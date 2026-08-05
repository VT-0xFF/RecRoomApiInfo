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
using Photon.Realtime;
using Photon.Voice.PUN;
using Unity.Netcode;
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
		[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2250", Offset = "0x5CE1050", VA = "0x185CE2250")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x789560", Offset = "0x788360", VA = "0x180789560")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7895A0", Offset = "0x7883A0", VA = "0x1807895A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PDOCGDMDGAF : KMNIEKHCFGH, OELPPNBPDEP, DBELOHHFHDL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class JGLHFLFMKCI : KMJOGKGGJGL
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class NFGLDNHGDNF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Action onCompleteCallback;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
			public NFGLDNHGDNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x55562C0", Offset = "0x55550C0", VA = "0x1855562C0")]
			internal void KKONNMOCDFD(MNGIIEMEPFG rh)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool ACHGHPAAMFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5CDDD00", Offset = "0x5CDCB00", VA = "0x185CDDD00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool JMEDLGICEJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5CDDAE0", Offset = "0x5CDC8E0", VA = "0x185CDDAE0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public IReadOnlyList<BNPOIDBDBPK> OGGHMGFNKDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5CDDBF0", Offset = "0x5CDC9F0", VA = "0x185CDDBF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD9C0", Offset = "0x5CDC7C0", VA = "0x185CDD9C0", Slot = "7")]
		public bool JNABFODHKAA(Action AJEANEILHFB, string KIEOKOALJLA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public JGLHFLFMKCI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private HGCDAMKECBP GCMAFEPGIMN;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly byte[] EBIIDPAMJEP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override bool MLNPDENGNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4E658C0", Offset = "0x4E646C0", VA = "0x184E658C0", Slot = "80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override HGCDAMKECBP EHELGFKHKJH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x760F30", Offset = "0x75FD30", VA = "0x180760F30", Slot = "81")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override bool CPAENKHMDEO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CE4D50", Offset = "0x5CE3B50", VA = "0x185CE4D50", Slot = "82")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override bool DPJAOLLJGGO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CE54F0", Offset = "0x5CE42F0", VA = "0x185CE54F0", Slot = "60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5CE4910", Offset = "0x5CE3710", VA = "0x185CE4910", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override float NFCHIBIBLHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5CE4500", Offset = "0x5CE3300", VA = "0x185CE4500", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override KMJOGKGGJGL LNCCABMFKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x767970", Offset = "0x766770", VA = "0x180767970", Slot = "77")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override bool HKMPKNOLCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5CE4430", Offset = "0x5CE3230", VA = "0x185CE4430", Slot = "83")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5CE4D90", Offset = "0x5CE3B90", VA = "0x185CE4D90", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override bool EGPFPLHBBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5CE4270", Offset = "0x5CE3070", VA = "0x185CE4270", Slot = "85")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool FBHGHHDBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5CE4D10", Offset = "0x5CE3B10", VA = "0x185CE4D10", Slot = "86")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override PDAHEEDKKPC JCFMJLLKKLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5CE50C0", Offset = "0x5CE3EC0", VA = "0x185CE50C0", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool ANBHICOAKKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5CE4FF0", Offset = "0x5CE3DF0", VA = "0x185CE4FF0", Slot = "76")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override int KGGOBHDFKHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5CE5480", Offset = "0x5CE4280", VA = "0x185CE5480", Slot = "63")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override int MIHCAFJJJED
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5CE5390", Offset = "0x5CE4190", VA = "0x185CE5390", Slot = "64")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override OOAELAJMHEN LLMPEMBMOEB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5CE4CD0", Offset = "0x5CE3AD0", VA = "0x185CE4CD0", Slot = "65")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public override int CDGDKGKOPPD
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5CE43D0", Offset = "0x5CE31D0", VA = "0x185CE43D0", Slot = "66")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public override int MFEBOHIBMLH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5CE5210", Offset = "0x5CE4010", VA = "0x185CE5210", Slot = "67")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public override event PAKICLDJOFH APJKBKIMPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5CE4960", Offset = "0x5CE3760", VA = "0x185CE4960", Slot = "56")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5CE5580", Offset = "0x5CE4380", VA = "0x185CE5580", Slot = "57")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public override event Action<OOAELAJMHEN> AIJOBBJGGON
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5CE4E90", Offset = "0x5CE3C90", VA = "0x185CE4E90", Slot = "58")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5CE4F40", Offset = "0x5CE3D40", VA = "0x185CE4F40", Slot = "59")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public override event Action<HGCDAMKECBP, HGCDAMKECBP> LLMIDFLHJJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5CE52E0", Offset = "0x5CE40E0", VA = "0x185CE52E0", Slot = "78")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5CE4DE0", Offset = "0x5CE3BE0", VA = "0x185CE4DE0", Slot = "79")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5CE4A00", Offset = "0x5CE3800", VA = "0x185CE4A00", Slot = "90")]
	public override void FIBHGCIMFCK(CAGBENJDHMI AJLFAPKIPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5CE5110", Offset = "0x5CE3F10", VA = "0x185CE5110")]
	[DJDJPHIPNFL(IEJLPKKICHC.GameOnly)]
	private static void LKBEDIJGOEL(NNIGDKDCOBN LAJBGPNDGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5CE5690", Offset = "0x5CE4490", VA = "0x185CE5690")]
	[Preserve]
	public PDOCGDMDGAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5CE4890", Offset = "0x5CE3690", VA = "0x185CE4890")]
	private void FBJMDLEJEML(bool COFIMPDPBNH, bool PDJOKOKAHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5CE42C0", Offset = "0x5CE30C0", VA = "0x185CE42C0", Slot = "68")]
	[CanBeNull]
	public override OOAELAJMHEN AINNFHKEFCF(int PABDGEBBIBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5CE4AD0", Offset = "0x5CE38D0", VA = "0x185CE4AD0")]
	private static short GCOHICOJGPA(StreamBuffer CLGAAHAEFGG, object HJNDJNFLIMN)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5CE46F0", Offset = "0x5CE34F0", VA = "0x185CE46F0")]
	private static object EHDABEEOLFM(StreamBuffer NKMIMHKKOKJ, short JGMNJBPPKGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5CE4550", Offset = "0x5CE3350", VA = "0x185CE4550", Slot = "100")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5CE4380", Offset = "0x5CE3180", VA = "0x185CE4380", Slot = "69")]
	public override bool AJNHEGPCAOC(AppSettings HDLBMNNAINO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5CE5280", Offset = "0x5CE4080", VA = "0x185CE5280", Slot = "70")]
	public override void MKDIBJNBIGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5CE4B80", Offset = "0x5CE3980", VA = "0x185CE4B80", Slot = "71")]
	public override bool GDECDIKEKMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5CE44C0", Offset = "0x5CE32C0", VA = "0x185CE44C0", Slot = "72")]
	public override void CKGNOAGFOHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5CE5040", Offset = "0x5CE3E40", VA = "0x185CE5040", Slot = "73")]
	public override bool LBBCBLNHCFG(byte GNKJGLJIIJH, Hashtable DNAMLLBGHHA, AGPMIFJKDDP CIALPGDDHBE, SendOptions IHPJKGMNCHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5CE4680", Offset = "0x5CE3480", VA = "0x185CE4680", Slot = "88")]
	public override bool ECHNLDKNPME(string HPBJPDKIDPE, MGLCHIMGADM NCMINEJFBNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5CE4170", Offset = "0x5CE2F70", VA = "0x185CE4170", Slot = "89")]
	public override void ACDPGOAJIAN(string KCEOMBKKHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5CE5400", Offset = "0x5CE4200", VA = "0x185CE5400", Slot = "93")]
	public void OnEvent(EventData ABFECFBJIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "94")]
	public void OnPlayerEnteredRoom(JMPALGNIPNO KALDEEADPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "95")]
	public void OnPlayerWillLeaveRoom(JMPALGNIPNO HNBCKDGEIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "96")]
	public void OnPlayerLeftRoom(JMPALGNIPNO HNBCKDGEIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "97")]
	public void OnRoomPropertiesUpdate(Hashtable PJDFMFNGOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "98")]
	public void OnPlayerPropertiesUpdate(JMPALGNIPNO BFCPCPBMIGC, Hashtable EFKNLFOHLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5CE52C0", Offset = "0x5CE40C0", VA = "0x185CE52C0", Slot = "99")]
	private void MMFCNALOJKJ(JMPALGNIPNO FBJINAHELDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface LGOLNFIHLPG : DGPCKDMJJKC, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DGPCKDMJJKC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	MOBHIPAGCOJ MNHCBHDINAN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string DEOLBJJDEEL
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Task ONJGMNHMFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KLHLNNMHEEF(MOBHIPAGCOJ DIOGLLFIIPP);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task MKDIBJNBIGK([Optional] CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<MOBHIPAGCOJ> FIGABPCBDMP(MOBHIPAGCOJ DIOGLLFIIPP, object KHNGAKEPNEA, [Optional] CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task LIOEINPGGIG([Optional] CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EIELLPDPOGG(OFODIMJAHFB ECICBMCJDEP);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface FBEAEALEIKO
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLOOMPLKPPB(ushort FEHJOCNBCFO, LNPEIHGEIKD LEOAIEKGKLA, params object[] FLNELCEKEBP);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal enum LNPEIHGEIKD
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Disconnect,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Disconnect_AlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Disconnect_AlreadyDisconnected,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	DisconnectInternal,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	DisconnectInternalTask,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	DisconnectInternal_NothingToDo,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DisconnectFromRoomInstance,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	DisconnectFromRoomInstanceInternal,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	DisconnectFromRoomInstance_LeavingAlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	DisconnectFromRoomInstance_AlreadyLeftRoom,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	DisconnectFromRoomInstanceInternal_BeforeLeaveRoom,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	DisconnectFromRoomInstanceInternal_AfterLeaveRoom,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	DisconnectFromRoomInstanceInternal_LeaveRoom,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	DisconnectFromRoomInstanceInternal_NothingToDo,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	ConnectToRegion,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	ConnectToRegion_AddedAuthValues,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	ConnectToRegion_ConnectToRegionInternal,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	ConnectToRegion_ConnectToRegionInternalTask,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	ConnectToRegion_EnteredOfflineMode,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	ConnectToRegion_ConnectionAlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	ConnectToRegion_AlreadyConnected,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	ConnectToRegion_DisconnectDueToCancellation,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	ConnectToRegion_DisconnectDueToError,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	ConnectToRegion_Connected,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	ConnectWithAppSettings,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	ConnectToRoomInstance,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ConnectToRoomInstance_ConnectionAlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	ConnectToRoomInstance_AlreadyInRoom,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	ConnectToRoomInstanceInternal,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	ConnectToRoomInstanceInternal_Connected
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JDLCCAPLPFA : DGPCKDMJJKC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	IJOKJANALOM FBDJCAIPPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IJOKJANALOM : LGOLNFIHLPG, DGPCKDMJJKC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyDictionary<string, int>> CAGBBJBAAGH([Optional] TimeSpan? GMCMOIJBADP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NNBECPGINFM
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool IIFOMLKDMPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool DDGAMJBFFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	TimeSpan OPJAAOAKEIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	TimeSpan GELLEFBGFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AppSettings OOAPLKOJMEG(NJBIFAJACNK LBJMKDMJBEB);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PDAHEEDKKPC LJBGFMLPMBN(NJBIFAJACNK LBJMKDMJBEB);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<NJBIFAJACNK> NPGKFCHJGFI(CancellationToken BCCDJHNACKO);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PBAOADFKDLD : NAKCLDOIKNI, DBELOHHFHDL, IOMBJFMAGAP, BBKKABLKNPG, KHFLEINBDEO, FFJAJMNAKCE, KAJDLMHFMPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly string LLGFADGIKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public HJOHDOIHOEL DNKKHGLOPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public HJOHDOIHOEL PPNKPEBINBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public KAPCIBMFMEE<HAPBAMNGMLC> OGEHNENPFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public HJOHDOIHOEL FDDJODIGFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public KAPCIBMFMEE<string> MBNMAPEHMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public KAPCIBMFMEE<Dictionary<string, object>> IJHPLGMNMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public KAPCIBMFMEE<HAPBAMNGMLC> BLPDKBABJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public LOHPOAFOAMK<bool, bool> OKALLDFNJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public HJOHDOIHOEL FGPKMAOHODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public HJOHDOIHOEL FMMKNDKOOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public HJOHDOIHOEL OPAGAJIEFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public HJOHDOIHOEL LPECALGIFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public HJOHDOIHOEL JEKOJJMIFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public KAPCIBMFMEE<JMPALGNIPNO> FPIGOOMKDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public LOHPOAFOAMK<PhotonView, JMPALGNIPNO> EJOCIFNBOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public ALHAAKPBCNN<PhotonView, JMPALGNIPNO, JMPALGNIPNO> KMBKOIBHAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public LOHPOAFOAMK<short, string> EIHKLECDHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public KAPCIBMFMEE<Hashtable> ADJKIAHNNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public KAPCIBMFMEE<HEJHIKFMFIE> OCNCEDLMHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public LOHPOAFOAMK<short, string> HMHPAAOOJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public HJOHDOIHOEL DHKLKINOAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public KAPCIBMFMEE<JMPALGNIPNO> NDHKBEFMCEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public KAPCIBMFMEE<JMPALGNIPNO> KICMBFBFEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public LOHPOAFOAMK<JMPALGNIPNO, Hashtable> OGCOIDDLFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public LOHPOAFOAMK<short, string> OLGBMOHMBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public HJOHDOIHOEL ECOBNHBKDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public HJOHDOIHOEL KEHINNOMGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public KAPCIBMFMEE<OperationResponse> GKNHHILCAID;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5CE34B0", Offset = "0x5CE22B0", VA = "0x185CE34B0", Slot = "31")]
	public virtual void OnDisconnected(HAPBAMNGMLC PFKGBLPNLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5C4D4D0", Offset = "0x5C4C2D0", VA = "0x185C4D4D0", Slot = "4")]
	public void OnConnected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3360", Offset = "0x5CE2160", VA = "0x185CE3360", Slot = "5")]
	public void OnConnectedToMaster()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "7")]
	public void OnRegionListReceived(MNGIIEMEPFG IPFIPKAJJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3460", Offset = "0x5CE2260", VA = "0x185CE3460", Slot = "8")]
	public void OnCustomAuthenticationResponse(Dictionary<string, object> LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3410", Offset = "0x5CE2210", VA = "0x185CE3410", Slot = "9")]
	public void OnCustomAuthenticationFailed(string IEOPAKELFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5CE36C0", Offset = "0x5CE24C0", VA = "0x185CE36C0", Slot = "10")]
	public void OnPlayerEnteredRoom(JMPALGNIPNO KALDEEADPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "11")]
	public void OnPlayerWillLeaveRoom(JMPALGNIPNO HNBCKDGEIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3720", Offset = "0x5CE2520", VA = "0x185CE3720", Slot = "12")]
	public void OnPlayerLeftRoom(JMPALGNIPNO HNBCKDGEIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3810", Offset = "0x5CE2610", VA = "0x185CE3810", Slot = "13")]
	public void OnRoomPropertiesUpdate(Hashtable PJDFMFNGOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3780", Offset = "0x5CE2580", VA = "0x185CE3780", Slot = "14")]
	public void OnPlayerPropertiesUpdate(JMPALGNIPNO BFCPCPBMIGC, Hashtable EFKNLFOHLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3660", Offset = "0x5CE2460", VA = "0x185CE3660", Slot = "15")]
	public void OnMasterClientSwitched(JMPALGNIPNO FBJINAHELDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xAEF5D0", Offset = "0xAEE3D0", VA = "0x180AEF5D0", Slot = "16")]
	public void OnJoinedLobby()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xBCAA90", Offset = "0xBC9890", VA = "0x180BCAA90", Slot = "17")]
	public void OnLeftLobby()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5CE37F0", Offset = "0x5CE25F0", VA = "0x185CE37F0", Slot = "18")]
	public void OnRoomListUpdate(List<AOLAIPCLDMG> OBHBCDHBGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3640", Offset = "0x5CE2440", VA = "0x185CE3640", Slot = "19")]
	public void OnLobbyStatisticsUpdate(List<DHEKFBMPHCH> OBGPLALMCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3540", Offset = "0x5CE2340", VA = "0x185CE3540", Slot = "20")]
	public void OnFriendListUpdate(List<FFDIGMBMAJH> MKPINCICKBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5CE33F0", Offset = "0x5CE21F0", VA = "0x185CE33F0", Slot = "21")]
	public void OnCreatedRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3380", Offset = "0x5CE2180", VA = "0x185CE3380", Slot = "22")]
	public void OnCreateRoomFailed(short CMNANEFIAGK, string BLAOEBOMGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xBC02F0", Offset = "0xBBF0F0", VA = "0x180BC02F0", Slot = "23")]
	public void OnJoinedRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5CE35D0", Offset = "0x5CE23D0", VA = "0x185CE35D0", Slot = "24")]
	public void OnJoinRoomFailed(short CMNANEFIAGK, string BLAOEBOMGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3560", Offset = "0x5CE2360", VA = "0x185CE3560", Slot = "25")]
	public void OnJoinRandomFailed(short CMNANEFIAGK, string BLAOEBOMGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xD64170", Offset = "0xD62F70", VA = "0x180D64170", Slot = "26")]
	public void OnLeftRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3280", Offset = "0x5CE2080", VA = "0x185CE3280", Slot = "30")]
	public void DDLKHOHINFP(HEJHIKFMFIE NIKGGMJCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5CE32F0", Offset = "0x5CE20F0", VA = "0x185CE32F0", Slot = "27")]
	public void LEIDEPACEOC(PhotonView OANBEMKCPEG, JMPALGNIPNO OLFOGNLCBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5CE31F0", Offset = "0x5CE1FF0", VA = "0x185CE31F0", Slot = "28")]
	public void CNGIIAIJLDM(PhotonView OANBEMKCPEG, JMPALGNIPNO ACCIPDFAEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3870", Offset = "0x5CE2670", VA = "0x185CE3870", Slot = "29")]
	public void OnWebRpcResponse(OperationResponse NBJDKPJPFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5CE38D0", Offset = "0x5CE26D0", VA = "0x185CE38D0")]
	public PBAOADFKDLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal static class MGEFIIBMDOB
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class ACFKFDKFEDF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Action<string, AGAJEBLOFKP> log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public HGCDAMKECBP networkClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool region;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public GOJPGIHGGLJ photonCallbacks;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public ACFKFDKFEDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x343C7E0", Offset = "0x343B5E0", VA = "0x18343C7E0")]
		internal void CEJMLKPJEEL(HAPBAMNGMLC disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x343CA80", Offset = "0x343B880", VA = "0x18343CA80")]
		internal void ECAEGBGFCHA(string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x343CB20", Offset = "0x343B920", VA = "0x18343CB20")]
		internal void GMEEIKFIJMG(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class LDKJOFPAGOM<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public PBAOADFKDLD photonCallbacks;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public LDKJOFPAGOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x397A540", Offset = "0x3979340", VA = "0x18397A540")]
		internal void PMEJPDDPNBG(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x397A490", Offset = "0x3979290", VA = "0x18397A490")]
		internal void FBGDCLKNGDP(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x397A2A0", Offset = "0x39790A0", VA = "0x18397A2A0")]
		internal void EJNBBDNFPLJ(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x247DA30", Offset = "0x247C830", VA = "0x18247DA30")]
	public static void GDHEFCCDHNI<T>(this GOJPGIHGGLJ CNMENKFDJKN, TaskCompletionSource<T> AIJCFMOLNKB, [NotNull] HGCDAMKECBP EKACDDKHNNM, AGAJEBLOFKP AIBCCLHKNFH, bool MIOKGJBOHDE, Action<string, AGAJEBLOFKP> DFCBIKLJFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x247E030", Offset = "0x247CE30", VA = "0x18247E030")]
	public static void PMGAPHJKLPA<T>(this PBAOADFKDLD CNMENKFDJKN, TaskCompletionSource<T> AIJCFMOLNKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class KKBDBNPNBDP<TNetworking> : LGOLNFIHLPG, DGPCKDMJJKC, IDisposable where TNetworking : class, GHPAKEJIMOP, MPMELMHFGFE
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class GELEBMBPOHD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private struct <<ConnectToRegionInternal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AsyncTaskMethodBuilder<NJBIFAJACNK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public GELEBMBPOHD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private TaskAwaiter<NJBIFAJACNK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x2EB4290", Offset = "0x2EB3090", VA = "0x182EB4290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2EB4600", Offset = "0x2EB3400", VA = "0x182EB4600", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NJBIFAJACNK photonServerConnectionInfo;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public GELEBMBPOHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3485980", Offset = "0x3484780", VA = "0x183485980")]
		[AsyncStateMachine(typeof(KKBDBNPNBDP<>.GELEBMBPOHD.<<ConnectToRegionInternal>b__0>d))]
		internal Task<NJBIFAJACNK> LINHMBOHLIG(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct LCEHAKODEEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AsyncTaskMethodBuilder<NJBIFAJACNK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NJBIFAJACNK photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private GELEBMBPOHD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter<NJBIFAJACNK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3976FE0", Offset = "0x3975DE0", VA = "0x183976FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3977BD0", Offset = "0x39769D0", VA = "0x183977BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct LEMHGAHLJDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder<NJBIFAJACNK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public NJBIFAJACNK photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x397B720", Offset = "0x397A520", VA = "0x18397B720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x397C3F0", Offset = "0x397B1F0", VA = "0x18397C3F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct MLJEPOEIHPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x3B8C9D0", Offset = "0x3B8B7D0", VA = "0x183B8C9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3B8CC20", Offset = "0x3B8BA20", VA = "0x183B8CC20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct GPHLLKHELBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private AGAJEBLOFKP <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3541190", Offset = "0x353FF90", VA = "0x183541190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x35416B0", Offset = "0x35404B0", VA = "0x1835416B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class JDBMPAMDKFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public JDBMPAMDKFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x38345C0", Offset = "0x38333C0", VA = "0x1838345C0")]
		internal Task<bool> GIIOMKGNONI(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct OKJLLHFBFOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private JDBMPAMDKFP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool <isCurrentlyOfflineMode>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3CDA4D0", Offset = "0x3CD92D0", VA = "0x183CDA4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3CDB2F0", Offset = "0x3CDA0F0", VA = "0x183CDB2F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class DAOBAPPDIJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public TaskCompletionSource<HAPBAMNGMLC> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public DAOBAPPDIJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4C40AC0", Offset = "0x4C3F8C0", VA = "0x184C40AC0")]
		internal void NMDNDOFNCCK(HAPBAMNGMLC disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4C409F0", Offset = "0x4C3F7F0", VA = "0x184C409F0")]
		internal void KKBNEJAAFKD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct JJHKHMMJIAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private DAOBAPPDIJK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<HAPBAMNGMLC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3855670", Offset = "0x3854470", VA = "0x183855670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3856C00", Offset = "0x3855A00", VA = "0x183856C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct JLIGBEFOPPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<MOBHIPAGCOJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public MOBHIPAGCOJ targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private AGAJEBLOFKP <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<MOBHIPAGCOJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x385C5A0", Offset = "0x385B3A0", VA = "0x18385C5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x385D1C0", Offset = "0x385BFC0", VA = "0x18385D1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class NMBMLHOAANN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private struct <<ConnectToRoomInstanceInternal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public AsyncTaskMethodBuilder<MOBHIPAGCOJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public NMBMLHOAANN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private TaskAwaiter<MOBHIPAGCOJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x2EB4670", Offset = "0x2EB3470", VA = "0x182EB4670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x2EB49F0", Offset = "0x2EB37F0", VA = "0x182EB49F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public MOBHIPAGCOJ targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public object pauseToken;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public NMBMLHOAANN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3BF7210", Offset = "0x3BF6010", VA = "0x183BF7210")]
		[AsyncStateMachine(typeof(KKBDBNPNBDP<>.NMBMLHOAANN.<<ConnectToRoomInstanceInternal>b__0>d))]
		internal Task<MOBHIPAGCOJ> MGPFEIGPPMP(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct GDDEECIGHIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder<MOBHIPAGCOJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public MOBHIPAGCOJ targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private NMBMLHOAANN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter<MOBHIPAGCOJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x347F300", Offset = "0x347E100", VA = "0x18347F300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x34800A0", Offset = "0x347EEA0", VA = "0x1834800A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class CLOFOKHFIJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TaskCompletionSource<DLACGEKGFHA> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public CLOFOKHFIJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x4A34B10", Offset = "0x4A33910", VA = "0x184A34B10")]
		internal void PBNMPJGDGPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4A34A80", Offset = "0x4A33880", VA = "0x184A34A80")]
		internal void NPGNBILKLHM()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct NCLMIJNFADM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public AsyncTaskMethodBuilder<MOBHIPAGCOJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public MOBHIPAGCOJ targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private CLOFOKHFIJC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private MGLCHIMGADM <roomOptions>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private TaskAwaiter<NJBIFAJACNK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter<DLACGEKGFHA> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3BD1E60", Offset = "0x3BD0C60", VA = "0x183BD1E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3BD42A0", Offset = "0x3BD30A0", VA = "0x183BD42A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct KMMIAMBOIFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Task<OLCJMMAECFA> whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private TaskAwaiter<OLCJMMAECFA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x38CF790", Offset = "0x38CE590", VA = "0x1838CF790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x865C40", Offset = "0x864A40", VA = "0x180865C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct IKOFJJPALAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x36A3880", Offset = "0x36A2680", VA = "0x1836A3880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x36A3AC0", Offset = "0x36A28C0", VA = "0x1836A3AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct OACBGBPNBGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private AGAJEBLOFKP <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3040", Offset = "0x3CB1E40", VA = "0x183CB3040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3CB34D0", Offset = "0x3CB22D0", VA = "0x183CB34D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct LLKHDKECGJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x39940A0", Offset = "0x3992EA0", VA = "0x1839940A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3994860", Offset = "0x3993660", VA = "0x183994860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class HPNLMJEECHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public HPNLMJEECHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x35EE360", Offset = "0x35ED160", VA = "0x1835EE360")]
		internal Task<OLCJMMAECFA> GNOHOBPBEHN(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct FLFLGHHCIJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private HPNLMJEECHM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private TaskAwaiter<OLCJMMAECFA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x33BF120", Offset = "0x33BDF20", VA = "0x1833BF120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x33BFC40", Offset = "0x33BEA40", VA = "0x1833BFC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class GMNJLALCFFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public TaskCompletionSource<DLACGEKGFHA> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public GMNJLALCFFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3538560", Offset = "0x3537360", VA = "0x183538560")]
		internal void BANCGKEAPJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x35385F0", Offset = "0x35373F0", VA = "0x1835385F0")]
		internal void MBCFMEOIIBE(HAPBAMNGMLC disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3538370", Offset = "0x3537170", VA = "0x183538370")]
		internal void AAIPENOKBJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class KAFOMDKDBKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TaskCompletionSource<DLACGEKGFHA> reconnectToMasterServerTcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public GMNJLALCFFF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public KAFOMDKDBKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x388EE80", Offset = "0x388DC80", VA = "0x18388EE80")]
		internal void HBNGBEMJHNI(HAPBAMNGMLC disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x388EF20", Offset = "0x388DD20", VA = "0x18388EF20")]
		internal void IFJKNNMCBCP()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct PJGJHNMHIIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public AsyncTaskMethodBuilder<OLCJMMAECFA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private GMNJLALCFFF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private KAFOMDKDBKH <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TaskAwaiter<DLACGEKGFHA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3DC6390", Offset = "0x3DC5190", VA = "0x183DC6390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3DC8460", Offset = "0x3DC7260", VA = "0x183DC8460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class HOEOPLCPNNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public TaskCompletionSource<DLACGEKGFHA> reconnectToMasterServerTcs;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public HOEOPLCPNNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x35EC280", Offset = "0x35EB080", VA = "0x1835EC280")]
		internal string AAIAPAMLMIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x35EC2F0", Offset = "0x35EB0F0", VA = "0x1835EC2F0")]
		internal void LMCCOKDEPOP(DLACGEKGFHA _1, DLACGEKGFHA _2)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct CDGOINFBBKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public AsyncTaskMethodBuilder<DLACGEKGFHA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private HOEOPLCPNNH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private TaskAwaiter<DLACGEKGFHA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x47807B0", Offset = "0x477F5B0", VA = "0x1847807B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x47814D0", Offset = "0x47802D0", VA = "0x1847814D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct MCGCONMEINF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3B5AB00", Offset = "0x3B59900", VA = "0x183B5AB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x865C40", Offset = "0x864A40", VA = "0x180865C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct GKBJHBLAMPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3527790", Offset = "0x3526590", VA = "0x183527790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3527B10", Offset = "0x3526910", VA = "0x183527B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct EAKLLMBHLAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public HAPBAMNGMLC disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private KAAPKEOJELL <exception>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3008640", Offset = "0x3007440", VA = "0x183008640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x865C40", Offset = "0x864A40", VA = "0x180865C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct AGEDPAIAJOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public HAPBAMNGMLC disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private HashSet<OFODIMJAHFB>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x345DCB0", Offset = "0x345CAB0", VA = "0x18345DCB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x345E6E0", Offset = "0x345D4E0", VA = "0x18345E6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct KLGJKFNBDBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private HashSet<DCDCGLLFDPI>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x38CE220", Offset = "0x38CD020", VA = "0x1838CE220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x38CE700", Offset = "0x38CD500", VA = "0x1838CE700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class EEEFPELEPNO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public string timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public EEEFPELEPNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
		internal string HNMOPGPKKIC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class LCINGHIEJIC<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public Dictionary<string, string> tcsTimeoutData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public GJHEBHGJGKI.JCLMMJLJNDF timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public LCINGHIEJIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x39794D0", Offset = "0x39782D0", VA = "0x1839794D0")]
		internal void MAGDHPEAPHD(string prefix, Dictionary<string, string> dict)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3978EB0", Offset = "0x3977CB0", VA = "0x183978EB0")]
		internal ALCDLCELFFH AEFLKLLLLDJ(TimeSpan timeoutTime)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class HPHIBNAAGBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public TaskCompletionSource<DLACGEKGFHA> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public HPHIBNAAGBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x35EE2D0", Offset = "0x35ED0D0", VA = "0x1835EE2D0")]
		internal void AEADIEOKEAM()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct GKMLNFMHELJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private HPHIBNAAGBM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public DLACGEKGFHA connectedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public AppSettings appSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private TaskAwaiter<DLACGEKGFHA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x352E3A0", Offset = "0x352D1A0", VA = "0x18352E3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x352F700", Offset = "0x352E500", VA = "0x18352F700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class IEGFHFHLCHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public IEGFHFHLCHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3676E50", Offset = "0x3675C50", VA = "0x183676E50")]
		internal object KIGNEKLCBBF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class HNMLJJIEIFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public HNMLJJIEIFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x35EBC40", Offset = "0x35EAA40", VA = "0x1835EBC40")]
		internal object MPHMBHEHKNP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class PKNLJLMOAJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public KKBDBNPNBDP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public PKNLJLMOAJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3DD1610", Offset = "0x3DD0410", VA = "0x183DD1610")]
		internal object LBFJMNDLEML()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly Hashtable BHKLPFJNLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly FBEAEALEIKO GPGPCGNKAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly MPCCDNFLFCD AJJLINFENBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected readonly string DKGMMFNPAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected readonly NNBECPGINFM OGODOGGIMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private TaskCompletionSource<OLCJMMAECFA> PGDIALAODHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[NotNull]
	public readonly GOJPGIHGGLJ BBMKEFEDBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected internal readonly TNetworking GJDPBDOIJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private ushort OKKBIDDIPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private GPKLDBPCDDM<NJBIFAJACNK> IAHCLMEEHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private GPKLDBPCDDM<bool> JDHHKJKOOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private GPKLDBPCDDM<MOBHIPAGCOJ> DKNNEJKFKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private GPKLDBPCDDM<OLCJMMAECFA> GLMFPEDCEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool KJHCKIMKLNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private bool CMCFMLNCLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly HashSet<DCDCGLLFDPI> GKPOBJPLHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly HashSet<OFODIMJAHFB> EOPHLCOOFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private bool ICPHJFMOKBC;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool FBHGHHDBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x38C4BF0", Offset = "0x38C39F0", VA = "0x1838C4BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	[CanBeNull]
	public MOBHIPAGCOJ MNHCBHDINAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x38C51D0", Offset = "0x38C3FD0", VA = "0x1838C51D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	protected DLACGEKGFHA FLKEGKMABGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x38C3F20", Offset = "0x38C2D20", VA = "0x1838C3F20")]
		get
		{
			return default(DLACGEKGFHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	[CanBeNull]
	public string DEOLBJJDEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x38C3670", Offset = "0x38C2470", VA = "0x1838C3670", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private TimeSpan OPJAAOAKEIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x38C4ED0", Offset = "0x38C3CD0", VA = "0x1838C4ED0")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private TimeSpan GELLEFBGFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x38C3420", Offset = "0x38C2220", VA = "0x1838C3420")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public Task ONJGMNHMFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x38C4E40", Offset = "0x38C3C40", VA = "0x1838C4E40", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract bool KLHLNNMHEEF(MOBHIPAGCOJ DIOGLLFIIPP);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x38C4040", Offset = "0x38C2E40", VA = "0x1838C4040")]
	private static TimeSpan EAJJHBGAIDD(TimeSpan KMCHOJJBIAF, string MEBBBIMBIJO)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x38C6640", Offset = "0x38C5440", VA = "0x1838C6640")]
	protected KKBDBNPNBDP(TNetworking JDIFANIOFLI, NNBECPGINFM HDLGJJMCIOD, string LLGFADGIKAL, MPCCDNFLFCD AJJLINFENBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x38C6680", Offset = "0x38C5480", VA = "0x1838C6680")]
	internal KKBDBNPNBDP(TNetworking JDIFANIOFLI, NNBECPGINFM HDLGJJMCIOD, string LLGFADGIKAL, MPCCDNFLFCD AJJLINFENBB, [Optional] FBEAEALEIKO GPGPCGNKAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x38C6250", Offset = "0x38C5050", VA = "0x1838C6250")]
	private void OEGOBKBFJJG(bool KNIBDNLMNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x38C4990", Offset = "0x38C3790", VA = "0x1838C4990")]
	private void GDPDMFPIHJH(DLACGEKGFHA DHIHNODHBIG, DLACGEKGFHA ALMPBAEOOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x38C3BB0", Offset = "0x38C29B0", VA = "0x1838C3BB0")]
	internal AGAJEBLOFKP BNBMCFEJDOF()
	{
		return default(AGAJEBLOFKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x38C5330", Offset = "0x38C4130", VA = "0x1838C5330")]
	[AsyncStateMachine(typeof(KKBDBNPNBDP<>.LCEHAKODEEH))]
	private Task<NJBIFAJACNK> LMHGFIIEFOH(AGAJEBLOFKP AIBCCLHKNFH, NJBIFAJACNK LBJMKDMJBEB, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x38C34F0", Offset = "0x38C22F0", VA = "0x1838C34F0")]
	[AsyncStateMachine(typeof(KKBDBNPNBDP<>.LEMHGAHLJDJ))]
	protected Task<NJBIFAJACNK> AEOEOEMFPCN(AGAJEBLOFKP AIBCCLHKNFH, NJBIFAJACNK LBJMKDMJBEB, CancellationToken ANLCEFCEDEM, CancellationToken KLGBFDEKLMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x38C6340", Offset = "0x38C5140", VA = "0x1838C6340")]
	[AsyncStateMachine(typeof(KKBDBNPNBDP<>.MLJEPOEIHPA))]
	protected Task OOBMBLCJDHN(AGAJEBLOFKP AIBCCLHKNFH, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x38C5C60", Offset = "0x38C4A60", VA = "0x1838C5C60", Slot = "7")]
	[AsyncStateMachine(typeof(KKBDBNPNBDP<>.GPHLLKHELBL))]
	public Task MKDIBJNBIGK([Optional] CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x38C4D00", Offset = "0x38C3B00", VA = "0x1838C4D00")]
	[AsyncStateMachine(typeof(KKBDBNPNBDP<>.OKJLLHFBFOG))]
	private Task JJEGJNMLKIB(AGAJEBLOFKP AIBCCLHKNFH, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x38C57E0", Offset = "0x38C45E0", VA = "0x1838C57E0")]
	[AsyncStateMachine(typeof(KKBDBNPNBDP<>.JJHKHMMJIAC))]
	private Task<bool> MECDBECMOEB(AGAJEBLOFKP AIBCCLHKNFH, CancellationToken EKDHBKMFLGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x38C4520", Offset = "0x38C3320", VA = "0x1838C4520", Slot = "8")]
	[AsyncStateMachine(typeof(KKBDBNPNBDP<>.JLIGBEFOPPE))]
	public Task<MOBHIPAGCOJ> FIGABPCBDMP(MOBHIPAGCOJ DIOGLLFIIPP, object KHNGAKEPNEA, [Optional] CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x38C4240", Offset = "0x38C3040", VA = "0x1838C4240")]
	[AsyncStateMachine(typeof(KKBDBNPNBDP<>.GDDEECIGHIF))]
	private Task<MOBHIPAGCOJ> FCPKKNNEFLO(AGAJEBLOFKP AIBCCLHKNFH, MOBHIPAGCOJ DIOGLLFIIPP, object KHNGAKEPNEA, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x38C36D0", Offset = "0x38C24D0", VA = "0x1838C36D0")]
	[AsyncStateMachine(typeof(KKBDBNPNBDP<>.NCLMIJNFADM))]
	private Task<MOBHIPAGCOJ> AOLMAJENBJL(AGAJEBLOFKP AIBCCLHKNFH, MOBHIPAGCOJ DIOGLLFIIPP, object KHNGAKEPNEA, CancellationToken ANLCEFCEDEM, CancellationToken KLGBFDEKLMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x38C4FA0", Offset = "0x38C3DA0", VA = "0x1838C4FA0")]
	[AsyncStateMachine(typeof(KKBDBNPNBDP<>.KMMIAMBOIFJ))]
	private void KMIOBPPGGJP(Task<OLCJMMAECFA> JECGEGLELEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x38C5D70", Offset = "0x38C4B70", VA = "0x1838C5D70")]
	[AsyncStateMachine(typeof(KKBDBNPNBDP<>.IKOFJJPALAD))]
	private Task NDFMKGCLLKA(AGAJEBLOFKP AIBCCLHKNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x38C5220", Offset = "0x38C4020", VA = "0x1838C5220", Slot = "9")]
	[AsyncStateMachine(typeof(KKBDBNPNBDP<>.OACBGBPNBGN))]
	public Task LIOEINPGGIG([Optional] CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x38C5940", Offset = "0x38C4740", VA = "0x1838C5940")]
	[AsyncStateMachine(typeof(KKBDBNPNBDP<>.LLKHDKECGJB))]
	private Task MELEKJNEGNC(AGAJEBLOFKP AIBCCLHKNFH, [Optional] CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x38C5080", Offset = "0x38C3E80", VA = "0x1838C5080")]
	[AsyncStateMachine(typeof(KKBDBNPNBDP<>.FLFLGHHCIJA))]
	private Task LBIOPOOKGCD(AGAJEBLOFKP AIBCCLHKNFH, [Optional] CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x38C4A80", Offset = "0x38C3880", VA = "0x1838C4A80")]
	[AsyncStateMachine(typeof(KKBDBNPNBDP<>.PJGJHNMHIIN))]
	private Task<OLCJMMAECFA> GPLHMICLANF(AGAJEBLOFKP AIBCCLHKNFH, CancellationToken ANLCEFCEDEM, CancellationToken KLGBFDEKLMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x38C5EA0", Offset = "0x38C4CA0", VA = "0x1838C5EA0")]
	[AsyncStateMachine(typeof(KKBDBNPNBDP<>.CDGOINFBBKP))]
	private Task<DLACGEKGFHA> NIOLBEKJIGI(AGAJEBLOFKP AIBCCLHKNFH, CancellationToken BCCDJHNACKO, string IPGJPNDBCJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x38C4C60", Offset = "0x38C3A60", VA = "0x1838C4C60", Slot = "14")]
	protected virtual void IIFMMGFHAPE(AGAJEBLOFKP AIBCCLHKNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x38C55A0", Offset = "0x38C43A0", VA = "0x1838C55A0", Slot = "15")]
	protected virtual void LOAGEFFBNML(AGAJEBLOFKP AIBCCLHKNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x38C4680", Offset = "0x38C3480", VA = "0x1838C4680")]
	private void FLOOMPLKPPB(AGAJEBLOFKP AIBCCLHKNFH, LNPEIHGEIKD IPGJPNDBCJD, params object[] MEALCFKPKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "16")]
	protected virtual void KENJKGJDBBH(MOBHIPAGCOJ LFCPOOEIEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x38C6010", Offset = "0x38C4E10", VA = "0x1838C6010")]
	[AsyncStateMachine(typeof(KKBDBNPNBDP<>.MCGCONMEINF))]
	private void OAHJENDHMKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x38C5A90", Offset = "0x38C4890", VA = "0x1838C5A90")]
	[AsyncStateMachine(typeof(KKBDBNPNBDP<>.GKBJHBLAMPA))]
	private Task MGLPKBJECDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x38C3E60", Offset = "0x38C2C60", VA = "0x1838C3E60")]
	[AsyncStateMachine(typeof(KKBDBNPNBDP<>.EAKLLMBHLAJ))]
	private void CBCBBDACODE(HAPBAMNGMLC LLEMHCHJLME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x38C54A0", Offset = "0x38C42A0", VA = "0x1838C54A0")]
	[AsyncStateMachine(typeof(KKBDBNPNBDP<>.AGEDPAIAJOD))]
	private Task LMNJGJHPHHN(HAPBAMNGMLC LLEMHCHJLME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x38C5B70", Offset = "0x38C4970", VA = "0x1838C5B70")]
	[AsyncStateMachine(typeof(KKBDBNPNBDP<>.KLGJKFNBDBD))]
	private Task MJJIDJKKEGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x38C41E0", Offset = "0x38C2FE0", VA = "0x1838C41E0", Slot = "10")]
	public void EIELLPDPOGG(OFODIMJAHFB ECICBMCJDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x22AC210", Offset = "0x22AB010", VA = "0x1822AC210")]
	private TaskCompletionSource<T> GHNDOJOALPH<T>(AGAJEBLOFKP AIBCCLHKNFH, CancellationToken BCCDJHNACKO, TimeSpan PNDCNOOMJCC, string OPDHKNPMMLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x22AC350", Offset = "0x22AB150", VA = "0x1822AC350")]
	private TaskCompletionSource<T> GHNDOJOALPH<T>(AGAJEBLOFKP AIBCCLHKNFH, CancellationToken BCCDJHNACKO, TimeSpan PNDCNOOMJCC, GJHEBHGJGKI.JCLMMJLJNDF OPDHKNPMMLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x38C43C0", Offset = "0x38C31C0", VA = "0x1838C43C0")]
	[AsyncStateMachine(typeof(KKBDBNPNBDP<>.GKMLNFMHELJ))]
	protected Task FFMBEHAKBMI(AGAJEBLOFKP AIBCCLHKNFH, AppSettings HDLBMNNAINO, DLACGEKGFHA ANFPNMIIJLE, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x38C3F90", Offset = "0x38C2D90", VA = "0x1838C3F90", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x38C3870", Offset = "0x38C2670", VA = "0x1838C3870", Slot = "17")]
	protected virtual void BKJCMOABEJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x38C5060", Offset = "0x38C3E60", VA = "0x1838C5060")]
	private static string LACDONFIGLD(AGAJEBLOFKP AIBCCLHKNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	protected void BPAIBICBBJL(string BLAOEBOMGGP, [Optional] AGAJEBLOFKP AIBCCLHKNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x38C60C0", Offset = "0x38C4EC0", VA = "0x1838C60C0")]
	protected void OEGGIANHCJN(string BLAOEBOMGGP, [Optional] AGAJEBLOFKP AIBCCLHKNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x38C3C00", Offset = "0x38C2A00", VA = "0x1838C3C00")]
	protected void BNJKOEGGPFA(string BLAOEBOMGGP, [Optional] AGAJEBLOFKP AIBCCLHKNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x38C5640", Offset = "0x38C4440", VA = "0x1838C5640")]
	protected void LPIFGLLPDKC(string BLAOEBOMGGP, Exception GLNCBNFNGKL, [Optional] AGAJEBLOFKP AIBCCLHKNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x38C3D90", Offset = "0x38C2B90", VA = "0x1838C3D90")]
	public void BPNCMMJBDCH(CAGBENJDHMI BAJKCAFEDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x38C47E0", Offset = "0x38C35E0", VA = "0x1838C47E0")]
	[CompilerGenerated]
	private void FODKMLNCOBI(HGCDAMKECBP JHKFMIIDOLO, HGCDAMKECBP IAFINMOOAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x22AC890", Offset = "0x22AB690", VA = "0x1822AC890")]
	[CompilerGenerated]
	internal static string PJCLKPAJJEA<T>(TimeSpan GBDFPJALKBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct AGAJEBLOFKP : IEquatable<AGAJEBLOFKP>, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public readonly ushort BNANLGLKNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public readonly string DKGMMFNPAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly GHPAKEJIMOP JDIFANIOFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly Stopwatch FBGMOHLMACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly List<(TimeSpan, DLACGEKGFHA, DLACGEKGFHA)> JOELFOFLMFF;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public TimeSpan ICOANLNJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5CD7BA0", Offset = "0x5CD69A0", VA = "0x185CD7BA0")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IReadOnlyList<(TimeSpan time, DLACGEKGFHA oldState, DLACGEKGFHA newState)> JDHCGDBEBNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7BE0", Offset = "0x5CD69E0", VA = "0x185CD7BE0")]
	public AGAJEBLOFKP(ushort FEHJOCNBCFO, string LLGFADGIKAL, GHPAKEJIMOP JDIFANIOFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7A90", Offset = "0x5CD6890", VA = "0x185CD7A90")]
	private void IOBDOIHFAEP(DLACGEKGFHA DHIHNODHBIG, DLACGEKGFHA ALMPBAEOOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7A60", Offset = "0x5CD6860", VA = "0x185CD7A60", Slot = "4")]
	public bool Equals(AGAJEBLOFKP LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5CD79D0", Offset = "0x5CD67D0", VA = "0x185CD79D0", Slot = "0")]
	public override bool Equals(object DGPHOMINFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7A70", Offset = "0x5CD6870", VA = "0x185CD7A70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7BC0", Offset = "0x5CD69C0", VA = "0x185CD7BC0")]
	public static bool PNFEPLLEJJK(AGAJEBLOFKP NLBDNIEIKMB, AGAJEBLOFKP NFFCMKPCJPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7880", Offset = "0x5CD6680", VA = "0x185CD7880", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal static class EOBEBILGHMB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct DKFJLBCIDGC<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public GPKLDBPCDDM<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public AGAJEBLOFKP doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4C809C0", Offset = "0x4C7F7C0", VA = "0x184C809C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4C80EC0", Offset = "0x4C7FCC0", VA = "0x184C80EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct KCFCJCEKMGD<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public GPKLDBPCDDM<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public TimeSpan forceCancelTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public AGAJEBLOFKP doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x3895E30", Offset = "0x3894C30", VA = "0x183895E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3896080", Offset = "0x3894E80", VA = "0x183896080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct MGDFDDLHLHF<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public GPKLDBPCDDM<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public CancellationToken newToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private CancellationTokenRegistration? <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x3B652E0", Offset = "0x3B640E0", VA = "0x183B652E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3B65840", Offset = "0x3B64640", VA = "0x183B65840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x224FAF0", Offset = "0x224E8F0", VA = "0x18224FAF0")]
	[AsyncStateMachine(typeof(DKFJLBCIDGC<>))]
	public static Task EFAPADCDKPK<TArgs>(this GPKLDBPCDDM<TArgs> MCMANCJPHMK, [Optional] AGAJEBLOFKP MFBJPPAEJKF) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x224F890", Offset = "0x224E690", VA = "0x18224F890")]
	[AsyncStateMachine(typeof(KCFCJCEKMGD<>))]
	public static Task BDMBCEGNKOL<TArgs>(this GPKLDBPCDDM<TArgs> MCMANCJPHMK, TimeSpan CKIJJAHOAEA, [Optional] AGAJEBLOFKP MFBJPPAEJKF) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2250180", Offset = "0x224EF80", VA = "0x182250180")]
	public static (bool, bool) GDLMHMIMIOC<TArgs>(this GPKLDBPCDDM<TArgs> MCMANCJPHMK, TArgs PABBJIBBIGE, [Out] string HIEEIODHCMA) where TArgs : IEquatable<TArgs>
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x224FE50", Offset = "0x224EC50", VA = "0x18224FE50")]
	[AsyncStateMachine(typeof(MGDFDDLHLHF<>))]
	public static Task<TArgs> FOMAAKOFDDL<TArgs>(this GPKLDBPCDDM<TArgs> MCMANCJPHMK, TArgs PABBJIBBIGE, CancellationToken GBGBPJOGKLE) where TArgs : IEquatable<TArgs>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal class GPKLDBPCDDM<TArgs> : IDisposable where TArgs : IEquatable<TArgs>
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate Task<TArgs> NADABFPAGMH(CancellationToken EGOLLFEHBCN, CancellationToken KMLDIJHEJJP);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct EJNIIHOHEJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public GPKLDBPCDDM<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public AGAJEBLOFKP doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public TimeSpan forceCancelAfter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x303D370", Offset = "0x303C170", VA = "0x18303D370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x303DB80", Offset = "0x303C980", VA = "0x18303DB80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct GOEOHCKCLLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public GPKLDBPCDDM<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public AGAJEBLOFKP doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x353DC60", Offset = "0x353CA60", VA = "0x18353DC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x353DED0", Offset = "0x353CCD0", VA = "0x18353DED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct DLDBDHKDADA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public GPKLDBPCDDM<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x4C83680", Offset = "0x4C82480", VA = "0x184C83680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x4C83DA0", Offset = "0x4C82BA0", VA = "0x184C83DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct EIFLINPMIMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public GPKLDBPCDDM<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public NADABFPAGMH taskFactory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private CancellationTokenSource <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x3033700", Offset = "0x3032500", VA = "0x183033700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x3034960", Offset = "0x3033760", VA = "0x183034960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct DCKMHLGFKLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public Task<TArgs> wrappedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public GPKLDBPCDDM<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x4C43900", Offset = "0x4C42700", VA = "0x184C43900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x3D96940", Offset = "0x3D95740", VA = "0x183D96940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private bool FGEBCHHJFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private bool GALNECAIMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private bool ILPBCNBFHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private CancellationTokenSource JCDCOKNOGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private CancellationTokenSource FHBHNHBJLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly AGAJEBLOFKP AIBCCLHKNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly CancellationToken FJDIBEBBHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly TArgs PABBJIBBIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private TArgs IKBIAFEOEKJ;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public TArgs CPKIHOLEKMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x35427E0", Offset = "0x35415E0", VA = "0x1835427E0")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TArgs INAJGAKNKBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x35423D0", Offset = "0x35411D0", VA = "0x1835423D0")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	[CanBeNull]
	public Task<TArgs> EEFEDLMFJME
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x760F60", Offset = "0x75FD60", VA = "0x180760F60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x760F20", Offset = "0x75FD20", VA = "0x180760F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3543BE0", Offset = "0x35429E0", VA = "0x183543BE0")]
	public GPKLDBPCDDM(TArgs MEFPNILDBJL, CancellationToken FJDIBEBBHAG, AGAJEBLOFKP AIBCCLHKNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x35433E0", Offset = "0x35421E0", VA = "0x1835433E0")]
	[AsyncStateMachine(typeof(GPKLDBPCDDM<>.EJNIIHOHEJB))]
	public Task OALFLFKEOPA(TimeSpan HEGKKOKPDLH, AGAJEBLOFKP NDPLDNIIOOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3542930", Offset = "0x3541730", VA = "0x183542930")]
	[AsyncStateMachine(typeof(GPKLDBPCDDM<>.GOEOHCKCLLL))]
	public Task JOHELPKHABF(AGAJEBLOFKP NDPLDNIIOOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3541B90", Offset = "0x3540990", VA = "0x183541B90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3542C60", Offset = "0x3541A60", VA = "0x183542C60")]
	[AsyncStateMachine(typeof(GPKLDBPCDDM<>.DLDBDHKDADA))]
	private Task MAKIKCEKLLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3541EB0", Offset = "0x3540CB0", VA = "0x183541EB0")]
	[AsyncStateMachine(typeof(GPKLDBPCDDM<>.EIFLINPMIMN))]
	public Task<TArgs> ELALCLLFCFK(NADABFPAGMH ACALIIOAJIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3543040", Offset = "0x3541E40", VA = "0x183543040")]
	[AsyncStateMachine(typeof(GPKLDBPCDDM<>.DCKMHLGFKLI))]
	private Task<TArgs> MEBKOKMJACH(Task<TArgs> JDIAFJFIKAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3542540", Offset = "0x3541340", VA = "0x183542540")]
	public bool HHKGCHNKHKC(TArgs MAEJOBFMMEE, [Out] string HIEEIODHCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3543970", Offset = "0x3542770", VA = "0x183543970")]
	private bool ODFKIBFDGME(TArgs MAEJOBFMMEE, [Out] string HIEEIODHCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3542130", Offset = "0x3540F30", VA = "0x183542130")]
	public CancellationTokenRegistration? FNPKJLFHHOH(CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3543B40", Offset = "0x3542940", VA = "0x183543B40")]
	[CompilerGenerated]
	private void OEJDNCJPPJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface MPCCDNFLFCD
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void COIGACHELOM(string LLGFADGIKAL, string GNLCHFAONBP, AGAJEBLOFKP AIBCCLHKNFH, [Optional] string IBJOJLLNBAL);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CLDPGGHHPNP(string LLGFADGIKAL, string GNLCHFAONBP, AGAJEBLOFKP AIBCCLHKNFH, [Optional] string IBJOJLLNBAL);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GNGHNEGHDNJ(string LLGFADGIKAL, string GNLCHFAONBP, AGAJEBLOFKP AIBCCLHKNFH, [Optional] string IBJOJLLNBAL);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KIADPHLHGJE(string LLGFADGIKAL, string GNLCHFAONBP, AGAJEBLOFKP AIBCCLHKNFH, Exception GAGKDENINAJ, [Optional] string IBJOJLLNBAL);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LBFCNFKPIJP(string LLGFADGIKAL, KAAPKEOJELL BCMPBFIGNMG);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal static class OHINIFILFAN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct PEMGDBMBCFF<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public MPCCDNFLFCD analytics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public string clientName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public string actionName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x3D960D0", Offset = "0x3D94ED0", VA = "0x183D960D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x3D96940", Offset = "0x3D95740", VA = "0x183D96940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct DKJCBAKNONB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public MPCCDNFLFCD analytics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public string clientName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public string actionName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5CD9AF0", Offset = "0x5CD88F0", VA = "0x185CD9AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5CD9FB0", Offset = "0x5CD8DB0", VA = "0x185CD9FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2504250", Offset = "0x2503050", VA = "0x182504250")]
	[AsyncStateMachine(typeof(PEMGDBMBCFF<>))]
	public static Task<T> CJNFANMMOJE<T>(this Task<T> DPNKBPFBJPJ, [CanBeNull] MPCCDNFLFCD AJJLINFENBB, string LLGFADGIKAL, string GNLCHFAONBP, AGAJEBLOFKP AIBCCLHKNFH, [Optional] string IBJOJLLNBAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5CE22D0", Offset = "0x5CE10D0", VA = "0x185CE22D0")]
	[AsyncStateMachine(typeof(DKJCBAKNONB))]
	public static Task CJNFANMMOJE(this Task DPNKBPFBJPJ, [CanBeNull] MPCCDNFLFCD AJJLINFENBB, string LLGFADGIKAL, string GNLCHFAONBP, AGAJEBLOFKP AIBCCLHKNFH, [Optional] string IBJOJLLNBAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public delegate Task DCDCGLLFDPI();
[Cpp2IlInjected.Token(Token = "0x200004E")]
public delegate Task OFODIMJAHFB(HAPBAMNGMLC LLEMHCHJLME);
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class LALCGOOJIEF : HGCDAMKECBP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly CAGBENJDHMI KJEJDHJCLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly Func<LALCGOOJIEF, bool> EJIKOIMMKMN;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public DLACGEKGFHA FLKEGKMABGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5CDEA90", Offset = "0x5CDD890", VA = "0x185CDEA90", Slot = "4")]
		get
		{
			return default(DLACGEKGFHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public KCBAEGBIENN NKOEJLECJGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5CDEBA0", Offset = "0x5CDD9A0", VA = "0x185CDEBA0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool FBHGHHDBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5CDEBE0", Offset = "0x5CDD9E0", VA = "0x185CDEBE0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool CPAENKHMDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5CDEC00", Offset = "0x5CDDA00", VA = "0x185CDEC00", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool MGBNEDEPBAA
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5CDEB60", Offset = "0x5CDD960", VA = "0x185CDEB60", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Exception KOHDPNGHHNC
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5CDEDE0", Offset = "0x5CDDBE0", VA = "0x185CDEDE0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public StatusCode HBJMCHGIIKP
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5CDEC40", Offset = "0x5CDDA40", VA = "0x185CDEC40", Slot = "16")]
		get
		{
			return default(StatusCode);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event CAGBENJDHMI.KKPPMEDHELI MNMILJLKOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5CDEB80", Offset = "0x5CDD980", VA = "0x185CDEB80", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5CDEDC0", Offset = "0x5CDDBC0", VA = "0x185CDEDC0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<DLACGEKGFHA, DLACGEKGFHA> IBNLCHAEIDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5CDED10", Offset = "0x5CDDB10", VA = "0x185CDED10", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5CDEC60", Offset = "0x5CDDA60", VA = "0x185CDEC60", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5CDEE00", Offset = "0x5CDDC00", VA = "0x185CDEE00")]
	public LALCGOOJIEF(CAGBENJDHMI KJEJDHJCLID, [Optional] Func<LALCGOOJIEF, bool> EJIKOIMMKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5CDEAB0", Offset = "0x5CDD8B0", VA = "0x185CDEAB0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5CDEB40", Offset = "0x5CDD940", VA = "0x185CDEB40")]
	private void ECHOFDCOEGN(DLACGEKGFHA DHIHNODHBIG, DLACGEKGFHA ALMPBAEOOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5CDEBC0", Offset = "0x5CDD9C0", VA = "0x185CDEBC0", Slot = "13")]
	public void HENBCGHJCNL(object PABBJIBBIGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5CDEC20", Offset = "0x5CDDA20", VA = "0x185CDEC20", Slot = "14")]
	public void KEOLNFFBNDK(object PABBJIBBIGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class CBCMOJAFIFM : JDLCCAPLPFA, DGPCKDMJJKC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class CEGKFPIIMOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public MOBHIPAGCOJ targetRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public CEGKFPIIMOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5CD9250", Offset = "0x5CD8050", VA = "0x185CD9250")]
		internal bool CFADCOMBDFD(LGOLNFIHLPG c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class BAKLNDKIOPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public BAKLNDKIOPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5CD8580", Offset = "0x5CD7380", VA = "0x185CD8580")]
		internal Task ONBGBHCGLLP(LGOLNFIHLPG c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct LNDOCBIPODL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public CBCMOJAFIFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5CDEEC0", Offset = "0x5CDDCC0", VA = "0x185CDEEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x5CDF150", Offset = "0x5CDDF50", VA = "0x185CDF150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct KABEEGEODHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public AsyncTaskMethodBuilder<MOBHIPAGCOJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public CBCMOJAFIFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public MOBHIPAGCOJ targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private MOBHIPAGCOJ <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter<MOBHIPAGCOJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x5CDE250", Offset = "0x5CDD050", VA = "0x185CDE250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x5CDE730", Offset = "0x5CDD530", VA = "0x185CDE730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class JOHLBCGABEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public JOHLBCGABEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x5CDDDF0", Offset = "0x5CDCBF0", VA = "0x185CDDDF0")]
		internal Task GADCKLGBNDE(LGOLNFIHLPG c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct KGODCBDDFID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public CBCMOJAFIFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5CDE7A0", Offset = "0x5CDD5A0", VA = "0x185CDE7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5CDEA30", Offset = "0x5CDD830", VA = "0x185CDEA30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public readonly GCPNKDOMKMB FBDJCAIPPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public readonly CIJGHKFIOHB MOAAPNOAJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly LGOLNFIHLPG[] JMPMPBPMMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public readonly GNDNAHHJPLP LOACLHGKNCG;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public MOBHIPAGCOJ MNHCBHDINAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5CD8E80", Offset = "0x5CD7C80", VA = "0x185CD8E80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string DEOLBJJDEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5CD87F0", Offset = "0x5CD75F0", VA = "0x185CD87F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private IEnumerable<LGOLNFIHLPG> FDHEMGPDIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5CD8D10", Offset = "0x5CD7B10", VA = "0x185CD8D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private IJOKJANALOM AKPGFDAIAOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Task ONJGMNHMFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5CD8D50", Offset = "0x5CD7B50", VA = "0x185CD8D50", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5CD8DA0", Offset = "0x5CD7BA0", VA = "0x185CD8DA0", Slot = "7")]
	public bool KLHLNNMHEEF(MOBHIPAGCOJ DIOGLLFIIPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5CD90B0", Offset = "0x5CD7EB0", VA = "0x185CD90B0")]
	[Preserve]
	public CBCMOJAFIFM([FGPOJKOJBFM(null)] GCPNKDOMKMB AJLFAPKIPEO, [FGPOJKOJBFM(null)] CIJGHKFIOHB BLFKPBLGCDM, [FGPOJKOJBFM(null)] GNDNAHHJPLP DPCCPJCEONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5CD8FC0", Offset = "0x5CD7DC0", VA = "0x185CD8FC0", Slot = "8")]
	[AsyncStateMachine(typeof(LNDOCBIPODL))]
	public Task MKDIBJNBIGK([Optional] CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5CD8BB0", Offset = "0x5CD79B0", VA = "0x185CD8BB0", Slot = "9")]
	[AsyncStateMachine(typeof(KABEEGEODHO))]
	public Task<MOBHIPAGCOJ> FIGABPCBDMP(MOBHIPAGCOJ DIOGLLFIIPP, object KHNGAKEPNEA, [Optional] CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5CD8ED0", Offset = "0x5CD7CD0", VA = "0x185CD8ED0", Slot = "10")]
	[AsyncStateMachine(typeof(KGODCBDDFID))]
	public Task LIOEINPGGIG([Optional] CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5CD8840", Offset = "0x5CD7640", VA = "0x185CD8840", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5CD8A90", Offset = "0x5CD7890", VA = "0x185CD8A90", Slot = "11")]
	public void EIELLPDPOGG(OFODIMJAHFB ECICBMCJDEP)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct OLCJMMAECFA : IEquatable<OLCJMMAECFA>
{
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public static readonly OLCJMMAECFA IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x779310", Offset = "0x778110", VA = "0x180779310", Slot = "4")]
	public bool Equals(OLCJMMAECFA LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3060", Offset = "0x5CE1E60", VA = "0x185CE3060", Slot = "0")]
	public override bool Equals(object DGPHOMINFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x75DC40", Offset = "0x75CA40", VA = "0x18075DC40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class JDHHIHDOGPL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5CD84D0", Offset = "0x5CD72D0", VA = "0x185CD84D0")]
	public JDHHIHDOGPL(string BLAOEBOMGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5CDD950", Offset = "0x5CDC750", VA = "0x185CDD950")]
	public JDHHIHDOGPL(string BLAOEBOMGGP, Exception FCMCOCINMCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class BNMNDMONOIG : JDHHIHDOGPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public readonly string JMBHPLABDFO;

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x5CD86C0", Offset = "0x5CD74C0", VA = "0x185CD86C0")]
	public BNMNDMONOIG(string GHCEBDADDLA, [NotNull] Exception FCMCOCINMCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class OMJGICKLOFG : JDHHIHDOGPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public readonly MOBHIPAGCOJ DDBCFKHNIAF;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5CE30D0", Offset = "0x5CE1ED0", VA = "0x185CE30D0")]
	public OMJGICKLOFG(MOBHIPAGCOJ ALAACEICNAM, [NotNull] Exception FCMCOCINMCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class AIHJHMEKCIB : JDHHIHDOGPL
{
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x5CD84D0", Offset = "0x5CD72D0", VA = "0x185CD84D0")]
	public AIHJHMEKCIB(string BLAOEBOMGGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class KAAPKEOJELL : JDHHIHDOGPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public readonly StatusCode? HBJMCHGIIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public readonly HAPBAMNGMLC DHMABCAPGLP;

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x5CDE0F0", Offset = "0x5CDCEF0", VA = "0x185CDE0F0")]
	public KAAPKEOJELL(HAPBAMNGMLC LLEMHCHJLME, Exception FCMCOCINMCK, StatusCode? MNCHBFLPGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5CDDE50", Offset = "0x5CDCC50", VA = "0x185CDDE50")]
	public static KAAPKEOJELL FKAJDEHDOPD(HAPBAMNGMLC PFKGBLPNLAK, HGCDAMKECBP EKACDDKHNNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class CBOMCGAKJPO : JDHHIHDOGPL
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5CD84D0", Offset = "0x5CD72D0", VA = "0x185CD84D0")]
	public CBOMCGAKJPO(string BLAOEBOMGGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class AHEIFCENEEC : JDHHIHDOGPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public readonly short NIBBOLAKHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public readonly string LPGEPIMGFCF;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5CD83E0", Offset = "0x5CD71E0", VA = "0x185CD83E0")]
	public AHEIFCENEEC(short OCGNIDFIOOG, string MKGHJANEAOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class NKLEADLOLIL : JDHHIHDOGPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public readonly short NIBBOLAKHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public readonly string LPGEPIMGFCF;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2090", Offset = "0x5CE0E90", VA = "0x185CE2090")]
	public NKLEADLOLIL(short OCGNIDFIOOG, string MKGHJANEAOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class CJKPINOAAJM : JDHHIHDOGPL
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5CD84D0", Offset = "0x5CD72D0", VA = "0x185CD84D0")]
	public CJKPINOAAJM(string BLAOEBOMGGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class NENIPLBKEKC : JDHHIHDOGPL
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5CDFA50", Offset = "0x5CDE850", VA = "0x185CDFA50")]
	public NENIPLBKEKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class ALCDLCELFFH : BFLEDLOCDFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public readonly Dictionary<string, string> IBEDDJCFAIA;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5CD8530", Offset = "0x5CD7330", VA = "0x185CD8530")]
	public ALCDLCELFFH(TimeSpan PNDCNOOMJCC, string BLAOEBOMGGP, Dictionary<string, string> IBJOJLLNBAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class GOJPGIHGGLJ : PBAOADFKDLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly KAPCIBMFMEE<HAPBAMNGMLC> KJBECGHFJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private readonly KAPCIBMFMEE<HAPBAMNGMLC> PLEBCHDLAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private readonly KAPCIBMFMEE<HAPBAMNGMLC> GFFOLOPECGJ;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<HAPBAMNGMLC> OECPMNALEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD560", Offset = "0x5CDC360", VA = "0x185CDD560")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD5C0", Offset = "0x5CDC3C0", VA = "0x185CDD5C0")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action<HAPBAMNGMLC> HLKMFGEHPCK
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD680", Offset = "0x5CDC480", VA = "0x185CDD680")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD6E0", Offset = "0x5CDC4E0", VA = "0x185CDD6E0")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<HAPBAMNGMLC> CNNEAKGHFFG
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD620", Offset = "0x5CDC420", VA = "0x185CDD620")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD500", Offset = "0x5CDC300", VA = "0x185CDD500")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5CDD740", Offset = "0x5CDC540", VA = "0x185CDD740", Slot = "31")]
	public override void OnDisconnected(HAPBAMNGMLC LLEMHCHJLME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5CDD840", Offset = "0x5CDC640", VA = "0x185CDD840")]
	public GOJPGIHGGLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class GCPNKDOMKMB : KKBDBNPNBDP<PBDPFIHDLBN>, IJOKJANALOM, LGOLNFIHLPG, DGPCKDMJJKC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct FOGGBLGOKFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public GCPNKDOMKMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private CancellationToken <token>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5CDA3E0", Offset = "0x5CD91E0", VA = "0x185CDA3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x865C40", Offset = "0x864A40", VA = "0x180865C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class GHJKLOMHHAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public GCPNKDOMKMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public AGAJEBLOFKP actionContext;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public GHJKLOMHHAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5CDB1F0", Offset = "0x5CD9FF0", VA = "0x185CDB1F0")]
		internal void OMBCMEJIEAM(AEMIIEBAFHL<string> timer, HICMFDICNOL log)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct NICLIBONLHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public AsyncTaskMethodBuilder<IReadOnlyDictionary<string, int>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public GCPNKDOMKMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private GHJKLOMHHAM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public TimeSpan? timeoutSpan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private AEMIIEBAFHL<string> <pingStackTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <pingTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private Stopwatch <sw>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private Dictionary<string, int> <regionPings>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private TaskAwaiter<NJBIFAJACNK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private YieldAwaitable.YieldAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x5CDFAD0", Offset = "0x5CDE8D0", VA = "0x185CDFAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x5CE1C10", Offset = "0x5CE0A10", VA = "0x185CE1C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private CancellationTokenSource JNAFPOOLPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private CancellationTokenSource AFJMKJJLNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private CancellationToken? KBPJNIFLEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private bool HOBAMOELOLN;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool NCMACJOHCJL
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7F9520", Offset = "0x7F8320", VA = "0x1807F9520")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x5CDACA0", Offset = "0x5CD9AA0", VA = "0x185CDACA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5CDAF40", Offset = "0x5CD9D40", VA = "0x185CDAF40", Slot = "13")]
	public override bool KLHLNNMHEEF(MOBHIPAGCOJ DIOGLLFIIPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5CDB090", Offset = "0x5CD9E90", VA = "0x185CDB090")]
	[Preserve]
	public GCPNKDOMKMB([FGPOJKOJBFM(null)] PBDPFIHDLBN JDIFANIOFLI, [FGPOJKOJBFM(null)] NNBECPGINFM HDLGJJMCIOD, [FGPOJKOJBFM(null)] MPCCDNFLFCD AJJLINFENBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5CDB140", Offset = "0x5CD9F40", VA = "0x185CDB140")]
	internal GCPNKDOMKMB(PBDPFIHDLBN JDIFANIOFLI, NNBECPGINFM HDLGJJMCIOD, MPCCDNFLFCD AJJLINFENBB, FBEAEALEIKO GPGPCGNKAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5CDA870", Offset = "0x5CD9670", VA = "0x185CDA870", Slot = "17")]
	protected override void BKJCMOABEJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5CDAAE0", Offset = "0x5CD98E0", VA = "0x185CDAAE0")]
	private void IIAPMPEJFEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5CDAD70", Offset = "0x5CD9B70", VA = "0x185CDAD70", Slot = "16")]
	protected override void KENJKGJDBBH(MOBHIPAGCOJ LFCPOOEIEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5CDAB50", Offset = "0x5CD9950", VA = "0x185CDAB50", Slot = "14")]
	protected override void IIFMMGFHAPE(AGAJEBLOFKP AIBCCLHKNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5CDAFA0", Offset = "0x5CD9DA0", VA = "0x185CDAFA0", Slot = "15")]
	protected override void LOAGEFFBNML(AGAJEBLOFKP AIBCCLHKNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5CDAA30", Offset = "0x5CD9830", VA = "0x185CDAA30")]
	[AsyncStateMachine(typeof(FOGGBLGOKFL))]
	private void CDDJLOHAEEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5CDA900", Offset = "0x5CD9700", VA = "0x185CDA900", Slot = "18")]
	[AsyncStateMachine(typeof(NICLIBONLHF))]
	public Task<IReadOnlyDictionary<string, int>> CAGBBJBAAGH([Optional] TimeSpan? GMCMOIJBADP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class MOBHIPAGCOJ : NJBIFAJACNK, IEquatable<MOBHIPAGCOJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public readonly string EIKKBKKAPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly string? NIFBNHPLNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public readonly string? KIBBIFHJOAC;

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x5CDF860", Offset = "0x5CDE660", VA = "0x185CDF860")]
	public MOBHIPAGCOJ(string NICAKOCOOHK, string ECLCHGJFKPM, string INNONHPDBJD, string? HALHIBEKENG, string CCKPAANGIIB, string HPBJPDKIDPE, string? AOONOCAEBLM, string? KIKBHJLDNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5CDF800", Offset = "0x5CDE600", VA = "0x185CDF800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5CDF520", Offset = "0x5CDE320", VA = "0x185CDF520", Slot = "5")]
	public bool Equals(MOBHIPAGCOJ? LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5CDF5A0", Offset = "0x5CDE3A0", VA = "0x185CDF5A0", Slot = "0")]
	public override bool Equals(object? DGPHOMINFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5CDF6C0", Offset = "0x5CDE4C0", VA = "0x185CDF6C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x1B2CBC0", Offset = "0x1B2B9C0", VA = "0x181B2CBC0")]
	public static bool PNFEPLLEJJK(MOBHIPAGCOJ? NLBDNIEIKMB, MOBHIPAGCOJ? NFFCMKPCJPP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x1430160", Offset = "0x142EF60", VA = "0x181430160")]
	public static bool IJDMLBHKDLI(MOBHIPAGCOJ? NLBDNIEIKMB, MOBHIPAGCOJ? NFFCMKPCJPP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class NJBIFAJACNK : IEquatable<NJBIFAJACNK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public readonly string EOAHALEIGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public readonly string? HCJMBFJLEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public readonly string? MFIDDACJAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public readonly string? EFIKPABNBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public readonly string IDCIJAOMMGP;

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1F40", Offset = "0x5CE0D40", VA = "0x185CE1F40")]
	public NJBIFAJACNK(string NICAKOCOOHK, string? ECLCHGJFKPM, string? INNONHPDBJD, string? HALHIBEKENG, string CCKPAANGIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1EE0", Offset = "0x5CE0CE0", VA = "0x185CE1EE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1D60", Offset = "0x5CE0B60", VA = "0x185CE1D60", Slot = "4")]
	public bool Equals(NJBIFAJACNK? LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1C80", Offset = "0x5CE0A80", VA = "0x185CE1C80", Slot = "0")]
	public override bool Equals(object? DGPHOMINFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1DF0", Offset = "0x5CE0BF0", VA = "0x185CE1DF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class CIJGHKFIOHB : KKBDBNPNBDP<CIJGHKFIOHB.OIMOHEPPIMG>
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public interface PJPIANOKJLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool NENAJKPIGCA();
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class OIMOHEPPIMG : GHPAKEJIMOP, MPMELMHFGFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private HGCDAMKECBP GCMAFEPGIMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private bool JOAHEADOLCP;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		private PhotonVoiceNetwork POKIGHAGFEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x5CE2610", Offset = "0x5CE1410", VA = "0x185CE2610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool MLNPDENGNGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xC65640", Offset = "0xC64440", VA = "0x180C65640", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public HGCDAMKECBP EHELGFKHKJH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool CPAENKHMDEO
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x5CE2A70", Offset = "0x5CE1870", VA = "0x185CE2A70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool HKMPKNOLCKF
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x5CE2580", Offset = "0x5CE1380", VA = "0x185CE2580", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x765470", Offset = "0x764270", VA = "0x180765470", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool EGPFPLHBBCP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool FBHGHHDBOKO
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x5CE2A20", Offset = "0x5CE1820", VA = "0x185CE2A20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public PDAHEEDKKPC JCFMJLLKKLC
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x5CE2CC0", Offset = "0x5CE1AC0", VA = "0x185CE2CC0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool DPJAOLLJGGO
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5CE2F50", Offset = "0x5CE1D50", VA = "0x185CE2F50", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<HGCDAMKECBP, HGCDAMKECBP> LLMIDFLHJJN
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x5CE2EA0", Offset = "0x5CE1CA0", VA = "0x185CE2EA0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x5CE2AC0", Offset = "0x5CE18C0", VA = "0x185CE2AC0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<bool> PELOGHPDCFA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2820", Offset = "0x5CE1620", VA = "0x185CE2820", Slot = "9")]
		public void FIBHGCIMFCK(CAGBENJDHMI BLFKPBLGCDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x5CE28F0", Offset = "0x5CE16F0", VA = "0x185CE28F0", Slot = "16")]
		public bool GDECDIKEKMO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2670", Offset = "0x5CE1470", VA = "0x185CE2670", Slot = "17")]
		public bool ECHNLDKNPME(string HPBJPDKIDPE, MGLCHIMGADM NCMINEJFBNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2DA0", Offset = "0x5CE1BA0", VA = "0x185CE2DA0", Slot = "18")]
		public void MKDIBJNBIGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2450", Offset = "0x5CE1250", VA = "0x185CE2450", Slot = "19")]
		public bool AJNHEGPCAOC(AppSettings HDLBMNNAINO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "22")]
		public void ADIGDFNGBPL(object EKDHBKMFLGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "23")]
		public void BJNALIGBDLB(object EKDHBKMFLGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "24")]
		public void IFADCJALLFH(object EKDHBKMFLGI, bool NPJECEMHBEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2C70", Offset = "0x5CE1A70", VA = "0x185CE2C70", Slot = "25")]
		public IDisposable KBLOGGINJCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "26")]
		private bool NEFKLJMELCK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "27")]
		public void COCDIHJCDBJ(StringBuilder CEPLELDLAJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2B70", Offset = "0x5CE1970", VA = "0x185CE2B70", Slot = "28")]
		public bool IMLHIAJFGJC(bool APMOEIPLPJJ, [Out] string HIFPPFEDDLE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public OIMOHEPPIMG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct MFBFLFIFEJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public CIJGHKFIOHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public GCPNKDOMKMB clientToFollow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private TaskAwaiter<MOBHIPAGCOJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5CDF1B0", Offset = "0x5CDDFB0", VA = "0x185CDF1B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5CDF4C0", Offset = "0x5CDE2C0", VA = "0x185CDF4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct ELFEKBDECDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public CIJGHKFIOHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x5CDA010", Offset = "0x5CD8E10", VA = "0x185CDA010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5CDA380", Offset = "0x5CD9180", VA = "0x185CDA380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private readonly GCPNKDOMKMB AJLFAPKIPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private readonly PJPIANOKJLM EFIGJCFNLKP;

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9630", Offset = "0x5CD8430", VA = "0x185CD9630", Slot = "13")]
	public override bool KLHLNNMHEEF(MOBHIPAGCOJ DIOGLLFIIPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5CD97B0", Offset = "0x5CD85B0", VA = "0x185CD97B0")]
	[Preserve]
	public CIJGHKFIOHB([FGPOJKOJBFM(null)] GCPNKDOMKMB AJLFAPKIPEO, [FGPOJKOJBFM(null)] NNBECPGINFM HDLGJJMCIOD, [FGPOJKOJBFM(null)] PJPIANOKJLM EFIGJCFNLKP, [FGPOJKOJBFM(null)] MPCCDNFLFCD AJJLINFENBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5CD93F0", Offset = "0x5CD81F0", VA = "0x185CD93F0")]
	private Task IKOFONABNCF(HAPBAMNGMLC LLEMHCHJLME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5CD96C0", Offset = "0x5CD84C0", VA = "0x185CD96C0")]
	[AsyncStateMachine(typeof(MFBFLFIFEJE))]
	public Task PMEPAJMPMID(GCPNKDOMKMB HFCDKLKOIDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5CD95B0", Offset = "0x5CD83B0", VA = "0x185CD95B0")]
	[CompilerGenerated]
	internal static void KJHJALKKBKB(HGCDAMKECBP JHKFMIIDOLO, HGCDAMKECBP IAFINMOOAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9320", Offset = "0x5CD8120", VA = "0x185CD9320")]
	[AsyncStateMachine(typeof(ELFEKBDECDN))]
	[CompilerGenerated]
	private Task CBJDHANPJOP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[Preserve]
public class JBFAOCKEBFI
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	[JsonProperty(PropertyName = "AI", Required = Required.Always)]
	[Preserve]
	public string AccountId
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7619C0", Offset = "0x7607C0", VA = "0x1807619C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	[Preserve]
	[JsonProperty(PropertyName = "AT", Required = Required.Always)]
	public byte[] AccessToken
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x760C60", Offset = "0x75FA60", VA = "0x180760C60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[JsonProperty(PropertyName = "VB", Required = Required.Always)]
	[Preserve]
	public byte[] VerificationBlob
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x760C70", Offset = "0x75FA70", VA = "0x180760C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[JsonProperty(PropertyName = "CKA", Required = Required.Always)]
	[Preserve]
	public byte[] ClientKeyA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7654C0", Offset = "0x7642C0", VA = "0x1807654C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x766E40", Offset = "0x765C40", VA = "0x180766E40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[Preserve]
	[JsonProperty(PropertyName = "CIA", Required = Required.Always)]
	public byte[] ClientIVA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x763870", Offset = "0x762670", VA = "0x180763870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x763890", Offset = "0x762690", VA = "0x180763890")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	[Preserve]
	[JsonProperty(PropertyName = "CPK", Required = Required.Always)]
	public byte[] ClientPublicKey
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7654A0", Offset = "0x7642A0", VA = "0x1807654A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x765480", Offset = "0x764280", VA = "0x180765480")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public JBFAOCKEBFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[Preserve]
public class EJOIAGBEFMI
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	[JsonProperty(PropertyName = "DR", Required = Required.Always)]
	[Preserve]
	public string Reason
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7619C0", Offset = "0x7607C0", VA = "0x1807619C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[JsonProperty(PropertyName = "KT", Required = Required.Default)]
	[Preserve]
	public byte[] SessionKeyB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x760C60", Offset = "0x75FA60", VA = "0x180760C60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public EJOIAGBEFMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class GNDNAHHJPLP : LGOLNFIHLPG, DGPCKDMJJKC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public enum DPAKCEBFAIG
	{
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		Disconnected,
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		Connected
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private NetworkManager PLAMKHGCHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private TaskCompletionSource<MOBHIPAGCOJ> OIPNPNHOBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	protected readonly NNBECPGINFM ODNFPDPGCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private readonly HashSet<OFODIMJAHFB> EOPHLCOOFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public DPAKCEBFAIG BFILDDLCPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private MOBHIPAGCOJ DIOGLLFIIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private RSACryptoServiceProvider AINEAAFJCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private RSACryptoServiceProvider HDGCBPAHILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private AesCryptoServiceProvider INCBOAAPGGM;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public MOBHIPAGCOJ MNHCBHDINAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7654A0", Offset = "0x7642A0", VA = "0x1807654A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public string DEOLBJJDEEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5CDB2C0", Offset = "0x5CDA0C0", VA = "0x185CDB2C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Task ONJGMNHMFLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5CDBEC0", Offset = "0x5CDACC0", VA = "0x185CDBEC0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5CDB550", Offset = "0x5CDA350", VA = "0x185CDB550", Slot = "10")]
	public void EIELLPDPOGG(OFODIMJAHFB ECICBMCJDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5CDC540", Offset = "0x5CDB340", VA = "0x185CDC540", Slot = "6")]
	public bool KLHLNNMHEEF(MOBHIPAGCOJ DIOGLLFIIPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x5CDD320", Offset = "0x5CDC120", VA = "0x185CDD320")]
	[Preserve]
	public GNDNAHHJPLP([FGPOJKOJBFM(null)] NNBECPGINFM GEJFAHDMKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x5CDC9C0", Offset = "0x5CDB7C0", VA = "0x185CDC9C0")]
	private void ODOGGJOBDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5CDBA60", Offset = "0x5CDA860", VA = "0x185CDBA60")]
	private void GFBMFGLODMA(ulong DGPHOMINFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5CDBF80", Offset = "0x5CDAD80", VA = "0x185CDBF80")]
	private void JNMAOLODMDP(ulong DGPHOMINFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5CDB2F0", Offset = "0x5CDA0F0", VA = "0x185CDB2F0")]
	private void BJAHFNIMOBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5CDBF10", Offset = "0x5CDAD10", VA = "0x185CDBF10")]
	private void JKLKMJCFJAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5CDC6E0", Offset = "0x5CDB4E0", VA = "0x185CDC6E0")]
	private void LJJGOKBPAEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5CDB3E0", Offset = "0x5CDA1E0", VA = "0x185CDB3E0")]
	private void DIJBBFBMNEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5CDBD90", Offset = "0x5CDAB90", VA = "0x185CDBD90")]
	private static (IPAddress, ushort) HLNLOPBBLKF(string BIDIEBEBGCP)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5CDCC10", Offset = "0x5CDBA10", VA = "0x185CDCC10")]
	private void PILMGPGPDLF(MOBHIPAGCOJ IDHGBFKNGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5CDB5B0", Offset = "0x5CDA3B0", VA = "0x185CDB5B0", Slot = "8")]
	public Task<MOBHIPAGCOJ> FIGABPCBDMP(MOBHIPAGCOJ DIOGLLFIIPP, object KHNGAKEPNEA, [Optional] CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5CDC860", Offset = "0x5CDB660", VA = "0x185CDC860", Slot = "7")]
	public Task MKDIBJNBIGK([Optional] CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5CDC580", Offset = "0x5CDB380", VA = "0x185CDC580", Slot = "9")]
	public Task LIOEINPGGIG([Optional] CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class NLKGLLGOCNH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2180", Offset = "0x5CE0F80", VA = "0x185CE2180")]
	public NLKGLLGOCNH(string BLAOEBOMGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5CE21E0", Offset = "0x5CE0FE0", VA = "0x185CE21E0")]
	public NLKGLLGOCNH(string BLAOEBOMGGP, Exception FCMCOCINMCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class BHOKJBIGNAA : NLKGLLGOCNH
{
	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5CD85E0", Offset = "0x5CD73E0", VA = "0x185CD85E0")]
	public BHOKJBIGNAA([NotNull] Exception FCMCOCINMCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class JLMMLGBDAEK : NLKGLLGOCNH
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5CDDD70", Offset = "0x5CDCB70", VA = "0x185CDDD70")]
	public JLMMLGBDAEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class PBNPOBIBHGG : NLKGLLGOCNH
{
	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5CE40F0", Offset = "0x5CE2EF0", VA = "0x185CE40F0")]
	public PBNPOBIBHGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public static class AGMIDHCJGNN
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private static AesCryptoServiceProvider MGEEMPJMDBI;

	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private static readonly string[] MOMDENNCBMK;

	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private static readonly string[] GECKJEFPKEN;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private static readonly string[] NLEBMODGJBM;

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7EB0", Offset = "0x5CD6CB0", VA = "0x185CD7EB0")]
	public static string KFNDDODGOCN(ulong KOPAGBBKACI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7E40", Offset = "0x5CD6C40", VA = "0x185CD7E40")]
	public static string EPHADONHGLG(ulong KOPAGBBKACI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7F20", Offset = "0x5CD6D20", VA = "0x185CD7F20")]
	public static AesCryptoServiceProvider LAJANKCMFMK()
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

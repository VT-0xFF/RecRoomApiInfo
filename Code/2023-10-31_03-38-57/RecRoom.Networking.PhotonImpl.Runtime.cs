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
		[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CE2B00", Offset = "0x5CE1F00", VA = "0x185CE2B00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x787CA0", Offset = "0x7870A0", VA = "0x180787CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x787CE0", Offset = "0x7870E0", VA = "0x180787CE0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KBHNNBFBAKN : LPKJGNNMHAL, COHHIJKCCGB, JBEICMJGPPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class NDOAHLHHOOH : IHCDHLEFDCE
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class JONHNFMBHDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Action onCompleteCallback;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
			public JONHNFMBHDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x5554760", Offset = "0x5553B60", VA = "0x185554760")]
			internal void OOBDJKEILHH(MFFAACJMPBN rh)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool FDLBCNIFDLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5CE25C0", Offset = "0x5CE19C0", VA = "0x185CE25C0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool BFFDKOLDFPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5CE24B0", Offset = "0x5CE18B0", VA = "0x185CE24B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public IReadOnlyList<DCFHDFEJPPF> MHICINADKKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5CE2630", Offset = "0x5CE1A30", VA = "0x185CE2630", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2740", Offset = "0x5CE1B40", VA = "0x185CE2740", Slot = "7")]
		public bool MJFHOAKFPKL(Action DPGGHMDCKBF, string CIAMMKNHANA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public NDOAHLHHOOH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NHFKPAOGFHM DFAOJIMCPDA;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly byte[] OEPLFDKNDJG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override bool OHMAFKDGICH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4E63D60", Offset = "0x4E63160", VA = "0x184E63D60", Slot = "80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override NHFKPAOGFHM HIOIJDDIHGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7610F0", Offset = "0x7604F0", VA = "0x1807610F0", Slot = "81")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override bool DCMKPMAFHGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CDE010", Offset = "0x5CDD410", VA = "0x185CDE010", Slot = "82")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override bool BJFEPCNKBNI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD8A0", Offset = "0x5CDCCA0", VA = "0x185CDD8A0", Slot = "60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5CDDD40", Offset = "0x5CDD140", VA = "0x185CDDD40", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override float OJPOIJOBGFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD640", Offset = "0x5CDCA40", VA = "0x185CDD640", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override IHCDHLEFDCE HIEHNLCBEAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x75F220", Offset = "0x75E620", VA = "0x18075F220", Slot = "77")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override bool ILIACOFMHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5CDE0C0", Offset = "0x5CDD4C0", VA = "0x185CDE0C0", Slot = "83")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD240", Offset = "0x5CDC640", VA = "0x185CDD240", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override bool FGOMAPLMOGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD5F0", Offset = "0x5CDC9F0", VA = "0x185CDD5F0", Slot = "85")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool KBINIFAGNPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD200", Offset = "0x5CDC600", VA = "0x185CDD200", Slot = "86")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override LDMJAJANBKI DLDAIKDONEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5CDE050", Offset = "0x5CDD450", VA = "0x185CDE050", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool JJMJMBNFGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5CDE2F0", Offset = "0x5CDD6F0", VA = "0x185CDE2F0", Slot = "76")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override int IIPCCEGBMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD780", Offset = "0x5CDCB80", VA = "0x185CDD780", Slot = "63")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override int NMEBBOLCKHO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD830", Offset = "0x5CDCC30", VA = "0x185CDD830", Slot = "64")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override CBOIFHFJJAA PHBDNODNADP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD7F0", Offset = "0x5CDCBF0", VA = "0x185CDD7F0", Slot = "65")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public override int JCNEEGKMDJH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5CDDA90", Offset = "0x5CDCE90", VA = "0x185CDDA90", Slot = "66")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public override int AJIPEDOHNFA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5CDE280", Offset = "0x5CDD680", VA = "0x185CDE280", Slot = "67")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public override event KDBNBIIJMHG AJPHKGPLPOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD420", Offset = "0x5CDC820", VA = "0x185CDD420", Slot = "56")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD0F0", Offset = "0x5CDC4F0", VA = "0x185CDD0F0", Slot = "57")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public override event Action<CBOIFHFJJAA> JJBHNFPAFGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD9E0", Offset = "0x5CDCDE0", VA = "0x185CDD9E0", Slot = "58")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD930", Offset = "0x5CDCD30", VA = "0x185CDD930", Slot = "59")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public override event Action<NHFKPAOGFHM, NHFKPAOGFHM> KFKMNGKMHPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5CDDF60", Offset = "0x5CDD360", VA = "0x185CDDF60", Slot = "78")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD6D0", Offset = "0x5CDCAD0", VA = "0x185CDD6D0", Slot = "79")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5CDD290", Offset = "0x5CDC690", VA = "0x185CDD290", Slot = "90")]
	public override void CAHMPNOMOFB(EIAKNHLGOIC GEMEBIOGIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5CDDC40", Offset = "0x5CDD040", VA = "0x185CDDC40")]
	[JMHDKPKEECF(OPIGPDFNEON.GameOnly)]
	private static void JHBKMICOLHJ(HLDKHDLHDPB KBPJCNHNBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5CDE3B0", Offset = "0x5CDD7B0", VA = "0x185CDE3B0")]
	[Preserve]
	public KBHNNBFBAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5CDDD90", Offset = "0x5CDD190", VA = "0x185CDDD90")]
	private void KIJFMDBGIEC(bool ABJODAPNKOI, bool PBMCBNAOPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5CDD360", Offset = "0x5CDC760", VA = "0x185CDD360", Slot = "68")]
	[CanBeNull]
	public override CBOIFHFJJAA COGLNFOPIFM(int CBNGMOLIGJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5CDE150", Offset = "0x5CDD550", VA = "0x185CDE150")]
	private static short ONCAHOKJACO(StreamBuffer DAEHGKDJGGG, object FFMGCGIHOED)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5CDCED0", Offset = "0x5CDC2D0", VA = "0x185CDCED0")]
	private static object AGPGDBLLCBL(StreamBuffer GFLAMJCDPHL, short KIHHOMBMMEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5CDD4C0", Offset = "0x5CDC8C0", VA = "0x185CDD4C0", Slot = "100")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5CDDF10", Offset = "0x5CDD310", VA = "0x185CDDF10", Slot = "69")]
	public override bool LLKMIKJGLAH(AppSettings PEKJMJJOJDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5CDCE90", Offset = "0x5CDC290", VA = "0x185CDCE90", Slot = "70")]
	public override void AEFMOCBEJCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5CDDAF0", Offset = "0x5CDCEF0", VA = "0x185CDDAF0", Slot = "71")]
	public override bool JECCICLMKAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5CDD690", Offset = "0x5CDCA90", VA = "0x185CDD690", Slot = "72")]
	public override void FNDHDAOBBFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5CDD070", Offset = "0x5CDC470", VA = "0x185CDD070", Slot = "73")]
	public override bool AKCMIODEIMJ(byte JILHBFHCFPK, Hashtable GJFIAOCHHKA, ICDPKBNMAKD IIAAPHJCFOK, SendOptions HLFCHLOIJKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5CDD190", Offset = "0x5CDC590", VA = "0x185CDD190", Slot = "88")]
	public override bool BKIAOMFJHCO(string LBGLMHHJHJJ, JOLFKJJOPME GENAHMOEODI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5CDDE10", Offset = "0x5CDD210", VA = "0x185CDDE10", Slot = "89")]
	public override void LBHJDLHDBGN(string BLIDPKJFLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5CDE200", Offset = "0x5CDD600", VA = "0x185CDE200", Slot = "93")]
	public void OnEvent(EventData DPBGJEIOGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "94")]
	public void OnPlayerEnteredRoom(GDKILHBGAII CHOPLJEIAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "95")]
	public void OnPlayerWillLeaveRoom(GDKILHBGAII DHADDGLKDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "96")]
	public void OnPlayerLeftRoom(GDKILHBGAII DHADDGLKDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "97")]
	public void OnRoomPropertiesUpdate(Hashtable HLOLOFIKNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "98")]
	public void OnPlayerPropertiesUpdate(GDKILHBGAII GLIAGCMNGEK, Hashtable BODDNMMGIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5CDE0A0", Offset = "0x5CDD4A0", VA = "0x185CDE0A0", Slot = "99")]
	private void ODJPDJKLIHK(GDKILHBGAII KMABMKLPDPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BPLKHKMOOON : NHBLADMBPDF, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NHBLADMBPDF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	GAMIAJAKEJM MHGBKMBBFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string OHPMMNNOFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Task IFDAACGMOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NNEEKCJNLBL(GAMIAJAKEJM CBJNNHMCKDJ);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task AEFMOCBEJCG([Optional] CancellationToken ELGJALILGJE);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<GAMIAJAKEJM> IEGFGJFPOMK(GAMIAJAKEJM CBJNNHMCKDJ, object JPGBCLJMEPC, [Optional] CancellationToken ELGJALILGJE);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task EJHHGCJMJNB([Optional] CancellationToken ELGJALILGJE);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NEIEEIEHJOP(AHEPBJHLOPN IFMDDPPNHFI);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface BLGKOMHDJIC
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELCIIBFOLCB(ushort ACINPHFOPOG, MDPKDAJBHBC NNJLOGLLBNK, params object[] DHNCNABPHMO);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal enum MDPKDAJBHBC
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
public interface FNEDNIJBEBA : NHBLADMBPDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	CKGIIMKOAEJ EOOELCBLBFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CKGIIMKOAEJ : BPLKHKMOOON, NHBLADMBPDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyDictionary<string, int>> CCDNKDPCBIC([Optional] TimeSpan? MCEEOLLDCOE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FENBOGEPBHH
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool LDOCCFFEECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool LIDGFPKCGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	TimeSpan GOIHCHEGHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	TimeSpan KMBBOOIDPFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AppSettings DEHAIODNMGN(GIFOGEOBDPH HJKLPPHAIMD);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LDMJAJANBKI PBBEDKGFBAM(GIFOGEOBDPH HJKLPPHAIMD);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<GIFOGEOBDPH> NHCHCCHABJH(CancellationToken ELGJALILGJE);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FGPBJGDEOFE : NEDFHLAOAMD, JBEICMJGPPL, JCBMOIEFAAO, MLAFENDDPJG, DNCDENMNMKJ, GJIDKKLPHAF, IPHFDDFNHIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly string ALNIPKACPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public OAELJMFAJKM ADPHICLADNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public OAELJMFAJKM GAFMGDJIDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public OCLNKBDMPPE<BJBJGPACONH> PFOIIAJBDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public OAELJMFAJKM CNFCIADHMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public OCLNKBDMPPE<string> BNIMLKKOEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public OCLNKBDMPPE<Dictionary<string, object>> HMNPAABGJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public OCLNKBDMPPE<BJBJGPACONH> BPGOCAPDPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public PFLGNCJFFGE<bool, bool> JHHCFABHFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public OAELJMFAJKM AIHDLPOHBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public OAELJMFAJKM EINDOPFKLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public OAELJMFAJKM JIEGGGFACKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public OAELJMFAJKM FPHABFFFPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public OAELJMFAJKM HIHAKPBNBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public OCLNKBDMPPE<GDKILHBGAII> IJNOAGEHAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public PFLGNCJFFGE<PhotonView, GDKILHBGAII> EOOPBAMNJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public DNMMKNGICIA<PhotonView, GDKILHBGAII, GDKILHBGAII> LGOAEFFOBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public PFLGNCJFFGE<short, string> AIKPLEHEFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public OCLNKBDMPPE<Hashtable> JDCDMCEMJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public OCLNKBDMPPE<GOIJLGDHMGB> GIDGOCMFIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public PFLGNCJFFGE<short, string> APPIGLAECDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public OAELJMFAJKM LFPNAJEHCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public OCLNKBDMPPE<GDKILHBGAII> LGHOAGIIKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public OCLNKBDMPPE<GDKILHBGAII> IJANDGNCLKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public PFLGNCJFFGE<GDKILHBGAII, Hashtable> HFDMGADAFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public PFLGNCJFFGE<short, string> GGKONAIOLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public OAELJMFAJKM GHDENGMHDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public OAELJMFAJKM DBMONCKMPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public OCLNKBDMPPE<OperationResponse> ILEHLNLBHPE;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5CD96E0", Offset = "0x5CD8AE0", VA = "0x185CD96E0", Slot = "31")]
	public virtual void OnDisconnected(BJBJGPACONH OJIFENIBHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5C4B970", Offset = "0x5C4AD70", VA = "0x185C4B970", Slot = "4")]
	public void OnConnected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9590", Offset = "0x5CD8990", VA = "0x185CD9590", Slot = "5")]
	public void OnConnectedToMaster()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "7")]
	public void OnRegionListReceived(MFFAACJMPBN PHFJDJOJIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9690", Offset = "0x5CD8A90", VA = "0x185CD9690", Slot = "8")]
	public void OnCustomAuthenticationResponse(Dictionary<string, object> GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9640", Offset = "0x5CD8A40", VA = "0x185CD9640", Slot = "9")]
	public void OnCustomAuthenticationFailed(string MEDOMIHIHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5CD98F0", Offset = "0x5CD8CF0", VA = "0x185CD98F0", Slot = "10")]
	public void OnPlayerEnteredRoom(GDKILHBGAII CHOPLJEIAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "11")]
	public void OnPlayerWillLeaveRoom(GDKILHBGAII DHADDGLKDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9950", Offset = "0x5CD8D50", VA = "0x185CD9950", Slot = "12")]
	public void OnPlayerLeftRoom(GDKILHBGAII DHADDGLKDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9A40", Offset = "0x5CD8E40", VA = "0x185CD9A40", Slot = "13")]
	public void OnRoomPropertiesUpdate(Hashtable HLOLOFIKNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5CD99B0", Offset = "0x5CD8DB0", VA = "0x185CD99B0", Slot = "14")]
	public void OnPlayerPropertiesUpdate(GDKILHBGAII GLIAGCMNGEK, Hashtable BODDNMMGIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9890", Offset = "0x5CD8C90", VA = "0x185CD9890", Slot = "15")]
	public void OnMasterClientSwitched(GDKILHBGAII KMABMKLPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xAEDED0", Offset = "0xAED2D0", VA = "0x180AEDED0", Slot = "16")]
	public void OnJoinedLobby()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xBC50C0", Offset = "0xBC44C0", VA = "0x180BC50C0", Slot = "17")]
	public void OnLeftLobby()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9A20", Offset = "0x5CD8E20", VA = "0x185CD9A20", Slot = "18")]
	public void OnRoomListUpdate(List<IIPJAHFNOMB> HKGJNMMLNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9870", Offset = "0x5CD8C70", VA = "0x185CD9870", Slot = "19")]
	public void OnLobbyStatisticsUpdate(List<JNGJJBMBGLC> KIGELBCGJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9770", Offset = "0x5CD8B70", VA = "0x185CD9770", Slot = "20")]
	public void OnFriendListUpdate(List<LAJFFCONHIM> DFDPKMPHHAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9620", Offset = "0x5CD8A20", VA = "0x185CD9620", Slot = "21")]
	public void OnCreatedRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5CD95B0", Offset = "0x5CD89B0", VA = "0x185CD95B0", Slot = "22")]
	public void OnCreateRoomFailed(short JFHDDFLNFMH, string NJKPBIBMIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xBBF230", Offset = "0xBBE630", VA = "0x180BBF230", Slot = "23")]
	public void OnJoinedRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9800", Offset = "0x5CD8C00", VA = "0x185CD9800", Slot = "24")]
	public void OnJoinRoomFailed(short JFHDDFLNFMH, string NJKPBIBMIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9790", Offset = "0x5CD8B90", VA = "0x185CD9790", Slot = "25")]
	public void OnJoinRandomFailed(short JFHDDFLNFMH, string NJKPBIBMIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xD63530", Offset = "0xD62930", VA = "0x180D63530", Slot = "26")]
	public void OnLeftRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9520", Offset = "0x5CD8920", VA = "0x185CD9520", Slot = "30")]
	public void OCNILILOHDB(GOIJLGDHMGB BCOICEBLMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9420", Offset = "0x5CD8820", VA = "0x185CD9420", Slot = "27")]
	public void IGJDBBMIAKO(PhotonView PPNMPLCNKNC, GDKILHBGAII GPDKGHKOOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9490", Offset = "0x5CD8890", VA = "0x185CD9490", Slot = "28")]
	public void KBNEMAKCCHG(PhotonView PPNMPLCNKNC, GDKILHBGAII IGPJKIFOECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9AA0", Offset = "0x5CD8EA0", VA = "0x185CD9AA0", Slot = "29")]
	public void OnWebRpcResponse(OperationResponse DOPLAHJJAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9B00", Offset = "0x5CD8F00", VA = "0x185CD9B00")]
	public FGPBJGDEOFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal static class DPCNDAAGLPE
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class FMFHNKHCHOC<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Action<string, KKFOMOHKANB> log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public KKFOMOHKANB actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public NHFKPAOGFHM networkClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool region;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public OIFLEICNDAM photonCallbacks;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public FMFHNKHCHOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x33E1D00", Offset = "0x33E1100", VA = "0x1833E1D00")]
		internal void JDPOBFEEIPL(BJBJGPACONH disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x33E1BC0", Offset = "0x33E0FC0", VA = "0x1833E1BC0")]
		internal void HBDLDGBFBFG(string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x33E18E0", Offset = "0x33E0CE0", VA = "0x1833E18E0")]
		internal void FPEHGIMHDNM(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class FHJGGCLHIKN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public FGPBJGDEOFE photonCallbacks;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public FHJGGCLHIKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x33D89C0", Offset = "0x33D7DC0", VA = "0x1833D89C0")]
		internal void MIFFFBEJAJO(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x33D8B20", Offset = "0x33D7F20", VA = "0x1833D8B20")]
		internal void PGHBGIOAHLB(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x33D87D0", Offset = "0x33D7BD0", VA = "0x1833D87D0")]
		internal void EHJLJJMEHCG(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x223DAC0", Offset = "0x223CEC0", VA = "0x18223DAC0")]
	public static void FDOEGNKMLKG<T>(this OIFLEICNDAM NHKJAFNPILF, TaskCompletionSource<T> OAONCJDELIC, [NotNull] NHFKPAOGFHM HGGHEIIIMNC, KKFOMOHKANB LKOALNBOENI, bool MNGEAEBDCEH, Action<string, KKFOMOHKANB> AMAPEJENOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x223D5C0", Offset = "0x223C9C0", VA = "0x18223D5C0")]
	public static void CMHICEEBDPO<T>(this FGPBJGDEOFE NHKJAFNPILF, TaskCompletionSource<T> OAONCJDELIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class ADKMJBDCCEO<TNetworking> : BPLKHKMOOON, NHBLADMBPDF, IDisposable where TNetworking : class, LHLMJCKPLDG, FAJONMKLMEP
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class HJHKBKAIBKA
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
			public AsyncTaskMethodBuilder<GIFOGEOBDPH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public HJHKBKAIBKA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private TaskAwaiter<GIFOGEOBDPH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x2EB2160", Offset = "0x2EB1560", VA = "0x182EB2160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2EB24D0", Offset = "0x2EB18D0", VA = "0x182EB24D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public KKFOMOHKANB actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public GIFOGEOBDPH photonServerConnectionInfo;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public HJHKBKAIBKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x355CF00", Offset = "0x355C300", VA = "0x18355CF00")]
		[AsyncStateMachine(typeof(ADKMJBDCCEO<>.HJHKBKAIBKA.<<ConnectToRegionInternal>b__0>d))]
		internal Task<GIFOGEOBDPH> LEPKLOOPHFF(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct LOHNHFICBHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AsyncTaskMethodBuilder<GIFOGEOBDPH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public KKFOMOHKANB actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public GIFOGEOBDPH photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private HJHKBKAIBKA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter<GIFOGEOBDPH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3987020", Offset = "0x3986420", VA = "0x183987020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3987C10", Offset = "0x3987010", VA = "0x183987C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct ADBHBLPDJLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder<GIFOGEOBDPH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public KKFOMOHKANB actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public GIFOGEOBDPH photonServerConnectionInfo;

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
		[Cpp2IlInjected.Address(RVA = "0x3461690", Offset = "0x3460A90", VA = "0x183461690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3462360", Offset = "0x3461760", VA = "0x183462360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct OKJOJKKPEOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public KKFOMOHKANB actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x3CF5D20", Offset = "0x3CF5120", VA = "0x183CF5D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3CF5F70", Offset = "0x3CF5370", VA = "0x183CF5F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct CDGFCCDGAAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private KKFOMOHKANB <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x4AB8C50", Offset = "0x4AB8050", VA = "0x184AB8C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x4AB9170", Offset = "0x4AB8570", VA = "0x184AB9170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class HGCEFMBHDPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public KKFOMOHKANB actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public HGCEFMBHDPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x353D940", Offset = "0x353CD40", VA = "0x18353D940")]
		internal Task<bool> BEADOIPKIJJ(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct JJFNPMAMMLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public KKFOMOHKANB actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private HGCEFMBHDPP <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x3846C70", Offset = "0x3846070", VA = "0x183846C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3847A90", Offset = "0x3846E90", VA = "0x183847A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class ODFCIBOLDHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public KKFOMOHKANB actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public TaskCompletionSource<BJBJGPACONH> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public ODFCIBOLDHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3CE3300", Offset = "0x3CE2700", VA = "0x183CE3300")]
		internal void KDOIDJCNNNK(BJBJGPACONH disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3CE3230", Offset = "0x3CE2630", VA = "0x183CE3230")]
		internal void HBAGFIGCBAE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct KMEOADOHGOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public KKFOMOHKANB actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private ODFCIBOLDHL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<BJBJGPACONH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x38FA800", Offset = "0x38F9C00", VA = "0x1838FA800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x38FBD90", Offset = "0x38FB190", VA = "0x1838FBD90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct BONJKBFBICK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<GAMIAJAKEJM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public GAMIAJAKEJM targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private KKFOMOHKANB <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<GAMIAJAKEJM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x48518A0", Offset = "0x4850CA0", VA = "0x1848518A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x48524C0", Offset = "0x48518C0", VA = "0x1848524C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class ADIMGMBANOG
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
			public AsyncTaskMethodBuilder<GAMIAJAKEJM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public ADIMGMBANOG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private TaskAwaiter<GAMIAJAKEJM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x2EB2540", Offset = "0x2EB1940", VA = "0x182EB2540", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x2EB28C0", Offset = "0x2EB1CC0", VA = "0x182EB28C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public KKFOMOHKANB actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public GAMIAJAKEJM targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public object pauseToken;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public ADIMGMBANOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3462550", Offset = "0x3461950", VA = "0x183462550")]
		[AsyncStateMachine(typeof(ADKMJBDCCEO<>.ADIMGMBANOG.<<ConnectToRoomInstanceInternal>b__0>d))]
		internal Task<GAMIAJAKEJM> MHNNBNFAEDC(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct MOJKPICILKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder<GAMIAJAKEJM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public KKFOMOHKANB actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public GAMIAJAKEJM targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private ADIMGMBANOG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter<GAMIAJAKEJM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3BC0C50", Offset = "0x3BC0050", VA = "0x183BC0C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3BC19F0", Offset = "0x3BC0DF0", VA = "0x183BC19F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class NAIPABLLDHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TaskCompletionSource<ENDNIBADGNL> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public NAIPABLLDHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3BF9660", Offset = "0x3BF8A60", VA = "0x183BF9660")]
		internal void KEBIMPBDKOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3BF95D0", Offset = "0x3BF89D0", VA = "0x183BF95D0")]
		internal void GIPJFFFKKEO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct JICLHOJBFNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public AsyncTaskMethodBuilder<GAMIAJAKEJM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public KKFOMOHKANB actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public GAMIAJAKEJM targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private NAIPABLLDHN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private JOLFKJJOPME <roomOptions>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private TaskAwaiter<GIFOGEOBDPH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter<ENDNIBADGNL> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x383CD60", Offset = "0x383C160", VA = "0x18383CD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x383F190", Offset = "0x383E590", VA = "0x18383F190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct BMFKGGCNHOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Task<ENPOEBKEFGA> whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private TaskAwaiter<ENPOEBKEFGA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x484F760", Offset = "0x484EB60", VA = "0x18484F760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x86F690", Offset = "0x86EA90", VA = "0x18086F690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct FPLCBJMLPPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public KKFOMOHKANB actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x33F2780", Offset = "0x33F1B80", VA = "0x1833F2780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x33F29C0", Offset = "0x33F1DC0", VA = "0x1833F29C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct MKJHCEPNLHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private KKFOMOHKANB <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3BB48D0", Offset = "0x3BB3CD0", VA = "0x183BB48D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4D60", Offset = "0x3BB4160", VA = "0x183BB4D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct KJFLCJLIILJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public KKFOMOHKANB actionContext;

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
		[Cpp2IlInjected.Address(RVA = "0x38E79A0", Offset = "0x38E6DA0", VA = "0x1838E79A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x38E8160", Offset = "0x38E7560", VA = "0x1838E8160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class KEKEEKKLMEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public KKFOMOHKANB actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public KEKEEKKLMEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x38C4960", Offset = "0x38C3D60", VA = "0x1838C4960")]
		internal Task<ENPOEBKEFGA> PDHALHCLDEH(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct NCHCLDCBPIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public KKFOMOHKANB actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private KEKEEKKLMEH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private TaskAwaiter<ENPOEBKEFGA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3BFB960", Offset = "0x3BFAD60", VA = "0x183BFB960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3BFC480", Offset = "0x3BFB880", VA = "0x183BFC480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class BEBOMNDACDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public KKFOMOHKANB actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public TaskCompletionSource<ENDNIBADGNL> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public BEBOMNDACDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x44971B0", Offset = "0x44965B0", VA = "0x1844971B0")]
		internal void MOOAIMBGNHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x4496EF0", Offset = "0x44962F0", VA = "0x184496EF0")]
		internal void DJKOJDLHMMF(BJBJGPACONH disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x4496F80", Offset = "0x4496380", VA = "0x184496F80")]
		internal void IHFIMCGEFKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class CMBELIOHEAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TaskCompletionSource<ENDNIBADGNL> reconnectToMasterServerTcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public BEBOMNDACDJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public CMBELIOHEAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x4AE6C10", Offset = "0x4AE6010", VA = "0x184AE6C10")]
		internal void BPKHFLNHDIL(BJBJGPACONH disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4AE6CB0", Offset = "0x4AE60B0", VA = "0x184AE6CB0")]
		internal void IGNFELPAEPK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct DMPIFOIJCIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public AsyncTaskMethodBuilder<ENPOEBKEFGA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public KKFOMOHKANB actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private BEBOMNDACDJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private CMBELIOHEAN <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TaskAwaiter<ENDNIBADGNL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4CA94A0", Offset = "0x4CA88A0", VA = "0x184CA94A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x4CAB570", Offset = "0x4CAA970", VA = "0x184CAB570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class PGNDEGLLDLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public KKFOMOHKANB actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public TaskCompletionSource<ENDNIBADGNL> reconnectToMasterServerTcs;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public PGNDEGLLDLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3DCF150", Offset = "0x3DCE550", VA = "0x183DCF150")]
		internal string HKOJPGGBOJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3DCF1C0", Offset = "0x3DCE5C0", VA = "0x183DCF1C0")]
		internal void LKMCAOLFJOC(ENDNIBADGNL _1, ENDNIBADGNL _2)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct NODMGLJLJFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public AsyncTaskMethodBuilder<ENDNIBADGNL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public KKFOMOHKANB actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private PGNDEGLLDLF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private TaskAwaiter<ENDNIBADGNL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3C34FE0", Offset = "0x3C343E0", VA = "0x183C34FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3C35D00", Offset = "0x3C35100", VA = "0x183C35D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct AMMGJMINCGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x36FEF20", Offset = "0x36FE320", VA = "0x1836FEF20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x86F690", Offset = "0x86EA90", VA = "0x18086F690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct ANDLDAEFIIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x36FF9C0", Offset = "0x36FEDC0", VA = "0x1836FF9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x36FFD40", Offset = "0x36FF140", VA = "0x1836FFD40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct EAFCACIHKEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public BJBJGPACONH disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private JGAPLIPHOHD <exception>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x302A5B0", Offset = "0x30299B0", VA = "0x18302A5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x86F690", Offset = "0x86EA90", VA = "0x18086F690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct IJEEIIDNFOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public BJBJGPACONH disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private HashSet<AHEPBJHLOPN>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x363B520", Offset = "0x363A920", VA = "0x18363B520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x363BF50", Offset = "0x363B350", VA = "0x18363BF50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct IGAPFLDIAIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private HashSet<ONAPCIBAJFM>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3635950", Offset = "0x3634D50", VA = "0x183635950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3635E30", Offset = "0x3635230", VA = "0x183635E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class PEIBIFPJIEB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public string timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public PEIBIFPJIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		internal string AHCHEMEOAAB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class CICMGPNBOOO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public KKFOMOHKANB actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public Dictionary<string, string> tcsTimeoutData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public NEIHNKIIOJK.CDGIGCKBFAG timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public CICMGPNBOOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4ADAEB0", Offset = "0x4ADA2B0", VA = "0x184ADAEB0")]
		internal void MLODLPCMDEM(string prefix, Dictionary<string, string> dict)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4ADB6D0", Offset = "0x4ADAAD0", VA = "0x184ADB6D0")]
		internal GJPJHHAMBIH PKNNMIFGKOA(TimeSpan timeoutTime)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class FHAFBGFLINN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public TaskCompletionSource<ENDNIBADGNL> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public FHAFBGFLINN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x33D8470", Offset = "0x33D7870", VA = "0x1833D8470")]
		internal void IKJNAPAONDA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct NKFLPMDIMDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public KKFOMOHKANB actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private FHAFBGFLINN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public ENDNIBADGNL connectedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public AppSettings appSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private TaskAwaiter<ENDNIBADGNL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3C11B40", Offset = "0x3C10F40", VA = "0x183C11B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3C12E30", Offset = "0x3C12230", VA = "0x183C12E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class IMKDOANMHGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public KKFOMOHKANB actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public IMKDOANMHGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3687E60", Offset = "0x3687260", VA = "0x183687E60")]
		internal object KGCECFEKIJC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class BACDNIKNMID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public KKFOMOHKANB actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public BACDNIKNMID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x443BE70", Offset = "0x443B270", VA = "0x18443BE70")]
		internal object CDGCAGEAOAP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class NBIMBPOILBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public ADKMJBDCCEO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public KKFOMOHKANB actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public NBIMBPOILBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3BFB010", Offset = "0x3BFA410", VA = "0x183BFB010")]
		internal object HGLOBJJAEGF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly Hashtable IEMINHCNHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly BLGKOMHDJIC ELPPNCIBDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly KAGKEKKANGF KFNCBONODEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected readonly string MLPJIOEIOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected readonly FENBOGEPBHH GBADCFKAFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private TaskCompletionSource<ENPOEBKEFGA> ELAAFEAMIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[NotNull]
	public readonly OIFLEICNDAM KDKACBOABHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected internal readonly TNetworking KECCEEPHDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private ushort KEMMPJJNCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private POGHEMJIJMB<GIFOGEOBDPH> MNEPCFOBIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private POGHEMJIJMB<bool> OCPDBCHFIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private POGHEMJIJMB<GAMIAJAKEJM> KEPKMGDHGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private POGHEMJIJMB<ENPOEBKEFGA> BKJGJPJFPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool DGFCHPDABNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private bool AJANLGICEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly HashSet<ONAPCIBAJFM> CPDFPAOOHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly HashSet<AHEPBJHLOPN> JLHHHMFEIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private bool GIAGFMCPJPC;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool KBINIFAGNPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x34629E0", Offset = "0x3461DE0", VA = "0x1834629E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	[CanBeNull]
	public GAMIAJAKEJM MHGBKMBBFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x34647D0", Offset = "0x3463BD0", VA = "0x1834647D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	protected ENDNIBADGNL DJAIKPJFBFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3465690", Offset = "0x3464A90", VA = "0x183465690")]
		get
		{
			return default(ENDNIBADGNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	[CanBeNull]
	public string OHPMMNNOFEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3463D60", Offset = "0x3463160", VA = "0x183463D60", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private TimeSpan GOIHCHEGHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3465360", Offset = "0x3464760", VA = "0x183465360")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private TimeSpan KMBBOOIDPFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x3464B50", Offset = "0x3463F50", VA = "0x183464B50")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public Task IFDAACGMOMC
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x34642F0", Offset = "0x34636F0", VA = "0x1834642F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract bool NNEEKCJNLBL(GAMIAJAKEJM CBJNNHMCKDJ);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3463BC0", Offset = "0x3462FC0", VA = "0x183463BC0")]
	private static TimeSpan GEJCKAPMJPJ(TimeSpan LJNGNHOEOJP, string LFAIHEECJFK)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3465930", Offset = "0x3464D30", VA = "0x183465930")]
	protected ADKMJBDCCEO(TNetworking EFGODGFKIGL, FENBOGEPBHH DHKOOLBBAFB, string ALNIPKACPEF, KAGKEKKANGF KFNCBONODEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3465970", Offset = "0x3464D70", VA = "0x183465970")]
	internal ADKMJBDCCEO(TNetworking EFGODGFKIGL, FENBOGEPBHH DHKOOLBBAFB, string ALNIPKACPEF, KAGKEKKANGF KFNCBONODEC, [Optional] BLGKOMHDJIC ELPPNCIBDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3462E40", Offset = "0x3462240", VA = "0x183462E40")]
	private void DHIEMINODNC(bool IAIELCEKOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3465430", Offset = "0x3464830", VA = "0x183465430")]
	private void OBPIFJOFELC(ENDNIBADGNL GHIHMIIOMCF, ENDNIBADGNL INMEJIBIMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3465060", Offset = "0x3464460", VA = "0x183465060")]
	internal KKFOMOHKANB NBPNKKOEONH()
	{
		return default(KKFOMOHKANB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3465520", Offset = "0x3464920", VA = "0x183465520")]
	[AsyncStateMachine(typeof(ADKMJBDCCEO<>.LOHNHFICBHO))]
	private Task<GIFOGEOBDPH> PKMLJFDOCOO(KKFOMOHKANB LKOALNBOENI, GIFOGEOBDPH HJKLPPHAIMD, CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3464C20", Offset = "0x3464020", VA = "0x183464C20")]
	[AsyncStateMachine(typeof(ADKMJBDCCEO<>.ADBHBLPDJLE))]
	protected Task<GIFOGEOBDPH> LGDEDHPKHCB(KKFOMOHKANB LKOALNBOENI, GIFOGEOBDPH HJKLPPHAIMD, CancellationToken MEGFHCBKLNI, CancellationToken IDHEMCMJEGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x34650B0", Offset = "0x34644B0", VA = "0x1834650B0")]
	[AsyncStateMachine(typeof(ADKMJBDCCEO<>.OKJOJKKPEOF))]
	protected Task NCJHLGGAMCI(KKFOMOHKANB LKOALNBOENI, CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3462690", Offset = "0x3461A90", VA = "0x183462690", Slot = "7")]
	[AsyncStateMachine(typeof(ADKMJBDCCEO<>.CDGFCCDGAAO))]
	public Task AEFMOCBEJCG([Optional] CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3464DA0", Offset = "0x34641A0", VA = "0x183464DA0")]
	[AsyncStateMachine(typeof(ADKMJBDCCEO<>.JJFNPMAMMLF))]
	private Task LGGEJLBOLNL(KKFOMOHKANB LKOALNBOENI, CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3463400", Offset = "0x3462800", VA = "0x183463400")]
	[AsyncStateMachine(typeof(ADKMJBDCCEO<>.KMEOADOHGOE))]
	private Task<bool> ENLLHHFOOGI(KKFOMOHKANB LKOALNBOENI, CancellationToken KJAGMGIFCEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3464380", Offset = "0x3463780", VA = "0x183464380", Slot = "8")]
	[AsyncStateMachine(typeof(ADKMJBDCCEO<>.BONJKBFBICK))]
	public Task<GAMIAJAKEJM> IEGFGJFPOMK(GAMIAJAKEJM CBJNNHMCKDJ, object JPGBCLJMEPC, [Optional] CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3464EE0", Offset = "0x34642E0", VA = "0x183464EE0")]
	[AsyncStateMachine(typeof(ADKMJBDCCEO<>.MOJKPICILKH))]
	private Task<GAMIAJAKEJM> LNIPPFELJEN(KKFOMOHKANB LKOALNBOENI, GAMIAJAKEJM CBJNNHMCKDJ, object JPGBCLJMEPC, CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x34649B0", Offset = "0x3463DB0", VA = "0x1834649B0")]
	[AsyncStateMachine(typeof(ADKMJBDCCEO<>.JICLHOJBFNH))]
	private Task<GAMIAJAKEJM> KKLGDMAIFKK(KKFOMOHKANB LKOALNBOENI, GAMIAJAKEJM CBJNNHMCKDJ, object JPGBCLJMEPC, CancellationToken MEGFHCBKLNI, CancellationToken IDHEMCMJEGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3463560", Offset = "0x3462960", VA = "0x183463560")]
	[AsyncStateMachine(typeof(ADKMJBDCCEO<>.BMFKGGCNHOM))]
	private void EOGOIFPMGPM(Task<ENPOEBKEFGA> JHAGDLOJBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3462A50", Offset = "0x3461E50", VA = "0x183462A50")]
	[AsyncStateMachine(typeof(ADKMJBDCCEO<>.FPLCBJMLPPA))]
	private Task CIAIGIBBBOL(KKFOMOHKANB LKOALNBOENI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3463000", Offset = "0x3462400", VA = "0x183463000", Slot = "9")]
	[AsyncStateMachine(typeof(ADKMJBDCCEO<>.MKJHCEPNLHH))]
	public Task EJHHGCJMJNB([Optional] CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3463DC0", Offset = "0x34631C0", VA = "0x183463DC0")]
	[AsyncStateMachine(typeof(ADKMJBDCCEO<>.KJFLCJLIILJ))]
	private Task HDOBBGHMIGO(KKFOMOHKANB LKOALNBOENI, [Optional] CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3462CF0", Offset = "0x34620F0", VA = "0x183462CF0")]
	[AsyncStateMachine(typeof(ADKMJBDCCEO<>.NCHCLDCBPIP))]
	private Task CLAMJHEGLHD(KKFOMOHKANB LKOALNBOENI, [Optional] CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3463F10", Offset = "0x3463310", VA = "0x183463F10")]
	[AsyncStateMachine(typeof(ADKMJBDCCEO<>.DMPIFOIJCIG))]
	private Task<ENPOEBKEFGA> HFOHNONPKGD(KKFOMOHKANB LKOALNBOENI, CancellationToken MEGFHCBKLNI, CancellationToken IDHEMCMJEGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3462B80", Offset = "0x3461F80", VA = "0x183462B80")]
	[AsyncStateMachine(typeof(ADKMJBDCCEO<>.NODMGLJLJFE))]
	private Task<ENDNIBADGNL> CJGANJLODGF(KKFOMOHKANB LKOALNBOENI, CancellationToken ELGJALILGJE, string GMCEKENFDDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3462940", Offset = "0x3461D40", VA = "0x183462940", Slot = "14")]
	protected virtual void BGCDIEDHKCK(KKFOMOHKANB LKOALNBOENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3464170", Offset = "0x3463570", VA = "0x183464170", Slot = "15")]
	protected virtual void HGKECGLMLPC(KKFOMOHKANB LKOALNBOENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3463110", Offset = "0x3462510", VA = "0x183463110")]
	private void ELCIIBFOLCB(KKFOMOHKANB LKOALNBOENI, MDPKDAJBHBC GMCEKENFDDF, params object[] CAAIHKBHIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "16")]
	protected virtual void HLNPGIKBNMF(GAMIAJAKEJM GCMKJHMLNLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3463B10", Offset = "0x3462F10", VA = "0x183463B10")]
	[AsyncStateMachine(typeof(ADKMJBDCCEO<>.AMMGJMINCGC))]
	private void FLFDIJPFODI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3464210", Offset = "0x3463610", VA = "0x183464210")]
	[AsyncStateMachine(typeof(ADKMJBDCCEO<>.ANDLDAEFIIA))]
	private Task HMALPMIJCLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x34645B0", Offset = "0x34639B0", VA = "0x1834645B0")]
	[AsyncStateMachine(typeof(ADKMJBDCCEO<>.EAFCACIHKEL))]
	private void JFGCECJEODC(BJBJGPACONH LLBKNLBACIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3465260", Offset = "0x3464660", VA = "0x183465260")]
	[AsyncStateMachine(typeof(ADKMJBDCCEO<>.IJEEIIDNFOF))]
	private Task NFECEAEHOAO(BJBJGPACONH LLBKNLBACIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3464080", Offset = "0x3463480", VA = "0x183464080")]
	[AsyncStateMachine(typeof(ADKMJBDCCEO<>.IGAPFLDIAIH))]
	private Task HFPPODOPGKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3465200", Offset = "0x3464600", VA = "0x183465200", Slot = "10")]
	public void NEIEEIEHJOP(AHEPBJHLOPN IFMDDPPNHFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2047AA0", Offset = "0x2046EA0", VA = "0x182047AA0")]
	private TaskCompletionSource<T> CEBBBGOIHKI<T>(KKFOMOHKANB LKOALNBOENI, CancellationToken ELGJALILGJE, TimeSpan LBOMALIMPNP, string DALDNLPBLPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x20478A0", Offset = "0x2046CA0", VA = "0x1820478A0")]
	private TaskCompletionSource<T> CEBBBGOIHKI<T>(KKFOMOHKANB LKOALNBOENI, CancellationToken ELGJALILGJE, TimeSpan LBOMALIMPNP, NEIHNKIIOJK.CDGIGCKBFAG DALDNLPBLPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3464670", Offset = "0x3463A70", VA = "0x183464670")]
	[AsyncStateMachine(typeof(ADKMJBDCCEO<>.NKFLPMDIMDH))]
	protected Task KBKBBBGILAJ(KKFOMOHKANB LKOALNBOENI, AppSettings PEKJMJJOJDA, ENDNIBADGNL KBPCLNNOCAG, CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3462F30", Offset = "0x3462330", VA = "0x183462F30", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3463620", Offset = "0x3462A20", VA = "0x183463620", Slot = "17")]
	protected virtual void FINNPNBJEED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3462FE0", Offset = "0x34623E0", VA = "0x183462FE0")]
	private static string EGNFPNKMCDP(KKFOMOHKANB LKOALNBOENI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	protected void PECDFFDPILO(string NJKPBIBMIJE, [Optional] KKFOMOHKANB LKOALNBOENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3464820", Offset = "0x3463C20", VA = "0x183464820")]
	protected void KJGJEBHBCFI(string NJKPBIBMIJE, [Optional] KKFOMOHKANB LKOALNBOENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3463270", Offset = "0x3462670", VA = "0x183463270")]
	protected void ENFDFEEIPGI(string NJKPBIBMIJE, [Optional] KKFOMOHKANB LKOALNBOENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x34627A0", Offset = "0x3461BA0", VA = "0x1834627A0")]
	protected void BEPDGOPOJJC(string NJKPBIBMIJE, Exception APLJIBADEAL, [Optional] KKFOMOHKANB LKOALNBOENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x34644E0", Offset = "0x34638E0", VA = "0x1834644E0")]
	public void IPDFGCFECDG(EIAKNHLGOIC GLHKMBBOAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3463960", Offset = "0x3462D60", VA = "0x183463960")]
	[CompilerGenerated]
	private void FKIGPNHNEMG(NHFKPAOGFHM GGCHAANGNGC, NHFKPAOGFHM LJEABKGMCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2047F20", Offset = "0x2047320", VA = "0x182047F20")]
	[CompilerGenerated]
	internal static string MKHBACOIMAO<T>(TimeSpan FHEAEFLMJDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct KKFOMOHKANB : IEquatable<KKFOMOHKANB>, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public readonly ushort MKKCLMJDODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public readonly string MLPJIOEIOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly LHLMJCKPLDG EFGODGFKIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly Stopwatch MKKMIIDECLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly List<(TimeSpan, ENDNIBADGNL, ENDNIBADGNL)> NFPCPDHGIFH;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public TimeSpan PKEPHKANBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5CDEFB0", Offset = "0x5CDE3B0", VA = "0x185CDEFB0")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IReadOnlyList<(TimeSpan time, ENDNIBADGNL oldState, ENDNIBADGNL newState)> NLOIPCMLIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x764960", Offset = "0x763D60", VA = "0x180764960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5CDF1C0", Offset = "0x5CDE5C0", VA = "0x185CDF1C0")]
	public KKFOMOHKANB(ushort ACINPHFOPOG, string ALNIPKACPEF, LHLMJCKPLDG EFGODGFKIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5CDF090", Offset = "0x5CDE490", VA = "0x185CDF090")]
	private void KGDILBAKPIG(ENDNIBADGNL GHIHMIIOMCF, ENDNIBADGNL INMEJIBIMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5CDEFD0", Offset = "0x5CDE3D0", VA = "0x185CDEFD0", Slot = "4")]
	public bool Equals(KKFOMOHKANB LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5CDEFE0", Offset = "0x5CDE3E0", VA = "0x185CDEFE0", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5CDF070", Offset = "0x5CDE470", VA = "0x185CDF070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5CDF1A0", Offset = "0x5CDE5A0", VA = "0x185CDF1A0")]
	public static bool MEMFAJGIIAO(KKFOMOHKANB GFPOLPOKADD, KKFOMOHKANB PBBDJDKAOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5CDEE60", Offset = "0x5CDE260", VA = "0x185CDEE60", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal static class LDGBFAOHFMH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct HPGHKCFMLAK<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public POGHEMJIJMB<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public KKFOMOHKANB doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x35710B0", Offset = "0x35704B0", VA = "0x1835710B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3571360", Offset = "0x3570760", VA = "0x183571360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct AIGDGNPLKAL<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public POGHEMJIJMB<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public TimeSpan forceCancelTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public KKFOMOHKANB doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x34A8700", Offset = "0x34A7B00", VA = "0x1834A8700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x34A8BA0", Offset = "0x34A7FA0", VA = "0x1834A8BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct PPKMLFEEEKO<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public POGHEMJIJMB<TArgs> clientAction;

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
		[Cpp2IlInjected.Address(RVA = "0x3E12820", Offset = "0x3E11C20", VA = "0x183E12820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x38E7900", Offset = "0x38E6D00", VA = "0x1838E7900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x244E0B0", Offset = "0x244D4B0", VA = "0x18244E0B0")]
	[AsyncStateMachine(typeof(HPGHKCFMLAK<>))]
	public static Task DLNHHDEJAEJ<TArgs>(this POGHEMJIJMB<TArgs> OPGEGLOLHAB, [Optional] KKFOMOHKANB MEICBFPILEO) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x244DE50", Offset = "0x244D250", VA = "0x18244DE50")]
	[AsyncStateMachine(typeof(AIGDGNPLKAL<>))]
	public static Task BCNBCGINOIG<TArgs>(this POGHEMJIJMB<TArgs> OPGEGLOLHAB, TimeSpan JFFMNICLKMA, [Optional] KKFOMOHKANB MEICBFPILEO) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x244E740", Offset = "0x244DB40", VA = "0x18244E740")]
	public static (bool, bool) OPFHMIDHPLH<TArgs>(this POGHEMJIJMB<TArgs> OPGEGLOLHAB, TArgs BGICHGONLEL, [Out] string PLENNALIFKG) where TArgs : IEquatable<TArgs>
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x244E410", Offset = "0x244D810", VA = "0x18244E410")]
	[AsyncStateMachine(typeof(PPKMLFEEEKO<>))]
	public static Task<TArgs> EJLDHPIEFAN<TArgs>(this POGHEMJIJMB<TArgs> OPGEGLOLHAB, TArgs BGICHGONLEL, CancellationToken MHNEJAJIJIG) where TArgs : IEquatable<TArgs>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal class POGHEMJIJMB<TArgs> : IDisposable where TArgs : IEquatable<TArgs>
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate Task<TArgs> JALBPCICCLO(CancellationToken KFOMCPLGGIC, CancellationToken KAPONPPJMPM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct HLJCCEKLFOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public POGHEMJIJMB<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public KKFOMOHKANB doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public TimeSpan forceCancelAfter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3568E60", Offset = "0x3568260", VA = "0x183568E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x3569670", Offset = "0x3568A70", VA = "0x183569670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct IPKMIGJLALC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public POGHEMJIJMB<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public KKFOMOHKANB doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x3693E20", Offset = "0x3693220", VA = "0x183693E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3694300", Offset = "0x3693700", VA = "0x183694300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct KFAAKBOPKLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public POGHEMJIJMB<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x38D4920", Offset = "0x38D3D20", VA = "0x1838D4920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x38D4DE0", Offset = "0x38D41E0", VA = "0x1838D4DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct MFCDKFALHNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public POGHEMJIJMB<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public JALBPCICCLO taskFactory;

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
		[Cpp2IlInjected.Address(RVA = "0x3B61870", Offset = "0x3B60C70", VA = "0x183B61870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x3B63400", Offset = "0x3B62800", VA = "0x183B63400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct JABLKOMIPAP : IAsyncStateMachine
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
		public POGHEMJIJMB<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x382D4C0", Offset = "0x382C8C0", VA = "0x18382D4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x356FA20", Offset = "0x356EE20", VA = "0x18356FA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private bool EJHKEMCAIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private bool MLKLFOAEOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private bool BOOMOBOFFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private CancellationTokenSource OGPHAHGCCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private CancellationTokenSource OMLGBHNAOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly KKFOMOHKANB LKOALNBOENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly CancellationToken CLGPMABAGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly TArgs BGICHGONLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private TArgs OJIAHHODKNI;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public TArgs PNJHIMNMKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3E10160", Offset = "0x3E0F560", VA = "0x183E10160")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TArgs CHCAGNEGCCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3E0EA60", Offset = "0x3E0DE60", VA = "0x183E0EA60")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	[CanBeNull]
	public Task<TArgs> CJOAPPLOCPK
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7610A0", Offset = "0x7604A0", VA = "0x1807610A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x761110", Offset = "0x760510", VA = "0x180761110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3E10560", Offset = "0x3E0F960", VA = "0x183E10560")]
	public POGHEMJIJMB(TArgs LHGNKNKDHKH, CancellationToken CLGPMABAGGJ, KKFOMOHKANB LKOALNBOENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3E0E7C0", Offset = "0x3E0DBC0", VA = "0x183E0E7C0")]
	[AsyncStateMachine(typeof(POGHEMJIJMB<>.HLJCCEKLFOL))]
	public Task AHACNCDCAOF(TimeSpan LMNDMOEADIP, KKFOMOHKANB BBPFOIEMGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3E10020", Offset = "0x3E0F420", VA = "0x183E10020")]
	[AsyncStateMachine(typeof(POGHEMJIJMB<>.IPKMIGJLALC))]
	public Task IOODLEIGBMF(KKFOMOHKANB BBPFOIEMGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3E0F200", Offset = "0x3E0E600", VA = "0x183E0F200", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3E0E4E0", Offset = "0x3E0D8E0", VA = "0x183E0E4E0")]
	[AsyncStateMachine(typeof(POGHEMJIJMB<>.KFAAKBOPKLN))]
	private Task ACFNLOLHMHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3E0EA80", Offset = "0x3E0DE80", VA = "0x183E0EA80")]
	[AsyncStateMachine(typeof(POGHEMJIJMB<>.MFCDKFALHNJ))]
	public Task<TArgs> CNNECPIIMCJ(JALBPCICCLO HECLGKEKAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3E0F680", Offset = "0x3E0EA80", VA = "0x183E0F680")]
	[AsyncStateMachine(typeof(POGHEMJIJMB<>.JABLKOMIPAP))]
	private Task<TArgs> EIJDIELOPCL(Task<TArgs> IEKBMFBECLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3E10170", Offset = "0x3E0F570", VA = "0x183E10170")]
	public bool PIBOEMHBFFI(TArgs KACNOJDGCMN, [Out] string PLENNALIFKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3E0FBF0", Offset = "0x3E0EFF0", VA = "0x183E0FBF0")]
	private bool GOEGHOGIABC(TArgs KACNOJDGCMN, [Out] string PLENNALIFKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3E0EE10", Offset = "0x3E0E210", VA = "0x183E0EE10")]
	public CancellationTokenRegistration? DCGKOADMKDD(CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3E0EA40", Offset = "0x3E0DE40", VA = "0x183E0EA40")]
	[CompilerGenerated]
	private void BMIDLDBPDAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface KAGKEKKANGF
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MBJCNODEBNE(string ALNIPKACPEF, string LNPLHMOGPHG, KKFOMOHKANB LKOALNBOENI, [Optional] string FDKHOCAIJLE);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AAKHDNNGGGN(string ALNIPKACPEF, string LNPLHMOGPHG, KKFOMOHKANB LKOALNBOENI, [Optional] string FDKHOCAIJLE);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KALPHMPPMMF(string ALNIPKACPEF, string LNPLHMOGPHG, KKFOMOHKANB LKOALNBOENI, [Optional] string FDKHOCAIJLE);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JIJIEOOOFNI(string ALNIPKACPEF, string LNPLHMOGPHG, KKFOMOHKANB LKOALNBOENI, Exception NNOCBMIAGOK, [Optional] string FDKHOCAIJLE);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IOCNCADAPMD(string ALNIPKACPEF, JGAPLIPHOHD ODAOOBOCJCA);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal static class NPEDEDIGMBA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct PEGOBCBPKGL<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public KAGKEKKANGF analytics;

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
		public KKFOMOHKANB actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x3DC5AF0", Offset = "0x3DC4EF0", VA = "0x183DC5AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x356FA20", Offset = "0x356EE20", VA = "0x18356FA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct IDFJJBJLIMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public KAGKEKKANGF analytics;

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
		public KKFOMOHKANB actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5CDBE50", Offset = "0x5CDB250", VA = "0x185CDBE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5CDC310", Offset = "0x5CDB710", VA = "0x185CDC310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x24EC5E0", Offset = "0x24EB9E0", VA = "0x1824EC5E0")]
	[AsyncStateMachine(typeof(PEGOBCBPKGL<>))]
	public static Task<T> LPOELNNOCBK<T>(this Task<T> FODAKAIIBEG, [CanBeNull] KAGKEKKANGF KFNCBONODEC, string ALNIPKACPEF, string LNPLHMOGPHG, KKFOMOHKANB LKOALNBOENI, [Optional] string FDKHOCAIJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2980", Offset = "0x5CE1D80", VA = "0x185CE2980")]
	[AsyncStateMachine(typeof(IDFJJBJLIMG))]
	public static Task LPOELNNOCBK(this Task FODAKAIIBEG, [CanBeNull] KAGKEKKANGF KFNCBONODEC, string ALNIPKACPEF, string LNPLHMOGPHG, KKFOMOHKANB LKOALNBOENI, [Optional] string FDKHOCAIJLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public delegate Task ONAPCIBAJFM();
[Cpp2IlInjected.Token(Token = "0x200004E")]
public delegate Task AHEPBJHLOPN(BJBJGPACONH LLBKNLBACIC);
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class IOGOIPKBBHD : NHFKPAOGFHM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly EIAKNHLGOIC GHLELJIAIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly Func<IOGOIPKBBHD, bool> OHJIGAICCMJ;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ENDNIBADGNL DJAIKPJFBFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5CDC8A0", Offset = "0x5CDBCA0", VA = "0x185CDC8A0", Slot = "4")]
		get
		{
			return default(ENDNIBADGNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public ELFHKIFMINK OHAPFDLNNFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5CDC800", Offset = "0x5CDBC00", VA = "0x185CDC800", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool KBINIFAGNPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5CDC570", Offset = "0x5CDB970", VA = "0x185CDC570", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool DCMKPMAFHGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5CDC820", Offset = "0x5CDBC20", VA = "0x185CDC820", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool NOFDHONNOAE
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5CDC7E0", Offset = "0x5CDBBE0", VA = "0x185CDC7E0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Exception HJCHOOKGMHH
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5CDC8C0", Offset = "0x5CDBCC0", VA = "0x185CDC8C0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public StatusCode INMJHLJPNLB
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5CDC6F0", Offset = "0x5CDBAF0", VA = "0x185CDC6F0", Slot = "16")]
		get
		{
			return default(StatusCode);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event EIAKNHLGOIC.EOECGNHFPNP HNIFHMMOBAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5CDC880", Offset = "0x5CDBC80", VA = "0x185CDC880", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5CDC6D0", Offset = "0x5CDBAD0", VA = "0x185CDC6D0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<ENDNIBADGNL, ENDNIBADGNL> CMMICIJEKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5CDC710", Offset = "0x5CDBB10", VA = "0x185CDC710", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5CDC590", Offset = "0x5CDB990", VA = "0x185CDC590", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5CDC8E0", Offset = "0x5CDBCE0", VA = "0x185CDC8E0")]
	public IOGOIPKBBHD(EIAKNHLGOIC GHLELJIAIOK, [Optional] Func<IOGOIPKBBHD, bool> OHJIGAICCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5CDC640", Offset = "0x5CDBA40", VA = "0x185CDC640", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5CDC7C0", Offset = "0x5CDBBC0", VA = "0x185CDC7C0")]
	private void JLJLLBBFKGN(ENDNIBADGNL GHIHMIIOMCF, ENDNIBADGNL INMEJIBIMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5CDC860", Offset = "0x5CDBC60", VA = "0x185CDC860", Slot = "13")]
	public void PEBKCDHKOFF(object BGICHGONLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5CDC840", Offset = "0x5CDBC40", VA = "0x185CDC840", Slot = "14")]
	public void OHJJMCEPLLC(object BGICHGONLEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class OOEJBBBBCOF : FNEDNIJBEBA, NHBLADMBPDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class FOKEDCLPPBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public GAMIAJAKEJM targetRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public FOKEDCLPPBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5CDA320", Offset = "0x5CD9720", VA = "0x185CDA320")]
		internal bool ONCFIBBCKGK(BPLKHKMOOON c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class AGFGOPNGMOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public AGFGOPNGMOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5CD5D20", Offset = "0x5CD5120", VA = "0x185CD5D20")]
		internal Task DJALJIBHCMF(BPLKHKMOOON c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct KGLNEJPAHAH : IAsyncStateMachine
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
		public OOEJBBBBCOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5CDEB70", Offset = "0x5CDDF70", VA = "0x185CDEB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x5CDEE00", Offset = "0x5CDE200", VA = "0x185CDEE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct KDFEPFJOHEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public AsyncTaskMethodBuilder<GAMIAJAKEJM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public OOEJBBBBCOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public GAMIAJAKEJM targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private GAMIAJAKEJM <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter<GAMIAJAKEJM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x5CDE620", Offset = "0x5CDDA20", VA = "0x185CDE620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x5CDEB00", Offset = "0x5CDDF00", VA = "0x185CDEB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class DNKPAIKMHLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public DNKPAIKMHLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x5CD9280", Offset = "0x5CD8680", VA = "0x185CD9280")]
		internal Task GEKGBFGDKHD(BPLKHKMOOON c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct PGILFIGCAIN : IAsyncStateMachine
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
		public OOEJBBBBCOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3AB0", Offset = "0x5CE2EB0", VA = "0x185CE3AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3D40", Offset = "0x5CE3140", VA = "0x185CE3D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public readonly CAKIFIAMPIO EOOELCBLBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public readonly MCHNGPEOGPG BEEPILCPLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly BPLKHKMOOON[] COLKDNNCDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public readonly LBMNPLNHIMN LMEPAMDHJGF;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public GAMIAJAKEJM MHGBKMBBFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5CE36C0", Offset = "0x5CE2AC0", VA = "0x185CE36C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string OHPMMNNOFEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3480", Offset = "0x5CE2880", VA = "0x185CE3480", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private IEnumerable<BPLKHKMOOON> JICJJADFLAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5CE34D0", Offset = "0x5CE28D0", VA = "0x185CE34D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private CKGIIMKOAEJ CJEJLMNHFGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Task IFDAACGMOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3510", Offset = "0x5CE2910", VA = "0x185CE3510", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3830", Offset = "0x5CE2C30", VA = "0x185CE3830", Slot = "7")]
	public bool NNEEKCJNLBL(GAMIAJAKEJM CBJNNHMCKDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3910", Offset = "0x5CE2D10", VA = "0x185CE3910")]
	[Preserve]
	public OOEJBBBBCOF([LOJAGCNCPBJ(null)] CAKIFIAMPIO GEMEBIOGIFK, [LOJAGCNCPBJ(null)] MCHNGPEOGPG IKBLLGNDCLO, [LOJAGCNCPBJ(null)] LBMNPLNHIMN GDONKOEDIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3050", Offset = "0x5CE2450", VA = "0x185CE3050", Slot = "8")]
	[AsyncStateMachine(typeof(KGLNEJPAHAH))]
	public Task AEFMOCBEJCG([Optional] CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3560", Offset = "0x5CE2960", VA = "0x185CE3560", Slot = "9")]
	[AsyncStateMachine(typeof(KDFEPFJOHEC))]
	public Task<GAMIAJAKEJM> IEGFGJFPOMK(GAMIAJAKEJM CBJNNHMCKDJ, object JPGBCLJMEPC, [Optional] CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3390", Offset = "0x5CE2790", VA = "0x185CE3390", Slot = "10")]
	[AsyncStateMachine(typeof(PGILFIGCAIN))]
	public Task EJHHGCJMJNB([Optional] CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3140", Offset = "0x5CE2540", VA = "0x185CE3140", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3710", Offset = "0x5CE2B10", VA = "0x185CE3710", Slot = "11")]
	public void NEIEEIEHJOP(AHEPBJHLOPN IFMDDPPNHFI)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct ENPOEBKEFGA : IEquatable<ENPOEBKEFGA>
{
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public static readonly ENPOEBKEFGA BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7785F0", Offset = "0x7779F0", VA = "0x1807785F0", Slot = "4")]
	public bool Equals(ENPOEBKEFGA LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5CD92E0", Offset = "0x5CD86E0", VA = "0x185CD92E0", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x75E5C0", Offset = "0x75D9C0", VA = "0x18075E5C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class IMFIAOHBCKC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5CDC3E0", Offset = "0x5CDB7E0", VA = "0x185CDC3E0")]
	public IMFIAOHBCKC(string NJKPBIBMIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5CDC370", Offset = "0x5CDB770", VA = "0x185CDC370")]
	public IMFIAOHBCKC(string NJKPBIBMIJE, Exception BEGMFKDODGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class IMKLEDAELLG : IMFIAOHBCKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public readonly string FNDBLJKEHGD;

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x5CDC440", Offset = "0x5CDB840", VA = "0x185CDC440")]
	public IMKLEDAELLG(string LIOPJDNMJKA, [NotNull] Exception BEGMFKDODGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class NPCABHOELPH : IMFIAOHBCKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public readonly GAMIAJAKEJM IMMAPPPPGGP;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2860", Offset = "0x5CE1C60", VA = "0x185CE2860")]
	public NPCABHOELPH(GAMIAJAKEJM JGGCFBKJFCO, [NotNull] Exception BEGMFKDODGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class JGAMDILCBIL : IMFIAOHBCKC
{
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x5CDC3E0", Offset = "0x5CDB7E0", VA = "0x185CDC3E0")]
	public JGAMDILCBIL(string NJKPBIBMIJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class JGAPLIPHOHD : IMFIAOHBCKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public readonly StatusCode? INMJHLJPNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public readonly BJBJGPACONH GNEMFJIGPPD;

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x5CDCD30", Offset = "0x5CDC130", VA = "0x185CDCD30")]
	public JGAPLIPHOHD(BJBJGPACONH LLBKNLBACIC, Exception BEGMFKDODGM, StatusCode? IIPDMFOHIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5CDCA90", Offset = "0x5CDBE90", VA = "0x185CDCA90")]
	public static JGAPLIPHOHD HOFFBJBHLOH(BJBJGPACONH OJIFENIBHNE, NHFKPAOGFHM HGGHEIIIMNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class LBMMFDFLCJB : IMFIAOHBCKC
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5CDC3E0", Offset = "0x5CDB7E0", VA = "0x185CDC3E0")]
	public LBMMFDFLCJB(string NJKPBIBMIJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class HAABPMIMKGB : IMFIAOHBCKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public readonly short GOBNJPNIJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public readonly string NKDEKAPEKIO;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5CDB150", Offset = "0x5CDA550", VA = "0x185CDB150")]
	public HAABPMIMKGB(short PBOIJGEHGIH, string FDOBFFACGFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class JDGDFFLPDAN : IMFIAOHBCKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public readonly short GOBNJPNIJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public readonly string NKDEKAPEKIO;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5CDC9A0", Offset = "0x5CDBDA0", VA = "0x185CDC9A0")]
	public JDGDFFLPDAN(short PBOIJGEHGIH, string FDOBFFACGFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class LGJPFDFMNDB : IMFIAOHBCKC
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5CDC3E0", Offset = "0x5CDB7E0", VA = "0x185CDC3E0")]
	public LGJPFDFMNDB(string NJKPBIBMIJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class BDMLHIKHPNE : IMFIAOHBCKC
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5D80", Offset = "0x5CD5180", VA = "0x185CD5D80")]
	public BDMLHIKHPNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class GJPJHHAMBIH : NNBNMLJOLLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public readonly Dictionary<string, string> BDPPCMEDHMC;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5CDB100", Offset = "0x5CDA500", VA = "0x185CDB100")]
	public GJPJHHAMBIH(TimeSpan LBOMALIMPNP, string NJKPBIBMIJE, Dictionary<string, string> FDKHOCAIJLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class OIFLEICNDAM : FGPBJGDEOFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly OCLNKBDMPPE<BJBJGPACONH> OEPOAOKAILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private readonly OCLNKBDMPPE<BJBJGPACONH> LHBDJGCJHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private readonly OCLNKBDMPPE<BJBJGPACONH> KBCIBLINGLN;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<BJBJGPACONH> EGKLLGLIBKA
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2DE0", Offset = "0x5CE21E0", VA = "0x185CE2DE0")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2CC0", Offset = "0x5CE20C0", VA = "0x185CE2CC0")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action<BJBJGPACONH> CPMDHHFDKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2C00", Offset = "0x5CE2000", VA = "0x185CE2C00")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2D80", Offset = "0x5CE2180", VA = "0x185CE2D80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<BJBJGPACONH> JEFIICAHBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2C60", Offset = "0x5CE2060", VA = "0x185CE2C60")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2D20", Offset = "0x5CE2120", VA = "0x185CE2D20")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2E40", Offset = "0x5CE2240", VA = "0x185CE2E40", Slot = "31")]
	public override void OnDisconnected(BJBJGPACONH LLBKNLBACIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2F40", Offset = "0x5CE2340", VA = "0x185CE2F40")]
	public OIFLEICNDAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class CAKIFIAMPIO : ADKMJBDCCEO<MLIGLPPOEFP>, CKGIIMKOAEJ, BPLKHKMOOON, NHBLADMBPDF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct BLDHCCHJHHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public CAKIFIAMPIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private CancellationToken <token>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5CD5E00", Offset = "0x5CD5200", VA = "0x185CD5E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x86F690", Offset = "0x86EA90", VA = "0x18086F690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class CKMHBFBIOIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public CAKIFIAMPIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public KKFOMOHKANB actionContext;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public CKMHBFBIOIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5CD6F80", Offset = "0x5CD6380", VA = "0x185CD6F80")]
		internal void GMCBBGDICKD(CBIPFMDCEHJ<string> timer, FBKCBHAMJJJ log)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct DHPLKAGODFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public AsyncTaskMethodBuilder<IReadOnlyDictionary<string, int>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public CAKIFIAMPIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private CKMHBFBIOIH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public TimeSpan? timeoutSpan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private CBIPFMDCEHJ<string> <pingStackTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private CBIPFMDCEHJ<string>.OLALGCKMEOA <pingTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private Stopwatch <sw>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private Dictionary<string, int> <regionPings>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private TaskAwaiter<GIFOGEOBDPH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private CBIPFMDCEHJ<string>.OLALGCKMEOA <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private YieldAwaitable.YieldAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x5CD70D0", Offset = "0x5CD64D0", VA = "0x185CD70D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x5CD9210", Offset = "0x5CD8610", VA = "0x185CD9210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private CancellationTokenSource LJPCJCDJNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private CancellationTokenSource JMNJBGIHGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private CancellationToken? LEKAFEMBEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private bool BFMOKCJBALA;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool BKGBHOLLOMD
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7F8460", Offset = "0x7F7860", VA = "0x1807F8460")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x5CD6600", Offset = "0x5CD5A00", VA = "0x185CD6600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6CE0", Offset = "0x5CD60E0", VA = "0x185CD6CE0", Slot = "13")]
	public override bool NNEEKCJNLBL(GAMIAJAKEJM CBJNNHMCKDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6E20", Offset = "0x5CD6220", VA = "0x185CD6E20")]
	[Preserve]
	public CAKIFIAMPIO([LOJAGCNCPBJ(null)] MLIGLPPOEFP EFGODGFKIGL, [LOJAGCNCPBJ(null)] FENBOGEPBHH DHKOOLBBAFB, [LOJAGCNCPBJ(null)] KAGKEKKANGF KFNCBONODEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6ED0", Offset = "0x5CD62D0", VA = "0x185CD6ED0")]
	internal CAKIFIAMPIO(MLIGLPPOEFP EFGODGFKIGL, FENBOGEPBHH DHKOOLBBAFB, KAGKEKKANGF KFNCBONODEC, BLGKOMHDJIC ELPPNCIBDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6950", Offset = "0x5CD5D50", VA = "0x185CD6950", Slot = "17")]
	protected override void FINNPNBJEED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6D40", Offset = "0x5CD6140", VA = "0x185CD6D40")]
	private void OGLGMFFMODB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6A60", Offset = "0x5CD5E60", VA = "0x185CD6A60", Slot = "16")]
	protected override void HLNPGIKBNMF(GAMIAJAKEJM GCMKJHMLNLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5CD66D0", Offset = "0x5CD5AD0", VA = "0x185CD66D0", Slot = "14")]
	protected override void BGCDIEDHKCK(KKFOMOHKANB LKOALNBOENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5CD69E0", Offset = "0x5CD5DE0", VA = "0x185CD69E0", Slot = "15")]
	protected override void HGKECGLMLPC(KKFOMOHKANB LKOALNBOENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6C30", Offset = "0x5CD6030", VA = "0x185CD6C30")]
	[AsyncStateMachine(typeof(BLDHCCHJHHD))]
	private void MJMLNGHFEML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6820", Offset = "0x5CD5C20", VA = "0x185CD6820", Slot = "18")]
	[AsyncStateMachine(typeof(DHPLKAGODFC))]
	public Task<IReadOnlyDictionary<string, int>> CCDNKDPCBIC([Optional] TimeSpan? MCEEOLLDCOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class GAMIAJAKEJM : GIFOGEOBDPH, IEquatable<GAMIAJAKEJM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public readonly string KGHPDEBFOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly string? KIJONKMGJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public readonly string? PIOKPKFGGGE;

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x5CDA730", Offset = "0x5CD9B30", VA = "0x185CDA730")]
	public GAMIAJAKEJM(string OBFFDNIPGBF, string HOJEHFLCCPC, string CLDEPPMNKOD, string? OLBAEDPBGMK, string KBDCCEKMLLF, string LBGLMHHJHJJ, string? NFCGEFNEGDG, string? JBEBPMMEGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5CDA6D0", Offset = "0x5CD9AD0", VA = "0x185CDA6D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5CDA3F0", Offset = "0x5CD97F0", VA = "0x185CDA3F0", Slot = "5")]
	public bool Equals(GAMIAJAKEJM? LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5CDA470", Offset = "0x5CD9870", VA = "0x185CDA470", Slot = "0")]
	public override bool Equals(object? BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5CDA590", Offset = "0x5CD9990", VA = "0x185CDA590", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x1B2BA40", Offset = "0x1B2AE40", VA = "0x181B2BA40")]
	public static bool MEMFAJGIIAO(GAMIAJAKEJM? GFPOLPOKADD, GAMIAJAKEJM? PBBDJDKAOCN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x1430620", Offset = "0x142FA20", VA = "0x181430620")]
	public static bool OPPLDLMADNB(GAMIAJAKEJM? GFPOLPOKADD, GAMIAJAKEJM? PBBDJDKAOCN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class GIFOGEOBDPH : IEquatable<GIFOGEOBDPH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public readonly string PAAIKHEBDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public readonly string? MNPPNINPBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public readonly string? BMICDAINAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public readonly string? NDDNJBEANBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public readonly string DDEKMLLMBHI;

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x5CDABE0", Offset = "0x5CD9FE0", VA = "0x185CDABE0")]
	public GIFOGEOBDPH(string OBFFDNIPGBF, string? HOJEHFLCCPC, string? CLDEPPMNKOD, string? OLBAEDPBGMK, string KBDCCEKMLLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5CDAB80", Offset = "0x5CD9F80", VA = "0x185CDAB80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x5CDA920", Offset = "0x5CD9D20", VA = "0x185CDA920", Slot = "4")]
	public bool Equals(GIFOGEOBDPH? LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5CDA9B0", Offset = "0x5CD9DB0", VA = "0x185CDA9B0", Slot = "0")]
	public override bool Equals(object? BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5CDAA90", Offset = "0x5CD9E90", VA = "0x185CDAA90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class MCHNGPEOGPG : ADKMJBDCCEO<MCHNGPEOGPG.HENBMADAEGE>
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public interface IOONAAFFIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool DDLBHJKJIEJ();
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class HENBMADAEGE : LHLMJCKPLDG, FAJONMKLMEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private NHFKPAOGFHM DFAOJIMCPDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private bool AOEBKFOBNCG;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		private PhotonVoiceNetwork MHAEMHAONGI
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x5CDB760", Offset = "0x5CDAB60", VA = "0x185CDB760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool OHMAFKDGICH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xC6B720", Offset = "0xC6AB20", VA = "0x180C6B720", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public NHFKPAOGFHM HIOIJDDIHGC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool DCMKPMAFHGN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x5CDBC90", Offset = "0x5CDB090", VA = "0x185CDBC90", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool ILIACOFMHNB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x5CDBDC0", Offset = "0x5CDB1C0", VA = "0x185CDBDC0", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x75C570", Offset = "0x75B970", VA = "0x18075C570", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool FGOMAPLMOGO
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool KBINIFAGNPO
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x5CDB4F0", Offset = "0x5CDA8F0", VA = "0x185CDB4F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public LDMJAJANBKI DLDAIKDONEP
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x5CDBCE0", Offset = "0x5CDB0E0", VA = "0x185CDBCE0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool BJFEPCNKBNI
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5CDB870", Offset = "0x5CDAC70", VA = "0x185CDB870", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<NHFKPAOGFHM, NHFKPAOGFHM> KFKMNGKMHPE
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x5CDBBE0", Offset = "0x5CDAFE0", VA = "0x185CDBBE0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x5CDB7C0", Offset = "0x5CDABC0", VA = "0x185CDB7C0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<bool> JOILMAIIFFN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x5CDB540", Offset = "0x5CDA940", VA = "0x185CDB540", Slot = "9")]
		public void CAHMPNOMOFB(EIAKNHLGOIC IKBLLGNDCLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x5CDB980", Offset = "0x5CDAD80", VA = "0x185CDB980", Slot = "16")]
		public bool JECCICLMKAL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x5CDB340", Offset = "0x5CDA740", VA = "0x185CDB340", Slot = "17")]
		public bool BKIAOMFJHCO(string LBGLMHHJHJJ, JOLFKJJOPME GENAHMOEODI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5CDB240", Offset = "0x5CDA640", VA = "0x185CDB240", Slot = "18")]
		public void AEFMOCBEJCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x5CDBAB0", Offset = "0x5CDAEB0", VA = "0x185CDBAB0", Slot = "19")]
		public bool LLKMIKJGLAH(AppSettings PEKJMJJOJDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "22")]
		public void HFPBBOPAGJI(object KJAGMGIFCEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "23")]
		public void FPBOAGPCPGG(object KJAGMGIFCEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "24")]
		public void ABOANEJLHIN(object KJAGMGIFCEM, bool JLDINMBJPKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x5CDB710", Offset = "0x5CDAB10", VA = "0x185CDB710", Slot = "25")]
		public IDisposable EGMBLOKDPDI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "26")]
		private bool DNAIOHLPGMI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "27")]
		public void JBMLFCHAPBC(StringBuilder GJAPOCEAGBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5CDB610", Offset = "0x5CDAA10", VA = "0x185CDB610", Slot = "28")]
		public bool EFLACDDKPJG(bool FKCEKAIEIPO, [Out] string GHNPOMJGELJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public HENBMADAEGE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct BMFJFIBMDHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public MCHNGPEOGPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public CAKIFIAMPIO clientToFollow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private TaskAwaiter<GAMIAJAKEJM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5CD6290", Offset = "0x5CD5690", VA = "0x185CD6290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5CD65A0", Offset = "0x5CD59A0", VA = "0x185CD65A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct GJDJBHJPGBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public MCHNGPEOGPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x5CDAD30", Offset = "0x5CDA130", VA = "0x185CDAD30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5CDB0A0", Offset = "0x5CDA4A0", VA = "0x185CDB0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private readonly CAKIFIAMPIO GEMEBIOGIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private readonly IOONAAFFIOJ NLJKAPOJPKH;

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x5CE19E0", Offset = "0x5CE0DE0", VA = "0x185CE19E0", Slot = "13")]
	public override bool NNEEKCJNLBL(GAMIAJAKEJM CBJNNHMCKDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1AF0", Offset = "0x5CE0EF0", VA = "0x185CE1AF0")]
	[Preserve]
	public MCHNGPEOGPG([LOJAGCNCPBJ(null)] CAKIFIAMPIO GEMEBIOGIFK, [LOJAGCNCPBJ(null)] FENBOGEPBHH DHKOOLBBAFB, [LOJAGCNCPBJ(null)] IOONAAFFIOJ NLJKAPOJPKH, [LOJAGCNCPBJ(null)] KAGKEKKANGF KFNCBONODEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1660", Offset = "0x5CE0A60", VA = "0x185CE1660")]
	private Task DHLBOKEKDKI(BJBJGPACONH LLBKNLBACIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5CE18F0", Offset = "0x5CE0CF0", VA = "0x185CE18F0")]
	[AsyncStateMachine(typeof(BMFJFIBMDHA))]
	public Task NHKOEBFHCJA(CAKIFIAMPIO IBBCHOFENFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1A70", Offset = "0x5CE0E70", VA = "0x185CE1A70")]
	[CompilerGenerated]
	internal static void OPEALPJFMCI(NHFKPAOGFHM GGCHAANGNGC, NHFKPAOGFHM LJEABKGMCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1820", Offset = "0x5CE0C20", VA = "0x185CE1820")]
	[AsyncStateMachine(typeof(GJDJBHJPGBF))]
	[CompilerGenerated]
	private Task MMLPEKKGFFM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[Preserve]
public class HKGLHMOFJFB
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	[JsonProperty(PropertyName = "AI", Required = Required.Always)]
	[Preserve]
	public string AccountId
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x75C7A0", Offset = "0x75BBA0", VA = "0x18075C7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x75C560", Offset = "0x75B960", VA = "0x18075C560")]
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
		[Cpp2IlInjected.Address(RVA = "0x764960", Offset = "0x763D60", VA = "0x180764960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x760A90", Offset = "0x75FE90", VA = "0x180760A90")]
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
		[Cpp2IlInjected.Address(RVA = "0x75C780", Offset = "0x75BB80", VA = "0x18075C780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x764970", Offset = "0x763D70", VA = "0x180764970")]
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
		[Cpp2IlInjected.Address(RVA = "0x75C7D0", Offset = "0x75BBD0", VA = "0x18075C7D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7681F0", Offset = "0x7675F0", VA = "0x1807681F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75C7E0", Offset = "0x75BBE0", VA = "0x18075C7E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x75C520", Offset = "0x75B920", VA = "0x18075C520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public HKGLHMOFJFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[Preserve]
public class HEILMHHDPJE
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	[JsonProperty(PropertyName = "DR", Required = Required.Always)]
	[Preserve]
	public string Reason
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x75C7A0", Offset = "0x75BBA0", VA = "0x18075C7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x75C560", Offset = "0x75B960", VA = "0x18075C560")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public HEILMHHDPJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class LBMNPLNHIMN : BPLKHKMOOON, NHBLADMBPDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public enum GENHKLLCPJF
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
	private NetworkManager IICLHHNPNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private TaskCompletionSource<GAMIAJAKEJM> FLCPKGHCNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	protected readonly FENBOGEPBHH FAIHIPHCCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private readonly HashSet<AHEPBJHLOPN> JLHHHMFEIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public GENHKLLCPJF LHMKHKJFCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private GAMIAJAKEJM CBJNNHMCKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private RSACryptoServiceProvider MIKKCJDEMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private RSACryptoServiceProvider NFKECAEFHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private AesCryptoServiceProvider BNEHILENGLE;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public GAMIAJAKEJM MHGBKMBBFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x75C7E0", Offset = "0x75BBE0", VA = "0x18075C7E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public string OHPMMNNOFEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5CE0170", Offset = "0x5CDF570", VA = "0x185CE0170", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Task IFDAACGMOMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5CE01A0", Offset = "0x5CDF5A0", VA = "0x185CE01A0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5CE13E0", Offset = "0x5CE07E0", VA = "0x185CE13E0", Slot = "10")]
	public void NEIEEIEHJOP(AHEPBJHLOPN IFMDDPPNHFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1440", Offset = "0x5CE0840", VA = "0x185CE1440", Slot = "6")]
	public bool NNEEKCJNLBL(GAMIAJAKEJM CBJNNHMCKDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1480", Offset = "0x5CE0880", VA = "0x185CE1480")]
	[Preserve]
	public LBMNPLNHIMN([LOJAGCNCPBJ(null)] FENBOGEPBHH BNJDEFBPJHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x5CDFDB0", Offset = "0x5CDF1B0", VA = "0x185CDFDB0")]
	private void FINIKJHBELB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5CDF700", Offset = "0x5CDEB00", VA = "0x185CDF700")]
	private void DMJOCLPDNMM(ulong BAFDGKKJJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5CE06A0", Offset = "0x5CDFAA0", VA = "0x185CE06A0")]
	private void JJNGOCFLIJH(ulong BAFDGKKJJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5CDFCC0", Offset = "0x5CDF0C0", VA = "0x185CDFCC0")]
	private void FHKIPKFDLJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5CE0C60", Offset = "0x5CE0060", VA = "0x185CE0C60")]
	private void KPIIHGIGPDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5CDF580", Offset = "0x5CDE980", VA = "0x185CDF580")]
	private void BGADBJDLCCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5CE0000", Offset = "0x5CDF400", VA = "0x185CE0000")]
	private void GLIDBKHAJOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5CDFB90", Offset = "0x5CDEF90", VA = "0x185CDFB90")]
	private static (IPAddress, ushort) FBJFEAGNLPM(string DGCJKHOICAJ)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5CE0CD0", Offset = "0x5CE00D0", VA = "0x185CE0CD0")]
	private void MLGDBADPEBN(GAMIAJAKEJM HCNDNMGLDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5CE01F0", Offset = "0x5CDF5F0", VA = "0x185CE01F0", Slot = "8")]
	public Task<GAMIAJAKEJM> IEGFGJFPOMK(GAMIAJAKEJM CBJNNHMCKDJ, object JPGBCLJMEPC, [Optional] CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5CDF420", Offset = "0x5CDE820", VA = "0x185CDF420", Slot = "7")]
	public Task AEFMOCBEJCG([Optional] CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5CDFA30", Offset = "0x5CDEE30", VA = "0x185CDFA30", Slot = "9")]
	public Task EJHHGCJMJNB([Optional] CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class FFDPGADOHMK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9350", Offset = "0x5CD8750", VA = "0x185CD9350")]
	public FFDPGADOHMK(string NJKPBIBMIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5CD93B0", Offset = "0x5CD87B0", VA = "0x185CD93B0")]
	public FFDPGADOHMK(string NJKPBIBMIJE, Exception BEGMFKDODGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class MDHBGEMJLCO : FFDPGADOHMK
{
	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1E30", Offset = "0x5CE1230", VA = "0x185CE1E30")]
	public MDHBGEMJLCO([NotNull] Exception BEGMFKDODGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class OAIGDCLHPEA : FFDPGADOHMK
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2B80", Offset = "0x5CE1F80", VA = "0x185CE2B80")]
	public OAIGDCLHPEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class CNMABDEBEIJ : FFDPGADOHMK
{
	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7050", Offset = "0x5CD6450", VA = "0x185CD7050")]
	public CNMABDEBEIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public static class MNMIFGKLMKN
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private static AesCryptoServiceProvider ICEHMGMHDJA;

	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private static readonly string[] CLCEHJCCCEI;

	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private static readonly string[] IHCFEOJOIGE;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private static readonly string[] OAOMNJKHJAP;

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1F80", Offset = "0x5CE1380", VA = "0x185CE1F80")]
	public static string FCOOFKLOKIK(ulong MDPJPABGGLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1F10", Offset = "0x5CE1310", VA = "0x185CE1F10")]
	public static string FCJGDNPKJJK(ulong MDPJPABGGLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1FF0", Offset = "0x5CE13F0", VA = "0x185CE1FF0")]
	public static AesCryptoServiceProvider HKIPMOPAKGI()
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

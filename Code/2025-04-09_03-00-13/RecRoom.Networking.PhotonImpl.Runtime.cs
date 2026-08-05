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
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x79CA320", Offset = "0x79C9720", VA = "0x1879CA320")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D5490", Offset = "0x9D4890", VA = "0x1809D5490")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D54D0", Offset = "0x9D48D0", VA = "0x1809D54D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NetworkProfiler : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA80", Offset = "0x9ABE80", VA = "0x1809ACA80")]
	public NetworkProfiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class AKOJFEGBPLA : AHGPKGBEBID, INPJCGAEHAB, PIJBGLPNJBE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class HEENOEFNHKO : FDPLCNMMFKI
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class GKGDOJKLLKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Action onCompleteCallback;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public GKGDOJKLLKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7002930", Offset = "0x7001D30", VA = "0x187002930")]
			internal void JLGIGEAACCL(DPBEEMKMGIG rh)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool NFGKNJBMGAC
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x79C19A0", Offset = "0x79C0DA0", VA = "0x1879C19A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool BDJBHHPPGEA
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x79C1770", Offset = "0x79C0B70", VA = "0x1879C1770", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public IReadOnlyList<LMIHNDONGBF> PGNNHPCGOLF
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x79C1A10", Offset = "0x79C0E10", VA = "0x1879C1A10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x79C1880", Offset = "0x79C0C80", VA = "0x1879C1880", Slot = "7")]
		public bool JDFMPHMMBIP(Action ODEPGCBOKMM, string JEDNOGMNDOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public HEENOEFNHKO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private MNJHCHNBELP FBNAEKPDGNH;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly byte[] NJLDFFKFNBL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override bool DBAFCIKFGPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x20577B0", Offset = "0x2056BB0", VA = "0x1820577B0", Slot = "91")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override MNJHCHNBELP OAHKEPINACD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9A9AA0", Offset = "0x9A8EA0", VA = "0x1809A9AA0", Slot = "92")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override bool IDELIHAABJH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x79BC830", Offset = "0x79BBC30", VA = "0x1879BC830", Slot = "93")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override bool NFLGFEBNPCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x79BD3D0", Offset = "0x79BC7D0", VA = "0x1879BD3D0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x79BD060", Offset = "0x79BC460", VA = "0x1879BD060", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override float GJHCLJLELIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x79BD5C0", Offset = "0x79BC9C0", VA = "0x1879BD5C0", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override FDPLCNMMFKI MJNJPFDHMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9AE420", Offset = "0x9AD820", VA = "0x1809AE420", Slot = "88")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override bool ANOCMPDNLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x79BCF30", Offset = "0x79BC330", VA = "0x1879BCF30", Slot = "94")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x79BC870", Offset = "0x79BBC70", VA = "0x1879BC870", Slot = "95")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override bool PEKAHDHDLLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x79BD2D0", Offset = "0x79BC6D0", VA = "0x1879BD2D0", Slot = "96")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool HGPICIPOFCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x79BD0B0", Offset = "0x79BC4B0", VA = "0x1879BD0B0", Slot = "97")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override NJHODAAANIC HFKDBBEDJEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x79BCC00", Offset = "0x79BC000", VA = "0x1879BCC00", Slot = "98")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool ABHCIEPHIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x79BC510", Offset = "0x79BB910", VA = "0x1879BC510", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override int IGMFOFJCHOI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x79BD710", Offset = "0x79BCB10", VA = "0x1879BD710", Slot = "69")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override int LCECDAMBFEF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x79BC610", Offset = "0x79BBA10", VA = "0x1879BC610", Slot = "70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override DNIGIBHMBIB GLIPCCAMJLH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x79BC680", Offset = "0x79BBA80", VA = "0x1879BC680", Slot = "71")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public override int BNBFPFJIGLI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x79BD0F0", Offset = "0x79BC4F0", VA = "0x1879BD0F0", Slot = "72")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public override int MPHNNCPMNKB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x79BD8A0", Offset = "0x79BCCA0", VA = "0x1879BD8A0", Slot = "73")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public override int OFMCMKOCBED
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x79BC740", Offset = "0x79BBB40", VA = "0x1879BC740", Slot = "83")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public override event MPNDCDPCBLI MIJJAFGANPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x79BCA70", Offset = "0x79BBE70", VA = "0x1879BCA70", Slot = "62")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x79BCFC0", Offset = "0x79BC3C0", VA = "0x1879BCFC0", Slot = "63")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public override event Action<DNIGIBHMBIB> DIJINAIGFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x79BD320", Offset = "0x79BC720", VA = "0x1879BD320", Slot = "64")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x79BD510", Offset = "0x79BC910", VA = "0x1879BD510", Slot = "65")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public override event Action<MNJHCHNBELP, MNJHCHNBELP> MNENECDPDPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x79BD460", Offset = "0x79BC860", VA = "0x1879BD460", Slot = "89")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x79BC560", Offset = "0x79BB960", VA = "0x1879BC560", Slot = "90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x79BD200", Offset = "0x79BC600", VA = "0x1879BD200", Slot = "101")]
	public override void KCEALIEBOKM(MGBPOGEONJM DNBAOBJCMFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x79BCB10", Offset = "0x79BBF10", VA = "0x1879BCB10")]
	[NOCPMGCIOME.CBODKAAMPCM.HHBOMGFEMJK]
	internal static void FJKHLPMEJLC(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x79BDBC0", Offset = "0x79BCFC0", VA = "0x1879BDBC0")]
	[UnityEngine.Scripting.Preserve]
	public AKOJFEGBPLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x79BC9F0", Offset = "0x79BBDF0", VA = "0x1879BC9F0")]
	private void EFDOODJLOJF(bool FKEDCACINBI, bool AKJNFHJAGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x79BD910", Offset = "0x79BCD10", VA = "0x1879BD910", Slot = "74")]
	[CanBeNull]
	public override DNIGIBHMBIB OGCGKCCKLEP(int CBHDFIGALJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x79BD7F0", Offset = "0x79BCBF0", VA = "0x1879BD7F0")]
	private static short ODACMKINLPK(StreamBuffer GDKFIHBGJMB, object BHFMDLEENOH)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x79BCD90", Offset = "0x79BC190", VA = "0x1879BCD90")]
	private static object GNMKCKFDPEG(StreamBuffer FEGACPFLFCO, short BFBCILDCBHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x79BC8C0", Offset = "0x79BBCC0", VA = "0x1879BC8C0", Slot = "111")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x79BC7A0", Offset = "0x79BBBA0", VA = "0x1879BC7A0", Slot = "75")]
	public override bool CFCMEBKEKCJ(AppSettings AFCFOMKIBBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x79BC7F0", Offset = "0x79BBBF0", VA = "0x1879BC7F0", Slot = "76")]
	public override void DFAFKJLFMAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x79BCC50", Offset = "0x79BC050", VA = "0x1879BCC50", Slot = "77")]
	public override bool GGFJLNPFCHD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x79BD1C0", Offset = "0x79BC5C0", VA = "0x1879BD1C0", Slot = "78")]
	public override void JOIHOCDANAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x79BD780", Offset = "0x79BCB80", VA = "0x1879BD780", Slot = "79")]
	public override void MLHBFNNCCDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x79BC6C0", Offset = "0x79BBAC0", VA = "0x1879BC6C0", Slot = "80")]
	public override void BEDDICFJGEC(List<object> CEFIHBLEFNG, int GNPKFMEIDNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x79BD610", Offset = "0x79BCA10", VA = "0x1879BD610", Slot = "81")]
	public override void MDFIOLFFEAH(int MLGNMELIMOJ, object JOKKIDPHPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x79BD690", Offset = "0x79BCA90", VA = "0x1879BD690", Slot = "82")]
	public override void MEBFBMEHAED(Hashtable GOEHJDBLOMA, int LGLPENFMNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x79BC490", Offset = "0x79BB890", VA = "0x1879BC490", Slot = "84")]
	public override bool ADCBEOHLBMG(byte MIDDANGFEAA, object PMHIICLKBJN, DHGFKKBCAMK HNIADHOEMAB, SendOptions ACCOEAAOMFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x79BD150", Offset = "0x79BC550", VA = "0x1879BD150", Slot = "99")]
	public override bool JJGANOGNOKB(string FLOFKJHCKAP, JMLPIJKPAJF CBEFMIJGJOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x79BDA50", Offset = "0x79BCE50", VA = "0x1879BDA50", Slot = "100")]
	public override void PMEAGDDCKGD(string HOPDGMKBGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x79BD9D0", Offset = "0x79BCDD0", VA = "0x1879BD9D0", Slot = "104")]
	public void OnEvent(EventData JPKBONLDDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "105")]
	public void OnPlayerEnteredRoom(EJNOMEECLJP ADHBPPJPIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "106")]
	public void OnPlayerWillLeaveRoom(EJNOMEECLJP KPKMKNFHCIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "107")]
	public void OnPlayerLeftRoom(EJNOMEECLJP KPKMKNFHCIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "108")]
	public void OnRoomPropertiesUpdate(Hashtable NLMLMIIIGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "109")]
	public void OnPlayerPropertiesUpdate(EJNOMEECLJP JCMJHPADAIB, Hashtable AHBMCKIPBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x20381D0", Offset = "0x20375D0", VA = "0x1820381D0", Slot = "110")]
	private void EALNACBKPEP(EJNOMEECLJP NECMOJEKHKH)
	{
	}
}
namespace _LogRegistration.RecRoom_Networking_PhotonImpl_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : BDONJGGEMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x79C6070", Offset = "0x79C5470", VA = "0x1879C6070", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Networking_PhotonImpl_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x79CB9E0", Offset = "0x79CADE0", VA = "0x1879CB9E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2553680", Offset = "0x2552A80", VA = "0x182553680")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GHEBHMFPHGA : HFONMDBAADL, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HFONMDBAADL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	ODLMCKNIIID PDPEHJBKLGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	string NLMFEFBFAOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Task EAOGAADMFHN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MBEMBDOMNDO(ODLMCKNIIID CEPLFOPGMML);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task DFAFKJLFMAP([Optional] CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<ODLMCKNIIID> EMDEHEGFIBL(ODLMCKNIIID CEPLFOPGMML, object MMOEGADJJKD, [Optional] CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task GHMMEKPMDLL([Optional] CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ELAFLAHNJKJ(DNAKFOJAEFK MAKELPANEHN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal interface LBENLAIDCGC
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCLFIBBMAIM(ushort JBPKDCGKEGC, KLEIHEKEAKO LKNDPPEPMAN, params object[] COEFLDFGPOO);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal enum KLEIHEKEAKO
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
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AKDJHEMIBMN : HFONMDBAADL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	ENKFANPICDA KGJKJBBBOPF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface ENKFANPICDA : GHEBHMFPHGA, HFONMDBAADL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyDictionary<string, int>> CAJECCJLNCE([Optional] TimeSpan? DHBANDEBEOP);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface GIGCKGJFCBC
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool BCICIEEPEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool CJCMBHKOMAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	TimeSpan KPMCCKDEFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan LPFBMGEHMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AppSettings NHCIDOPLHPP(DJIKLFFCJOG LKGGBHBPNBD);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NJHODAAANIC BPGDBKBJKEE(DJIKLFFCJOG LKGGBHBPNBD);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<DJIKLFFCJOG> GFEIEOKLGFE(CancellationToken LMNHDKIFBOH);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LFFFEPFAKBF
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	OPNNLJDPBAB EBHMBMCOPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string MKCKEHEGPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	string KCIKDADOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<bool> IICOEEPBDMC(string LGMEMDPDIBF, string BEFEOEPDJCE, string GEPHELLKDBE);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task DFAFKJLFMAP([Optional] CancellationToken LMNHDKIFBOH);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class FAAAOKLEHCO : BBAEFALHHMO, PIJBGLPNJBE, DDIDDLMHCAH, KFEJNIDEAAD, MEAEIFDHGPM, GJPNMNMHDFB, CKBLLPPBPFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly string AEMCHHEBCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public OPNNLJDPBAB JLMOLPLDCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public OPNNLJDPBAB EPLCBHCNAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public GLDBGNIANKN<OFLJMGOKAPC> ALMGOKAIJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public OPNNLJDPBAB BPCLOMIFPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public GLDBGNIANKN<string> IOCIGBCAEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public GLDBGNIANKN<Dictionary<string, object>> PGDJEALKIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public GLDBGNIANKN<OFLJMGOKAPC> NDNPCLDMCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public APHAPGEAMFF<bool, bool> IBBFDMCNPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public OPNNLJDPBAB ILABHKCKCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public OPNNLJDPBAB PDMLMIHOEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public OPNNLJDPBAB GJKIEBIIOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public OPNNLJDPBAB OAKPMICHHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public OPNNLJDPBAB LHLBOIGEPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public GLDBGNIANKN<EJNOMEECLJP> BAGIDDKAIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public APHAPGEAMFF<PhotonView, EJNOMEECLJP> LLADEAKLCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public CJBDHFJKABF<PhotonView, EJNOMEECLJP, EJNOMEECLJP> FMGECPEMOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public APHAPGEAMFF<short, string> ONOLKELKGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public GLDBGNIANKN<Hashtable> EDEMKKNENCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public GLDBGNIANKN<KPLGNFFIKML> HCIKKLLLCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public APHAPGEAMFF<short, string> ECFKKNBBGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public OPNNLJDPBAB ONLBDHJGDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public GLDBGNIANKN<EJNOMEECLJP> IMJAOBHHLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public GLDBGNIANKN<EJNOMEECLJP> NMIFLABGOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public APHAPGEAMFF<EJNOMEECLJP, Hashtable> HLOJLOIJDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public APHAPGEAMFF<short, string> LDAHBGBDOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public OPNNLJDPBAB LMGFABAOHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public OPNNLJDPBAB IGEGPDHEECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public GLDBGNIANKN<OperationResponse> PKMIEGKAKHA;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x79BFE10", Offset = "0x79BF210", VA = "0x1879BFE10", Slot = "31")]
	public virtual void OnDisconnected(OFLJMGOKAPC HPHIHIGFFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x79BFCE0", Offset = "0x79BF0E0", VA = "0x1879BFCE0", Slot = "4")]
	public void OnConnected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xE01AB0", Offset = "0xE00EB0", VA = "0x180E01AB0", Slot = "5")]
	public void OnConnectedToMaster()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "7")]
	public void OnRegionListReceived(DPBEEMKMGIG NHPCAPFJOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x79BFDC0", Offset = "0x79BF1C0", VA = "0x1879BFDC0", Slot = "8")]
	public void OnCustomAuthenticationResponse(Dictionary<string, object> HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x79BFD70", Offset = "0x79BF170", VA = "0x1879BFD70", Slot = "9")]
	public void OnCustomAuthenticationFailed(string KEGGNIKHPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x79C0040", Offset = "0x79BF440", VA = "0x1879C0040", Slot = "10")]
	public void OnPlayerEnteredRoom(EJNOMEECLJP ADHBPPJPIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "11")]
	public void OnPlayerWillLeaveRoom(EJNOMEECLJP KPKMKNFHCIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x79C00A0", Offset = "0x79BF4A0", VA = "0x1879C00A0", Slot = "12")]
	public void OnPlayerLeftRoom(EJNOMEECLJP KPKMKNFHCIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x79C0190", Offset = "0x79BF590", VA = "0x1879C0190", Slot = "13")]
	public void OnRoomPropertiesUpdate(Hashtable NLMLMIIIGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x79C0100", Offset = "0x79BF500", VA = "0x1879C0100", Slot = "14")]
	public void OnPlayerPropertiesUpdate(EJNOMEECLJP JCMJHPADAIB, Hashtable AHBMCKIPBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x79BFFE0", Offset = "0x79BF3E0", VA = "0x1879BFFE0", Slot = "15")]
	public void OnMasterClientSwitched(EJNOMEECLJP NECMOJEKHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x79BFFA0", Offset = "0x79BF3A0", VA = "0x1879BFFA0", Slot = "16")]
	public void OnJoinedLobby()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1CCBA00", Offset = "0x1CCAE00", VA = "0x181CCBA00", Slot = "17")]
	public void OnLeftLobby()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x79C0170", Offset = "0x79BF570", VA = "0x1879C0170", Slot = "18")]
	public void OnRoomListUpdate(List<FLOEECIBDAF> MKAOPDHIFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x79BFFC0", Offset = "0x79BF3C0", VA = "0x1879BFFC0", Slot = "19")]
	public void OnLobbyStatisticsUpdate(List<DAEONMFCAEJ> GKEFHGGAAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x79BFEA0", Offset = "0x79BF2A0", VA = "0x1879BFEA0", Slot = "20")]
	public void OnFriendListUpdate(List<OAGDDNIJGMA> ICMDIKIMNDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7891AE0", Offset = "0x7890EE0", VA = "0x187891AE0", Slot = "21")]
	public void OnCreatedRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x79BFD00", Offset = "0x79BF100", VA = "0x1879BFD00", Slot = "22")]
	public void OnCreateRoomFailed(short OEIEAKELPFO, string DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1CCBA20", Offset = "0x1CCAE20", VA = "0x181CCBA20", Slot = "23")]
	public void OnJoinedRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x79BFF30", Offset = "0x79BF330", VA = "0x1879BFF30", Slot = "24")]
	public void OnJoinRoomFailed(short OEIEAKELPFO, string DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x79BFEC0", Offset = "0x79BF2C0", VA = "0x1879BFEC0", Slot = "25")]
	public void OnJoinRandomFailed(short OEIEAKELPFO, string DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xC24FC0", Offset = "0xC243C0", VA = "0x180C24FC0", Slot = "26")]
	public void OnLeftRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x79C0250", Offset = "0x79BF650", VA = "0x1879C0250", Slot = "30")]
	public void PAIMIJKBPGF(KPLGNFFIKML KEEIIFLKIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x79BFBE0", Offset = "0x79BEFE0", VA = "0x1879BFBE0", Slot = "27")]
	public void DCONKENAIBL(PhotonView HJHNBHPPKAJ, EJNOMEECLJP DBPOAMOJLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x79BFC50", Offset = "0x79BF050", VA = "0x1879BFC50", Slot = "28")]
	public void HCGGMJLHJEM(PhotonView HJHNBHPPKAJ, EJNOMEECLJP POLPGPBGHGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x79C01F0", Offset = "0x79BF5F0", VA = "0x1879C01F0", Slot = "29")]
	public void OnWebRpcResponse(OperationResponse DLNNHCPPFNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x79C02C0", Offset = "0x79BF6C0", VA = "0x1879C02C0")]
	public FAAAOKLEHCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal static class APCMFEJBDFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class MNFMKNBMEEJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Action<string, PGONDIMPEGN> log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public MNJHCHNBELP networkClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool region;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public MGDBAFPJACD photonCallbacks;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public MNFMKNBMEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5089DB0", Offset = "0x50891B0", VA = "0x185089DB0")]
		internal void JNNLHIJLFIP(OFLJMGOKAPC disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x508A1A0", Offset = "0x50895A0", VA = "0x18508A1A0")]
		internal void MHANOCGOOMB(string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x508A030", Offset = "0x5089430", VA = "0x18508A030")]
		internal void KEIJIOONBED(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class IABFHMDFNDG<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public FAAAOKLEHCO photonCallbacks;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public IABFHMDFNDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x49E2C00", Offset = "0x49E2000", VA = "0x1849E2C00")]
		internal void NPHEIIEOENF(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x49E2990", Offset = "0x49E1D90", VA = "0x1849E2990")]
		internal void EHNFFKAPCGO(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x49E2850", Offset = "0x49E1C50", VA = "0x1849E2850")]
		internal void AEGGCEJNKDN(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3D8F960", Offset = "0x3D8ED60", VA = "0x183D8F960")]
	public static void HGJDNMBEADP<T>(this MGDBAFPJACD BHCFGOEDCGM, TaskCompletionSource<T> BBMIIIIDLPN, [NotNull] MNJHCHNBELP GHEAFJMIOIH, PGONDIMPEGN NMJDAHMKHPM, bool CKJLOCCFJIE, Action<string, PGONDIMPEGN> DPDKJPMBJOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3D8F3C0", Offset = "0x3D8E7C0", VA = "0x183D8F3C0")]
	public static void GAPPKFCNLNE<T>(this FAAAOKLEHCO BHCFGOEDCGM, TaskCompletionSource<T> BBMIIIIDLPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class FBOFLJNPJIO<TNetworking> : GHEBHMFPHGA, HFONMDBAADL, IDisposable where TNetworking : class, MJJDBPOIHBE, EHHBJPGDAKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class GEHBONACMDG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private struct <<ConnectToRegionInternal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AsyncTaskMethodBuilder<DJIKLFFCJOG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public GEHBONACMDG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private TaskAwaiter<DJIKLFFCJOG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x3E8C6E0", Offset = "0x3E8BAE0", VA = "0x183E8C6E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x3E8CA60", Offset = "0x3E8BE60", VA = "0x183E8CA60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public DJIKLFFCJOG photonServerConnectionInfo;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public GEHBONACMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x484AA10", Offset = "0x4849E10", VA = "0x18484AA10")]
		[AsyncStateMachine(typeof(FBOFLJNPJIO<>.GEHBONACMDG.<<ConnectToRegionInternal>b__0>d))]
		internal Task<DJIKLFFCJOG> PPBOHCAFIMF(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct EGNNGOLCBGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AsyncTaskMethodBuilder<DJIKLFFCJOG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public DJIKLFFCJOG photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private GEHBONACMDG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter<DJIKLFFCJOG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x42E0680", Offset = "0x42DFA80", VA = "0x1842E0680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x42E1290", Offset = "0x42E0690", VA = "0x1842E1290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct JPLNPDBMHCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder<DJIKLFFCJOG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public DJIKLFFCJOG photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4CC0B90", Offset = "0x4CBFF90", VA = "0x184CC0B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4CC1900", Offset = "0x4CC0D00", VA = "0x184CC1900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct GJLKAFFPJHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x485EF50", Offset = "0x485E350", VA = "0x18485EF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x485F1A0", Offset = "0x485E5A0", VA = "0x18485F1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct ENLDGPFFHFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private PGONDIMPEGN <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x42F9AC0", Offset = "0x42F8EC0", VA = "0x1842F9AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x42FA000", Offset = "0x42F9400", VA = "0x1842FA000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class KCCKGFGJKHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public KCCKGFGJKHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4D70D50", Offset = "0x4D70150", VA = "0x184D70D50")]
		internal Task<bool> BMHGKHEMEBH(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct HNBFCGBAJJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private KCCKGFGJKHC <>8__1;

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

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4924730", Offset = "0x4923B30", VA = "0x184924730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x4925580", Offset = "0x4924980", VA = "0x184925580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class NKEJKMGKEGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public TaskCompletionSource<OFLJMGOKAPC> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public NKEJKMGKEGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x50FECD0", Offset = "0x50FE0D0", VA = "0x1850FECD0")]
		internal void LBNEIDPDOOE(OFLJMGOKAPC disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x50FEBE0", Offset = "0x50FDFE0", VA = "0x1850FEBE0")]
		internal void FLDLACFACDE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct KPGGNNMKPJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private NKEJKMGKEGF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<OFLJMGOKAPC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4DCE000", Offset = "0x4DCD400", VA = "0x184DCE000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4DCF5F0", Offset = "0x4DCE9F0", VA = "0x184DCF5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct PKHKHGALCJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<ODLMCKNIIID> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public ODLMCKNIIID targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private PGONDIMPEGN <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<ODLMCKNIIID> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5351820", Offset = "0x5350C20", VA = "0x185351820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x53524B0", Offset = "0x53518B0", VA = "0x1853524B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class DHPLPFFJJAD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		private struct <<ConnectToRoomInstanceInternal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public AsyncTaskMethodBuilder<ODLMCKNIIID> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public DHPLPFFJJAD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private TaskAwaiter<ODLMCKNIIID> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x3E8CAD0", Offset = "0x3E8BED0", VA = "0x183E8CAD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x3E8CE70", Offset = "0x3E8C270", VA = "0x183E8CE70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public ODLMCKNIIID targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public object pauseToken;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public DHPLPFFJJAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x66D9B50", Offset = "0x66D8F50", VA = "0x1866D9B50")]
		[AsyncStateMachine(typeof(FBOFLJNPJIO<>.DHPLPFFJJAD.<<ConnectToRoomInstanceInternal>b__0>d))]
		internal Task<ODLMCKNIIID> IPHOEHENEGG(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct IGIFJAEEHLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder<ODLMCKNIIID> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public ODLMCKNIIID targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private DHPLPFFJJAD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter<ODLMCKNIIID> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4A12A80", Offset = "0x4A11E80", VA = "0x184A12A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x4A13860", Offset = "0x4A12C60", VA = "0x184A13860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class OKLBLOKGJOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TaskCompletionSource<HGADFODJLBI> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public OKLBLOKGJOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5229050", Offset = "0x5228450", VA = "0x185229050")]
		internal void MIIDKPLHBNB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct HKMIDNPBDDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public AsyncTaskMethodBuilder<ODLMCKNIIID> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public ODLMCKNIIID targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private OKLBLOKGJOK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private JMLPIJKPAJF <roomOptions>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private Action <trySetResAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter<DJIKLFFCJOG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter<HGADFODJLBI> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x491D0B0", Offset = "0x491C4B0", VA = "0x18491D0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x491F410", Offset = "0x491E810", VA = "0x18491F410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct NBBLNEEHJMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Task<COGDIJBNNAB> whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private TaskAwaiter<COGDIJBNNAB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x50D2AC0", Offset = "0x50D1EC0", VA = "0x1850D2AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA0AFE0", Offset = "0xA0A3E0", VA = "0x180A0AFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct HODLKKADKAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x492B780", Offset = "0x492AB80", VA = "0x18492B780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x492B9D0", Offset = "0x492ADD0", VA = "0x18492B9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct MIKHFKBHFHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private PGONDIMPEGN <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5060760", Offset = "0x505FB60", VA = "0x185060760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5060BF0", Offset = "0x505FFF0", VA = "0x185060BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct IBFCNDIABDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x49F1220", Offset = "0x49F0620", VA = "0x1849F1220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x49F1A10", Offset = "0x49F0E10", VA = "0x1849F1A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class IHMFFLGBEBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public IHMFFLGBEBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x4A18610", Offset = "0x4A17A10", VA = "0x184A18610")]
		internal Task<COGDIJBNNAB> ELJMCFKMJMG(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct LCKMLDHFDOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private IHMFFLGBEBA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private TaskAwaiter<COGDIJBNNAB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4E59840", Offset = "0x4E58C40", VA = "0x184E59840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x4E5A390", Offset = "0x4E59790", VA = "0x184E5A390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class FOPBDEMMADC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TaskCompletionSource<HGADFODJLBI> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public FOPBDEMMADC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x4783840", Offset = "0x4782C40", VA = "0x184783840")]
		internal void NPFEDELPDIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4783520", Offset = "0x4782920", VA = "0x184783520")]
		internal void AEKHHJHPAIC(OFLJMGOKAPC disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x47835C0", Offset = "0x47829C0", VA = "0x1847835C0")]
		internal void FOMBGCKCPIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class IALOEPJIEBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TaskCompletionSource<HGADFODJLBI> reconnectToMasterServerTcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public FOPBDEMMADC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public IALOEPJIEBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x49E5E20", Offset = "0x49E5220", VA = "0x1849E5E20")]
		internal void BLAKDDGFJPD(OFLJMGOKAPC disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x49E5EC0", Offset = "0x49E52C0", VA = "0x1849E5EC0")]
		internal void JHHLABLKDBL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct OCHBKCDPEMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AsyncTaskMethodBuilder<COGDIJBNNAB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private FOPBDEMMADC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private IALOEPJIEBD <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private TaskAwaiter<HGADFODJLBI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x520C5C0", Offset = "0x520B9C0", VA = "0x18520C5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x520E6F0", Offset = "0x520DAF0", VA = "0x18520E6F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class GNHICONINBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public TaskCompletionSource<HGADFODJLBI> reconnectToMasterServerTcs;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public GNHICONINBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x48758F0", Offset = "0x4874CF0", VA = "0x1848758F0")]
		internal string BGGDJGFLPOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x4875960", Offset = "0x4874D60", VA = "0x184875960")]
		internal void JCJLODJLOFH(HGADFODJLBI _1, HGADFODJLBI _2)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct NDMHBIHJBLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public AsyncTaskMethodBuilder<HGADFODJLBI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private GNHICONINBH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private TaskAwaiter<HGADFODJLBI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x50DBF30", Offset = "0x50DB330", VA = "0x1850DBF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x50DCCA0", Offset = "0x50DC0A0", VA = "0x1850DCCA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct LMPNFGBOFFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4E79B20", Offset = "0x4E78F20", VA = "0x184E79B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA0AFE0", Offset = "0xA0A3E0", VA = "0x180A0AFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct GCLIJHFPPCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4822070", Offset = "0x4821470", VA = "0x184822070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4822410", Offset = "0x4821810", VA = "0x184822410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct PBCELOIHOEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public OFLJMGOKAPC disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private GCAJLBNDPDL <exception>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x52EFB90", Offset = "0x52EEF90", VA = "0x1852EFB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA0AFE0", Offset = "0xA0A3E0", VA = "0x180A0AFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct DCKHLCHEJCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public OFLJMGOKAPC disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private HashSet<DNAKFOJAEFK>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x66C1F20", Offset = "0x66C1320", VA = "0x1866C1F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x66C2A10", Offset = "0x66C1E10", VA = "0x1866C2A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct CNPLPIHEOGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private HashSet<KJEDKBCNOKO>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6481BF0", Offset = "0x6480FF0", VA = "0x186481BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x64820E0", Offset = "0x64814E0", VA = "0x1864820E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class NHPOGLMNCHI<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public string timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public NHPOGLMNCHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		internal string LMBBLFECGMC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class FEKJOCHIHFA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public Dictionary<string, string> tcsTimeoutData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public MOFIDDFDCNN.IDCANJGEIMD timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public FEKJOCHIHFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x471DC60", Offset = "0x471D060", VA = "0x18471DC60")]
		internal void DLCEBPFHFDG(string prefix, Dictionary<string, string> dict)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x471E070", Offset = "0x471D470", VA = "0x18471E070")]
		internal GOMGDJGGPJG MMMCDAMIJOM(TimeSpan timeoutTime)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class CHNKKILHNLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public TaskCompletionSource<HGADFODJLBI> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public CHNKKILHNLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x63F1E70", Offset = "0x63F1270", VA = "0x1863F1E70")]
		internal void NALGGDEDNKH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct AAIIGOIPBFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private CHNKKILHNLP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public HGADFODJLBI connectedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public AppSettings appSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private TaskAwaiter<HGADFODJLBI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x47DFDD0", Offset = "0x47DF1D0", VA = "0x1847DFDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x47E1100", Offset = "0x47E0500", VA = "0x1847E1100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class LMCCIPNHAND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public LMCCIPNHAND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4E73BB0", Offset = "0x4E72FB0", VA = "0x184E73BB0")]
		internal object FCCGHLOFOML()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class JONBNOEHHNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public JONBNOEHHNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4C925D0", Offset = "0x4C919D0", VA = "0x184C925D0")]
		internal object IIIKKGNPAIJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class IDENFDCOEMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public FBOFLJNPJIO<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public IDENFDCOEMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x49F39D0", Offset = "0x49F2DD0", VA = "0x1849F39D0")]
		internal object GBNGHFDAFII()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly Hashtable OKBIFGEBIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly LBENLAIDCGC PFCKJIJNFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly DLMGPADEJND FKCAFNMOIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected readonly string OBPCAKCMEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected readonly GIGCKGJFCBC KNJBINEMGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private TaskCompletionSource<COGDIJBNNAB> NFALMLHMAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[NotNull]
	public readonly MGDBAFPJACD MHKFFCLEOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected internal readonly TNetworking BBEHMGBBFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private ushort NIEKGGMPNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private JOAEPJGCNNH<DJIKLFFCJOG> JKDIKMAHLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private JOAEPJGCNNH<bool> OLHAKIPMIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private JOAEPJGCNNH<ODLMCKNIIID> DIFOLOBKJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private JOAEPJGCNNH<COGDIJBNNAB> DBLAJABKLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool AMGJAENEBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private bool CPHBPEFKLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly HashSet<KJEDKBCNOKO> BFPBDFHDEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly HashSet<DNAKFOJAEFK> NIDENLLKPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private bool ACJJLPFCEAB;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool HGPICIPOFCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4711430", Offset = "0x4710830", VA = "0x184711430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	[CanBeNull]
	public ODLMCKNIIID PDPEHJBKLGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x47123F0", Offset = "0x47117F0", VA = "0x1847123F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	protected HGADFODJLBI FFEBIINAKDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4712230", Offset = "0x4711630", VA = "0x184712230")]
		get
		{
			return default(HGADFODJLBI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	[CanBeNull]
	public string NLMFEFBFAOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x470FB00", Offset = "0x470EF00", VA = "0x18470FB00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private TimeSpan KPMCCKDEFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4710180", Offset = "0x470F580", VA = "0x184710180")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private TimeSpan LPFBMGEHMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4712750", Offset = "0x4711B50", VA = "0x184712750")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Task EAOGAADMFHN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4712050", Offset = "0x4711450", VA = "0x184712050", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract bool MBEMBDOMNDO(ODLMCKNIIID CEPLFOPGMML);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4710E20", Offset = "0x4710220", VA = "0x184710E20")]
	private static TimeSpan HCHMFGOEDFI(TimeSpan BFKEEJMJDMA, string IGEPDAOOLBO)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4712C70", Offset = "0x4712070", VA = "0x184712C70")]
	protected FBOFLJNPJIO(TNetworking BOGAODIGBEK, GIGCKGJFCBC LGMNKOMDONC, string AEMCHHEBCOG, DLMGPADEJND FKCAFNMOIHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4712CD0", Offset = "0x47120D0", VA = "0x184712CD0")]
	internal FBOFLJNPJIO(TNetworking BOGAODIGBEK, GIGCKGJFCBC LGMNKOMDONC, string AEMCHHEBCOG, DLMGPADEJND FKCAFNMOIHA, [Optional] LBENLAIDCGC PFCKJIJNFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x470FA00", Offset = "0x470EE00", VA = "0x18470FA00")]
	private void AMHGFKOKAOC(bool FKPHPPGPLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4710D20", Offset = "0x4710120", VA = "0x184710D20")]
	private void GPKJNJOJDDL(HGADFODJLBI DNCHFJBNOEE, HGADFODJLBI CCLHBAPKJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4710070", Offset = "0x470F470", VA = "0x184710070")]
	internal PGONDIMPEGN DNHOHIFPGNJ()
	{
		return default(PGONDIMPEGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4712840", Offset = "0x4711C40", VA = "0x184712840")]
	[AsyncStateMachine(typeof(FBOFLJNPJIO<>.EGNNGOLCBGI))]
	private Task<DJIKLFFCJOG> PHOPBGEJEMO(PGONDIMPEGN NMJDAHMKHPM, DJIKLFFCJOG LKGGBHBPNBD, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x47109F0", Offset = "0x470FDF0", VA = "0x1847109F0")]
	[AsyncStateMachine(typeof(FBOFLJNPJIO<>.JPLNPDBMHCK))]
	protected Task<DJIKLFFCJOG> GJCBOPCLEON(PGONDIMPEGN NMJDAHMKHPM, DJIKLFFCJOG LKGGBHBPNBD, CancellationToken GHPICBKCPHK, CancellationToken LIFKOCJFABJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4710FC0", Offset = "0x47103C0", VA = "0x184710FC0")]
	[AsyncStateMachine(typeof(FBOFLJNPJIO<>.GJLKAFFPJHG))]
	protected Task HOBGKDGJEAK(PGONDIMPEGN NMJDAHMKHPM, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x470FF60", Offset = "0x470F360", VA = "0x18470FF60", Slot = "7")]
	[AsyncStateMachine(typeof(FBOFLJNPJIO<>.ENLDGPFFHFB))]
	public Task DFAFKJLFMAP([Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4711C10", Offset = "0x4711010", VA = "0x184711C10")]
	[AsyncStateMachine(typeof(FBOFLJNPJIO<>.HNBFCGBAJJF))]
	private Task KFCGDMPGMPK(PGONDIMPEGN NMJDAHMKHPM, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4710250", Offset = "0x470F650", VA = "0x184710250")]
	[AsyncStateMachine(typeof(FBOFLJNPJIO<>.KPGGNNMKPJF))]
	private Task<bool> ECJOMDMCDDD(PGONDIMPEGN NMJDAHMKHPM, CancellationToken HHGPJKKLNIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4710410", Offset = "0x470F810", VA = "0x184710410", Slot = "8")]
	[AsyncStateMachine(typeof(FBOFLJNPJIO<>.PKHKHGALCJO))]
	public Task<ODLMCKNIIID> EMDEHEGFIBL(ODLMCKNIIID CEPLFOPGMML, object MMOEGADJJKD, [Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4711E10", Offset = "0x4711210", VA = "0x184711E10")]
	[AsyncStateMachine(typeof(FBOFLJNPJIO<>.IGIFJAEEHLD))]
	private Task<ODLMCKNIIID> KLMJOAGIMHD(PGONDIMPEGN NMJDAHMKHPM, ODLMCKNIIID CEPLFOPGMML, object MMOEGADJJKD, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4710B70", Offset = "0x470FF70", VA = "0x184710B70")]
	[AsyncStateMachine(typeof(FBOFLJNPJIO<>.HKMIDNPBDDB))]
	private Task<ODLMCKNIIID> GPEDILFDCCC(PGONDIMPEGN NMJDAHMKHPM, ODLMCKNIIID CEPLFOPGMML, object MMOEGADJJKD, CancellationToken GHPICBKCPHK, CancellationToken LIFKOCJFABJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4711110", Offset = "0x4710510", VA = "0x184711110")]
	[AsyncStateMachine(typeof(FBOFLJNPJIO<>.NBBLNEEHJMA))]
	private void IDCHHGHJIIM(Task<COGDIJBNNAB> DCCHLMIEFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x47129B0", Offset = "0x4711DB0", VA = "0x1847129B0")]
	[AsyncStateMachine(typeof(FBOFLJNPJIO<>.HODLKKADKAG))]
	private Task PIGIKAOGFNK(PGONDIMPEGN NMJDAHMKHPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x47108E0", Offset = "0x470FCE0", VA = "0x1847108E0", Slot = "9")]
	[AsyncStateMachine(typeof(FBOFLJNPJIO<>.MIKHFKBHFHM))]
	public Task GHMMEKPMDLL([Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x47120E0", Offset = "0x47114E0", VA = "0x1847120E0")]
	[AsyncStateMachine(typeof(FBOFLJNPJIO<>.IBFCNDIABDG))]
	private Task LDCBLKPKAEC(PGONDIMPEGN NMJDAHMKHPM, [Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x47122A0", Offset = "0x47116A0", VA = "0x1847122A0")]
	[AsyncStateMachine(typeof(FBOFLJNPJIO<>.LCKMLDHFDOE))]
	private Task MBOAMAKNGDC(PGONDIMPEGN NMJDAHMKHPM, [Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4711930", Offset = "0x4710D30", VA = "0x184711930")]
	[AsyncStateMachine(typeof(FBOFLJNPJIO<>.OCHBKCDPEMO))]
	private Task<COGDIJBNNAB> KCBOIIMDBKM(PGONDIMPEGN NMJDAHMKHPM, CancellationToken GHPICBKCPHK, CancellationToken LIFKOCJFABJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x470FB60", Offset = "0x470EF60", VA = "0x18470FB60")]
	[AsyncStateMachine(typeof(FBOFLJNPJIO<>.NDMHBIHJBLL))]
	private Task<HGADFODJLBI> CBMAHOIOFLE(PGONDIMPEGN NMJDAHMKHPM, CancellationToken LMNHDKIFBOH, string IOPCFKOHPBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4711D50", Offset = "0x4711150", VA = "0x184711D50", Slot = "14")]
	protected virtual void KFJOIDOOPPG(PGONDIMPEGN NMJDAHMKHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4711F90", Offset = "0x4711390", VA = "0x184711F90", Slot = "15")]
	protected virtual void KMMACOIICMH(PGONDIMPEGN NMJDAHMKHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4711AA0", Offset = "0x4710EA0", VA = "0x184711AA0")]
	private void KCLFIBBMAIM(PGONDIMPEGN NMJDAHMKHPM, KLEIHEKEAKO IOPCFKOHPBF, params object[] BPKDFLJLPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "16")]
	protected virtual void FBJKJPCCJDF(ODLMCKNIIID MDAACFNPCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4712440", Offset = "0x4711840", VA = "0x184712440")]
	[AsyncStateMachine(typeof(FBOFLJNPJIO<>.LMPNFGBOFFL))]
	private void MFONGJDKBIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4712680", Offset = "0x4711A80", VA = "0x184712680")]
	[AsyncStateMachine(typeof(FBOFLJNPJIO<>.GCLIJHFPPCK))]
	private Task PAGCPJECCPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x47111D0", Offset = "0x47105D0", VA = "0x1847111D0")]
	[AsyncStateMachine(typeof(FBOFLJNPJIO<>.PBCELOIHOEG))]
	private void IIJDLANKFMG(OFLJMGOKAPC JHHDCJJPOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4710630", Offset = "0x470FA30", VA = "0x184710630")]
	[AsyncStateMachine(typeof(FBOFLJNPJIO<>.DCKHLCHEJCA))]
	private Task FCFGFENPBKE(OFLJMGOKAPC JHHDCJJPOOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x470FCD0", Offset = "0x470F0D0", VA = "0x18470FCD0")]
	[AsyncStateMachine(typeof(FBOFLJNPJIO<>.CNPLPIHEOGH))]
	private Task CFPANDOPIHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x47103B0", Offset = "0x470F7B0", VA = "0x1847103B0", Slot = "10")]
	public void ELAFLAHNJKJ(DNAKFOJAEFK MAKELPANEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3B984E0", Offset = "0x3B978E0", VA = "0x183B984E0")]
	private TaskCompletionSource<T> LDNGGCBAENJ<T>(PGONDIMPEGN NMJDAHMKHPM, CancellationToken LMNHDKIFBOH, TimeSpan ADEFLDLMJBI, string FGBFBECGMPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3B98240", Offset = "0x3B97640", VA = "0x183B98240")]
	private TaskCompletionSource<T> LDNGGCBAENJ<T>(PGONDIMPEGN NMJDAHMKHPM, CancellationToken LMNHDKIFBOH, TimeSpan ADEFLDLMJBI, MOFIDDFDCNN.IDCANJGEIMD FGBFBECGMPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x47114A0", Offset = "0x47108A0", VA = "0x1847114A0")]
	[AsyncStateMachine(typeof(FBOFLJNPJIO<>.AAIIGOIPBFJ))]
	protected Task IPHCALDFBBF(PGONDIMPEGN NMJDAHMKHPM, AppSettings AFCFOMKIBBI, HGADFODJLBI HIJAFLEJLAM, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x47100C0", Offset = "0x470F4C0", VA = "0x1847100C0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4711600", Offset = "0x4710A00", VA = "0x184711600", Slot = "17")]
	protected virtual void JNILBPLGMCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4712820", Offset = "0x4711C20", VA = "0x184712820")]
	private static string PHNLHDIMAPC(PGONDIMPEGN NMJDAHMKHPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
	protected void GFDFDHMHGGA(string DAMFJFKKFBI, [Optional] PGONDIMPEGN NMJDAHMKHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x47124E0", Offset = "0x47118E0", VA = "0x1847124E0")]
	protected void PADHHMMINIJ(string DAMFJFKKFBI, [Optional] PGONDIMPEGN NMJDAHMKHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x470FDC0", Offset = "0x470F1C0", VA = "0x18470FDC0")]
	protected void CIEDCJNPNEC(string DAMFJFKKFBI, [Optional] PGONDIMPEGN NMJDAHMKHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4711290", Offset = "0x4710690", VA = "0x184711290")]
	protected void ILKEALIOPDP(string DAMFJFKKFBI, Exception BLCFGIAFKHH, [Optional] PGONDIMPEGN NMJDAHMKHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4710570", Offset = "0x470F970", VA = "0x184710570")]
	public void FACBPDFBHAB(MGBPOGEONJM LFCHBABPELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4710730", Offset = "0x470FB30", VA = "0x184710730")]
	[CompilerGenerated]
	private void FFIJNEIEPIP(MNJHCHNBELP LHJAKMCKDJK, MNJHCHNBELP KDEBDLMDJAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3B98180", Offset = "0x3B97580", VA = "0x183B98180")]
	[CompilerGenerated]
	internal static string JDOGHCKCICM<T>(TimeSpan HEIAKNJACAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct PGONDIMPEGN : IEquatable<PGONDIMPEGN>, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public readonly ushort JLCCLNEJJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public readonly string OBPCAKCMEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly MJJDBPOIHBE BOGAODIGBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly Stopwatch MIIALBEHPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly List<(TimeSpan, HGADFODJLBI, HGADFODJLBI)> EBGNFFHNPHL;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public TimeSpan JHNFHPCNDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x79CAF10", Offset = "0x79CA310", VA = "0x1879CAF10")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IReadOnlyList<(TimeSpan time, HGADFODJLBI oldState, HGADFODJLBI newState)> CLHBJCDBEGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x79CB130", Offset = "0x79CA530", VA = "0x1879CB130")]
	public PGONDIMPEGN(ushort JBPKDCGKEGC, string AEMCHHEBCOG, MJJDBPOIHBE BOGAODIGBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x79CAFF0", Offset = "0x79CA3F0", VA = "0x1879CAFF0")]
	private void PAPGHJFPDOP(HGADFODJLBI DNCHFJBNOEE, HGADFODJLBI CCLHBAPKJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x79CAFC0", Offset = "0x79CA3C0", VA = "0x1879CAFC0", Slot = "4")]
	public bool Equals(PGONDIMPEGN KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x79CAF30", Offset = "0x79CA330", VA = "0x1879CAF30", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x79CAFD0", Offset = "0x79CA3D0", VA = "0x1879CAFD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x79CB110", Offset = "0x79CA510", VA = "0x1879CB110")]
	public static bool PEOCKCCHEIN(PGONDIMPEGN KGCKEJLFPJB, PGONDIMPEGN HKELKGIPNGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x79CADC0", Offset = "0x79CA1C0", VA = "0x1879CADC0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal static class NCNBOPLIDHB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct DAAACLENGJM<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public JOAEPJGCNNH<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public PGONDIMPEGN doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x66BC1C0", Offset = "0x66BB5C0", VA = "0x1866BC1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x66BC970", Offset = "0x66BBD70", VA = "0x1866BC970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct CADCICOGBMI<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public JOAEPJGCNNH<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public TimeSpan forceCancelTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public PGONDIMPEGN doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x62F3090", Offset = "0x62F2490", VA = "0x1862F3090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x62F3550", Offset = "0x62F2950", VA = "0x1862F3550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct MBBCPKGFAPJ<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public JOAEPJGCNNH<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public CancellationToken newToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private CancellationTokenRegistration? <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x50430C0", Offset = "0x50424C0", VA = "0x1850430C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x48FB5F0", Offset = "0x48FA9F0", VA = "0x1848FB5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x37CA450", Offset = "0x37C9850", VA = "0x1837CA450")]
	[AsyncStateMachine(typeof(DAAACLENGJM<>))]
	public static Task HEHJNDKMNDL<TArgs>(this JOAEPJGCNNH<TArgs> LACEKGIJPNP, [Optional] PGONDIMPEGN CPLDEBHIMMA) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x37C9E90", Offset = "0x37C9290", VA = "0x1837C9E90")]
	[AsyncStateMachine(typeof(CADCICOGBMI<>))]
	public static Task DIEPIGMEABI<TArgs>(this JOAEPJGCNNH<TArgs> LACEKGIJPNP, TimeSpan MFCBCEFEKJL, [Optional] PGONDIMPEGN CPLDEBHIMMA) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x37CA7B0", Offset = "0x37C9BB0", VA = "0x1837CA7B0")]
	public static (bool, bool) MFENFHGBCFF<TArgs>(this JOAEPJGCNNH<TArgs> LACEKGIJPNP, TArgs IGICHEAKAKH, [Out] string CFILLGOJAGM) where TArgs : IEquatable<TArgs>
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x37CA0F0", Offset = "0x37C94F0", VA = "0x1837CA0F0")]
	[AsyncStateMachine(typeof(MBBCPKGFAPJ<>))]
	public static Task<TArgs> EHLLOLOLBOI<TArgs>(this JOAEPJGCNNH<TArgs> LACEKGIJPNP, TArgs IGICHEAKAKH, CancellationToken HCNBKJFAMBF) where TArgs : IEquatable<TArgs>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal class JOAEPJGCNNH<TArgs> : IDisposable where TArgs : IEquatable<TArgs>
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public delegate Task<TArgs> KFOIJIMGLME(CancellationToken KDIAGAEKKJM, CancellationToken GNAKHDMHMMC);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct HIJNHOHAMCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public JOAEPJGCNNH<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public PGONDIMPEGN doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public TimeSpan forceCancelAfter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x490C420", Offset = "0x490B820", VA = "0x18490C420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x490C960", Offset = "0x490BD60", VA = "0x18490C960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct KCAHJAAEKNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public JOAEPJGCNNH<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public PGONDIMPEGN doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x4D704B0", Offset = "0x4D6F8B0", VA = "0x184D704B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x4D70C90", Offset = "0x4D70090", VA = "0x184D70C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct HOELMBLJBJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public JOAEPJGCNNH<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x492BCA0", Offset = "0x492B0A0", VA = "0x18492BCA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x492C240", Offset = "0x492B640", VA = "0x18492C240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct CIACKMEHGHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public JOAEPJGCNNH<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public KFOIJIMGLME taskFactory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private CancellationTokenSource <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x63F2890", Offset = "0x63F1C90", VA = "0x1863F2890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x4A1E860", Offset = "0x4A1DC60", VA = "0x184A1E860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct GCPNAMJDNHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public Task<TArgs> wrappedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public JOAEPJGCNNH<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x48229F0", Offset = "0x4821DF0", VA = "0x1848229F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x4822CB0", Offset = "0x48220B0", VA = "0x184822CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private bool EKDCONIHOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private bool CIJNDEJLGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private bool NHJMDJIHCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private CancellationTokenSource OGLOOKGLIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private CancellationTokenSource HINOHKEPJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly PGONDIMPEGN NMJDAHMKHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly CancellationToken BOHHBCNKHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly TArgs IGICHEAKAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private TArgs OBGLHJKOJGG;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public TArgs JKNLEFEANEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x4C8EBA0", Offset = "0x4C8DFA0", VA = "0x184C8EBA0")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public TArgs AAPAIDOCFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4C8DA00", Offset = "0x4C8CE00", VA = "0x184C8DA00")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[CanBeNull]
	public Task<TArgs> OLHIMKLJNKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A40", Offset = "0x9A8E40", VA = "0x1809A9A40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A90", Offset = "0x9A8E90", VA = "0x1809A9A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x4C8FB70", Offset = "0x4C8EF70", VA = "0x184C8FB70")]
	public JOAEPJGCNNH(TArgs LNBECIKOMEJ, CancellationToken BOHHBCNKHLK, PGONDIMPEGN NMJDAHMKHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x4C8DED0", Offset = "0x4C8D2D0", VA = "0x184C8DED0")]
	[AsyncStateMachine(typeof(JOAEPJGCNNH<>.HIJNHOHAMCI))]
	public Task EOJHHJOHGLF(TimeSpan HLNPMCJOOGP, PGONDIMPEGN MHDIIDAMGBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x4C8E430", Offset = "0x4C8D830", VA = "0x184C8E430")]
	[AsyncStateMachine(typeof(JOAEPJGCNNH<>.KCAHJAAEKNO))]
	public Task GDEOHECAABB(PGONDIMPEGN MHDIIDAMGBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4C8DB90", Offset = "0x4C8CF90", VA = "0x184C8DB90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x4C8F2B0", Offset = "0x4C8E6B0", VA = "0x184C8F2B0")]
	[AsyncStateMachine(typeof(JOAEPJGCNNH<>.HOELMBLJBJM))]
	private Task PAJGPGCDKFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4C8F180", Offset = "0x4C8E580", VA = "0x184C8F180")]
	[AsyncStateMachine(typeof(JOAEPJGCNNH<>.CIACKMEHGHJ))]
	public Task<TArgs> OHKFCDIDLPF(KFOIJIMGLME LHEOHPBOKFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4C8EBC0", Offset = "0x4C8DFC0", VA = "0x184C8EBC0")]
	[AsyncStateMachine(typeof(JOAEPJGCNNH<>.GCPNAMJDNHI))]
	private Task<TArgs> LJCOEIAELDC(Task<TArgs> EOMLPLLODHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4C8E010", Offset = "0x4C8D410", VA = "0x184C8E010")]
	public bool FHEAOPKDINP(TArgs DNPOBEPEFIM, [Out] string CFILLGOJAGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4C8F7C0", Offset = "0x4C8EBC0", VA = "0x184C8F7C0")]
	private bool PEGKBLJLDBB(TArgs DNPOBEPEFIM, [Out] string CFILLGOJAGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x4C8EA50", Offset = "0x4C8DE50", VA = "0x184C8EA50")]
	public CancellationTokenRegistration? LAKIHIJFKFD(CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4C8E790", Offset = "0x4C8DB90", VA = "0x184C8E790")]
	[CompilerGenerated]
	private void IIOBALDIAGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface DLMGPADEJND
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ECIHFGNBPHM(string AEMCHHEBCOG, string AAAEJNNKBGJ, PGONDIMPEGN NMJDAHMKHPM, [Optional] string LDGNLBGEHIL);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NHNCHKBCIID(string AEMCHHEBCOG, string AAAEJNNKBGJ, PGONDIMPEGN NMJDAHMKHPM, [Optional] string LDGNLBGEHIL);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GIFLPACFPBL(string AEMCHHEBCOG, string AAAEJNNKBGJ, PGONDIMPEGN NMJDAHMKHPM, [Optional] string LDGNLBGEHIL);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DPCJLANBIMN(string AEMCHHEBCOG, string AAAEJNNKBGJ, PGONDIMPEGN NMJDAHMKHPM, Exception OBHLNPEHLEG, [Optional] string LDGNLBGEHIL);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BLHHBILGNBL(string AEMCHHEBCOG, GCAJLBNDPDL IDAMMIHEJMI);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class NNGJIGAJMAC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct IPAGLOFHNBP<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public DLMGPADEJND analytics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public string clientName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public string actionName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4A2E5A0", Offset = "0x4A2D9A0", VA = "0x184A2E5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x4822CB0", Offset = "0x48220B0", VA = "0x184822CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct PMGIIFLLNKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public DLMGPADEJND analytics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public string clientName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public string actionName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x79CB390", Offset = "0x79CA790", VA = "0x1879CB390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x79CB850", Offset = "0x79CAC50", VA = "0x1879CB850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x37D8E70", Offset = "0x37D8270", VA = "0x1837D8E70")]
	[AsyncStateMachine(typeof(IPAGLOFHNBP<>))]
	public static Task<T> MDMPMJIEHOE<T>(this Task<T> NHNFPALEEPM, [CanBeNull] DLMGPADEJND FKCAFNMOIHA, string AEMCHHEBCOG, string AAAEJNNKBGJ, PGONDIMPEGN NMJDAHMKHPM, [Optional] string LDGNLBGEHIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x79CA1A0", Offset = "0x79C95A0", VA = "0x1879CA1A0")]
	[AsyncStateMachine(typeof(PMGIIFLLNKI))]
	public static Task MDMPMJIEHOE(this Task NHNFPALEEPM, [CanBeNull] DLMGPADEJND FKCAFNMOIHA, string AEMCHHEBCOG, string AAAEJNNKBGJ, PGONDIMPEGN NMJDAHMKHPM, [Optional] string LDGNLBGEHIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public delegate Task KJEDKBCNOKO();
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate Task DNAKFOJAEFK(OFLJMGOKAPC JHHDCJJPOOO);
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class AIACMOONMDD : MNJHCHNBELP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly MGBPOGEONJM HEONJNPGOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly Func<AIACMOONMDD, bool> IFIFNLCLACP;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public HGADFODJLBI FFEBIINAKDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x79BC240", Offset = "0x79BB640", VA = "0x1879BC240", Slot = "4")]
		get
		{
			return default(HGADFODJLBI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public DKOMNEILAPE NFIIADGAOLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA12720", Offset = "0xA11B20", VA = "0x180A12720", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool HGPICIPOFCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x79BC220", Offset = "0x79BB620", VA = "0x1879BC220", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool IDELIHAABJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x79BC080", Offset = "0x79BB480", VA = "0x1879BC080", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool GAGJCMDMBIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x79BC060", Offset = "0x79BB460", VA = "0x1879BC060", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Exception OBIGHPHFGHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA23D70", Offset = "0xA23170", VA = "0x180A23D70", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public StatusCode MMMLLDHAFAO
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x79BC1E0", Offset = "0x79BB5E0", VA = "0x1879BC1E0", Slot = "16")]
		get
		{
			return default(StatusCode);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event MGBPOGEONJM.JKFCPKLPGCH CDALAPBDHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x79BC200", Offset = "0x79BB600", VA = "0x1879BC200", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x79BC330", Offset = "0x79BB730", VA = "0x1879BC330", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<HGADFODJLBI, HGADFODJLBI> JPPJFOOKHHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x79BC280", Offset = "0x79BB680", VA = "0x1879BC280", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x79BC130", Offset = "0x79BB530", VA = "0x1879BC130", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x79BC370", Offset = "0x79BB770", VA = "0x1879BC370")]
	public AIACMOONMDD(MGBPOGEONJM HEONJNPGOPB, [Optional] Func<AIACMOONMDD, bool> IFIFNLCLACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x79BC0A0", Offset = "0x79BB4A0", VA = "0x1879BC0A0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x79BC040", Offset = "0x79BB440", VA = "0x1879BC040")]
	private void DAPOLPJKMJC(HGADFODJLBI DNCHFJBNOEE, HGADFODJLBI CCLHBAPKJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x79BC260", Offset = "0x79BB660", VA = "0x1879BC260", Slot = "13")]
	public void MIJNOIDEJHE(object IGICHEAKAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x79BC350", Offset = "0x79BB750", VA = "0x1879BC350", Slot = "14")]
	public void OLFOJLNFJIO(object IGICHEAKAKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class MGPFDBMPGLM : AKDJHEMIBMN, HFONMDBAADL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class IEJBPCCHOAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public ODLMCKNIIID targetRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public IEJBPCCHOAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x79C1B20", Offset = "0x79C0F20", VA = "0x1879C1B20")]
		internal bool JPLOACOJBOO(GHEBHMFPHGA c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class AIJKKDGFJME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public AIJKKDGFJME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x79BC430", Offset = "0x79BB830", VA = "0x1879BC430")]
		internal Task MOONLKCHCCK(GHEBHMFPHGA c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct GKLBBLFKKCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public MGPFDBMPGLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x79C1430", Offset = "0x79C0830", VA = "0x1879C1430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x79C16C0", Offset = "0x79C0AC0", VA = "0x1879C16C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct GAPLADOKHCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public AsyncTaskMethodBuilder<ODLMCKNIIID> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public MGPFDBMPGLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public ODLMCKNIIID targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private Task<ODLMCKNIIID> <punConnectionTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private TaskAwaiter<ODLMCKNIIID> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x79C0AE0", Offset = "0x79BFEE0", VA = "0x1879C0AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x79C0FC0", Offset = "0x79C03C0", VA = "0x1879C0FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class DGOJAOACPCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public DGOJAOACPCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x79BF6E0", Offset = "0x79BEAE0", VA = "0x1879BF6E0")]
		internal Task BKAEBNOGNDG(GHEBHMFPHGA c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct APLLEDFFGNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public MGPFDBMPGLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x79BDE20", Offset = "0x79BD220", VA = "0x1879BDE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x79BE0B0", Offset = "0x79BD4B0", VA = "0x1879BE0B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public readonly DGAMKNBJEKB KGJKJBBBOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public readonly MDLDJDBMFDP PILIDCBOBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly GHEBHMFPHGA[] BFJBCDAIJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public readonly LLOHELIIHCE OIBGDHOCKHC;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public ODLMCKNIIID PDPEHJBKLGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x79C9850", Offset = "0x79C8C50", VA = "0x1879C9850", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public string NLMFEFBFAOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x79C8FF0", Offset = "0x79C83F0", VA = "0x1879C8FF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private IEnumerable<GHEBHMFPHGA> FOEBKDFGOAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x79C96E0", Offset = "0x79C8AE0", VA = "0x1879C96E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private ENKFANPICDA HDINKGCDIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task EAOGAADMFHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x79C9720", Offset = "0x79C8B20", VA = "0x1879C9720", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x79C9770", Offset = "0x79C8B70", VA = "0x1879C9770", Slot = "7")]
	public bool MBEMBDOMNDO(ODLMCKNIIID CEPLFOPGMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x79C98A0", Offset = "0x79C8CA0", VA = "0x1879C98A0")]
	[UnityEngine.Scripting.Preserve]
	public MGPFDBMPGLM([CMKKAFOAFJE(null)] DGAMKNBJEKB DNBAOBJCMFG, [CMKKAFOAFJE(null)] MDLDJDBMFDP PCIEFMILMAF, [CMKKAFOAFJE(null)] LLOHELIIHCE NPLHGKAONCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x79C9040", Offset = "0x79C8440", VA = "0x1879C9040", Slot = "8")]
	[AsyncStateMachine(typeof(GKLBBLFKKCK))]
	public Task DFAFKJLFMAP([Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x79C9490", Offset = "0x79C8890", VA = "0x1879C9490", Slot = "9")]
	[AsyncStateMachine(typeof(GAPLADOKHCJ))]
	public Task<ODLMCKNIIID> EMDEHEGFIBL(ODLMCKNIIID CEPLFOPGMML, object MMOEGADJJKD, [Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x79C95F0", Offset = "0x79C89F0", VA = "0x1879C95F0", Slot = "10")]
	[AsyncStateMachine(typeof(APLLEDFFGNC))]
	public Task GHMMEKPMDLL([Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x79C9130", Offset = "0x79C8530", VA = "0x1879C9130", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x79C9370", Offset = "0x79C8770", VA = "0x1879C9370", Slot = "11")]
	public void ELAFLAHNJKJ(DNAKFOJAEFK MAKELPANEHN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct COGDIJBNNAB : IEquatable<COGDIJBNNAB>
{
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public static readonly COGDIJBNNAB AMGMCPILGIN;

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "4")]
	public bool Equals(COGDIJBNNAB KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x79BED40", Offset = "0x79BE140", VA = "0x1879BED40", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class AHAGPJKICOJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x79BBF70", Offset = "0x79BB370", VA = "0x1879BBF70")]
	public AHAGPJKICOJ(string DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x79BBFD0", Offset = "0x79BB3D0", VA = "0x1879BBFD0")]
	public AHAGPJKICOJ(string DAMFJFKKFBI, Exception HIFFMIIALED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class LKPAAPKGANF : AHAGPJKICOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public readonly string PCNMNPFCKOF;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x79C4030", Offset = "0x79C3430", VA = "0x1879C4030")]
	public LKPAAPKGANF(string CGLECOHBABA, [NotNull] Exception HIFFMIIALED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class NCBCICEPNCF : AHAGPJKICOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public readonly ODLMCKNIIID ENOIOBKKCLG;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x79C9D10", Offset = "0x79C9110", VA = "0x1879C9D10")]
	public NCBCICEPNCF(ODLMCKNIIID LEEEDAFDHCO, [NotNull] Exception HIFFMIIALED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class DLGALKILMII : AHAGPJKICOJ
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x79BBF70", Offset = "0x79BB370", VA = "0x1879BBF70")]
	public DLGALKILMII(string DAMFJFKKFBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class GCAJLBNDPDL : AHAGPJKICOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public readonly StatusCode? MMMLLDHAFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public readonly OFLJMGOKAPC LNCNNFKMGKA;

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x79C12D0", Offset = "0x79C06D0", VA = "0x1879C12D0")]
	public GCAJLBNDPDL(OFLJMGOKAPC JHHDCJJPOOO, Exception HIFFMIIALED, StatusCode? DKDCEBHLPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x79C1030", Offset = "0x79C0430", VA = "0x1879C1030")]
	public static GCAJLBNDPDL OPJMKIIFFAI(OFLJMGOKAPC HPHIHIGFFEL, MNJHCHNBELP GHEAFJMIOIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class HNIAGBBBGAF : AHAGPJKICOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x79BBF70", Offset = "0x79BB370", VA = "0x1879BBF70")]
	public HNIAGBBBGAF(string DAMFJFKKFBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class LJAOKCMPBMO : AHAGPJKICOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public readonly short FLMJECNBAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public readonly string KAKJHGAFONA;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x79C3F40", Offset = "0x79C3340", VA = "0x1879C3F40")]
	public LJAOKCMPBMO(short HLLDLKNABPD, string OHFKJCKKOJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class OFFIMPJIBNO : AHAGPJKICOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public readonly short FLMJECNBAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public readonly string KAKJHGAFONA;

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x79CA900", Offset = "0x79C9D00", VA = "0x1879CA900")]
	public OFFIMPJIBNO(short HLLDLKNABPD, string OHFKJCKKOJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class PMOGPBHOBNF : AHAGPJKICOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x79BBF70", Offset = "0x79BB370", VA = "0x1879BBF70")]
	public PMOGPBHOBNF(string DAMFJFKKFBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class KHOLOPBDHOJ : AHAGPJKICOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x79C2140", Offset = "0x79C1540", VA = "0x1879C2140")]
	public KHOLOPBDHOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class GOMGDJGGPJG : KLOHGJNAMJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public readonly Dictionary<string, string> POJGGBMONKH;

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x79C1720", Offset = "0x79C0B20", VA = "0x1879C1720")]
	public GOMGDJGGPJG(TimeSpan ADEFLDLMJBI, string DAMFJFKKFBI, Dictionary<string, string> LDGNLBGEHIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class MGDBAFPJACD : FAAAOKLEHCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private readonly GLDBGNIANKN<OFLJMGOKAPC> AHBGDEMLOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private readonly GLDBGNIANKN<OFLJMGOKAPC> PANGJFJFGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private readonly GLDBGNIANKN<OFLJMGOKAPC> GDLIBDFJNLN;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<OFLJMGOKAPC> MBGKAGEFPIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x79C8C00", Offset = "0x79C8000", VA = "0x1879C8C00")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x79C8BA0", Offset = "0x79C7FA0", VA = "0x1879C8BA0")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action<OFLJMGOKAPC> HGFFLLEIOHK
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x79C8C60", Offset = "0x79C8060", VA = "0x1879C8C60")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x79C8CC0", Offset = "0x79C80C0", VA = "0x1879C8CC0")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<OFLJMGOKAPC> DDCGAMOKMMN
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x79C8D80", Offset = "0x79C8180", VA = "0x1879C8D80")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x79C8D20", Offset = "0x79C8120", VA = "0x1879C8D20")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x79C8DE0", Offset = "0x79C81E0", VA = "0x1879C8DE0", Slot = "31")]
	public override void OnDisconnected(OFLJMGOKAPC JHHDCJJPOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x79C8EE0", Offset = "0x79C82E0", VA = "0x1879C8EE0")]
	public MGDBAFPJACD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class DGAMKNBJEKB : FBOFLJNPJIO<FMKBFEIFICC>, ENKFANPICDA, GHEBHMFPHGA, HFONMDBAADL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private struct KGPIDBADHPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public DGAMKNBJEKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private CancellationToken <token>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x79C1CB0", Offset = "0x79C10B0", VA = "0x1879C1CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA0AFE0", Offset = "0xA0A3E0", VA = "0x180A0AFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class MBGMGAJHGAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public DGAMKNBJEKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public PGONDIMPEGN actionContext;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public MBGMGAJHGAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x79C6140", Offset = "0x79C5540", VA = "0x1879C6140")]
		internal void LNOFAIGPHPD(APGKENHKANG<string> timer, GBHBOJAPDOA log)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct MEPOBMMDCBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public AsyncTaskMethodBuilder<IReadOnlyDictionary<string, int>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public DGAMKNBJEKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private MBGMGAJHGAH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public TimeSpan? timeoutSpan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private APGKENHKANG<string> <pingStackTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private APGKENHKANG<string>.EEEKGBDKLHP <pingTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private Stopwatch <sw>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private Dictionary<string, int> <regionPings>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private TaskAwaiter<DJIKLFFCJOG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private YieldAwaitable.YieldAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x79C69E0", Offset = "0x79C5DE0", VA = "0x1879C69E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x79C8B30", Offset = "0x79C7F30", VA = "0x1879C8B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private CancellationTokenSource MFDOOFEPLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private CancellationTokenSource LJAPCKJDCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private CancellationToken HKMOFBPFGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private bool BHPJBLGGPOL;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private bool PCNGJELPOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xDB2810", Offset = "0xDB1C10", VA = "0x180DB2810")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x79BEE60", Offset = "0x79BE260", VA = "0x1879BEE60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x79BF380", Offset = "0x79BE780", VA = "0x1879BF380", Slot = "13")]
	public override bool MBEMBDOMNDO(ODLMCKNIIID CEPLFOPGMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x79BF500", Offset = "0x79BE900", VA = "0x1879BF500")]
	[UnityEngine.Scripting.Preserve]
	public DGAMKNBJEKB([CMKKAFOAFJE(null)] FMKBFEIFICC BOGAODIGBEK, [CMKKAFOAFJE(null)] GIGCKGJFCBC LGMNKOMDONC, [CMKKAFOAFJE(null)] DLMGPADEJND FKCAFNMOIHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x79BF5F0", Offset = "0x79BE9F0", VA = "0x1879BF5F0")]
	internal DGAMKNBJEKB(FMKBFEIFICC BOGAODIGBEK, GIGCKGJFCBC LGMNKOMDONC, DLMGPADEJND FKCAFNMOIHA, LBENLAIDCGC PFCKJIJNFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x79BF1C0", Offset = "0x79BE5C0", VA = "0x1879BF1C0", Slot = "17")]
	protected override void JNILBPLGMCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x79BEDB0", Offset = "0x79BE1B0", VA = "0x1879BEDB0")]
	private void AHDKAJMINEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x79BF060", Offset = "0x79BE460", VA = "0x1879BF060", Slot = "16")]
	protected override void FBJKJPCCJDF(ODLMCKNIIID MDAACFNPCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x79BF210", Offset = "0x79BE610", VA = "0x1879BF210", Slot = "14")]
	protected override void KFJOIDOOPPG(PGONDIMPEGN NMJDAHMKHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x79BF300", Offset = "0x79BE700", VA = "0x1879BF300", Slot = "15")]
	protected override void KMMACOIICMH(PGONDIMPEGN NMJDAHMKHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x79BF3E0", Offset = "0x79BE7E0", VA = "0x1879BF3E0")]
	[AsyncStateMachine(typeof(KGPIDBADHPO))]
	private void ODAGJMJJEKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x79BEF30", Offset = "0x79BE330", VA = "0x1879BEF30", Slot = "18")]
	[AsyncStateMachine(typeof(MEPOBMMDCBP))]
	public Task<IReadOnlyDictionary<string, int>> CAJECCJLNCE([Optional] TimeSpan? DHBANDEBEOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class ODLMCKNIIID : DJIKLFFCJOG, IEquatable<ODLMCKNIIID>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public readonly string HJEOLHEBLNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public readonly string? KOOLFAIBLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public readonly string? LNADMHFIEFG;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x79CA710", Offset = "0x79C9B10", VA = "0x1879CA710")]
	public ODLMCKNIIID(string PENOAKNPGNL, string ADKIHAFOMCN, string NLFEKILELLA, string? AAFOIPPOLDJ, string GEPHELLKDBE, string FLOFKJHCKAP, string? LGMEMDPDIBF, string? HCLGLDOIIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x79CA6B0", Offset = "0x79C9AB0", VA = "0x1879CA6B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x79CA420", Offset = "0x79C9820", VA = "0x1879CA420", Slot = "5")]
	public bool Equals(ODLMCKNIIID? KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x79CA4A0", Offset = "0x79C98A0", VA = "0x1879CA4A0", Slot = "0")]
	public override bool Equals(object? BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x79CA570", Offset = "0x79C9970", VA = "0x1879CA570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x1190550", Offset = "0x118F950", VA = "0x181190550")]
	public static bool PEOCKCCHEIN(ODLMCKNIIID? KGCKEJLFPJB, ODLMCKNIIID? HKELKGIPNGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x1190520", Offset = "0x118F920", VA = "0x181190520")]
	public static bool OGMAAAEFFPP(ODLMCKNIIID? KGCKEJLFPJB, ODLMCKNIIID? HKELKGIPNGP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class DJIKLFFCJOG : IEquatable<DJIKLFFCJOG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public readonly string HDHCAEKCBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public readonly string? IHEAENNDEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public readonly string? OIPOPONKPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public readonly string? MGNNIDMOBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public readonly string HJBOONFIKKP;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x79BF9B0", Offset = "0x79BEDB0", VA = "0x1879BF9B0")]
	public DJIKLFFCJOG(string PENOAKNPGNL, string? ADKIHAFOMCN, string? NLFEKILELLA, string? AAFOIPPOLDJ, string GEPHELLKDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x79BF950", Offset = "0x79BED50", VA = "0x1879BF950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x79BF7D0", Offset = "0x79BEBD0", VA = "0x1879BF7D0", Slot = "4")]
	public bool Equals(DJIKLFFCJOG? KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x79BF740", Offset = "0x79BEB40", VA = "0x1879BF740", Slot = "0")]
	public override bool Equals(object? BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x79BF860", Offset = "0x79BEC60", VA = "0x1879BF860", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class MDLDJDBMFDP : FBOFLJNPJIO<MDLDJDBMFDP.BBNIOFDMIFF>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public interface CEDAKDKOFPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool LDHMKGCJGFM();
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class BBNIOFDMIFF : MJJDBPOIHBE, EHHBJPGDAKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private MNJHCHNBELP FBNAEKPDGNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private bool FPDJJPOAPKK;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private PhotonVoiceNetwork EIONFFFKMHH
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x79BE880", Offset = "0x79BDC80", VA = "0x1879BE880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool DBAFCIKFGPM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0xA0E470", Offset = "0xA0D870", VA = "0x180A0E470", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public MNJHCHNBELP OAHKEPINACD
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool IDELIHAABJH
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x79BE3F0", Offset = "0x79BD7F0", VA = "0x1879BE3F0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool ANOCMPDNLFE
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x79BE750", Offset = "0x79BDB50", VA = "0x1879BE750", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x9AA510", Offset = "0x9A9910", VA = "0x1809AA510", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool PEKAHDHDLLK
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool HGPICIPOFCP
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x79BE830", Offset = "0x79BDC30", VA = "0x1879BE830", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public NJHODAAANIC HFKDBBEDJEK
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x79BE540", Offset = "0x79BD940", VA = "0x1879BE540", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool NFLGFEBNPCF
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x79BEB80", Offset = "0x79BDF80", VA = "0x1879BEB80", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<MNJHCHNBELP, MNJHCHNBELP> MNENECDPDPH
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x79BEC90", Offset = "0x79BE090", VA = "0x1879BEC90", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x79BE110", Offset = "0x79BD510", VA = "0x1879BE110", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<bool> GFELLJOGAEE
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x79BEAB0", Offset = "0x79BDEB0", VA = "0x1879BEAB0", Slot = "9")]
		public void KCEALIEBOKM(MGBPOGEONJM PCIEFMILMAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x79BE620", Offset = "0x79BDA20", VA = "0x1879BE620", Slot = "16")]
		public bool GGFJLNPFCHD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x79BE8E0", Offset = "0x79BDCE0", VA = "0x1879BE8E0", Slot = "17")]
		public bool JJGANOGNOKB(string FLOFKJHCKAP, JMLPIJKPAJF CBEFMIJGJOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x79BE2F0", Offset = "0x79BD6F0", VA = "0x1879BE2F0", Slot = "18")]
		public void DFAFKJLFMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x79BE1C0", Offset = "0x79BD5C0", VA = "0x1879BE1C0", Slot = "19")]
		public bool CFCMEBKEKCJ(AppSettings AFCFOMKIBBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "22")]
		public void PNJBKLODMKM(object HHGPJKKLNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "23")]
		public void OOEBPBPKHGC(object HHGPJKKLNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "24")]
		public void LIIAMCCAEJN(object HHGPJKKLNIG, bool MOJLEMKJLCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x79BE7E0", Offset = "0x79BDBE0", VA = "0x1879BE7E0", Slot = "25")]
		public IDisposable IHNHMFBCFOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "26")]
		private bool LIFJLIGALCE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "27")]
		public void LBEGNPIBGGG(StringBuilder ECDIJKLJMNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x79BE440", Offset = "0x79BD840", VA = "0x1879BE440", Slot = "28")]
		public bool EADHGHPOGHI(bool LCGINDJNOFG, [Out] string AFHGIBDEPMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public BBNIOFDMIFF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct NEOAIJKKCPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public MDLDJDBMFDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public DGAMKNBJEKB clientToFollow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private TaskAwaiter<ODLMCKNIIID> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x79C9E30", Offset = "0x79C9230", VA = "0x1879C9E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x79CA140", Offset = "0x79C9540", VA = "0x1879CA140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct OLIFIBHDENI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public MDLDJDBMFDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x79CA9F0", Offset = "0x79C9DF0", VA = "0x1879CA9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x79CAD60", Offset = "0x79CA160", VA = "0x1879CAD60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private readonly DGAMKNBJEKB DNBAOBJCMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private readonly CEDAKDKOFPO BGPHCJNPFJG;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x79C6610", Offset = "0x79C5A10", VA = "0x1879C6610", Slot = "13")]
	public override bool MBEMBDOMNDO(ODLMCKNIIID CEPLFOPGMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x79C66A0", Offset = "0x79C5AA0", VA = "0x1879C66A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public MDLDJDBMFDP([CMKKAFOAFJE(null)] DGAMKNBJEKB DNBAOBJCMFG, [CMKKAFOAFJE(null)] GIGCKGJFCBC LGMNKOMDONC, [CMKKAFOAFJE(null)] CEDAKDKOFPO BGPHCJNPFJG, [CMKKAFOAFJE(null)] DLMGPADEJND FKCAFNMOIHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x79C6380", Offset = "0x79C5780", VA = "0x1879C6380")]
	private Task FPJFAHKDPGH(OFLJMGOKAPC JHHDCJJPOOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x79C6210", Offset = "0x79C5610", VA = "0x1879C6210")]
	[AsyncStateMachine(typeof(NEOAIJKKCPM))]
	public Task BNJJHBIDADK(DGAMKNBJEKB OBJKAMEPEJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x79C6300", Offset = "0x79C5700", VA = "0x1879C6300")]
	[CompilerGenerated]
	internal static void DEGPDJFBOML(MNJHCHNBELP LHJAKMCKDJK, MNJHCHNBELP KDEBDLMDJAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x79C6540", Offset = "0x79C5940", VA = "0x1879C6540")]
	[AsyncStateMachine(typeof(OLIFIBHDENI))]
	[CompilerGenerated]
	private Task GNOBDACKKJH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[RecRoom.NoEngine.Common.Preserve]
public class KACNGPIKCDF
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[JsonProperty(PropertyName = "AI", Required = Required.Always)]
	[RecRoom.NoEngine.Common.Preserve]
	public string AccountId
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4D0", Offset = "0x9A98D0", VA = "0x1809AA4D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "AT", Required = Required.Always)]
	public byte[] AccessToken
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x9A9210", Offset = "0x9A8610", VA = "0x1809A9210")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "VB", Required = Required.Always)]
	public byte[] VerificationBlob
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x9A9260", Offset = "0x9A8660", VA = "0x1809A9260")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[JsonProperty(PropertyName = "CKA", Required = Required.Always)]
	[RecRoom.NoEngine.Common.Preserve]
	public byte[] ClientKeyA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3A0", Offset = "0x9A97A0", VA = "0x1809AA3A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x9B01E0", Offset = "0x9AF5E0", VA = "0x1809B01E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	[JsonProperty(PropertyName = "CIA", Required = Required.Always)]
	[RecRoom.NoEngine.Common.Preserve]
	public byte[] ClientIVA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x9AA490", Offset = "0x9A9890", VA = "0x1809AA490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x9B40A0", Offset = "0x9B34A0", VA = "0x1809B40A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	[JsonProperty(PropertyName = "CPK", Required = Required.Always)]
	[RecRoom.NoEngine.Common.Preserve]
	public byte[] ClientPublicKey
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3C0", Offset = "0x9A97C0", VA = "0x1809AA3C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3D0", Offset = "0x9A97D0", VA = "0x1809AA3D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public KACNGPIKCDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[RecRoom.NoEngine.Common.Preserve]
public class EHNKLJHOJLM
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "DR", Required = Required.Always)]
	public string Reason
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4D0", Offset = "0x9A98D0", VA = "0x1809AA4D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "KT", Required = Required.Default)]
	public byte[] SessionKeyB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x9A9210", Offset = "0x9A8610", VA = "0x1809A9210")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public EHNKLJHOJLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class LLOHELIIHCE : GHEBHMFPHGA, HFONMDBAADL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public enum BFIECEPJDKI
	{
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		Disconnected,
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		Connected
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private NetworkManager LMLGIBIBIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private TaskCompletionSource<ODLMCKNIIID> DPPGGINBEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	protected readonly GIGCKGJFCBC GIOICGKNAFL;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly GBHBOJAPDOA GFDFDHMHGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private readonly HashSet<DNAKFOJAEFK> NIDENLLKPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public BFIECEPJDKI NBOOECJLKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private ODLMCKNIIID CEPLFOPGMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private RSACryptoServiceProvider NBLDDOLLMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private RSACryptoServiceProvider AOHGBOEDEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private AesCryptoServiceProvider IJAGCHHLLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private byte[] FFLGMDMAGOH;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public ODLMCKNIIID PDPEHJBKLGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3C0", Offset = "0x9A97C0", VA = "0x1809AA3C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public string NLMFEFBFAOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x79C4730", Offset = "0x79C3B30", VA = "0x1879C4730", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public Task EAOGAADMFHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x79C59C0", Offset = "0x79C4DC0", VA = "0x1879C59C0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x79C5150", Offset = "0x79C4550", VA = "0x1879C5150", Slot = "10")]
	public void ELAFLAHNJKJ(DNAKFOJAEFK MAKELPANEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x79C5A80", Offset = "0x79C4E80", VA = "0x1879C5A80", Slot = "6")]
	public bool MBEMBDOMNDO(ODLMCKNIIID CEPLFOPGMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x79C5EB0", Offset = "0x79C52B0", VA = "0x1879C5EB0")]
	[RecRoom.NoEngine.Common.Preserve]
	public LLOHELIIHCE([CMKKAFOAFJE(null)] GIGCKGJFCBC PCFMAGHPDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x79C5760", Offset = "0x79C4B60", VA = "0x1879C5760")]
	private void GJOLDDOFDJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x79C5BF0", Offset = "0x79C4FF0", VA = "0x1879C5BF0")]
	private void NBPIEDPKJHN(ulong BLFGIKOAKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x79C5A10", Offset = "0x79C4E10", VA = "0x1879C5A10")]
	private void LAIGCHDIMGC(bool HJLBKDCCEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x79C4760", Offset = "0x79C3B60", VA = "0x1879C4760")]
	private void BAEEMCLJMCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x79C4970", Offset = "0x79C3D70", VA = "0x1879C4970")]
	private void BMGENHHBOCH(ulong BLFGIKOAKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x79C5610", Offset = "0x79C4A10", VA = "0x1879C5610")]
	private void GBNPFAFEJNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x79C5DD0", Offset = "0x79C51D0", VA = "0x1879C5DD0")]
	private void OAKPODFBHIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x79C4F70", Offset = "0x79C4370", VA = "0x1879C4F70")]
	private void DJNCAOLGMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x79C5C60", Offset = "0x79C5060", VA = "0x1879C5C60")]
	private void NGFHFNDJCAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x79C5AC0", Offset = "0x79C4EC0", VA = "0x1879C5AC0")]
	private static (IPAddress, ushort) MGLDGDHDKNH(string EPMPPBFGILN)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x79C4160", Offset = "0x79C3560", VA = "0x1879C4160")]
	private void AIDEBBJIGGI(ODLMCKNIIID CNPHJFFEOIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x79C51B0", Offset = "0x79C45B0", VA = "0x1879C51B0", Slot = "8")]
	public Task<ODLMCKNIIID> EMDEHEGFIBL(ODLMCKNIIID CEPLFOPGMML, object MMOEGADJJKD, [Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x79C4E90", Offset = "0x79C4290", VA = "0x1879C4E90", Slot = "7")]
	public Task DFAFKJLFMAP([Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x79C5680", Offset = "0x79C4A80", VA = "0x1879C5680", Slot = "9")]
	public Task GHMMEKPMDLL([Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x79C50F0", Offset = "0x79C44F0", VA = "0x1879C50F0", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class JDPLIJDCGOE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x79C1BE0", Offset = "0x79C0FE0", VA = "0x1879C1BE0")]
	public JDPLIJDCGOE(string DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x79C1C40", Offset = "0x79C1040", VA = "0x1879C1C40")]
	public JDPLIJDCGOE(string DAMFJFKKFBI, Exception HIFFMIIALED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class EIHNCHPBOPF : JDPLIJDCGOE
{
	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x79BFB00", Offset = "0x79BEF00", VA = "0x1879BFB00")]
	public EIHNCHPBOPF([NotNull] Exception HIFFMIIALED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class ADCALADJIGF : JDPLIJDCGOE
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x79BBEF0", Offset = "0x79BB2F0", VA = "0x1879BBEF0")]
	public ADCALADJIGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class ODEOONGFNOP : JDPLIJDCGOE
{
	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x79CA3A0", Offset = "0x79C97A0", VA = "0x1879CA3A0")]
	public ODEOONGFNOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class MJMDNOKPKEA
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	private static AesCryptoServiceProvider CHLLEJAPGNK;

	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private static readonly string PJLKFFLDKPE;

	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private static readonly string PPGCKDHKMGH;

	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private static readonly string IAAMDNFBCCN;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x79C9B80", Offset = "0x79C8F80", VA = "0x1879C9B80")]
	public static string KFGKCDABDOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x79C9B30", Offset = "0x79C8F30", VA = "0x1879C9B30")]
	public static string IILEADDFKBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x79C9A40", Offset = "0x79C8E40", VA = "0x1879C9A40")]
	public static AesCryptoServiceProvider AGNCIDEFMFJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class KJMBILGGHMH : LFFFEPFAKBF
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public enum AKELAFEFPPI
	{
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		Disconnected,
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		Connected
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private OPNNLJDPBAB MDEOLCMFKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private NetworkManager LMLGIBIBIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	protected readonly GIGCKGJFCBC GIOICGKNAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	private TaskCompletionSource<bool> BCAGLNKJEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	public AKELAFEFPPI NBOOECJLKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private RSACryptoServiceProvider NBLDDOLLMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private RSACryptoServiceProvider AOHGBOEDEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private AesCryptoServiceProvider IJAGCHHLLIJ;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public OPNNLJDPBAB EBHMBMCOPJA
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string MKCKEHEGPIE
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3C0", Offset = "0x9A97C0", VA = "0x1809AA3C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3D0", Offset = "0x9A97D0", VA = "0x1809AA3D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string KCIKDADOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x79C2B50", Offset = "0x79C1F50", VA = "0x1879C2B50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x79C3D90", Offset = "0x79C3190", VA = "0x1879C3D90")]
	[UnityEngine.Scripting.Preserve]
	public KJMBILGGHMH([CMKKAFOAFJE(null)] GIGCKGJFCBC PCFMAGHPDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x79C3220", Offset = "0x79C2620", VA = "0x1879C3220")]
	private void GJOLDDOFDJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x79C3940", Offset = "0x79C2D40", VA = "0x1879C3940")]
	private void NBPIEDPKJHN(ulong BLFGIKOAKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x79C2C70", Offset = "0x79C2070", VA = "0x1879C2C70")]
	private void EJODOKMOJAJ(ulong BLFGIKOAKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x79C2960", Offset = "0x79C1D60", VA = "0x1879C2960")]
	private void BMGENHHBOCH(ulong BLFGIKOAKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x79C3130", Offset = "0x79C2530", VA = "0x1879C3130")]
	private void GBNPFAFEJNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x79C3D20", Offset = "0x79C3120", VA = "0x1879C3D20")]
	private void OAKPODFBHIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x79C3C80", Offset = "0x79C3080", VA = "0x1879C3C80")]
	private void NGFHFNDJCAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x79C3810", Offset = "0x79C2C10", VA = "0x1879C3810")]
	private static (IPAddress, ushort) MGLDGDHDKNH(string EPMPPBFGILN)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x79C21C0", Offset = "0x79C15C0", VA = "0x1879C21C0")]
	private void AIDEBBJIGGI(string GEPHELLKDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x79C3420", Offset = "0x79C2820", VA = "0x1879C3420", Slot = "7")]
	public Task<bool> IICOEEPBDMC(string LGMEMDPDIBF, string BEFEOEPDJCE, string GEPHELLKDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x79C2AB0", Offset = "0x79C1EB0", VA = "0x1879C2AB0", Slot = "8")]
	public Task DFAFKJLFMAP([Optional] CancellationToken LMNHDKIFBOH)
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

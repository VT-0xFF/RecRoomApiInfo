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
using RecRoom.NoEngine.Common;
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
		[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E75450", Offset = "0x5E74850", VA = "0x185E75450")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79C170", Offset = "0x79B570", VA = "0x18079C170")]
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
		[Cpp2IlInjected.Address(RVA = "0x79C1B0", Offset = "0x79B5B0", VA = "0x18079C1B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BAEADLGJAJF : BJNPNPAOLKG, BOEDEAICBBP, DGOECEIMKPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class HIFLLDIKCND : EOACOFFILAP
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class FNBLCCJFIGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Action onCompleteCallback;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public FNBLCCJFIGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x56DAC50", Offset = "0x56DA050", VA = "0x1856DAC50")]
			internal void IKFKLDJEHGK(BGDHFGMKEAF rh)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool JNGALIPDDKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5E70690", Offset = "0x5E6FA90", VA = "0x185E70690", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool BAIMFEIJEPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5E70580", Offset = "0x5E6F980", VA = "0x185E70580", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public IReadOnlyList<DFJNGGLLPFD> CJCIGFHPMMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5E70470", Offset = "0x5E6F870", VA = "0x185E70470", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5E70350", Offset = "0x5E6F750", VA = "0x185E70350", Slot = "7")]
		public bool AOLPMJFBOPE(Action PNFGOKHMIDN, string FJKPAKACFID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public HIFLLDIKCND()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private CMJPDOILBCJ FLHPNDMJFKG;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly byte[] CGMPAIIMFKL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override bool JDCAKBHEBFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4FE52D0", Offset = "0x4FE46D0", VA = "0x184FE52D0", Slot = "80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override CMJPDOILBCJ JALJAMAPEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7782D0", Offset = "0x7776D0", VA = "0x1807782D0", Slot = "81")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override bool KMPFJLHJGKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E68660", Offset = "0x5E67A60", VA = "0x185E68660", Slot = "82")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override bool JCIECFLLIAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E67CB0", Offset = "0x5E670B0", VA = "0x185E67CB0", Slot = "60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5E67BE0", Offset = "0x5E66FE0", VA = "0x185E67BE0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override float DFDLPGJIBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5E68FB0", Offset = "0x5E683B0", VA = "0x185E68FB0", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override EOACOFFILAP LIOOIABOPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x770C90", Offset = "0x770090", VA = "0x180770C90", Slot = "77")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override bool NPNDHJGALCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5E67B50", Offset = "0x5E66F50", VA = "0x185E67B50", Slot = "83")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E68F20", Offset = "0x5E68320", VA = "0x185E68F20", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override bool DIPBIEMOPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5E68DA0", Offset = "0x5E681A0", VA = "0x185E68DA0", Slot = "85")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool APHFIAIJBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5E68F70", Offset = "0x5E68370", VA = "0x185E68F70", Slot = "86")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override HJJBCFNINCF BLKNALBEPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5E68010", Offset = "0x5E67410", VA = "0x185E68010", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool BPADHEOMPKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5E67D40", Offset = "0x5E67140", VA = "0x185E67D40", Slot = "76")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override int NMDMAGAPAMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5E68440", Offset = "0x5E67840", VA = "0x185E68440", Slot = "63")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override int PNPJGGDDODN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5E68900", Offset = "0x5E67D00", VA = "0x185E68900", Slot = "64")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override MCGPJKMOCMD LDNPDGDNPAI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5E68CE0", Offset = "0x5E680E0", VA = "0x185E68CE0", Slot = "65")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public override int OJNLFCBEHAC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5E68560", Offset = "0x5E67960", VA = "0x185E68560", Slot = "66")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public override int LPLGGILIPJH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5E683D0", Offset = "0x5E677D0", VA = "0x185E683D0", Slot = "67")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public override event MLOFNKJDPCG HAPNNDIGOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5E685C0", Offset = "0x5E679C0", VA = "0x185E685C0", Slot = "56")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5E68060", Offset = "0x5E67460", VA = "0x185E68060", Slot = "57")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public override event Action<MCGPJKMOCMD> FGHKLLILBJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5E67D90", Offset = "0x5E67190", VA = "0x185E67D90", Slot = "58")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5E684B0", Offset = "0x5E678B0", VA = "0x185E684B0", Slot = "59")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public override event Action<CMJPDOILBCJ, CMJPDOILBCJ> DOEIOPGPMLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5E68970", Offset = "0x5E67D70", VA = "0x185E68970", Slot = "78")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5E68C30", Offset = "0x5E68030", VA = "0x185E68C30", Slot = "79")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5E67E40", Offset = "0x5E67240", VA = "0x185E67E40", Slot = "90")]
	public override void DJNOJIFGGKI(MDNFCDJDIDI HPKDHFNNJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5E68A60", Offset = "0x5E67E60", VA = "0x185E68A60")]
	[JMGGEKJCAGA(PLCOHLLKCIG.GameOnly)]
	private static void KLOPPCLPFPI(DIBCBJLEDOH KIMBONFFHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5E69070", Offset = "0x5E68470", VA = "0x185E69070")]
	[UnityEngine.Scripting.Preserve]
	public BAEADLGJAJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E67C30", Offset = "0x5E67030", VA = "0x185E67C30")]
	private void BINLDANECBD(bool OFHJBKBPMED, bool AGHHJFKHHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E686A0", Offset = "0x5E67AA0", VA = "0x185E686A0", Slot = "68")]
	[CanBeNull]
	public override MCGPJKMOCMD JCNMANGDFFO(int GGMPKKECCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5E68B80", Offset = "0x5E67F80", VA = "0x185E68B80")]
	private static short LNMPGJBGHOF(StreamBuffer PPGLOBNDEEL, object HGPGJAJMFAD)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E68230", Offset = "0x5E67630", VA = "0x185E68230")]
	private static object EGJJDKCHCLD(StreamBuffer FIKIHBLOIJA, short HKIFHAEDDHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E68100", Offset = "0x5E67500", VA = "0x185E68100", Slot = "100")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5E688B0", Offset = "0x5E67CB0", VA = "0x185E688B0", Slot = "69")]
	public override bool JOHMFPFECBO(AppSettings AJKMEHBADOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E68A20", Offset = "0x5E67E20", VA = "0x185E68A20", Slot = "70")]
	public override void KKINBLMALBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E68760", Offset = "0x5E67B60", VA = "0x185E68760", Slot = "71")]
	public override bool JLHHAFCKMJE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5E68DF0", Offset = "0x5E681F0", VA = "0x185E68DF0", Slot = "72")]
	public override void OFMKHNFAELF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E68D20", Offset = "0x5E68120", VA = "0x185E68D20", Slot = "73")]
	public override bool NMADGGDHPMI(byte BBGPALIBDLK, Hashtable HGLLFFGNFNO, EHOFEDECKGG CABAACJJFGI, SendOptions MDNGOAELOMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E68EB0", Offset = "0x5E682B0", VA = "0x185E68EB0", Slot = "88")]
	public override bool PAIFOJKMMAB(string FHFJJKMLAMJ, NJPEOABBCGE IFDLNJBIMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E67F10", Offset = "0x5E67310", VA = "0x185E67F10", Slot = "89")]
	public override void DLEHOPBCFHO(string EMBBEGCDAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E68E30", Offset = "0x5E68230", VA = "0x185E68E30", Slot = "93")]
	public void OnEvent(EventData OCFFDKFEACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "94")]
	public void OnPlayerEnteredRoom(GBNAOCOJGEF GOLJPGFPJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "95")]
	public void OnPlayerWillLeaveRoom(GBNAOCOJGEF HFLDKBFMDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "96")]
	public void OnPlayerLeftRoom(GBNAOCOJGEF HFLDKBFMDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "97")]
	public void OnRoomPropertiesUpdate(Hashtable IEIMNBLDJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "98")]
	public void OnPlayerPropertiesUpdate(GBNAOCOJGEF GNDFGOLCJMA, Hashtable PAFKOGJAJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5E68B60", Offset = "0x5E67F60", VA = "0x185E68B60", Slot = "99")]
	private void LAFKKADDCJG(GBNAOCOJGEF HEMGIECNFEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DDIBIGFOLFO : AKGKFDBFHCF, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AKGKFDBFHCF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	BFMJCHANHOA MHFOPFGCPAH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string JBHCEKANEDA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Task IINENCGHIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CEHFKNIEPII(BFMJCHANHOA OBMCAKJAMCD);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task KKINBLMALBK([Optional] CancellationToken EANFAKGANNH);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<BFMJCHANHOA> LOPFAPEFLFB(BFMJCHANHOA OBMCAKJAMCD, object ILANCELDAHJ, [Optional] CancellationToken EANFAKGANNH);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task PNLFHFPFNDO([Optional] CancellationToken EANFAKGANNH);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MICKLOPCCJL(KHELFPNOEKF CKKLMBNDAMN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface IMOIMFPGIOM
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HFFPBIOICJP(ushort GIMFAPCPALH, LDIONLMHMBH OJNKNMGPJGH, params object[] DEHOHHHLHBF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal enum LDIONLMHMBH
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
public interface NNOIIBODMMD : AKGKFDBFHCF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	MNNDKCCBBEO CMINNHFOLIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MNNDKCCBBEO : DDIBIGFOLFO, AKGKFDBFHCF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyDictionary<string, int>> KICONNKHJCA([Optional] TimeSpan? DKKLOLCIGJB);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DJFGNEJLECF
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool DCHEAOMCJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool OIFNFPMGALD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	TimeSpan LOGDGGDPLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	TimeSpan LCCFAKHHEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AppSettings KJHNAPFAOPH(IPGEKALJHDB FJFEMOFEPKH);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HJJBCFNINCF KALMIDNOLAJ(IPGEKALJHDB FJFEMOFEPKH);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<IPGEKALJHDB> LEJFJBNJNHL(CancellationToken EANFAKGANNH);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class GFBOBHOGHMJ : OPMLKAJNPOJ, DGOECEIMKPO, OPGJBBEIFPA, OIOBEGOFIIN, GCGJIHLIODA, LPKJPBGAKAP, GLGDCCILJJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly string NBOJOMFFCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public FCJKIAIKOOM NCBMOBPBPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public FCJKIAIKOOM ONBHGHIDNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public CFBCANLCDFG<AMEEIBMCCBH> HGEFLMKKAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public FCJKIAIKOOM GAPGIOLGAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public CFBCANLCDFG<string> HGHFMAHFIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public CFBCANLCDFG<Dictionary<string, object>> IJKBAGNFAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public CFBCANLCDFG<AMEEIBMCCBH> IICJNGBKBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public HHJEIKBAAJF<bool, bool> ALKNKIAHDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public FCJKIAIKOOM GDHHPGKNFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public FCJKIAIKOOM OBDIMJNEDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public FCJKIAIKOOM FHMJEAFILOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public FCJKIAIKOOM FOGCDMMFHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public FCJKIAIKOOM CFOMLDCMMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public CFBCANLCDFG<GBNAOCOJGEF> GBBMGEDMGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public HHJEIKBAAJF<PhotonView, GBNAOCOJGEF> OOPNICICCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public MKFPLDNDPJC<PhotonView, GBNAOCOJGEF, GBNAOCOJGEF> OCLNJAJAFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public HHJEIKBAAJF<short, string> NGABOCFBGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public CFBCANLCDFG<Hashtable> CCCLLELAMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public CFBCANLCDFG<LJPPACODAOE> FOAEEFECADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public HHJEIKBAAJF<short, string> PMMHMGHBPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public FCJKIAIKOOM CMOAMALBCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public CFBCANLCDFG<GBNAOCOJGEF> LMIIDHOLDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public CFBCANLCDFG<GBNAOCOJGEF> KMCMNECFGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public HHJEIKBAAJF<GBNAOCOJGEF, Hashtable> PFNDBFEHECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public HHJEIKBAAJF<short, string> EJGFHIBGJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public FCJKIAIKOOM LLICDFMMAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public FCJKIAIKOOM AIPBDDCHMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public CFBCANLCDFG<OperationResponse> LLJCDCGKJHG;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DC60", Offset = "0x5E6D060", VA = "0x185E6DC60", Slot = "31")]
	public virtual void OnDisconnected(AMEEIBMCCBH JFJLOHCPMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5DDC3C0", Offset = "0x5DDB7C0", VA = "0x185DDC3C0", Slot = "4")]
	public void OnConnected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x19C3D00", Offset = "0x19C3100", VA = "0x1819C3D00", Slot = "5")]
	public void OnConnectedToMaster()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "7")]
	public void OnRegionListReceived(BGDHFGMKEAF PKOLMAOJPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DC10", Offset = "0x5E6D010", VA = "0x185E6DC10", Slot = "8")]
	public void OnCustomAuthenticationResponse(Dictionary<string, object> KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DBC0", Offset = "0x5E6CFC0", VA = "0x185E6DBC0", Slot = "9")]
	public void OnCustomAuthenticationFailed(string JNMCDDLAKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DE70", Offset = "0x5E6D270", VA = "0x185E6DE70", Slot = "10")]
	public void OnPlayerEnteredRoom(GBNAOCOJGEF GOLJPGFPJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "11")]
	public void OnPlayerWillLeaveRoom(GBNAOCOJGEF HFLDKBFMDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DED0", Offset = "0x5E6D2D0", VA = "0x185E6DED0", Slot = "12")]
	public void OnPlayerLeftRoom(GBNAOCOJGEF HFLDKBFMDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DFC0", Offset = "0x5E6D3C0", VA = "0x185E6DFC0", Slot = "13")]
	public void OnRoomPropertiesUpdate(Hashtable IEIMNBLDJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DF30", Offset = "0x5E6D330", VA = "0x185E6DF30", Slot = "14")]
	public void OnPlayerPropertiesUpdate(GBNAOCOJGEF GNDFGOLCJMA, Hashtable PAFKOGJAJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DE10", Offset = "0x5E6D210", VA = "0x185E6DE10", Slot = "15")]
	public void OnMasterClientSwitched(GBNAOCOJGEF HEMGIECNFEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xB78F10", Offset = "0xB78310", VA = "0x180B78F10", Slot = "16")]
	public void OnJoinedLobby()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xD68DF0", Offset = "0xD681F0", VA = "0x180D68DF0", Slot = "17")]
	public void OnLeftLobby()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DFA0", Offset = "0x5E6D3A0", VA = "0x185E6DFA0", Slot = "18")]
	public void OnRoomListUpdate(List<GDAOLACHDKP> IDMKFDLGMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DDF0", Offset = "0x5E6D1F0", VA = "0x185E6DDF0", Slot = "19")]
	public void OnLobbyStatisticsUpdate(List<CNMHKNFOPBO> IFPKHMKLGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DCF0", Offset = "0x5E6D0F0", VA = "0x185E6DCF0", Slot = "20")]
	public void OnFriendListUpdate(List<FGECKCPINOO> HHNNNDEAMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DBA0", Offset = "0x5E6CFA0", VA = "0x185E6DBA0", Slot = "21")]
	public void OnCreatedRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DB30", Offset = "0x5E6CF30", VA = "0x185E6DB30", Slot = "22")]
	public void OnCreateRoomFailed(short FHHFCLCHKFP, string KCFFPPIEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xBF91B0", Offset = "0xBF85B0", VA = "0x180BF91B0", Slot = "23")]
	public void OnJoinedRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DD80", Offset = "0x5E6D180", VA = "0x185E6DD80", Slot = "24")]
	public void OnJoinRoomFailed(short FHHFCLCHKFP, string KCFFPPIEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DD10", Offset = "0x5E6D110", VA = "0x185E6DD10", Slot = "25")]
	public void OnJoinRandomFailed(short FHHFCLCHKFP, string KCFFPPIEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xEE22D0", Offset = "0xEE16D0", VA = "0x180EE22D0", Slot = "26")]
	public void OnLeftRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DAC0", Offset = "0x5E6CEC0", VA = "0x185E6DAC0", Slot = "30")]
	public void GGCOKGOGKHB(LJPPACODAOE PPPGPJEJFAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DA50", Offset = "0x5E6CE50", VA = "0x185E6DA50", Slot = "27")]
	public void DIKAMILNEML(PhotonView OFLHGMNHLKH, GBNAOCOJGEF MKDDEJJKIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D9C0", Offset = "0x5E6CDC0", VA = "0x185E6D9C0", Slot = "28")]
	public void AMDMMLCHNMM(PhotonView OFLHGMNHLKH, GBNAOCOJGEF JIMHKAMCMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5E6E020", Offset = "0x5E6D420", VA = "0x185E6E020", Slot = "29")]
	public void OnWebRpcResponse(OperationResponse CANKDHAGEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5E6E080", Offset = "0x5E6D480", VA = "0x185E6E080")]
	public GFBOBHOGHMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal static class MOEOKIFDBEP
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class DANMOOGDOMG<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Action<string, FMBKLOOGAFL> log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public FMBKLOOGAFL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CMJPDOILBCJ networkClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool region;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public OEGHPKANBGP photonCallbacks;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public DANMOOGDOMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4D9AE80", Offset = "0x4D9A280", VA = "0x184D9AE80")]
		internal void GPLMFOCOJIM(AMEEIBMCCBH disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4D9ACE0", Offset = "0x4D9A0E0", VA = "0x184D9ACE0")]
		internal void ELLLCFHLFMM(string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4D9AAD0", Offset = "0x4D99ED0", VA = "0x184D9AAD0")]
		internal void AJDOCKNHGHB(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class OALIKNIAJNC<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public GFBOBHOGHMJ photonCallbacks;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public OALIKNIAJNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8F30", Offset = "0x3DE8330", VA = "0x183DE8F30")]
		internal void MDAJOCLCHLL(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8AA0", Offset = "0x3DE7EA0", VA = "0x183DE8AA0")]
		internal void BBJJDEAHNIN(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8C00", Offset = "0x3DE8000", VA = "0x183DE8C00")]
		internal void HFPBKJLCIFE(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x25A9C50", Offset = "0x25A9050", VA = "0x1825A9C50")]
	public static void KFPONOFPHLM<T>(this OEGHPKANBGP OJBLMMFBMLK, TaskCompletionSource<T> KGCILHALMAA, [NotNull] CMJPDOILBCJ BMAPHLJJGMN, FMBKLOOGAFL GJGIHAJJGMJ, bool ENNOMKLNJGE, Action<string, FMBKLOOGAFL> BLHBFCHIDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x25AA250", Offset = "0x25A9650", VA = "0x1825AA250")]
	public static void KKLIOGPNOJF<T>(this GFBOBHOGHMJ OJBLMMFBMLK, TaskCompletionSource<T> KGCILHALMAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class ICKGPIOEHOD<TNetworking> : DDIBIGFOLFO, AKGKFDBFHCF, IDisposable where TNetworking : class, IDDJPGOLDLP, ENPDDPAPFEB
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class PFGEPHOEJHI
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
			public AsyncTaskMethodBuilder<IPGEKALJHDB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public PFGEPHOEJHI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private TaskAwaiter<IPGEKALJHDB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x2F72BB0", Offset = "0x2F71FB0", VA = "0x182F72BB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2F72F20", Offset = "0x2F72320", VA = "0x182F72F20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public FMBKLOOGAFL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public IPGEKALJHDB photonServerConnectionInfo;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public PFGEPHOEJHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3EC9FC0", Offset = "0x3EC93C0", VA = "0x183EC9FC0")]
		[AsyncStateMachine(typeof(ICKGPIOEHOD<>.PFGEPHOEJHI.<<ConnectToRegionInternal>b__0>d))]
		internal Task<IPGEKALJHDB> NGBLCJLDMIC(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct OHNBLKFGDNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AsyncTaskMethodBuilder<IPGEKALJHDB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public FMBKLOOGAFL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public IPGEKALJHDB photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private PFGEPHOEJHI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter<IPGEKALJHDB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3E06390", Offset = "0x3E05790", VA = "0x183E06390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3E06F80", Offset = "0x3E06380", VA = "0x183E06F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct KAAAMLLBGMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder<IPGEKALJHDB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public FMBKLOOGAFL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public IPGEKALJHDB photonServerConnectionInfo;

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
		[Cpp2IlInjected.Address(RVA = "0x395E220", Offset = "0x395D620", VA = "0x18395E220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x395EF60", Offset = "0x395E360", VA = "0x18395EF60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct PBEKJMDNMID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public FMBKLOOGAFL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x3EBA9C0", Offset = "0x3EB9DC0", VA = "0x183EBA9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3EBAC10", Offset = "0x3EBA010", VA = "0x183EBAC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct FGEDJNPLFEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private FMBKLOOGAFL <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x34665B0", Offset = "0x34659B0", VA = "0x1834665B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3466AD0", Offset = "0x3465ED0", VA = "0x183466AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class IDOMFNNEHMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public FMBKLOOGAFL actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public IDOMFNNEHMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x373EF00", Offset = "0x373E300", VA = "0x18373EF00")]
		internal Task<bool> DNKGELGMELE(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct PFPCGNNDHOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public FMBKLOOGAFL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private IDOMFNNEHMA <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x3EE66B0", Offset = "0x3EE5AB0", VA = "0x183EE66B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3EE74D0", Offset = "0x3EE68D0", VA = "0x183EE74D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class FDKNOBKALMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public FMBKLOOGAFL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public TaskCompletionSource<AMEEIBMCCBH> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public FDKNOBKALMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x344A0A0", Offset = "0x34494A0", VA = "0x18344A0A0")]
		internal void HLPFPBOHMNF(AMEEIBMCCBH disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x344A160", Offset = "0x3449560", VA = "0x18344A160")]
		internal void JBGGGIEKHED()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct FBDPCEGMDMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public FMBKLOOGAFL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private FDKNOBKALMN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<AMEEIBMCCBH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x343AAC0", Offset = "0x3439EC0", VA = "0x18343AAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x343BFF0", Offset = "0x343B3F0", VA = "0x18343BFF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct ECCNNAPIGHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<BFMJCHANHOA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public BFMJCHANHOA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private FMBKLOOGAFL <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<BFMJCHANHOA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x30E4A30", Offset = "0x30E3E30", VA = "0x1830E4A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x30E5650", Offset = "0x30E4A50", VA = "0x1830E5650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class IMDHGJCIEJI
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
			public AsyncTaskMethodBuilder<BFMJCHANHOA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public IMDHGJCIEJI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private TaskAwaiter<BFMJCHANHOA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x2F72F90", Offset = "0x2F72390", VA = "0x182F72F90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x2F73310", Offset = "0x2F72710", VA = "0x182F73310", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public FMBKLOOGAFL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public BFMJCHANHOA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public object pauseToken;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public IMDHGJCIEJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x37604D0", Offset = "0x375F8D0", VA = "0x1837604D0")]
		[AsyncStateMachine(typeof(ICKGPIOEHOD<>.IMDHGJCIEJI.<<ConnectToRoomInstanceInternal>b__0>d))]
		internal Task<BFMJCHANHOA> OLAHLALJGDA(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct CKBFFFOFBDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder<BFMJCHANHOA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public FMBKLOOGAFL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public BFMJCHANHOA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private IMDHGJCIEJI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter<BFMJCHANHOA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x48255B0", Offset = "0x48249B0", VA = "0x1848255B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4826310", Offset = "0x4825710", VA = "0x184826310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class MCHFALNELEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TaskCompletionSource<MAAEKIPMOMF> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public MCHFALNELEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3C9DC80", Offset = "0x3C9D080", VA = "0x183C9DC80")]
		internal void EHILPKLJKIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3C9DBF0", Offset = "0x3C9CFF0", VA = "0x183C9DBF0")]
		internal void DAGIGMCJHDJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct EKKDDEBLDOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public AsyncTaskMethodBuilder<BFMJCHANHOA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public FMBKLOOGAFL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public BFMJCHANHOA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private MCHFALNELEM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private NJPEOABBCGE <roomOptions>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private TaskAwaiter<IPGEKALJHDB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter<MAAEKIPMOMF> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x30FA950", Offset = "0x30F9D50", VA = "0x1830FA950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x30FCD90", Offset = "0x30FC190", VA = "0x1830FCD90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct JHGMLOPIIHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Task<AEPNGCJHCBN> whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private TaskAwaiter<AEPNGCJHCBN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x38F3870", Offset = "0x38F2C70", VA = "0x1838F3870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F66B0", Offset = "0x7F5AB0", VA = "0x1807F66B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct CCOMIILAPFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public FMBKLOOGAFL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x4727310", Offset = "0x4726710", VA = "0x184727310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4727550", Offset = "0x4726950", VA = "0x184727550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct ALFEKKDGMBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private FMBKLOOGAFL <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3565E50", Offset = "0x3565250", VA = "0x183565E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x35662E0", Offset = "0x35656E0", VA = "0x1835662E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct ENKNBMBMIFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public FMBKLOOGAFL actionContext;

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
		[Cpp2IlInjected.Address(RVA = "0x310BBD0", Offset = "0x310AFD0", VA = "0x18310BBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x310C390", Offset = "0x310B790", VA = "0x18310C390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class ANCGKGAFKDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public FMBKLOOGAFL actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public ANCGKGAFKDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3572AB0", Offset = "0x3571EB0", VA = "0x183572AB0")]
		internal Task<AEPNGCJHCBN> OMDFEADOBLK(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct PAIGCKOEOPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public FMBKLOOGAFL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private ANCGKGAFKDI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private TaskAwaiter<AEPNGCJHCBN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3EB1700", Offset = "0x3EB0B00", VA = "0x183EB1700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3EB2220", Offset = "0x3EB1620", VA = "0x183EB2220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class GMGHPEJDMBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public FMBKLOOGAFL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public TaskCompletionSource<MAAEKIPMOMF> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public GMGHPEJDMBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3576C10", Offset = "0x3576010", VA = "0x183576C10")]
		internal void FMMKNEMAAFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3576B80", Offset = "0x3575F80", VA = "0x183576B80")]
		internal void CKFAKHLNCLE(AMEEIBMCCBH disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3576950", Offset = "0x3575D50", VA = "0x183576950")]
		internal void CGEKLOMKMPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class INAAOPMNKIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TaskCompletionSource<MAAEKIPMOMF> reconnectToMasterServerTcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public GMGHPEJDMBM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public INAAOPMNKIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x376A7D0", Offset = "0x3769BD0", VA = "0x18376A7D0")]
		internal void DMMLAKFHGKL(AMEEIBMCCBH disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x376A870", Offset = "0x3769C70", VA = "0x18376A870")]
		internal void JGGCJHEMONO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct CICMDLAANCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public AsyncTaskMethodBuilder<AEPNGCJHCBN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public FMBKLOOGAFL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private GMGHPEJDMBM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private INAAOPMNKIJ <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TaskAwaiter<MAAEKIPMOMF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4811A20", Offset = "0x4810E20", VA = "0x184811A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x4813AF0", Offset = "0x4812EF0", VA = "0x184813AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class MHFOAJDNDBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public FMBKLOOGAFL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public TaskCompletionSource<MAAEKIPMOMF> reconnectToMasterServerTcs;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public MHFOAJDNDBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4AB0", Offset = "0x3CC3EB0", VA = "0x183CC4AB0")]
		internal string KPOLFNONLHC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3CC49C0", Offset = "0x3CC3DC0", VA = "0x183CC49C0")]
		internal void CHEJKDJJHBM(MAAEKIPMOMF _1, MAAEKIPMOMF _2)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct ADEMIHDFLDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public AsyncTaskMethodBuilder<MAAEKIPMOMF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public FMBKLOOGAFL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private MHFOAJDNDBN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private TaskAwaiter<MAAEKIPMOMF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3555510", Offset = "0x3554910", VA = "0x183555510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3556230", Offset = "0x3555630", VA = "0x183556230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct CPIPIMFFMJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x49DBEF0", Offset = "0x49DB2F0", VA = "0x1849DBEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7F66B0", Offset = "0x7F5AB0", VA = "0x1807F66B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct CNOEECGEDLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4911E80", Offset = "0x4911280", VA = "0x184911E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4912200", Offset = "0x4911600", VA = "0x184912200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct AMAKMPBFEBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AMEEIBMCCBH disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private BCHCBLJOICK <exception>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3566D00", Offset = "0x3566100", VA = "0x183566D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7F66B0", Offset = "0x7F5AB0", VA = "0x1807F66B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct PILHDLKNAFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public AMEEIBMCCBH disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private HashSet<KHELFPNOEKF>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3F1BB80", Offset = "0x3F1AF80", VA = "0x183F1BB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3F1C5B0", Offset = "0x3F1B9B0", VA = "0x183F1C5B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct JGFLGDILAML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private HashSet<BELOBGAHJDM>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x38F2800", Offset = "0x38F1C00", VA = "0x1838F2800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x38F2CE0", Offset = "0x38F20E0", VA = "0x1838F2CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class MFKEIJFOANK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public string timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public MFKEIJFOANK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
		internal string IFPEGBFEDOF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class HKJHCIEJHJP<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public FMBKLOOGAFL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public Dictionary<string, string> tcsTimeoutData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public ADPLOOKCEKH.COBOFIIAEGD timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public HKJHCIEJHJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x360B870", Offset = "0x360AC70", VA = "0x18360B870")]
		internal void AAEMHKICBCD(string prefix, Dictionary<string, string> dict)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x360BF90", Offset = "0x360B390", VA = "0x18360BF90")]
		internal FDMAPAJDLAP LHOOGIDKJFA(TimeSpan timeoutTime)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class HIGHCLFGHAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public TaskCompletionSource<MAAEKIPMOMF> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public HIGHCLFGHAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x35FE940", Offset = "0x35FDD40", VA = "0x1835FE940")]
		internal void PDBEGKHMJMB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct LKAIFGPJHEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public FMBKLOOGAFL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private HIGHCLFGHAO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public MAAEKIPMOMF connectedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public AppSettings appSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private TaskAwaiter<MAAEKIPMOMF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3A9E110", Offset = "0x3A9D510", VA = "0x183A9E110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3A9F400", Offset = "0x3A9E800", VA = "0x183A9F400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class JBNOFDENHEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public FMBKLOOGAFL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public JBNOFDENHEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x38E0E60", Offset = "0x38E0260", VA = "0x1838E0E60")]
		internal object OEKBDCFGEJE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class MKBGDBFJGJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public FMBKLOOGAFL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public MKBGDBFJGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3CCBC70", Offset = "0x3CCB070", VA = "0x183CCBC70")]
		internal object IMIMDMJDFDB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class OBPGAGEHPAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public ICKGPIOEHOD<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public FMBKLOOGAFL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public OBPGAGEHPAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3DE9D20", Offset = "0x3DE9120", VA = "0x183DE9D20")]
		internal object DENPCCEGNKF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static readonly GBIKKFKHKKF BLHBFCHIDPL;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly Hashtable IOJLLJDFELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly IMOIMFPGIOM LBOFEFMDOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly OABDLKEBIHB GIDLIGIPGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected readonly string BGNIELCKHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected readonly DJFGNEJLECF IEFBDHBMCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private TaskCompletionSource<AEPNGCJHCBN> IBDHPHHLPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[NotNull]
	public readonly OEGHPKANBGP LDCPGMGBMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected internal readonly TNetworking PIDBHCGDKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private ushort IJCADACICAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private COGOHHGNMOO<IPGEKALJHDB> NPLMENFIBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private COGOHHGNMOO<bool> DJMMLILPCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private COGOHHGNMOO<BFMJCHANHOA> PMBPHJJFKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private COGOHHGNMOO<AEPNGCJHCBN> JCNJDKCKHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool KOIOOBMHKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private bool ALFACEKNPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly HashSet<BELOBGAHJDM> IBIJJNLDBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly HashSet<KHELFPNOEKF> CKODDGKNPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private bool CIECAMCCGCB;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool APHFIAIJBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x36D1360", Offset = "0x36D0760", VA = "0x1836D1360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	[CanBeNull]
	public BFMJCHANHOA MHFOPFGCPAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x36CEA00", Offset = "0x36CDE00", VA = "0x1836CEA00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	protected MAAEKIPMOMF LAIHEFIFEBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x36CE3F0", Offset = "0x36CD7F0", VA = "0x1836CE3F0")]
		get
		{
			return default(MAAEKIPMOMF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	[CanBeNull]
	public string JBHCEKANEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x36D01C0", Offset = "0x36CF5C0", VA = "0x1836D01C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private TimeSpan LOGDGGDPLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x36CFDB0", Offset = "0x36CF1B0", VA = "0x1836CFDB0")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private TimeSpan LCCFAKHHEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x36CE4E0", Offset = "0x36CD8E0", VA = "0x1836CE4E0")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public Task IINENCGHIJD
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x36CEEB0", Offset = "0x36CE2B0", VA = "0x1836CEEB0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract bool CEHFKNIEPII(BFMJCHANHOA OBMCAKJAMCD);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x36CF280", Offset = "0x36CE680", VA = "0x1836CF280")]
	private static TimeSpan GALCBEBHJEF(TimeSpan GNGBIJILHHK, string MDFAJJKMBAI)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x36D1690", Offset = "0x36D0A90", VA = "0x1836D1690")]
	protected ICKGPIOEHOD(TNetworking HHIFKNOOMJO, DJFGNEJLECF BAIKLPPEPEE, string NBOJOMFFCIM, OABDLKEBIHB GIDLIGIPGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x36D16D0", Offset = "0x36D0AD0", VA = "0x1836D16D0")]
	internal ICKGPIOEHOD(TNetworking HHIFKNOOMJO, DJFGNEJLECF BAIKLPPEPEE, string NBOJOMFFCIM, OABDLKEBIHB GIDLIGIPGCJ, [Optional] IMOIMFPGIOM LBOFEFMDOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x36D1100", Offset = "0x36D0500", VA = "0x1836D1100")]
	private void OBLCMLDLFJA(bool FPOCHAEKMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x36CF010", Offset = "0x36CE410", VA = "0x1836CF010")]
	private void FBPMKFANJCP(MAAEKIPMOMF JGHOLNPLABJ, MAAEKIPMOMF HBFICDCNBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x36CED10", Offset = "0x36CE110", VA = "0x1836CED10")]
	internal FMBKLOOGAFL EAPNGKPMMIF()
	{
		return default(FMBKLOOGAFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x36D05F0", Offset = "0x36CF9F0", VA = "0x1836D05F0")]
	[AsyncStateMachine(typeof(ICKGPIOEHOD<>.OHNBLKFGDNE))]
	private Task<IPGEKALJHDB> KDKILEGMOBD(FMBKLOOGAFL GJGIHAJJGMJ, IPGEKALJHDB FJFEMOFEPKH, CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x36CF100", Offset = "0x36CE500", VA = "0x1836CF100")]
	[AsyncStateMachine(typeof(ICKGPIOEHOD<>.KAAAMLLBGMO))]
	protected Task<IPGEKALJHDB> FOLKPAEOMMC(FMBKLOOGAFL GJGIHAJJGMJ, IPGEKALJHDB FJFEMOFEPKH, CancellationToken ALOMHAAFBNI, CancellationToken MPAKBKFDENJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x36CE750", Offset = "0x36CDB50", VA = "0x1836CE750")]
	[AsyncStateMachine(typeof(ICKGPIOEHOD<>.PBEKJMDNMID))]
	protected Task CDOANGAAHFB(FMBKLOOGAFL GJGIHAJJGMJ, CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x36D08F0", Offset = "0x36CFCF0", VA = "0x1836D08F0", Slot = "7")]
	[AsyncStateMachine(typeof(ICKGPIOEHOD<>.FGEDJNPLFEE))]
	public Task KKINBLMALBK([Optional] CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x36CFFE0", Offset = "0x36CF3E0", VA = "0x1836CFFE0")]
	[AsyncStateMachine(typeof(ICKGPIOEHOD<>.PFPCGNNDHOM))]
	private Task HNDPPCJFGOD(FMBKLOOGAFL GJGIHAJJGMJ, CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x36D0220", Offset = "0x36CF620", VA = "0x1836D0220")]
	[AsyncStateMachine(typeof(ICKGPIOEHOD<>.FBDPCEGMDMP))]
	private Task<bool> JIGIAENFLOI(FMBKLOOGAFL GJGIHAJJGMJ, CancellationToken NOEAHPPKHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x36D0BA0", Offset = "0x36CFFA0", VA = "0x1836D0BA0", Slot = "8")]
	[AsyncStateMachine(typeof(ICKGPIOEHOD<>.ECCNNAPIGHB))]
	public Task<BFMJCHANHOA> LOPFAPEFLFB(BFMJCHANHOA OBMCAKJAMCD, object ILANCELDAHJ, [Optional] CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x36D0D60", Offset = "0x36D0160", VA = "0x1836D0D60")]
	[AsyncStateMachine(typeof(ICKGPIOEHOD<>.CKBFFFOFBDA))]
	private Task<BFMJCHANHOA> MOJHDPHKGAC(FMBKLOOGAFL GJGIHAJJGMJ, BFMJCHANHOA OBMCAKJAMCD, object ILANCELDAHJ, CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x36D0A00", Offset = "0x36CFE00", VA = "0x1836D0A00")]
	[AsyncStateMachine(typeof(ICKGPIOEHOD<>.EKKDDEBLDOK))]
	private Task<BFMJCHANHOA> KLJMBEBEMHL(FMBKLOOGAFL GJGIHAJJGMJ, BFMJCHANHOA OBMCAKJAMCD, object ILANCELDAHJ, CancellationToken ALOMHAAFBNI, CancellationToken MPAKBKFDENJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x36CEBA0", Offset = "0x36CDFA0", VA = "0x1836CEBA0")]
	[AsyncStateMachine(typeof(ICKGPIOEHOD<>.JHGMLOPIIHL))]
	private void DHHOMOCCGBJ(Task<AEPNGCJHCBN> GIKFFOODFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x36CFBA0", Offset = "0x36CEFA0", VA = "0x1836CFBA0")]
	[AsyncStateMachine(typeof(ICKGPIOEHOD<>.CCOMIILAPFA))]
	private Task GPMDMPEAKFA(FMBKLOOGAFL GJGIHAJJGMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x36D13D0", Offset = "0x36D07D0", VA = "0x1836D13D0", Slot = "9")]
	[AsyncStateMachine(typeof(ICKGPIOEHOD<>.ALFEKKDGMBL))]
	public Task PNLFHFPFNDO([Optional] CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x36CED60", Offset = "0x36CE160", VA = "0x1836CED60")]
	[AsyncStateMachine(typeof(ICKGPIOEHOD<>.ENKNBMBMIFI))]
	private Task EDBMNKKJLFG(FMBKLOOGAFL GJGIHAJJGMJ, [Optional] CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x36CEA50", Offset = "0x36CDE50", VA = "0x1836CEA50")]
	[AsyncStateMachine(typeof(ICKGPIOEHOD<>.PAIGCKOEOPE))]
	private Task DCCIKLPJMCE(FMBKLOOGAFL GJGIHAJJGMJ, [Optional] CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x36D0EE0", Offset = "0x36D02E0", VA = "0x1836D0EE0")]
	[AsyncStateMachine(typeof(ICKGPIOEHOD<>.CICMDLAANCE))]
	private Task<AEPNGCJHCBN> NDNCCODAMPG(FMBKLOOGAFL GJGIHAJJGMJ, CancellationToken ALOMHAAFBNI, CancellationToken MPAKBKFDENJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x36D11F0", Offset = "0x36D05F0", VA = "0x1836D11F0")]
	[AsyncStateMachine(typeof(ICKGPIOEHOD<>.ADEMIHDFLDP))]
	private Task<MAAEKIPMOMF> PBEMCMPLNDI(FMBKLOOGAFL GJGIHAJJGMJ, CancellationToken EANFAKGANNH, string ONCLGAMIHNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x36D0120", Offset = "0x36CF520", VA = "0x1836D0120", Slot = "14")]
	protected virtual void HNPBKJBDBIF(FMBKLOOGAFL GJGIHAJJGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x36D0850", Offset = "0x36CFC50", VA = "0x1836D0850", Slot = "15")]
	protected virtual void KHNJCADCCHB(FMBKLOOGAFL GJGIHAJJGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x36CFE80", Offset = "0x36CF280", VA = "0x1836CFE80")]
	private void HFFPBIOICJP(FMBKLOOGAFL GJGIHAJJGMJ, LDIONLMHMBH ONCLGAMIHNG, params object[] IFILEFKNBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "16")]
	protected virtual void CODPPFBBBDI(BFMJCHANHOA KFMCHODINGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x36D1050", Offset = "0x36D0450", VA = "0x1836D1050")]
	[AsyncStateMachine(typeof(ICKGPIOEHOD<>.CPIPIMFFMJJ))]
	private void NKDAHPMFOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x36CFCD0", Offset = "0x36CF0D0", VA = "0x1836CFCD0")]
	[AsyncStateMachine(typeof(ICKGPIOEHOD<>.CNOEECGEDLD))]
	private Task HBNODGPONGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x36D0380", Offset = "0x36CF780", VA = "0x1836D0380")]
	[AsyncStateMachine(typeof(ICKGPIOEHOD<>.AMAKMPBFEBH))]
	private void JOGOJGHDDML(AMEEIBMCCBH ONHEFMLKKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x36CF5D0", Offset = "0x36CE9D0", VA = "0x1836CF5D0")]
	[AsyncStateMachine(typeof(ICKGPIOEHOD<>.PILHDLKNAFG))]
	private Task GDIMMCAOODP(AMEEIBMCCBH ONHEFMLKKKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x36D0760", Offset = "0x36CFB60", VA = "0x1836D0760")]
	[AsyncStateMachine(typeof(ICKGPIOEHOD<>.JGFLGDILAML))]
	private Task KGHPFDLCCAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x36D0D00", Offset = "0x36D0100", VA = "0x1836D0D00", Slot = "10")]
	public void MICKLOPCCJL(KHELFPNOEKF CKKLMBNDAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2E2FE90", Offset = "0x2E2F290", VA = "0x182E2FE90")]
	private TaskCompletionSource<T> LNBHAOAMGDB<T>(FMBKLOOGAFL GJGIHAJJGMJ, CancellationToken EANFAKGANNH, TimeSpan GBELJBLENFG, string INCJJFEMAMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2E2FFD0", Offset = "0x2E2F3D0", VA = "0x182E2FFD0")]
	private TaskCompletionSource<T> LNBHAOAMGDB<T>(FMBKLOOGAFL GJGIHAJJGMJ, CancellationToken EANFAKGANNH, TimeSpan GBELJBLENFG, ADPLOOKCEKH.COBOFIIAEGD INCJJFEMAMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x36CE8A0", Offset = "0x36CDCA0", VA = "0x1836CE8A0")]
	[AsyncStateMachine(typeof(ICKGPIOEHOD<>.LKAIFGPJHEJ))]
	protected Task COKMAIMDMAL(FMBKLOOGAFL GJGIHAJJGMJ, AppSettings AJKMEHBADOK, MAAEKIPMOMF JBPHFLPEOPE, CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x36CEC60", Offset = "0x36CE060", VA = "0x1836CEC60", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x36CF6D0", Offset = "0x36CEAD0", VA = "0x1836CF6D0", Slot = "17")]
	protected virtual void GDPAAGOGDPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x36D05D0", Offset = "0x36CF9D0", VA = "0x1836D05D0")]
	private static string KDHHFEGNEOI(FMBKLOOGAFL GJGIHAJJGMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0")]
	protected void FPKCBBOJANI(string KCFFPPIEBHH, [Optional] FMBKLOOGAFL GJGIHAJJGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x36D0440", Offset = "0x36CF840", VA = "0x1836D0440")]
	protected void KCBIFEFDHPK(string KCFFPPIEBHH, [Optional] FMBKLOOGAFL GJGIHAJJGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x36CFA10", Offset = "0x36CEE10", VA = "0x1836CFA10")]
	protected void GJOFFIOBNOA(string KCFFPPIEBHH, [Optional] FMBKLOOGAFL GJGIHAJJGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x36CE5B0", Offset = "0x36CD9B0", VA = "0x1836CE5B0")]
	protected void BHHNAGAKLKD(string KCFFPPIEBHH, Exception LLKMJCLKBJP, [Optional] FMBKLOOGAFL GJGIHAJJGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x36CEF40", Offset = "0x36CE340", VA = "0x1836CEF40")]
	public void FAHKOFMADNM(MDNFCDJDIDI LJPFKJLDINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x36CF420", Offset = "0x36CE820", VA = "0x1836CF420")]
	[CompilerGenerated]
	private void GBKLIKBCCIJ(CMJPDOILBCJ KKODDNECDAG, CMJPDOILBCJ APLOOGCGDFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x20EC030", Offset = "0x20EB430", VA = "0x1820EC030")]
	[CompilerGenerated]
	internal static string LPNHJJFMLIP<T>(TimeSpan AEPDBMBDGLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct FMBKLOOGAFL : IEquatable<FMBKLOOGAFL>, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public readonly ushort KKONKJGKJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public readonly string BGNIELCKHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly IDDJPGOLDLP HHIFKNOOMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly Stopwatch LPMKNEMAFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly List<(TimeSpan, MAAEKIPMOMF, MAAEKIPMOMF)> KIHMDPEJCKI;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public TimeSpan HMJEFCJDFLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D1F0", Offset = "0x5E6C5F0", VA = "0x185E6D1F0")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IReadOnlyList<(TimeSpan time, MAAEKIPMOMF oldState, MAAEKIPMOMF newState)> CCEKGNKLKIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x775A80", Offset = "0x774E80", VA = "0x180775A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D210", Offset = "0x5E6C610", VA = "0x185E6D210")]
	public FMBKLOOGAFL(ushort GIMFAPCPALH, string NBOJOMFFCIM, IDDJPGOLDLP HHIFKNOOMJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CEB0", Offset = "0x5E6C2B0", VA = "0x185E6CEB0")]
	private void CPFOCNJIJMJ(MAAEKIPMOMF JGHOLNPLABJ, MAAEKIPMOMF HBFICDCNBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D1A0", Offset = "0x5E6C5A0", VA = "0x185E6D1A0", Slot = "4")]
	public bool Equals(FMBKLOOGAFL LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D110", Offset = "0x5E6C510", VA = "0x185E6D110", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D1D0", Offset = "0x5E6C5D0", VA = "0x185E6D1D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D1B0", Offset = "0x5E6C5B0", VA = "0x185E6D1B0")]
	public static bool FCHDBNDMOOD(FMBKLOOGAFL OJKFAPKLEMA, FMBKLOOGAFL BBHLJNIGCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CFC0", Offset = "0x5E6C3C0", VA = "0x185E6CFC0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal static class AKOMMLDGCCL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct PNNELBHICFO<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public COGOHHGNMOO<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public FMBKLOOGAFL doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3F245B0", Offset = "0x3F239B0", VA = "0x183F245B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3F24860", Offset = "0x3F23C60", VA = "0x183F24860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct IJFPENGNABL<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public COGOHHGNMOO<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public TimeSpan forceCancelTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public FMBKLOOGAFL doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x375D550", Offset = "0x375C950", VA = "0x18375D550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x375D7A0", Offset = "0x375CBA0", VA = "0x18375D7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct AFFEJEKMJHK<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public COGOHHGNMOO<TArgs> clientAction;

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
		[Cpp2IlInjected.Address(RVA = "0x3558F00", Offset = "0x3558300", VA = "0x183558F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3559460", Offset = "0x3558860", VA = "0x183559460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2B375E0", Offset = "0x2B369E0", VA = "0x182B375E0")]
	[AsyncStateMachine(typeof(PNNELBHICFO<>))]
	public static Task NALOHNCFOBM<TArgs>(this COGOHHGNMOO<TArgs> NPLCHPMOCIL, [Optional] FMBKLOOGAFL JANHMKNOIIH) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2B37050", Offset = "0x2B36450", VA = "0x182B37050")]
	[AsyncStateMachine(typeof(IJFPENGNABL<>))]
	public static Task DAOCKPKCBNK<TArgs>(this COGOHHGNMOO<TArgs> NPLCHPMOCIL, TimeSpan DFBPBCFBNPE, [Optional] FMBKLOOGAFL JANHMKNOIIH) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2B36DE0", Offset = "0x2B361E0", VA = "0x182B36DE0")]
	public static (bool, bool) BPGMKAJCJKC<TArgs>(this COGOHHGNMOO<TArgs> NPLCHPMOCIL, TArgs OPJDDCOPPHE, [Out] string BJEGHKBBNOA) where TArgs : IEquatable<TArgs>
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2B372B0", Offset = "0x2B366B0", VA = "0x182B372B0")]
	[AsyncStateMachine(typeof(AFFEJEKMJHK<>))]
	public static Task<TArgs> ELKGDBONBNJ<TArgs>(this COGOHHGNMOO<TArgs> NPLCHPMOCIL, TArgs OPJDDCOPPHE, CancellationToken MAGIPAHIALD) where TArgs : IEquatable<TArgs>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal class COGOHHGNMOO<TArgs> : IDisposable where TArgs : IEquatable<TArgs>
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate Task<TArgs> EACLPCLALCF(CancellationToken PKJFKCELMGB, CancellationToken EPOCPLEDCBF);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct IIOKHJPNAHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public COGOHHGNMOO<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public FMBKLOOGAFL doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public TimeSpan forceCancelAfter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x375C7A0", Offset = "0x375BBA0", VA = "0x18375C7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x375CA90", Offset = "0x375BE90", VA = "0x18375CA90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct IPNALIDAGEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public COGOHHGNMOO<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public FMBKLOOGAFL doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x376EF60", Offset = "0x376E360", VA = "0x18376EF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x376F1D0", Offset = "0x376E5D0", VA = "0x18376F1D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct KMHIINAEDFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public COGOHHGNMOO<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x39D6400", Offset = "0x39D5800", VA = "0x1839D6400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x39D6980", Offset = "0x39D5D80", VA = "0x1839D6980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct HMNPKPBJNLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public COGOHHGNMOO<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public EACLPCLALCF taskFactory;

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
		[Cpp2IlInjected.Address(RVA = "0x361A480", Offset = "0x3619880", VA = "0x18361A480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x361C010", Offset = "0x361B410", VA = "0x18361C010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct BBJNOIPBPEN : IAsyncStateMachine
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
		public COGOHHGNMOO<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x453FF10", Offset = "0x453F310", VA = "0x18453FF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x30E8DA0", Offset = "0x30E81A0", VA = "0x1830E8DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private bool DEPIKGHNAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private bool MCFCMFEOPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private bool JEMEHNNEGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private CancellationTokenSource EPPMHIDPCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private CancellationTokenSource DCEPBMHNDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly FMBKLOOGAFL GJGIHAJJGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly CancellationToken DIGBFHNOFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly TArgs OPJDDCOPPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private TArgs KANFMCPNFBA;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public TArgs ADHFGEBEBLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x4914620", Offset = "0x4913A20", VA = "0x184914620")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TArgs IFDHGGFCECA
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x49128C0", Offset = "0x4911CC0", VA = "0x1849128C0")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	[CanBeNull]
	public Task<TArgs> HDEHGDNJJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x779420", Offset = "0x778820", VA = "0x180779420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x779410", Offset = "0x778810", VA = "0x180779410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4914750", Offset = "0x4913B50", VA = "0x184914750")]
	public COGOHHGNMOO(TArgs HPCPBKFKMPB, CancellationToken DIGBFHNOFEL, FMBKLOOGAFL GJGIHAJJGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4912780", Offset = "0x4911B80", VA = "0x184912780")]
	[AsyncStateMachine(typeof(COGOHHGNMOO<>.IIOKHJPNAHN))]
	public Task CFLJJEHEAOL(TimeSpan PPGHANADEIC, FMBKLOOGAFL PIPKBGDJHDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4913420", Offset = "0x4912820", VA = "0x184913420")]
	[AsyncStateMachine(typeof(COGOHHGNMOO<>.IPNALIDAGEK))]
	public Task DJNOOFGBDIO(FMBKLOOGAFL PIPKBGDJHDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4913800", Offset = "0x4912C00", VA = "0x184913800", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4913A60", Offset = "0x4912E60", VA = "0x184913A60")]
	[AsyncStateMachine(typeof(COGOHHGNMOO<>.KMHIINAEDFO))]
	private Task FBEIDMLOBFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4913C60", Offset = "0x4913060", VA = "0x184913C60")]
	[AsyncStateMachine(typeof(COGOHHGNMOO<>.HMNPKPBJNLG))]
	public Task<TArgs> FODJOBIPELL(EACLPCLALCF INPPMMGDNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4914100", Offset = "0x4913500", VA = "0x184914100")]
	[AsyncStateMachine(typeof(COGOHHGNMOO<>.BBJNOIPBPEN))]
	private Task<TArgs> JOFAIFGJAPL(Task<TArgs> LBKIFKIPPFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x49144C0", Offset = "0x49138C0", VA = "0x1849144C0")]
	public bool LCEFLGOBGPG(TArgs FBHMKPFPPFA, [Out] string BJEGHKBBNOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4912CD0", Offset = "0x49120D0", VA = "0x184912CD0")]
	private bool DJLFIJDELFN(TArgs FBHMKPFPPFA, [Out] string BJEGHKBBNOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4912A30", Offset = "0x4911E30", VA = "0x184912A30")]
	public CancellationTokenRegistration? DGNPFKPHOLO(CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4914630", Offset = "0x4913A30", VA = "0x184914630")]
	[CompilerGenerated]
	private void OLLOPNKLLOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface OABDLKEBIHB
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IGFHGPLPIKG(string NBOJOMFFCIM, string IIFPINDBKEP, FMBKLOOGAFL GJGIHAJJGMJ, [Optional] string OEHODLAGEBJ);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OGHNLCDMDLF(string NBOJOMFFCIM, string IIFPINDBKEP, FMBKLOOGAFL GJGIHAJJGMJ, [Optional] string OEHODLAGEBJ);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ADAPIDBPMLA(string NBOJOMFFCIM, string IIFPINDBKEP, FMBKLOOGAFL GJGIHAJJGMJ, [Optional] string OEHODLAGEBJ);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CICAKDAOHHI(string NBOJOMFFCIM, string IIFPINDBKEP, FMBKLOOGAFL GJGIHAJJGMJ, Exception LGFOLODPIEE, [Optional] string OEHODLAGEBJ);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MDGAEKJKLGP(string NBOJOMFFCIM, BCHCBLJOICK ONAOAKDIJMF);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal static class OEFNONBMPEG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct FIMOOEIJAEI<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public OABDLKEBIHB analytics;

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
		public FMBKLOOGAFL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x34717F0", Offset = "0x3470BF0", VA = "0x1834717F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x30E8DA0", Offset = "0x30E81A0", VA = "0x1830E8DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct KMFCNCHBMOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public OABDLKEBIHB analytics;

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
		public FMBKLOOGAFL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5E727C0", Offset = "0x5E71BC0", VA = "0x185E727C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5E72C80", Offset = "0x5E72080", VA = "0x185E72C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2653AD0", Offset = "0x2652ED0", VA = "0x182653AD0")]
	[AsyncStateMachine(typeof(FIMOOEIJAEI<>))]
	public static Task<T> BPPHAGFDKFC<T>(this Task<T> BPGIJHHDFCF, [CanBeNull] OABDLKEBIHB GIDLIGIPGCJ, string NBOJOMFFCIM, string IIFPINDBKEP, FMBKLOOGAFL GJGIHAJJGMJ, [Optional] string OEHODLAGEBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5E754D0", Offset = "0x5E748D0", VA = "0x185E754D0")]
	[AsyncStateMachine(typeof(KMFCNCHBMOA))]
	public static Task BPPHAGFDKFC(this Task BPGIJHHDFCF, [CanBeNull] OABDLKEBIHB GIDLIGIPGCJ, string NBOJOMFFCIM, string IIFPINDBKEP, FMBKLOOGAFL GJGIHAJJGMJ, [Optional] string OEHODLAGEBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public delegate Task BELOBGAHJDM();
[Cpp2IlInjected.Token(Token = "0x200004E")]
public delegate Task KHELFPNOEKF(AMEEIBMCCBH ONHEFMLKKKI);
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class GAOCOBKMEFC : CMJPDOILBCJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly MDNFCDJDIDI PPDGEJEANNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly Func<GAOCOBKMEFC, bool> EFJFOJKLKIH;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public MAAEKIPMOMF LAIHEFIFEBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D590", Offset = "0x5E6C990", VA = "0x185E6D590", Slot = "4")]
		get
		{
			return default(MAAEKIPMOMF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public GFBCPABFLGJ CANKMGCMFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D790", Offset = "0x5E6CB90", VA = "0x185E6D790", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool APHFIAIJBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D8E0", Offset = "0x5E6CCE0", VA = "0x185E6D8E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool KMPFJLHJGKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D770", Offset = "0x5E6CB70", VA = "0x185E6D770", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool OACKAJBPJMG
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D680", Offset = "0x5E6CA80", VA = "0x185E6D680", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Exception GGFNKMCIBAM
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D6A0", Offset = "0x5E6CAA0", VA = "0x185E6D6A0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public StatusCode HAPDIPEBMMB
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D860", Offset = "0x5E6CC60", VA = "0x185E6D860", Slot = "16")]
		get
		{
			return default(StatusCode);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event MDNFCDJDIDI.DKDJOGCMKIA EMAEBILDOIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D8C0", Offset = "0x5E6CCC0", VA = "0x185E6D8C0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D5D0", Offset = "0x5E6C9D0", VA = "0x185E6D5D0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<MAAEKIPMOMF, MAAEKIPMOMF> JMDFCEINMGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D6C0", Offset = "0x5E6CAC0", VA = "0x185E6D6C0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D7B0", Offset = "0x5E6CBB0", VA = "0x185E6D7B0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D900", Offset = "0x5E6CD00", VA = "0x185E6D900")]
	public GAOCOBKMEFC(MDNFCDJDIDI PPDGEJEANNA, [Optional] Func<GAOCOBKMEFC, bool> EFJFOJKLKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D5F0", Offset = "0x5E6C9F0", VA = "0x185E6D5F0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D880", Offset = "0x5E6CC80", VA = "0x185E6D880")]
	private void MIKIPPPLBOP(MAAEKIPMOMF JGHOLNPLABJ, MAAEKIPMOMF HBFICDCNBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D5B0", Offset = "0x5E6C9B0", VA = "0x185E6D5B0", Slot = "13")]
	public void BCIGOPOPIEO(object OPJDDCOPPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D8A0", Offset = "0x5E6CCA0", VA = "0x185E6D8A0", Slot = "14")]
	public void OAHFFJMIOAO(object OPJDDCOPPHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class HLKPMMGADGN : NNOIIBODMMD, AKGKFDBFHCF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class JOIGADADLPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public BFMJCHANHOA targetRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public JOIGADADLPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5E726F0", Offset = "0x5E71AF0", VA = "0x185E726F0")]
		internal bool LLLNABCBCLP(DDIBIGFOLFO c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class NEBNBGDFHAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public NEBNBGDFHAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5E75370", Offset = "0x5E74770", VA = "0x185E75370")]
		internal Task JGOBKMCCMDI(DDIBIGFOLFO c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct EOJPJPBDGCF : IAsyncStateMachine
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
		public HLKPMMGADGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CB70", Offset = "0x5E6BF70", VA = "0x185E6CB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CE00", Offset = "0x5E6C200", VA = "0x185E6CE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct HJJHPAOFDNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public AsyncTaskMethodBuilder<BFMJCHANHOA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public HLKPMMGADGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public BFMJCHANHOA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private BFMJCHANHOA <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter<BFMJCHANHOA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x5E70700", Offset = "0x5E6FB00", VA = "0x185E70700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x5E70BE0", Offset = "0x5E6FFE0", VA = "0x185E70BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class ADIHMGNFOLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public ADIHMGNFOLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x5E67A80", Offset = "0x5E66E80", VA = "0x185E67A80")]
		internal Task DAGLLCOCFNC(DDIBIGFOLFO c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct DCANACJHNBG : IAsyncStateMachine
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
		public HLKPMMGADGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5E69EB0", Offset = "0x5E692B0", VA = "0x185E69EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A140", Offset = "0x5E69540", VA = "0x185E6A140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public readonly HCFIJNGAIKH CMINNHFOLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public readonly HJKIEMMEOOP DEACIKAICAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly DDIBIGFOLFO[] GCBBLDNIGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public readonly MGEOIIKGPEI PHHFABLBGNH;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public BFMJCHANHOA MHFOPFGCPAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5E71500", Offset = "0x5E70900", VA = "0x185E71500", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string JBHCEKANEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5E717F0", Offset = "0x5E70BF0", VA = "0x185E717F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private IEnumerable<DDIBIGFOLFO> BJAEKNHHGDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5E71840", Offset = "0x5E70C40", VA = "0x185E71840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private MNNDKCCBBEO APKJECBHDKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Task IINENCGHIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5E717A0", Offset = "0x5E70BA0", VA = "0x185E717A0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5E71420", Offset = "0x5E70820", VA = "0x185E71420", Slot = "7")]
	public bool CEHFKNIEPII(BFMJCHANHOA OBMCAKJAMCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5E71CE0", Offset = "0x5E710E0", VA = "0x185E71CE0")]
	[UnityEngine.Scripting.Preserve]
	public HLKPMMGADGN([MJHHGJKKIMK(null)] HCFIJNGAIKH HPKDHFNNJLO, [MJHHGJKKIMK(null)] HJKIEMMEOOP MBBFKDPCJMN, [MJHHGJKKIMK(null)] MGEOIIKGPEI GIBKCNCMLLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5E71880", Offset = "0x5E70C80", VA = "0x185E71880", Slot = "8")]
	[AsyncStateMachine(typeof(EOJPJPBDGCF))]
	public Task KKINBLMALBK([Optional] CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5E71970", Offset = "0x5E70D70", VA = "0x185E71970", Slot = "9")]
	[AsyncStateMachine(typeof(HJJHPAOFDNH))]
	public Task<BFMJCHANHOA> LOPFAPEFLFB(BFMJCHANHOA OBMCAKJAMCD, object ILANCELDAHJ, [Optional] CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5E71BF0", Offset = "0x5E70FF0", VA = "0x185E71BF0", Slot = "10")]
	[AsyncStateMachine(typeof(DCANACJHNBG))]
	public Task PNLFHFPFNDO([Optional] CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5E71550", Offset = "0x5E70950", VA = "0x185E71550", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5E71AD0", Offset = "0x5E70ED0", VA = "0x185E71AD0", Slot = "11")]
	public void MICKLOPCCJL(KHELFPNOEKF CKKLMBNDAMN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct AEPNGCJHCBN : IEquatable<AEPNGCJHCBN>
{
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public static readonly AEPNGCJHCBN LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x78C310", Offset = "0x78B710", VA = "0x18078C310", Slot = "4")]
	public bool Equals(AEPNGCJHCBN LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5E67AE0", Offset = "0x5E66EE0", VA = "0x185E67AE0", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x772DC0", Offset = "0x7721C0", VA = "0x180772DC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class IJEOMMBPOGM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CB10", Offset = "0x5E6BF10", VA = "0x185E6CB10")]
	public IJEOMMBPOGM(string KCFFPPIEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5E71E80", Offset = "0x5E71280", VA = "0x185E71E80")]
	public IJEOMMBPOGM(string KCFFPPIEBHH, Exception FEFDOAEBKHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class EEGHIDPDPEP : IJEOMMBPOGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public readonly string NCPBECAGMPA;

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C9E0", Offset = "0x5E6BDE0", VA = "0x185E6C9E0")]
	public EEGHIDPDPEP(string IJNCDDAAILN, [NotNull] Exception FEFDOAEBKHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class GACDEAGBONN : IJEOMMBPOGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public readonly BFMJCHANHOA LGAHFFCEPJM;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D470", Offset = "0x5E6C870", VA = "0x185E6D470")]
	public GACDEAGBONN(BFMJCHANHOA FEDDHHBNPCG, [NotNull] Exception FEFDOAEBKHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class KBJBKFCKJFE : IJEOMMBPOGM
{
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CB10", Offset = "0x5E6BF10", VA = "0x185E6CB10")]
	public KBJBKFCKJFE(string KCFFPPIEBHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class BCHCBLJOICK : IJEOMMBPOGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public readonly StatusCode? HAPDIPEBMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public readonly AMEEIBMCCBH MBDNFBKFIMH;

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x5E69580", Offset = "0x5E68980", VA = "0x185E69580")]
	public BCHCBLJOICK(AMEEIBMCCBH ONHEFMLKKKI, Exception FEFDOAEBKHB, StatusCode? ECOFJMDAJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5E692E0", Offset = "0x5E686E0", VA = "0x185E692E0")]
	public static BCHCBLJOICK ILKJECEJMKF(AMEEIBMCCBH JFJLOHCPMLO, CMJPDOILBCJ BMAPHLJJGMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class ENLAIHIIEGC : IJEOMMBPOGM
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CB10", Offset = "0x5E6BF10", VA = "0x185E6CB10")]
	public ENLAIHIIEGC(string KCFFPPIEBHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class CIAILAMGOEP : IJEOMMBPOGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public readonly short ALDFCLBILLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public readonly string AJDJMPGMEBI;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5E69CF0", Offset = "0x5E690F0", VA = "0x185E69CF0")]
	public CIAILAMGOEP(short FIBEPNMHCEG, string DKOHBAKOMAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class DJGGBDPFFAI : IJEOMMBPOGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public readonly short ALDFCLBILLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public readonly string AJDJMPGMEBI;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A740", Offset = "0x5E69B40", VA = "0x185E6A740")]
	public DJGGBDPFFAI(short FIBEPNMHCEG, string DKOHBAKOMAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class ILFJJBAKIPA : IJEOMMBPOGM
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CB10", Offset = "0x5E6BF10", VA = "0x185E6CB10")]
	public ILFJJBAKIPA(string KCFFPPIEBHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class NGBJBAIACDC : IJEOMMBPOGM
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5E753D0", Offset = "0x5E747D0", VA = "0x185E753D0")]
	public NGBJBAIACDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class FDMAPAJDLAP : EDEGECFPELD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public readonly Dictionary<string, string> JPACEHPLPLC;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CE60", Offset = "0x5E6C260", VA = "0x185E6CE60")]
	public FDMAPAJDLAP(TimeSpan GBELJBLENFG, string KCFFPPIEBHH, Dictionary<string, string> OEHODLAGEBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class OEGHPKANBGP : GFBOBHOGHMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly CFBCANLCDFG<AMEEIBMCCBH> MLGEOHBOBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private readonly CFBCANLCDFG<AMEEIBMCCBH> BJJFMLOBKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private readonly CFBCANLCDFG<AMEEIBMCCBH> MPPGFMLDOMJ;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<AMEEIBMCCBH> JKADDNNKAHI
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x5E756B0", Offset = "0x5E74AB0", VA = "0x185E756B0")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5E75930", Offset = "0x5E74D30", VA = "0x185E75930")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action<AMEEIBMCCBH> MEJBNIMAABM
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5E757D0", Offset = "0x5E74BD0", VA = "0x185E757D0")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5E75650", Offset = "0x5E74A50", VA = "0x185E75650")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<AMEEIBMCCBH> ALHOGJIIMPN
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x5E75770", Offset = "0x5E74B70", VA = "0x185E75770")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5E75710", Offset = "0x5E74B10", VA = "0x185E75710")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5E75830", Offset = "0x5E74C30", VA = "0x185E75830", Slot = "31")]
	public override void OnDisconnected(AMEEIBMCCBH ONHEFMLKKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5E75990", Offset = "0x5E74D90", VA = "0x185E75990")]
	public OEGHPKANBGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class HCFIJNGAIKH : ICKGPIOEHOD<KMODIKDNDMK>, MNNDKCCBBEO, DDIBIGFOLFO, AKGKFDBFHCF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct GODCJFLHJEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public HCFIJNGAIKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private CancellationToken <token>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5E6E8A0", Offset = "0x5E6DCA0", VA = "0x185E6E8A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7F66B0", Offset = "0x7F5AB0", VA = "0x1807F66B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class HEFCDLFOFEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public HCFIJNGAIKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public FMBKLOOGAFL actionContext;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public HEFCDLFOFEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5E70280", Offset = "0x5E6F680", VA = "0x185E70280")]
		internal void EIFMINBCLKM(PIHHFPKOALH<string> timer, GBIKKFKHKKF log)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct EBDNJFKLMDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public AsyncTaskMethodBuilder<IReadOnlyDictionary<string, int>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public HCFIJNGAIKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private HEFCDLFOFEN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public TimeSpan? timeoutSpan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private PIHHFPKOALH<string> <pingStackTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private PIHHFPKOALH<string>.NABJKOHEGKG <pingTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private Stopwatch <sw>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private Dictionary<string, int> <regionPings>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private TaskAwaiter<IPGEKALJHDB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private PIHHFPKOALH<string>.NABJKOHEGKG <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private YieldAwaitable.YieldAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A830", Offset = "0x5E69C30", VA = "0x185E6A830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C970", Offset = "0x5E6BD70", VA = "0x185E6C970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private static readonly GBIKKFKHKKF BLHBFCHIDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private CancellationTokenSource ILIKGFLOEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private CancellationTokenSource GNEONIMLNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private CancellationToken NFBJABEEFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private bool EIHNAJDAFEN;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool CNDKIOPLMHO
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x93DE50", Offset = "0x93D250", VA = "0x18093DE50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x5E6ED30", Offset = "0x5E6E130", VA = "0x185E6ED30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EEB0", Offset = "0x5E6E2B0", VA = "0x185E6EEB0", Slot = "13")]
	public override bool CEHFKNIEPII(BFMJCHANHOA OBMCAKJAMCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F580", Offset = "0x5E6E980", VA = "0x185E6F580")]
	[UnityEngine.Scripting.Preserve]
	public HCFIJNGAIKH([MJHHGJKKIMK(null)] KMODIKDNDMK HHIFKNOOMJO, [MJHHGJKKIMK(null)] DJFGNEJLECF BAIKLPPEPEE, [MJHHGJKKIMK(null)] OABDLKEBIHB GIDLIGIPGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F490", Offset = "0x5E6E890", VA = "0x185E6F490")]
	internal HCFIJNGAIKH(KMODIKDNDMK HHIFKNOOMJO, DJFGNEJLECF BAIKLPPEPEE, OABDLKEBIHB GIDLIGIPGCJ, IMOIMFPGIOM LBOFEFMDOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F070", Offset = "0x5E6E470", VA = "0x185E6F070", Slot = "17")]
	protected override void GDPAAGOGDPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EE00", Offset = "0x5E6E200", VA = "0x185E6EE00")]
	private void BHNCKOECCPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EF10", Offset = "0x5E6E310", VA = "0x185E6EF10", Slot = "16")]
	protected override void CODPPFBBBDI(BFMJCHANHOA KFMCHODINGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F0C0", Offset = "0x5E6E4C0", VA = "0x185E6F0C0", Slot = "14")]
	protected override void HNPBKJBDBIF(FMBKLOOGAFL GJGIHAJJGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F1C0", Offset = "0x5E6E5C0", VA = "0x185E6F1C0", Slot = "15")]
	protected override void KHNJCADCCHB(FMBKLOOGAFL GJGIHAJJGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F370", Offset = "0x5E6E770", VA = "0x185E6F370")]
	[AsyncStateMachine(typeof(GODCJFLHJEA))]
	private void OBJFPDJOEEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F240", Offset = "0x5E6E640", VA = "0x185E6F240", Slot = "18")]
	[AsyncStateMachine(typeof(EBDNJFKLMDP))]
	public Task<IReadOnlyDictionary<string, int>> KICONNKHJCA([Optional] TimeSpan? DKKLOLCIGJB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class BFMJCHANHOA : IPGEKALJHDB, IEquatable<BFMJCHANHOA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public readonly string ECJKOGOKPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly string? JCKMIEJIFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public readonly string? FJNLFMLPLCN;

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x5E69A20", Offset = "0x5E68E20", VA = "0x185E69A20")]
	public BFMJCHANHOA(string CEPHOGAGKIC, string LPCIBCGBNBO, string JKILCCIFHFD, string? GAKCEOKLBKC, string KNJGGINFEIF, string FHFJJKMLAMJ, string? JJMBEPGPJAC, string? ODEGDMONDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5E699C0", Offset = "0x5E68DC0", VA = "0x185E699C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5E69800", Offset = "0x5E68C00", VA = "0x185E69800", Slot = "5")]
	public bool Equals(BFMJCHANHOA? LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5E696E0", Offset = "0x5E68AE0", VA = "0x185E696E0", Slot = "0")]
	public override bool Equals(object? ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5E69880", Offset = "0x5E68C80", VA = "0x185E69880", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x82CE10", Offset = "0x82C210", VA = "0x18082CE10")]
	public static bool FCHDBNDMOOD(BFMJCHANHOA? OJKFAPKLEMA, BFMJCHANHOA? BBHLJNIGCPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x82D2A0", Offset = "0x82C6A0", VA = "0x18082D2A0")]
	public static bool HAGCGOPJDDN(BFMJCHANHOA? OJKFAPKLEMA, BFMJCHANHOA? BBHLJNIGCPB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class IPGEKALJHDB : IEquatable<IPGEKALJHDB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public readonly string OLACBICADIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public readonly string? NCBJHCEKIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public readonly string? IOKOCAELBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public readonly string? DAHHGKDKFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public readonly string GHBHHBKPFJE;

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E721B0", Offset = "0x5E715B0", VA = "0x185E721B0")]
	public IPGEKALJHDB(string CEPHOGAGKIC, string? LPCIBCGBNBO, string? JKILCCIFHFD, string? GAKCEOKLBKC, string KNJGGINFEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E72150", Offset = "0x5E71550", VA = "0x185E72150", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x5E71FD0", Offset = "0x5E713D0", VA = "0x185E71FD0", Slot = "4")]
	public bool Equals(IPGEKALJHDB? LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5E71EF0", Offset = "0x5E712F0", VA = "0x185E71EF0", Slot = "0")]
	public override bool Equals(object? ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5E72060", Offset = "0x5E71460", VA = "0x185E72060", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class HJKIEMMEOOP : ICKGPIOEHOD<HJKIEMMEOOP.HCOEECDAAFH>
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public interface BCLAKDIGEGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool DCMGKAPEKJD();
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class HCOEECDAAFH : IDDJPGOLDLP, ENPDDPAPFEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private CMJPDOILBCJ FLHPNDMJFKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private bool DKEHIOMDLED;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		private PhotonVoiceNetwork BIOIEDEDOFP
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x5E6F810", Offset = "0x5E6EC10", VA = "0x185E6F810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool JDCAKBHEBFN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xCE4250", Offset = "0xCE3650", VA = "0x180CE4250", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public CMJPDOILBCJ JALJAMAPEDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool KMPFJLHJGKF
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x5E6FB20", Offset = "0x5E6EF20", VA = "0x185E6FB20", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool NPNDHJGALCC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x5E6F670", Offset = "0x5E6EA70", VA = "0x185E6F670", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x773870", Offset = "0x772C70", VA = "0x180773870", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool DIPBIEMOPFB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool APHFIAIJBKD
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x5E70230", Offset = "0x5E6F630", VA = "0x185E70230", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public HJJBCFNINCF BLKNALBEPGD
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x5E6F940", Offset = "0x5E6ED40", VA = "0x185E6F940", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool JCIECFLLIAE
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5E6F700", Offset = "0x5E6EB00", VA = "0x185E6F700", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<CMJPDOILBCJ, CMJPDOILBCJ> DOEIOPGPMLI
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x5E6FDD0", Offset = "0x5E6F1D0", VA = "0x185E6FDD0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x5E6FF80", Offset = "0x5E6F380", VA = "0x185E6FF80", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<bool> NCADHOLNLMC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F870", Offset = "0x5E6EC70", VA = "0x185E6F870", Slot = "9")]
		public void DJNOJIFGGKI(MDNFCDJDIDI MBBFKDPCJMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x5E6FB70", Offset = "0x5E6EF70", VA = "0x185E6FB70", Slot = "16")]
		public bool JLHHAFCKMJE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x5E70030", Offset = "0x5E6F430", VA = "0x185E70030", Slot = "17")]
		public bool PAIFOJKMMAB(string FHFJJKMLAMJ, NJPEOABBCGE IFDLNJBIMFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5E6FE80", Offset = "0x5E6F280", VA = "0x185E6FE80", Slot = "18")]
		public void KKINBLMALBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x5E6FCA0", Offset = "0x5E6F0A0", VA = "0x185E6FCA0", Slot = "19")]
		public bool JOHMFPFECBO(AppSettings AJKMEHBADOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "22")]
		public void FNBHKFKNOJI(object NOEAHPPKHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "23")]
		public void AOPHEPMILLC(object NOEAHPPKHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "24")]
		public void MMEEMEJLJKK(object NOEAHPPKHNC, bool ALGPNNBDODD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x5E701E0", Offset = "0x5E6F5E0", VA = "0x185E701E0", Slot = "25")]
		public IDisposable PGLMLKDHNGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "26")]
		private bool OJOBFMDJAOP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "27")]
		public void CJJPEHJHJNN(StringBuilder IMFMKHONGJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5E6FA20", Offset = "0x5E6EE20", VA = "0x185E6FA20", Slot = "28")]
		public bool EPELGLOHHMM(bool JMDJAHAOEJG, [Out] string HCMLCAPJMPH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public HCOEECDAAFH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct JODHNLHIBKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public HJKIEMMEOOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public HCFIJNGAIKH clientToFollow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private TaskAwaiter<BFMJCHANHOA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5E72380", Offset = "0x5E71780", VA = "0x185E72380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5E72690", Offset = "0x5E71A90", VA = "0x185E72690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct MABKLBHMAIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public HJKIEMMEOOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x5E72CE0", Offset = "0x5E720E0", VA = "0x185E72CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5E73050", Offset = "0x5E72450", VA = "0x185E73050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private readonly HCFIJNGAIKH HPKDHFNNJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private readonly BCLAKDIGEGP FPCEPNMEBBK;

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E70C50", Offset = "0x5E70050", VA = "0x185E70C50", Slot = "13")]
	public override bool CEHFKNIEPII(BFMJCHANHOA OBMCAKJAMCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5E710E0", Offset = "0x5E704E0", VA = "0x185E710E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public HJKIEMMEOOP([MJHHGJKKIMK(null)] HCFIJNGAIKH HPKDHFNNJLO, [MJHHGJKKIMK(null)] DJFGNEJLECF BAIKLPPEPEE, [MJHHGJKKIMK(null)] BCLAKDIGEGP FPCEPNMEBBK, [MJHHGJKKIMK(null)] OABDLKEBIHB GIDLIGIPGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E70F20", Offset = "0x5E70320", VA = "0x185E70F20")]
	private Task LCAIDEBEIND(AMEEIBMCCBH ONHEFMLKKKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E70E30", Offset = "0x5E70230", VA = "0x185E70E30")]
	[AsyncStateMachine(typeof(JODHNLHIBKG))]
	public Task JEABKJNPDKG(HCFIJNGAIKH MAGBPCKIGEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E70DB0", Offset = "0x5E701B0", VA = "0x185E70DB0")]
	[CompilerGenerated]
	internal static void FDHINKKHPPP(CMJPDOILBCJ KKODDNECDAG, CMJPDOILBCJ APLOOGCGDFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E70CE0", Offset = "0x5E700E0", VA = "0x185E70CE0")]
	[AsyncStateMachine(typeof(MABKLBHMAIH))]
	[CompilerGenerated]
	private Task DOBMOJEHACB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[UnityEngine.Scripting.Preserve]
public class PELCMEPFCJE
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	[JsonProperty(PropertyName = "AI", Required = Required.Always)]
	[UnityEngine.Scripting.Preserve]
	public string AccountId
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x773880", Offset = "0x772C80", VA = "0x180773880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	[UnityEngine.Scripting.Preserve]
	[JsonProperty(PropertyName = "AT", Required = Required.Always)]
	public byte[] AccessToken
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x773840", Offset = "0x772C40", VA = "0x180773840")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[JsonProperty(PropertyName = "VB", Required = Required.Always)]
	[UnityEngine.Scripting.Preserve]
	public byte[] VerificationBlob
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x775A80", Offset = "0x774E80", VA = "0x180775A80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x775420", Offset = "0x774820", VA = "0x180775420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[JsonProperty(PropertyName = "CKA", Required = Required.Always)]
	[UnityEngine.Scripting.Preserve]
	public byte[] ClientKeyA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x773860", Offset = "0x772C60", VA = "0x180773860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x775A50", Offset = "0x774E50", VA = "0x180775A50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[UnityEngine.Scripting.Preserve]
	[JsonProperty(PropertyName = "CIA", Required = Required.Always)]
	public byte[] ClientIVA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x773AC0", Offset = "0x772EC0", VA = "0x180773AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x77A180", Offset = "0x779580", VA = "0x18077A180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	[UnityEngine.Scripting.Preserve]
	[JsonProperty(PropertyName = "CPK", Required = Required.Always)]
	public byte[] ClientPublicKey
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x773AA0", Offset = "0x772EA0", VA = "0x180773AA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x773890", Offset = "0x772C90", VA = "0x180773890")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public PELCMEPFCJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[UnityEngine.Scripting.Preserve]
public class HCNANLEFKFD
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	[JsonProperty(PropertyName = "DR", Required = Required.Always)]
	[UnityEngine.Scripting.Preserve]
	public string Reason
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x773880", Offset = "0x772C80", VA = "0x180773880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[JsonProperty(PropertyName = "KT", Required = Required.Default)]
	[UnityEngine.Scripting.Preserve]
	public byte[] SessionKeyB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x773840", Offset = "0x772C40", VA = "0x180773840")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public HCNANLEFKFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class MGEOIIKGPEI : DDIBIGFOLFO, AKGKFDBFHCF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public enum OAIPOCMCGCK
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
	private NetworkManager LHHODACHEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private TaskCompletionSource<BFMJCHANHOA> KAFANJGDDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	protected readonly DJFGNEJLECF OCHPNDAFIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private readonly HashSet<KHELFPNOEKF> CKODDGKNPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public OAIPOCMCGCK DLGBKKLFJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private BFMJCHANHOA OBMCAKJAMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private RSACryptoServiceProvider ABGIBHLILNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private RSACryptoServiceProvider FPAMOFECPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private AesCryptoServiceProvider PIMFPNHMFGC;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public BFMJCHANHOA MHFOPFGCPAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x773AA0", Offset = "0x772EA0", VA = "0x180773AA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public string JBHCEKANEDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E73CC0", Offset = "0x5E730C0", VA = "0x185E73CC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Task IINENCGHIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5E733C0", Offset = "0x5E727C0", VA = "0x185E733C0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5E74B40", Offset = "0x5E73F40", VA = "0x185E74B40", Slot = "10")]
	public void MICKLOPCCJL(KHELFPNOEKF CKKLMBNDAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E73130", Offset = "0x5E72530", VA = "0x185E73130", Slot = "6")]
	public bool CEHFKNIEPII(BFMJCHANHOA OBMCAKJAMCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E75190", Offset = "0x5E74590", VA = "0x185E75190")]
	[UnityEngine.Scripting.Preserve]
	public MGEOIIKGPEI([MJHHGJKKIMK(null)] DJFGNEJLECF LJNDGGMFHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E73170", Offset = "0x5E72570", VA = "0x185E73170")]
	private void EHMGHBPDLHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E74D00", Offset = "0x5E74100", VA = "0x185E74D00")]
	private void PLMPCCANBOG(ulong ECLCDMJMICA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E73410", Offset = "0x5E72810", VA = "0x185E73410")]
	private void HEJJICFCOPG(ulong ECLCDMJMICA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5E74BA0", Offset = "0x5E73FA0", VA = "0x185E74BA0")]
	private void NANCEAEBLPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5E74C90", Offset = "0x5E74090", VA = "0x185E74C90")]
	private void NCPEBADEDCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E739D0", Offset = "0x5E72DD0", VA = "0x185E739D0")]
	private void HKFPEAIBLAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E73B50", Offset = "0x5E72F50", VA = "0x185E73B50")]
	private void INPCFDLNNJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E74560", Offset = "0x5E73960", VA = "0x185E74560")]
	private static (IPAddress, ushort) LJOPMAIJNLD(string FELINOOLPKJ)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5E73E50", Offset = "0x5E73250", VA = "0x185E73E50")]
	private void LFMNFBDDDAM(BFMJCHANHOA PNMGJEFKPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5E74690", Offset = "0x5E73A90", VA = "0x185E74690", Slot = "8")]
	public Task<BFMJCHANHOA> LOPFAPEFLFB(BFMJCHANHOA OBMCAKJAMCD, object ILANCELDAHJ, [Optional] CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5E73CF0", Offset = "0x5E730F0", VA = "0x185E73CF0", Slot = "7")]
	public Task KKINBLMALBK([Optional] CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5E75030", Offset = "0x5E74430", VA = "0x185E75030", Slot = "9")]
	public Task PNLFHFPFNDO([Optional] CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class CIMNLOOFNLC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E69DE0", Offset = "0x5E691E0", VA = "0x185E69DE0")]
	public CIMNLOOFNLC(string KCFFPPIEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E69E40", Offset = "0x5E69240", VA = "0x185E69E40")]
	public CIMNLOOFNLC(string KCFFPPIEBHH, Exception FEFDOAEBKHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class BKLIMFEBEHF : CIMNLOOFNLC
{
	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5E69C10", Offset = "0x5E69010", VA = "0x185E69C10")]
	public BKLIMFEBEHF([NotNull] Exception FEFDOAEBKHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class JDOGMLFCMEK : CIMNLOOFNLC
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E72300", Offset = "0x5E71700", VA = "0x185E72300")]
	public JDOGMLFCMEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class MGADBFALHOJ : CIMNLOOFNLC
{
	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E730B0", Offset = "0x5E724B0", VA = "0x185E730B0")]
	public MGADBFALHOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public static class DEDGCJDJCME
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private static AesCryptoServiceProvider EBJPAPOHJEJ;

	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private static readonly string[] LINFBFHNMBD;

	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private static readonly string[] KBDCEPNPGBD;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private static readonly string[] AOEBEDJDDEH;

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A310", Offset = "0x5E69710", VA = "0x185E6A310")]
	public static string KDPMHNILLPM(ulong BANBPKAHABN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A1A0", Offset = "0x5E695A0", VA = "0x185E6A1A0")]
	public static string ICNFNDAGIHB(ulong BANBPKAHABN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A210", Offset = "0x5E69610", VA = "0x185E6A210")]
	public static AesCryptoServiceProvider IPKANONCKDI()
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

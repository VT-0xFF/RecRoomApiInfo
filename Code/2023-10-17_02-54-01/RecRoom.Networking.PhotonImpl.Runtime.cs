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
		[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D3AD30", Offset = "0x5D39530", VA = "0x185D3AD30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78D440", Offset = "0x78BC40", VA = "0x18078D440")]
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
		[Cpp2IlInjected.Address(RVA = "0x78D480", Offset = "0x78BC80", VA = "0x18078D480")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DMACKHGFLCE : BDEJIENONBD, MMGCDLGMEDF, BLONKEEDDKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class NENADJMBDKE : NDOKGPDDKPK
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class LMLACBNCDLL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Action onCompleteCallback;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public LMLACBNCDLL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x559FD40", Offset = "0x559E540", VA = "0x18559FD40")]
			internal void GCCHIKCOOJK(KIKDGIIACCL rh)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool ELPIDDFMIAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5D3ABD0", Offset = "0x5D393D0", VA = "0x185D3ABD0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool CGLEDMCCDPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5D3AAC0", Offset = "0x5D392C0", VA = "0x185D3AAC0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public IReadOnlyList<LPKCMADNJHA> CGLLCDMGDPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5D3A9B0", Offset = "0x5D391B0", VA = "0x185D3A9B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A890", Offset = "0x5D39090", VA = "0x185D3A890", Slot = "7")]
		public bool BPJGOGMACOH(Action GNGPONJIDAG, string ENJNNGLDCFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public NENADJMBDKE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NCPEHMNDMGE EGPAGAAEGAN;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly byte[] OKOLAJFDLAD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override bool AKDPNBPLAKO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4EC8DC0", Offset = "0x4EC75C0", VA = "0x184EC8DC0", Slot = "80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override NCPEHMNDMGE OMFBJGACMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x761C30", Offset = "0x760430", VA = "0x180761C30", Slot = "81")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override bool NDFLLOOKAHC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D31620", Offset = "0x5D2FE20", VA = "0x185D31620", Slot = "82")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override bool GMLOIJNEKFL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5D31590", Offset = "0x5D2FD90", VA = "0x185D31590", Slot = "60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5D32560", Offset = "0x5D30D60", VA = "0x185D32560", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override float GFBDDBBGHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5D31960", Offset = "0x5D30160", VA = "0x185D31960", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override NDOKGPDDKPK BGLJAIBBBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x768CA0", Offset = "0x7674A0", VA = "0x180768CA0", Slot = "77")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override bool CNJFMDCFCGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5D328E0", Offset = "0x5D310E0", VA = "0x185D328E0", Slot = "83")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5D31D70", Offset = "0x5D30570", VA = "0x185D31D70", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override bool AFAPDHIEGLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5D31C10", Offset = "0x5D30410", VA = "0x185D31C10", Slot = "85")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool BBGGDANMMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5D31C60", Offset = "0x5D30460", VA = "0x185D31C60", Slot = "86")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override MCINOFGOPIN JMJAPBGMLJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5D31DC0", Offset = "0x5D305C0", VA = "0x185D31DC0", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool BBFKFKAPNMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5D323F0", Offset = "0x5D30BF0", VA = "0x185D323F0", Slot = "76")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override int DLEKDMLNNBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5D32120", Offset = "0x5D30920", VA = "0x185D32120", Slot = "63")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override int PCPMKFPEHLO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5D32380", Offset = "0x5D30B80", VA = "0x185D32380", Slot = "64")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override JLNLBCDKCMG BPCDKOHENOB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5D328A0", Offset = "0x5D310A0", VA = "0x185D328A0", Slot = "65")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public override int EHGDIPGJGLB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5D31660", Offset = "0x5D2FE60", VA = "0x185D31660", Slot = "66")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public override int HKAMFIAMFBK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5D31E30", Offset = "0x5D30630", VA = "0x185D31E30", Slot = "67")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public override event MOCIEJGKFFB HIJOCHCOMMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5D31EA0", Offset = "0x5D306A0", VA = "0x185D31EA0", Slot = "56")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D32190", Offset = "0x5D30990", VA = "0x185D32190", Slot = "57")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public override event Action<JLNLBCDKCMG> CPJNHBENIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5D31F40", Offset = "0x5D30740", VA = "0x185D31F40", Slot = "58")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5D319B0", Offset = "0x5D301B0", VA = "0x185D319B0", Slot = "59")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public override event Action<NCPEHMNDMGE, NCPEHMNDMGE> KEPFIDIOCBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5D324B0", Offset = "0x5D30CB0", VA = "0x185D324B0", Slot = "78")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5D32070", Offset = "0x5D30870", VA = "0x185D32070", Slot = "79")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5D32970", Offset = "0x5D31170", VA = "0x185D32970", Slot = "90")]
	public override void PNIOAFLHPKJ(NCNPIPEEFLG GKGPAAMEJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5D327A0", Offset = "0x5D30FA0", VA = "0x185D327A0")]
	[NJKKEFDLCAD(AFMDLPKJFNK.GameOnly)]
	private static void PFJBINLDPOI(LLKIHBKOOLA OKPDFALIJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5D32AB0", Offset = "0x5D312B0", VA = "0x185D32AB0")]
	[Preserve]
	public DMACKHGFLCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D31A60", Offset = "0x5D30260", VA = "0x185D31A60")]
	private void DPBHGDFPPED(bool AODCEFMOKFB, bool CMGADKMNLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5D32660", Offset = "0x5D30E60", VA = "0x185D32660", Slot = "68")]
	[CanBeNull]
	public override JLNLBCDKCMG OILMLGEMGCE(int MHCLCCCFPCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5D325B0", Offset = "0x5D30DB0", VA = "0x185D325B0")]
	private static short OALGMMDLKAH(StreamBuffer AKIOOFDBMOM, object JOJKDJKCGNC)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5D317C0", Offset = "0x5D2FFC0", VA = "0x185D317C0")]
	private static object CDIOIKPCFGM(StreamBuffer JGOGJJOPCJM, short HPFMIMMLOKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5D31AE0", Offset = "0x5D302E0", VA = "0x185D31AE0", Slot = "100")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5D31D20", Offset = "0x5D30520", VA = "0x185D31D20", Slot = "69")]
	public override bool FECOBPHGMGJ(AppSettings PLMDHCPMLFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D31CE0", Offset = "0x5D304E0", VA = "0x185D31CE0", Slot = "70")]
	public override void ELIKLHPLONE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D32230", Offset = "0x5D30A30", VA = "0x185D32230", Slot = "71")]
	public override bool KPLPHLIGDMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D31CA0", Offset = "0x5D304A0", VA = "0x185D31CA0", Slot = "72")]
	public override void EHADPMMJPLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D31FF0", Offset = "0x5D307F0", VA = "0x185D31FF0", Slot = "73")]
	public override bool IJEDOMOCHEH(byte DFBOOPBNIGI, Hashtable BBDAIOEBCKN, ACADAJIBIJM OONIKFINHEG, SendOptions GBEFIOLAGPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5D32440", Offset = "0x5D30C40", VA = "0x185D32440", Slot = "88")]
	public override bool LNCHDKAILIL(string IEKFPPBBHHC, FAOJMAKOAPP LIBEOECBKPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5D316C0", Offset = "0x5D2FEC0", VA = "0x185D316C0", Slot = "89")]
	public override void CAHFKMGDONN(string MKKJLFIBOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5D32720", Offset = "0x5D30F20", VA = "0x185D32720", Slot = "93")]
	public void OnEvent(EventData FBIOHGBKANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "94")]
	public void OnPlayerEnteredRoom(FEAMONLCDHI FLJMIBLOJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "95")]
	public void OnPlayerWillLeaveRoom(FEAMONLCDHI BNCODFCOBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "96")]
	public void OnPlayerLeftRoom(FEAMONLCDHI BNCODFCOBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "97")]
	public void OnRoomPropertiesUpdate(Hashtable NCILEKMDKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "98")]
	public void OnPlayerPropertiesUpdate(FEAMONLCDHI FEJEOGLPBBC, Hashtable GLPLKAAOCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5D31E10", Offset = "0x5D30610", VA = "0x185D31E10", Slot = "99")]
	private void GKIHDPMHFGF(FEAMONLCDHI GBMBBFIICBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface PDDNIKFHLIC : CGHNPOGGIOM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CGHNPOGGIOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	ENGKFENENDE BKAELLFMGNE
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string OJDJBJBDPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Task BFEBILADLEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JPKMJKCCEMO(ENGKFENENDE BKLIDCPKLEM);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task ELIKLHPLONE([Optional] CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<ENGKFENENDE> CHDNBFLEOJK(ENGKFENENDE BKLIDCPKLEM, object LLNAJFDAEHL, [Optional] CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task NINEIKMEAAE([Optional] CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BGDGBNGCKDD(CMMNHJHICGF MPPKBKKNPFE);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface MHOHFOIHKFE
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HHOKLMEAHFC(ushort GHDJMDLGPPF, GGEHNFPMHFG KGDAOEAHMPJ, params object[] PGCJMEJGFHF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal enum GGEHNFPMHFG
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
public interface HEEPHCNKAAB : CGHNPOGGIOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	KHDBONJHAAE DPMIDGHPAFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KHDBONJHAAE : PDDNIKFHLIC, CGHNPOGGIOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyDictionary<string, int>> KLEJFNIAAFJ([Optional] TimeSpan? FKGFIGDIAOH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LPPGHONKDIF
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool MGEPJNOKABG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool NOJFCGNIHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	TimeSpan KOCBJEHKFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	TimeSpan OIMHJMLFECK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AppSettings GIKLKAIILFN(BDGMFPCFLOK HOKOONHBJON);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MCINOFGOPIN CLDHCIFIBKI(BDGMFPCFLOK HOKOONHBJON);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<BDGMFPCFLOK> ACAFBIKHLCM(CancellationToken EHCFBFBFEDH);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class DKEDHFJPJBH : BBFBJIGLHIK, BLONKEEDDKO, NBEEGINBIJJ, FKGFGDPDPOC, LMGNPNNGJKE, IPCGGPHOBCC, JDCKCBMHLCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly string OFOCENNNFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public BJPMGBAMGNN LOLGLMDBDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public BJPMGBAMGNN GKDALAIIDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public MBOBMBMLJPH<LADONBJPHPE> HDFGIDGPJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public BJPMGBAMGNN OOFNDMJPCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public MBOBMBMLJPH<string> CEGMKGNNPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public MBOBMBMLJPH<Dictionary<string, object>> HBJAPAGEFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public MBOBMBMLJPH<LADONBJPHPE> DFMLAOEECEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public JEAOGCMOGDE<bool, bool> ODPMIGMGOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public BJPMGBAMGNN OIFHEFEJOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public BJPMGBAMGNN MLEBPMCIAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public BJPMGBAMGNN JEOINLJJCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public BJPMGBAMGNN ADFFNBHJMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public BJPMGBAMGNN EOLKIFCBDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public MBOBMBMLJPH<FEAMONLCDHI> DAICFPOMFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public JEAOGCMOGDE<PhotonView, FEAMONLCDHI> DADBONHJLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public MHLFPCNBIHM<PhotonView, FEAMONLCDHI, FEAMONLCDHI> LLKGHHLMDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public JEAOGCMOGDE<short, string> IFOPKECONKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public MBOBMBMLJPH<Hashtable> ODAFCPFOGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public MBOBMBMLJPH<JCHODIHICIN> GBLJAIDDCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public JEAOGCMOGDE<short, string> JLIAHANEMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public BJPMGBAMGNN EGLPECEPILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public MBOBMBMLJPH<FEAMONLCDHI> OBMPMIIBLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public MBOBMBMLJPH<FEAMONLCDHI> FLMHNFAOOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public JEAOGCMOGDE<FEAMONLCDHI, Hashtable> LBPHBLELGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public JEAOGCMOGDE<short, string> AMLGECBDMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public BJPMGBAMGNN BDLIMBALBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public BJPMGBAMGNN CJPGCJKLOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public MBOBMBMLJPH<OperationResponse> ODCKABKNAEA;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5D30950", Offset = "0x5D2F150", VA = "0x185D30950", Slot = "31")]
	public virtual void OnDisconnected(LADONBJPHPE IKEMELLOGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5CA5E30", Offset = "0x5CA4630", VA = "0x185CA5E30", Slot = "4")]
	public void OnConnected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5D30800", Offset = "0x5D2F000", VA = "0x185D30800", Slot = "5")]
	public void OnConnectedToMaster()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "7")]
	public void OnRegionListReceived(KIKDGIIACCL BMODIEIJGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5D30900", Offset = "0x5D2F100", VA = "0x185D30900", Slot = "8")]
	public void OnCustomAuthenticationResponse(Dictionary<string, object> AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5D308B0", Offset = "0x5D2F0B0", VA = "0x185D308B0", Slot = "9")]
	public void OnCustomAuthenticationFailed(string ABKAFOCDEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5D30B60", Offset = "0x5D2F360", VA = "0x185D30B60", Slot = "10")]
	public void OnPlayerEnteredRoom(FEAMONLCDHI FLJMIBLOJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "11")]
	public void OnPlayerWillLeaveRoom(FEAMONLCDHI BNCODFCOBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5D30BC0", Offset = "0x5D2F3C0", VA = "0x185D30BC0", Slot = "12")]
	public void OnPlayerLeftRoom(FEAMONLCDHI BNCODFCOBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5D30CB0", Offset = "0x5D2F4B0", VA = "0x185D30CB0", Slot = "13")]
	public void OnRoomPropertiesUpdate(Hashtable NCILEKMDKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5D30C20", Offset = "0x5D2F420", VA = "0x185D30C20", Slot = "14")]
	public void OnPlayerPropertiesUpdate(FEAMONLCDHI FEJEOGLPBBC, Hashtable GLPLKAAOCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5D30B00", Offset = "0x5D2F300", VA = "0x185D30B00", Slot = "15")]
	public void OnMasterClientSwitched(FEAMONLCDHI GBMBBFIICBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xAE8B50", Offset = "0xAE7350", VA = "0x180AE8B50", Slot = "16")]
	public void OnJoinedLobby()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xBB9FF0", Offset = "0xBB87F0", VA = "0x180BB9FF0", Slot = "17")]
	public void OnLeftLobby()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5D30C90", Offset = "0x5D2F490", VA = "0x185D30C90", Slot = "18")]
	public void OnRoomListUpdate(List<GDOPMCAIDJJ> BMCONEJDIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D30AE0", Offset = "0x5D2F2E0", VA = "0x185D30AE0", Slot = "19")]
	public void OnLobbyStatisticsUpdate(List<EDKFFCMOHPI> OCGMJCHLMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5D309E0", Offset = "0x5D2F1E0", VA = "0x185D309E0", Slot = "20")]
	public void OnFriendListUpdate(List<KOENPFMFAJJ> MKHJCCNKJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5D30890", Offset = "0x5D2F090", VA = "0x185D30890", Slot = "21")]
	public void OnCreatedRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5D30820", Offset = "0x5D2F020", VA = "0x185D30820", Slot = "22")]
	public void OnCreateRoomFailed(short FACFHMGIDFM, string BKGEBGGPBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xBB0310", Offset = "0xBAEB10", VA = "0x180BB0310", Slot = "23")]
	public void OnJoinedRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5D30A70", Offset = "0x5D2F270", VA = "0x185D30A70", Slot = "24")]
	public void OnJoinRoomFailed(short FACFHMGIDFM, string BKGEBGGPBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5D30A00", Offset = "0x5D2F200", VA = "0x185D30A00", Slot = "25")]
	public void OnJoinRandomFailed(short FACFHMGIDFM, string BKGEBGGPBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xD49F40", Offset = "0xD48740", VA = "0x180D49F40", Slot = "26")]
	public void OnLeftRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5D30720", Offset = "0x5D2EF20", VA = "0x185D30720", Slot = "30")]
	public void GCEACDCFONJ(JCHODIHICIN EEILNADBKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5D30790", Offset = "0x5D2EF90", VA = "0x185D30790", Slot = "27")]
	public void JJADPDKJJCF(PhotonView MCDIDJOCCHO, FEAMONLCDHI KGHDFCJAHGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5D30690", Offset = "0x5D2EE90", VA = "0x185D30690", Slot = "28")]
	public void DKFMHHMJACK(PhotonView MCDIDJOCCHO, FEAMONLCDHI AHCKCPHMFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5D30D10", Offset = "0x5D2F510", VA = "0x185D30D10", Slot = "29")]
	public void OnWebRpcResponse(OperationResponse PMLAHEAPMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5D30D70", Offset = "0x5D2F570", VA = "0x185D30D70")]
	public DKEDHFJPJBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal static class GDHGDBOCBOC
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class HEHBALBMJFL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Action<string, FJLCNICBIII> log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public FJLCNICBIII actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public NCPEHMNDMGE networkClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool region;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public LGKHOIPJHAI photonCallbacks;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public HEHBALBMJFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x356F590", Offset = "0x356DD90", VA = "0x18356F590")]
		internal void IEGEFGJJMAM(LADONBJPHPE disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x356F730", Offset = "0x356DF30", VA = "0x18356F730")]
		internal void NCPHAJEFNBE(string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x356F1B0", Offset = "0x356D9B0", VA = "0x18356F1B0")]
		internal void GGLDNJDCLEB(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class PFLKEFFKDHB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public DKEDHFJPJBH photonCallbacks;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public PFLKEFFKDHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3DA6BE0", Offset = "0x3DA53E0", VA = "0x183DA6BE0")]
		internal void PCBEIPJNNHO(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3DA6800", Offset = "0x3DA5000", VA = "0x183DA6800")]
		internal void HIACLHEIMJI(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3DA69F0", Offset = "0x3DA51F0", VA = "0x183DA69F0")]
		internal void LJLAIMKIFIK(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2360A00", Offset = "0x235F200", VA = "0x182360A00")]
	public static void FMIBGAGIJMD<T>(this LGKHOIPJHAI INDOLFKCPBN, TaskCompletionSource<T> LPGJFJPDIDO, [NotNull] NCPEHMNDMGE OCHJLPKBLJJ, FJLCNICBIII GOGGOGPMKGP, bool CCMHBBLECKK, Action<string, FJLCNICBIII> KFIEDGIKACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2361000", Offset = "0x235F800", VA = "0x182361000")]
	public static void OILDBHOMGIP<T>(this DKEDHFJPJBH INDOLFKCPBN, TaskCompletionSource<T> LPGJFJPDIDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class HAFODBMMIFJ<TNetworking> : PDDNIKFHLIC, CGHNPOGGIOM, IDisposable where TNetworking : class, GDMHDAAKABH, FFJNDGBCJKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class JILOAALPANL
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
			public AsyncTaskMethodBuilder<BDGMFPCFLOK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public JILOAALPANL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private TaskAwaiter<BDGMFPCFLOK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x2E8C700", Offset = "0x2E8AF00", VA = "0x182E8C700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2E8CA70", Offset = "0x2E8B270", VA = "0x182E8CA70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public FJLCNICBIII actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public BDGMFPCFLOK photonServerConnectionInfo;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public JILOAALPANL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x37FE440", Offset = "0x37FCC40", VA = "0x1837FE440")]
		[AsyncStateMachine(typeof(HAFODBMMIFJ<>.JILOAALPANL.<<ConnectToRegionInternal>b__0>d))]
		internal Task<BDGMFPCFLOK> PHDIIFAMEPJ(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct MHEELOLFOHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AsyncTaskMethodBuilder<BDGMFPCFLOK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public FJLCNICBIII actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public BDGMFPCFLOK photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private JILOAALPANL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter<BDGMFPCFLOK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3B06880", Offset = "0x3B05080", VA = "0x183B06880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3B07470", Offset = "0x3B05C70", VA = "0x183B07470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct HEMIFJDHGKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder<BDGMFPCFLOK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public FJLCNICBIII actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public BDGMFPCFLOK photonServerConnectionInfo;

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
		[Cpp2IlInjected.Address(RVA = "0x356F980", Offset = "0x356E180", VA = "0x18356F980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3570650", Offset = "0x356EE50", VA = "0x183570650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct AKDFAEKIAJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public FJLCNICBIII actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x352B040", Offset = "0x3529840", VA = "0x18352B040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x352B290", Offset = "0x3529A90", VA = "0x18352B290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct FJIJIKKDHLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private FJLCNICBIII <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x34223C0", Offset = "0x3420BC0", VA = "0x1834223C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x34228E0", Offset = "0x34210E0", VA = "0x1834228E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class OMPEMCKEBIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public FJLCNICBIII actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public OMPEMCKEBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3CF3610", Offset = "0x3CF1E10", VA = "0x183CF3610")]
		internal Task<bool> KJLLAMJCPIJ(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct PIFHPKPIKOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public FJLCNICBIII actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private OMPEMCKEBIK <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x3DAD060", Offset = "0x3DAB860", VA = "0x183DAD060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3DADE80", Offset = "0x3DAC680", VA = "0x183DADE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class DJFPHGGNCCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public FJLCNICBIII actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public TaskCompletionSource<LADONBJPHPE> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public DJFPHGGNCCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4D18920", Offset = "0x4D17120", VA = "0x184D18920")]
		internal void OIFDHEMDHFP(LADONBJPHPE disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4D18850", Offset = "0x4D17050", VA = "0x184D18850")]
		internal void MINKGDEMGKN()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct FOAPLMNJNFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public FJLCNICBIII actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private DJFPHGGNCCA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<LADONBJPHPE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x342F240", Offset = "0x342DA40", VA = "0x18342F240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x34307D0", Offset = "0x342EFD0", VA = "0x1834307D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct LIFMKCGIGJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<ENGKFENENDE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public ENGKFENENDE targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private FJLCNICBIII <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<ENGKFENENDE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3923090", Offset = "0x3921890", VA = "0x183923090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3923CB0", Offset = "0x39224B0", VA = "0x183923CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class FHFJFHNKEFG
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
			public AsyncTaskMethodBuilder<ENGKFENENDE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public FHFJFHNKEFG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private TaskAwaiter<ENGKFENENDE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x2E8CAE0", Offset = "0x2E8B2E0", VA = "0x182E8CAE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x2E8CE60", Offset = "0x2E8B660", VA = "0x182E8CE60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public FJLCNICBIII actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public ENGKFENENDE targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public object pauseToken;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public FHFJFHNKEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x34144D0", Offset = "0x3412CD0", VA = "0x1834144D0")]
		[AsyncStateMachine(typeof(HAFODBMMIFJ<>.FHFJFHNKEFG.<<ConnectToRoomInstanceInternal>b__0>d))]
		internal Task<ENGKFENENDE> ILOIPBEIFJN(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct FGLBGKAFIIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder<ENGKFENENDE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public FJLCNICBIII actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public ENGKFENENDE targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private FHFJFHNKEFG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter<ENGKFENENDE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3412160", Offset = "0x3410960", VA = "0x183412160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3412F00", Offset = "0x3411700", VA = "0x183412F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class KKPFDCELMMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TaskCompletionSource<KBGMFEBKJBD> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public KKPFDCELMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3880960", Offset = "0x387F160", VA = "0x183880960")]
		internal void LFEPFFHAFMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x38808D0", Offset = "0x387F0D0", VA = "0x1838808D0")]
		internal void HCECPCKBNCM()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct CLAJPJOOEAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public AsyncTaskMethodBuilder<ENGKFENENDE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public FJLCNICBIII actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public ENGKFENENDE targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private KKPFDCELMMH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private FAOJMAKOAPP <roomOptions>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private TaskAwaiter<BDGMFPCFLOK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter<KBGMFEBKJBD> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4B6AE90", Offset = "0x4B69690", VA = "0x184B6AE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4B6D2D0", Offset = "0x4B6BAD0", VA = "0x184B6D2D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct BCFMKNMPNDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Task<HKEAPFGLHIG> whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private TaskAwaiter<HKEAPFGLHIG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x43E68B0", Offset = "0x43E50B0", VA = "0x1843E68B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x840DA0", Offset = "0x83F5A0", VA = "0x180840DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct HIDPKJCBBKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public FJLCNICBIII actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3590C00", Offset = "0x358F400", VA = "0x183590C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3590E40", Offset = "0x358F640", VA = "0x183590E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct FJCDCFLBKMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private FJLCNICBIII <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3421620", Offset = "0x341FE20", VA = "0x183421620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3421AB0", Offset = "0x34202B0", VA = "0x183421AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct FJGMAKLOBLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public FJLCNICBIII actionContext;

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
		[Cpp2IlInjected.Address(RVA = "0x3421BA0", Offset = "0x34203A0", VA = "0x183421BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3422360", Offset = "0x3420B60", VA = "0x183422360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class IJHLDDJJKMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public FJLCNICBIII actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public IJHLDDJJKMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x36489C0", Offset = "0x36471C0", VA = "0x1836489C0")]
		internal Task<HKEAPFGLHIG> DKDNHMMHBME(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct JMKOFNNLOIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public FJLCNICBIII actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private IJHLDDJJKMA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private TaskAwaiter<HKEAPFGLHIG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3826CD0", Offset = "0x38254D0", VA = "0x183826CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x38277F0", Offset = "0x3825FF0", VA = "0x1838277F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class HINLKDJMLPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public FJLCNICBIII actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public TaskCompletionSource<KBGMFEBKJBD> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public HINLKDJMLPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3591560", Offset = "0x358FD60", VA = "0x183591560")]
		internal void CJDGDECIMMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3591820", Offset = "0x3590020", VA = "0x183591820")]
		internal void OANJFLGBMOA(LADONBJPHPE disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x35915F0", Offset = "0x358FDF0", VA = "0x1835915F0")]
		internal void IBMACCLKKKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class MHJAIDCCNGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TaskCompletionSource<KBGMFEBKJBD> reconnectToMasterServerTcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public HINLKDJMLPD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public MHJAIDCCNGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3B079A0", Offset = "0x3B061A0", VA = "0x183B079A0")]
		internal void CLEHJKFGPCC(LADONBJPHPE disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3B07A40", Offset = "0x3B06240", VA = "0x183B07A40")]
		internal void PNMJAOHODPM()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct AIPDJDDEDFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public AsyncTaskMethodBuilder<HKEAPFGLHIG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public FJLCNICBIII actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private HINLKDJMLPD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private MHJAIDCCNGH <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TaskAwaiter<KBGMFEBKJBD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x35206D0", Offset = "0x351EED0", VA = "0x1835206D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x35227A0", Offset = "0x3520FA0", VA = "0x1835227A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class JEDMHHIFLPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public FJLCNICBIII actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public TaskCompletionSource<KBGMFEBKJBD> reconnectToMasterServerTcs;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public JEDMHHIFLPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x37EB130", Offset = "0x37E9930", VA = "0x1837EB130")]
		internal string FOLOJKCONOB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x37EB1A0", Offset = "0x37E99A0", VA = "0x1837EB1A0")]
		internal void IBKKNHDOHCO(KBGMFEBKJBD _1, KBGMFEBKJBD _2)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct MEDMGLAFBLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public AsyncTaskMethodBuilder<KBGMFEBKJBD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public FJLCNICBIII actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private JEDMHHIFLPM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private TaskAwaiter<KBGMFEBKJBD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3AEB400", Offset = "0x3AE9C00", VA = "0x183AEB400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3AEC120", Offset = "0x3AEA920", VA = "0x183AEC120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct IOAJEDHOCFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3667020", Offset = "0x3665820", VA = "0x183667020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x840DA0", Offset = "0x83F5A0", VA = "0x180840DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct PIHBDPOHFEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3DAE2E0", Offset = "0x3DACAE0", VA = "0x183DAE2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3DAE660", Offset = "0x3DACE60", VA = "0x183DAE660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct BPDGOGLJOIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public LADONBJPHPE disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private PDKBPPOMIOM <exception>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4897780", Offset = "0x4895F80", VA = "0x184897780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x840DA0", Offset = "0x83F5A0", VA = "0x180840DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct KJFFCIAJEOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public LADONBJPHPE disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private HashSet<CMMNHJHICGF>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3878EE0", Offset = "0x38776E0", VA = "0x183878EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3879910", Offset = "0x3878110", VA = "0x183879910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct DBMNJCCLPPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private HashSet<AAGPPEIEPMJ>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4CE2970", Offset = "0x4CE1170", VA = "0x184CE2970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4CE2E50", Offset = "0x4CE1650", VA = "0x184CE2E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class OALPIBFFNAD<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public string timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public OALPIBFFNAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
		internal string OGBEHNEGGIE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class ABAPIOCPMEN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public FJLCNICBIII actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public Dictionary<string, string> tcsTimeoutData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public MCBOFPNLODH.HHLCPOBHIMG timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public ABAPIOCPMEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3485AB0", Offset = "0x34842B0", VA = "0x183485AB0")]
		internal void IFIACJDLIBI(string prefix, Dictionary<string, string> dict)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x34862D0", Offset = "0x3484AD0", VA = "0x1834862D0")]
		internal EODMBBIDKHD MPGOKIIKKLP(TimeSpan timeoutTime)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class IBCKPOIKAAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public TaskCompletionSource<KBGMFEBKJBD> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public IBCKPOIKAAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x361F170", Offset = "0x361D970", VA = "0x18361F170")]
		internal void DOHLMKPHHOL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct NBFPAKDBDMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public FJLCNICBIII actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private IBCKPOIKAAC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public KBGMFEBKJBD connectedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public AppSettings appSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private TaskAwaiter<KBGMFEBKJBD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3B98270", Offset = "0x3B96A70", VA = "0x183B98270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3B99560", Offset = "0x3B97D60", VA = "0x183B99560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class ADNMFLAGGAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public FJLCNICBIII actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public ADNMFLAGGAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x34ADA30", Offset = "0x34AC230", VA = "0x1834ADA30")]
		internal object MMGAPBCDPAI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class LKOBCHFECIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public FJLCNICBIII actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public LKOBCHFECIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x39246D0", Offset = "0x3922ED0", VA = "0x1839246D0")]
		internal object ILMEHKKCFDN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class KHHFHEFELNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public HAFODBMMIFJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public FJLCNICBIII actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public KHHFHEFELNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3873280", Offset = "0x3871A80", VA = "0x183873280")]
		internal object JFHEANHCCFI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly Hashtable HBELFGNEHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly MHOHFOIHKFE BGOBHFLGNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly ICFKNDAFIME DMJAOAPOMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected readonly string IJHJILECBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected readonly LPPGHONKDIF JFIINJNEDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private TaskCompletionSource<HKEAPFGLHIG> JKPLCGPHOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[NotNull]
	public readonly LGKHOIPJHAI PEEHFNHLHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected internal readonly TNetworking FDJBNEIPECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private ushort ADHHKOIFHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private KHHJFDPNGMJ<BDGMFPCFLOK> NKBEGEKADLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private KHHJFDPNGMJ<bool> BOJMPBEMKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private KHHJFDPNGMJ<ENGKFENENDE> ABNBLMEPONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private KHHJFDPNGMJ<HKEAPFGLHIG> GFBJCLDEDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool LMKIALBDPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private bool EHDOLOLMMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly HashSet<AAGPPEIEPMJ> AIMMPDHDPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly HashSet<CMMNHJHICGF> IIGLKEDDBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private bool CBPCANBMLCP;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool BBGGDANMMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x355C210", Offset = "0x355AA10", VA = "0x18355C210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	[CanBeNull]
	public ENGKFENENDE BKAELLFMGNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x355E000", Offset = "0x355C800", VA = "0x18355E000", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	protected KBGMFEBKJBD EEGGEKKHJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x355E330", Offset = "0x355CB30", VA = "0x18355E330")]
		get
		{
			return default(KBGMFEBKJBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	[CanBeNull]
	public string OJDJBJBDPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x355CF00", Offset = "0x355B700", VA = "0x18355CF00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private TimeSpan KOCBJEHKFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x355DE20", Offset = "0x355C620", VA = "0x18355DE20")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private TimeSpan OIMHJMLFECK
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x355D2A0", Offset = "0x355BAA0", VA = "0x18355D2A0")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public Task BFEBILADLEB
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x355D370", Offset = "0x355BB70", VA = "0x18355D370", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract bool JPKMJKCCEMO(ENGKFENENDE BKLIDCPKLEM);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x355CCA0", Offset = "0x355B4A0", VA = "0x18355CCA0")]
	private static TimeSpan IFHDIDPMJJG(TimeSpan IPJFPJFJACP, string HNHMJGCODBA)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x355ED70", Offset = "0x355D570", VA = "0x18355ED70")]
	protected HAFODBMMIFJ(TNetworking JIAGCNOOLAE, LPPGHONKDIF IDBBFLOCDDC, string OFOCENNNFKK, ICFKNDAFIME DMJAOAPOMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x355EA30", Offset = "0x355D230", VA = "0x18355EA30")]
	internal HAFODBMMIFJ(TNetworking JIAGCNOOLAE, LPPGHONKDIF IDBBFLOCDDC, string OFOCENNNFKK, ICFKNDAFIME DMJAOAPOMIP, [Optional] MHOHFOIHKFE BGOBHFLGNJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x355CBB0", Offset = "0x355B3B0", VA = "0x18355CBB0")]
	private void IAKJOOKKICE(bool EANKMFHELBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x355BEA0", Offset = "0x355A6A0", VA = "0x18355BEA0")]
	private void CPLPMMKPJJK(KBGMFEBKJBD EAONIJJEEOI, KBGMFEBKJBD LAIOPCMADMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x355C1C0", Offset = "0x355A9C0", VA = "0x18355C1C0")]
	internal FJLCNICBIII EEJLFNCGOIF()
	{
		return default(FJLCNICBIII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x355C770", Offset = "0x355AF70", VA = "0x18355C770")]
	[AsyncStateMachine(typeof(HAFODBMMIFJ<>.MHEELOLFOHK))]
	private Task<BDGMFPCFLOK> GDFAPAGDJEM(FJLCNICBIII GOGGOGPMKGP, BDGMFPCFLOK HOKOONHBJON, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x355B840", Offset = "0x355A040", VA = "0x18355B840")]
	[AsyncStateMachine(typeof(HAFODBMMIFJ<>.HEMIFJDHGKC))]
	protected Task<BDGMFPCFLOK> BCBENKADPFP(FJLCNICBIII GOGGOGPMKGP, BDGMFPCFLOK HOKOONHBJON, CancellationToken FGKAIOLPPKC, CancellationToken OGJILCFKKGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x355E420", Offset = "0x355CC20", VA = "0x18355E420")]
	[AsyncStateMachine(typeof(HAFODBMMIFJ<>.AKDFAEKIAJH))]
	protected Task PGICMGIAIPE(FJLCNICBIII GOGGOGPMKGP, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x355C370", Offset = "0x355AB70", VA = "0x18355C370", Slot = "7")]
	[AsyncStateMachine(typeof(HAFODBMMIFJ<>.FJIJIKKDHLM))]
	public Task ELIKLHPLONE([Optional] CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x355DCE0", Offset = "0x355C4E0", VA = "0x18355DCE0")]
	[AsyncStateMachine(typeof(HAFODBMMIFJ<>.PIFHPKPIKOE))]
	private Task MNAPHGMLLJC(FJLCNICBIII GOGGOGPMKGP, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x355BBE0", Offset = "0x355A3E0", VA = "0x18355BBE0")]
	[AsyncStateMachine(typeof(HAFODBMMIFJ<>.FOAPLMNJNFN))]
	private Task<bool> BMBFOBIHDDM(FJLCNICBIII GOGGOGPMKGP, CancellationToken KIAKEGJPMAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x355BD40", Offset = "0x355A540", VA = "0x18355BD40", Slot = "8")]
	[AsyncStateMachine(typeof(HAFODBMMIFJ<>.LIFMKCGIGJM))]
	public Task<ENGKFENENDE> CHDNBFLEOJK(ENGKFENENDE BKLIDCPKLEM, object LLNAJFDAEHL, [Optional] CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x355C040", Offset = "0x355A840", VA = "0x18355C040")]
	[AsyncStateMachine(typeof(HAFODBMMIFJ<>.FGLBGKAFIIG))]
	private Task<ENGKFENENDE> EADDBAEHHED(FJLCNICBIII GOGGOGPMKGP, ENGKFENENDE BKLIDCPKLEM, object LLNAJFDAEHL, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x355E6E0", Offset = "0x355CEE0", VA = "0x18355E6E0")]
	[AsyncStateMachine(typeof(HAFODBMMIFJ<>.CLAJPJOOEAK))]
	private Task<ENGKFENENDE> POODCJPILJJ(FJLCNICBIII GOGGOGPMKGP, ENGKFENENDE BKLIDCPKLEM, object LLNAJFDAEHL, CancellationToken FGKAIOLPPKC, CancellationToken OGJILCFKKGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x355BB20", Offset = "0x355A320", VA = "0x18355BB20")]
	[AsyncStateMachine(typeof(HAFODBMMIFJ<>.BCFMKNMPNDF))]
	private void BKLMALILDLP(Task<HKEAPFGLHIG> GDOOKJEGBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x355E050", Offset = "0x355C850", VA = "0x18355E050")]
	[AsyncStateMachine(typeof(HAFODBMMIFJ<>.HIDPKJCBBKE))]
	private Task OEHLIMGAIBM(FJLCNICBIII GOGGOGPMKGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x355DEF0", Offset = "0x355C6F0", VA = "0x18355DEF0", Slot = "9")]
	[AsyncStateMachine(typeof(HAFODBMMIFJ<>.FJCDCFLBKMI))]
	public Task NINEIKMEAAE([Optional] CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x355D960", Offset = "0x355C160", VA = "0x18355D960")]
	[AsyncStateMachine(typeof(HAFODBMMIFJ<>.FJGMAKLOBLH))]
	private Task LJGPIBLJEFI(FJLCNICBIII GOGGOGPMKGP, [Optional] CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x355D4E0", Offset = "0x355BCE0", VA = "0x18355D4E0")]
	[AsyncStateMachine(typeof(HAFODBMMIFJ<>.JMKOFNNLOIN))]
	private Task KGFAIMHGGLC(FJLCNICBIII GOGGOGPMKGP, [Optional] CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x355C8E0", Offset = "0x355B0E0", VA = "0x18355C8E0")]
	[AsyncStateMachine(typeof(HAFODBMMIFJ<>.AIPDJDDEDFF))]
	private Task<HKEAPFGLHIG> GHFFHJILJDM(FJLCNICBIII GOGGOGPMKGP, CancellationToken FGKAIOLPPKC, CancellationToken OGJILCFKKGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x355E570", Offset = "0x355CD70", VA = "0x18355E570")]
	[AsyncStateMachine(typeof(HAFODBMMIFJ<>.MEDMGLAFBLA))]
	private Task<KBGMFEBKJBD> PIHKNFPGPLO(FJLCNICBIII GOGGOGPMKGP, CancellationToken EHCFBFBFEDH, string OONIIOMBHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x355DC40", Offset = "0x355C440", VA = "0x18355DC40", Slot = "14")]
	protected virtual void MKCAFOAJMFB(FJLCNICBIII GOGGOGPMKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x355D8C0", Offset = "0x355C0C0", VA = "0x18355D8C0", Slot = "15")]
	protected virtual void KJBDPOEGHEM(FJLCNICBIII GOGGOGPMKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x355CA50", Offset = "0x355B250", VA = "0x18355CA50")]
	private void HHOKLMEAHFC(FJLCNICBIII GOGGOGPMKGP, GGEHNFPMHFG OONIIOMBHJI, params object[] CCBNPDAGICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "16")]
	protected virtual void KLBCGDANBIG(ENGKFENENDE JENLPPBJFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x355B790", Offset = "0x3559F90", VA = "0x18355B790")]
	[AsyncStateMachine(typeof(HAFODBMMIFJ<>.IOAJEDHOCFD))]
	private void AECNKFFHDDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x355D400", Offset = "0x355BC00", VA = "0x18355D400")]
	[AsyncStateMachine(typeof(HAFODBMMIFJ<>.PIHBDPOHFEP))]
	private Task KGCNFDJAFNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x355CE40", Offset = "0x355B640", VA = "0x18355CE40")]
	[AsyncStateMachine(typeof(HAFODBMMIFJ<>.BPDGOGLJOIL))]
	private void IGBAGEKEPLD(LADONBJPHPE CJJNALPCMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x355B9C0", Offset = "0x355A1C0", VA = "0x18355B9C0")]
	[AsyncStateMachine(typeof(HAFODBMMIFJ<>.KJFFCIAJEOF))]
	private Task BCGFEMLKKCI(LADONBJPHPE CJJNALPCMIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x355D630", Offset = "0x355BE30", VA = "0x18355D630")]
	[AsyncStateMachine(typeof(HAFODBMMIFJ<>.DBMNJCCLPPP))]
	private Task KGKBAOPCKDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x355BAC0", Offset = "0x355A2C0", VA = "0x18355BAC0", Slot = "10")]
	public void BGDGBNGCKDD(CMMNHJHICGF MPPKBKKNPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x215DBA0", Offset = "0x215C3A0", VA = "0x18215DBA0")]
	private TaskCompletionSource<T> ECGCBACHCLL<T>(FJLCNICBIII GOGGOGPMKGP, CancellationToken EHCFBFBFEDH, TimeSpan EHHDIDGCGLB, string FPCIMGLOHHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x215DCE0", Offset = "0x215C4E0", VA = "0x18215DCE0")]
	private TaskCompletionSource<T> ECGCBACHCLL<T>(FJLCNICBIII GOGGOGPMKGP, CancellationToken EHCFBFBFEDH, TimeSpan EHHDIDGCGLB, MCBOFPNLODH.HHLCPOBHIMG FPCIMGLOHHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x355C480", Offset = "0x355AC80", VA = "0x18355C480")]
	[AsyncStateMachine(typeof(HAFODBMMIFJ<>.NBFPAKDBDMB))]
	protected Task FKFLMMGCIJB(FJLCNICBIII GOGGOGPMKGP, AppSettings PLMDHCPMLFA, KBGMFEBKJBD MHAMEBCBOPE, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x355BF90", Offset = "0x355A790", VA = "0x18355BF90", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x355CF60", Offset = "0x355B760", VA = "0x18355CF60", Slot = "17")]
	protected virtual void JCDFHDNLEBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x355C280", Offset = "0x355AA80", VA = "0x18355C280")]
	private static string EIEIKGMIJPG(FJLCNICBIII GOGGOGPMKGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	protected void NOCJPHOMELN(string BKGEBGGPBLH, [Optional] FJLCNICBIII GOGGOGPMKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x355DAB0", Offset = "0x355C2B0", VA = "0x18355DAB0")]
	protected void MDEODFKEEPD(string BKGEBGGPBLH, [Optional] FJLCNICBIII GOGGOGPMKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x355C5E0", Offset = "0x355ADE0", VA = "0x18355C5E0")]
	protected void GDBKNPKOPNG(string BKGEBGGPBLH, [Optional] FJLCNICBIII GOGGOGPMKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x355D720", Offset = "0x355BF20", VA = "0x18355D720")]
	protected void KIBAIBCDKCE(string BKGEBGGPBLH, Exception KPCACGLGOPI, [Optional] FJLCNICBIII GOGGOGPMKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x355C2A0", Offset = "0x355AAA0", VA = "0x18355C2A0")]
	public void ELBAPHOONGG(NCNPIPEEFLG MEAOIIOHJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x355E180", Offset = "0x355C980", VA = "0x18355E180")]
	[CompilerGenerated]
	private void OKGFGLOHFMF(NCPEHMNDMGE NHGLLPKLPMG, NCPEHMNDMGE IJAEPCHBBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x215E220", Offset = "0x215CA20", VA = "0x18215E220")]
	[CompilerGenerated]
	internal static string EJDLKJEMCCA<T>(TimeSpan MFJKHGIDLGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct FJLCNICBIII : IEquatable<FJLCNICBIII>, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public readonly ushort EEEGNJDNKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public readonly string IJHJILECBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly GDMHDAAKABH JIAGCNOOLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly Stopwatch PGHOMNCACMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly List<(TimeSpan, KBGMFEBKJBD, KBGMFEBKJBD)> FOEIDMDPJJG;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public TimeSpan PPFBBPHHNBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5D34AE0", Offset = "0x5D332E0", VA = "0x185D34AE0")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IReadOnlyList<(TimeSpan time, KBGMFEBKJBD oldState, KBGMFEBKJBD newState)> DCOCGOFEKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5D34E40", Offset = "0x5D33640", VA = "0x185D34E40")]
	public FJLCNICBIII(ushort GHDJMDLGPPF, string OFOCENNNFKK, GDMHDAAKABH JIAGCNOOLAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5D34D30", Offset = "0x5D33530", VA = "0x185D34D30")]
	private void PEEHFBJOHCJ(KBGMFEBKJBD EAONIJJEEOI, KBGMFEBKJBD LAIOPCMADMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5D34C70", Offset = "0x5D33470", VA = "0x185D34C70", Slot = "4")]
	public bool Equals(FJLCNICBIII IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5D34C80", Offset = "0x5D33480", VA = "0x185D34C80", Slot = "0")]
	public override bool Equals(object CBBCDNDPNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5D34D10", Offset = "0x5D33510", VA = "0x185D34D10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5D34B00", Offset = "0x5D33300", VA = "0x185D34B00")]
	public static bool BIBGNMIHGGC(FJLCNICBIII PEEDIPGMMHL, FJLCNICBIII PEFIBHOJLKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5D34B20", Offset = "0x5D33320", VA = "0x185D34B20", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal static class MDDPFOLLNOH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct KJAGJICMJOF<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public KHHJFDPNGMJ<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public FJLCNICBIII doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x38786B0", Offset = "0x3876EB0", VA = "0x1838786B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3878E60", Offset = "0x3877660", VA = "0x183878E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct PJHANJHPILF<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public KHHJFDPNGMJ<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public TimeSpan forceCancelTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public FJLCNICBIII doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x3DB8D50", Offset = "0x3DB7550", VA = "0x183DB8D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3DB9250", Offset = "0x3DB7A50", VA = "0x183DB9250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct EAAAKJBHHGP<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public KHHJFDPNGMJ<TArgs> clientAction;

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
		[Cpp2IlInjected.Address(RVA = "0x302C820", Offset = "0x302B020", VA = "0x18302C820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x302D840", Offset = "0x302C040", VA = "0x18302D840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x24394B0", Offset = "0x2437CB0", VA = "0x1824394B0")]
	[AsyncStateMachine(typeof(KJAGJICMJOF<>))]
	public static Task DDKPCKNBHAJ<TArgs>(this KHHJFDPNGMJ<TArgs> GNOACNAIALD, [Optional] FJLCNICBIII EPOALIPOABI) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2439810", Offset = "0x2438010", VA = "0x182439810")]
	[AsyncStateMachine(typeof(PJHANJHPILF<>))]
	public static Task FDEBGNKPMLE<TArgs>(this KHHJFDPNGMJ<TArgs> GNOACNAIALD, TimeSpan PANGHPKBJLA, [Optional] FJLCNICBIII EPOALIPOABI) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2439DA0", Offset = "0x24385A0", VA = "0x182439DA0")]
	public static (bool, bool) ILFKOLGDEAH<TArgs>(this KHHJFDPNGMJ<TArgs> GNOACNAIALD, TArgs KMJKCJJHEFM, [Out] string KNIDENKONOK) where TArgs : IEquatable<TArgs>
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2439A70", Offset = "0x2438270", VA = "0x182439A70")]
	[AsyncStateMachine(typeof(EAAAKJBHHGP<>))]
	public static Task<TArgs> HNHKGOHKBJL<TArgs>(this KHHJFDPNGMJ<TArgs> GNOACNAIALD, TArgs KMJKCJJHEFM, CancellationToken JGEBFDILDCE) where TArgs : IEquatable<TArgs>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal class KHHJFDPNGMJ<TArgs> : IDisposable where TArgs : IEquatable<TArgs>
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate Task<TArgs> IGCBHHHLPKF(CancellationToken PCINDPFHCPJ, CancellationToken NBNMKMMNGNJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct ABKILDFFNJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public KHHJFDPNGMJ<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public FJLCNICBIII doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public TimeSpan forceCancelAfter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3486F80", Offset = "0x3485780", VA = "0x183486F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x3487560", Offset = "0x3485D60", VA = "0x183487560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct DBIOJNNHJEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public KHHJFDPNGMJ<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public FJLCNICBIII doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x4CE2100", Offset = "0x4CE0900", VA = "0x184CE2100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4CE2910", Offset = "0x4CE1110", VA = "0x184CE2910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct KNHMNEEGCPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public KHHJFDPNGMJ<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x38852A0", Offset = "0x3883AA0", VA = "0x1838852A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x38859C0", Offset = "0x38841C0", VA = "0x1838859C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct IEFBKKHBEHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public KHHJFDPNGMJ<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public IGCBHHHLPKF taskFactory;

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
		[Cpp2IlInjected.Address(RVA = "0x3632680", Offset = "0x3630E80", VA = "0x183632680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x3632FB0", Offset = "0x36317B0", VA = "0x183632FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct ODECACECEAB : IAsyncStateMachine
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
		public KHHJFDPNGMJ<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3CC9EC0", Offset = "0x3CC86C0", VA = "0x183CC9EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x305F330", Offset = "0x305DB30", VA = "0x18305F330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private bool KIMEMKKPGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private bool DIDCMBNEKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private bool KOKOCODCNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private CancellationTokenSource GPKDKJLCMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private CancellationTokenSource CBEGFNLMLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly FJLCNICBIII GOGGOGPMKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly CancellationToken DINCIKDPHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly TArgs KMJKCJJHEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private TArgs HJHABDMAAIM;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public TArgs NPBPBJCHJJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3873B90", Offset = "0x3872390", VA = "0x183873B90")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TArgs JIKKMHJAIOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x38735A0", Offset = "0x3871DA0", VA = "0x1838735A0")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	[CanBeNull]
	public Task<TArgs> MCFJFJGBOJK
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x761C00", Offset = "0x760400", VA = "0x180761C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x761BE0", Offset = "0x7603E0", VA = "0x180761BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x38756F0", Offset = "0x3873EF0", VA = "0x1838756F0")]
	public KHHJFDPNGMJ(TArgs LJOJCMMDHPB, CancellationToken DINCIKDPHMJ, FJLCNICBIII GOGGOGPMKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x38747B0", Offset = "0x3872FB0", VA = "0x1838747B0")]
	[AsyncStateMachine(typeof(KHHJFDPNGMJ<>.ABKILDFFNJI))]
	public Task MKKIHKCDOMP(TimeSpan LFCLJEMHOFC, FJLCNICBIII ENPKHKLMOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3873E30", Offset = "0x3872630", VA = "0x183873E30")]
	[AsyncStateMachine(typeof(KHHJFDPNGMJ<>.DBIOJNNHJEA))]
	public Task INKAPHLJOGF(FJLCNICBIII ENPKHKLMOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3873680", Offset = "0x3871E80", VA = "0x183873680", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3874460", Offset = "0x3872C60", VA = "0x183874460")]
	[AsyncStateMachine(typeof(KHHJFDPNGMJ<>.KNHMNEEGCPI))]
	private Task LJBKLNIKEAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3873930", Offset = "0x3872130", VA = "0x183873930")]
	[AsyncStateMachine(typeof(KHHJFDPNGMJ<>.IEFBKKHBEHL))]
	public Task<TArgs> ENABGHDNFKD(IGCBHHHLPKF PFALOLLKDEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x38741A0", Offset = "0x38729A0", VA = "0x1838741A0")]
	[AsyncStateMachine(typeof(KHHJFDPNGMJ<>.ODECACECEAB))]
	private Task<TArgs> KEAMEKCCJIA(Task<TArgs> POJFPFKIKLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3874F80", Offset = "0x3873780", VA = "0x183874F80")]
	public bool OKKHLHGIGGL(TArgs KEEDAFGBEKP, [Out] string KNIDENKONOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3875360", Offset = "0x3873B60", VA = "0x183875360")]
	private bool PNCMPPHHCFL(TArgs KEEDAFGBEKP, [Out] string KNIDENKONOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x38748F0", Offset = "0x38730F0", VA = "0x1838748F0")]
	public CancellationTokenRegistration? NOJJGKPCMKH(CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3873BB0", Offset = "0x38723B0", VA = "0x183873BB0")]
	[CompilerGenerated]
	private void GKOODGECICB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface ICFKNDAFIME
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HCMOCOPLLFK(string OFOCENNNFKK, string DJKOMFPPCFA, FJLCNICBIII GOGGOGPMKGP, [Optional] string GOHJAEFKDAG);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HOLKCGGCEEG(string OFOCENNNFKK, string DJKOMFPPCFA, FJLCNICBIII GOGGOGPMKGP, [Optional] string GOHJAEFKDAG);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JHMIMFBHHLP(string OFOCENNNFKK, string DJKOMFPPCFA, FJLCNICBIII GOGGOGPMKGP, [Optional] string GOHJAEFKDAG);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BDFLEAFDPPL(string OFOCENNNFKK, string DJKOMFPPCFA, FJLCNICBIII GOGGOGPMKGP, Exception LNOFJJLDMOF, [Optional] string GOHJAEFKDAG);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GJMDJPBODLL(string OFOCENNNFKK, PDKBPPOMIOM KGOAJHALHKN);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal static class ENIPGACJEON
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct EEAICFHLALF<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public ICFKNDAFIME analytics;

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
		public FJLCNICBIII actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x305EAC0", Offset = "0x305D2C0", VA = "0x18305EAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x305F330", Offset = "0x305DB30", VA = "0x18305F330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct LDJAOAJBNGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public ICFKNDAFIME analytics;

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
		public FJLCNICBIII actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5D39A60", Offset = "0x5D38260", VA = "0x185D39A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5D39F20", Offset = "0x5D38720", VA = "0x185D39F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x22488E0", Offset = "0x22470E0", VA = "0x1822488E0")]
	[AsyncStateMachine(typeof(EEAICFHLALF<>))]
	public static Task<T> ELJEBDAJEFK<T>(this Task<T> AKGEHPDFIAE, [CanBeNull] ICFKNDAFIME DMJAOAPOMIP, string OFOCENNNFKK, string DJKOMFPPCFA, FJLCNICBIII GOGGOGPMKGP, [Optional] string GOHJAEFKDAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5D348B0", Offset = "0x5D330B0", VA = "0x185D348B0")]
	[AsyncStateMachine(typeof(LDJAOAJBNGI))]
	public static Task ELJEBDAJEFK(this Task AKGEHPDFIAE, [CanBeNull] ICFKNDAFIME DMJAOAPOMIP, string OFOCENNNFKK, string DJKOMFPPCFA, FJLCNICBIII GOGGOGPMKGP, [Optional] string GOHJAEFKDAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public delegate Task AAGPPEIEPMJ();
[Cpp2IlInjected.Token(Token = "0x200004E")]
public delegate Task CMMNHJHICGF(LADONBJPHPE CJJNALPCMIH);
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class BBAILEIOPBA : NCPEHMNDMGE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly NCNPIPEEFLG KFFHAJDIOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly Func<BBAILEIOPBA, bool> GLGCIGGEAFP;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public KBGMFEBKJBD EEGGEKKHJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F830", Offset = "0x5D2E030", VA = "0x185D2F830", Slot = "4")]
		get
		{
			return default(KBGMFEBKJBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public PGCFLJLDKLM ODHGELPFGLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F6C0", Offset = "0x5D2DEC0", VA = "0x185D2F6C0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool BBGGDANMMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F6A0", Offset = "0x5D2DEA0", VA = "0x185D2F6A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool NDFLLOOKAHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F520", Offset = "0x5D2DD20", VA = "0x185D2F520", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool GNJOMMOFCNL
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F7B0", Offset = "0x5D2DFB0", VA = "0x185D2F7B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Exception JIGOLPCHKBI
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F850", Offset = "0x5D2E050", VA = "0x185D2F850", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public StatusCode IIFGOHOMJIG
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F7F0", Offset = "0x5D2DFF0", VA = "0x185D2F7F0", Slot = "16")]
		get
		{
			return default(StatusCode);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event NCNPIPEEFLG.BBGODEDCGEL BALDJAENMIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F7D0", Offset = "0x5D2DFD0", VA = "0x185D2F7D0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F810", Offset = "0x5D2E010", VA = "0x185D2F810", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<KBGMFEBKJBD, KBGMFEBKJBD> BCGPHKCEOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F6E0", Offset = "0x5D2DEE0", VA = "0x185D2F6E0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F5F0", Offset = "0x5D2DDF0", VA = "0x185D2F5F0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F890", Offset = "0x5D2E090", VA = "0x185D2F890")]
	public BBAILEIOPBA(NCNPIPEEFLG KFFHAJDIOCE, [Optional] Func<BBAILEIOPBA, bool> GLGCIGGEAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F560", Offset = "0x5D2DD60", VA = "0x185D2F560", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F870", Offset = "0x5D2E070", VA = "0x185D2F870")]
	private void PPAJDJMCCJH(KBGMFEBKJBD EAONIJJEEOI, KBGMFEBKJBD LAIOPCMADMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F540", Offset = "0x5D2DD40", VA = "0x185D2F540", Slot = "13")]
	public void BHKBJDNPGGI(object KMJKCJJHEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F790", Offset = "0x5D2DF90", VA = "0x185D2F790", Slot = "14")]
	public void HOFLMLIPINO(object KMJKCJJHEFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class JAJMPOCBEIG : HEEPHCNKAAB, CGHNPOGGIOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class DGODCBHIFAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public ENGKFENENDE targetRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public DGODCBHIFAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5D305C0", Offset = "0x5D2EDC0", VA = "0x185D305C0")]
		internal bool DHHAFPODANH(PDDNIKFHLIC c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class FOAKMCCKABJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public FOAKMCCKABJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5D35120", Offset = "0x5D33920", VA = "0x185D35120")]
		internal Task MMDHNEJLNHB(PDDNIKFHLIC c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct GMFGDFLDEMC : IAsyncStateMachine
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
		public JAJMPOCBEIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5D35180", Offset = "0x5D33980", VA = "0x185D35180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x5D35410", Offset = "0x5D33C10", VA = "0x185D35410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct KDFKHNMFPGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public AsyncTaskMethodBuilder<ENGKFENENDE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public JAJMPOCBEIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public ENGKFENENDE targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private ENGKFENENDE <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter<ENGKFENENDE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x5D38D80", Offset = "0x5D37580", VA = "0x185D38D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x5D39260", Offset = "0x5D37A60", VA = "0x185D39260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class FBEGJNMFPFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public FBEGJNMFPFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x5D34A80", Offset = "0x5D33280", VA = "0x185D34A80")]
		internal Task BBDFEOKPOGB(PDDNIKFHLIC c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct HJCFHGFPELL : IAsyncStateMachine
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
		public JAJMPOCBEIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5D35470", Offset = "0x5D33C70", VA = "0x185D35470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5D35700", Offset = "0x5D33F00", VA = "0x185D35700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public readonly DPPBKDFDBFF DPMIDGHPAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public readonly JHDHKHALCMN ENDMFMMOKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly PDDNIKFHLIC[] KIGKBFMLJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public readonly PIKMCHHMNCL PHLEAMGFHHN;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public ENGKFENENDE BKAELLFMGNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5D38340", Offset = "0x5D36B40", VA = "0x185D38340", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string OJDJBJBDPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5D38090", Offset = "0x5D36890", VA = "0x185D38090", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private IEnumerable<PDDNIKFHLIC> EOPGAJLBEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5D38300", Offset = "0x5D36B00", VA = "0x185D38300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private KHDBONJHAAE PLLHLGOIOPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Task BFEBILADLEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5D380E0", Offset = "0x5D368E0", VA = "0x185D380E0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5D38130", Offset = "0x5D36930", VA = "0x185D38130", Slot = "7")]
	public bool JPKMJKCCEMO(ENGKFENENDE BKLIDCPKLEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5D38390", Offset = "0x5D36B90", VA = "0x185D38390")]
	[Preserve]
	public JAJMPOCBEIG([KEKICHOEFEB(null)] DPPBKDFDBFF GKGPAAMEJDN, [KEKICHOEFEB(null)] JHDHKHALCMN GJADJJCIBCM, [KEKICHOEFEB(null)] PIKMCHHMNCL EGEMIFNJLHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5D37FA0", Offset = "0x5D367A0", VA = "0x185D37FA0", Slot = "8")]
	[AsyncStateMachine(typeof(GMFGDFLDEMC))]
	public Task ELIKLHPLONE([Optional] CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5D37BF0", Offset = "0x5D363F0", VA = "0x185D37BF0", Slot = "9")]
	[AsyncStateMachine(typeof(KDFKHNMFPGJ))]
	public Task<ENGKFENENDE> CHDNBFLEOJK(ENGKFENENDE BKLIDCPKLEM, object LLNAJFDAEHL, [Optional] CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5D38210", Offset = "0x5D36A10", VA = "0x185D38210", Slot = "10")]
	[AsyncStateMachine(typeof(HJCFHGFPELL))]
	public Task NINEIKMEAAE([Optional] CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5D37D50", Offset = "0x5D36550", VA = "0x185D37D50", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5D37AD0", Offset = "0x5D362D0", VA = "0x185D37AD0", Slot = "11")]
	public void BGDGBNGCKDD(CMMNHJHICGF MPPKBKKNPFE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct HKEAPFGLHIG : IEquatable<HKEAPFGLHIG>
{
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public static readonly HKEAPFGLHIG MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x77D0F0", Offset = "0x77B8F0", VA = "0x18077D0F0", Slot = "4")]
	public bool Equals(HKEAPFGLHIG IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5D35760", Offset = "0x5D33F60", VA = "0x185D35760", Slot = "0")]
	public override bool Equals(object CBBCDNDPNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x764500", Offset = "0x762D00", VA = "0x180764500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class MMKHOKAIIMJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5D357D0", Offset = "0x5D33FD0", VA = "0x185D357D0")]
	public MMKHOKAIIMJ(string BKGEBGGPBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5D3A4B0", Offset = "0x5D38CB0", VA = "0x185D3A4B0")]
	public MMKHOKAIIMJ(string BKGEBGGPBLH, Exception MKHOFBPNAEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class POJBNLADCEI : MMKHOKAIIMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public readonly string LMCKLLOLJJM;

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x5D3D530", Offset = "0x5D3BD30", VA = "0x185D3D530")]
	public POJBNLADCEI(string CCOKAAEIKAL, [NotNull] Exception MKHOFBPNAEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class KHJBDGHNGAO : MMKHOKAIIMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public readonly ENGKFENENDE CFJKMBDLAFA;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5D39940", Offset = "0x5D38140", VA = "0x185D39940")]
	public KHJBDGHNGAO(ENGKFENENDE MIBJMDOIBHD, [NotNull] Exception MKHOFBPNAEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class NGMJDPDIIEP : MMKHOKAIIMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x5D357D0", Offset = "0x5D33FD0", VA = "0x185D357D0")]
	public NGMJDPDIIEP(string BKGEBGGPBLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class PDKBPPOMIOM : MMKHOKAIIMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public readonly StatusCode? IIFGOHOMJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public readonly LADONBJPHPE NNNHANJNKJH;

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x5D3B050", Offset = "0x5D39850", VA = "0x185D3B050")]
	public PDKBPPOMIOM(LADONBJPHPE CJJNALPCMIH, Exception MKHOFBPNAEH, StatusCode? BFLPFGFOOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5D3ADB0", Offset = "0x5D395B0", VA = "0x185D3ADB0")]
	public static PDKBPPOMIOM OCOJEEPAPGC(LADONBJPHPE IKEMELLOGFH, NCPEHMNDMGE OCHJLPKBLJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class IAGMBGIDBMI : MMKHOKAIIMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5D357D0", Offset = "0x5D33FD0", VA = "0x185D357D0")]
	public IAGMBGIDBMI(string BKGEBGGPBLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class NNPMKAPGBCE : MMKHOKAIIMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public readonly short NAKGEFNCFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public readonly string BMABPGEIDMK;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5D3AC40", Offset = "0x5D39440", VA = "0x185D3AC40")]
	public NNPMKAPGBCE(short DFJHGAEKCEE, string BCNKDDIMILJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class ILBJIJKHPOE : MMKHOKAIIMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public readonly short NAKGEFNCFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public readonly string BMABPGEIDMK;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5D379E0", Offset = "0x5D361E0", VA = "0x185D379E0")]
	public ILBJIJKHPOE(short DFJHGAEKCEE, string BCNKDDIMILJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class LAMCHBDOOLC : MMKHOKAIIMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5D357D0", Offset = "0x5D33FD0", VA = "0x185D357D0")]
	public LAMCHBDOOLC(string BKGEBGGPBLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class PIJEIFHPDHH : MMKHOKAIIMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5D3B1B0", Offset = "0x5D399B0", VA = "0x185D3B1B0")]
	public PIJEIFHPDHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class EODMBBIDKHD : FGKOBBLBHHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public readonly Dictionary<string, string> JCKIBOCNPKI;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5D34A30", Offset = "0x5D33230", VA = "0x185D34A30")]
	public EODMBBIDKHD(TimeSpan EHHDIDGCGLB, string BKGEBGGPBLH, Dictionary<string, string> GOHJAEFKDAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class LGKHOIPJHAI : DKEDHFJPJBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly MBOBMBMLJPH<LADONBJPHPE> EBICPAAEDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private readonly MBOBMBMLJPH<LADONBJPHPE> IFMLIGBGOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private readonly MBOBMBMLJPH<LADONBJPHPE> KGBEDKIIHMK;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<LADONBJPHPE> IAHMDFBJECL
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A0A0", Offset = "0x5D388A0", VA = "0x185D3A0A0")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A100", Offset = "0x5D38900", VA = "0x185D3A100")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action<LADONBJPHPE> PNGKEPJNKLA
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A260", Offset = "0x5D38A60", VA = "0x185D3A260")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5D39FE0", Offset = "0x5D387E0", VA = "0x185D39FE0")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<LADONBJPHPE> OGICPKIMNND
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A040", Offset = "0x5D38840", VA = "0x185D3A040")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5D39F80", Offset = "0x5D38780", VA = "0x185D39F80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5D3A160", Offset = "0x5D38960", VA = "0x185D3A160", Slot = "31")]
	public override void OnDisconnected(LADONBJPHPE CJJNALPCMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5D3A2C0", Offset = "0x5D38AC0", VA = "0x185D3A2C0")]
	public LGKHOIPJHAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class DPPBKDFDBFF : HAFODBMMIFJ<EMCLNBMIAFK>, KHDBONJHAAE, PDDNIKFHLIC, CGHNPOGGIOM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct DGACNNMKMDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public DPPBKDFDBFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private CancellationToken <token>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5D30130", Offset = "0x5D2E930", VA = "0x185D30130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x840DA0", Offset = "0x83F5A0", VA = "0x180840DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class DOHNHOFNKLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public DPPBKDFDBFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public FJLCNICBIII actionContext;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public DOHNHOFNKLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5D32D20", Offset = "0x5D31520", VA = "0x185D32D20")]
		internal void NFDMLDPKCFD(ANHHFLMKBPC<string> timer, DGJIKJLGCCH log)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct IFODABFKGGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public AsyncTaskMethodBuilder<IReadOnlyDictionary<string, int>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public DPPBKDFDBFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private DOHNHOFNKLF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public TimeSpan? timeoutSpan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private ANHHFLMKBPC<string> <pingStackTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <pingTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private Stopwatch <sw>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private Dictionary<string, int> <regionPings>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private TaskAwaiter<BDGMFPCFLOK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private YieldAwaitable.YieldAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x5D35830", Offset = "0x5D34030", VA = "0x185D35830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x5D37970", Offset = "0x5D36170", VA = "0x185D37970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private CancellationTokenSource JPCOPEAFBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private CancellationTokenSource FPLEAAODGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private CancellationToken? OEMMOEMCDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private bool BNAHPDDAMGO;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool DDMIIFCEEIL
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6E0", Offset = "0x7F8EE0", VA = "0x1807FA6E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x5D32EA0", Offset = "0x5D316A0", VA = "0x185D32EA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5D33000", Offset = "0x5D31800", VA = "0x185D33000", Slot = "13")]
	public override bool JPKMJKCCEMO(ENGKFENENDE BKLIDCPKLEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5D33610", Offset = "0x5D31E10", VA = "0x185D33610")]
	[Preserve]
	public DPPBKDFDBFF([KEKICHOEFEB(null)] EMCLNBMIAFK JIAGCNOOLAE, [KEKICHOEFEB(null)] LPPGHONKDIF IDBBFLOCDDC, [KEKICHOEFEB(null)] ICFKNDAFIME DMJAOAPOMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5D336C0", Offset = "0x5D31EC0", VA = "0x185D336C0")]
	internal DPPBKDFDBFF(EMCLNBMIAFK JIAGCNOOLAE, LPPGHONKDIF IDBBFLOCDDC, ICFKNDAFIME DMJAOAPOMIP, MHOHFOIHKFE BGOBHFLGNJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5D32F70", Offset = "0x5D31770", VA = "0x185D32F70", Slot = "17")]
	protected override void JCDFHDNLEBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5D33530", Offset = "0x5D31D30", VA = "0x185D33530")]
	private void NHHIFPNMOEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5D330E0", Offset = "0x5D318E0", VA = "0x185D330E0", Slot = "16")]
	protected override void KLBCGDANBIG(ENGKFENENDE JENLPPBJFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5D333E0", Offset = "0x5D31BE0", VA = "0x185D333E0", Slot = "14")]
	protected override void MKCAFOAJMFB(FJLCNICBIII GOGGOGPMKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5D33060", Offset = "0x5D31860", VA = "0x185D33060", Slot = "15")]
	protected override void KJBDPOEGHEM(FJLCNICBIII GOGGOGPMKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5D32DF0", Offset = "0x5D315F0", VA = "0x185D32DF0")]
	[AsyncStateMachine(typeof(DGACNNMKMDA))]
	private void BHNDNBPFLEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5D332B0", Offset = "0x5D31AB0", VA = "0x185D332B0", Slot = "18")]
	[AsyncStateMachine(typeof(IFODABFKGGH))]
	public Task<IReadOnlyDictionary<string, int>> KLEJFNIAAFJ([Optional] TimeSpan? FKGFIGDIAOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class ENGKFENENDE : BDGMFPCFLOK, IEquatable<ENGKFENENDE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public readonly string BJEAFINJMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly string? GHEMKIHFDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public readonly string? PDLHJGOIALN;

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x5D346C0", Offset = "0x5D32EC0", VA = "0x185D346C0")]
	public ENGKFENENDE(string IFANLFPPKPH, string CKFBLFIPANL, string BIFJEJELICM, string? CPJNIAMFGDL, string KFMOHHOJLMP, string IEKFPPBBHHC, string? EONNDCGKPPP, string? CHKBAEGNLKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5D34660", Offset = "0x5D32E60", VA = "0x185D34660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5D344A0", Offset = "0x5D32CA0", VA = "0x185D344A0", Slot = "5")]
	public bool Equals(ENGKFENENDE? IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5D34380", Offset = "0x5D32B80", VA = "0x185D34380", Slot = "0")]
	public override bool Equals(object? CBBCDNDPNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5D34520", Offset = "0x5D32D20", VA = "0x185D34520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x1AFAFF0", Offset = "0x1AF97F0", VA = "0x181AFAFF0")]
	public static bool BIBGNMIHGGC(ENGKFENENDE? PEEDIPGMMHL, ENGKFENENDE? PEFIBHOJLKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x141DF10", Offset = "0x141C710", VA = "0x18141DF10")]
	public static bool LBEMCIDNPGP(ENGKFENENDE? PEEDIPGMMHL, ENGKFENENDE? PEFIBHOJLKB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class BDGMFPCFLOK : IEquatable<BDGMFPCFLOK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public readonly string CPJLHNPOCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public readonly string? BKDLICNFPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public readonly string? CCKJCEJCDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public readonly string? KEIEEJLPLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public readonly string JFHFMBOBAFD;

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FC10", Offset = "0x5D2E410", VA = "0x185D2FC10")]
	public BDGMFPCFLOK(string IFANLFPPKPH, string? CKFBLFIPANL, string? BIFJEJELICM, string? CPJNIAMFGDL, string KFMOHHOJLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FBB0", Offset = "0x5D2E3B0", VA = "0x185D2FBB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F950", Offset = "0x5D2E150", VA = "0x185D2F950", Slot = "4")]
	public bool Equals(BDGMFPCFLOK? IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F9E0", Offset = "0x5D2E1E0", VA = "0x185D2F9E0", Slot = "0")]
	public override bool Equals(object? CBBCDNDPNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FAC0", Offset = "0x5D2E2C0", VA = "0x185D2FAC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class JHDHKHALCMN : HAFODBMMIFJ<JHDHKHALCMN.EAJCHLNHION>
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public interface LMNJDIKLHLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool MGDEOEEHAEM();
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class EAJCHLNHION : GDMHDAAKABH, FFJNDGBCJKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private NCPEHMNDMGE EGPAGAAEGAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private bool ECKIIJEJPKM;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		private PhotonVoiceNetwork KEEBCILDHNI
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x5D33C30", Offset = "0x5D32430", VA = "0x185D33C30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool AKDPNBPLAKO
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xC565E0", Offset = "0xC54DE0", VA = "0x180C565E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public NCPEHMNDMGE OMFBJGACMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool NDFLLOOKAHC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x5D33880", Offset = "0x5D32080", VA = "0x185D33880", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool CNJFMDCFCGA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x5D34220", Offset = "0x5D32A20", VA = "0x185D34220", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x76E4A0", Offset = "0x76CCA0", VA = "0x18076E4A0", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool AFAPDHIEGLI
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool BBGGDANMMGG
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x5D338D0", Offset = "0x5D320D0", VA = "0x185D338D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public MCINOFGOPIN JMJAPBGMLJN
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x5D33B50", Offset = "0x5D32350", VA = "0x185D33B50", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool GMLOIJNEKFL
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5D33770", Offset = "0x5D31F70", VA = "0x185D33770", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<NCPEHMNDMGE, NCPEHMNDMGE> KEPFIDIOCBC
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x5D34070", Offset = "0x5D32870", VA = "0x185D34070", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x5D33CE0", Offset = "0x5D324E0", VA = "0x185D33CE0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<bool> FICLFLDINIH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x5D342B0", Offset = "0x5D32AB0", VA = "0x185D342B0", Slot = "9")]
		public void PNIOAFLHPKJ(NCNPIPEEFLG GJADJJCIBCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x5D33D90", Offset = "0x5D32590", VA = "0x185D33D90", Slot = "16")]
		public bool KPLPHLIGDMG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x5D33EC0", Offset = "0x5D326C0", VA = "0x185D33EC0", Slot = "17")]
		public bool LNCHDKAILIL(string IEKFPPBBHHC, FAOJMAKOAPP LIBEOECBKPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5D33920", Offset = "0x5D32120", VA = "0x185D33920", Slot = "18")]
		public void ELIKLHPLONE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x5D33A20", Offset = "0x5D32220", VA = "0x185D33A20", Slot = "19")]
		public bool FECOBPHGMGJ(AppSettings PLMDHCPMLFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "22")]
		public void MGMAPGDJJJC(object KIAKEGJPMAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "23")]
		public void HLGFKJEEIPJ(object KIAKEGJPMAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "24")]
		public void MHNAAFJKBNJ(object KIAKEGJPMAL, bool FMGPAPMCAKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x5D33C90", Offset = "0x5D32490", VA = "0x185D33C90", Slot = "25")]
		public IDisposable IIBDMBHPIEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "26")]
		private bool LILMIMICBAM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "27")]
		public void CKMJOOFKAPL(StringBuilder ICLBMBEPLED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5D34120", Offset = "0x5D32920", VA = "0x185D34120", Slot = "28")]
		public bool NBFECOLKNEG(bool FDFNKHKIJFI, [Out] string HLPKEEDLIBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public EAJCHLNHION()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct NBCAOJDGMDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public JHDHKHALCMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public DPPBKDFDBFF clientToFollow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private TaskAwaiter<ENGKFENENDE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A520", Offset = "0x5D38D20", VA = "0x185D3A520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A830", Offset = "0x5D39030", VA = "0x185D3A830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct BOMNNFMFBHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public JHDHKHALCMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x5D2FD60", Offset = "0x5D2E560", VA = "0x185D2FD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5D300D0", Offset = "0x5D2E8D0", VA = "0x185D300D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private readonly DPPBKDFDBFF GKGPAAMEJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private readonly LMNJDIKLHLA PHFGEGEBKLK;

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x5D387F0", Offset = "0x5D36FF0", VA = "0x185D387F0", Slot = "13")]
	public override bool JPKMJKCCEMO(ENGKFENENDE BKLIDCPKLEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5D38A40", Offset = "0x5D37240", VA = "0x185D38A40")]
	[Preserve]
	public JHDHKHALCMN([KEKICHOEFEB(null)] DPPBKDFDBFF GKGPAAMEJDN, [KEKICHOEFEB(null)] LPPGHONKDIF IDBBFLOCDDC, [KEKICHOEFEB(null)] LMNJDIKLHLA PHFGEGEBKLK, [KEKICHOEFEB(null)] ICFKNDAFIME DMJAOAPOMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5D38630", Offset = "0x5D36E30", VA = "0x185D38630")]
	private Task JOGDPLBPCNM(LADONBJPHPE CJJNALPCMIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5D38880", Offset = "0x5D37080", VA = "0x185D38880")]
	[AsyncStateMachine(typeof(NBCAOJDGMDB))]
	public Task KENIHFBODFH(DPPBKDFDBFF OPIOKHAILEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5D385B0", Offset = "0x5D36DB0", VA = "0x185D385B0")]
	[CompilerGenerated]
	internal static void JAEOGHANMAB(NCPEHMNDMGE NHGLLPKLPMG, NCPEHMNDMGE IJAEPCHBBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5D38970", Offset = "0x5D37170", VA = "0x185D38970")]
	[AsyncStateMachine(typeof(BOMNNFMFBHE))]
	[CompilerGenerated]
	private Task OEOAFLHPDDG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[Preserve]
public class EFAFLAIGNEB
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	[Preserve]
	[JsonProperty(PropertyName = "AI", Required = Required.Always)]
	public string AccountId
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x766300", Offset = "0x764B00", VA = "0x180766300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	[JsonProperty(PropertyName = "AT", Required = Required.Always)]
	[Preserve]
	public byte[] AccessToken
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x766130", Offset = "0x764930", VA = "0x180766130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[Preserve]
	[JsonProperty(PropertyName = "VB", Required = Required.Always)]
	public byte[] VerificationBlob
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x7662F0", Offset = "0x764AF0", VA = "0x1807662F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x765D00", Offset = "0x764500", VA = "0x180765D00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x766120", Offset = "0x764920", VA = "0x180766120")]
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
		[Cpp2IlInjected.Address(RVA = "0x76B5B0", Offset = "0x769DB0", VA = "0x18076B5B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x76BD00", Offset = "0x76A500", VA = "0x18076BD00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	[JsonProperty(PropertyName = "CPK", Required = Required.Always)]
	[Preserve]
	public byte[] ClientPublicKey
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7660F0", Offset = "0x7648F0", VA = "0x1807660F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x76E4B0", Offset = "0x76CCB0", VA = "0x18076E4B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public EFAFLAIGNEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[Preserve]
public class OEIJIJGIOKE
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	[Preserve]
	[JsonProperty(PropertyName = "DR", Required = Required.Always)]
	public string Reason
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x766300", Offset = "0x764B00", VA = "0x180766300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[Preserve]
	[JsonProperty(PropertyName = "KT", Required = Required.Default)]
	public byte[] SessionKeyB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x766130", Offset = "0x764930", VA = "0x180766130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public OEIJIJGIOKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class PIKMCHHMNCL : PDDNIKFHLIC, CGHNPOGGIOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public enum HFENKAKKNMD
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
	private NetworkManager GAGKICGAJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private TaskCompletionSource<ENGKFENENDE> OLNJLJOEOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	protected readonly LPPGHONKDIF PCPPOFHPCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private readonly HashSet<CMMNHJHICGF> IIGLKEDDBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public HFENKAKKNMD IMKIDBEGMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private ENGKFENENDE BKLIDCPKLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private RSACryptoServiceProvider BIMGONDPAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private RSACryptoServiceProvider MOHMHLKECOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private AesCryptoServiceProvider KCAIEJOEJID;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public ENGKFENENDE BKAELLFMGNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7660F0", Offset = "0x7648F0", VA = "0x1807660F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public string OJDJBJBDPCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5D3BEF0", Offset = "0x5D3A6F0", VA = "0x185D3BEF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Task BFEBILADLEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5D3BF20", Offset = "0x5D3A720", VA = "0x185D3BF20", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5D3B230", Offset = "0x5D39A30", VA = "0x185D3B230", Slot = "10")]
	public void BGDGBNGCKDD(CMMNHJHICGF MPPKBKKNPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5D3BF70", Offset = "0x5D3A770", VA = "0x185D3BF70", Slot = "6")]
	public bool JPKMJKCCEMO(ENGKFENENDE BKLIDCPKLEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x5D3D350", Offset = "0x5D3BB50", VA = "0x185D3D350")]
	[Preserve]
	public PIKMCHHMNCL([KEKICHOEFEB(null)] LPPGHONKDIF FDMLFCELGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x5D3D180", Offset = "0x5D3B980", VA = "0x185D3D180")]
	private void ODICLNLDDED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5D3CCF0", Offset = "0x5D3B4F0", VA = "0x185D3CCF0")]
	private void NCKBKKCCNKL(ulong CBBCDNDPNHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5D3BFB0", Offset = "0x5D3A7B0", VA = "0x185D3BFB0")]
	private void KADCLOHLDLN(ulong CBBCDNDPNHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5D3BCD0", Offset = "0x5D3A4D0", VA = "0x185D3BCD0")]
	private void GLGMEKIFDJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5D3CC80", Offset = "0x5D3B480", VA = "0x185D3CC80")]
	private void MDFBEFEOFHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5D3B290", Offset = "0x5D39A90", VA = "0x185D3B290")]
	private void CCPBCBHLGEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5D3BDC0", Offset = "0x5D3A5C0", VA = "0x185D3BDC0")]
	private static (IPAddress, ushort) ICKDJDNFNBE(string MNCEINFJHAP)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5D3C570", Offset = "0x5D3AD70", VA = "0x185D3C570")]
	private void KKKKDFEHHGE(ENGKFENENDE EJCHIKHAGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5D3B500", Offset = "0x5D39D00", VA = "0x185D3B500", Slot = "8")]
	public Task<ENGKFENENDE> CHDNBFLEOJK(ENGKFENENDE BKLIDCPKLEM, object LLNAJFDAEHL, [Optional] CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5D3BB70", Offset = "0x5D3A370", VA = "0x185D3BB70", Slot = "7")]
	public Task ELIKLHPLONE([Optional] CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5D3D020", Offset = "0x5D3B820", VA = "0x185D3D020", Slot = "9")]
	public Task NINEIKMEAAE([Optional] CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class KDLMBOMCKPN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5D39340", Offset = "0x5D37B40", VA = "0x185D39340")]
	public KDLMBOMCKPN(string BKGEBGGPBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5D392D0", Offset = "0x5D37AD0", VA = "0x185D392D0")]
	public KDLMBOMCKPN(string BKGEBGGPBLH, Exception MKHOFBPNAEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class MDCLFJBPIJC : KDLMBOMCKPN
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5D3A3D0", Offset = "0x5D38BD0", VA = "0x185D3A3D0")]
	public MDCLFJBPIJC([NotNull] Exception MKHOFBPNAEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class JHACELOLIKP : KDLMBOMCKPN
{
	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5D38530", Offset = "0x5D36D30", VA = "0x185D38530")]
	public JHACELOLIKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class FLKEKHDJFGN : KDLMBOMCKPN
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5D350A0", Offset = "0x5D338A0", VA = "0x185D350A0")]
	public FLKEKHDJFGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public static class KHCDCLLKGCF
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private static AesCryptoServiceProvider CMGKJGBLIFD;

	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private static readonly string[] PHKPMHMDBAG;

	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private static readonly string[] OFPIPHEDCKE;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private static readonly string[] NNJEIMHFNHP;

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5D393A0", Offset = "0x5D37BA0", VA = "0x185D393A0")]
	public static string BFDPJMFNGGO(ulong KNCOEFOICAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5D39410", Offset = "0x5D37C10", VA = "0x185D39410")]
	public static string BLDBKHLBMAN(ulong KNCOEFOICAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5D39480", Offset = "0x5D37C80", VA = "0x185D39480")]
	public static AesCryptoServiceProvider DIFIDIJCOBL()
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

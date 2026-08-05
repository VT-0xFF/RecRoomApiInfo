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
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5B1E920", Offset = "0x5B1D720", VA = "0x185B1E920")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x75C880", Offset = "0x75B680", VA = "0x18075C880")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA7DB60", Offset = "0xA7C960", VA = "0x180A7DB60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DKLPLIEJEOP : AJLMIBDFIDI, GEAKAOKNMKF, GPAICHBCLGN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GGIMGIKPIKL : FMECLAKOLIL
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class MPHJJKJHECA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Action onCompleteCallback;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
			public MPHJJKJHECA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x29200F0", Offset = "0x291EEF0", VA = "0x1829200F0")]
			internal void <PingMinimumOfRegions>b__0(GHHFMKINOKJ rh)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool FODIEKBGGNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5B18F80", Offset = "0x5B17D80", VA = "0x185B18F80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool PGCAJGLOMBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5B19130", Offset = "0x5B17F30", VA = "0x185B19130", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public IReadOnlyList<PLBOBFPJMJG> BFGJAFFNHJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5B18E60", Offset = "0x5B17C60", VA = "0x185B18E60", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5B18FF0", Offset = "0x5B17DF0", VA = "0x185B18FF0", Slot = "7")]
		public bool PENCBOPLOIA(Action NMNGGLIJMCG, string IOABDFFDDCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public GGIMGIKPIKL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private CADEDDJAMPA FMKOPGBEAOI;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly byte[] PPAGCCNNEJP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override bool IKCCAPOMODG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x92D5F0", Offset = "0x92C3F0", VA = "0x18092D5F0", Slot = "78")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override CADEDDJAMPA LECKGBDDAPP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x757910", Offset = "0x756710", VA = "0x180757910", Slot = "79")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override bool NOEFIENPGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5B17E80", Offset = "0x5B16C80", VA = "0x185B17E80", Slot = "80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override bool NGHDPPIFAIK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5B17960", Offset = "0x5B16760", VA = "0x185B17960", Slot = "59")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5B16B20", Offset = "0x5B15920", VA = "0x185B16B20", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override float HNJILEHCBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5B17A00", Offset = "0x5B16800", VA = "0x185B17A00", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override FMECLAKOLIL LHNJGLKGGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7578A0", Offset = "0x7566A0", VA = "0x1807578A0", Slot = "75")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override bool EOHKOGNKOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5B17840", Offset = "0x5B16640", VA = "0x185B17840", Slot = "81")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5B173E0", Offset = "0x5B161E0", VA = "0x185B173E0", Slot = "82")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override bool FHJLLNOECIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5B17CE0", Offset = "0x5B16AE0", VA = "0x185B17CE0", Slot = "83")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool KPFDOHJDJJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5B17F50", Offset = "0x5B16D50", VA = "0x185B17F50", Slot = "84")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override FBALGABFPOI EFJBADCCPCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5B17040", Offset = "0x5B15E40", VA = "0x185B17040", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override int PAKGAOCMDMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5B17AE0", Offset = "0x5B168E0", VA = "0x185B17AE0", Slot = "62")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override int LDFODEFICAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5B16DF0", Offset = "0x5B15BF0", VA = "0x185B16DF0", Slot = "63")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override ECDFOCMBGHG PAACCJIGOEA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5B16E70", Offset = "0x5B15C70", VA = "0x185B16E70", Slot = "64")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int AMJAJFPDLBP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5B175D0", Offset = "0x5B163D0", VA = "0x185B175D0", Slot = "65")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public override int MDCDLEALGFF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5B17A60", Offset = "0x5B16860", VA = "0x185B17A60", Slot = "66")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public override event GAIOIIDEJOE HIIHJJPFKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5B177A0", Offset = "0x5B165A0", VA = "0x185B177A0", Slot = "55")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5B17C40", Offset = "0x5B16A40", VA = "0x185B17C40", Slot = "56")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public override event Action<ECDFOCMBGHG> PNLMCCJKCBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5B17340", Offset = "0x5B16140", VA = "0x185B17340", Slot = "57")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5B16C80", Offset = "0x5B15A80", VA = "0x185B16C80", Slot = "58")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public override event Action<CADEDDJAMPA, CADEDDJAMPA> OLGABNIJJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5B17530", Offset = "0x5B16330", VA = "0x185B17530", Slot = "76")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5B170A0", Offset = "0x5B15EA0", VA = "0x185B170A0", Slot = "77")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5B17B60", Offset = "0x5B16960", VA = "0x185B17B60", Slot = "88")]
	public override void MDCFEKLHJHB(DLJDIJKODNL DMOEEMEOPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5B17440", Offset = "0x5B16240", VA = "0x185B17440")]
	[CFDOMFEMHNO(ANAFFCEINAM.GameOnly)]
	private static void HGNLLPENNMP(GMLHNNIDAIC IPJNDIBMKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5B180D0", Offset = "0x5B16ED0", VA = "0x185B180D0")]
	[Preserve]
	public DKLPLIEJEOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5B17ED0", Offset = "0x5B16CD0", VA = "0x185B17ED0")]
	private void OINEENLGBPJ(bool KIDOHGEOCMD, bool FJODNMEGNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5B16D20", Offset = "0x5B15B20", VA = "0x185B16D20", Slot = "67")]
	[CanBeNull]
	public override ECDFOCMBGHG CLLNDGLEOPP(int BKNOAMJJOPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5B16BD0", Offset = "0x5B159D0", VA = "0x185B16BD0")]
	private static short BJMPNJPINMH(StreamBuffer NDDBNIPPLLA, object NJBBMOOMNDO)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5B17140", Offset = "0x5B15F40", VA = "0x185B17140")]
	private static object FAHCBBLHHPK(StreamBuffer AENOHJPHCLA, short PFLGNDMCMIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5B16F10", Offset = "0x5B15D10", VA = "0x185B16F10", Slot = "97")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5B17630", Offset = "0x5B16430", VA = "0x185B17630", Slot = "68")]
	public override bool IJDBFHLPLGB(AppSettings OAJFDBGIMNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5B18020", Offset = "0x5B16E20", VA = "0x185B18020", Slot = "69")]
	public override void PPKLBAECIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5B17D20", Offset = "0x5B16B20", VA = "0x185B17D20", Slot = "70")]
	public override bool MGJLPMLIAAA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5B16B80", Offset = "0x5B15980", VA = "0x185B16B80", Slot = "71")]
	public override void AMCCCMGKCHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5B178E0", Offset = "0x5B166E0", VA = "0x185B178E0", Slot = "72")]
	public override bool KBJPMBEOGNN(byte PLFGLKLLFNF, Hashtable JFNKHGDIIEM, OHJCMMIIADA IHGPCCMNLBJ, SendOptions FNBAAGLGPAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5B172C0", Offset = "0x5B160C0", VA = "0x185B172C0", Slot = "86")]
	public override bool GEKFKOPEGME(string FFMOFPMPOHB, BLCEEOKIMAG FBDACBNJEHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5B17690", Offset = "0x5B16490", VA = "0x185B17690", Slot = "87")]
	public override void ILFLDBCFEKE(string GJICLDEGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5B17FA0", Offset = "0x5B16DA0", VA = "0x185B17FA0", Slot = "91")]
	public void OnEvent(EventData EIADGBGLAJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "92")]
	public void OnPlayerEnteredRoom(LKFKEMBCBJC ADKGFIEICJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "93")]
	public void OnPlayerLeftRoom(LKFKEMBCBJC IEBOBJAEOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "94")]
	public void OnRoomPropertiesUpdate(Hashtable CBDABLCNHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "95")]
	public void OnPlayerPropertiesUpdate(LKFKEMBCBJC FMIKKBMBNHI, Hashtable BLHHIFEDDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5B16EC0", Offset = "0x5B15CC0", VA = "0x185B16EC0", Slot = "96")]
	private void DMIOAJGLLIP(LKFKEMBCBJC OCFOPBHEABO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface NHDLJMJKKPB : OELMMPOJFHN, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OELMMPOJFHN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	GONJJJGFLNJ PIMCKADBKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string HNOLKAKJBJL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	Task PJBIJLJDNGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GNLNDNKALCF(GONJJJGFLNJ IBHKJDDBFAL);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task PPKLBAECIEH([Optional] CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<GONJJJGFLNJ> GEGLBFAACEA(GONJJJGFLNJ IBHKJDDBFAL, object MLHNCMAKIOC, [Optional] CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task PPODHDNDJOH([Optional] CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JLAENJNHADN(ACMOIGHLHJL IONPGPAMBFG);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface AFFJFDPLBNL
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OOPCIMOIODK(ushort ECNEOLCEGAE, FFKLPFJKNDH CLHAFKEEGIP, params object[] EJEDIPFPCCK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal enum FFKLPFJKNDH
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
public interface DCDAEJDLCNO : OELMMPOJFHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	MJOBGOOJHML EEPNBGMBDIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MJOBGOOJHML : NHDLJMJKKPB, OELMMPOJFHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyDictionary<string, int>> BAABJPKJIBI([Optional] TimeSpan? BGFDACBDBID);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ICNBEOMJLKN
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool MFFCEIDDAHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	TimeSpan PKJMMLKJMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	TimeSpan LLPMEMDLEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AppSettings GBFOADGJGDJ(DGHAAGPFHHI HMEMCGDMOGB);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FBALGABFPOI KGHEAELKAGE(DGHAAGPFHHI HMEMCGDMOGB);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<DGHAAGPFHHI> HBCPCEDIKNO(CancellationToken NBLKBHANAPP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class JPIBPMFFBMB : LBDOJFHALMH, GPAICHBCLGN, IEOFPIMKJPB, KCDPHJBOJJO, EBAJIAPIFGL, BJIGNJPFPPK, KEFNFHFMNML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly string GHFCIPHCDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public CJIPBGMKILF PEICCDFCKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public CJIPBGMKILF FOHCJNBHLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public global::JDKDAIPFIPL<OAAKIMBOCHL> KJJMNCCCBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public CJIPBGMKILF HOJMHCHBOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public global::JDKDAIPFIPL<string> BDMHCJICFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public global::JDKDAIPFIPL<Dictionary<string, object>> DIGPMHIPMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public global::JDKDAIPFIPL<OAAKIMBOCHL> OMPLDJBOFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public global::LEPJFHFGLAL<bool, bool> DKGBGINKIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public CJIPBGMKILF EANINBBDEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public CJIPBGMKILF IKKPCMLLJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public CJIPBGMKILF LHMJKPJIIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public CJIPBGMKILF MHDCJFBKAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public CJIPBGMKILF PBGMOLENJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public global::JDKDAIPFIPL<LKFKEMBCBJC> PAHGIAGBJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public global::LEPJFHFGLAL<PhotonView, LKFKEMBCBJC> HGHOCICDKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public global::GPMIOKNMCFC<PhotonView, LKFKEMBCBJC, LKFKEMBCBJC> LGLEOFNIAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public global::LEPJFHFGLAL<short, string> PBPPEBFBAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public global::JDKDAIPFIPL<Hashtable> JHDEPLIPFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public global::JDKDAIPFIPL<CMCFEOONABN> AMFCNFJKLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public global::LEPJFHFGLAL<short, string> MMPCJKDKOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public CJIPBGMKILF MABIAFFILKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public global::JDKDAIPFIPL<LKFKEMBCBJC> BBDNANIDJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public global::JDKDAIPFIPL<LKFKEMBCBJC> JGIKGBNHCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public global::LEPJFHFGLAL<LKFKEMBCBJC, Hashtable> GDLMKGOBACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public global::LEPJFHFGLAL<short, string> JIHOIBFBMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public CJIPBGMKILF DANLMHNNNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public CJIPBGMKILF HBKIENHDFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public global::JDKDAIPFIPL<OperationResponse> PLKCNCHCJME;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BC10", Offset = "0x5B1AA10", VA = "0x185B1BC10", Slot = "30")]
	public virtual void OnDisconnected(OAAKIMBOCHL NJKKJCCKJKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x123F520", Offset = "0x123E320", VA = "0x18123F520", Slot = "4")]
	public void OnConnected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BAC0", Offset = "0x5B1A8C0", VA = "0x185B1BAC0", Slot = "5")]
	public void OnConnectedToMaster()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "7")]
	public void OnRegionListReceived(GHHFMKINOKJ MNEKFENJMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BBC0", Offset = "0x5B1A9C0", VA = "0x185B1BBC0", Slot = "8")]
	public void OnCustomAuthenticationResponse(Dictionary<string, object> MMJOHADFCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BB70", Offset = "0x5B1A970", VA = "0x185B1BB70", Slot = "9")]
	public void OnCustomAuthenticationFailed(string AJOOMGDGNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BE00", Offset = "0x5B1AC00", VA = "0x185B1BE00", Slot = "10")]
	public void OnPlayerEnteredRoom(LKFKEMBCBJC ADKGFIEICJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BE60", Offset = "0x5B1AC60", VA = "0x185B1BE60", Slot = "11")]
	public void OnPlayerLeftRoom(LKFKEMBCBJC IEBOBJAEOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BF30", Offset = "0x5B1AD30", VA = "0x185B1BF30", Slot = "12")]
	public void OnRoomPropertiesUpdate(Hashtable CBDABLCNHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BEC0", Offset = "0x5B1ACC0", VA = "0x185B1BEC0", Slot = "13")]
	public void OnPlayerPropertiesUpdate(LKFKEMBCBJC FMIKKBMBNHI, Hashtable BLHHIFEDDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BDA0", Offset = "0x5B1ABA0", VA = "0x185B1BDA0", Slot = "14")]
	public void OnMasterClientSwitched(LKFKEMBCBJC OCFOPBHEABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BD80", Offset = "0x5B1AB80", VA = "0x185B1BD80", Slot = "15")]
	public void OnJoinedLobby()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x13167C0", Offset = "0x13155C0", VA = "0x1813167C0", Slot = "16")]
	public void OnLeftLobby()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x123F290", Offset = "0x123E090", VA = "0x18123F290", Slot = "17")]
	public void OnRoomListUpdate(List<CBBCDMMJGGK> LLOFPFEACJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x123F160", Offset = "0x123DF60", VA = "0x18123F160", Slot = "18")]
	public void OnLobbyStatisticsUpdate(List<AFPCAGIPGFN> LJNLFMFJHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x123F2B0", Offset = "0x123E0B0", VA = "0x18123F2B0", Slot = "19")]
	public void OnFriendListUpdate(List<BPOFOKKJOFP> GNKGCFAILDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BB50", Offset = "0x5B1A950", VA = "0x185B1BB50", Slot = "20")]
	public void OnCreatedRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BAE0", Offset = "0x5B1A8E0", VA = "0x185B1BAE0", Slot = "21")]
	public void OnCreateRoomFailed(short PBPEBGCNCPN, string GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x13185B0", Offset = "0x13173B0", VA = "0x1813185B0", Slot = "22")]
	public void OnJoinedRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BD10", Offset = "0x5B1AB10", VA = "0x185B1BD10", Slot = "23")]
	public void OnJoinRoomFailed(short PBPEBGCNCPN, string GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BCA0", Offset = "0x5B1AAA0", VA = "0x185B1BCA0", Slot = "24")]
	public void OnJoinRandomFailed(short PBPEBGCNCPN, string GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x131B9A0", Offset = "0x131A7A0", VA = "0x18131B9A0", Slot = "25")]
	public void OnLeftRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5B1B950", Offset = "0x5B1A750", VA = "0x185B1B950", Slot = "29")]
	public void BNOBAEELLDL(CMCFEOONABN PFBGGFHJPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BA50", Offset = "0x5B1A850", VA = "0x185B1BA50", Slot = "26")]
	public void NFJKEPODKJP(PhotonView INJAGDNEPHH, LKFKEMBCBJC PAGIFHGDGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5B1B9C0", Offset = "0x5B1A7C0", VA = "0x185B1B9C0", Slot = "27")]
	public void GLJJAMPLJAB(PhotonView INJAGDNEPHH, LKFKEMBCBJC BDINNNBEJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BF90", Offset = "0x5B1AD90", VA = "0x185B1BF90", Slot = "28")]
	public void OnWebRpcResponse(OperationResponse FBLMHHGAGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BFF0", Offset = "0x5B1ADF0", VA = "0x185B1BFF0")]
	public JPIBPMFFBMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal static class DPBPHJNMGFC
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class LPGKGGEDPBA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Action<string, BMALNKMDMLE> log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CADEDDJAMPA networkClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool region;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public GKGHEGFGJEC photonCallbacks;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public LPGKGGEDPBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3A9D7B0", Offset = "0x3A9C5B0", VA = "0x183A9D7B0")]
		internal void <RegisterConnectionFailures>b__2(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class DIDOBKIOPOL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public JPIBPMFFBMB photonCallbacks;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public DIDOBKIOPOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2B05540", Offset = "0x2B04340", VA = "0x182B05540")]
		internal void <RegisterRoomJoinFailures>b__2(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x209EC10", Offset = "0x209DA10", VA = "0x18209EC10")]
	public static void BKNCFPFDLMK<T>(this GKGHEGFGJEC FOKNBEFOFJA, TaskCompletionSource<T> CDMHJAEBELL, [NotNull] CADEDDJAMPA LHLEOLFHDAI, BMALNKMDMLE FCOCNKHPKHM, bool KBPJOCOAHLD, Action<string, BMALNKMDMLE> EKOKIILLNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x209F250", Offset = "0x209E050", VA = "0x18209F250")]
	public static void OGHNBKDOJAH<T>(this JPIBPMFFBMB FOKNBEFOFJA, TaskCompletionSource<T> CDMHJAEBELL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class DIHPPILHIFK<TNetworking> : NHDLJMJKKPB, OELMMPOJFHN, IDisposable where TNetworking : class, IOABGKDGANE, MBMPIPGPDDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class GJABANDFMNM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private struct <<ConnectToRegionInternal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public AsyncTaskMethodBuilder<DGHAAGPFHHI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public GJABANDFMNM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private TaskAwaiter<DGHAAGPFHHI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x1D03710", Offset = "0x1D02510", VA = "0x181D03710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1D03A10", Offset = "0x1D02810", VA = "0x181D03A10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public DGHAAGPFHHI photonServerConnectionInfo;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public GJABANDFMNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x32D32E0", Offset = "0x32D20E0", VA = "0x1832D32E0")]
		[AsyncStateMachine(typeof(global::DIHPPILHIFK<>.GJABANDFMNM.<<ConnectToRegionInternal>b__0>d))]
		internal Task<DGHAAGPFHHI> <ConnectToRegionInternal>b__0(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct OAJILJFFHPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public AsyncTaskMethodBuilder<DGHAAGPFHHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public DGHAAGPFHHI photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private GJABANDFMNM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private TaskAwaiter<DGHAAGPFHHI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x2C4EA20", Offset = "0x2C4D820", VA = "0x182C4EA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2C4F530", Offset = "0x2C4E330", VA = "0x182C4F530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct MEKBNDCDJFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public AsyncTaskMethodBuilder<DGHAAGPFHHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public DGHAAGPFHHI photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2CEDFA0", Offset = "0x2CECDA0", VA = "0x182CEDFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x2CEEB10", Offset = "0x2CED910", VA = "0x182CEEB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct FGKFMGLIODK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x2A67AA0", Offset = "0x2A668A0", VA = "0x182A67AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct HOFHDCBFBJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private BMALNKMDMLE <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3E0CB90", Offset = "0x3E0B990", VA = "0x183E0CB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class CAIPIDKCCEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public CAIPIDKCCEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x31654C0", Offset = "0x31642C0", VA = "0x1831654C0")]
		internal Task<bool> <DisconnectInternal>b__0(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct DGKMENNODBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private CAIPIDKCCEH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool <isCurrentlyOfflineMode>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x4CAEF90", Offset = "0x4CADD90", VA = "0x184CAEF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class NOPABCPFJNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public TaskCompletionSource<OAAKIMBOCHL> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public NOPABCPFJNL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct HMDMBGIDHPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private NOPABCPFJNL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private TaskAwaiter<OAAKIMBOCHL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x35F10C0", Offset = "0x35EFEC0", VA = "0x1835F10C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x35F23B0", Offset = "0x35F11B0", VA = "0x1835F23B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct GINLOANOCFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public AsyncTaskMethodBuilder<GONJJJGFLNJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public GONJJJGFLNJ targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private BMALNKMDMLE <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter<GONJJJGFLNJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x32D2820", Offset = "0x32D1620", VA = "0x1832D2820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x32D3290", Offset = "0x32D2090", VA = "0x1832D3290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class MCDONJNEDAO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private struct <<ConnectToRoomInstanceInternal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public AsyncTaskMethodBuilder<GONJJJGFLNJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public MCDONJNEDAO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private TaskAwaiter<GONJJJGFLNJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x1D03A60", Offset = "0x1D02860", VA = "0x181D03A60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x1D03D80", Offset = "0x1D02B80", VA = "0x181D03D80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public GONJJJGFLNJ targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public object pauseToken;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public MCDONJNEDAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2CDCAB0", Offset = "0x2CDB8B0", VA = "0x182CDCAB0")]
		[AsyncStateMachine(typeof(global::DIHPPILHIFK<>.MCDONJNEDAO.<<ConnectToRoomInstanceInternal>b__0>d))]
		internal Task<GONJJJGFLNJ> <ConnectToRoomInstanceInternal>b__0(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct OELBMPJDMFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder<GONJJJGFLNJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public GONJJJGFLNJ targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private MCDONJNEDAO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private TaskAwaiter<GONJJJGFLNJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3B4B430", Offset = "0x3B4A230", VA = "0x183B4B430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3B4C110", Offset = "0x3B4AF10", VA = "0x183B4C110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class PHLMEHIGMPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public TaskCompletionSource<NJPHLGJHJOE> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public PHLMEHIGMPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x200B350", Offset = "0x200A150", VA = "0x18200B350")]
		internal void <ConnectToRoomInstanceInternalTask>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x200B3D0", Offset = "0x200A1D0", VA = "0x18200B3D0")]
		internal void <ConnectToRoomInstanceInternalTask>b__2()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct DBNJAILILBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public AsyncTaskMethodBuilder<GONJJJGFLNJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public GONJJJGFLNJ targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private PHLMEHIGMPE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private BLCEEOKIMAG <roomOptions>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private TaskAwaiter<DGHAAGPFHHI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter<NJPHLGJHJOE> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x36CE860", Offset = "0x36CD660", VA = "0x1836CE860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x36D0710", Offset = "0x36CF510", VA = "0x1836D0710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct IFMICPAAMMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Task<GABJJGKGDOH> whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private TaskAwaiter<GABJJGKGDOH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x1E01440", Offset = "0x1E00240", VA = "0x181E01440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x74B100", Offset = "0x749F00", VA = "0x18074B100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct OBOMEPPBMAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3B3EE70", Offset = "0x3B3DC70", VA = "0x183B3EE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct NKJKIKPBODP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private BMALNKMDMLE <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x36FADE0", Offset = "0x36F9BE0", VA = "0x1836FADE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct BHPEBOOHPNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2C96E50", Offset = "0x2C95C50", VA = "0x182C96E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class CBJFBJGMEIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public CBJFBJGMEIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3167690", Offset = "0x3166490", VA = "0x183167690")]
		internal Task<GABJJGKGDOH> <DisconnectFromRoomInstanceInternal>b__0(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct GEICNDMBLOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private CBJFBJGMEIK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private TaskAwaiter<GABJJGKGDOH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x32C6450", Offset = "0x32C5250", VA = "0x1832C6450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class HAFNFEILCDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public TaskCompletionSource<NJPHLGJHJOE> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public HAFNFEILCDG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class KBAHNDFFHAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public TaskCompletionSource<NJPHLGJHJOE> reconnectToMasterServerTcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public HAFNFEILCDG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public KBAHNDFFHAE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct PHALFMCGNCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public AsyncTaskMethodBuilder<GABJJGKGDOH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private HAFNFEILCDG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private KBAHNDFFHAE <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private TaskAwaiter<NJPHLGJHJOE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2008D00", Offset = "0x2007B00", VA = "0x182008D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x200AAE0", Offset = "0x20098E0", VA = "0x18200AAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class MKBKEKJKFOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public TaskCompletionSource<NJPHLGJHJOE> reconnectToMasterServerTcs;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public MKBKEKJKFOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x30D2350", Offset = "0x30D1150", VA = "0x1830D2350")]
		internal string <WaitForStableState>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct LEDKADHNPFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public AsyncTaskMethodBuilder<NJPHLGJHJOE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private MKBKEKJKFOI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private TaskAwaiter<NJPHLGJHJOE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x284E220", Offset = "0x284D020", VA = "0x18284E220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x284ED20", Offset = "0x284DB20", VA = "0x18284ED20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct MGCBFIAKKOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2CF5900", Offset = "0x2CF4700", VA = "0x182CF5900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x74B100", Offset = "0x749F00", VA = "0x18074B100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct AJIBFHGMEDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x24E0330", Offset = "0x24DF130", VA = "0x1824E0330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct BGJAIKOAFLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public OAAKIMBOCHL disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private PGALOEFPGPI <exception>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2C91700", Offset = "0x2C90500", VA = "0x182C91700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x74B100", Offset = "0x749F00", VA = "0x18074B100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct JLEHMGMBFKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public OAAKIMBOCHL disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private HashSet<ACMOIGHLHJL>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x26C5380", Offset = "0x26C4180", VA = "0x1826C5380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct KPDNNGACDNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private HashSet<DKMBJINJIPI>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4661CD0", Offset = "0x4660AD0", VA = "0x184661CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class PAIFAFPLPHD<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public string timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public PAIFAFPLPHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
		internal string <NewTaskCompletionSource>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class DAJPIHLKOMK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public Dictionary<string, string> tcsTimeoutData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public PECCHCMILFI.DLEJAEEKLAC timeoutMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public DAJPIHLKOMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x36CBB20", Offset = "0x36CA920", VA = "0x1836CBB20")]
		internal void <NewTaskCompletionSource>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class GEBOFIOFLKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public TaskCompletionSource<NJPHLGJHJOE> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public GEBOFIOFLKB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct JBCDANOKODO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private GEBOFIOFLKB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public NJPHLGJHJOE connectedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public AppSettings appSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private TaskAwaiter<NJPHLGJHJOE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x35FB370", Offset = "0x35FA170", VA = "0x1835FB370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class ANPLAOIBHNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public ANPLAOIBHNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x34D63E0", Offset = "0x34D51E0", VA = "0x1834D63E0")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class GAAKIMHODJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public GAAKIMHODJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3C884A0", Offset = "0x3C872A0", VA = "0x183C884A0")]
		internal object <LogWarning>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class KCLHEEBGMJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public KCLHEEBGMJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x234F5A0", Offset = "0x234E3A0", VA = "0x18234F5A0")]
		internal object <LogError>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class FOFDIKFOEEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public global::DIHPPILHIFK<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public FOFDIKFOEEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2BAEBB0", Offset = "0x2BAD9B0", VA = "0x182BAEBB0")]
		internal object <LogException>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly Hashtable GNDKBGFMPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly AFFJFDPLBNL BANHKILKLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly CKINGFFABPF IBGIMMLCCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected readonly string CKFDJADAAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected readonly ICNBEOMJLKN BCFEJNOKCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private TaskCompletionSource<GABJJGKGDOH> LMGKPGJHHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[NotNull]
	public readonly GKGHEGFGJEC POIALBHEJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	protected internal readonly TNetworking DKGIFMJCJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private ushort IHOPMGBIMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private global::HAOPNHCMONJ<DGHAAGPFHHI> FLJDBBCOKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private global::HAOPNHCMONJ<bool> MDBMMJEFDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private global::HAOPNHCMONJ<GONJJJGFLNJ> KNBKPIEHCDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private global::HAOPNHCMONJ<GABJJGKGDOH> LLPAMECIBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool PPNDJIJJGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool LNIKCDGGKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly HashSet<DKMBJINJIPI> EEAAHPJJCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly HashSet<ACMOIGHLHJL> OHCLHKNKKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private bool OCJGGEPKHAO;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool KPFDOHJDJJN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2B089F0", Offset = "0x2B077F0", VA = "0x182B089F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	[CanBeNull]
	public GONJJJGFLNJ PIMCKADBKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2B07580", Offset = "0x2B06380", VA = "0x182B07580", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	protected NJPHLGJHJOE AMFBIKPMCDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B06160", Offset = "0x2B04F60", VA = "0x182B06160")]
		get
		{
			return default(NJPHLGJHJOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	[CanBeNull]
	public string HNOLKAKJBJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B07050", Offset = "0x2B05E50", VA = "0x182B07050", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private TimeSpan PKJMMLKJMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B084E0", Offset = "0x2B072E0", VA = "0x182B084E0")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private TimeSpan LLPMEMDLEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B06820", Offset = "0x2B05620", VA = "0x182B06820")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public Task PJBIJLJDNGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B06DD0", Offset = "0x2B05BD0", VA = "0x182B06DD0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract bool GNLNDNKALCF(GONJJJGFLNJ IBHKJDDBFAL);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2B08250", Offset = "0x2B07050", VA = "0x182B08250")]
	private static TimeSpan NLNHKBIAOJF(TimeSpan KFHHNKHBEBI, string ICIEGOLHGJN)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2B09430", Offset = "0x2B08230", VA = "0x182B09430")]
	protected DIHPPILHIFK(TNetworking PAOJHNGKONI, ICNBEOMJLKN CKEHEGKGGCH, string GHFCIPHCDJK, CKINGFFABPF IBGIMMLCCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2B09110", Offset = "0x2B07F10", VA = "0x182B09110")]
	internal DIHPPILHIFK(TNetworking PAOJHNGKONI, ICNBEOMJLKN CKEHEGKGGCH, string GHFCIPHCDJK, CKINGFFABPF IBGIMMLCCDF, [Optional] AFFJFDPLBNL BANHKILKLPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2B08780", Offset = "0x2B07580", VA = "0x182B08780")]
	private void OMOEIMBMCPJ(bool IDKOCJBGGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2B07180", Offset = "0x2B05F80", VA = "0x182B07180")]
	private void IAMDLLCGLDC(NJPHLGJHJOE BMNOGHCMJGL, NJPHLGJHJOE HEEEANCGFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2B07320", Offset = "0x2B06120", VA = "0x182B07320")]
	internal BMALNKMDMLE IKELEOIFGPK()
	{
		return default(BMALNKMDMLE);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2B075D0", Offset = "0x2B063D0", VA = "0x182B075D0")]
	[AsyncStateMachine(typeof(global::DIHPPILHIFK<>.OAJILJFFHPD))]
	private Task<DGHAAGPFHHI> KMEPBDBJPKP(BMALNKMDMLE FCOCNKHPKHM, DGHAAGPFHHI HMEMCGDMOGB, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2B080B0", Offset = "0x2B06EB0", VA = "0x182B080B0")]
	[AsyncStateMachine(typeof(global::DIHPPILHIFK<>.MEKBNDCDJFP))]
	protected Task<DGHAAGPFHHI> NGAIDNIBHDI(BMALNKMDMLE FCOCNKHPKHM, DGHAAGPFHHI HMEMCGDMOGB, CancellationToken GJBNCDIAHHO, CancellationToken BNJDHMGFAPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2B066D0", Offset = "0x2B054D0", VA = "0x182B066D0")]
	[AsyncStateMachine(typeof(global::DIHPPILHIFK<>.FGKFMGLIODK))]
	protected Task DHKGKICKHBH(BMALNKMDMLE FCOCNKHPKHM, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2B08DB0", Offset = "0x2B07BB0", VA = "0x182B08DB0", Slot = "7")]
	[AsyncStateMachine(typeof(global::DIHPPILHIFK<>.HOFHDCBFBJF))]
	public Task PPKLBAECIEH([Optional] CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2B05C00", Offset = "0x2B04A00", VA = "0x182B05C00")]
	[AsyncStateMachine(typeof(global::DIHPPILHIFK<>.DGKMENNODBO))]
	private Task AMBEICOFHBH(BMALNKMDMLE FCOCNKHPKHM, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2B061D0", Offset = "0x2B04FD0", VA = "0x182B061D0")]
	[AsyncStateMachine(typeof(global::DIHPPILHIFK<>.HMDMBGIDHPK))]
	private Task<bool> CJIAENBJNGG(BMALNKMDMLE FCOCNKHPKHM, CancellationToken AMBDKIOJFBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2B06B90", Offset = "0x2B05990", VA = "0x182B06B90", Slot = "8")]
	[AsyncStateMachine(typeof(global::DIHPPILHIFK<>.GINLOANOCFC))]
	public Task<GONJJJGFLNJ> GEGLBFAACEA(GONJJJGFLNJ IBHKJDDBFAL, object MLHNCMAKIOC, [Optional] CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2B07C20", Offset = "0x2B06A20", VA = "0x182B07C20")]
	[AsyncStateMachine(typeof(global::DIHPPILHIFK<>.OELBMPJDMFJ))]
	private Task<GONJJJGFLNJ> LPHMOLMPPKP(BMALNKMDMLE FCOCNKHPKHM, GONJJJGFLNJ IBHKJDDBFAL, object MLHNCMAKIOC, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2B069E0", Offset = "0x2B057E0", VA = "0x182B069E0")]
	[AsyncStateMachine(typeof(global::DIHPPILHIFK<>.DBNJAILILBP))]
	private Task<GONJJJGFLNJ> ENHJBNDBKAG(BMALNKMDMLE FCOCNKHPKHM, GONJJJGFLNJ IBHKJDDBFAL, object MLHNCMAKIOC, CancellationToken GJBNCDIAHHO, CancellationToken BNJDHMGFAPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2B085F0", Offset = "0x2B073F0", VA = "0x182B085F0")]
	[AsyncStateMachine(typeof(global::DIHPPILHIFK<>.IFMICPAAMMJ))]
	private void OKLBNEGPPPK(Task<GABJJGKGDOH> INPNAGMKGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2B078F0", Offset = "0x2B066F0", VA = "0x182B078F0")]
	[AsyncStateMachine(typeof(global::DIHPPILHIFK<>.OBOMEPPBMAD))]
	private Task LBNBMOLGFNG(BMALNKMDMLE FCOCNKHPKHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2B08EE0", Offset = "0x2B07CE0", VA = "0x182B08EE0", Slot = "9")]
	[AsyncStateMachine(typeof(global::DIHPPILHIFK<>.NKJKIKPBODP))]
	public Task PPODHDNDJOH([Optional] CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2B06010", Offset = "0x2B04E10", VA = "0x182B06010")]
	[AsyncStateMachine(typeof(global::DIHPPILHIFK<>.BHPEBOOHPNL))]
	private Task BNOKDCABBKG(BMALNKMDMLE FCOCNKHPKHM, [Optional] CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2B08390", Offset = "0x2B07190", VA = "0x182B08390")]
	[AsyncStateMachine(typeof(global::DIHPPILHIFK<>.GEICNDMBLOC))]
	private Task OFBINFKEFNF(BMALNKMDMLE FCOCNKHPKHM, [Optional] CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2B07760", Offset = "0x2B06560", VA = "0x182B07760")]
	[AsyncStateMachine(typeof(global::DIHPPILHIFK<>.PHALFMCGNCJ))]
	private Task<GABJJGKGDOH> KNNIMEIBEIO(BMALNKMDMLE FCOCNKHPKHM, CancellationToken GJBNCDIAHHO, CancellationToken BNJDHMGFAPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2B06350", Offset = "0x2B05150", VA = "0x182B06350")]
	[AsyncStateMachine(typeof(global::DIHPPILHIFK<>.LEDKADHNPFA))]
	private Task<NJPHLGJHJOE> DAJLGOOHELK(BMALNKMDMLE FCOCNKHPKHM, CancellationToken NBLKBHANAPP, string JBJAGOLOBKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2B07B70", Offset = "0x2B06970", VA = "0x182B07B70", Slot = "14")]
	protected virtual void LLDNDIDOIPJ(BMALNKMDMLE FCOCNKHPKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2B07270", Offset = "0x2B06070", VA = "0x182B07270", Slot = "15")]
	protected virtual void IHGGHIDPGBC(BMALNKMDMLE FCOCNKHPKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2B08870", Offset = "0x2B07670", VA = "0x182B08870")]
	private void OOPCIMOIODK(BMALNKMDMLE FCOCNKHPKHM, FFKLPFJKNDH JBJAGOLOBKN, params object[] CFGJGLPAHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "16")]
	protected virtual void HLNGNIHLFDH(GONJJJGFLNJ ANNKPBFPGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2B086D0", Offset = "0x2B074D0", VA = "0x182B086D0")]
	[AsyncStateMachine(typeof(global::DIHPPILHIFK<>.MGCBFIAKKOE))]
	private void OLJDHEPFPHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2B07FB0", Offset = "0x2B06DB0", VA = "0x182B07FB0")]
	[AsyncStateMachine(typeof(global::DIHPPILHIFK<>.AJIBFHGMEDA))]
	private Task MOEKNOGPLLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2B070B0", Offset = "0x2B05EB0", VA = "0x182B070B0")]
	[AsyncStateMachine(typeof(global::DIHPPILHIFK<>.BGJAIKOAFLN))]
	private void HPBPCJFIBIJ(OAAKIMBOCHL LOHBMAHKHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2B05EE0", Offset = "0x2B04CE0", VA = "0x182B05EE0")]
	[AsyncStateMachine(typeof(global::DIHPPILHIFK<>.JLEHMGMBFKP))]
	private Task AOFEDJHDHDF(OAAKIMBOCHL LOHBMAHKHMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2B07A50", Offset = "0x2B06850", VA = "0x182B07A50")]
	[AsyncStateMachine(typeof(global::DIHPPILHIFK<>.KPDNNGACDNM))]
	private Task LIMCMDAHBKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2B07520", Offset = "0x2B06320", VA = "0x182B07520", Slot = "10")]
	public void JLAENJNHADN(ACMOIGHLHJL IONPGPAMBFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2C78B80", Offset = "0x2C77980", VA = "0x182C78B80")]
	private TaskCompletionSource<T> KBIGPNCDDOL<T>(BMALNKMDMLE FCOCNKHPKHM, CancellationToken NBLKBHANAPP, TimeSpan OIPLOFODGGB, string GNGPCACADBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2C78920", Offset = "0x2C77720", VA = "0x182C78920")]
	private TaskCompletionSource<T> KBIGPNCDDOL<T>(BMALNKMDMLE FCOCNKHPKHM, CancellationToken NBLKBHANAPP, TimeSpan OIPLOFODGGB, PECCHCMILFI.DLEJAEEKLAC GNGPCACADBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2B05D60", Offset = "0x2B04B60", VA = "0x182B05D60")]
	[AsyncStateMachine(typeof(global::DIHPPILHIFK<>.JBCDANOKODO))]
	protected Task AMJCBIBBCEP(BMALNKMDMLE FCOCNKHPKHM, AppSettings OAJFDBGIMNJ, NJPHLGJHJOE NKNPLKIKJLM, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2B06930", Offset = "0x2B05730", VA = "0x182B06930", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2B08A60", Offset = "0x2B07860", VA = "0x182B08A60", Slot = "17")]
	protected virtual void PJDCAJIIDIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2B07A30", Offset = "0x2B06830", VA = "0x182B07A30")]
	private static string LIAOMHHKMBF(BMALNKMDMLE FCOCNKHPKHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2B064E0", Offset = "0x2B052E0", VA = "0x182B064E0")]
	protected void DBKHFPMEGAJ(string GPAOLHFLBHD, [Optional] BMALNKMDMLE FCOCNKHPKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2B06E60", Offset = "0x2B05C60", VA = "0x182B06E60")]
	protected void HNNDPDPEPLK(string GPAOLHFLBHD, [Optional] BMALNKMDMLE FCOCNKHPKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2B07DC0", Offset = "0x2B06BC0", VA = "0x182B07DC0")]
	protected void MBCIOBBCNFF(string GPAOLHFLBHD, [Optional] BMALNKMDMLE FCOCNKHPKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2B05A00", Offset = "0x2B04800", VA = "0x182B05A00")]
	protected void AHFHDEBPJBO(string GPAOLHFLBHD, Exception ADJEGMMBDPA, [Optional] BMALNKMDMLE FCOCNKHPKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2B06D10", Offset = "0x2B05B10", VA = "0x182B06D10")]
	public void GLIHMKLDCEP(DLJDIJKODNL IPMHPHKLFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2B07370", Offset = "0x2B06170", VA = "0x182B07370")]
	[CompilerGenerated]
	private void JAJBBPPCAPB(CADEDDJAMPA FAOLDBFHPMM, CADEDDJAMPA GKEJKMEMOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2C788F0", Offset = "0x2C776F0", VA = "0x182C788F0")]
	[CompilerGenerated]
	internal static string GCCIBNEJJBN<T>(TimeSpan NKDPFAIAJLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct BMALNKMDMLE : IEquatable<BMALNKMDMLE>, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public readonly ushort MCIGJMKEOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public readonly string CKFDJADAAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly IOABGKDGANE PAOJHNGKONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly Stopwatch LOOJHKDGLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly List<(TimeSpan, NJPHLGJHJOE, NJPHLGJHJOE)> GPEAIKJGNIB;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TimeSpan GNAKIPHHKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5B14700", Offset = "0x5B13500", VA = "0x185B14700")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IReadOnlyList<(TimeSpan time, NJPHLGJHJOE oldState, NJPHLGJHJOE newState)> GGDOMMFLJLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5B14740", Offset = "0x5B13540", VA = "0x185B14740")]
	public BMALNKMDMLE(ushort ECNEOLCEGAE, string GHFCIPHCDJK, IOABGKDGANE PAOJHNGKONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5B14420", Offset = "0x5B13220", VA = "0x185B14420")]
	private void AMCBNEAKPNJ(NJPHLGJHJOE BMNOGHCMJGL, NJPHLGJHJOE HEEEANCGFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5B146F0", Offset = "0x5B134F0", VA = "0x185B146F0", Slot = "4")]
	public bool Equals(BMALNKMDMLE IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5B14660", Offset = "0x5B13460", VA = "0x185B14660", Slot = "0")]
	public override bool Equals(object OJGAEOFIMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5B14720", Offset = "0x5B13520", VA = "0x185B14720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5B14640", Offset = "0x5B13440", VA = "0x185B14640")]
	public static bool EJGLOGBEPOL(BMALNKMDMLE CJCAMOJJGED, BMALNKMDMLE DDMHJAPFCFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5B144E0", Offset = "0x5B132E0", VA = "0x185B144E0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal static class GKOALLLHNFK
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1BE0", Offset = "0x2AE09E0", VA = "0x182AE1BE0")]
	[AsyncStateMachine(typeof(BCKJPEGBMMN))]
	public static Task GABOHBCFPHL<TArgs>(this global::HAOPNHCMONJ<TArgs> EOJAFEPBELI, [Optional] BMALNKMDMLE LDILOHAKJHP) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1F70", Offset = "0x2AE0D70", VA = "0x182AE1F70")]
	[AsyncStateMachine(typeof(GNPCCMCOHEM))]
	public static Task KMAFILIMHEL<TArgs>(this global::HAOPNHCMONJ<TArgs> EOJAFEPBELI, TimeSpan JGINIBLIEKD, [Optional] BMALNKMDMLE LDILOHAKJHP) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE21F0", Offset = "0x2AE0FF0", VA = "0x182AE21F0")]
	public static (bool, bool) MLDOGGIBGDO<TArgs>(this global::HAOPNHCMONJ<TArgs> EOJAFEPBELI, TArgs ONDHOAIGIEB, out string ABLFBHJAJKM) where TArgs : IEquatable<TArgs>
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1820", Offset = "0x2AE0620", VA = "0x182AE1820")]
	[AsyncStateMachine(typeof(PDPMNGCMIFJ))]
	public static Task<TArgs> FNNPAHJINNG<TArgs>(this global::HAOPNHCMONJ<TArgs> EOJAFEPBELI, TArgs ONDHOAIGIEB, CancellationToken IEBDKEFLKHL) where TArgs : IEquatable<TArgs>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal class HAOPNHCMONJ<TArgs> : IDisposable where TArgs : IEquatable<TArgs>
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public delegate Task<TArgs> AHKPGIHPHIH(CancellationToken BJIMEEDBBEO, CancellationToken NGBKLCNFGLD);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct HDFEBICNPIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public global::HAOPNHCMONJ<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public BMALNKMDMLE doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public TimeSpan forceCancelAfter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x3235E60", Offset = "0x3234C60", VA = "0x183235E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct GHBBLPMFLIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public global::HAOPNHCMONJ<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public BMALNKMDMLE doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x32D07B0", Offset = "0x32CF5B0", VA = "0x1832D07B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct MEDDHAFGFIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public global::HAOPNHCMONJ<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2CE95E0", Offset = "0x2CE83E0", VA = "0x182CE95E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct EGPDHLJBPCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public global::HAOPNHCMONJ<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public AHKPGIHPHIH taskFactory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private CancellationTokenSource <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x322B340", Offset = "0x322A140", VA = "0x18322B340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x1D05B60", Offset = "0x1D04960", VA = "0x181D05B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct AFEHKDBDELN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public Task<TArgs> wrappedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public global::HAOPNHCMONJ<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x33F3140", Offset = "0x33F1F40", VA = "0x1833F3140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x1054F50", Offset = "0x1053D50", VA = "0x181054F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private bool LINNMJPFKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private bool OEGMAGCNLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private bool PJCOPHHEHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private CancellationTokenSource LFEKDPKAEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private CancellationTokenSource FEPCMFJDPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly BMALNKMDMLE FCOCNKHPKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private readonly CancellationToken GHKIFNBJIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly TArgs ONDHOAIGIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private TArgs KAHIPMIDNOL;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public TArgs OAFAFEDHHDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3DAFAD0", Offset = "0x3DAE8D0", VA = "0x183DAFAD0")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public TArgs FBBPJDJNCPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3DAFB10", Offset = "0x3DAE910", VA = "0x183DAFB10")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	[CanBeNull]
	public Task<TArgs> NJELEDGBOOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x757900", Offset = "0x756700", VA = "0x180757900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7FA1B0", Offset = "0x7F8FB0", VA = "0x1807FA1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3DB0780", Offset = "0x3DAF580", VA = "0x183DB0780")]
	public HAOPNHCMONJ(TArgs PHKLFKDLEII, CancellationToken GHKIFNBJIOP, BMALNKMDMLE FCOCNKHPKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3DAF680", Offset = "0x3DAE480", VA = "0x183DAF680")]
	[AsyncStateMachine(typeof(global::HAOPNHCMONJ<>.HDFEBICNPIB))]
	public Task HKGAILLABBI(TimeSpan EGODGMJEEPB, BMALNKMDMLE HOLBONLOJHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3DB0520", Offset = "0x3DAF320", VA = "0x183DB0520")]
	[AsyncStateMachine(typeof(global::HAOPNHCMONJ<>.GHBBLPMFLIC))]
	public Task PBHAAIOEBAK(BMALNKMDMLE HOLBONLOJHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3DAF280", Offset = "0x3DAE080", VA = "0x183DAF280", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3DAE7A0", Offset = "0x3DAD5A0", VA = "0x183DAE7A0")]
	[AsyncStateMachine(typeof(global::HAOPNHCMONJ<>.MEDDHAFGFIN))]
	private Task BOKPOLCBAPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3DAFCA0", Offset = "0x3DAEAA0", VA = "0x183DAFCA0")]
	[AsyncStateMachine(typeof(global::HAOPNHCMONJ<>.EGPDHLJBPCL))]
	public Task<TArgs> LPLJBLOBKLA(AHKPGIHPHIH IPBKNNCDKNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3DAFFA0", Offset = "0x3DAEDA0", VA = "0x183DAFFA0")]
	[AsyncStateMachine(typeof(global::HAOPNHCMONJ<>.AFEHKDBDELN))]
	private Task<TArgs> MEBIBCAGMDA(Task<TArgs> ODBCHOLPIEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3DAF8C0", Offset = "0x3DAE6C0", VA = "0x183DAF8C0")]
	public bool IBJHBNNPCDN(TArgs HPHCJIMFOOK, out string ABLFBHJAJKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3DAF020", Offset = "0x3DADE20", VA = "0x183DAF020")]
	private bool DBJGPEMAPEA(TArgs HPHCJIMFOOK, out string ABLFBHJAJKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3DAEAA0", Offset = "0x3DAD8A0", VA = "0x183DAEAA0")]
	public void CLNHBLGAIBL(CancellationToken NBLKBHANAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3DAFAE0", Offset = "0x3DAE8E0", VA = "0x183DAFAE0")]
	[CompilerGenerated]
	private void IGNDJMDHAFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface CKINGFFABPF
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GACBNFKDPKM(string GHFCIPHCDJK, string JNFEKFGAKEC, BMALNKMDMLE FCOCNKHPKHM, [Optional] string NPHFIEBGKNO);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OMCFKLENDOB(string GHFCIPHCDJK, string JNFEKFGAKEC, BMALNKMDMLE FCOCNKHPKHM, [Optional] string NPHFIEBGKNO);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HCCOFCDODJJ(string GHFCIPHCDJK, string JNFEKFGAKEC, BMALNKMDMLE FCOCNKHPKHM, [Optional] string NPHFIEBGKNO);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GIAPMOHHOHB(string GHFCIPHCDJK, string JNFEKFGAKEC, BMALNKMDMLE FCOCNKHPKHM, Exception NBMLFONNLJF, [Optional] string NPHFIEBGKNO);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NMCOBOKLDIJ(string GHFCIPHCDJK, PGALOEFPGPI DANJKKLFFGD);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal static class IIOKBHANAPN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct LENNCBLPMBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public CKINGFFABPF analytics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public string clientName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public string actionName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5B1CC20", Offset = "0x5B1BA20", VA = "0x185B1CC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2935120", Offset = "0x2933F20", VA = "0x182935120")]
	[AsyncStateMachine(typeof(IIHOKMIPIJI))]
	public static Task<T> CNAIOJKDDIK<T>(this Task<T> LEGNJFDJJMM, [CanBeNull] CKINGFFABPF IBGIMMLCCDF, string GHFCIPHCDJK, string JNFEKFGAKEC, BMALNKMDMLE FCOCNKHPKHM, [Optional] string NPHFIEBGKNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5B1A760", Offset = "0x5B19560", VA = "0x185B1A760")]
	[AsyncStateMachine(typeof(LENNCBLPMBD))]
	public static Task CNAIOJKDDIK(this Task LEGNJFDJJMM, [CanBeNull] CKINGFFABPF IBGIMMLCCDF, string GHFCIPHCDJK, string JNFEKFGAKEC, BMALNKMDMLE FCOCNKHPKHM, [Optional] string NPHFIEBGKNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public delegate Task DKMBJINJIPI();
[Cpp2IlInjected.Token(Token = "0x200004F")]
public delegate Task ACMOIGHLHJL(OAAKIMBOCHL LOHBMAHKHMB);
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class LBIPKOFBBMP : CADEDDJAMPA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly DLJDIJKODNL LNNKAMHDJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Func<LBIPKOFBBMP, bool> BIGNBEGBLLB;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public NJPHLGJHJOE AMFBIKPMCDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5B1C7E0", Offset = "0x5B1B5E0", VA = "0x185B1C7E0", Slot = "4")]
		get
		{
			return default(NJPHLGJHJOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public DLJNNACPCNN KCACEOLJHGA
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5B1CA60", Offset = "0x5B1B860", VA = "0x185B1CA60", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool KPFDOHJDJJN
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5B1CB20", Offset = "0x5B1B920", VA = "0x185B1CB20", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool NOEFIENPGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5B1CAE0", Offset = "0x5B1B8E0", VA = "0x185B1CAE0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool JPMCNEGMOCN
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5B1CAA0", Offset = "0x5B1B8A0", VA = "0x185B1CAA0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Exception NJLGELPLJGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5B1C7A0", Offset = "0x5B1B5A0", VA = "0x185B1C7A0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public StatusCode LKAELEDGFJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5B1C940", Offset = "0x5B1B740", VA = "0x185B1C940", Slot = "16")]
		get
		{
			return default(StatusCode);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event DLJDIJKODNL.GMEMDPKOEKA LLCBPPIPMON
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5B1CA80", Offset = "0x5B1B880", VA = "0x185B1CA80", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5B1C7C0", Offset = "0x5B1B5C0", VA = "0x185B1C7C0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<NJPHLGJHJOE, NJPHLGJHJOE> BANJPMDEBED
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5B1C960", Offset = "0x5B1B760", VA = "0x185B1C960", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5B1C8A0", Offset = "0x5B1B6A0", VA = "0x185B1C8A0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5B1CB40", Offset = "0x5B1B940", VA = "0x185B1CB40")]
	public LBIPKOFBBMP(DLJDIJKODNL LNNKAMHDJIF, [Optional] Func<LBIPKOFBBMP, bool> BIGNBEGBLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5B1C800", Offset = "0x5B1B600", VA = "0x185B1C800", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5B1CA00", Offset = "0x5B1B800", VA = "0x185B1CA00")]
	private void JDJEJJNJPHE(NJPHLGJHJOE BMNOGHCMJGL, NJPHLGJHJOE HEEEANCGFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5B1CAC0", Offset = "0x5B1B8C0", VA = "0x185B1CAC0", Slot = "13")]
	public void MMEGPCHPAIM(object ONDHOAIGIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5B1CB00", Offset = "0x5B1B900", VA = "0x185B1CB00", Slot = "14")]
	public void NECLFMEGHBL(object ONDHOAIGIEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class HFEJPMABALH : DCDAEJDLCNO, OELMMPOJFHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class GAFKIOMKGPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public GONJJJGFLNJ targetRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public GAFKIOMKGPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x5B18DA0", Offset = "0x5B17BA0", VA = "0x185B18DA0")]
		internal bool <ShouldConnect>b__0(NHDLJMJKKPB c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class ANCGOCEJOOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public ANCGOCEJOOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x5B142A0", Offset = "0x5B130A0", VA = "0x185B142A0")]
		internal Task <Disconnect>b__0(NHDLJMJKKPB c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct NJMPEIMGCCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public HFEJPMABALH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x5B1E6E0", Offset = "0x5B1D4E0", VA = "0x185B1E6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct LOGHBLFHKCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public AsyncTaskMethodBuilder<GONJJJGFLNJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public HFEJPMABALH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public GONJJJGFLNJ targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private GONJJJGFLNJ <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private TaskAwaiter<GONJJJGFLNJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5B1D490", Offset = "0x5B1C290", VA = "0x185B1D490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5B1D8E0", Offset = "0x5B1C6E0", VA = "0x185B1D8E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class MLBDGGDCELJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public MLBDGGDCELJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x5B1DEB0", Offset = "0x5B1CCB0", VA = "0x185B1DEB0")]
		internal Task <DisconnectFromRoomInstance>b__0(NHDLJMJKKPB c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct JKGPOCAGPDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public HFEJPMABALH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x5B1B710", Offset = "0x5B1A510", VA = "0x185B1B710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public readonly FOMDIGCAOOP EEPNBGMBDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public readonly NJHMNNFDPCI JGNIOMAEBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly NHDLJMJKKPB[] KMNDCOAEHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public readonly DFIOALGGGKP LDDOENALPJO;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public GONJJJGFLNJ PIMCKADBKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5B1A300", Offset = "0x5B19100", VA = "0x185B1A300", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string HNOLKAKJBJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x5B1A180", Offset = "0x5B18F80", VA = "0x185B1A180", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private IEnumerable<NHDLJMJKKPB> NAHJHKPJJLD
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5B19E80", Offset = "0x5B18C80", VA = "0x185B19E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private MJOBGOOJHML KIHDPEDLEBB
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Task PJBIJLJDNGH
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5B1A130", Offset = "0x5B18F30", VA = "0x185B1A130", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5B1A040", Offset = "0x5B18E40", VA = "0x185B1A040", Slot = "7")]
	public bool GNLNDNKALCF(GONJJJGFLNJ IBHKJDDBFAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5B1A590", Offset = "0x5B19390", VA = "0x185B1A590")]
	[Preserve]
	public HFEJPMABALH([HDMGOABMPFL(null)] FOMDIGCAOOP DMOEEMEOPAF, [HDMGOABMPFL(null)] NJHMNNFDPCI KOIHPDCPBMA, [HDMGOABMPFL(null)] DFIOALGGGKP EEIKJFHBBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5B1A350", Offset = "0x5B19150", VA = "0x185B1A350", Slot = "8")]
	[AsyncStateMachine(typeof(NJMPEIMGCCE))]
	public Task PPKLBAECIEH([Optional] CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5B19EC0", Offset = "0x5B18CC0", VA = "0x185B19EC0", Slot = "9")]
	[AsyncStateMachine(typeof(LOGHBLFHKCD))]
	public Task<GONJJJGFLNJ> GEGLBFAACEA(GONJJJGFLNJ IBHKJDDBFAL, object MLHNCMAKIOC, [Optional] CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5B1A470", Offset = "0x5B19270", VA = "0x185B1A470", Slot = "10")]
	[AsyncStateMachine(typeof(JKGPOCAGPDH))]
	public Task PPODHDNDJOH([Optional] CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5B19C70", Offset = "0x5B18A70", VA = "0x185B19C70", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5B1A1D0", Offset = "0x5B18FD0", VA = "0x185B1A1D0", Slot = "11")]
	public void JLAENJNHADN(ACMOIGHLHJL IONPGPAMBFG)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct GABJJGKGDOH : IEquatable<GABJJGKGDOH>
{
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public static readonly GABJJGKGDOH ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7621B0", Offset = "0x760FB0", VA = "0x1807621B0", Slot = "4")]
	public bool Equals(GABJJGKGDOH IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5B18D30", Offset = "0x5B17B30", VA = "0x185B18D30", Slot = "0")]
	public override bool Equals(object OJGAEOFIMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7487A0", Offset = "0x7475A0", VA = "0x1807487A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class HFBDFEPJLDL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x5B18330", Offset = "0x5B17130", VA = "0x185B18330")]
	public HFBDFEPJLDL(string GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5B19BF0", Offset = "0x5B189F0", VA = "0x185B19BF0")]
	public HFBDFEPJLDL(string GPAOLHFLBHD, Exception HJNEAIFJHLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class JIDENHLJKLB : HFBDFEPJLDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public readonly string KAGDFAGNPFM;

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5B1B5F0", Offset = "0x5B1A3F0", VA = "0x185B1B5F0")]
	public JIDENHLJKLB(string MBJKCNDPDLP, [NotNull] Exception HJNEAIFJHLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class BGCHNEIPBJH : HFBDFEPJLDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public readonly GONJJJGFLNJ KJFJCILNEFP;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5B14300", Offset = "0x5B13100", VA = "0x185B14300")]
	public BGCHNEIPBJH(GONJJJGFLNJ LBEAMMMHJED, [NotNull] Exception HJNEAIFJHLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class NHJDPPFLLLF : HFBDFEPJLDL
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5B18330", Offset = "0x5B17130", VA = "0x185B18330")]
	public NHJDPPFLLLF(string GPAOLHFLBHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class PGALOEFPGPI : HFBDFEPJLDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public readonly StatusCode? LKAELEDGFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public readonly OAAKIMBOCHL PEFHMFOFCLP;

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5B1EFC0", Offset = "0x5B1DDC0", VA = "0x185B1EFC0")]
	public PGALOEFPGPI(OAAKIMBOCHL LOHBMAHKHMB, Exception HJNEAIFJHLM, StatusCode? MGJDEDPGGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5B1ED00", Offset = "0x5B1DB00", VA = "0x185B1ED00")]
	public static PGALOEFPGPI IBFLBPILPOD(OAAKIMBOCHL NJKKJCCKJKF, CADEDDJAMPA LHLEOLFHDAI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class EGHBEAEONLJ : HFBDFEPJLDL
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5B18330", Offset = "0x5B17130", VA = "0x185B18330")]
	public EGHBEAEONLJ(string GPAOLHFLBHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class LJHCCDOPMDF : HFBDFEPJLDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public readonly short ENIEAJDHNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public readonly string AIPJMBFOPAB;

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5B1D3A0", Offset = "0x5B1C1A0", VA = "0x185B1D3A0")]
	public LJHCCDOPMDF(short IBCAALMMGCM, string DPFCJBAEMCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class MHAJNPEJJMH : HFBDFEPJLDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public readonly short ENIEAJDHNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public readonly string AIPJMBFOPAB;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x5B1DDC0", Offset = "0x5B1CBC0", VA = "0x185B1DDC0")]
	public MHAJNPEJJMH(short IBCAALMMGCM, string DPFCJBAEMCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class HECLBOOCFCL : HFBDFEPJLDL
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x5B18330", Offset = "0x5B17130", VA = "0x185B18330")]
	public HECLBOOCFCL(string GPAOLHFLBHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class OJDMPHEFDMI : HFBDFEPJLDL
{
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5B1EC70", Offset = "0x5B1DA70", VA = "0x185B1EC70")]
	public OJDMPHEFDMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class GHFMOCAFCDP : KHGHHPMCACG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public readonly Dictionary<string, string> NGNNOMIBONF;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5B19250", Offset = "0x5B18050", VA = "0x185B19250")]
	public GHFMOCAFCDP(TimeSpan OIPLOFODGGB, string GPAOLHFLBHD, Dictionary<string, string> NPHFIEBGKNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class GKGHEGFGJEC : JPIBPMFFBMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private readonly global::JDKDAIPFIPL<OAAKIMBOCHL> CFHFGLMBOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private readonly global::JDKDAIPFIPL<OAAKIMBOCHL> PGDKOBPMOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private readonly global::JDKDAIPFIPL<OAAKIMBOCHL> ADBBDKJKODO;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<OAAKIMBOCHL> LFEOOENMLCC
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5B19410", Offset = "0x5B18210", VA = "0x185B19410")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5B19290", Offset = "0x5B18090", VA = "0x185B19290")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action<OAAKIMBOCHL> NOPCBCJMPEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5B19350", Offset = "0x5B18150", VA = "0x185B19350")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5B19470", Offset = "0x5B18270", VA = "0x185B19470")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<OAAKIMBOCHL> ADIKJOGBCEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5B192F0", Offset = "0x5B180F0", VA = "0x185B192F0")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5B193B0", Offset = "0x5B181B0", VA = "0x185B193B0")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5B194D0", Offset = "0x5B182D0", VA = "0x185B194D0", Slot = "30")]
	public override void OnDisconnected(OAAKIMBOCHL LOHBMAHKHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5B195D0", Offset = "0x5B183D0", VA = "0x185B195D0")]
	public GKGHEGFGJEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class FOMDIGCAOOP : global::DIHPPILHIFK<ADEJCHDMBNK>, MJOBGOOJHML, NHDLJMJKKPB, OELMMPOJFHN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct MBFKMPKOMMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public FOMDIGCAOOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private CancellationToken <token>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5B1D930", Offset = "0x5B1C730", VA = "0x185B1D930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x74B100", Offset = "0x749F00", VA = "0x18074B100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class KGJLENIFBKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public FOMDIGCAOOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public BMALNKMDMLE actionContext;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public KGJLENIFBKJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private struct PPAGIEGKBBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public AsyncTaskMethodBuilder<IReadOnlyDictionary<string, int>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public FOMDIGCAOOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private KGJLENIFBKJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public TimeSpan? timeoutSpan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private global::GKMALKFADNA<string> <pingStackTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private EHEFPJIJJBB <pingTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private Stopwatch <sw>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private Dictionary<string, int> <regionPings>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private TaskAwaiter<DGHAAGPFHHI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private EHEFPJIJJBB <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private YieldAwaitable.YieldAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x5B1F160", Offset = "0x5B1DF60", VA = "0x185B1F160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x5B20AA0", Offset = "0x5B1F8A0", VA = "0x185B20AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private CancellationTokenSource NNNHBCGKCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private CancellationTokenSource EOJFOHNBPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private CancellationToken? MHFHAFLDBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private bool CBMLGOPKLLL;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool PDLDGHGMBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x1407030", Offset = "0x1405E30", VA = "0x181407030")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x5B185B0", Offset = "0x5B173B0", VA = "0x185B185B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5B18680", Offset = "0x5B17480", VA = "0x185B18680", Slot = "13")]
	public override bool GNLNDNKALCF(GONJJJGFLNJ IBHKJDDBFAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5B18BB0", Offset = "0x5B179B0", VA = "0x185B18BB0")]
	[Preserve]
	public FOMDIGCAOOP([HDMGOABMPFL(null)] ADEJCHDMBNK PAOJHNGKONI, [HDMGOABMPFL(null)] ICNBEOMJLKN CKEHEGKGGCH, [HDMGOABMPFL(null)] CKINGFFABPF IBGIMMLCCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5B18C70", Offset = "0x5B17A70", VA = "0x185B18C70")]
	internal FOMDIGCAOOP(ADEJCHDMBNK PAOJHNGKONI, ICNBEOMJLKN CKEHEGKGGCH, CKINGFFABPF IBGIMMLCCDF, AFFJFDPLBNL BANHKILKLPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5B18B10", Offset = "0x5B17910", VA = "0x185B18B10", Slot = "17")]
	protected override void PJDCAJIIDIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x5B18AA0", Offset = "0x5B178A0", VA = "0x185B18AA0")]
	private void NCNILMMJDPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5B186E0", Offset = "0x5B174E0", VA = "0x185B186E0", Slot = "16")]
	protected override void HLNGNIHLFDH(GONJJJGFLNJ ANNKPBFPGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5B18940", Offset = "0x5B17740", VA = "0x185B18940", Slot = "14")]
	protected override void LLDNDIDOIPJ(BMALNKMDMLE FCOCNKHPKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5B188C0", Offset = "0x5B176C0", VA = "0x185B188C0", Slot = "15")]
	protected override void IHGGHIDPGBC(BMALNKMDMLE FCOCNKHPKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5B184E0", Offset = "0x5B172E0", VA = "0x185B184E0")]
	[AsyncStateMachine(typeof(MBFKMPKOMMA))]
	private void CKOFBHEHAIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x5B183A0", Offset = "0x5B171A0", VA = "0x185B183A0", Slot = "18")]
	[AsyncStateMachine(typeof(PPAGIEGKBBM))]
	public Task<IReadOnlyDictionary<string, int>> BAABJPKJIBI([Optional] TimeSpan? BGFDACBDBID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class GONJJJGFLNJ : DGHAAGPFHHI, IEquatable<GONJJJGFLNJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public readonly string MIAJKKKNHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public readonly bool CHIFBCBPLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public readonly string? NCAKEFEKGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public readonly string? JGBFPFHJBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public readonly bool HKGMEPHGBCM;

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5B19A10", Offset = "0x5B18810", VA = "0x185B19A10")]
	public GONJJJGFLNJ(string EDAONJAFLOL, string KNNFMHMLBJE, string CHOGKMHOPGK, string? GKGOHFDFOGJ, string HGMMMNGCCII, string FFMOFPMPOHB, string? PEEKKJPGOIA, string? OKCODAMJOLJ, bool OJIHMNLKNFA, bool COMGCPMBHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x5B19990", Offset = "0x5B18790", VA = "0x185B19990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x5B197E0", Offset = "0x5B185E0", VA = "0x185B197E0", Slot = "5")]
	public bool Equals(GONJJJGFLNJ? IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x5B196C0", Offset = "0x5B184C0", VA = "0x185B196C0", Slot = "0")]
	public override bool Equals(object? OJGAEOFIMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5B19860", Offset = "0x5B18660", VA = "0x185B19860", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x1935FB0", Offset = "0x1934DB0", VA = "0x181935FB0")]
	public static bool EJGLOGBEPOL(GONJJJGFLNJ? CJCAMOJJGED, GONJJJGFLNJ? DDMHJAPFCFF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x1936470", Offset = "0x1935270", VA = "0x181936470")]
	public static bool IKFCAHNLBFO(GONJJJGFLNJ? CJCAMOJJGED, GONJJJGFLNJ? DDMHJAPFCFF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class DGHAAGPFHHI : IEquatable<DGHAAGPFHHI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public readonly string OKCBICOINEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public readonly string? LPGOMCEMGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public readonly string? EAEHOIKMOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public readonly string? HENOPJANJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public readonly string IKNHJNLFOMM;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5B169E0", Offset = "0x5B157E0", VA = "0x185B169E0")]
	public DGHAAGPFHHI(string EDAONJAFLOL, string? KNNFMHMLBJE, string? CHOGKMHOPGK, string? GKGOHFDFOGJ, string HGMMMNGCCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x5B16980", Offset = "0x5B15780", VA = "0x185B16980", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5B16730", Offset = "0x5B15530", VA = "0x185B16730", Slot = "4")]
	public bool Equals(DGHAAGPFHHI? IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5B167C0", Offset = "0x5B155C0", VA = "0x185B167C0", Slot = "0")]
	public override bool Equals(object? OJGAEOFIMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5B168A0", Offset = "0x5B156A0", VA = "0x185B168A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class NJHMNNFDPCI : global::DIHPPILHIFK<NJHMNNFDPCI.IKLMJBHACDL>
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public interface OEBGIJJNNPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool OHHEJEHNHDP();
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class IKLMJBHACDL : IOABGKDGANE, MBMPIPGPDDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private CADEDDJAMPA FMKOPGBEAOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private bool APNOCFLBPNO;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private PhotonVoiceNetwork CPBFJBKGEAE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x5B1AD10", Offset = "0x5B19B10", VA = "0x185B1AD10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool IKCCAPOMODG
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x10218E0", Offset = "0x10206E0", VA = "0x1810218E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public CADEDDJAMPA LECKGBDDAPP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool NOEFIENPGLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x5B1B3D0", Offset = "0x5B1A1D0", VA = "0x185B1B3D0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool EOHKOGNKOGH
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x5B1AEC0", Offset = "0x5B19CC0", VA = "0x185B1AEC0", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x7D64C0", Offset = "0x7D52C0", VA = "0x1807D64C0", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool FHJLLNOECIM
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x745330", Offset = "0x744130", VA = "0x180745330", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool KPFDOHJDJJN
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5B1B480", Offset = "0x5B1A280", VA = "0x185B1B480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public FBALGABFPOI EFJBADCCPCE
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x5B1A8F0", Offset = "0x5B196F0", VA = "0x185B1A8F0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool NGHDPPIFAIK
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x5B1B080", Offset = "0x5B19E80", VA = "0x185B1B080", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<CADEDDJAMPA, CADEDDJAMPA> OLGABNIJJJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x5B1AC70", Offset = "0x5B19A70", VA = "0x185B1AC70", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x5B1A9E0", Offset = "0x5B197E0", VA = "0x185B1A9E0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<bool> OLDOGDLHEMG
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x5B1B1B0", Offset = "0x5B19FB0", VA = "0x185B1B1B0", Slot = "9")]
		public void MDCFEKLHJHB(DLJDIJKODNL KOIHPDCPBMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x5B1B290", Offset = "0x5B1A090", VA = "0x185B1B290", Slot = "16")]
		public bool MGJLPMLIAAA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x5B1AA80", Offset = "0x5B19880", VA = "0x185B1AA80", Slot = "17")]
		public bool GEKFKOPEGME(string FFMOFPMPOHB, BLCEEOKIMAG FBDACBNJEHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x5B1B4D0", Offset = "0x5B1A2D0", VA = "0x185B1B4D0", Slot = "18")]
		public void PPKLBAECIEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x5B1AD70", Offset = "0x5B19B70", VA = "0x185B1AD70", Slot = "19")]
		public bool IJDBFHLPLGB(AppSettings OAJFDBGIMNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "22")]
		public void COOODJECDEI(object AMBDKIOJFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "23")]
		public void KBIJMKJKOPO(object AMBDKIOJFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "24")]
		public void HIFIBMLACMD(object AMBDKIOJFBL, bool OHPEFNFODEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x5B1B420", Offset = "0x5B1A220", VA = "0x185B1B420", Slot = "25")]
		public IDisposable OMFGHEOBCFD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x745330", Offset = "0x744130", VA = "0x180745330", Slot = "26")]
		private bool LNIEINALDIN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "27")]
		public void KLGNEAAAOPM(StringBuilder EOCPHJGLPEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x5B1AF70", Offset = "0x5B19D70", VA = "0x185B1AF70", Slot = "28")]
		public bool JMHABEEFHPP(bool DLDBGNDCLIN, out string DOIPIGHENCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public IKLMJBHACDL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct OAHKEKIABBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public NJHMNNFDPCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public FOMDIGCAOOP clientToFollow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter<GONJJJGFLNJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5B1E9B0", Offset = "0x5B1D7B0", VA = "0x185B1E9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct LIEHKJAHEKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public NJHMNNFDPCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5B1D0A0", Offset = "0x5B1BEA0", VA = "0x185B1D0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private readonly FOMDIGCAOOP DMOEEMEOPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private readonly OEBGIJJNNPM BOFJENNINFN;

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5B1E0A0", Offset = "0x5B1CEA0", VA = "0x185B1E0A0", Slot = "13")]
	public override bool GNLNDNKALCF(GONJJJGFLNJ IBHKJDDBFAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5B1E410", Offset = "0x5B1D210", VA = "0x185B1E410")]
	[Preserve]
	public NJHMNNFDPCI([HDMGOABMPFL(null)] FOMDIGCAOOP DMOEEMEOPAF, [HDMGOABMPFL(null)] ICNBEOMJLKN CKEHEGKGGCH, [HDMGOABMPFL(null)] OEBGIJJNNPM BOFJENNINFN, [HDMGOABMPFL(null)] CKINGFFABPF IBGIMMLCCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x5B1E250", Offset = "0x5B1D050", VA = "0x185B1E250")]
	private Task NKKGLLAODJM(OAAKIMBOCHL LOHBMAHKHMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x5B1E130", Offset = "0x5B1CF30", VA = "0x185B1E130")]
	[AsyncStateMachine(typeof(OAHKEKIABBO))]
	public Task HMDEODJADLN(FOMDIGCAOOP ILHBMDCCPHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x5B1DF10", Offset = "0x5B1CD10", VA = "0x185B1DF10")]
	[CompilerGenerated]
	internal static void CAFDLLMJKMF(CADEDDJAMPA FAOLDBFHPMM, CADEDDJAMPA GKEJKMEMOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x5B1DFA0", Offset = "0x5B1CDA0", VA = "0x185B1DFA0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(LIEHKJAHEKN))]
	private Task DEBAOJKJABC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class DFIOALGGGKP : NHDLJMJKKPB, OELMMPOJFHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public enum EHGKPCMKIDC
	{
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		Disconnected,
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		Connected
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private NetworkManager LEIGIPNEGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private TaskCompletionSource<GONJJJGFLNJ> DBDFFCEECBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	protected readonly ICNBEOMJLKN PIAFOMPPFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private readonly HashSet<ACMOIGHLHJL> OHCLHKNKKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public EHGKPCMKIDC LBNMLDCEPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private GONJJJGFLNJ IBHKJDDBFAL;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly string[] FIIAKOAMHJM;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly string[] NFKPJPGCBKD;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly string[] EHJCFEKLCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private RSACryptoServiceProvider GLHAPEAMGHD;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public GONJJJGFLNJ PIMCKADBKKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x748BA0", Offset = "0x7479A0", VA = "0x180748BA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string HNOLKAKJBJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5B15800", Offset = "0x5B14600", VA = "0x185B15800", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Task PJBIJLJDNGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x5B157C0", Offset = "0x5B145C0", VA = "0x185B157C0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5B15AE0", Offset = "0x5B148E0", VA = "0x185B15AE0", Slot = "10")]
	public void JLAENJNHADN(ACMOIGHLHJL IONPGPAMBFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5B15770", Offset = "0x5B14570", VA = "0x185B15770", Slot = "6")]
	public bool GNLNDNKALCF(GONJJJGFLNJ IBHKJDDBFAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5B165D0", Offset = "0x5B153D0", VA = "0x185B165D0")]
	[Preserve]
	public DFIOALGGGKP([HDMGOABMPFL(null)] ICNBEOMJLKN MBJHPKLKOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5B15E10", Offset = "0x5B14C10", VA = "0x185B15E10")]
	private void PMLPGPBJINI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5B14A10", Offset = "0x5B13810", VA = "0x185B14A10")]
	private void CHCDBPGOCBE(ulong OJGAEOFIMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5B15B40", Offset = "0x5B14940", VA = "0x185B15B40")]
	private void LJEAECBAGFH(ulong OJGAEOFIMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5B15830", Offset = "0x5B14630", VA = "0x185B15830")]
	private void IPALBBIICIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5B149A0", Offset = "0x5B137A0", VA = "0x185B149A0")]
	private void BDAGFOEGHCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5B15930", Offset = "0x5B14730", VA = "0x185B15930")]
	private void JELMFELLCKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x5B15C90", Offset = "0x5B14A90", VA = "0x185B15C90")]
	private static (IPAddress, ushort) LOKIHJBOCDO(string CDAKDOEEMED)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5B14CF0", Offset = "0x5B13AF0", VA = "0x185B14CF0", Slot = "8")]
	public Task<GONJJJGFLNJ> GEGLBFAACEA(GONJJJGFLNJ IBHKJDDBFAL, object MLHNCMAKIOC, [Optional] CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5B15FE0", Offset = "0x5B14DE0", VA = "0x185B15FE0", Slot = "7")]
	public Task PPKLBAECIEH([Optional] CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5B16110", Offset = "0x5B14F10", VA = "0x185B16110", Slot = "9")]
	public Task PPODHDNDJOH([Optional] CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "12")]
	public void Dispose()
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

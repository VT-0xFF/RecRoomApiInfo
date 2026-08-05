using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AmplitudeAnalytics;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Mono.Math;
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
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x67E3090", Offset = "0x67E1A90", VA = "0x1867E3090")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x847190", Offset = "0x845B90", VA = "0x180847190")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x143BBF0", Offset = "0x143A5F0", VA = "0x18143BBF0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum KKENHEDEJMB
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ChatPage,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	PlayerDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	ActionCode,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	FriendImport,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	PlatformFriendInvite,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	PlatformNotification,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	WatchNotification,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	LegacyHomeScreen,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	NavigationBar,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	LegacyChatPage,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	MobileHomeChat,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	PlayerProfile,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	ShareContent,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	HUDHotbarShortcut
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FBKKDABKONO
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private const string IKDHJOMNODO = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private const string IBIBFDIFLFL = "flowName";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const string NKNOMELHKIC = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private const string PKMJBKAOFCG = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const string KHENONLNGMB = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const string CGBPDLHBLFE = "failure";

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const string GFKLNJIFHPI = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long PHONICBPOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private LIAJLLJFFCN NBCILIFDJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool NBGMKIKMJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private float PAOIHIKMHNO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x67DD830", Offset = "0x67DC230", VA = "0x1867DD830")]
	public FBKKDABKONO(string HOCCBOHBIIE, float PAOIHIKMHNO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x35C2710", Offset = "0x35C1110", VA = "0x1835C2710")]
	public void HHODGEBAHOE<T>(string EELLPGLCOLL, T MFBGAMJDOKA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x67DD670", Offset = "0x67DC070", VA = "0x1867DD670")]
	public void HHODGEBAHOE(string EELLPGLCOLL, string MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x67DD6F0", Offset = "0x67DC0F0", VA = "0x1867DD6F0")]
	public void MIMBLIGHPEA(string INGEDCDMOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x67DD490", Offset = "0x67DBE90", VA = "0x1867DD490")]
	public void EMDECLPPNOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x67DD550", Offset = "0x67DBF50", VA = "0x1867DD550")]
	private void GCPKJJFDPIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x67DD7E0", Offset = "0x67DC1E0", VA = "0x1867DD7E0")]
	private bool OPIFECOFPIJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KENIFKIDOIC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FFCJMMOGLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action NEEKBMGCBOF;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action DKNJDOILFBH;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OFEHPCFKLFI NCBKDFJCMBF(string GPCNNKNFCLP, string ALEMLLDGECA, [Optional] PELPDIJCKFF PNJKGAPFPNN);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OFEHPCFKLFI DAJEEPKCJLL(PELPDIJCKFF PNJKGAPFPNN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "7")]
	OFEHPCFKLFI IEOHNFPLMLO(PELPDIJCKFF PNJKGAPFPNN, Dictionary<string, string> DGEDJIPAOPK);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FEOEGENCNAC(string CPPLNMCJEIO);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IKEEJKHGCFM OOHNNONCHCE(string CDFHHFJDBLF);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KMFKNIOGOCI KBGIEOBBIDG(string CGOCAAGLMFF);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IKEEJKHGCFM LHLGNLPDIMI(string BKEHBKCHOII);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "12")]
	OFEHPCFKLFI NHGBJNFAAAL();
}
namespace RecRoom.Analytics.Statsig
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class SerializedStatsigExperiment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public SerializedStatsigExperiment()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class SerializedStatsigExperimentSegment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private string parameterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private string parameterValue;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x67E4C00", Offset = "0x67E3600", VA = "0x1867E4C00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class MKJONPNIOEL : KENIFKIDOIC
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private const string IIJDALOLBGI = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private const string KHCNOHNGLCL = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private const string HLDHLLILHKA = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private const string LCHDHDNIFMH = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private const string BLPDJGBHILB = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private const string ELNNAKDAIIE = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private const string HGALEEMPNFH = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private const string DOELNNHHCCN = "AccountCreationTimeAfterEpochMilliseconds";

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private const string IHPCDPAKJLG = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private const string IDLHAEKCMPP = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private const string JIBGPBPHANF = "LocaleName";

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly IReadOnlyDictionary<string, DIGNOJBMKAN> EDEBDGNDIBO;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private const int PNGPFJNAPGC = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool BNIPAIONDIA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool FFCJMMOGLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7E6A20", Offset = "0x7E5420", VA = "0x1807E6A20", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action NEEKBMGCBOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x67E1E80", Offset = "0x67E0880", VA = "0x1867E1E80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x67E1790", Offset = "0x67E0190", VA = "0x1867E1790", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action DKNJDOILFBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x67E0B80", Offset = "0x67DF580", VA = "0x1867E0B80", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x67E1660", Offset = "0x67E0060", VA = "0x1867E1660", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x67E19E0", Offset = "0x67E03E0", VA = "0x1867E19E0", Slot = "8")]
	public OFEHPCFKLFI NCBKDFJCMBF(string GPCNNKNFCLP, string ALEMLLDGECA, [Optional] PELPDIJCKFF PNJKGAPFPNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x67E1F20", Offset = "0x67E0920", VA = "0x1867E1F20", Slot = "16")]
	public OFEHPCFKLFI NHGBJNFAAAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x67E0C20", Offset = "0x67DF620", VA = "0x1867E0C20", Slot = "10")]
	public OFEHPCFKLFI DAJEEPKCJLL(PELPDIJCKFF PNJKGAPFPNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x67E1370", Offset = "0x67DFD70", VA = "0x1867E1370", Slot = "11")]
	public OFEHPCFKLFI IEOHNFPLMLO(PELPDIJCKFF PNJKGAPFPNN, Dictionary<string, string> DGEDJIPAOPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x67E1230", Offset = "0x67DFC30", VA = "0x1867E1230", Slot = "12")]
	public bool FEOEGENCNAC(string CPPLNMCJEIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x67E20B0", Offset = "0x67E0AB0", VA = "0x1867E20B0", Slot = "13")]
	public IKEEJKHGCFM OOHNNONCHCE(string CDFHHFJDBLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x67E1830", Offset = "0x67E0230", VA = "0x1867E1830", Slot = "14")]
	public KMFKNIOGOCI KBGIEOBBIDG(string CGOCAAGLMFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x67E18F0", Offset = "0x67E02F0", VA = "0x1867E18F0", Slot = "15")]
	public IKEEJKHGCFM LHLGNLPDIMI(string BKEHBKCHOII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x67E0590", Offset = "0x67DEF90", VA = "0x1867E0590")]
	private KCGGAANLOEJ AIANPOGKMFN(PELPDIJCKFF PNJKGAPFPNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x67E0E40", Offset = "0x67DF840", VA = "0x1867E0E40")]
	private HHLLNMKGLKK EECPAKJNPJM(string ALEMLLDGECA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x67E0FE0", Offset = "0x67DF9E0", VA = "0x1867E0FE0")]
	private void EIJHLKEHPMF(string CDFHHFJDBLF, IKEEJKHGCFM ACOBKEPHPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public MKJONPNIOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9A1AB0", Offset = "0x9A04B0", VA = "0x1809A1AB0")]
	[CompilerGenerated]
	private void PCPPGLNJPCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x67E12E0", Offset = "0x67DFCE0", VA = "0x1867E12E0")]
	[CompilerGenerated]
	private void GAJBOBMCFAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x67E1700", Offset = "0x67E0100", VA = "0x1867E1700")]
	[CompilerGenerated]
	private void IPPDOPENHEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HCFJOLBHDJI : KENIFKIDOIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private KENIFKIDOIC OKKANCAHMCG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private KENIFKIDOIC IKPFPMKENNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x67DDC70", Offset = "0x67DC670", VA = "0x1867DDC70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool FFCJMMOGLGC
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x67DE310", Offset = "0x67DCD10", VA = "0x1867DE310", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action NEEKBMGCBOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x67DE640", Offset = "0x67DD040", VA = "0x1867DE640", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x67DE0D0", Offset = "0x67DCAD0", VA = "0x1867DE0D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action DKNJDOILFBH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x67DDCE0", Offset = "0x67DC6E0", VA = "0x1867DDCE0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x67DE030", Offset = "0x67DCA30", VA = "0x1867DE030", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	[Preserve]
	public HCFJOLBHDJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x67DDB80", Offset = "0x67DC580", VA = "0x1867DDB80")]
	[MBJLKJLIAAH(JDACKNHLALI.GameOnly)]
	private static void AEOMHGNMPKA(DPALDOJEBJE GCADPHBJBBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x67DE360", Offset = "0x67DCD60", VA = "0x1867DE360", Slot = "8")]
	public OFEHPCFKLFI NCBKDFJCMBF(string GPCNNKNFCLP, string ALEMLLDGECA, [Optional] PELPDIJCKFF PNJKGAPFPNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x67DDD80", Offset = "0x67DC780", VA = "0x1867DDD80", Slot = "10")]
	public OFEHPCFKLFI DAJEEPKCJLL(PELPDIJCKFF PNJKGAPFPNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x67DDF20", Offset = "0x67DC920", VA = "0x1867DDF20", Slot = "11")]
	public OFEHPCFKLFI IEOHNFPLMLO(PELPDIJCKFF PNJKGAPFPNN, Dictionary<string, string> DGEDJIPAOPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x67DDE80", Offset = "0x67DC880", VA = "0x1867DDE80", Slot = "12")]
	public bool FEOEGENCNAC(string CPPLNMCJEIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x67DE7E0", Offset = "0x67DD1E0", VA = "0x1867DE7E0", Slot = "13")]
	public IKEEJKHGCFM OOHNNONCHCE(string CDFHHFJDBLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x67DE170", Offset = "0x67DCB70", VA = "0x1867DE170", Slot = "14")]
	public KMFKNIOGOCI KBGIEOBBIDG(string CGOCAAGLMFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x67DE270", Offset = "0x67DCC70", VA = "0x1867DE270", Slot = "15")]
	public IKEEJKHGCFM LHLGNLPDIMI(string BKEHBKCHOII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x67DE6E0", Offset = "0x67DD0E0", VA = "0x1867DE6E0", Slot = "16")]
	public OFEHPCFKLFI NHGBJNFAAAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1BADE90", Offset = "0x1BAC890", VA = "0x181BADE90")]
	[CompilerGenerated]
	private void LEPDJBHHLHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x22320F0", Offset = "0x2230AF0", VA = "0x1822320F0")]
	[CompilerGenerated]
	private void BOGEOMGHGAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class BAKBJJPBHBD : KENIFKIDOIC
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool FFCJMMOGLGC
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE80", Offset = "0x7FC880", VA = "0x1807FDE80", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action NEEKBMGCBOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x67DD1D0", Offset = "0x67DBBD0", VA = "0x1867DD1D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x67DD070", Offset = "0x67DBA70", VA = "0x1867DD070", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action DKNJDOILFBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x67DCDF0", Offset = "0x67DB7F0", VA = "0x1867DCDF0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x67DCFD0", Offset = "0x67DB9D0", VA = "0x1867DCFD0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x67DD130", Offset = "0x67DBB30", VA = "0x1867DD130", Slot = "8")]
	public OFEHPCFKLFI NCBKDFJCMBF(string GPCNNKNFCLP, string ALEMLLDGECA, [Optional] PELPDIJCKFF PNJKGAPFPNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x67DCE90", Offset = "0x67DB890", VA = "0x1867DCE90", Slot = "10")]
	public OFEHPCFKLFI DAJEEPKCJLL(PELPDIJCKFF PNJKGAPFPNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x67DCF30", Offset = "0x67DB930", VA = "0x1867DCF30", Slot = "11")]
	public OFEHPCFKLFI IEOHNFPLMLO(PELPDIJCKFF PNJKGAPFPNN, Dictionary<string, string> DGEDJIPAOPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0", Slot = "12")]
	public bool FEOEGENCNAC(string CPPLNMCJEIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x67DD120", Offset = "0x67DBB20", VA = "0x1867DD120", Slot = "13")]
	public IKEEJKHGCFM OOHNNONCHCE(string CDFHHFJDBLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x67DD110", Offset = "0x67DBB10", VA = "0x1867DD110", Slot = "14")]
	public KMFKNIOGOCI KBGIEOBBIDG(string CGOCAAGLMFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x67DD120", Offset = "0x67DBB20", VA = "0x1867DD120", Slot = "15")]
	public IKEEJKHGCFM LHLGNLPDIMI(string BKEHBKCHOII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x67DD270", Offset = "0x67DBC70", VA = "0x1867DD270", Slot = "16")]
	public OFEHPCFKLFI NHGBJNFAAAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public BAKBJJPBHBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EEDILLEMEAC
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FBKKDABKONO ONGJOALJJKM(string HOCCBOHBIIE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DNPJNOEGDPE
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	long BFDJHLCOAAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	long DFGGFACCHMG();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AGJEBDCDBKM(long IAKFKJNNMKI, bool FDNBIELJADD = true);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NNMGMEDABLB(string BKJKDPLKCNE, string CMNPIDNKKFH, string DFJABNMOCKO);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OFJFEGCJNAH(string BKJKDPLKCNE);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IFIAJJPADMP(string BKJKDPLKCNE, string ANEOMKINMOI, string PAMLDAPLMFD);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FJCNDEDEHGP(string FJMCJNMPNJB, object EOLBHPJLGNF, object PFBGFAMHDCP);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BAHDPDJCLFL(string INFEJKJENAL, string NDPNGBBNJDI, DateTime PGDMLILHMNI, string GFDAIBJCMIE, string BKJKDPLKCNE);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PELPDIJCKFF
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool KPPFJFNKDNP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool CFLCKCGELDK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool CANCOGEBNIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool HJPNGGAGPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool? LACBLFKEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int? MJNDDDBADPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int NHLNMPMDOPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	string GBOHHGEGPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string PFLNMEGKIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string HEHMANPJDCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string JPPANKEFHID
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	string CAIDAJAEPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	string BGEEKKGJKBK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	double EBPGKEPCLBL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
namespace AmplitudeAnalytics
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AGAmplitudeAnalyticsSettings : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private AmplitudeAnalyticsClient.Settings editorSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private bool forceEditorSettingsForDevelopers;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public AmplitudeAnalyticsClient.Settings DDGBPFLFHOL
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool FMMPPEIIJFP
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8E9E30", Offset = "0x8E8830", VA = "0x1808E9E30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x877E70", Offset = "0x876870", VA = "0x180877E70")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private enum MKLCFMIADBM
		{
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		internal class OLEEJJAGCBL
		{
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			private class AKNNJHBJLIG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000074")]
				public int PIINJFDFIEC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000075")]
				public Dictionary<string, object> ODJPOBBGIKC;

				[Cpp2IlInjected.Token(Token = "0x60000B9")]
				[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
				public AKNNJHBJLIG()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000015")]
			[CompilerGenerated]
			private sealed class PDIBKFAMOJN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
				public PDIBKFAMOJN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x67E4A30", Offset = "0x67E3430", VA = "0x1867E4A30")]
				internal bool <GetBatch>b__0(AKNNJHBJLIG item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private const string OMMIFNIHLDK = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private readonly string KEADNAEDGGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private List<AKNNJHBJLIG> BLHOIOEKMPF;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public int? JKECCCDJGGK
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0x67E4800", Offset = "0x67E3200", VA = "0x1867E4800")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public int? NKDALBIACIM
			{
				[Cpp2IlInjected.Token(Token = "0x60000AE")]
				[Cpp2IlInjected.Address(RVA = "0x67E40D0", Offset = "0x67E2AD0", VA = "0x1867E40D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x67E48A0", Offset = "0x67E32A0", VA = "0x1867E48A0")]
			internal OLEEJJAGCBL(string BHICMALHIKJ, string ALEMLLDGECA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x67E43E0", Offset = "0x67E2DE0", VA = "0x1867E43E0")]
			public int OIAPIOAEDOG([Optional] int? FBGKNEDNFPN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x67E4570", Offset = "0x67E2F70", VA = "0x1867E4570")]
			public List<Dictionary<string, object>> ONNJLKGOIBJ(int CEDCFPJOEMM, int? FBGKNEDNFPN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x67E3400", Offset = "0x67E1E00", VA = "0x1867E3400")]
			public void DOGPEOJIJNF(AmplitudeAnalyticsIdentifyMessage OMHIFHKMIMJ, bool FEMAPGKEMLD = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x67E34A0", Offset = "0x67E1EA0", VA = "0x1867E34A0")]
			public void DOGPEOJIJNF(Dictionary<string, object> OMHIFHKMIMJ, bool FEMAPGKEMLD = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x67E3F40", Offset = "0x67E2940", VA = "0x1867E3F40")]
			public void LADNDPKJDFB(params Dictionary<string, object>[] OKAAOIFIEFK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x67E4190", Offset = "0x67E2B90", VA = "0x1867E4190")]
			public void LPJAOJFNDEE(List<Dictionary<string, object>> NAHHGBLJBBA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x67E35B0", Offset = "0x67E1FB0", VA = "0x1867E35B0")]
			private void FNDJKIANFCE(Dictionary<string, object> OMHIFHKMIMJ, bool FEMAPGKEMLD = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x67E36F0", Offset = "0x67E20F0", VA = "0x1867E36F0")]
			public void HLABJBEHIDL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x67E3960", Offset = "0x67E2360", VA = "0x1867E3960")]
			private void ILNBGFFPHKA([Optional] string MDOKHCFJJKA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x67E3E10", Offset = "0x67E2810", VA = "0x1867E3E10")]
			private static string KBCJMCIKOPC(string MFBGAMJDOKA, string IGFDDANAMMH)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x67E4E50", Offset = "0x67E3850", VA = "0x1867E4E50")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public struct FEKIKEJBDAP<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public int MDNPDKKCEDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public string NAEHAPINHLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public T FMMGJPIGLPL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class NMBKIJNHLNJ : IEnumerator<FJMKJDOKGFB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private FJMKJDOKGFB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private FJMKJDOKGFB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C7")]
				[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x84FBB0", Offset = "0x84E5B0", VA = "0x18084FBB0")]
			[DebuggerHidden]
			public NMBKIJNHLNJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x67E2430", Offset = "0x67E0E30", VA = "0x1867E2430", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x67E2A20", Offset = "0x67E1420", VA = "0x1867E2A20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class NBPAIBENLPE : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public DGKGHLNCFMM quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x84FBB0", Offset = "0x84E5B0", VA = "0x18084FBB0")]
			[DebuggerHidden]
			public NBPAIBENLPE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x67E2300", Offset = "0x67E0D00", VA = "0x1867E2300", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x67E23F0", Offset = "0x67E0DF0", VA = "0x1867E23F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class IFNNELMBJOB : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D1")]
				[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D3")]
				[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x84FBB0", Offset = "0x84E5B0", VA = "0x18084FBB0")]
			[DebuggerHidden]
			public IFNNELMBJOB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x67DE970", Offset = "0x67DD370", VA = "0x1867DE970", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x67DEAE0", Offset = "0x67DD4E0", VA = "0x1867DEAE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class OFBBJGLFJDJ : IEnumerator<FJMKJDOKGFB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private FJMKJDOKGFB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private FJMKJDOKGFB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D7")]
				[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D9")]
				[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x84FBB0", Offset = "0x84E5B0", VA = "0x18084FBB0")]
			[DebuggerHidden]
			public OFBBJGLFJDJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x67E3120", Offset = "0x67E1B20", VA = "0x1867E3120", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x67E33C0", Offset = "0x67E1DC0", VA = "0x1867E33C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class IHNDADPOKDA : IEnumerator<FJMKJDOKGFB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private FJMKJDOKGFB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			private FJMKJDOKGFB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E0")]
				[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x84FBB0", Offset = "0x84E5B0", VA = "0x18084FBB0")]
			[DebuggerHidden]
			public IHNDADPOKDA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x67DEB20", Offset = "0x67DD520", VA = "0x1867DEB20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x67DEDC0", Offset = "0x67DD7C0", VA = "0x1867DEDC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class KOKOEGNMBCA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public OLEEJJAGCBL cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
			public KOKOEGNMBCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x67DF710", Offset = "0x67DE110", VA = "0x1867DF710")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x67DFA80", Offset = "0x67DE480", VA = "0x1867DFA80")]
			internal void <FlushFromCache>b__1(FEKIKEJBDAP<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class KNNCEGFCAAJ : IEnumerator<FJMKJDOKGFB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private FJMKJDOKGFB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public OLEEJJAGCBL cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private KOKOEGNMBCA <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public int? earlierThanFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public string url;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public string dataIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			private string <apiKey>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private float <startTime>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private bool <timedOut>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private int <batchSize>5__5;

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private FJMKJDOKGFB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x84FBB0", Offset = "0x84E5B0", VA = "0x18084FBB0")]
			[DebuggerHidden]
			public KNNCEGFCAAJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x67DEE00", Offset = "0x67DD800", VA = "0x1867DEE00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x67DF6D0", Offset = "0x67DE0D0", VA = "0x1867DF6D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class HBHDCGGOIKM<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
			public HBHDCGGOIKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x3149CB0", Offset = "0x31486B0", VA = "0x183149CB0")]
			internal FEKIKEJBDAP<T> <PostRudderStackJson>b__0(DIGMLPJGGJK postResponse)
			{
				return default(FEKIKEJBDAP<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class EICBFOJMIAD<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
			public EICBFOJMIAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x3149CB0", Offset = "0x31486B0", VA = "0x183149CB0")]
			internal FEKIKEJBDAP<T> <PostAmplitudeJson>b__0(DIGMLPJGGJK postResponse)
			{
				return default(FEKIKEJBDAP<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private BFKALAACKIL CJGBPPGGMBB;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private const string MAAHLBOAOBA = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private const string OHHEGPNPFLL = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const string PGABAEIMMKJ = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const int GJMNFALCHOJ = 15;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const int IHDICGAAFNL = 10;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const int BADAAMFIOKG = 5;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private const float DPJGHLDMIEN = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private const long BMBNJMDGNJI = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private const string AGAJPMJLHIL = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private const string FFCBPEBGIBB = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static bool FPDDGAGJOGL;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static bool DNBKOBCCLCE;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static int FAFFMJJDFLH;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static int NDMCHBDEDAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private IKOLGEGGJGK PGBBMCAAGED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool KJPDKFOFKIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private float JFIFDIPGNKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private float LACJFNPFKLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int DCOCJGAEGKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int KDOPOFDMCNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int? HBANBJJBCHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int? FEHADCODHHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private long BEJIHLENIAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private string PFLCLGJFCFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private long JOELHKACMCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private Dictionary<string, object> AMMLAOKEAOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private MKLCFMIADBM ONNOJEMNDFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int IHLJPCLOGKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int NNDEGLIHPOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private float HJFDNPBIEKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private bool MAHFEDOKDAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private bool AEIPPPAKJOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private OLEEJJAGCBL MFBOHFDADPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private OLEEJJAGCBL HDLIJFIBMBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private OLEEJJAGCBL KHHLIIFGBBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> IEMLCMGMCIF;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo PBMPDNNPPIG;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static string PGENGINPBHF;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const string GOKFMKLLNGC = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly string JFKKCDJINNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly string DBGMIMMFIOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly string HHLKJBEPCFJ;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private BFKALAACKIL BOCLNNMINBE
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x67DA2E0", Offset = "0x67D8CE0", VA = "0x1867DA2E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private static int JLJILKKBJIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x67D6C80", Offset = "0x67D5680", VA = "0x1867D6C80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static long LGIDPEIODKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x67DB7B0", Offset = "0x67DA1B0", VA = "0x1867DB7B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x67DB8B0", Offset = "0x67DA2B0", VA = "0x1867DB8B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static string MDCLLMMNMEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x67DB750", Offset = "0x67DA150", VA = "0x1867DB750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static string HLMDMAGNIAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x67DB780", Offset = "0x67DA180", VA = "0x1867DB780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string PLFIEHIBJDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9580", VA = "0x1807DAB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7D7870", Offset = "0x7D6270", VA = "0x1807D7870")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int? MJNDDDBADPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x895EB0", Offset = "0x8948B0", VA = "0x180895EB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x882B50", Offset = "0x881550", VA = "0x180882B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool ECLAECIOMJM
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xEFD5B0", Offset = "0xEFBFB0", VA = "0x180EFD5B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xEFD6B0", Offset = "0xEFC0B0", VA = "0x180EFD6B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static bool PCDKFCPFPKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x67DB660", Offset = "0x67DA060", VA = "0x1867DB660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<bool> FPGNHEPJAJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x67DB5C0", Offset = "0x67D9FC0", VA = "0x1867DB5C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x67DB810", Offset = "0x67DA210", VA = "0x1867DB810")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x67D6990", Offset = "0x67D5390", VA = "0x1867D6990", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x67D8690", Offset = "0x67D7090", VA = "0x1867D8690")]
		private void LCNFBPKNAAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x67DAE10", Offset = "0x67D9810", VA = "0x1867DAE10")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x67DA3D0", Offset = "0x67D8DD0", VA = "0x1867DA3D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x67DB100", Offset = "0x67D9B00", VA = "0x1867DB100")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x67DA470", Offset = "0x67D8E70", VA = "0x1867DA470")]
		public OFEHPCFKLFI PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x67D7F80", Offset = "0x67D6980", VA = "0x1867D7F80")]
		[IteratorStateMachine(typeof(NMBKIJNHLNJ))]
		public IEnumerator<FJMKJDOKGFB> Initialize(AmplitudeAnalyticsEvent JBDGNPCOCKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x67DAFF0", Offset = "0x67D99F0", VA = "0x1867DAFF0")]
		public void UpdateLastAliveTime(float KLAJFDPNJJB = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x67D7980", Offset = "0x67D6380", VA = "0x1867D7980")]
		private OFEHPCFKLFI GALKBNMEGPE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x67D83F0", Offset = "0x67D6DF0", VA = "0x1867D83F0")]
		private OFEHPCFKLFI KPLLDEBOEPJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x67DA9C0", Offset = "0x67D93C0", VA = "0x1867DA9C0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x67D7A60", Offset = "0x67D6460", VA = "0x1867D7A60")]
		[IteratorStateMachine(typeof(NBPAIBENLPE))]
		private IEnumerator HDJOJFKDOBO(DGKGHLNCFMM BKDFFCGCBDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x67DB370", Offset = "0x67D9D70", VA = "0x1867DB370")]
		[IteratorStateMachine(typeof(IFNNELMBJOB))]
		public IEnumerator WaitForFlush(float BELNMJHFEGJ = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x67DAED0", Offset = "0x67D98D0", VA = "0x1867DAED0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x67DAE20", Offset = "0x67D9820", VA = "0x1867DAE20")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime DCICKGKMGLG)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x67D7BD0", Offset = "0x67D65D0", VA = "0x1867D7BD0")]
		public static IEDIAHAPDII Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x67D67F0", Offset = "0x67D51F0", VA = "0x1867D67F0")]
		public static LIAJLLJFFCN AccountSelectionPostLoginEvent([NotNull] string GHOJAMDCAPF, string KEGACDNFGON)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x67D7530", Offset = "0x67D5F30", VA = "0x1867D7530")]
		public static LIAJLLJFFCN Event([NotNull] string GHOJAMDCAPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x67DA4D0", Offset = "0x67D8ED0", VA = "0x1867DA4D0")]
		public static LIAJLLJFFCN PreviousSessionEvent([NotNull] string GHOJAMDCAPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x67D7D30", Offset = "0x67D6730", VA = "0x1867D7D30")]
		public static LIAJLLJFFCN InitializeEvent(string KEGACDNFGON)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x67DAB20", Offset = "0x67D9520", VA = "0x1867DAB20")]
		public static LIAJLLJFFCN StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x67D6E50", Offset = "0x67D5850", VA = "0x1867D6E50")]
		public static LIAJLLJFFCN CreateOutOfSessionEvent(string GHOJAMDCAPF, bool GADKCBGJFKH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x67D9B10", Offset = "0x67D8510", VA = "0x1867D9B10")]
		public static OFEHPCFKLFI LogOutOfSessionEvent(LIAJLLJFFCN BGPNBIEOKCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x67D9850", Offset = "0x67D8250", VA = "0x1867D9850")]
		public void LogEventAsync(AmplitudeAnalyticsEvent OMNKOJDKGKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x67D9E20", Offset = "0x67D8820", VA = "0x1867D9E20")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent OMNKOJDKGKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x67D9F70", Offset = "0x67D8970", VA = "0x1867D9F70")]
		public void LogSerializedEventAsync(Dictionary<string, object> BBHFNKEHFOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x67D99A0", Offset = "0x67D83A0", VA = "0x1867D99A0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage CBCPLCFOJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x67D7AF0", Offset = "0x67D64F0", VA = "0x1867D7AF0")]
		private void IOBHHBKIAHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x67DA050", Offset = "0x67D8A50", VA = "0x1867DA050")]
		private void MJCAJHHKADB(Dictionary<string, object> MGLBNGMEPMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x67D7800", Offset = "0x67D6200", VA = "0x1867D7800")]
		private void FPMNBHPACGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x67D80F0", Offset = "0x67D6AF0", VA = "0x1867D80F0")]
		private void KFDPBHCECFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x67D78F0", Offset = "0x67D62F0", VA = "0x1867D78F0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x67DA350", Offset = "0x67D8D50", VA = "0x1867DA350")]
		[IteratorStateMachine(typeof(OFBBJGLFJDJ))]
		private IEnumerator<FJMKJDOKGFB> OMDOGFGKGOO(float BELNMJHFEGJ = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x67D7730", Offset = "0x67D6130", VA = "0x1867D7730")]
		[IteratorStateMachine(typeof(IHNDADPOKDA))]
		private IEnumerator<FJMKJDOKGFB> FAGCEKIDCJM(float BELNMJHFEGJ = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x67D8010", Offset = "0x67D6A10", VA = "0x1867D8010")]
		[IteratorStateMachine(typeof(KNNCEGFCAAJ))]
		private IEnumerator<FJMKJDOKGFB> KDNCCHDIEDA(OLEEJJAGCBL JBCAAIHLJAH, int? FBGKNEDNFPN, string MFAOHKOCGGB, string ILHJLNIFGFC, float BELNMJHFEGJ, Action<int> OHDCDJOCNCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x67D82D0", Offset = "0x67D6CD0", VA = "0x1867D82D0")]
		private static void KMDBMNHCLLA(bool KLIEDEEIKHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x67D7130", Offset = "0x67D5B30", VA = "0x1867D7130")]
		private global::DJAOLOOILHN<FEKIKEJBDAP<Dictionary<string, object>>> DDEJHFKPGGK(string MFAOHKOCGGB, string ILHJLNIFGFC, string AEKJCHLGKED, string ABLBKJGNMGB, Dictionary<string, object> FMMGJPIGLPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x67D7260", Offset = "0x67D5C60", VA = "0x1867D7260")]
		private global::DJAOLOOILHN<FEKIKEJBDAP<List<Dictionary<string, object>>>> DDEJHFKPGGK(string MFAOHKOCGGB, string ILHJLNIFGFC, string AEKJCHLGKED, string ABLBKJGNMGB, List<Dictionary<string, object>> FMMGJPIGLPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3BA43C0", Offset = "0x3BA2DC0", VA = "0x183BA43C0")]
		private global::DJAOLOOILHN<FEKIKEJBDAP<T>> IHDAAOOKFFK<T>(string MFAOHKOCGGB, string ILHJLNIFGFC, string ABLBKJGNMGB, T FMMGJPIGLPL, Dictionary<string, object> LIDPMJHBMAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3BA4080", Offset = "0x3BA2A80", VA = "0x183BA4080")]
		private global::DJAOLOOILHN<FEKIKEJBDAP<T>> AEDMHBPFKDM<T>(string MFAOHKOCGGB, string ILHJLNIFGFC, string AEKJCHLGKED, T FMMGJPIGLPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x67D77B0", Offset = "0x67D61B0", VA = "0x1867D77B0")]
		private bool FOAFGGCIOHD(float FCHMDEEIDME, float BELNMJHFEGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x67D89B0", Offset = "0x67D73B0", VA = "0x1867D89B0")]
		private Dictionary<string, object> LEHKCDNCDCC(string ILHJLNIFGFC, Dictionary<string, object> FMMGJPIGLPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x67DB450", Offset = "0x67D9E50", VA = "0x1867DB450")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x67D96F0", Offset = "0x67D80F0", VA = "0x1867D96F0")]
		[CompilerGenerated]
		private long LFPHBKNPPOJ()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x67D7A50", Offset = "0x67D6450", VA = "0x1867D7A50")]
		[CompilerGenerated]
		private void GLJBDDJLALH(int LNONBINKJKB)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly string uuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly string eventType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly long sequenceNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		internal Dictionary<string, object> eventProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private long sessionId;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x67DC510", Offset = "0x67DAF10", VA = "0x1867DC510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x67DC5D0", Offset = "0x67DAFD0", VA = "0x1867DC5D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x67DC570", Offset = "0x67DAF70", VA = "0x1867DC570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x67DC640", Offset = "0x67DB040", VA = "0x1867DC640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x7D7940", Offset = "0x7D6340", VA = "0x1807D7940")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x67DC040", Offset = "0x67DAA40", VA = "0x1867DC040")]
		public static LIAJLLJFFCN KMLFLFAGFOK(string LHIPGOMOMEB, [NotNull] string DNKACKAGOGL, long IAKFKJNNMKI, long CKBDDABOOCN, string KEGACDNFGON)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x67DC130", Offset = "0x67DAB30", VA = "0x1867DC130")]
		public static LIAJLLJFFCN KPLEKBFACHO(string LHIPGOMOMEB, [NotNull] string DNKACKAGOGL, long IAKFKJNNMKI, long CKBDDABOOCN, string KEGACDNFGON, long KCLNLNMIBFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x67DC350", Offset = "0x67DAD50", VA = "0x1867DC350")]
		private AmplitudeAnalyticsEvent(string LHIPGOMOMEB, [NotNull] string DNKACKAGOGL, long IAKFKJNNMKI, long CKBDDABOOCN, string KEGACDNFGON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xFD6850", Offset = "0xFD5250", VA = "0x180FD6850")]
		public void IDIJMOABEII(long FPCHINFIHAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x67DC230", Offset = "0x67DAC30", VA = "0x1867DC230", Slot = "5")]
		public override void MKDKMPDGFEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x67DBE90", Offset = "0x67DA890", VA = "0x1867DBE90", Slot = "6")]
		public override void EEPBIKPHKEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x67DB910", Offset = "0x67DA310", VA = "0x1867DB910", Slot = "4")]
		protected override Dictionary<string, object> BHMAMAMNFLN(Dictionary<string, object> CFJFPPOBNMO)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class AmplitudeAnalyticsIdentifyMessage
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public class DeviceInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public string platform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public string osName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public string osVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public string deviceBrand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public string deviceManufacturer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public string deviceModel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public string deviceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public string carrier;

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x67DD310", Offset = "0x67DBD10", VA = "0x1867DD310")]
			public void ALFCJIGMKHM(Dictionary<string, object> PBNHBGLIMKN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public class RevenueData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public float price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public float revenue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string productId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public string revenueType;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x67E4A90", Offset = "0x67E3490", VA = "0x1867E4A90")]
			public void ALFCJIGMKHM(Dictionary<string, object> BMIOJNLDNAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x246BBD0", Offset = "0x246A5D0", VA = "0x18246BBD0")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		internal DeviceInfo deviceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		internal RevenueData revenueData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly string buildVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		internal Dictionary<string, object> userProperties;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x7D2880", Offset = "0x7D1280", VA = "0x1807D2880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x67DCB60", Offset = "0x67DB560", VA = "0x1867DCB60")]
		public static IEDIAHAPDII KMLFLFAGFOK(string LHIPGOMOMEB, string KEGACDNFGON)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x67DCD30", Offset = "0x67DB730", VA = "0x1867DCD30")]
		protected AmplitudeAnalyticsIdentifyMessage(string LHIPGOMOMEB, string KEGACDNFGON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x67DCAE0", Offset = "0x67DB4E0", VA = "0x1867DCAE0")]
		public Dictionary<string, object> JGENDKHBLCG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x67DC6B0", Offset = "0x67DB0B0", VA = "0x1867DC6B0", Slot = "4")]
		protected virtual Dictionary<string, object> BHMAMAMNFLN(Dictionary<string, object> CFJFPPOBNMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x67DCC10", Offset = "0x67DB610", VA = "0x1867DCC10")]
		protected void LEAONHJKKMA(string IGFDDANAMMH, Dictionary<string, object> KNOKEHJCNDL, Dictionary<string, object> MLPOAJPKEHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x67DCA70", Offset = "0x67DB470", VA = "0x1867DCA70")]
		protected void FDJLBEDDHJI(string IGFDDANAMMH, string MFBGAMJDOKA, Dictionary<string, object> EFMBJGPJNLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x67DCCB0", Offset = "0x67DB6B0", VA = "0x1867DCCB0", Slot = "5")]
		public virtual void MKDKMPDGFEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x67DC9F0", Offset = "0x67DB3F0", VA = "0x1867DC9F0", Slot = "6")]
		public virtual void EEPBIKPHKEL()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class IEDIAHAPDII : global::FMCPBAJNJHN<AmplitudeAnalyticsIdentifyMessage, IEDIAHAPDII>
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public override IEDIAHAPDII OKKBMCFENGA
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8426B0", Offset = "0x8410B0", VA = "0x1808426B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage OMPNFBKIFGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x67DE920", Offset = "0x67DD320", VA = "0x1867DE920")]
	public IEDIAHAPDII(AmplitudeAnalyticsIdentifyMessage MDEEJIBNIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x67DE880", Offset = "0x67DD280", VA = "0x1867DE880", Slot = "4")]
	public override void EEPBIKPHKEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class LIAJLLJFFCN : global::FMCPBAJNJHN<AmplitudeAnalyticsEvent, LIAJLLJFFCN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private bool BIBIFGEDJOJ;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public override LIAJLLJFFCN OKKBMCFENGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8426B0", Offset = "0x8410B0", VA = "0x1808426B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public long MEAAJOPAEAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x403B400", Offset = "0x4039E00", VA = "0x18403B400")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x67D67A0", Offset = "0x67D51A0", VA = "0x1867D67A0")]
	public LIAJLLJFFCN(AmplitudeAnalyticsEvent MDEEJIBNIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "5")]
	public override AmplitudeAnalyticsEvent OMPNFBKIFGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x67DFF20", Offset = "0x67DE920", VA = "0x1867DFF20", Slot = "4")]
	public override void EEPBIKPHKEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x67E0230", Offset = "0x67DEC30", VA = "0x1867E0230")]
	public LIAJLLJFFCN HHODGEBAHOE(string EELLPGLCOLL, long[] MFBGAMJDOKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x67E0060", Offset = "0x67DEA60", VA = "0x1867E0060")]
	public LIAJLLJFFCN HHODGEBAHOE(string EELLPGLCOLL, ulong[] MFBGAMJDOKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x36FF7D0", Offset = "0x36FE1D0", VA = "0x1836FF7D0")]
	public LIAJLLJFFCN HHODGEBAHOE<T>(string EELLPGLCOLL, T[] MFBGAMJDOKA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x67E0470", Offset = "0x67DEE70", VA = "0x1867E0470")]
	public LIAJLLJFFCN HHODGEBAHOE(string EELLPGLCOLL, string[] MFBGAMJDOKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x36FF760", Offset = "0x36FE160", VA = "0x1836FF760")]
	public LIAJLLJFFCN HHODGEBAHOE<T>(string EELLPGLCOLL, T MFBGAMJDOKA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x67E03E0", Offset = "0x67DEDE0", VA = "0x1867E03E0")]
	public LIAJLLJFFCN HHODGEBAHOE(string EELLPGLCOLL, long MFBGAMJDOKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x67E01A0", Offset = "0x67DEBA0", VA = "0x1867E01A0")]
	public LIAJLLJFFCN HHODGEBAHOE(string EELLPGLCOLL, ulong MFBGAMJDOKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x67E0370", Offset = "0x67DED70", VA = "0x1867E0370")]
	public LIAJLLJFFCN HHODGEBAHOE(string EELLPGLCOLL, string MFBGAMJDOKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x67E0480", Offset = "0x67DEE80", VA = "0x1867E0480")]
	public LIAJLLJFFCN MJEGBEBFJLI(string EELLPGLCOLL, object? MFBGAMJDOKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x67DFFC0", Offset = "0x67DE9C0", VA = "0x1867DFFC0")]
	public LIAJLLJFFCN HBMFKCCLLEC(string EELLPGLCOLL, string MFBGAMJDOKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x67E04A0", Offset = "0x67DEEA0", VA = "0x1867E04A0")]
	private LIAJLLJFFCN PBDELDPAPOG(string EELLPGLCOLL, object MFBGAMJDOKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class AGCHDPHKAGG : LIAJLLJFFCN
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x67D67A0", Offset = "0x67D51A0", VA = "0x1867D67A0")]
	public AGCHDPHKAGG(AmplitudeAnalyticsEvent MDEEJIBNIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x67D65E0", Offset = "0x67D4FE0", VA = "0x1867D65E0", Slot = "4")]
	public override void EEPBIKPHKEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class FMCPBAJNJHN<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::FMCPBAJNJHN<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	protected M MDEEJIBNIAD;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public abstract BLDR OKKBMCFENGA
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x34E7CA0", Offset = "0x34E66A0", VA = "0x1834E7CA0")]
	public FMCPBAJNJHN(M MDEEJIBNIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x361BD50", Offset = "0x361A750", VA = "0x18361BD50")]
	public BLDR PNHKNMAHBAD(AmplitudeAnalyticsIdentifyMessage.DeviceInfo KAILKJKCNCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x361BCE0", Offset = "0x361A6E0", VA = "0x18361BCE0")]
	public BLDR NIPDEPPBAND(AmplitudeAnalyticsIdentifyMessage.RevenueData CFHCEHPPPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x361BC70", Offset = "0x361A670", VA = "0x18361BC70")]
	public BLDR CLAAEMKCCOB(string EELLPGLCOLL, string MFBGAMJDOKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3559540", Offset = "0x3557F40", VA = "0x183559540")]
	public BLDR CLAAEMKCCOB<T>(string EELLPGLCOLL, T MFBGAMJDOKA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x361BBC0", Offset = "0x361A5C0", VA = "0x18361BBC0")]
	public BLDR CLAAEMKCCOB(string EELLPGLCOLL, long MFBGAMJDOKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x361BB10", Offset = "0x361A510", VA = "0x18361BB10")]
	public BLDR CLAAEMKCCOB(string EELLPGLCOLL, ulong MFBGAMJDOKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void EEPBIKPHKEL();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x361BD20", Offset = "0x361A720", VA = "0x18361BD20")]
	internal static string OFGMFMNENIG(string MFBGAMJDOKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x361BA20", Offset = "0x361A420", VA = "0x18361BA20")]
	private BLDR BJJAKKHKLPL(string EELLPGLCOLL, object MFBGAMJDOKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M OMPNFBKIFGA();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class NCIJGALNBHI
{
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const string NKCJKNNLOJG = "batch";

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public const string CPNPFLMACDA = "type";

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public const string BBPLLNABDCH = "identify";

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const string KPOCLAOBLGE = "track";

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const string HHLLLGMOOHG = "userId";

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public const string HDBFBCHPPLB = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public const string LLHLFJJLFCP = "stable_id";

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public const string IAMBFENLDFB = "messageId";

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public const string ALFAOMKIFKC = "event";

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public const string FJKEFIINPEF = "version";

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public const string JPIPBCFNLDB = "locale";

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public const string COCCMLHMEFG = "name";

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public const string IJBBGPBCBJL = "properties";

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const string JLBIEDOBOHI = "traits";

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public const string BCDJJBJPKLF = "context";

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public const string LAGGCFGICHO = "app";

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public const string IAFFGDOJGNH = "os";

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public const string GHFIEKOMGOD = "device";

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const string OJPPNELPLFC = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const string GNIENAMHONN = "brand";

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public const string MGOHBAEEGOF = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public const string BLCFIOLIMAJ = "model";

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const string ADGKLOELBPC = "type";

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public NCIJGALNBHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class GACIJBIJMNP
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public const int IHEBALOIGPP = 2;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const int OHFLKFEBGPA = 100;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const int GIAADENGDFI = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const long EMNPNJDEPLD = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public const int EFBJAHBFMIP = 1024;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public const int FFKLOKBMEIE = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public const string BNCFAIPHFNE = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public const string PIAHCIAOKBI = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public const string APHGHMPBKIL = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public const string NNDKFDNDNJH = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public const string BKPCIBPIHKG = "session_start";

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public const string CAPPDDMBAEL = "session_end";

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public const string BJNENCNBMIC = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public const string CJCKJPPACKA = "event_time";

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public const string IPIOPIPMKEG = "session_id";

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public const string AENCLHHGEIC = "session_tracking_data";

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public const string FMLENGOCCPI = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public const string CPDCAKJJDJO = "app_version";

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public const string HBIIOKONMFA = "ip";

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public const string HNFNEBMFAFN = "language";

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public const string LLHLFJJLFCP = "stable_id";

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public const string JNOOEBKABKC = "platform";

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public const string PLBKMLBCHLP = "os_name";

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public const string FLFMGJHMOKN = "os_version";

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public const string DBPMFNKAJJJ = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public const string IDLHNFFAGCB = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public const string DPAGDJEIOHL = "device_model";

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public const string DPIJBCMFCMF = "device_type";

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public const string LDDPAKPIJDJ = "price";

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public const string LCLMBADCLNO = "quantity";

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public const string LMDBMHDHOIK = "revenue";

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public const string EFDHFLCMLEN = "productId";

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public const string KMKGAPOMAAD = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public const string INGCBGPPDFC = "event_type";

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public const string HHLLLGMOOHG = "user_id";

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public const string NBCPFDAGKLK = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public const int KBBFOKCHNCK = 10;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> CMHFLLPMINL;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x67DD9D0", Offset = "0x67DC3D0", VA = "0x1867DD9D0")]
	internal static bool IOBKDPKGGCH(string IGFDDANAMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public GACIJBIJMNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface IKOLGEGGJGK
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool LHONIKKACIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string EEGJKOHAJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string LLMJMFEDBLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	string PACPLOGPGEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	string KNIPGMAGFMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::DJAOLOOILHN<DIGMLPJGGJK> DDEJHFKPGGK(string MFAOHKOCGGB, Dictionary<string, string> KOACCGAECIP, bool AFGJGNJOGII = false);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::DJAOLOOILHN<DIGMLPJGGJK> NODJDIBEMON(string MFAOHKOCGGB, string HKHPACLFMJF, string GBCFLALFNHO, string EKOBFCCBLHL);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct DIGMLPJGGJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public readonly int JFHAPGJPEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public readonly string JJJEODHGIPE;

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0xA34BF0", Offset = "0xA335F0", VA = "0x180A34BF0")]
	public DIGMLPJGGJK(int MDNPDKKCEDM, string NAEHAPINHLO)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class NNIFMOPFNIE
{
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static byte[] FNNHBCFPBIC;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static int IPKGAJADJFC;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static int DIJMLDGECMG;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static BigInteger DGOGINAIMEE;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public NNIFMOPFNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x67E2A60", Offset = "0x67E1460", VA = "0x1867E2A60")]
	private static string DAIOEIOFDHG(byte[] LPDJCHOFJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x67E2B70", Offset = "0x67E1570", VA = "0x1867E2B70")]
	public static string LIOEFPBPBEO(byte[] AHIMNOMEIMA, bool ADOOPHPHCDD)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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

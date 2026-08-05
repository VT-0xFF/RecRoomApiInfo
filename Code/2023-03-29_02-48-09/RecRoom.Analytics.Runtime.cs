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
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x62624F0", Offset = "0x62612F0", VA = "0x1862624F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x740BD0", Offset = "0x73F9D0", VA = "0x180740BD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB9A310", Offset = "0xB99110", VA = "0x180B9A310")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum FLKBFPIBDIH
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
public class GKNGCFPIOGN
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private const string APMMIGNOEJA = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private const string MEBFILPENNP = "flowName";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const string MGICLKIKJED = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private const string DNNLDOBMGEH = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const string PNADNPGNBHF = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const string ALOHGOIFAEL = "failure";

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const string HJPJGILKNCC = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long DEDFIJJDILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private OMMKAKFNCEO CGIEFDEGECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool POGDBHHAIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private float IFIBOFBDBHD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x625BBE0", Offset = "0x625A9E0", VA = "0x18625BBE0")]
	public GKNGCFPIOGN(string LCKNHIHMLAL, float IFIBOFBDBHD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x228EF00", Offset = "0x228DD00", VA = "0x18228EF00")]
	public void FGKPEJLAOBO<T>(string PEJFAKHLGCN, T NLHFEJHKLAH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x625B900", Offset = "0x625A700", VA = "0x18625B900")]
	public void FGKPEJLAOBO(string PEJFAKHLGCN, string NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x625BAF0", Offset = "0x625A8F0", VA = "0x18625BAF0")]
	public void NJFDAMPEKLC(string CLHIMJHIJHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x625B840", Offset = "0x625A640", VA = "0x18625B840")]
	public void AKMANGJGIAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x625B980", Offset = "0x625A780", VA = "0x18625B980")]
	private void HDBCGPELHKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x625BAA0", Offset = "0x625A8A0", VA = "0x18625BAA0")]
	private bool IAIDADDEJAG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MGFDLFIFDLL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CKBGNMHNINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action GMDJPPLJJMJ;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action EPJFEHDEOLH;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LMAPELGHNPL GIHONBOCKDC(string ICCPOBMKHGJ, string KIOKDLLNPKO, [Optional] HDINBDBDCCC CLKJFAHCNME);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LMAPELGHNPL MFLGLGGONPB(HDINBDBDCCC CLKJFAHCNME);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LMAPELGHNPL LKIMFIBFGMO(HDINBDBDCCC CLKJFAHCNME, Dictionary<string, string> OHJAJKPMGCL);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DJKCMNDILNM(string DDKCLLJFKPC);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NDHJFFILMBD IGGIKLODOJM(string DDMALLIIPEG);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BMDIMGKOMFO FODBBNHDMGE(string GOAKBBBEPON);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NDHJFFILMBD NDFCONEBFNA(string OEMAPEMFAPH);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "12")]
	LMAPELGHNPL HFOFKLBBMPL();
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
			[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6262F90", Offset = "0x6261D90", VA = "0x186262F90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class KNECIDBHHFK : MGFDLFIFDLL
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private const string HJEGCOCGAJC = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private const string HNKBICMLHFA = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private const string FPOLPPHGFOO = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private const string DNAIGONKHFC = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private const string OKIIMPHACAL = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private const string JAHDMFNMEKE = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private const string FPBEKGMGKBK = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private const string MPLOIIPNHCO = "AccountCreationTimeAfterEpochMilliseconds";

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private const string KNFLBHMNGMM = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private const string NNJGBJNFKKL = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private const string GMDMDAAOIOF = "LocaleName";

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly IReadOnlyDictionary<string, FPPGAPPIPEN> CHFNLPODCDA;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private const int PGEOJHGPDNK = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool HELOIDLBHJI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool CKBGNMHNINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x792380", Offset = "0x791180", VA = "0x180792380", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action GMDJPPLJJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x625E540", Offset = "0x625D340", VA = "0x18625E540", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x625E280", Offset = "0x625D080", VA = "0x18625E280", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action EPJFEHDEOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x625D2D0", Offset = "0x625C0D0", VA = "0x18625D2D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x625DDD0", Offset = "0x625CBD0", VA = "0x18625DDD0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x625D600", Offset = "0x625C400", VA = "0x18625D600", Slot = "8")]
	public LMAPELGHNPL GIHONBOCKDC(string ICCPOBMKHGJ, string KIOKDLLNPKO, [Optional] HDINBDBDCCC CLKJFAHCNME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x625DC40", Offset = "0x625CA40", VA = "0x18625DC40", Slot = "16")]
	public LMAPELGHNPL HFOFKLBBMPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x625E320", Offset = "0x625D120", VA = "0x18625E320", Slot = "10")]
	public LMAPELGHNPL MFLGLGGONPB(HDINBDBDCCC CLKJFAHCNME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x625DF90", Offset = "0x625CD90", VA = "0x18625DF90", Slot = "11")]
	public LMAPELGHNPL LKIMFIBFGMO(HDINBDBDCCC CLKJFAHCNME, Dictionary<string, string> OHJAJKPMGCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x625D400", Offset = "0x625C200", VA = "0x18625D400", Slot = "12")]
	public bool DJKCMNDILNM(string DDKCLLJFKPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x625DE70", Offset = "0x625CC70", VA = "0x18625DE70", Slot = "13")]
	public NDHJFFILMBD IGGIKLODOJM(string DDMALLIIPEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x625D4B0", Offset = "0x625C2B0", VA = "0x18625D4B0", Slot = "14")]
	public BMDIMGKOMFO FODBBNHDMGE(string GOAKBBBEPON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x625E5E0", Offset = "0x625D3E0", VA = "0x18625E5E0", Slot = "15")]
	public NDHJFFILMBD NDFCONEBFNA(string OEMAPEMFAPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x625E6D0", Offset = "0x625D4D0", VA = "0x18625E6D0")]
	private FCBNPODEEKJ ONPFCFFPHJC(HDINBDBDCCC CLKJFAHCNME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x625DAA0", Offset = "0x625C8A0", VA = "0x18625DAA0")]
	private NMMNAEDFFCD HAOHBDJCLGF(string KIOKDLLNPKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x625ECC0", Offset = "0x625DAC0", VA = "0x18625ECC0")]
	private void PEEBPFNEFJG(string DDMALLIIPEG, NDHJFFILMBD KJJGPOAAHIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public KNECIDBHHFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xBD3820", Offset = "0xBD2620", VA = "0x180BD3820")]
	[CompilerGenerated]
	private void MLMBIOFNNAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x625D570", Offset = "0x625C370", VA = "0x18625D570")]
	[CompilerGenerated]
	private void FPDFJDEAJMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x625D370", Offset = "0x625C170", VA = "0x18625D370")]
	[CompilerGenerated]
	private void DAEGKANBHGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class MNHHACONDGK : MGFDLFIFDLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private MGFDLFIFDLL AFEOMMDGGKB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private MGFDLFIFDLL AHBOCLNKFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x625FF60", Offset = "0x625ED60", VA = "0x18625FF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool CKBGNMHNINE
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6260410", Offset = "0x625F210", VA = "0x186260410", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action GMDJPPLJJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6260370", Offset = "0x625F170", VA = "0x186260370", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x62600E0", Offset = "0x625EEE0", VA = "0x1862600E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action EPJFEHDEOLH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x625F800", Offset = "0x625E600", VA = "0x18625F800", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x625FE20", Offset = "0x625EC20", VA = "0x18625FE20", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	[Preserve]
	public MNHHACONDGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6260280", Offset = "0x625F080", VA = "0x186260280")]
	[NPBDMCLHPNM(AIJEIIPHIJH.GameOnly)]
	private static void MLABOGLCIBB(HKDBAIGILEN DHPFLPHCDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x625FA40", Offset = "0x625E840", VA = "0x18625FA40", Slot = "8")]
	public LMAPELGHNPL GIHONBOCKDC(string ICCPOBMKHGJ, string KIOKDLLNPKO, [Optional] HDINBDBDCCC CLKJFAHCNME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6260180", Offset = "0x625EF80", VA = "0x186260180", Slot = "10")]
	public LMAPELGHNPL MFLGLGGONPB(HDINBDBDCCC CLKJFAHCNME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x625FFD0", Offset = "0x625EDD0", VA = "0x18625FFD0", Slot = "11")]
	public LMAPELGHNPL LKIMFIBFGMO(HDINBDBDCCC CLKJFAHCNME, Dictionary<string, string> OHJAJKPMGCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x625F8A0", Offset = "0x625E6A0", VA = "0x18625F8A0", Slot = "12")]
	public bool DJKCMNDILNM(string DDKCLLJFKPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x625FEC0", Offset = "0x625ECC0", VA = "0x18625FEC0", Slot = "13")]
	public NDHJFFILMBD IGGIKLODOJM(string DDMALLIIPEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x625F940", Offset = "0x625E740", VA = "0x18625F940", Slot = "14")]
	public BMDIMGKOMFO FODBBNHDMGE(string GOAKBBBEPON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6260460", Offset = "0x625F260", VA = "0x186260460", Slot = "15")]
	public NDHJFFILMBD NDFCONEBFNA(string OEMAPEMFAPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x625FD20", Offset = "0x625EB20", VA = "0x18625FD20", Slot = "16")]
	public LMAPELGHNPL HFOFKLBBMPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x115F050", Offset = "0x115DE50", VA = "0x18115F050")]
	[CompilerGenerated]
	private void BBCHPGJBMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1502630", Offset = "0x1501430", VA = "0x181502630")]
	[CompilerGenerated]
	private void DNEELHIANGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class KJFPFDAILAO : MGFDLFIFDLL
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool CKBGNMHNINE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x70F850", Offset = "0x70E650", VA = "0x18070F850", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action GMDJPPLJJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x625D230", Offset = "0x625C030", VA = "0x18625D230", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x625D0F0", Offset = "0x625BEF0", VA = "0x18625D0F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action EPJFEHDEOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x625CDB0", Offset = "0x625BBB0", VA = "0x18625CDB0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x625CFA0", Offset = "0x625BDA0", VA = "0x18625CFA0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x625CE60", Offset = "0x625BC60", VA = "0x18625CE60", Slot = "8")]
	public LMAPELGHNPL GIHONBOCKDC(string ICCPOBMKHGJ, string KIOKDLLNPKO, [Optional] HDINBDBDCCC CLKJFAHCNME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x625D190", Offset = "0x625BF90", VA = "0x18625D190", Slot = "10")]
	public LMAPELGHNPL MFLGLGGONPB(HDINBDBDCCC CLKJFAHCNME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x625D050", Offset = "0x625BE50", VA = "0x18625D050", Slot = "11")]
	public LMAPELGHNPL LKIMFIBFGMO(HDINBDBDCCC CLKJFAHCNME, Dictionary<string, string> OHJAJKPMGCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x70F8E0", Offset = "0x70E6E0", VA = "0x18070F8E0", Slot = "12")]
	public bool DJKCMNDILNM(string DDKCLLJFKPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x625D040", Offset = "0x625BE40", VA = "0x18625D040", Slot = "13")]
	public NDHJFFILMBD IGGIKLODOJM(string DDMALLIIPEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x625CE50", Offset = "0x625BC50", VA = "0x18625CE50", Slot = "14")]
	public BMDIMGKOMFO FODBBNHDMGE(string GOAKBBBEPON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x625D040", Offset = "0x625BE40", VA = "0x18625D040", Slot = "15")]
	public NDHJFFILMBD NDFCONEBFNA(string OEMAPEMFAPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x625CF00", Offset = "0x625BD00", VA = "0x18625CF00", Slot = "16")]
	public LMAPELGHNPL HFOFKLBBMPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public KJFPFDAILAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JJBNIOKKEAK
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GKNGCFPIOGN LIKFLIBFCEG(string LCKNHIHMLAL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BOHGMEODGFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACEDFLDLEAM(string KPEPJOHCOMD, string MBPAOFINIMI, string EEOBDAFOJDO);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NIPEOFFAJGD(string KPEPJOHCOMD);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MEDFKKFMFOL(string KPEPJOHCOMD, string CLDPDLKBLBC, string MIGJIEEOAEJ);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PNACDGHHCDE(string LENENIMKCMC, object GJELCFEMHPI, object INODNMNEPHB);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HPONMKPKEIC(long LOOHFCCDDLN, bool FOMNJDAKOMM = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HDINBDBDCCC
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool JLGFNBIAIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool CDEKDINDEOB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool ECBLGEOEFGC
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool ELJEMGFPFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool? GJDGGJFLBFA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int? EPMIMBJKOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int KNGAGKADLDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string MHHPBEBLGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	string NOHAFJKLCOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string NFGOABACGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string CMBBMAHAHPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string PEEOKOMDELI
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	string BEALKDGLOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	double BFALMBEJHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
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

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public AmplitudeAnalyticsClient.Settings BKNOGDKFMGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool NAKJHIJPMKK
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7F1340", Offset = "0x7F0140", VA = "0x1807F1340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6FA110", Offset = "0x6F8F10", VA = "0x1806FA110")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private enum DBMHFKOLNGC
		{
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		internal class NAAFBMFGIEH
		{
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			private class GIPPCKJLONJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000074")]
				public int OEMOIAIAMJC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000075")]
				public Dictionary<string, object> GHKKNONAFOF;

				[Cpp2IlInjected.Token(Token = "0x60000B6")]
				[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
				public GIPPCKJLONJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000015")]
			[CompilerGenerated]
			private sealed class MGLJDPHPEPP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x60000B7")]
				[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
				public MGLJDPHPEPP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000B8")]
				[Cpp2IlInjected.Address(RVA = "0x625F7A0", Offset = "0x625E5A0", VA = "0x18625F7A0")]
				internal bool <GetBatch>b__0(GIPPCKJLONJ item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private const string ENMKKDNHLHE = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private readonly string BOFDAKKMDPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private List<GIPPCKJLONJ> BNCBBMBKCKH;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public int? CGANDFDAFFD
			{
				[Cpp2IlInjected.Token(Token = "0x60000AA")]
				[Cpp2IlInjected.Address(RVA = "0x6261750", Offset = "0x6260550", VA = "0x186261750")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public int? BHGFOGDGNAO
			{
				[Cpp2IlInjected.Token(Token = "0x60000AB")]
				[Cpp2IlInjected.Address(RVA = "0x6261690", Offset = "0x6260490", VA = "0x186261690")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x62619A0", Offset = "0x62607A0", VA = "0x1862619A0")]
			internal NAAFBMFGIEH(string OFLMIKCIEOA, string KIOKDLLNPKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x62610E0", Offset = "0x625FEE0", VA = "0x1862610E0")]
			public int JJHEDAHNEMO([Optional] int? CBOBPOJIDJM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x6261270", Offset = "0x6260070", VA = "0x186261270")]
			public List<Dictionary<string, object>> JLMPHMKFJHG(int DEAPMPKEAKO, int? CBOBPOJIDJM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x6261900", Offset = "0x6260700", VA = "0x186261900")]
			public void OJOPGHFLJJP(AmplitudeAnalyticsIdentifyMessage BLIKPCIFNNO, bool EHPHLGAIKAA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x62617F0", Offset = "0x62605F0", VA = "0x1862617F0")]
			public void OJOPGHFLJJP(Dictionary<string, object> BLIKPCIFNNO, bool EHPHLGAIKAA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x6261500", Offset = "0x6260300", VA = "0x186261500")]
			public void JPLPIPEAPFO(params Dictionary<string, object>[] HAJEEKDAFMP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6260500", Offset = "0x625F300", VA = "0x186260500")]
			public void EIPJFFNEGMB(List<Dictionary<string, object>> FDAIHHDHPBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6260E70", Offset = "0x625FC70", VA = "0x186260E70")]
			private void HLCDNDKIMDL(Dictionary<string, object> BLIKPCIFNNO, bool EHPHLGAIKAA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6260750", Offset = "0x625F550", VA = "0x186260750")]
			public void FCIBDMKIBLN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x62609C0", Offset = "0x625F7C0", VA = "0x1862609C0")]
			private void GLBOIDJJNJD([Optional] string MDBLNPOALIM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6260FB0", Offset = "0x625FDB0", VA = "0x186260FB0")]
			private static string HNJPKCMJMOH(string NLHFEJHKLAH, string ANFHHLAHMJD)
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

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x62631E0", Offset = "0x6261FE0", VA = "0x1862631E0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public struct LJHCIEDLLII<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public int DAEIHIKJHCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public string CFKFFCMMFNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public T DCMPFMNCCJE;
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class IMNBFCPMNDE : IEnumerator<FFIMBIIMMMD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private FFIMBIIMMMD <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private FFIMBIIMMMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x8A7890", Offset = "0x8A6690", VA = "0x1808A7890")]
			[DebuggerHidden]
			public IMNBFCPMNDE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x625C780", Offset = "0x625B580", VA = "0x18625C780", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x625CD70", Offset = "0x625BB70", VA = "0x18625CD70", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class LKLPCKHJHPN : IEnumerator<object>, IEnumerator, IDisposable
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
			public NGNPLNHEGFI quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8A7890", Offset = "0x8A6690", VA = "0x1808A7890")]
			[DebuggerHidden]
			public LKLPCKHJHPN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x625F670", Offset = "0x625E470", VA = "0x18625F670", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x625F760", Offset = "0x625E560", VA = "0x18625F760", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class EHHINKEEMMC : IEnumerator<object>, IEnumerator, IDisposable
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

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x8A7890", Offset = "0x8A6690", VA = "0x1808A7890")]
			[DebuggerHidden]
			public EHHINKEEMMC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x625B690", Offset = "0x625A490", VA = "0x18625B690", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x625B800", Offset = "0x625A600", VA = "0x18625B800", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class DLKCMDLBKPK : IEnumerator<FFIMBIIMMMD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private FFIMBIIMMMD <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private FFIMBIIMMMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D6")]
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x8A7890", Offset = "0x8A6690", VA = "0x1808A7890")]
			[DebuggerHidden]
			public DLKCMDLBKPK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x625B230", Offset = "0x625A030", VA = "0x18625B230", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x625B4D0", Offset = "0x625A2D0", VA = "0x18625B4D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class DKKCNGBJLCB : IEnumerator<FFIMBIIMMMD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private FFIMBIIMMMD <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private FFIMBIIMMMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DF")]
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x8A7890", Offset = "0x8A6690", VA = "0x1808A7890")]
			[DebuggerHidden]
			public DKKCNGBJLCB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x625AF50", Offset = "0x6259D50", VA = "0x18625AF50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x625B1F0", Offset = "0x6259FF0", VA = "0x18625B1F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class NEJLCNLGNKG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public NAAFBMFGIEH cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
			public NEJLCNLGNKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x6261B30", Offset = "0x6260930", VA = "0x186261B30")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x6261EA0", Offset = "0x6260CA0", VA = "0x186261EA0")]
			internal void <FlushFromCache>b__1(LJHCIEDLLII<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class HHOAFILDKDE : IEnumerator<FFIMBIIMMMD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private FFIMBIIMMMD <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public NAAFBMFGIEH cache;

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
			private NEJLCNLGNKG <>8__1;

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

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private FFIMBIIMMMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E6")]
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x8A7890", Offset = "0x8A6690", VA = "0x1808A7890")]
			[DebuggerHidden]
			public HHOAFILDKDE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x625BE70", Offset = "0x625AC70", VA = "0x18625BE70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x625C740", Offset = "0x625B540", VA = "0x18625C740", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class JDMCEPDDHDF<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
			public JDMCEPDDHDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x2F469D0", Offset = "0x2F457D0", VA = "0x182F469D0")]
			internal LJHCIEDLLII<T> <PostRudderStackJson>b__0(OGILIMCEGOM postResponse)
			{
				return default(LJHCIEDLLII<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class JHAHCMBGBOG<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
			public JHAHCMBGBOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x2F469D0", Offset = "0x2F457D0", VA = "0x182F469D0")]
			internal LJHCIEDLLII<T> <PostAmplitudeJson>b__0(OGILIMCEGOM postResponse)
			{
				return default(LJHCIEDLLII<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private CIKFDIBBBFD MNBLJNNFFIF;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private const string DKHIHGPGIKJ = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private const string EJBMGDDLOPN = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const string JFIJKJEAIOD = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const int NNCKNPEKIOC = 15;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const int JGDHPNMOFHL = 10;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const int MFOHFDOMDIG = 5;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private const float JPKMFADGFHN = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private const long AFKOOPELLAF = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private const string BIPJAMIGKHK = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private const string KFMPLHGJNBD = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static bool HPMNDMHLIEI;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static bool FLKBFHKNHFA;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static int NPHBADCILOO;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static int KGECHOINHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private MFFEGPNBCCA PLLEPJJGMEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool APMNLLGMMAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private float HEDFLMKMBFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private float NHGLHBILBOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int DINKFPIJIOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int DKFKIIPNIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int? FJGJNDOHNLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int? JJPJJFABNLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private long BKGFJJKEBBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private string CMBKNJJCEHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private long ABGEBHMGHLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private Dictionary<string, object> AINJOIDLJIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private DBMHFKOLNGC ANHFLICDJOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int CFPCJLIMPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int AAHHBEJKNJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private float NDMDJHJHFJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private bool IFMHGNPIHEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private bool EHCALOPGLIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private NAAFBMFGIEH HNCMLLNICCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private NAAFBMFGIEH EEOCLKLAKHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private NAAFBMFGIEH COMNFBOMKLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> GOAJHJBJHAG;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo EFPKDIOPNBI;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static string PNLJHHIMJFF;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const string NMKFGNJKDJN = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly string PEFABNHLCCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly string EOALHIEHDAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly string GJEIMBHMOCD;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private CIKFDIBBBFD BJOCFCMMDIB
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x62569A0", Offset = "0x62557A0", VA = "0x1862569A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private static int OBPPLDJENCB
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x62580A0", Offset = "0x6256EA0", VA = "0x1862580A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static long HNONBICCPGK
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x6259A70", Offset = "0x6258870", VA = "0x186259A70")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6259B70", Offset = "0x6258970", VA = "0x186259B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static string MONAOKIJPMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6259A10", Offset = "0x6258810", VA = "0x186259A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static string NPAIHDDGNJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6259A40", Offset = "0x6258840", VA = "0x186259A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string MPJAFILPICK
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x7022F0", Offset = "0x7010F0", VA = "0x1807022F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x7025C0", Offset = "0x7013C0", VA = "0x1807025C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int? EPMIMBJKOGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x718380", Offset = "0x717180", VA = "0x180718380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x704F70", Offset = "0x703D70", VA = "0x180704F70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool CMKIGCPBFKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAEC9D0", Offset = "0xAEB7D0", VA = "0x180AEC9D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xAECAD0", Offset = "0xAEB8D0", VA = "0x180AECAD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static bool ODHNPPKIALE
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6259920", Offset = "0x6258720", VA = "0x186259920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<bool> JHBPMPGNPPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6259880", Offset = "0x6258680", VA = "0x186259880")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x6259AD0", Offset = "0x62588D0", VA = "0x186259AD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6254C90", Offset = "0x6253A90", VA = "0x186254C90", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6258410", Offset = "0x6257210", VA = "0x186258410")]
		private void PBDJJDIPDPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x62590D0", Offset = "0x6257ED0", VA = "0x1862590D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6258370", Offset = "0x6257170", VA = "0x186258370", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x62593C0", Offset = "0x62581C0", VA = "0x1862593C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6258730", Offset = "0x6257530", VA = "0x186258730")]
		public LMAPELGHNPL PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x62571C0", Offset = "0x6255FC0", VA = "0x1862571C0")]
		[IteratorStateMachine(typeof(IMNBFCPMNDE))]
		public IEnumerator<FFIMBIIMMMD> Initialize(AmplitudeAnalyticsEvent BOOJEFBANOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x62592B0", Offset = "0x62580B0", VA = "0x1862592B0")]
		public void UpdateLastAliveTime(float IHHMNHHHHPI = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6256850", Offset = "0x6255650", VA = "0x186256850")]
		private LMAPELGHNPL GIDJKEBLEOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6257250", Offset = "0x6256050", VA = "0x186257250")]
		private LMAPELGHNPL JNKLKDCDNGI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6258C80", Offset = "0x6257A80", VA = "0x186258C80")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6255C80", Offset = "0x6254A80", VA = "0x186255C80")]
		[IteratorStateMachine(typeof(LKLPCKHJHPN))]
		private IEnumerator COBPEEJMHFA(NGNPLNHEGFI GKOCCCIGEOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6259630", Offset = "0x6258430", VA = "0x186259630")]
		[IteratorStateMachine(typeof(EHHINKEEMMC))]
		public IEnumerator WaitForFlush(float FOFGIJODLCJ = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6259190", Offset = "0x6257F90", VA = "0x186259190")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x62590E0", Offset = "0x6257EE0", VA = "0x1862590E0")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime BOMIODHNHJM)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6256E10", Offset = "0x6255C10", VA = "0x186256E10")]
		public static HHKPJINPBBA Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6254AF0", Offset = "0x62538F0", VA = "0x186254AF0")]
		public static OMMKAKFNCEO AccountSelectionPostLoginEvent([NotNull] string HOBGFMBJCNE, string HKHNMDJBMBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6255FF0", Offset = "0x6254DF0", VA = "0x186255FF0")]
		public static OMMKAKFNCEO Event([NotNull] string HOBGFMBJCNE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6258790", Offset = "0x6257590", VA = "0x186258790")]
		public static OMMKAKFNCEO PreviousSessionEvent([NotNull] string HOBGFMBJCNE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6256F70", Offset = "0x6255D70", VA = "0x186256F70")]
		public static OMMKAKFNCEO InitializeEvent(string HKHNMDJBMBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6258DE0", Offset = "0x6257BE0", VA = "0x186258DE0")]
		public static OMMKAKFNCEO StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6255D10", Offset = "0x6254B10", VA = "0x186255D10")]
		public static OMMKAKFNCEO CreateOutOfSessionEvent(string HOBGFMBJCNE, bool LKBJEKENEBK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6257B10", Offset = "0x6256910", VA = "0x186257B10")]
		public static LMAPELGHNPL LogOutOfSessionEvent(OMMKAKFNCEO CHCKADIHJEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6257850", Offset = "0x6256650", VA = "0x186257850")]
		public void LogEventAsync(AmplitudeAnalyticsEvent KINDBIOMFMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6257E20", Offset = "0x6256C20", VA = "0x186257E20")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent KINDBIOMFMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6257F70", Offset = "0x6256D70", VA = "0x186257F70")]
		public void LogSerializedEventAsync(Dictionary<string, object> KJNENJJKKLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x62579A0", Offset = "0x62567A0", VA = "0x1862579A0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage EENEJFCJOOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x62563D0", Offset = "0x62551D0", VA = "0x1862563D0")]
		private void FCDKMKEADIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x62564B0", Offset = "0x62552B0", VA = "0x1862564B0")]
		private void FLJIDPFEFNG(Dictionary<string, object> OHNIAEDHHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6258280", Offset = "0x6257080", VA = "0x186258280")]
		private void OGMFFKCMGLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x62561F0", Offset = "0x6254FF0", VA = "0x1862561F0")]
		private void FBOKDDGBPIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6256740", Offset = "0x6255540", VA = "0x186256740")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x62567D0", Offset = "0x62555D0", VA = "0x1862567D0")]
		[IteratorStateMachine(typeof(DLKCMDLBKPK))]
		private IEnumerator<FFIMBIIMMMD> GGEEGJKMKCO(float FOFGIJODLCJ = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6256920", Offset = "0x6255720", VA = "0x186256920")]
		[IteratorStateMachine(typeof(DKKCNGBJLCB))]
		private IEnumerator<FFIMBIIMMMD> GJFNGHLEDEJ(float FOFGIJODLCJ = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6257770", Offset = "0x6256570", VA = "0x186257770")]
		[IteratorStateMachine(typeof(HHOAFILDKDE))]
		private IEnumerator<FFIMBIIMMMD> LLGLBOEFHHA(NAAFBMFGIEH IMBDKJJAFKD, int? CBOBPOJIDJM, string NFFFAMNBEOH, string LNJAEJCKMDP, float FOFGIJODLCJ, Action<int> EFOHPDEKKLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6257650", Offset = "0x6256450", VA = "0x186257650")]
		private static void LCPOLDFIMDM(bool GFPLKJDJKHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6256CE0", Offset = "0x6255AE0", VA = "0x186256CE0")]
		private global::ONJEHKCKOLK<LJHCIEDLLII<Dictionary<string, object>>> HIPOPAKAEAJ(string NFFFAMNBEOH, string LNJAEJCKMDP, string NPLJEBAFKEN, string EIBCPJCJEJJ, Dictionary<string, object> DCMPFMNCCJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6256A10", Offset = "0x6255810", VA = "0x186256A10")]
		private global::ONJEHKCKOLK<LJHCIEDLLII<List<Dictionary<string, object>>>> HIPOPAKAEAJ(string NFFFAMNBEOH, string LNJAEJCKMDP, string NPLJEBAFKEN, string EIBCPJCJEJJ, List<Dictionary<string, object>> DCMPFMNCCJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x3530680", Offset = "0x352F480", VA = "0x183530680")]
		private global::ONJEHKCKOLK<LJHCIEDLLII<T>> GOMJGPPKGON<T>(string NFFFAMNBEOH, string LNJAEJCKMDP, string EIBCPJCJEJJ, T DCMPFMNCCJE, Dictionary<string, object> OKFKHHCIJJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3530340", Offset = "0x352F140", VA = "0x183530340")]
		private global::ONJEHKCKOLK<LJHCIEDLLII<T>> GMGLMGKFPOC<T>(string NFFFAMNBEOH, string LNJAEJCKMDP, string NPLJEBAFKEN, T DCMPFMNCCJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6258050", Offset = "0x6256E50", VA = "0x186258050")]
		private bool NAMPJHCIMEF(float MIJNONLKFAG, float FOFGIJODLCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6254F80", Offset = "0x6253D80", VA = "0x186254F80")]
		private Dictionary<string, object> BJMIIHEOCCB(string LNJAEJCKMDP, Dictionary<string, object> DCMPFMNCCJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6259710", Offset = "0x6258510", VA = "0x186259710")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x62574F0", Offset = "0x62562F0", VA = "0x1862574F0")]
		[CompilerGenerated]
		private long KFDBJKFCCBN()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6258270", Offset = "0x6257070", VA = "0x186258270")]
		[CompilerGenerated]
		private void NPFOICEPMFJ(int KMCPDFDELDP)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly string uuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly string eventType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly long sequenceNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		internal Dictionary<string, object> eventProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private long time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long sessionId;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x625A740", Offset = "0x6259540", VA = "0x18625A740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x625A7A0", Offset = "0x62595A0", VA = "0x18625A7A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7B1C60", Offset = "0x7B0A60", VA = "0x1807B1C60")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6259CD0", Offset = "0x6258AD0", VA = "0x186259CD0")]
		public static OMMKAKFNCEO FBMANFCLCAO(string CPFPNOFCGCI, [NotNull] string ALNFHILNCAP, long LOOHFCCDDLN, long GFGGNJKNOCC, string HKHNMDJBMBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6259BD0", Offset = "0x62589D0", VA = "0x186259BD0")]
		public static OMMKAKFNCEO CIFKMLHIIMA(string CPFPNOFCGCI, [NotNull] string ALNFHILNCAP, long LOOHFCCDDLN, long GFGGNJKNOCC, string HKHNMDJBMBJ, long NJJICPEGDJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x625A580", Offset = "0x6259380", VA = "0x18625A580")]
		private AmplitudeAnalyticsEvent(string CPFPNOFCGCI, [NotNull] string ALNFHILNCAP, long LOOHFCCDDLN, long GFGGNJKNOCC, string HKHNMDJBMBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xB55B80", Offset = "0xB54980", VA = "0x180B55B80")]
		public void BEMPGDNDKMA(long HCEDKLNGCHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x625A460", Offset = "0x6259260", VA = "0x18625A460", Slot = "5")]
		public override void OPODHAHOMGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6259DC0", Offset = "0x6258BC0", VA = "0x186259DC0", Slot = "6")]
		public override void IKCNJNLJPKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6259F70", Offset = "0x6258D70", VA = "0x186259F70", Slot = "4")]
		protected override Dictionary<string, object> JCMEACBKIPO(Dictionary<string, object> DBLNICJLGPC)
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
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public string platform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public string osName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public string osVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public string deviceBrand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public string deviceManufacturer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public string deviceModel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public string deviceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public string carrier;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x625B510", Offset = "0x625A310", VA = "0x18625B510")]
			public void BPHFMLFKAMF(Dictionary<string, object> HHLGLABABDP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public class RevenueData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public float price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public float revenue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public string productId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string revenueType;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x6262E20", Offset = "0x6261C20", VA = "0x186262E20")]
			public void BPHFMLFKAMF(Dictionary<string, object> HABBOGDPOAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x16385B0", Offset = "0x16373B0", VA = "0x1816385B0")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		internal DeviceInfo deviceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		internal RevenueData revenueData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly string buildVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		internal Dictionary<string, object> userProperties;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x6F7F10", Offset = "0x6F6D10", VA = "0x1806F7F10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x625A890", Offset = "0x6259690", VA = "0x18625A890")]
		public static HHKPJINPBBA FBMANFCLCAO(string CPFPNOFCGCI, string HKHNMDJBMBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x625AE90", Offset = "0x6259C90", VA = "0x18625AE90")]
		protected AmplitudeAnalyticsIdentifyMessage(string CPFPNOFCGCI, string HKHNMDJBMBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x625A810", Offset = "0x6259610", VA = "0x18625A810")]
		public Dictionary<string, object> COLEPBNHIME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x625A9C0", Offset = "0x62597C0", VA = "0x18625A9C0", Slot = "4")]
		protected virtual Dictionary<string, object> JCMEACBKIPO(Dictionary<string, object> DBLNICJLGPC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x625AD00", Offset = "0x6259B00", VA = "0x18625AD00")]
		protected void JJGMDKDCKHN(string ANFHHLAHMJD, Dictionary<string, object> GIFMBOINCFG, Dictionary<string, object> OEDMLHEKIPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x625ADA0", Offset = "0x6259BA0", VA = "0x18625ADA0")]
		protected void OJINAOPBLHF(string ANFHHLAHMJD, string NLHFEJHKLAH, Dictionary<string, object> ACEGKOBDPDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x625AE10", Offset = "0x6259C10", VA = "0x18625AE10", Slot = "5")]
		public virtual void OPODHAHOMGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x625A940", Offset = "0x6259740", VA = "0x18625A940", Slot = "6")]
		public virtual void IKCNJNLJPKC()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class HHKPJINPBBA : global::DGEGJIPNPMA<AmplitudeAnalyticsIdentifyMessage, HHKPJINPBBA>
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public override HHKPJINPBBA EELPGPPGFOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x73C0B0", Offset = "0x73AEB0", VA = "0x18073C0B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage PEIACLNJANM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x625BE20", Offset = "0x625AC20", VA = "0x18625BE20")]
	public HHKPJINPBBA(AmplitudeAnalyticsIdentifyMessage GNDOGDAIOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x625BD80", Offset = "0x625AB80", VA = "0x18625BD80", Slot = "4")]
	public override void IKCNJNLJPKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class OMMKAKFNCEO : global::DGEGJIPNPMA<AmplitudeAnalyticsEvent, OMMKAKFNCEO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private bool KEMGMAOEDLH;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public override OMMKAKFNCEO EELPGPPGFOB
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x73C0B0", Offset = "0x73AEB0", VA = "0x18073C0B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public long AKLNCMCGJJN
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6262580", Offset = "0x6261380", VA = "0x186262580")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6262C10", Offset = "0x6261A10", VA = "0x186262C10")]
	public OMMKAKFNCEO(AmplitudeAnalyticsEvent GNDOGDAIOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40", Slot = "5")]
	public override AmplitudeAnalyticsEvent PEIACLNJANM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x62629C0", Offset = "0x62617C0", VA = "0x1862629C0", Slot = "4")]
	public override void IKCNJNLJPKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6262870", Offset = "0x6261670", VA = "0x186262870")]
	public OMMKAKFNCEO FGKPEJLAOBO(string PEJFAKHLGCN, long[] NLHFEJHKLAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6262730", Offset = "0x6261530", VA = "0x186262730")]
	public OMMKAKFNCEO FGKPEJLAOBO(string PEJFAKHLGCN, ulong[] NLHFEJHKLAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x24A9B00", Offset = "0x24A8900", VA = "0x1824A9B00")]
	public OMMKAKFNCEO FGKPEJLAOBO<T>(string PEJFAKHLGCN, T[] NLHFEJHKLAH) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x62629B0", Offset = "0x62617B0", VA = "0x1862629B0")]
	public OMMKAKFNCEO FGKPEJLAOBO(string PEJFAKHLGCN, string[] NLHFEJHKLAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x24A9A90", Offset = "0x24A8890", VA = "0x1824A9A90")]
	public OMMKAKFNCEO FGKPEJLAOBO<T>(string PEJFAKHLGCN, T NLHFEJHKLAH) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6262630", Offset = "0x6261430", VA = "0x186262630")]
	public OMMKAKFNCEO FGKPEJLAOBO(string PEJFAKHLGCN, long NLHFEJHKLAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x62625A0", Offset = "0x62613A0", VA = "0x1862625A0")]
	public OMMKAKFNCEO FGKPEJLAOBO(string PEJFAKHLGCN, ulong NLHFEJHKLAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x62626C0", Offset = "0x62614C0", VA = "0x1862626C0")]
	public OMMKAKFNCEO FGKPEJLAOBO(string PEJFAKHLGCN, string NLHFEJHKLAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6262BF0", Offset = "0x62619F0", VA = "0x186262BF0")]
	public OMMKAKFNCEO NEGDKFAMAND(string PEJFAKHLGCN, object? NLHFEJHKLAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6262B50", Offset = "0x6261950", VA = "0x186262B50")]
	public OMMKAKFNCEO KMJGHJPFKAH(string PEJFAKHLGCN, string NLHFEJHKLAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6262A60", Offset = "0x6261860", VA = "0x186262A60")]
	private OMMKAKFNCEO JCLOGKMIJCH(string PEJFAKHLGCN, object NLHFEJHKLAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class PLCOBDCJMJL : OMMKAKFNCEO
{
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6262C10", Offset = "0x6261A10", VA = "0x186262C10")]
	public PLCOBDCJMJL(AmplitudeAnalyticsEvent GNDOGDAIOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6262C60", Offset = "0x6261A60", VA = "0x186262C60", Slot = "4")]
	public override void IKCNJNLJPKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class DGEGJIPNPMA<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::DGEGJIPNPMA<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	protected M GNDOGDAIOKH;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public abstract BLDR EELPGPPGFOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x28D63A0", Offset = "0x28D51A0", VA = "0x1828D63A0")]
	public DGEGJIPNPMA(M GNDOGDAIOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2B0A400", Offset = "0x2B09200", VA = "0x182B0A400")]
	public BLDR MAJAOAEFDKD(AmplitudeAnalyticsIdentifyMessage.DeviceInfo GGOCDJDGPDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2B0A2D0", Offset = "0x2B090D0", VA = "0x182B0A2D0")]
	public BLDR JHOAHICAGKN(AmplitudeAnalyticsIdentifyMessage.RevenueData LKCGNIEINAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2B0A230", Offset = "0x2B09030", VA = "0x182B0A230")]
	public BLDR CKNJJBMGIKN(string PEJFAKHLGCN, string NLHFEJHKLAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2640FA0", Offset = "0x263FDA0", VA = "0x182640FA0")]
	public BLDR CKNJJBMGIKN<T>(string PEJFAKHLGCN, T NLHFEJHKLAH) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2B0A180", Offset = "0x2B08F80", VA = "0x182B0A180")]
	public BLDR CKNJJBMGIKN(string PEJFAKHLGCN, long NLHFEJHKLAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2B0A0D0", Offset = "0x2B08ED0", VA = "0x182B0A0D0")]
	public BLDR CKNJJBMGIKN(string PEJFAKHLGCN, ulong NLHFEJHKLAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void IKCNJNLJPKC();

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2B0A2A0", Offset = "0x2B090A0", VA = "0x182B0A2A0")]
	internal static string FGJJFOHKLLA(string NLHFEJHKLAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2B0A310", Offset = "0x2B09110", VA = "0x182B0A310")]
	private BLDR LBKBADOHPDE(string PEJFAKHLGCN, object NLHFEJHKLAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M PEIACLNJANM();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class NEIIHBDDHPD
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public const string LIJILAFHGNO = "batch";

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const string HBJHBODODBH = "type";

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public const string HMOFEHKIOIP = "identify";

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public const string JHCIOIDILBL = "track";

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const string EILBEIEGHDD = "userId";

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const string JBGCPKIODGG = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public const string AGIJLGEJEBN = "messageId";

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public const string PNPICHPJIJF = "event";

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public const string ALKKGFBMDMB = "version";

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public const string IEJJKPCEBFB = "locale";

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public const string IAHGFFAJEFL = "name";

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public const string LAOJPEHIIDJ = "properties";

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public const string OINBIFOAKBI = "traits";

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public const string EOECKKJAHJA = "context";

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const string BJDLEFAFMGB = "app";

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public const string KICHGNAPMGP = "os";

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public const string DICFCOJOLCK = "device";

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public const string OEHBFEJILFE = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public const string CMMMPNEGOFE = "brand";

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const string PGMHOPMBJDO = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const string PBMFEHLAFFD = "model";

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public const string JAFFEKICCIE = "type";

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public NEIIHBDDHPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class NNJNFJLIOFC
{
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public const int KOJEHEPJJCC = 2;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const int POCKEOPAMCK = 100;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public const int FKMHCCMKDOB = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const long BPGNDMFELIL = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const int DBIPCABOGOF = 1024;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const int NFCICEDFHLF = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public const string LFKHEMMENOH = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public const string NOHHHDLGPAO = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public const string MGIAPJOJCOK = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public const string ABNLFHAOLIM = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public const string OMJMFFLKDJM = "session_start";

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public const string LKEPAKHILLI = "session_end";

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public const string LMIAEMNILDI = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public const string FHPBJFHBOPN = "event_time";

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public const string KDKICKDMDOO = "session_id";

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public const string IEMBIKIPAPP = "session_tracking_data";

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public const string ACIGNLJFLPJ = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public const string ODFFIDCJAHP = "app_version";

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public const string AHMIMGOIMDL = "ip";

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public const string BCBALGHEPDF = "language";

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public const string LFABNFIEKLM = "platform";

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public const string ANLCJGMDINB = "os_name";

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public const string DBIJMLHGJKL = "os_version";

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public const string BKOFDJGDELM = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public const string HKOOMOGHOCM = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public const string AOLAOIEDMMM = "device_model";

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public const string AFPPDBOEIDF = "device_type";

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public const string CEMKHCKPFNC = "price";

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public const string LDOCCBHFNEC = "quantity";

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public const string LKKGBGDHLNN = "revenue";

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public const string DEGMFKJPEHN = "productId";

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public const string KAFILEIHFJF = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public const string BOHPLEHBCHE = "event_type";

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public const string EILBEIEGHDD = "user_id";

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public const string NDBAONIOKJJ = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public const int PKBAPGLGKFM = 10;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> EAPMEANKDFN;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6262340", Offset = "0x6261140", VA = "0x186262340")]
	internal static bool EMOGDAADOKK(string ANFHHLAHMJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public NNJNFJLIOFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface MFFEGPNBCCA
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool FLJJNNKGILJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string HIOMLHIFFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string GEODGJMNAMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string PBJPMCKJKPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string HLKPNJLKHLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::ONJEHKCKOLK<OGILIMCEGOM> HIPOPAKAEAJ(string NFFFAMNBEOH, Dictionary<string, string> IHIHLGNMMAC, bool PEGJJLFADAG = false);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::ONJEHKCKOLK<OGILIMCEGOM> LEGGDBHAPFP(string NFFFAMNBEOH, string DCFHPGEIONL, string CPDPGCKPIAB, string MCHCKDNJKPO);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct OGILIMCEGOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public readonly int LNAPMLKGBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public readonly string LEHCBLOLOKN;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x800F90", Offset = "0x7FFD90", VA = "0x180800F90")]
	public OGILIMCEGOM(int DAEIHIKJHCG, string CFKFFCMMFNH)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class KNPJDABNJNB
{
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static byte[] KJPEJCPNACN;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static int ENGDLONOMNK;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static int IBOHBKOLMLK;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static BigInteger BMOFNNOLMPE;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public KNPJDABNJNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x625F040", Offset = "0x625DE40", VA = "0x18625F040")]
	private static string NKHPLDDEAIA(byte[] MIECAKFJHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x625F150", Offset = "0x625DF50", VA = "0x18625F150")]
	public static string OEIELDLCBEJ(byte[] NJGGJPEFKKD, bool NCDJBNMKDFA)
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

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
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

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
		[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E9D800", Offset = "0x5E9BE00", VA = "0x185E9D800")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x723370", Offset = "0x721970", VA = "0x180723370")]
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
		[Cpp2IlInjected.Address(RVA = "0xE65B40", Offset = "0xE64140", VA = "0x180E65B40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GNKPHLPEDJO
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string CNMIDBLAGNI = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string ODDGOHLMFLB = "flowName";

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private const string EAFIPKHABDB = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const string EAOGNIGGLDB = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private const string LBAPBOLBKHA = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private const string BEHGKMBJHCH = "failure";

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const string PFJLNOCLHGN = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private long MHOGAGPEAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private IELDMODPJDI JBKIMFFCJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool MAJOBBGOMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private float EANJDEPMAOJ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E99AA0", Offset = "0x5E980A0", VA = "0x185E99AA0")]
	public GNKPHLPEDJO(string PCIEMKDPNGG, float EANJDEPMAOJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x32CC810", Offset = "0x32CAE10", VA = "0x1832CC810")]
	public void AFPLPLBOOFP<T>(string LNOIPGJELOP, T MAKFNMHIJIF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E99700", Offset = "0x5E97D00", VA = "0x185E99700")]
	public void AFPLPLBOOFP(string LNOIPGJELOP, string MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5E99960", Offset = "0x5E97F60", VA = "0x185E99960")]
	public void NGHOGMINKKF(string AGNJOFHHANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5E998A0", Offset = "0x5E97EA0", VA = "0x185E998A0")]
	public void ENNDEDHGFAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5E99780", Offset = "0x5E97D80", VA = "0x185E99780")]
	private void BCKBHFEINEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5E99A50", Offset = "0x5E98050", VA = "0x185E99A50")]
	private bool PACMOFJGOCL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HGHONBEIFHF
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IGOPHNBFNOE OIEJOMHJJDA(string KAECEDMINHD, string AOPKPOMEDAD, [Optional] HHOLBCFHBMD DKONNMFNCLF);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IGOPHNBFNOE PDIEBDIELJI(HHOLBCFHBMD DKONNMFNCLF);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IGOPHNBFNOE DICLNIPNCAD(HHOLBCFHBMD DKONNMFNCLF, Dictionary<string, string> NDLHCNNFKPG);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KBDMBHLGJPI(string NCPKBJFPLNJ);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JBCBEFKAJPA JBLDFJEENAG(string JJFBDCCOHDJ);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JECDKIGBKFJ JKPMFOIOAOK(string KPAMLFCJJNH);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JBCBEFKAJPA CPBJEHFGKCN(string CNCDKICKCGP);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IGOPHNBFNOE HMJFAENMIFJ();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class PNOJAFKPEEM : HGHONBEIFHF
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private const string DDCJGEBKNGG = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private const string BJLCELNEIOL = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const string PIDEONKGPPK = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const string LJEDMNDDGNP = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private const string IHDMFGPLKNM = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private const string IECCKNIDGLL = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const string FLHNMMKAFIG = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private const string NKBDPDOINOC = "AccountCreationTimeAfterEpochMilliseconds";

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const string GEIDEJFEAAG = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const string KAKBLDKJKJF = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const string EBLLNBBKOBB = "LocaleName";

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly IReadOnlyDictionary<string, AENICMGOFFA> EAACMOJAINJ;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int JLKPBCOMMGN = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool EPOLFPCAMDH;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5E9F460", Offset = "0x5E9DA60", VA = "0x185E9F460", Slot = "4")]
	public IGOPHNBFNOE OIEJOMHJJDA(string KAECEDMINHD, string AOPKPOMEDAD, [Optional] HHOLBCFHBMD DKONNMFNCLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5E9F050", Offset = "0x5E9D650", VA = "0x185E9F050", Slot = "11")]
	public IGOPHNBFNOE HMJFAENMIFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5E9F900", Offset = "0x5E9DF00", VA = "0x185E9F900", Slot = "5")]
	public IGOPHNBFNOE PDIEBDIELJI(HHOLBCFHBMD DKONNMFNCLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E9EB10", Offset = "0x5E9D110", VA = "0x185E9EB10", Slot = "6")]
	public IGOPHNBFNOE DICLNIPNCAD(HHOLBCFHBMD DKONNMFNCLF, Dictionary<string, string> NDLHCNNFKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E9F3B0", Offset = "0x5E9D9B0", VA = "0x185E9F3B0", Slot = "7")]
	public bool KBDMBHLGJPI(string NCPKBJFPLNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E9F1E0", Offset = "0x5E9D7E0", VA = "0x185E9F1E0", Slot = "8")]
	public JBCBEFKAJPA JBLDFJEENAG(string JJFBDCCOHDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5E9F2F0", Offset = "0x5E9D8F0", VA = "0x185E9F2F0", Slot = "9")]
	public JECDKIGBKFJ JKPMFOIOAOK(string KPAMLFCJJNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E9EA20", Offset = "0x5E9D020", VA = "0x185E9EA20", Slot = "10")]
	public JBCBEFKAJPA CPBJEHFGKCN(string CNCDKICKCGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E290", Offset = "0x5E9C890", VA = "0x185E9E290")]
	private PMBIOKPKGPH BIBECGGFGFK(HHOLBCFHBMD DKONNMFNCLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E880", Offset = "0x5E9CE80", VA = "0x185E9E880")]
	private HCPKGEMDIAB COGOEKJKAMG(string AOPKPOMEDAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5E9EE00", Offset = "0x5E9D400", VA = "0x185E9EE00")]
	private void DOPHGEDLHBH(string JJFBDCCOHDJ, JBCBEFKAJPA PPPBIOFDOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public PNOJAFKPEEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xC69890", Offset = "0xC67E90", VA = "0x180C69890")]
	[CompilerGenerated]
	private void JPDCCBAAAPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MJEFIDGHPBA : HGHONBEIFHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private HGHONBEIFHF DNGAOMAFLCF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private HGHONBEIFHF JHGMMLCOACP
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D5E0", Offset = "0x5E9BBE0", VA = "0x185E9D5E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	[Preserve]
	public MJEFIDGHPBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E9D200", Offset = "0x5E9B800", VA = "0x185E9D200")]
	[PILNOHNDGDF(KBMKLHMPDPB.GameOnly)]
	private static void NFCMOOADJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5E9D300", Offset = "0x5E9B900", VA = "0x185E9D300", Slot = "4")]
	public IGOPHNBFNOE OIEJOMHJJDA(string KAECEDMINHD, string AOPKPOMEDAD, [Optional] HHOLBCFHBMD DKONNMFNCLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E9D4E0", Offset = "0x5E9BAE0", VA = "0x185E9D4E0", Slot = "5")]
	public IGOPHNBFNOE PDIEBDIELJI(HHOLBCFHBMD DKONNMFNCLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E9CDB0", Offset = "0x5E9B3B0", VA = "0x185E9CDB0", Slot = "6")]
	public IGOPHNBFNOE DICLNIPNCAD(HHOLBCFHBMD DKONNMFNCLF, Dictionary<string, string> NDLHCNNFKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5E9D160", Offset = "0x5E9B760", VA = "0x185E9D160", Slot = "7")]
	public bool KBDMBHLGJPI(string NCPKBJFPLNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E9CFC0", Offset = "0x5E9B5C0", VA = "0x185E9CFC0", Slot = "8")]
	public JBCBEFKAJPA JBLDFJEENAG(string JJFBDCCOHDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E9D060", Offset = "0x5E9B660", VA = "0x185E9D060", Slot = "9")]
	public JECDKIGBKFJ JKPMFOIOAOK(string KPAMLFCJJNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E9CD10", Offset = "0x5E9B310", VA = "0x185E9CD10", Slot = "10")]
	public JBCBEFKAJPA CPBJEHFGKCN(string CNCDKICKCGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E9CEC0", Offset = "0x5E9B4C0", VA = "0x185E9CEC0", Slot = "11")]
	public IGOPHNBFNOE HMJFAENMIFJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class BKCOJKHEFFO : HGHONBEIFHF
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E98C70", Offset = "0x5E97270", VA = "0x185E98C70", Slot = "4")]
	public IGOPHNBFNOE OIEJOMHJJDA(string KAECEDMINHD, string AOPKPOMEDAD, [Optional] HHOLBCFHBMD DKONNMFNCLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5E98D10", Offset = "0x5E97310", VA = "0x185E98D10", Slot = "5")]
	public IGOPHNBFNOE PDIEBDIELJI(HHOLBCFHBMD DKONNMFNCLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E98B20", Offset = "0x5E97120", VA = "0x185E98B20", Slot = "6")]
	public IGOPHNBFNOE DICLNIPNCAD(HHOLBCFHBMD DKONNMFNCLF, Dictionary<string, string> NDLHCNNFKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260", Slot = "7")]
	public bool KBDMBHLGJPI(string NCPKBJFPLNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5E98B10", Offset = "0x5E97110", VA = "0x185E98B10", Slot = "8")]
	public JBCBEFKAJPA JBLDFJEENAG(string JJFBDCCOHDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5E98C60", Offset = "0x5E97260", VA = "0x185E98C60", Slot = "9")]
	public JECDKIGBKFJ JKPMFOIOAOK(string KPAMLFCJJNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5E98B10", Offset = "0x5E97110", VA = "0x185E98B10", Slot = "10")]
	public JBCBEFKAJPA CPBJEHFGKCN(string CNCDKICKCGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5E98BC0", Offset = "0x5E971C0", VA = "0x185E98BC0", Slot = "11")]
	public IGOPHNBFNOE HMJFAENMIFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public BKCOJKHEFFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PDOGKJOKJOL
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GNKPHLPEDJO KENPPFAIOMG(string PCIEMKDPNGG);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HHOLBCFHBMD
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool PAONDHDBMLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool NLNLAABJMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HHGMFGFHJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool ILOJJJAEJKP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool? MBOJEDLGELO
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int? AIMIBLBAPPL
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int IBDJMAKPCMF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string AEFJBHJHOFH
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string MIAMLEFCIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string MMNABAHBIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string CIOCHGFLCIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string GOBFNHAMEFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	string DKMBIKPJMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	double HIOKNFIBJOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
namespace AmplitudeAnalytics
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AGAmplitudeAnalyticsSettings : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private AmplitudeAnalyticsClient.Settings editorSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private bool forceEditorSettingsForDevelopers;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AmplitudeAnalyticsClient.Settings GHFPIAODADG
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool ACOAIIHEKMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8C3430", Offset = "0x8C1A30", VA = "0x1808C3430")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public enum GOHAPJFGCLP
		{
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			RudderStackOnly,
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			Both
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private enum NIHELOEJPBN
		{
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		internal class JOBLDNINJFK
		{
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			private class BKBOICGPMBA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000060")]
				public int LDBLHBDMNJM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000061")]
				public Dictionary<string, object> MFICDHDHPMD;

				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
				public BKBOICGPMBA()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000012")]
			[CompilerGenerated]
			private sealed class EKEHGFOIKNM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000062")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
				public EKEHGFOIKNM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x5E993C0", Offset = "0x5E979C0", VA = "0x185E993C0")]
				internal bool <GetBatch>b__0(BKBOICGPMBA item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private const string FNHIOAMNOHO = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private readonly string GFBIJELPOGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private List<BKBOICGPMBA> PAFBDAABACG;

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public int? BDAMBNADLOG
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x5E9B070", Offset = "0x5E99670", VA = "0x185E9B070")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public int? HCJAKDMLACN
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x5E9B9B0", Offset = "0x5E99FB0", VA = "0x185E9B9B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x5E9BA70", Offset = "0x5E9A070", VA = "0x185E9BA70")]
			internal JOBLDNINJFK(string IMEEJHLAPNK, string AOPKPOMEDAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5E9B670", Offset = "0x5E99C70", VA = "0x185E9B670")]
			public int MJCHBOILBBB([Optional] int? HBNJIIBFGLB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5E9B3E0", Offset = "0x5E999E0", VA = "0x185E9B3E0")]
			public List<Dictionary<string, object>> MGNDKNALBIP(int IJNJIEKDCNC, int? HBNJIIBFGLB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5E9B800", Offset = "0x5E99E00", VA = "0x185E9B800")]
			public void MPJLCFLNLJL(AmplitudeAnalyticsIdentifyMessage LGKNNMGLNIA, bool GOCHFFJFDOG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5E9B8A0", Offset = "0x5E99EA0", VA = "0x185E9B8A0")]
			public void MPJLCFLNLJL(Dictionary<string, object> LGKNNMGLNIA, bool GOCHFFJFDOG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5E9B250", Offset = "0x5E99850", VA = "0x185E9B250")]
			public void JIIMHHDMDPO(params Dictionary<string, object>[] OLNBDPFFEFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5E9A5D0", Offset = "0x5E98BD0", VA = "0x185E9A5D0")]
			public void DIBLAFHPAOO(List<Dictionary<string, object>> ODCHNKIAPLL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x5E9B110", Offset = "0x5E99710", VA = "0x185E9B110")]
			private void IOLINLDEKID(Dictionary<string, object> LGKNNMGLNIA, bool GOCHFFJFDOG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x5E9A950", Offset = "0x5E98F50", VA = "0x185E9A950")]
			public void HFNOCENEKAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x5E9ABC0", Offset = "0x5E991C0", VA = "0x185E9ABC0")]
			private void HLINCIJFHJB([Optional] string EOJFFLKNAKN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x5E9A820", Offset = "0x5E98E20", VA = "0x185E9A820")]
			private static string GIEOMCHLOHL(string MAKFNMHIJIF, string AIGAKEKDKHM)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x5E9FD50", Offset = "0x5E9E350", VA = "0x185E9FD50")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public struct DMKBCOLCKBO<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public int CCFDHDODLHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public string DBECLGENHFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public T APLCCHNGLIK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class MCJCLPCIMBE : IEnumerator<PBBBHKGHFDI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private PBBBHKGHFDI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			private PBBBHKGHFDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
			[DebuggerHidden]
			public MCJCLPCIMBE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x5E9BC00", Offset = "0x5E9A200", VA = "0x185E9BC00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x5E9C1F0", Offset = "0x5E9A7F0", VA = "0x185E9C1F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class PHJNCNFNEMK : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public EONHFJBEBFJ quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
			[DebuggerHidden]
			public PHJNCNFNEMK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x5E9E160", Offset = "0x5E9C760", VA = "0x185E9E160", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x5E9E250", Offset = "0x5E9C850", VA = "0x185E9E250", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class CMMALGLDHKF : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AE")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
			[DebuggerHidden]
			public CMMALGLDHKF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x5E99090", Offset = "0x5E97690", VA = "0x185E99090", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x5E99200", Offset = "0x5E97800", VA = "0x185E99200", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class GHNGOIBNLHA : IEnumerator<PBBBHKGHFDI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private PBBBHKGHFDI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private PBBBHKGHFDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B2")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B4")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
			[DebuggerHidden]
			public GHNGOIBNLHA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x5E99420", Offset = "0x5E97A20", VA = "0x185E99420", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x5E996C0", Offset = "0x5E97CC0", VA = "0x185E996C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class CKPDPFAKKOE : IEnumerator<PBBBHKGHFDI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private PBBBHKGHFDI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private PBBBHKGHFDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
			[DebuggerHidden]
			public CKPDPFAKKOE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x5E98DB0", Offset = "0x5E973B0", VA = "0x185E98DB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x5E99050", Offset = "0x5E97650", VA = "0x185E99050", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class MFNJJGKLAEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public JOBLDNINJFK cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
			public MFNJJGKLAEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x5E9C860", Offset = "0x5E9AE60", VA = "0x185E9C860")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x5E9C900", Offset = "0x5E9AF00", VA = "0x185E9C900")]
			internal void <FlushFromCache>b__1(DMKBCOLCKBO<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class OBEFHMHAGCJ : IEnumerator<PBBBHKGHFDI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private PBBBHKGHFDI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public JOBLDNINJFK cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			private MFNJJGKLAEA <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public int? earlierThanFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public string url;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public string dataIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private string <apiKey>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private float <startTime>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private bool <timedOut>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private int <batchSize>5__5;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			private PBBBHKGHFDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
			[DebuggerHidden]
			public OBEFHMHAGCJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x5E9D890", Offset = "0x5E9BE90", VA = "0x185E9D890", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x5E9E120", Offset = "0x5E9C720", VA = "0x185E9E120", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class JOHKOHDIDHI<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
			public JOHKOHDIDHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x3D91690", Offset = "0x3D8FC90", VA = "0x183D91690")]
			internal DMKBCOLCKBO<T> <PostRudderStackJson>b__0(MBFKDIHPCGI postResponse)
			{
				return default(DMKBCOLCKBO<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class PJNLBHHLPMG<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
			public PJNLBHHLPMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x3D91690", Offset = "0x3D8FC90", VA = "0x183D91690")]
			internal DMKBCOLCKBO<T> <PostAmplitudeJson>b__0(MBFKDIHPCGI postResponse)
			{
				return default(DMKBCOLCKBO<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private DNLANILPICA NIODJPEPCCD;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private const string DBIFFIKCNEL = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private const string FPHNGKNAAKB = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private const string MBKPCDJDMDP = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private const int EOHCMOGJKND = 10;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private const int DCKNEBPMKCJ = 10;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private const int GIKNDCMAMJK = 5;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private const float PAEBHKNIDOA = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private const long FMEIPHJMMFC = -1L;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private const string AELODBLAKPP = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private const string DBHJOLBGGHM = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static bool MAGLBHMIBLP;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static bool MNALPDNPOOJ;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static int GDMDBBGHNJK;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static int GJAMAKHGPDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private FEIOBHDCGMF CLBGENJEJEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private bool FGGEEFGKKOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private float EPJKFBGIGNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private float NNJHFPHEKLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private int AHGHJLDGKKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int OMIDNBFDJNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int? GGCMPLEGIBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int? ABPLBGNPICF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private long HFIPGAIGLAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string IFIPPOLBKKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private long AAKDGDBIKOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Dictionary<string, object> NPGKDNBPLMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NIHELOEJPBN CIPLLMNHEPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int GAHPDENDNEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private int MMLCFBPLLFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private float PJPKOICJFHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool HKHIFJBLOKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool PABDBOGIDHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private JOBLDNINJFK IMIJGDIMMFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private JOBLDNINJFK GICMHFBFLCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private JOBLDNINJFK OHLPLJBCBPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> CCKFMDLBDBB;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo IAIJHMEHOEE;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static string IPEOOMBGNGP;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private const string PDHNHFOENBP = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly string LPKNCIOFAJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly string DHCNIIIMOAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly string EELJCDCMLKD;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private DNLANILPICA HPGMFEIMJJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5E95F20", Offset = "0x5E94520", VA = "0x185E95F20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private static int EEFOGMPOJIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5E961D0", Offset = "0x5E947D0", VA = "0x185E961D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static long GIABGFNONJF
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5E97760", Offset = "0x5E95D60", VA = "0x185E97760")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5E97860", Offset = "0x5E95E60", VA = "0x185E97860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static string PCIOAOFHPMO
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5E97700", Offset = "0x5E95D00", VA = "0x185E97700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static string AICPDMFHCAM
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5E97730", Offset = "0x5E95D30", VA = "0x185E97730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public string CNEOBJGALPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x739BD0", Offset = "0x7381D0", VA = "0x180739BD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x739EA0", Offset = "0x7384A0", VA = "0x180739EA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int? AIMIBLBAPPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x74FC30", Offset = "0x74E230", VA = "0x18074FC30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x73C850", Offset = "0x73AE50", VA = "0x18073C850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public GOHAPJFGCLP? GBFELBBCCJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x828910", Offset = "0x826F10", VA = "0x180828910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x73C860", Offset = "0x73AE60", VA = "0x18073C860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool CDNHENBFMIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x828DA0", Offset = "0x8273A0", VA = "0x180828DA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x828AE0", Offset = "0x8270E0", VA = "0x180828AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static bool AOHEGCPEDDN
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5E97610", Offset = "0x5E95C10", VA = "0x185E97610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> EPGBMOAEEDI
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5E97570", Offset = "0x5E95B70", VA = "0x185E97570")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5E977C0", Offset = "0x5E95DC0", VA = "0x185E977C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5E92800", Offset = "0x5E90E00", VA = "0x185E92800", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5E92CD0", Offset = "0x5E912D0", VA = "0x185E92CD0")]
		private void CDELJCKJFKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5E96DC0", Offset = "0x5E953C0", VA = "0x185E96DC0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5E960B0", Offset = "0x5E946B0", VA = "0x185E960B0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5E970B0", Offset = "0x5E956B0", VA = "0x185E970B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5E96420", Offset = "0x5E94A20", VA = "0x185E96420")]
		public IGOPHNBFNOE PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5E94B30", Offset = "0x5E93130", VA = "0x185E94B30")]
		[IteratorStateMachine(typeof(MCJCLPCIMBE))]
		public IEnumerator<PBBBHKGHFDI> Initialize(AmplitudeAnalyticsEvent KAPFKBMGLLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5E96FA0", Offset = "0x5E955A0", VA = "0x185E96FA0")]
		public void UpdateLastAliveTime(float MNNKIKNAMKE = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5E92FF0", Offset = "0x5E915F0", VA = "0x185E92FF0")]
		private IGOPHNBFNOE CKDHHNLOHPH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5E94C50", Offset = "0x5E93250", VA = "0x185E94C50")]
		private IGOPHNBFNOE JECLKKKMGBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5E96970", Offset = "0x5E94F70", VA = "0x185E96970")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5E94BC0", Offset = "0x5E931C0", VA = "0x185E94BC0")]
		[IteratorStateMachine(typeof(PHJNCNFNEMK))]
		private IEnumerator JAJFFOOFAMA(EONHFJBEBFJ PHNAHADJDBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5E97320", Offset = "0x5E95920", VA = "0x185E97320")]
		[IteratorStateMachine(typeof(CMMALGLDHKF))]
		public IEnumerator WaitForFlush(float DKOGNBKHEEK = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5E96E80", Offset = "0x5E95480", VA = "0x185E96E80")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5E96DD0", Offset = "0x5E953D0", VA = "0x185E96DD0")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime BPPPFJGDDBP)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5E94780", Offset = "0x5E92D80", VA = "0x185E94780")]
		public static IPNKOFKMIJE Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5E92660", Offset = "0x5E90C60", VA = "0x185E92660")]
		public static IELDMODPJDI AccountSelectionPostLoginEvent([NotNull] string NLNHKLKCEOA, string BLFKBMDMAMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5E937F0", Offset = "0x5E91DF0", VA = "0x185E937F0")]
		public static IELDMODPJDI Event([NotNull] string NLNHKLKCEOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5E96480", Offset = "0x5E94A80", VA = "0x185E96480")]
		public static IELDMODPJDI PreviousSessionEvent([NotNull] string NLNHKLKCEOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5E948E0", Offset = "0x5E92EE0", VA = "0x185E948E0")]
		public static IELDMODPJDI InitializeEvent(string BLFKBMDMAMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5E96AD0", Offset = "0x5E950D0", VA = "0x185E96AD0")]
		public static IELDMODPJDI StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5E931A0", Offset = "0x5E917A0", VA = "0x185E931A0")]
		public static IELDMODPJDI CreateOutOfSessionEvent(string NLNHKLKCEOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5E95210", Offset = "0x5E93810", VA = "0x185E95210")]
		public static IGOPHNBFNOE LogOutOfSessionEvent(IELDMODPJDI KLDCCGHEELK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5E94F50", Offset = "0x5E93550", VA = "0x185E94F50")]
		public void LogEventAsync(AmplitudeAnalyticsEvent HFHMFFPPFLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5E955B0", Offset = "0x5E93BB0", VA = "0x185E955B0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent HFHMFFPPFLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5E95700", Offset = "0x5E93D00", VA = "0x185E95700")]
		public void LogSerializedEventAsync(Dictionary<string, object> IKCIBDFNBEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5E950A0", Offset = "0x5E936A0", VA = "0x185E950A0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage PENCBOFBNGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5E95E40", Offset = "0x5E94440", VA = "0x185E95E40")]
		private void NDMLFCFCDFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5E93470", Offset = "0x5E91A70", VA = "0x185E93470")]
		private void DGBFFDGKHGL(Dictionary<string, object> JDEFICMNKIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5E93700", Offset = "0x5E91D00", VA = "0x185E93700")]
		private void EFNKPOLDJPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5E92AF0", Offset = "0x5E910F0", VA = "0x185E92AF0")]
		private void BKEINBLDKGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5E939F0", Offset = "0x5E91FF0", VA = "0x185E939F0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5E963A0", Offset = "0x5E949A0", VA = "0x185E963A0")]
		[IteratorStateMachine(typeof(GHNGOIBNLHA))]
		private IEnumerator<PBBBHKGHFDI> PGCFBJGFKCN(float DKOGNBKHEEK = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5E96150", Offset = "0x5E94750", VA = "0x185E96150")]
		[IteratorStateMachine(typeof(CKPDPFAKKOE))]
		private IEnumerator<PBBBHKGHFDI> PAFALKFLPDI(float DKOGNBKHEEK = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5E930C0", Offset = "0x5E916C0", VA = "0x185E930C0")]
		[IteratorStateMachine(typeof(OBEFHMHAGCJ))]
		private IEnumerator<PBBBHKGHFDI> CNEBMFKEOCA(JOBLDNINJFK ODMPDKFLOEI, int? HBNJIIBFGLB, string LMPNJDEGODD, string BGNOMIPGMNG, float DKOGNBKHEEK, Action<int> FACCJNKLNJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5E95F90", Offset = "0x5E94590", VA = "0x185E95F90")]
		private static void OINCJIFNIIF(bool EGPCCIKKLOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5E95B30", Offset = "0x5E94130", VA = "0x185E95B30")]
		private global::DIHJKCFGFNO<DMKBCOLCKBO<Dictionary<string, object>>> MHAIMGJBAPG(string LMPNJDEGODD, string BGNOMIPGMNG, string INOIPIAGFMI, string EBFLNBMKEIM, Dictionary<string, object> APLCCHNGLIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5E957E0", Offset = "0x5E93DE0", VA = "0x185E957E0")]
		private global::DIHJKCFGFNO<DMKBCOLCKBO<List<Dictionary<string, object>>>> MHAIMGJBAPG(string LMPNJDEGODD, string BGNOMIPGMNG, string INOIPIAGFMI, string EBFLNBMKEIM, List<Dictionary<string, object>> APLCCHNGLIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4268210", Offset = "0x4266810", VA = "0x184268210")]
		private global::DIHJKCFGFNO<DMKBCOLCKBO<T>> JFIPJKKCNBJ<T>(string LMPNJDEGODD, string BGNOMIPGMNG, string EBFLNBMKEIM, T APLCCHNGLIK, Dictionary<string, object> LLBAEMDBHMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x42684A0", Offset = "0x4266AA0", VA = "0x1842684A0")]
		private global::DIHJKCFGFNO<DMKBCOLCKBO<T>> MBFGMBJHGBF<T>(string LMPNJDEGODD, string BGNOMIPGMNG, string INOIPIAGFMI, T APLCCHNGLIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5E94EF0", Offset = "0x5E934F0", VA = "0x185E94EF0")]
		private bool KFPHFNFIIPH(float LGMCDNJLHGA, float DKOGNBKHEEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5E93A80", Offset = "0x5E92080", VA = "0x185E93A80")]
		private Dictionary<string, object> HANBAOMEPHG(string BGNOMIPGMNG, Dictionary<string, object> APLCCHNGLIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5E97400", Offset = "0x5E95A00", VA = "0x185E97400")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5E95CE0", Offset = "0x5E942E0", VA = "0x185E95CE0")]
		[CompilerGenerated]
		private long MPHCHDEOLIE()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5E94F40", Offset = "0x5E93540", VA = "0x185E94F40")]
		[CompilerGenerated]
		private void KKKCFOMAKPG(int DKDPDCDPIDB)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly string uuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly string eventType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly long sequenceNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		internal Dictionary<string, object> eventProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private long time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private long sessionId;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x5E98300", Offset = "0x5E96900", VA = "0x185E98300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x5E98360", Offset = "0x5E96960", VA = "0x185E98360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x810210", Offset = "0x80E810", VA = "0x180810210")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5E978C0", Offset = "0x5E95EC0", VA = "0x185E978C0")]
		public static IELDMODPJDI CBFHJGEFJHE(string AJGHIJIKOBE, [NotNull] string PJKFKLILAKL, long DHLGNBEAFOA, long BMGLGFNAGOO, string BLFKBMDMAMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5E98040", Offset = "0x5E96640", VA = "0x185E98040")]
		public static IELDMODPJDI PNFHLFPHIBP(string AJGHIJIKOBE, [NotNull] string PJKFKLILAKL, long DHLGNBEAFOA, long BMGLGFNAGOO, string BLFKBMDMAMJ, long FKMPPJBLBFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5E98140", Offset = "0x5E96740", VA = "0x185E98140")]
		private AmplitudeAnalyticsEvent(string AJGHIJIKOBE, [NotNull] string PJKFKLILAKL, long DHLGNBEAFOA, long BMGLGFNAGOO, string BLFKBMDMAMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xF583F0", Offset = "0xF569F0", VA = "0x180F583F0")]
		public void DMMBGKKAPGD(long GMHFKKJKLCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5E97F20", Offset = "0x5E96520", VA = "0x185E97F20", Slot = "5")]
		public override void LOFNPGOJNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5E979B0", Offset = "0x5E95FB0", VA = "0x185E979B0", Slot = "6")]
		public override void COBECOFGEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5E97A30", Offset = "0x5E96030", VA = "0x185E97A30", Slot = "4")]
		protected override Dictionary<string, object> LALGHHBFCPJ(Dictionary<string, object> JBMHOFJOJLB)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class AmplitudeAnalyticsIdentifyMessage
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public class DeviceInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public string platform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public string osName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public string osVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public string deviceBrand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public string deviceManufacturer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public string deviceModel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public string deviceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public string carrier;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x5E99240", Offset = "0x5E97840", VA = "0x185E99240")]
			public void BFFIFOFDLBN(Dictionary<string, object> KPKEFEHBMHB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public class RevenueData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public float price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public float revenue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public string productId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public string revenueType;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x5E9FBE0", Offset = "0x5E9E1E0", VA = "0x185E9FBE0")]
			public void BFFIFOFDLBN(Dictionary<string, object> ELEEANBEFBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x1FEF4A0", Offset = "0x1FEDAA0", VA = "0x181FEF4A0")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		internal DeviceInfo deviceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		internal RevenueData revenueData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly string buildVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		internal Dictionary<string, object> userProperties;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x71E880", Offset = "0x71CE80", VA = "0x18071E880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5E98470", Offset = "0x5E96A70", VA = "0x185E98470")]
		public static IPNKOFKMIJE CBFHJGEFJHE(string AJGHIJIKOBE, string BLFKBMDMAMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5E98A50", Offset = "0x5E97050", VA = "0x185E98A50")]
		protected AmplitudeAnalyticsIdentifyMessage(string AJGHIJIKOBE, string BLFKBMDMAMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5E989D0", Offset = "0x5E96FD0", VA = "0x185E989D0")]
		public Dictionary<string, object> NNIKNNOKJFH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E98610", Offset = "0x5E96C10", VA = "0x185E98610", Slot = "4")]
		protected virtual Dictionary<string, object> LALGHHBFCPJ(Dictionary<string, object> JBMHOFJOJLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5E983D0", Offset = "0x5E969D0", VA = "0x185E983D0")]
		protected void BFFKBJHGNPF(string AIGAKEKDKHM, Dictionary<string, object> JBNOFPBDAHB, Dictionary<string, object> OGMLJJLHNKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5E985A0", Offset = "0x5E96BA0", VA = "0x185E985A0")]
		protected void HKEFCAFOKPI(string AIGAKEKDKHM, string MAKFNMHIJIF, Dictionary<string, object> GKDAPMHFKJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5E98950", Offset = "0x5E96F50", VA = "0x185E98950", Slot = "5")]
		public virtual void LOFNPGOJNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5E98520", Offset = "0x5E96B20", VA = "0x185E98520", Slot = "6")]
		public virtual void COBECOFGEFP()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class IPNKOFKMIJE : global::ACECIKOJEBC<AmplitudeAnalyticsIdentifyMessage, IPNKOFKMIJE>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public override IPNKOFKMIJE KJKDPHBNIFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x71E890", Offset = "0x71CE90", VA = "0x18071E890", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage HNAANPFOIDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A580", Offset = "0x5E98B80", VA = "0x185E9A580")]
	public IPNKOFKMIJE(AmplitudeAnalyticsIdentifyMessage DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A4E0", Offset = "0x5E98AE0", VA = "0x185E9A4E0", Slot = "4")]
	public override void COBECOFGEFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class IELDMODPJDI : global::ACECIKOJEBC<AmplitudeAnalyticsEvent, IELDMODPJDI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private bool KKEJEOLKMPL;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public override IELDMODPJDI KJKDPHBNIFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x71E890", Offset = "0x71CE90", VA = "0x18071E890", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public long LOOLJCIJLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A3D0", Offset = "0x5E989D0", VA = "0x185E9A3D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5E99E00", Offset = "0x5E98400", VA = "0x185E99E00")]
	public IELDMODPJDI(AmplitudeAnalyticsEvent DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620", Slot = "5")]
	public override AmplitudeAnalyticsEvent HNAANPFOIDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A270", Offset = "0x5E98870", VA = "0x185E9A270", Slot = "4")]
	public override void COBECOFGEFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5E99F60", Offset = "0x5E98560", VA = "0x185E99F60")]
	public IELDMODPJDI AFPLPLBOOFP(string LNOIPGJELOP, long[] MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A130", Offset = "0x5E98730", VA = "0x185E9A130")]
	public IELDMODPJDI AFPLPLBOOFP(string LNOIPGJELOP, ulong[] MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x33BE910", Offset = "0x33BCF10", VA = "0x1833BE910")]
	public IELDMODPJDI AFPLPLBOOFP<T>(string LNOIPGJELOP, T[] MAKFNMHIJIF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5E99F50", Offset = "0x5E98550", VA = "0x185E99F50")]
	public IELDMODPJDI AFPLPLBOOFP(string LNOIPGJELOP, string[] MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x33BE8A0", Offset = "0x33BCEA0", VA = "0x1833BE8A0")]
	public IELDMODPJDI AFPLPLBOOFP<T>(string LNOIPGJELOP, T MAKFNMHIJIF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E99E50", Offset = "0x5E98450", VA = "0x185E99E50")]
	public IELDMODPJDI AFPLPLBOOFP(string LNOIPGJELOP, long MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A0A0", Offset = "0x5E986A0", VA = "0x185E9A0A0")]
	public IELDMODPJDI AFPLPLBOOFP(string LNOIPGJELOP, ulong MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5E99EE0", Offset = "0x5E984E0", VA = "0x185E99EE0")]
	public IELDMODPJDI AFPLPLBOOFP(string LNOIPGJELOP, string MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A3B0", Offset = "0x5E989B0", VA = "0x185E9A3B0")]
	public IELDMODPJDI HIBLLCHOLAD(string LNOIPGJELOP, object? MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A310", Offset = "0x5E98910", VA = "0x185E9A310")]
	public IELDMODPJDI GGIDEDGHDOH(string LNOIPGJELOP, string MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A3F0", Offset = "0x5E989F0", VA = "0x185E9A3F0")]
	private IELDMODPJDI OGGAGHGLIBC(string LNOIPGJELOP, object MAKFNMHIJIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class HDAGEDBKHOO : IELDMODPJDI
{
	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E99E00", Offset = "0x5E98400", VA = "0x185E99E00")]
	public HDAGEDBKHOO(AmplitudeAnalyticsEvent DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E99C40", Offset = "0x5E98240", VA = "0x185E99C40", Slot = "4")]
	public override void COBECOFGEFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class ACECIKOJEBC<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::ACECIKOJEBC<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	protected M DIDMFBHHIEC;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract BLDR KJKDPHBNIFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x33487E0", Offset = "0x3346DE0", VA = "0x1833487E0")]
	public ACECIKOJEBC(M DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x427F420", Offset = "0x427DA20", VA = "0x18427F420")]
	public BLDR OFLLNAEKFMF(AmplitudeAnalyticsIdentifyMessage.DeviceInfo FDOFODFGNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x427F460", Offset = "0x427DA60", VA = "0x18427F460")]
	public BLDR OIHBGKIGEKF(AmplitudeAnalyticsIdentifyMessage.RevenueData ODMDMBMBEIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x427F290", Offset = "0x427D890", VA = "0x18427F290")]
	public BLDR COFEJIDDCIA(string LNOIPGJELOP, string MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x36ED1C0", Offset = "0x36EB7C0", VA = "0x1836ED1C0")]
	public BLDR COFEJIDDCIA<T>(string LNOIPGJELOP, T MAKFNMHIJIF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x427F1E0", Offset = "0x427D7E0", VA = "0x18427F1E0")]
	public BLDR COFEJIDDCIA(string LNOIPGJELOP, long MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x427F130", Offset = "0x427D730", VA = "0x18427F130")]
	public BLDR COFEJIDDCIA(string LNOIPGJELOP, ulong MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void COBECOFGEFP();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x427F3F0", Offset = "0x427D9F0", VA = "0x18427F3F0")]
	internal static string OEFFAMAHOAK(string MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x427F300", Offset = "0x427D900", VA = "0x18427F300")]
	private BLDR LIOFPEAGILP(string LNOIPGJELOP, object MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M HNAANPFOIDD();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class MIKLFKEOMJE
{
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public const string KMAMEDGAMAI = "batch";

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public const string KFOGACNIAMN = "type";

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public const string AKNDFJGJENC = "identify";

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public const string IONLAHDOHON = "track";

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public const string NJGPDCEGIBB = "userId";

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public const string LKMDJABILDK = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public const string EJKFIBJKEGO = "messageId";

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public const string KCCHBILMGJE = "event";

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public const string OJMNDBBFAKG = "version";

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public const string KOMILFKEGFH = "locale";

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public const string FIMHLOBKMGJ = "name";

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public const string FBOPLNNELIH = "properties";

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public const string MAGKOCDJOIE = "traits";

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public const string PKHMECNPFJA = "context";

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public const string JCLEDNCCAGP = "app";

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public const string BMMGIPAJPHG = "os";

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public const string CKEFAEBOINE = "device";

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public const string DAKHGPKAAOK = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public const string PNGKCDNPCKC = "brand";

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public const string EKDOIAEDDME = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public const string BMDKOPCLNPN = "model";

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public const string BOMIIOMGNBP = "type";

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public MIKLFKEOMJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class MJPCGCBIBIA
{
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const int FFJLNJFLGKF = 2;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public const int PIEEMAIHKHD = 100;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public const int NCDFFLOIAGG = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const long HFNDAFDEFKC = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const int PADIBHBKBNN = 1024;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public const int FBKBAANECFJ = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public const string FKDHCBBDCJN = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public const string AGJIDHHJIBH = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public const string MJHHFFIIIFC = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public const string HPKKOFKKHNK = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public const string CJMCNOLGNHE = "session_start";

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public const string PFKDNAIFFIL = "session_end";

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public const string KAGOCFMPAIC = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const string CNCOPEEEKOH = "event_time";

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public const string PCAILECDCMI = "session_id";

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public const string EBGKNJAOCKD = "session_tracking_data";

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public const string OECEBHMOHJH = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public const string PGGLEDIOFEC = "app_version";

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const string FNFECGEOFHK = "ip";

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const string LMPDIJCNDIC = "language";

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public const string NDPLEKCGGKL = "platform";

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public const string GGEHFBODBDG = "os_name";

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const string MAFBBHIHGIA = "os_version";

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public const string FPNJPJCACAF = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const string CMMCALOFLHM = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const string BINMADIBFJI = "device_model";

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const string FCBHMDGLKJC = "device_type";

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public const string JOHKFDPGGCL = "price";

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public const string GCOONEEMGAB = "quantity";

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public const string BMHOPECCIFA = "revenue";

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public const string LJMJCEOKAKM = "productId";

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public const string MDJOMNHCKJP = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public const string LIFCICPCFNB = "event_type";

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public const string NJGPDCEGIBB = "user_id";

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public const string ENJBMBJJBFI = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public const int CPFNPBEPBDG = 10;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> DMHHFLAOKLD;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5E9D650", Offset = "0x5E9BC50", VA = "0x185E9D650")]
	internal static bool BECFMIBGCPF(string AIGAKEKDKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public MJPCGCBIBIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface FEIOBHDCGMF
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool LDJGIEBMHHP
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	string EKPJDMAKOPB
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	string CBCEHBGIJCD
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	string EBBJGOHBPOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string OGDDACFCNHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::DIHJKCFGFNO<MBFKDIHPCGI> MHAIMGJBAPG(string LMPNJDEGODD, Dictionary<string, string> BJEKKBKKKMM, bool ECANMHHALGL = false);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::DIHJKCFGFNO<MBFKDIHPCGI> PPKCILHCBHE(string LMPNJDEGODD, string IGMBHBMBIHA, string MMNCMMDMDEE, string OILOFFFFCNN);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct MBFKDIHPCGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public readonly int KDMOOKGHKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public readonly string BOBALIDCANN;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x8D2FE0", Offset = "0x8D15E0", VA = "0x1808D2FE0")]
	public MBFKDIHPCGI(int CCFDHDODLHJ, string DBECLGENHFH)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class MDBMMECDLKK
{
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static byte[] GADOFMLHAHJ;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static int HEJKOBPMNOJ;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static int HLKLMDMLFLE;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static BigInteger DBAKCFGFCLA;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public MDBMMECDLKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C580", Offset = "0x5E9AB80", VA = "0x185E9C580")]
	private static string LLKJKMBGMPE(byte[] LKLEFAIICIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C230", Offset = "0x5E9A830", VA = "0x185E9C230")]
	public static string FCKPDHOJNPG(byte[] PPJLGCLGPJE, bool KMFFDGBHCMI)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
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

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
		[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DBBC80", Offset = "0x5DBA680", VA = "0x185DBBC80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6926F0", Offset = "0x6910F0", VA = "0x1806926F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x812880", Offset = "0x811280", VA = "0x180812880")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DB7F20", Offset = "0x5DB6920", VA = "0x185DB7F20")]
	public GNKPHLPEDJO(string PCIEMKDPNGG, float EANJDEPMAOJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x24FDFF0", Offset = "0x24FC9F0", VA = "0x1824FDFF0")]
	public void AFPLPLBOOFP<T>(string LNOIPGJELOP, T MAKFNMHIJIF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7B80", Offset = "0x5DB6580", VA = "0x185DB7B80")]
	public void AFPLPLBOOFP(string LNOIPGJELOP, string MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7DE0", Offset = "0x5DB67E0", VA = "0x185DB7DE0")]
	public void NGHOGMINKKF(string AGNJOFHHANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7D20", Offset = "0x5DB6720", VA = "0x185DB7D20")]
	public void ENNDEDHGFAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7C00", Offset = "0x5DB6600", VA = "0x185DB7C00")]
	private void BCKBHFEINEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7ED0", Offset = "0x5DB68D0", VA = "0x185DB7ED0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DBD8E0", Offset = "0x5DBC2E0", VA = "0x185DBD8E0", Slot = "4")]
	public IGOPHNBFNOE OIEJOMHJJDA(string KAECEDMINHD, string AOPKPOMEDAD, [Optional] HHOLBCFHBMD DKONNMFNCLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD4D0", Offset = "0x5DBBED0", VA = "0x185DBD4D0", Slot = "11")]
	public IGOPHNBFNOE HMJFAENMIFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5DBDD80", Offset = "0x5DBC780", VA = "0x185DBDD80", Slot = "5")]
	public IGOPHNBFNOE PDIEBDIELJI(HHOLBCFHBMD DKONNMFNCLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5DBCF90", Offset = "0x5DBB990", VA = "0x185DBCF90", Slot = "6")]
	public IGOPHNBFNOE DICLNIPNCAD(HHOLBCFHBMD DKONNMFNCLF, Dictionary<string, string> NDLHCNNFKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD830", Offset = "0x5DBC230", VA = "0x185DBD830", Slot = "7")]
	public bool KBDMBHLGJPI(string NCPKBJFPLNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD660", Offset = "0x5DBC060", VA = "0x185DBD660", Slot = "8")]
	public JBCBEFKAJPA JBLDFJEENAG(string JJFBDCCOHDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD770", Offset = "0x5DBC170", VA = "0x185DBD770", Slot = "9")]
	public JECDKIGBKFJ JKPMFOIOAOK(string KPAMLFCJJNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5DBCEA0", Offset = "0x5DBB8A0", VA = "0x185DBCEA0", Slot = "10")]
	public JBCBEFKAJPA CPBJEHFGKCN(string CNCDKICKCGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC710", Offset = "0x5DBB110", VA = "0x185DBC710")]
	private PMBIOKPKGPH BIBECGGFGFK(HHOLBCFHBMD DKONNMFNCLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5DBCD00", Offset = "0x5DBB700", VA = "0x185DBCD00")]
	private HCPKGEMDIAB COGOEKJKAMG(string AOPKPOMEDAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD280", Offset = "0x5DBBC80", VA = "0x185DBD280")]
	private void DOPHGEDLHBH(string JJFBDCCOHDJ, JBCBEFKAJPA PPPBIOFDOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public PNOJAFKPEEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x83E620", Offset = "0x83D020", VA = "0x18083E620")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DBBA60", Offset = "0x5DBA460", VA = "0x185DBBA60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	[Preserve]
	public MJEFIDGHPBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB680", Offset = "0x5DBA080", VA = "0x185DBB680")]
	[PILNOHNDGDF(KBMKLHMPDPB.GameOnly)]
	private static void NFCMOOADJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB780", Offset = "0x5DBA180", VA = "0x185DBB780", Slot = "4")]
	public IGOPHNBFNOE OIEJOMHJJDA(string KAECEDMINHD, string AOPKPOMEDAD, [Optional] HHOLBCFHBMD DKONNMFNCLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB960", Offset = "0x5DBA360", VA = "0x185DBB960", Slot = "5")]
	public IGOPHNBFNOE PDIEBDIELJI(HHOLBCFHBMD DKONNMFNCLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB230", Offset = "0x5DB9C30", VA = "0x185DBB230", Slot = "6")]
	public IGOPHNBFNOE DICLNIPNCAD(HHOLBCFHBMD DKONNMFNCLF, Dictionary<string, string> NDLHCNNFKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB5E0", Offset = "0x5DB9FE0", VA = "0x185DBB5E0", Slot = "7")]
	public bool KBDMBHLGJPI(string NCPKBJFPLNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB440", Offset = "0x5DB9E40", VA = "0x185DBB440", Slot = "8")]
	public JBCBEFKAJPA JBLDFJEENAG(string JJFBDCCOHDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB4E0", Offset = "0x5DB9EE0", VA = "0x185DBB4E0", Slot = "9")]
	public JECDKIGBKFJ JKPMFOIOAOK(string KPAMLFCJJNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB190", Offset = "0x5DB9B90", VA = "0x185DBB190", Slot = "10")]
	public JBCBEFKAJPA CPBJEHFGKCN(string CNCDKICKCGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB340", Offset = "0x5DB9D40", VA = "0x185DBB340", Slot = "11")]
	public IGOPHNBFNOE HMJFAENMIFJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class BKCOJKHEFFO : HGHONBEIFHF
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5DB70F0", Offset = "0x5DB5AF0", VA = "0x185DB70F0", Slot = "4")]
	public IGOPHNBFNOE OIEJOMHJJDA(string KAECEDMINHD, string AOPKPOMEDAD, [Optional] HHOLBCFHBMD DKONNMFNCLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7190", Offset = "0x5DB5B90", VA = "0x185DB7190", Slot = "5")]
	public IGOPHNBFNOE PDIEBDIELJI(HHOLBCFHBMD DKONNMFNCLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6FA0", Offset = "0x5DB59A0", VA = "0x185DB6FA0", Slot = "6")]
	public IGOPHNBFNOE DICLNIPNCAD(HHOLBCFHBMD DKONNMFNCLF, Dictionary<string, string> NDLHCNNFKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679700", VA = "0x18067AD00", Slot = "7")]
	public bool KBDMBHLGJPI(string NCPKBJFPLNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6F90", Offset = "0x5DB5990", VA = "0x185DB6F90", Slot = "8")]
	public JBCBEFKAJPA JBLDFJEENAG(string JJFBDCCOHDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5DB70E0", Offset = "0x5DB5AE0", VA = "0x185DB70E0", Slot = "9")]
	public JECDKIGBKFJ JKPMFOIOAOK(string KPAMLFCJJNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6F90", Offset = "0x5DB5990", VA = "0x185DB6F90", Slot = "10")]
	public JBCBEFKAJPA CPBJEHFGKCN(string CNCDKICKCGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7040", Offset = "0x5DB5A40", VA = "0x185DB7040", Slot = "11")]
	public IGOPHNBFNOE HMJFAENMIFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool ACOAIIHEKMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6923D0", Offset = "0x690DD0", VA = "0x1806923D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xEC9410", Offset = "0xEC7E10", VA = "0x180EC9410")]
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
				[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
				[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
				public EKEHGFOIKNM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x5DB7840", Offset = "0x5DB6240", VA = "0x185DB7840")]
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
				[Cpp2IlInjected.Address(RVA = "0x5DB94F0", Offset = "0x5DB7EF0", VA = "0x185DB94F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public int? HCJAKDMLACN
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x5DB9E30", Offset = "0x5DB8830", VA = "0x185DB9E30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x5DB9EF0", Offset = "0x5DB88F0", VA = "0x185DB9EF0")]
			internal JOBLDNINJFK(string IMEEJHLAPNK, string AOPKPOMEDAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5DB9AF0", Offset = "0x5DB84F0", VA = "0x185DB9AF0")]
			public int MJCHBOILBBB([Optional] int? HBNJIIBFGLB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5DB9860", Offset = "0x5DB8260", VA = "0x185DB9860")]
			public List<Dictionary<string, object>> MGNDKNALBIP(int IJNJIEKDCNC, int? HBNJIIBFGLB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5DB9C80", Offset = "0x5DB8680", VA = "0x185DB9C80")]
			public void MPJLCFLNLJL(AmplitudeAnalyticsIdentifyMessage LGKNNMGLNIA, bool GOCHFFJFDOG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5DB9D20", Offset = "0x5DB8720", VA = "0x185DB9D20")]
			public void MPJLCFLNLJL(Dictionary<string, object> LGKNNMGLNIA, bool GOCHFFJFDOG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5DB96D0", Offset = "0x5DB80D0", VA = "0x185DB96D0")]
			public void JIIMHHDMDPO(params Dictionary<string, object>[] OLNBDPFFEFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5DB8A50", Offset = "0x5DB7450", VA = "0x185DB8A50")]
			public void DIBLAFHPAOO(List<Dictionary<string, object>> ODCHNKIAPLL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x5DB9590", Offset = "0x5DB7F90", VA = "0x185DB9590")]
			private void IOLINLDEKID(Dictionary<string, object> LGKNNMGLNIA, bool GOCHFFJFDOG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x5DB8DD0", Offset = "0x5DB77D0", VA = "0x185DB8DD0")]
			public void HFNOCENEKAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x5DB9040", Offset = "0x5DB7A40", VA = "0x185DB9040")]
			private void HLINCIJFHJB([Optional] string EOJFFLKNAKN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x5DB8CA0", Offset = "0x5DB76A0", VA = "0x185DB8CA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5DBE1D0", Offset = "0x5DBCBD0", VA = "0x185DBE1D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679C00", VA = "0x18067B200")]
			[DebuggerHidden]
			public MCJCLPCIMBE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x5DBA080", Offset = "0x5DB8A80", VA = "0x185DBA080", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x5DBA670", Offset = "0x5DB9070", VA = "0x185DBA670", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679C00", VA = "0x18067B200")]
			[DebuggerHidden]
			public PHJNCNFNEMK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x5DBC5E0", Offset = "0x5DBAFE0", VA = "0x185DBC5E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x5DBC6D0", Offset = "0x5DBB0D0", VA = "0x185DBC6D0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679C00", VA = "0x18067B200")]
			[DebuggerHidden]
			public CMMALGLDHKF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x5DB7510", Offset = "0x5DB5F10", VA = "0x185DB7510", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x5DB7680", Offset = "0x5DB6080", VA = "0x185DB7680", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679C00", VA = "0x18067B200")]
			[DebuggerHidden]
			public GHNGOIBNLHA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x5DB78A0", Offset = "0x5DB62A0", VA = "0x185DB78A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x5DB7B40", Offset = "0x5DB6540", VA = "0x185DB7B40", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679C00", VA = "0x18067B200")]
			[DebuggerHidden]
			public CKPDPFAKKOE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x5DB7230", Offset = "0x5DB5C30", VA = "0x185DB7230", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x5DB74D0", Offset = "0x5DB5ED0", VA = "0x185DB74D0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
			public MFNJJGKLAEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x5DBACE0", Offset = "0x5DB96E0", VA = "0x185DBACE0")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x5DBAD80", Offset = "0x5DB9780", VA = "0x185DBAD80")]
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679C00", VA = "0x18067B200")]
			[DebuggerHidden]
			public OBEFHMHAGCJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x5DBBD10", Offset = "0x5DBA710", VA = "0x185DBBD10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x5DBC5A0", Offset = "0x5DBAFA0", VA = "0x185DBC5A0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
			public JOHKOHDIDHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x317C910", Offset = "0x317B310", VA = "0x18317C910")]
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
			[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
			public PJNLBHHLPMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x317C910", Offset = "0x317B310", VA = "0x18317C910")]
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
			[Cpp2IlInjected.Address(RVA = "0x5DB43A0", Offset = "0x5DB2DA0", VA = "0x185DB43A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private static int EEFOGMPOJIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5DB4650", Offset = "0x5DB3050", VA = "0x185DB4650")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static long GIABGFNONJF
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5DB5BE0", Offset = "0x5DB45E0", VA = "0x185DB5BE0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5DB5CE0", Offset = "0x5DB46E0", VA = "0x185DB5CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static string PCIOAOFHPMO
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5DB5B80", Offset = "0x5DB4580", VA = "0x185DB5B80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static string AICPDMFHCAM
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5DB5BB0", Offset = "0x5DB45B0", VA = "0x185DB5BB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public string CNEOBJGALPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x68D740", Offset = "0x68C140", VA = "0x18068D740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6AEDC0", Offset = "0x6AD7C0", VA = "0x1806AEDC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int? AIMIBLBAPPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7A7C00", Offset = "0x7A6600", VA = "0x1807A7C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x1B4F6A0", Offset = "0x1B4E0A0", VA = "0x181B4F6A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public GOHAPJFGCLP? GBFELBBCCJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x72F7A0", Offset = "0x72E1A0", VA = "0x18072F7A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x12FE9F0", Offset = "0x12FD3F0", VA = "0x1812FE9F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool CDNHENBFMIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x11400E0", Offset = "0x113EAE0", VA = "0x1811400E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x113F520", Offset = "0x113DF20", VA = "0x18113F520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static bool AOHEGCPEDDN
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5DB5A90", Offset = "0x5DB4490", VA = "0x185DB5A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> EPGBMOAEEDI
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5DB59F0", Offset = "0x5DB43F0", VA = "0x185DB59F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5DB5C40", Offset = "0x5DB4640", VA = "0x185DB5C40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0C80", Offset = "0x5DAF680", VA = "0x185DB0C80", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1150", Offset = "0x5DAFB50", VA = "0x185DB1150")]
		private void CDELJCKJFKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5240", Offset = "0x5DB3C40", VA = "0x185DB5240")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4530", Offset = "0x5DB2F30", VA = "0x185DB4530", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5530", Offset = "0x5DB3F30", VA = "0x185DB5530")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5DB48A0", Offset = "0x5DB32A0", VA = "0x185DB48A0")]
		public IGOPHNBFNOE PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2FB0", Offset = "0x5DB19B0", VA = "0x185DB2FB0")]
		[IteratorStateMachine(typeof(MCJCLPCIMBE))]
		public IEnumerator<PBBBHKGHFDI> Initialize(AmplitudeAnalyticsEvent KAPFKBMGLLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5420", Offset = "0x5DB3E20", VA = "0x185DB5420")]
		public void UpdateLastAliveTime(float MNNKIKNAMKE = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1470", Offset = "0x5DAFE70", VA = "0x185DB1470")]
		private IGOPHNBFNOE CKDHHNLOHPH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5DB30D0", Offset = "0x5DB1AD0", VA = "0x185DB30D0")]
		private IGOPHNBFNOE JECLKKKMGBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4DF0", Offset = "0x5DB37F0", VA = "0x185DB4DF0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3040", Offset = "0x5DB1A40", VA = "0x185DB3040")]
		[IteratorStateMachine(typeof(PHJNCNFNEMK))]
		private IEnumerator JAJFFOOFAMA(EONHFJBEBFJ PHNAHADJDBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5DB57A0", Offset = "0x5DB41A0", VA = "0x185DB57A0")]
		[IteratorStateMachine(typeof(CMMALGLDHKF))]
		public IEnumerator WaitForFlush(float DKOGNBKHEEK = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5300", Offset = "0x5DB3D00", VA = "0x185DB5300")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5250", Offset = "0x5DB3C50", VA = "0x185DB5250")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime BPPPFJGDDBP)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2C00", Offset = "0x5DB1600", VA = "0x185DB2C00")]
		public static IPNKOFKMIJE Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0AE0", Offset = "0x5DAF4E0", VA = "0x185DB0AE0")]
		public static IELDMODPJDI AccountSelectionPostLoginEvent([NotNull] string NLNHKLKCEOA, string BLFKBMDMAMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1C70", Offset = "0x5DB0670", VA = "0x185DB1C70")]
		public static IELDMODPJDI Event([NotNull] string NLNHKLKCEOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4900", Offset = "0x5DB3300", VA = "0x185DB4900")]
		public static IELDMODPJDI PreviousSessionEvent([NotNull] string NLNHKLKCEOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2D60", Offset = "0x5DB1760", VA = "0x185DB2D60")]
		public static IELDMODPJDI InitializeEvent(string BLFKBMDMAMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4F50", Offset = "0x5DB3950", VA = "0x185DB4F50")]
		public static IELDMODPJDI StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1620", Offset = "0x5DB0020", VA = "0x185DB1620")]
		public static IELDMODPJDI CreateOutOfSessionEvent(string NLNHKLKCEOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3690", Offset = "0x5DB2090", VA = "0x185DB3690")]
		public static IGOPHNBFNOE LogOutOfSessionEvent(IELDMODPJDI KLDCCGHEELK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5DB33D0", Offset = "0x5DB1DD0", VA = "0x185DB33D0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent HFHMFFPPFLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3A30", Offset = "0x5DB2430", VA = "0x185DB3A30")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent HFHMFFPPFLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3B80", Offset = "0x5DB2580", VA = "0x185DB3B80")]
		public void LogSerializedEventAsync(Dictionary<string, object> IKCIBDFNBEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3520", Offset = "0x5DB1F20", VA = "0x185DB3520")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage PENCBOFBNGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5DB42C0", Offset = "0x5DB2CC0", VA = "0x185DB42C0")]
		private void NDMLFCFCDFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5DB18F0", Offset = "0x5DB02F0", VA = "0x185DB18F0")]
		private void DGBFFDGKHGL(Dictionary<string, object> JDEFICMNKIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1B80", Offset = "0x5DB0580", VA = "0x185DB1B80")]
		private void EFNKPOLDJPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0F70", Offset = "0x5DAF970", VA = "0x185DB0F70")]
		private void BKEINBLDKGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1E70", Offset = "0x5DB0870", VA = "0x185DB1E70")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4820", Offset = "0x5DB3220", VA = "0x185DB4820")]
		[IteratorStateMachine(typeof(GHNGOIBNLHA))]
		private IEnumerator<PBBBHKGHFDI> PGCFBJGFKCN(float DKOGNBKHEEK = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5DB45D0", Offset = "0x5DB2FD0", VA = "0x185DB45D0")]
		[IteratorStateMachine(typeof(CKPDPFAKKOE))]
		private IEnumerator<PBBBHKGHFDI> PAFALKFLPDI(float DKOGNBKHEEK = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1540", Offset = "0x5DAFF40", VA = "0x185DB1540")]
		[IteratorStateMachine(typeof(OBEFHMHAGCJ))]
		private IEnumerator<PBBBHKGHFDI> CNEBMFKEOCA(JOBLDNINJFK ODMPDKFLOEI, int? HBNJIIBFGLB, string LMPNJDEGODD, string BGNOMIPGMNG, float DKOGNBKHEEK, Action<int> FACCJNKLNJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4410", Offset = "0x5DB2E10", VA = "0x185DB4410")]
		private static void OINCJIFNIIF(bool EGPCCIKKLOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3FB0", Offset = "0x5DB29B0", VA = "0x185DB3FB0")]
		private global::DIHJKCFGFNO<DMKBCOLCKBO<Dictionary<string, object>>> MHAIMGJBAPG(string LMPNJDEGODD, string BGNOMIPGMNG, string INOIPIAGFMI, string EBFLNBMKEIM, Dictionary<string, object> APLCCHNGLIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3C60", Offset = "0x5DB2660", VA = "0x185DB3C60")]
		private global::DIHJKCFGFNO<DMKBCOLCKBO<List<Dictionary<string, object>>>> MHAIMGJBAPG(string LMPNJDEGODD, string BGNOMIPGMNG, string INOIPIAGFMI, string EBFLNBMKEIM, List<Dictionary<string, object>> APLCCHNGLIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3897F60", Offset = "0x3896960", VA = "0x183897F60")]
		private global::DIHJKCFGFNO<DMKBCOLCKBO<T>> JFIPJKKCNBJ<T>(string LMPNJDEGODD, string BGNOMIPGMNG, string EBFLNBMKEIM, T APLCCHNGLIK, Dictionary<string, object> LLBAEMDBHMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x38981F0", Offset = "0x3896BF0", VA = "0x1838981F0")]
		private global::DIHJKCFGFNO<DMKBCOLCKBO<T>> MBFGMBJHGBF<T>(string LMPNJDEGODD, string BGNOMIPGMNG, string INOIPIAGFMI, T APLCCHNGLIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3370", Offset = "0x5DB1D70", VA = "0x185DB3370")]
		private bool KFPHFNFIIPH(float LGMCDNJLHGA, float DKOGNBKHEEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1F00", Offset = "0x5DB0900", VA = "0x185DB1F00")]
		private Dictionary<string, object> HANBAOMEPHG(string BGNOMIPGMNG, Dictionary<string, object> APLCCHNGLIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5880", Offset = "0x5DB4280", VA = "0x185DB5880")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4160", Offset = "0x5DB2B60", VA = "0x185DB4160")]
		[CompilerGenerated]
		private long MPHCHDEOLIE()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5DB33C0", Offset = "0x5DB1DC0", VA = "0x185DB33C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5DB6780", Offset = "0x5DB5180", VA = "0x185DB6780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x5DB67E0", Offset = "0x5DB51E0", VA = "0x185DB67E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x68D780", Offset = "0x68C180", VA = "0x18068D780")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5D40", Offset = "0x5DB4740", VA = "0x185DB5D40")]
		public static IELDMODPJDI CBFHJGEFJHE(string AJGHIJIKOBE, [NotNull] string PJKFKLILAKL, long DHLGNBEAFOA, long BMGLGFNAGOO, string BLFKBMDMAMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5DB64C0", Offset = "0x5DB4EC0", VA = "0x185DB64C0")]
		public static IELDMODPJDI PNFHLFPHIBP(string AJGHIJIKOBE, [NotNull] string PJKFKLILAKL, long DHLGNBEAFOA, long BMGLGFNAGOO, string BLFKBMDMAMJ, long FKMPPJBLBFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5DB65C0", Offset = "0x5DB4FC0", VA = "0x185DB65C0")]
		private AmplitudeAnalyticsEvent(string AJGHIJIKOBE, [NotNull] string PJKFKLILAKL, long DHLGNBEAFOA, long BMGLGFNAGOO, string BLFKBMDMAMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x949990", Offset = "0x948390", VA = "0x180949990")]
		public void DMMBGKKAPGD(long GMHFKKJKLCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5DB63A0", Offset = "0x5DB4DA0", VA = "0x185DB63A0", Slot = "5")]
		public override void LOFNPGOJNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5E30", Offset = "0x5DB4830", VA = "0x185DB5E30", Slot = "6")]
		public override void COBECOFGEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5EB0", Offset = "0x5DB48B0", VA = "0x185DB5EB0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5DB76C0", Offset = "0x5DB60C0", VA = "0x185DB76C0")]
			public void BFFIFOFDLBN(Dictionary<string, object> KPKEFEHBMHB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x5DBE060", Offset = "0x5DBCA60", VA = "0x185DBE060")]
			public void BFFIFOFDLBN(Dictionary<string, object> ELEEANBEFBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x11FA130", Offset = "0x11F8B30", VA = "0x1811FA130")]
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
			[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x697130", Offset = "0x695B30", VA = "0x180697130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5DB68F0", Offset = "0x5DB52F0", VA = "0x185DB68F0")]
		public static IPNKOFKMIJE CBFHJGEFJHE(string AJGHIJIKOBE, string BLFKBMDMAMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6ED0", Offset = "0x5DB58D0", VA = "0x185DB6ED0")]
		protected AmplitudeAnalyticsIdentifyMessage(string AJGHIJIKOBE, string BLFKBMDMAMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6E50", Offset = "0x5DB5850", VA = "0x185DB6E50")]
		public Dictionary<string, object> NNIKNNOKJFH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6A90", Offset = "0x5DB5490", VA = "0x185DB6A90", Slot = "4")]
		protected virtual Dictionary<string, object> LALGHHBFCPJ(Dictionary<string, object> JBMHOFJOJLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6850", Offset = "0x5DB5250", VA = "0x185DB6850")]
		protected void BFFKBJHGNPF(string AIGAKEKDKHM, Dictionary<string, object> JBNOFPBDAHB, Dictionary<string, object> OGMLJJLHNKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6A20", Offset = "0x5DB5420", VA = "0x185DB6A20")]
		protected void HKEFCAFOKPI(string AIGAKEKDKHM, string MAKFNMHIJIF, Dictionary<string, object> GKDAPMHFKJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6DD0", Offset = "0x5DB57D0", VA = "0x185DB6DD0", Slot = "5")]
		public virtual void LOFNPGOJNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5DB69A0", Offset = "0x5DB53A0", VA = "0x185DB69A0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x774500", Offset = "0x772F00", VA = "0x180774500", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage HNAANPFOIDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8A00", Offset = "0x5DB7400", VA = "0x185DB8A00")]
	public IPNKOFKMIJE(AmplitudeAnalyticsIdentifyMessage DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8960", Offset = "0x5DB7360", VA = "0x185DB8960", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x774500", Offset = "0x772F00", VA = "0x180774500", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public long LOOLJCIJLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8850", Offset = "0x5DB7250", VA = "0x185DB8850")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8280", Offset = "0x5DB6C80", VA = "0x185DB8280")]
	public IELDMODPJDI(AmplitudeAnalyticsEvent DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0", Slot = "5")]
	public override AmplitudeAnalyticsEvent HNAANPFOIDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5DB86F0", Offset = "0x5DB70F0", VA = "0x185DB86F0", Slot = "4")]
	public override void COBECOFGEFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5DB83E0", Offset = "0x5DB6DE0", VA = "0x185DB83E0")]
	public IELDMODPJDI AFPLPLBOOFP(string LNOIPGJELOP, long[] MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5DB85B0", Offset = "0x5DB6FB0", VA = "0x185DB85B0")]
	public IELDMODPJDI AFPLPLBOOFP(string LNOIPGJELOP, ulong[] MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x25F00D0", Offset = "0x25EEAD0", VA = "0x1825F00D0")]
	public IELDMODPJDI AFPLPLBOOFP<T>(string LNOIPGJELOP, T[] MAKFNMHIJIF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5DB83D0", Offset = "0x5DB6DD0", VA = "0x185DB83D0")]
	public IELDMODPJDI AFPLPLBOOFP(string LNOIPGJELOP, string[] MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x25F0060", Offset = "0x25EEA60", VA = "0x1825F0060")]
	public IELDMODPJDI AFPLPLBOOFP<T>(string LNOIPGJELOP, T MAKFNMHIJIF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5DB82D0", Offset = "0x5DB6CD0", VA = "0x185DB82D0")]
	public IELDMODPJDI AFPLPLBOOFP(string LNOIPGJELOP, long MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8520", Offset = "0x5DB6F20", VA = "0x185DB8520")]
	public IELDMODPJDI AFPLPLBOOFP(string LNOIPGJELOP, ulong MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8360", Offset = "0x5DB6D60", VA = "0x185DB8360")]
	public IELDMODPJDI AFPLPLBOOFP(string LNOIPGJELOP, string MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8830", Offset = "0x5DB7230", VA = "0x185DB8830")]
	public IELDMODPJDI HIBLLCHOLAD(string LNOIPGJELOP, object? MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8790", Offset = "0x5DB7190", VA = "0x185DB8790")]
	public IELDMODPJDI GGIDEDGHDOH(string LNOIPGJELOP, string MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8870", Offset = "0x5DB7270", VA = "0x185DB8870")]
	private IELDMODPJDI OGGAGHGLIBC(string LNOIPGJELOP, object MAKFNMHIJIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class HDAGEDBKHOO : IELDMODPJDI
{
	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8280", Offset = "0x5DB6C80", VA = "0x185DB8280")]
	public HDAGEDBKHOO(AmplitudeAnalyticsEvent DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5DB80C0", Offset = "0x5DB6AC0", VA = "0x185DB80C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x257A080", Offset = "0x2578A80", VA = "0x18257A080")]
	public ACECIKOJEBC(M DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x38AF180", Offset = "0x38ADB80", VA = "0x1838AF180")]
	public BLDR OFLLNAEKFMF(AmplitudeAnalyticsIdentifyMessage.DeviceInfo FDOFODFGNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x38AF1C0", Offset = "0x38ADBC0", VA = "0x1838AF1C0")]
	public BLDR OIHBGKIGEKF(AmplitudeAnalyticsIdentifyMessage.RevenueData ODMDMBMBEIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x38AEFF0", Offset = "0x38AD9F0", VA = "0x1838AEFF0")]
	public BLDR COFEJIDDCIA(string LNOIPGJELOP, string MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x293A540", Offset = "0x2938F40", VA = "0x18293A540")]
	public BLDR COFEJIDDCIA<T>(string LNOIPGJELOP, T MAKFNMHIJIF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x38AEF40", Offset = "0x38AD940", VA = "0x1838AEF40")]
	public BLDR COFEJIDDCIA(string LNOIPGJELOP, long MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x38AEE90", Offset = "0x38AD890", VA = "0x1838AEE90")]
	public BLDR COFEJIDDCIA(string LNOIPGJELOP, ulong MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void COBECOFGEFP();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x38AF150", Offset = "0x38ADB50", VA = "0x1838AF150")]
	internal static string OEFFAMAHOAK(string MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x38AF060", Offset = "0x38ADA60", VA = "0x1838AF060")]
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
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DBBAD0", Offset = "0x5DBA4D0", VA = "0x185DBBAD0")]
	internal static bool BECFMIBGCPF(string AIGAKEKDKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A20B0", Offset = "0x6A0AB0", VA = "0x1806A20B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public MDBMMECDLKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5DBAA00", Offset = "0x5DB9400", VA = "0x185DBAA00")]
	private static string LLKJKMBGMPE(byte[] LKLEFAIICIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA6B0", Offset = "0x5DB90B0", VA = "0x185DBA6B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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

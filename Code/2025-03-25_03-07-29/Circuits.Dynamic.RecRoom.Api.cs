using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
		[Cpp2IlInjected.Address(RVA = "0x263CF90", Offset = "0x263C390", VA = "0x18263CF90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6F0", Offset = "0x9BBAF0", VA = "0x1809BC6F0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9BC730", Offset = "0x9BBB30", VA = "0x1809BC730")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct JHAEHINNHPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public EECNAGIPCBM<OGFMDANGMLF> IPBAABIBOBH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x263CEC0", Offset = "0x263C2C0", VA = "0x18263CEC0")]
	public static JHAEHINNHPI AFLKMMODJAC()
	{
		return default(JHAEHINNHPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x263CEF0", Offset = "0x263C2F0", VA = "0x18263CEF0")]
	[CompilerGenerated]
	internal static EECNAGIPCBM<OGFMDANGMLF> PKBEPCDLDLG(int FIIKLGCIAGG)
	{
		return default(EECNAGIPCBM<OGFMDANGMLF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FKPKOCEEANE
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface INEOGNLIKLL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int BEBIJLHICBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int GPKNHLOMBMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float IMNOKCEDNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float PPDNOJPCPAF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool MJCHKENABMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BMKEEAGAHLK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool CGIPIANOMDC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DCMDOGAMABH<DKANDHFOMPH> CV2SetMaxAmmo(HEBAMOJLAJA MIJGFNBACFK, int HJCBHKAGEBL);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DCMDOGAMABH<DKANDHFOMPH> CV2SetCurrentAmmo(HEBAMOJLAJA MIJGFNBACFK, int AFADNKNNDKJ);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DCMDOGAMABH<DKANDHFOMPH> CV2SetADSEnabled(HEBAMOJLAJA MIJGFNBACFK, bool EJBJKNOIGIB);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "10")]
	DCMDOGAMABH<DKANDHFOMPH> CV2SetCanReload(HEBAMOJLAJA MIJGFNBACFK, bool MJPGICCLFLB);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DCMDOGAMABH<DKANDHFOMPH> CV2SetContinuousFire(HEBAMOJLAJA MIJGFNBACFK, bool OIPIIGDLPPA);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DCMDOGAMABH<DKANDHFOMPH> CV2SetRateOfFire(HEBAMOJLAJA MIJGFNBACFK, float JOOAPGEPGHG);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "13")]
	DCMDOGAMABH<DKANDHFOMPH> CV2SetReloadDuration(HEBAMOJLAJA MIJGFNBACFK, float AKIEJPDFOGK);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface MDDJKJKDCKB
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string FADJCEFBKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DCMDOGAMABH<DKANDHFOMPH> SetHandleControlLabel(HEBAMOJLAJA MIJGFNBACFK, string FAGNIGAMDJK);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BAHGJNHENGN
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(FKPKOCEEANE, FKPKOCEEANE, FKPKOCEEANE, FKPKOCEEANE, FKPKOCEEANE) KJDLIOEBLNM(object CALAFNPECBD);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object DFPELANIALN();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MLDGJAOBMHH(object CALAFNPECBD);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string FLAILMPNDND(object CALAFNPECBD);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DKMLIKPDHFD
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool EJKDHAKEEEH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HLOLLLBEKFC
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EJPPFNLOKLD PIMIACJPJPG(int ABEJKMJDICJ);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int HPLLHGDKJML([In] EJPPFNLOKLD ODKLLNJFOFL);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FCCBGBLIEEC
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DCMDOGAMABH<DKANDHFOMPH> SetEnabled(HEBAMOJLAJA MIJGFNBACFK, bool AGBIBPMGCIJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct LDIGIPAMNEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly ICCGNOOFIKJ KAKPDEACMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly HLOLLLBEKFC HEIKCNKCKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly BAHGJNHENGN ONLHGDCFHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly JHAEHINNHPI FPOKCCHKILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly EOFNFLKHEBM CICHFJPOMJP;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x263CF20", Offset = "0x263C320", VA = "0x18263CF20")]
	public LDIGIPAMNEF(ICCGNOOFIKJ CFLEKOBEGAF, HLOLLLBEKFC MBDGKAOABOH, BAHGJNHENGN FMDABIPPHMI, [In] JHAEHINNHPI LPCIFBAJGIM, EOFNFLKHEBM GMCDJLKMGEI)
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

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RecRoom.AI.OpenAI.Realtime;
using RecRoom.Audio;
using RecRoom.DataLayer.Audio;
using RecRoom.Logging.Attributes;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B980", Offset = "0x7E4A580", VA = "0x187E4B980")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA87960", Offset = "0xA86560", VA = "0x180A87960")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA879A0", Offset = "0xA865A0", VA = "0x180A879A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_AI_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : MMLLDFGFMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7E48400", Offset = "0x7E47000", VA = "0x187E48400", Slot = "4")]
		public override void AMHLLDBNIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum EIKJEFCONGE
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Int,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Float,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Bool,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	String
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class LFMKINFPHFJ : IEquatable<LFMKINFPHFJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Type CPLOGNDDIFM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7E46550", Offset = "0x7E45150", VA = "0x187E46550", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public EIKJEFCONGE GJCIAOMMHGH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA5B110", Offset = "0xA59D10", VA = "0x180A5B110")]
		[CompilerGenerated]
		get
		{
			return default(EIKJEFCONGE);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7B0", Offset = "0xA5B3B0", VA = "0x180A5C7B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string FEGHCLOCPPH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA5B740", Offset = "0xA5A340", VA = "0x180A5B740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string AIPBCIKCLMO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7A0", Offset = "0xA5B3A0", VA = "0x180A5C7A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool FIOJJFCDFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xAC0B50", Offset = "0xABF750", VA = "0x180AC0B50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xAC0880", Offset = "0xABF480", VA = "0x180AC0880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7E469A0", Offset = "0x7E455A0", VA = "0x187E469A0")]
	public LFMKINFPHFJ(EIKJEFCONGE GJCIAOMMHGH, string FEGHCLOCPPH, string AIPBCIKCLMO = "", bool FIOJJFCDFIF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7E46830", Offset = "0x7E45430", VA = "0x187E46830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7E465B0", Offset = "0x7E451B0", VA = "0x187E465B0", Slot = "6")]
	protected virtual bool ICEFMOGIBAF(StringBuilder DDJELLABJIL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x11F2920", Offset = "0x11F1520", VA = "0x1811F2920")]
	public static bool IECKAGJENEB(LFMKINFPHFJ? BPDAPAPCGNJ, LFMKINFPHFJ? NFNCPNOAJAJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x11F2480", Offset = "0x11F1080", VA = "0x1811F2480")]
	public static bool CDGFDPOPEPC(LFMKINFPHFJ? BPDAPAPCGNJ, LFMKINFPHFJ? NFNCPNOAJAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7E463A0", Offset = "0x7E44FA0", VA = "0x187E463A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7E46150", Offset = "0x7E44D50", VA = "0x187E46150", Slot = "0")]
	public override bool Equals(object? KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7E461E0", Offset = "0x7E44DE0", VA = "0x187E461E0", Slot = "7")]
	public virtual bool Equals(LFMKINFPHFJ? IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7E467A0", Offset = "0x7E453A0", VA = "0x187E467A0", Slot = "8")]
	public virtual LFMKINFPHFJ KIFIJLAIMMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7E46940", Offset = "0x7E45540", VA = "0x187E46940")]
	protected LFMKINFPHFJ(LFMKINFPHFJ IMGHKDLHKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7E46100", Offset = "0x7E44D00", VA = "0x187E46100")]
	public void AEDAIPFNKDM([Out] EIKJEFCONGE GJCIAOMMHGH, [Out] string FEGHCLOCPPH, [Out] string AIPBCIKCLMO, [Out] bool FIOJJFCDFIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ONKPEPCBDDF : IEquatable<ONKPEPCBDDF>
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	protected virtual Type CPLOGNDDIFM
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7E4C7F0", Offset = "0x7E4B3F0", VA = "0x187E4C7F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public JToken EALJMBJMFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA5B460", Offset = "0xA5A060", VA = "0x180A5B460")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public LFMKINFPHFJ POOMLAMMIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA5B740", Offset = "0xA5A340", VA = "0x180A5B740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x11EF390", Offset = "0x11EDF90", VA = "0x1811EF390")]
	public ONKPEPCBDDF(JToken EALJMBJMFLJ, LFMKINFPHFJ POOMLAMMIMO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7E4CA30", Offset = "0x7E4B630", VA = "0x187E4CA30")]
	public static int IEHBFKINBPP(ONKPEPCBDDF BKMPCFIAHIG)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7E4CFF0", Offset = "0x7E4BBF0", VA = "0x187E4CFF0")]
	public static float IEHBFKINBPP(ONKPEPCBDDF BKMPCFIAHIG)
	{
		return default(float);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7E4CE20", Offset = "0x7E4BA20", VA = "0x187E4CE20")]
	public static bool IEHBFKINBPP(ONKPEPCBDDF BKMPCFIAHIG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C940", Offset = "0x7E4B540", VA = "0x187E4C940")]
	public static string IEHBFKINBPP(ONKPEPCBDDF BKMPCFIAHIG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7E4CD10", Offset = "0x7E4B910", VA = "0x187E4CD10")]
	public static int[] IEHBFKINBPP(ONKPEPCBDDF BKMPCFIAHIG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7E4CEE0", Offset = "0x7E4BAE0", VA = "0x187E4CEE0")]
	public static float[] IEHBFKINBPP(ONKPEPCBDDF BKMPCFIAHIG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7E4CC00", Offset = "0x7E4B800", VA = "0x187E4CC00")]
	public static bool[] IEHBFKINBPP(ONKPEPCBDDF BKMPCFIAHIG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7E4CAF0", Offset = "0x7E4B6F0", VA = "0x187E4CAF0")]
	public static string[] IEHBFKINBPP(ONKPEPCBDDF BKMPCFIAHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D140", Offset = "0x7E4BD40", VA = "0x187E4D140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C850", Offset = "0x7E4B450", VA = "0x187E4C850", Slot = "6")]
	protected virtual bool ICEFMOGIBAF(StringBuilder DDJELLABJIL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x11F2920", Offset = "0x11F1520", VA = "0x1811F2920")]
	public static bool IECKAGJENEB(ONKPEPCBDDF? BPDAPAPCGNJ, ONKPEPCBDDF? NFNCPNOAJAJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x11F2480", Offset = "0x11F1080", VA = "0x1811F2480")]
	public static bool CDGFDPOPEPC(ONKPEPCBDDF? BPDAPAPCGNJ, ONKPEPCBDDF? NFNCPNOAJAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C6D0", Offset = "0x7E4B2D0", VA = "0x187E4C6D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C640", Offset = "0x7E4B240", VA = "0x187E4C640", Slot = "0")]
	public override bool Equals(object? KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C500", Offset = "0x7E4B100", VA = "0x187E4C500", Slot = "7")]
	public virtual bool Equals(ONKPEPCBDDF? IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D0B0", Offset = "0x7E4BCB0", VA = "0x187E4D0B0", Slot = "8")]
	public virtual ONKPEPCBDDF KIFIJLAIMMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D250", Offset = "0x7E4BE50", VA = "0x187E4D250")]
	protected ONKPEPCBDDF(ONKPEPCBDDF IMGHKDLHKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C4C0", Offset = "0x7E4B0C0", VA = "0x187E4C4C0")]
	public void AEDAIPFNKDM([Out] JToken EALJMBJMFLJ, [Out] LFMKINFPHFJ POOMLAMMIMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class NKOJIKEELJN : PAGLIHLGBDP
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const string GMCNEMBMCJI = "Open AI Realtime API";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private const string GNPOPEBGMJD = "endpoint";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string KHJNBNLONEO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public BBJODKOKOBA? DAAHPJEFIEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA5B740", Offset = "0xA5A340", VA = "0x180A5B740", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public decimal IDMGFFMLJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xE4A620", Offset = "0xE49220", VA = "0x180E4A620", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xF40730", Offset = "0xF3F330", VA = "0x180F40730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string GLEFBMJLKLC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5A0", Offset = "0xA5A1A0", VA = "0x180A5B5A0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA5FCB0", Offset = "0xA5E8B0", VA = "0x180A5FCB0", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7E4B6F0", Offset = "0x7E4A2F0", VA = "0x187E4B6F0")]
	public NKOJIKEELJN(string DBLEEDABNAE, string JPNNJHKEJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7E49C30", Offset = "0x7E48830", VA = "0x187E49C30")]
	private static MBKGBFPEPFO.PPMOBLDKHND BMKACFKKANA(string GCMGIIOIBAL, string DGAEKBKPCCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7E4ADB0", Offset = "0x7E499B0", VA = "0x187E4ADB0")]
	private MBKGBFPEPFO.PPMOBLDKHND JPLPDNGHPAG(string GCMGIIOIBAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7E4A220", Offset = "0x7E48E20", VA = "0x187E4A220", Slot = "9")]
	public void FKIGLHBJGGF(string? APLKCLBHHOJ, string OAOPBELJGGD, string GHILGCANDFL, float EFJLFBADMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7E4ABA0", Offset = "0x7E497A0", VA = "0x187E4ABA0", Slot = "10")]
	public void HIEPBKGNECL(string? APLKCLBHHOJ, ErrorEventDTO AKPHDFOCOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7E4B560", Offset = "0x7E4A160", VA = "0x187E4B560")]
	public static void OPACIDDLMLN(string MKMPFLKICKK, string DGAEKBKPCCJ, decimal BEAONNGPBDP, string PBHLPKLGFAP, params (string key, string val)[] FJOLFOKCIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7E4B360", Offset = "0x7E49F60", VA = "0x187E4B360", Slot = "11")]
	public void OPACIDDLMLN(string? APLKCLBHHOJ, decimal BEAONNGPBDP, string PBHLPKLGFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7E49CC0", Offset = "0x7E488C0", VA = "0x187E49CC0", Slot = "12")]
	public void EGECPGANDAM(string? APLKCLBHHOJ, ConversationItemDTO BHNJKAEPJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7E4ADF0", Offset = "0x7E499F0", VA = "0x187E4ADF0", Slot = "14")]
	public void KKIOMKLEALF(string? APLKCLBHHOJ, ResponseEventDTO AKPHDFOCOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7E49880", Offset = "0x7E48480", VA = "0x187E49880")]
	private (decimal?, string, string, string, string, string) APHMNPGBLEC(ResponseEventDTO AKPHDFOCOBG)
	{
		return default((decimal?, string, string, string, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7E4A3F0", Offset = "0x7E48FF0", VA = "0x187E4A3F0", Slot = "13")]
	public void FOJHNIJELDP(string? APLKCLBHHOJ, ResponseEventDTO AKPHDFOCOBG, float? IDALCKPOKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7E4AA50", Offset = "0x7E49650", VA = "0x187E4AA50", Slot = "15")]
	public void GJJNJGHMAOL(string? APLKCLBHHOJ, string LENOHNAJDNM, string? MFCHFPLNKAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class KLBFMDHIICE : PAGLIHLGBDP
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public BBJODKOKOBA? DAAHPJEFIEE
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA5B460", Offset = "0xA5A060", VA = "0x180A5B460", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public decimal IDMGFFMLJPG
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7E45FC0", Offset = "0x7E44BC0", VA = "0x187E45FC0", Slot = "6")]
		get
		{
			return default(decimal);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string GLEFBMJLKLC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA5B740", Offset = "0xA5A340", VA = "0x180A5B740", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "9")]
	public void FKIGLHBJGGF(string? APLKCLBHHOJ, string OAOPBELJGGD, string GHILGCANDFL, float EFJLFBADMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "10")]
	public void HIEPBKGNECL(string? APLKCLBHHOJ, ErrorEventDTO AKPHDFOCOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "11")]
	public void OPACIDDLMLN(string? APLKCLBHHOJ, decimal BEAONNGPBDP, string PBHLPKLGFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "12")]
	public void EGECPGANDAM(string? APLKCLBHHOJ, ConversationItemDTO BHNJKAEPJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "14")]
	public void KKIOMKLEALF(string? APLKCLBHHOJ, ResponseEventDTO AKPHDFOCOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "13")]
	public void FOJHNIJELDP(string? APLKCLBHHOJ, ResponseEventDTO AKPHDFOCOBG, float? IDALCKPOKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "15")]
	public void GJJNJGHMAOL(string? APLKCLBHHOJ, string LENOHNAJDNM, string? MFCHFPLNKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7E46020", Offset = "0x7E44C20", VA = "0x187E46020")]
	public KLBFMDHIICE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NHOEKPEOKME
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	GFJLLHFJBHN<ConversationItemDTO> DEHBKIKCCLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	IReadOnlyList<ConversationItemDTO> PLCHCECHHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<string> HEHNCHJBALJ(ConversationItemDTO BHNJKAEPJMN);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NJGDGKLECHA(string BABCMIEBHAA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LIFLBGOOBJB
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LCHKJPIIHCP(IReadOnlyCollection<string> HNCIJLJMHHL, CancellationToken JHCOCAANJDL);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface EGAPNKKDAEF
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ToolDTO[] HAJNNNLBHJG();

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<string> LLOPIFGFKKK(string IEFFJAPJBDG, string OGNGKONOKIH, CancellationToken JHCOCAANJDL);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GEDGKMHBFFD
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface DOEKOMHJPCL
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	const string DDBJGAILDGD = "gpt-4o-mini-realtime-preview-2024-12-17";

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	const string HNAHJCPMHEM = "gpt-4o-mini-transcribe";

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	LEABLAPMKHF PLLKJLADIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	AudioSource? IEFCFJPAPEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	NHOEKPEOKME? MGJJBDHIDJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	LIFLBGOOBJB? FKNNFDFGCFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string? CJGMDLCJEIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool EPMFIONJCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool ODLACGHCPNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool JMIHLFLKHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool JBGOHOGIKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool HNPEGFGGHFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool FGMEMKDDNCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool IIKGBKAICHK
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool LOKOLBNMPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool FDBOGPGHCDO
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool OFBFFIBIPON
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool ONMMPKLPPHP
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool PJFJGGBPCMM
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	decimal IDMGFFMLJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	GFJLLHFJBHN<bool> OOIAILLGNAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	LKKDMOCNJPN KIILHNMNBKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	KLPJLNGNINA<string, string> KJPNAEKADJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	LKKDMOCNJPN MHLHEHDDPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	LKKDMOCNJPN BHFDFEOBNCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	GFJLLHFJBHN<List<ToolDTO>> HHFICOEJHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	LKKDMOCNJPN ANJMEAEAIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	KLPJLNGNINA<float, string> PHEBHCNBKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	GFJLLHFJBHN<string> CGMJMBILCJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	string GLEFBMJLKLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool JDBMKJJLJHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task FACHHNALIEO(string MHDJEODIPGC, VoiceOption NGJOIEJKOAA, float EFJLFBADMGP = 0.6f, string ENNNFBGFOKO = "gpt-4o-mini-realtime-preview-2024-12-17", string GHILGCANDFL = "gpt-4o-mini-transcribe", [Optional] IReadOnlyCollection<string>? JHDKOBIJANB, [Optional] CancellationToken JHCOCAANJDL);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void LBEFNIAHEGL();

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task NFJKHIOIGNO(string MHDJEODIPGC, [Optional] CancellationToken JHCOCAANJDL);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task EMJCMDGANHO(float EFJLFBADMGP, [Optional] CancellationToken JHCOCAANJDL);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task FNAONBKJDGL(bool PMENEMBMEBK, [Optional] CancellationToken JHCOCAANJDL);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void DBACAICPHJI(params GEDGKMHBFFD[] HALDBIBMFCM);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool DADMANBENMM(GEDGKMHBFFD IFHJPMBJNDF);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void MKDAFOOOIOM(params GEDGKMHBFFD[] HALDBIBMFCM);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void EDCDFBNFDKF(HDJJBEMDFDP DANCOEFIHDF, bool FMPGMHEHDJF = false);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void NKJDLCPGMLL(HDJJBEMDFDP DANCOEFIHDF, bool FMPGMHEHDJF = false);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void GCMHBEDOGBK(HDJJBEMDFDP DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void KOICGKINDPN(HDJJBEMDFDP DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void APAAAKJIPJB(decimal BEAONNGPBDP, string PBHLPKLGFAP);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task MNGIJKHMBHL(string HLMEMBFCHLD, [Optional] string? PLOMKBLHOIE, [Optional] CancellationToken JHCOCAANJDL);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task JDFAKEJHGCH(string HLMEMBFCHLD, [Optional] string? PLOMKBLHOIE, [Optional] string? HOJDJIIPKJB, bool KNKPKNBLPKA = false, bool GCLFDFMAJKI = false, [Optional] CancellationToken JHCOCAANJDL);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task NJGDGKLECHA(string PLOMKBLHOIE, [Optional] CancellationToken JHCOCAANJDL);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<ResponseDTO> GKCJJFHGLLO(bool PHLLPPLOCIO = true, [Optional] CancellationToken JHCOCAANJDL);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<string> KFAAMDEHCLJ(string MHDJEODIPGC, [Optional] IReadOnlyList<ConversationItemDTO>? HNCIJLJMHHL, [Optional] CancellationToken JHCOCAANJDL);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<TOutput> KFAAMDEHCLJ<TOutput>(string MHDJEODIPGC, [Optional] IReadOnlyList<ConversationItemDTO>? HNCIJLJMHHL, [Optional] CancellationToken JHCOCAANJDL) where TOutput : class;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<List<ONKPEPCBDDF>> KFAAMDEHCLJ(string MHDJEODIPGC, IReadOnlyList<ConversationItemDTO>? HNCIJLJMHHL, IReadOnlyList<LFMKINFPHFJ> NNNMBEGGKLP, [Optional] CancellationToken JHCOCAANJDL);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool OJHBHCGIEAI(string BABCMIEBHAA);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool OMAFCJKIINE(string BABCMIEBHAA);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "49")]
	bool MHCOFLHECEN(string OIKLPDJLPPJ);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "50")]
	Task GGNCLLKNOBD(bool PKFPNLDDIBD, [Optional] CancellationToken JHCOCAANJDL);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "54")]
	IReadOnlyCollection<string> NMPLANEMCPN();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface PAGLIHLGBDP
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	BBJODKOKOBA? DAAHPJEFIEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	decimal IDMGFFMLJPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string GLEFBMJLKLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FKIGLHBJGGF(string? APLKCLBHHOJ, string OAOPBELJGGD, string GHILGCANDFL, float EFJLFBADMGP);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HIEPBKGNECL(string? APLKCLBHHOJ, ErrorEventDTO AKPHDFOCOBG);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OPACIDDLMLN(string? APLKCLBHHOJ, decimal BEAONNGPBDP, string PBHLPKLGFAP);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EGECPGANDAM(string? APLKCLBHHOJ, ConversationItemDTO BHNJKAEPJMN);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FOJHNIJELDP(string? APLKCLBHHOJ, ResponseEventDTO AKPHDFOCOBG, float? IDALCKPOKGC);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KKIOMKLEALF(string? APLKCLBHHOJ, ResponseEventDTO AKPHDFOCOBG);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GJJNJGHMAOL(string? APLKCLBHHOJ, string LENOHNAJDNM, string? MFCHFPLNKAD);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface DOLMLFOFDCA
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void LPENJHKGILF(ReadOnlySpan<float> MPFONBMLLDJ, int MLLNAMJEKJF, int PAJDKCOCDIA);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EGPIJGMLJLG(LPENJHKGILF PGCJAKGCANN);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKFBFKKJGHL(LPENJHKGILF PGCJAKGCANN);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class KEMJAFIIIFP
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private enum FMPHGHHOKIH
	{
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		array,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		boolean,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		@enum,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		integer,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		number,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		@object,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		@string
	}

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static ConcurrentDictionary<Type, JsonSchema> NLFIGJIDMPF;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static readonly Type[] DDACBIJFOAL;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly Type[] LAMLGCGOGNA;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3CFDBA0", Offset = "0x3CFC7A0", VA = "0x183CFDBA0")]
	public static JsonSchema LGFPFICEOKK<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7E44CE0", Offset = "0x7E438E0", VA = "0x187E44CE0")]
	public static JsonSchema FOKBEGEHDNH(IReadOnlyList<LFMKINFPHFJ> AHEPAEIEJIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7E45030", Offset = "0x7E43C30", VA = "0x187E45030")]
	private static JsonSchema GIIILLELDHO(Type MDCDODCGNEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7E444E0", Offset = "0x7E430E0", VA = "0x187E444E0")]
	private static JsonSchema AIFLLDJONMF(Type MDCDODCGNEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7E45480", Offset = "0x7E44080", VA = "0x187E45480")]
	private static FMPHGHHOKIH ICOLIBCNJNO(Type MDCDODCGNEK, [Out] Type? OAMNPKONCPO)
	{
		return default(FMPHGHHOKIH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7E44A70", Offset = "0x7E43670", VA = "0x187E44A70")]
	private static bool FAEBJAFHOBA(Type MDCDODCGNEK, [Out][MaybeNullWhen(false)] Type LDDADBFCAAP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class CDPDMMOCBBP : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct FIPPFAJNNHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public CDPDMMOCBBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TaskAwaiter<JEPCABOKLPN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7E40F00", Offset = "0x7E3FB00", VA = "0x187E40F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xAB3320", Offset = "0xAB1F20", VA = "0x180AB3320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct BNCAALBJBHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder<JEPCABOKLPN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public CDPDMMOCBBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private decimal <cost>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskAwaiter<JEPCABOKLPN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7E3D430", Offset = "0x7E3C030", VA = "0x187E3D430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7E3D860", Offset = "0x7E3C460", VA = "0x187E3D860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static readonly PEOHNMCPNIJ OJAPELLDHBE;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly TimeSpan EDKEHNBEMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly CancellationTokenSource HBLDJMCKLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly ANNBMFDCHKA CKEBICHIDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly GPLIMJALPFA DLMPCMMBKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly long LONDCKFKCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly long JHDKIKAAMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string IKKIEFFFAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private decimal PBLFJFCAAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Guid LLIMALAIFAA;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7E3DBE0", Offset = "0x7E3C7E0", VA = "0x187E3DBE0")]
	public CDPDMMOCBBP(ANNBMFDCHKA GLCHPGGOPEB, GPLIMJALPFA LPDELPLFMKC, string EKMBKAIBCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D9A0", Offset = "0x7E3C5A0", VA = "0x187E3D9A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D8D0", Offset = "0x7E3C4D0", VA = "0x187E3D8D0")]
	[AsyncStateMachine(typeof(FIPPFAJNNHI))]
	private void CBLLGFPBAHF(CancellationToken JHCOCAANJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7E3DA10", Offset = "0x7E3C610", VA = "0x187E3DA10")]
	[AsyncStateMachine(typeof(BNCAALBJBHL))]
	private Task<JEPCABOKLPN> JLPAFFAEPEF(CancellationToken JHCOCAANJDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class JPFMCKJNOOO : GEDGKMHBFFD, EGAPNKKDAEF
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate Task<string> OINLHCGCKHF(List<ONKPEPCBDDF> HPGHIMFEEID);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct CLINCGEMHAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string methodName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public JPFMCKJNOOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public string methodArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7E3DDE0", Offset = "0x7E3C9E0", VA = "0x187E3DDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7E3E480", Offset = "0x7E3D080", VA = "0x187E3E480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly string MNLKMFKOOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly string IBHCNAFIJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly IReadOnlyList<LFMKINFPHFJ> BLAGEJEOEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OINLHCGCKHF OJFJEBDFGKJ;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x107AF70", Offset = "0x1079B70", VA = "0x18107AF70")]
	public JPFMCKJNOOO(string BKILENEPEEB, string JKEAHMPNEHK, IReadOnlyList<LFMKINFPHFJ> AHEPAEIEJIO, OINLHCGCKHF NOMKKKJDNJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7E44210", Offset = "0x7E42E10", VA = "0x187E44210", Slot = "4")]
	private ToolDTO[] AACAJPHKHBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7E443A0", Offset = "0x7E42FA0", VA = "0x187E443A0", Slot = "5")]
	[AsyncStateMachine(typeof(CLINCGEMHAC))]
	private Task<string> EEPPMHODMGC(string IEFFJAPJBDG, string OGNGKONOKIH, CancellationToken JHCOCAANJDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class EOHMLHMJHKO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
	public EOHMLHMJHKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JCGDDKKFEAK : Exception, EMPDFHKKPAC
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string JNOPPOLMNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x56480A0", Offset = "0x5646CA0", VA = "0x1856480A0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7E43E90", Offset = "0x7E42A90", VA = "0x187E43E90")]
	public JCGDDKKFEAK(string FIOJCPGFMCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public abstract class ANNBMFDCHKA : DOEKOMHJPCL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private enum OINGOGJIGEF
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		NotConnected,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		Connected
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct AJOPPBFDMGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public ANNBMFDCHKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int? reconnectAttempt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private CancellationTokenSource <cts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private CancellationToken <originalCancellationToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IDisposable <combinedTokenDisposer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private string <instructions>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private float <temperature>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private TaskAwaiter<LEABLAPMKHF> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private TaskAwaiter<bool> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7E35050", Offset = "0x7E33C50", VA = "0x187E35050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7E37300", Offset = "0x7E35F00", VA = "0x187E37300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct PBFBIPDJOOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public ANNBMFDCHKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool keepConversationHistory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7E4D720", Offset = "0x7E4C320", VA = "0x187E4D720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7E4D930", Offset = "0x7E4C530", VA = "0x187E4D930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct NADNKECJLFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public ANNBMFDCHKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7E48E60", Offset = "0x7E47A60", VA = "0x187E48E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7E49010", Offset = "0x7E47C10", VA = "0x187E49010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct LOBLAJOKPOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public ANNBMFDCHKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public float temperature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7E48130", Offset = "0x7E46D30", VA = "0x187E48130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7E482D0", Offset = "0x7E46ED0", VA = "0x187E482D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct KICHGCDNBAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public ANNBMFDCHKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7E45C60", Offset = "0x7E44860", VA = "0x187E45C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7E45F60", Offset = "0x7E44B60", VA = "0x187E45F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct EJGLGAGBNMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public ANNBMFDCHKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public string conversationItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7E40400", Offset = "0x7E3F000", VA = "0x187E40400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7E40870", Offset = "0x7E3F470", VA = "0x187E40870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct DAKNHEGLNGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public ANNBMFDCHKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public string conversationItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public bool suppressFromConversationLog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public bool excludeFromConversationPruning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public string previousItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7E3E4F0", Offset = "0x7E3D0F0", VA = "0x187E3E4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7E3EA40", Offset = "0x7E3D640", VA = "0x187E3EA40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct BMLAIHEANKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ANNBMFDCHKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public string convresationItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7E3CEA0", Offset = "0x7E3BAA0", VA = "0x187E3CEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7E3D3D0", Offset = "0x7E3BFD0", VA = "0x187E3D3D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class ACOECNMKBEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public ResponseDTO response;

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public ACOECNMKBEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7E35020", Offset = "0x7E33C20", VA = "0x187E35020")]
		internal bool HFIHDPBCGPP(OutputAudioBufferEventDTO ev)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct BLAEDLBAIGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public AsyncTaskMethodBuilder<ResponseDTO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public ANNBMFDCHKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private ACOECNMKBEN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public bool waitForAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private TaskAwaiter<ResponseDTO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private TaskAwaiter<OutputAudioBufferEventDTO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7E3C600", Offset = "0x7E3B200", VA = "0x187E3C600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7E3CE30", Offset = "0x7E3BA30", VA = "0x187E3CE30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct BEKCGOLCCAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public ANNBMFDCHKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private TaskAwaiter<List<ConversationItemDTO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7E3BFA0", Offset = "0x7E3ABA0", VA = "0x187E3BFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7E3C550", Offset = "0x7E3B150", VA = "0x187E3C550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct FOHHPCGIMPP<TOutput> : IAsyncStateMachine where TOutput : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public AsyncTaskMethodBuilder<TOutput> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public ANNBMFDCHKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter<List<ConversationItemDTO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x4D82A20", Offset = "0x4D81620", VA = "0x184D82A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x4D83250", Offset = "0x4D81E50", VA = "0x184D83250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct EEDAJCKJFNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AsyncTaskMethodBuilder<List<ONKPEPCBDDF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public IReadOnlyList<LFMKINFPHFJ> responseArgSchemas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public ANNBMFDCHKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter<List<ConversationItemDTO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7E3F170", Offset = "0x7E3DD70", VA = "0x187E3F170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7E3F840", Offset = "0x7E3E440", VA = "0x187E3F840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class GIDGKHAGGPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public ANNBMFDCHKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public ResponseCreateEventDTO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public string id;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public GIDGKHAGGPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7E42630", Offset = "0x7E41230", VA = "0x187E42630")]
		internal void DPOFGMCLOEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7E42730", Offset = "0x7E41330", VA = "0x187E42730")]
		internal bool KNGIPCKOHJI(ResponseEventDTO ev)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct MAHFDLDLHMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public AsyncTaskMethodBuilder<List<ConversationItemDTO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public ANNBMFDCHKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public JsonSchema responseSchema;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private TaskAwaiter<ResponseEventDTO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7E48510", Offset = "0x7E47110", VA = "0x187E48510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7E48D80", Offset = "0x7E47980", VA = "0x187E48D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct PLLKILJBKCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public DateTime expirationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public ANNBMFDCHKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7E4E370", Offset = "0x7E4CF70", VA = "0x187E4E370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7E4E760", Offset = "0x7E4D360", VA = "0x187E4E760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct OOMKOKFDNPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public ANNBMFDCHKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private List<ToolDTO> <tools>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7E4D2A0", Offset = "0x7E4BEA0", VA = "0x187E4D2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7E4D6C0", Offset = "0x7E4C2C0", VA = "0x187E4D6C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct EPNABLCGJDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public ANNBMFDCHKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public ResponseEventDTO ev;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private string <responseId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7E409A0", Offset = "0x7E3F5A0", VA = "0x187E409A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xAB3320", Offset = "0xAB1F20", VA = "0x180AB3320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class NLFAHJGFPBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public ANNBMFDCHKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public NLFAHJGFPBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B740", Offset = "0x7E4A340", VA = "0x187E4B740")]
		internal Task NIAPIFAIJIJ(ConversationItemDTO outputItem)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct NCMIEOBONCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public ANNBMFDCHKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public ResponseDTO response;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private NLFAHJGFPBE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7E49070", Offset = "0x7E47C70", VA = "0x187E49070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7E49820", Offset = "0x7E48420", VA = "0x187E49820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct OLHDBFOLGPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public ConversationItemDTO item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public ANNBMFDCHKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7E4C050", Offset = "0x7E4AC50", VA = "0x187E4C050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7E4C460", Offset = "0x7E4B060", VA = "0x187E4C460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct DEODKIPBCKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public AsyncTaskMethodBuilder<ResponseDTO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public ANNBMFDCHKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private TaskAwaiter<ResponseDTO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7E3EAA0", Offset = "0x7E3D6A0", VA = "0x187E3EAA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7E3EE00", Offset = "0x7E3DA00", VA = "0x187E3EE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct PMBMMBLBALF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public AsyncTaskMethodBuilder<ResponseDTO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public ANNBMFDCHKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private CancellationToken <cancellationToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private DateTime? <startTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private TaskAwaiter<ResponseDTO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7E4E7C0", Offset = "0x7E4D3C0", VA = "0x187E4E7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7E4EFD0", Offset = "0x7E4DBD0", VA = "0x187E4EFD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly PEOHNMCPNIJ OJAPELLDHBE;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private const ToolChoice MNLFEAPLHAM = ToolChoice.Auto;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private const float EDKBLIBJDFM = 0.01f;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static readonly TimeSpan[] APCMJPPICPD;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static readonly TimeSpan BHMANLAJJHD;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private static readonly TimeSpan FKFDHMCANBH;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static readonly TimeSpan HAOEHCKCJOL;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static readonly TimeSpan MNILAFKLOEC;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static readonly TimeSpan MCOEFLJKAGM;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private const string PJICMEIKBLO = "out-of-band-id";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly LKFFIJHKCFD NADMBPMCFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly DOLMLFOFDCA JNCOBJEFJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected readonly GPLIMJALPFA DLMPCMMBKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly LIJNMIECNBL NGMAOECKLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly GPPIOPCLACN CGHIKFNADGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly GPPIOPCLACN KHJJBHEBGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Dictionary<string, DateTime> PLNEDFGAFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly PAGLIHLGBDP ALHEKAECGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly PHKLCIGAAAD? KHOFIHNOBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private string GNFDJAHPKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private VoiceOption OLFPBNABBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float BNEELNFMCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private string MIEPFKPDDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private string CDCLKNGFLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private OINGOGJIGEF JDOBKJHHNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private CancellationTokenSource? HBLDJMCKLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private LEABLAPMKHF? JNPIFKDEGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private GameObject? IGPDHAMJMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private AudioSource? HDIPAELKLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private AudioSourceSimpleLevelMeter? LDENMGKBAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private GLBIBLJGPIM? NMNANFCNMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NMEODMCOPMD? LKECCMMMMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private GBOHLAHNJPM? OOOEKPGPHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private LKINOAOEJON? HILNJEHGCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private IReadOnlyCollection<string> KCBGEIAKACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private DateTime? FPHOJEMCGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private Task<ResponseDTO>? FJFOLMBJBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private uint IPBCKLBMJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly HashSet<string> HILNLNHEHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly HashSet<string> NPCGBPOFDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly HashSet<string> KHNJGMCIMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private bool GPEFGMPGMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private HDJJBEMDFDP? JHKABOCOCDA;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public LEABLAPMKHF PLLKJLADIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7E38C70", Offset = "0x7E37870", VA = "0x187E38C70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string? CJGMDLCJEIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7E3A600", Offset = "0x7E39200", VA = "0x187E3A600", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public abstract bool EPMFIONJCIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public abstract bool ODLACGHCPNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract bool JMIHLFLKHEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	protected abstract bool DHJOMDGAJNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	protected abstract string? BHJFBIOPNKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	protected abstract string MGJINJGGIEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	protected abstract int PFBGNGGPPAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected abstract int IKACFBCAPHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected abstract EMPPHIOPPNL KFBKHKPCAKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected abstract string KBPCFLJCPEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	protected virtual bool NNCMMMBJFHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	protected TimeSpan HLLENHMLBAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xAC4E30", Offset = "0xAC3A30", VA = "0x180AC4E30")]
		[CompilerGenerated]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2642920", Offset = "0x2641520", VA = "0x182642920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool JBGOHOGIKFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7E39E60", Offset = "0x7E38A60", VA = "0x187E39E60", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool HNPEGFGGHFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7E38360", Offset = "0x7E36F60", VA = "0x187E38360", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool FGMEMKDDNCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7E39DD0", Offset = "0x7E389D0", VA = "0x187E39DD0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool IIKGBKAICHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xB06750", Offset = "0xB05350", VA = "0x180B06750", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xB65D50", Offset = "0xB64950", VA = "0x180B65D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool LOKOLBNMPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7E379D0", Offset = "0x7E365D0", VA = "0x187E379D0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool FDBOGPGHCDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7E37920", Offset = "0x7E36520", VA = "0x187E37920", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool OFBFFIBIPON
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xB6AE00", Offset = "0xB69A00", VA = "0x180B6AE00", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool ONMMPKLPPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7E37E20", Offset = "0x7E36A20", VA = "0x187E37E20", Slot = "19")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool PJFJGGBPCMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7E37AB0", Offset = "0x7E366B0", VA = "0x187E37AB0", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public decimal IDMGFFMLJPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7E37BE0", Offset = "0x7E367E0", VA = "0x187E37BE0", Slot = "21")]
		get
		{
			return default(decimal);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	private bool IKPNDOJDAOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7E3A8F0", Offset = "0x7E394F0", VA = "0x187E3A8F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	private bool JNENDMEMJIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7E37A10", Offset = "0x7E36610", VA = "0x187E37A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	private bool EFPLEBCCGPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7E383D0", Offset = "0x7E36FD0", VA = "0x187E383D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool JDBMKJJLJHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x209CB00", Offset = "0x209B700", VA = "0x18209CB00", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x209C630", Offset = "0x209B230", VA = "0x18209C630", Slot = "57")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	private uint BJLFFGHKKKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xAE6910", Offset = "0xAE5510", VA = "0x180AE6910")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7E3A650", Offset = "0x7E39250", VA = "0x187E3A650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public AudioSource? IEFCFJPAPEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA5EB20", Offset = "0xA5D720", VA = "0x180A5EB20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public NHOEKPEOKME? MGJJBDHIDJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA65BC0", Offset = "0xA647C0", VA = "0x180A65BC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public LIFLBGOOBJB? FKNNFDFGCFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xB0CA10", Offset = "0xB0B610", VA = "0x180B0CA10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public string GLEFBMJLKLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7E37A60", Offset = "0x7E36660", VA = "0x187E37A60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7E39270", Offset = "0x7E37E70", VA = "0x187E39270", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public GFJLLHFJBHN<bool> OOIAILLGNAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xB26310", Offset = "0xB24F10", VA = "0x180B26310", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public LKKDMOCNJPN KIILHNMNBKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xB25FC0", Offset = "0xB24BC0", VA = "0x180B25FC0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public KLPJLNGNINA<string, string> KJPNAEKADJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xBB7D90", Offset = "0xBB6990", VA = "0x180BB7D90", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GFJLLHFJBHN<List<ToolDTO>> HHFICOEJHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xBB7E40", Offset = "0xBB6A40", VA = "0x180BB7E40", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public LKKDMOCNJPN MHLHEHDDPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xBB96F0", Offset = "0xBB82F0", VA = "0x180BB96F0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public LKKDMOCNJPN BHFDFEOBNCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xBCA2C0", Offset = "0xBC8EC0", VA = "0x180BCA2C0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public LKKDMOCNJPN ANJMEAEAIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xBB7E70", Offset = "0xBB6A70", VA = "0x180BB7E70", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public KLPJLNGNINA<float, string> PHEBHCNBKCI
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xBB1CB0", Offset = "0xBB08B0", VA = "0x180BB1CB0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public GFJLLHFJBHN<string> CGMJMBILCJE
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xBB46A0", Offset = "0xBB32A0", VA = "0x180BB46A0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7E3B850", Offset = "0x7E3A450", VA = "0x187E3B850")]
	public ANNBMFDCHKA(LKFFIJHKCFD OJJOGCNFBIO, DOLMLFOFDCA LMEKEKGLLGF, GPLIMJALPFA LPDELPLFMKC, PAGLIHLGBDP IJPBAHDOAJC, [Optional] PHKLCIGAAAD? DKGPCIKILJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7E3B2B0", Offset = "0x7E39EB0", VA = "0x187E3B2B0")]
	private void PDPMJKPLJCC(GEDGKMHBFFD GPPOCCBIKEF, EGAPNKKDAEF? NOMKKKJDNJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7E38230", Offset = "0x7E36E30", VA = "0x187E38230", Slot = "31")]
	public Task FACHHNALIEO(string MHDJEODIPGC, VoiceOption NGJOIEJKOAA, float EFJLFBADMGP, string ENNNFBGFOKO, string GHILGCANDFL, [Optional] IReadOnlyCollection<string>? JHDKOBIJANB, [Optional] CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7E39330", Offset = "0x7E37F30", VA = "0x187E39330")]
	[AsyncStateMachine(typeof(AJOPPBFDMGL))]
	private Task KLGGPMNDEIM(int? MPIHOIEPJHC, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7E37CB0", Offset = "0x7E368B0", VA = "0x187E37CB0", Slot = "71")]
	protected virtual Task CheckAccess(CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7E3B5E0", Offset = "0x7E3A1E0", VA = "0x187E3B5E0", Slot = "72")]
	protected virtual Task<bool> UploadTranscriptsForModeration(CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7E39490", Offset = "0x7E38090", VA = "0x187E39490", Slot = "32")]
	public void LBEFNIAHEGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7E388E0", Offset = "0x7E374E0", VA = "0x187E388E0", Slot = "54")]
	[AsyncStateMachine(typeof(PBFBIPDJOOK))]
	public Task GGNCLLKNOBD(bool PKFPNLDDIBD, [Optional] CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7E37FF0", Offset = "0x7E36BF0", VA = "0x187E37FF0", Slot = "73")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7E3A6C0", Offset = "0x7E392C0", VA = "0x187E3A6C0", Slot = "33")]
	[AsyncStateMachine(typeof(NADNKECJLFI))]
	public Task NFJKHIOIGNO(string MHDJEODIPGC, [Optional] CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7E38120", Offset = "0x7E36D20", VA = "0x187E38120", Slot = "34")]
	[AsyncStateMachine(typeof(LOBLAJOKPOE))]
	public Task EMJCMDGANHO(float EFJLFBADMGP, [Optional] CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7E383E0", Offset = "0x7E36FE0", VA = "0x187E383E0", Slot = "35")]
	[AsyncStateMachine(typeof(KICHGCDNBAM))]
	public Task FNAONBKJDGL(bool PMENEMBMEBK, [Optional] CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7E37DA0", Offset = "0x7E369A0", VA = "0x187E37DA0", Slot = "36")]
	public void DBACAICPHJI(params GEDGKMHBFFD[] HALDBIBMFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7E37D40", Offset = "0x7E36940", VA = "0x187E37D40", Slot = "37")]
	public bool DADMANBENMM(GEDGKMHBFFD IFHJPMBJNDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7E3A350", Offset = "0x7E38F50", VA = "0x187E3A350", Slot = "38")]
	public void MKDAFOOOIOM(params GEDGKMHBFFD[] HALDBIBMFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7E380B0", Offset = "0x7E36CB0", VA = "0x187E380B0", Slot = "39")]
	public void EDCDFBNFDKF(HDJJBEMDFDP DANCOEFIHDF, bool FMPGMHEHDJF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7E3AA00", Offset = "0x7E39600", VA = "0x187E3AA00", Slot = "40")]
	public void NKJDLCPGMLL(HDJJBEMDFDP DANCOEFIHDF, bool FMPGMHEHDJF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7E38620", Offset = "0x7E37220", VA = "0x187E38620", Slot = "41")]
	public void GCMHBEDOGBK(HDJJBEMDFDP DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7E39450", Offset = "0x7E38050", VA = "0x187E39450", Slot = "42")]
	public void KOICGKINDPN(HDJJBEMDFDP DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7E3AA70", Offset = "0x7E39670", VA = "0x187E3AA70", Slot = "58")]
	public IReadOnlyCollection<string> NMPLANEMCPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7E37360", Offset = "0x7E35F60", VA = "0x187E37360", Slot = "43")]
	public void APAAAKJIPJB(decimal BEAONNGPBDP, string PBHLPKLGFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7E3A4C0", Offset = "0x7E390C0", VA = "0x187E3A4C0", Slot = "44")]
	[AsyncStateMachine(typeof(EJGLGAGBNMA))]
	public Task MNGIJKHMBHL(string HLMEMBFCHLD, string? PLOMKBLHOIE, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7E38DB0", Offset = "0x7E379B0", VA = "0x187E38DB0", Slot = "45")]
	[AsyncStateMachine(typeof(DAKNHEGLNGN))]
	public Task JDFAKEJHGCH(string HLMEMBFCHLD, string? PLOMKBLHOIE, string? HOJDJIIPKJB, bool KNKPKNBLPKA, bool GCLFDFMAJKI, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7E3A7D0", Offset = "0x7E393D0", VA = "0x187E3A7D0", Slot = "46")]
	[AsyncStateMachine(typeof(BMLAIHEANKA))]
	public Task NJGDGKLECHA(string BMACJMGBBGM, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7E3B1F0", Offset = "0x7E39DF0", VA = "0x187E3B1F0", Slot = "51")]
	public bool OJHBHCGIEAI(string BABCMIEBHAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7E3B250", Offset = "0x7E39E50", VA = "0x187E3B250", Slot = "52")]
	public bool OMAFCJKIINE(string BABCMIEBHAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7E3A2A0", Offset = "0x7E38EA0", VA = "0x187E3A2A0", Slot = "53")]
	public bool MHCOFLHECEN(string OIKLPDJLPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7E38B30", Offset = "0x7E37730", VA = "0x187E38B30", Slot = "47")]
	[AsyncStateMachine(typeof(BLAEDLBAIGD))]
	public Task<ResponseDTO> GKCJJFHGLLO(bool PHLLPPLOCIO = true, [Optional] CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7E39110", Offset = "0x7E37D10", VA = "0x187E39110", Slot = "48")]
	[AsyncStateMachine(typeof(BEKCGOLCCAB))]
	public Task<string> KFAAMDEHCLJ(string MHDJEODIPGC, [Optional] IReadOnlyList<ConversationItemDTO>? HNCIJLJMHHL, [Optional] CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3194DE0", Offset = "0x31939E0", VA = "0x183194DE0", Slot = "49")]
	[AsyncStateMachine(typeof(FOHHPCGIMPP<>))]
	public Task<TOutput> KFAAMDEHCLJ<TOutput>(string MHDJEODIPGC, [Optional] IReadOnlyList<ConversationItemDTO>? HNCIJLJMHHL, [Optional] CancellationToken JHCOCAANJDL) where TOutput : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7E38FA0", Offset = "0x7E37BA0", VA = "0x187E38FA0", Slot = "50")]
	[AsyncStateMachine(typeof(EEDAJCKJFNA))]
	public Task<List<ONKPEPCBDDF>> KFAAMDEHCLJ(string MHDJEODIPGC, IReadOnlyList<ConversationItemDTO>? HNCIJLJMHHL, IReadOnlyList<LFMKINFPHFJ> NNNMBEGGKLP, [Optional] CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7E377B0", Offset = "0x7E363B0", VA = "0x187E377B0")]
	[AsyncStateMachine(typeof(MAHFDLDLHMB))]
	private Task<List<ConversationItemDTO>> BJDDBLBMAKP(string MHDJEODIPGC, IReadOnlyList<ConversationItemDTO>? HNCIJLJMHHL, JsonSchema? LFIIKNGPNHJ, [Optional] CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7E39CC0", Offset = "0x7E388C0", VA = "0x187E39CC0")]
	[AsyncStateMachine(typeof(PLLKILJBKCB))]
	private Task LBJHEJCDFME(DateTime JGPMAJBAGBJ, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7E3A050", Offset = "0x7E38C50", VA = "0x187E3A050")]
	private bool LPHDBJLIMDD(ResponseDTO FLHCCHCJDKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7E38D10", Offset = "0x7E37910", VA = "0x187E38D10")]
	private void HGIMPFNHHMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7E38660", Offset = "0x7E37260", VA = "0x187E38660")]
	private void GDCNBNKABKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x7E3A3D0", Offset = "0x7E38FD0", VA = "0x187E3A3D0")]
	[AsyncStateMachine(typeof(OOMKOKFDNPH))]
	private Task MLAHCJNGBKM([Optional] CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x7E376C0", Offset = "0x7E362C0", VA = "0x187E376C0")]
	private void BHLMJGIKGPL(ReadOnlySpan<float> MPFONBMLLDJ, int MLLNAMJEKJF, int PAJDKCOCDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x7E38820", Offset = "0x7E37420", VA = "0x187E38820")]
	private void GECNNPKCOGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7E39E70", Offset = "0x7E38A70", VA = "0x187E39E70")]
	[AsyncStateMachine(typeof(EPNABLCGJDH))]
	private void LGHILKFHNBJ(ResponseEventDTO AKPHDFOCOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7E37E70", Offset = "0x7E36A70", VA = "0x187E37E70")]
	private void DEHBKIKCCLM(ConversationItemDTO BHNJKAEPJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7E3AAD0", Offset = "0x7E396D0", VA = "0x187E3AAD0")]
	private void OIDBAJALPPH(ResponseEventDTO AKPHDFOCOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7E389F0", Offset = "0x7E375F0", VA = "0x187E389F0")]
	private void GHDHDOCMJPN(string OAOPBELJGGD, string GHILGCANDFL, float EFJLFBADMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7E38700", Offset = "0x7E37300", VA = "0x187E38700")]
	[AsyncStateMachine(typeof(NCMIEOBONCE))]
	private Task GDMHPCOLGND(ResponseDTO FLHCCHCJDKE, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7E39F40", Offset = "0x7E38B40", VA = "0x187E39F40")]
	[AsyncStateMachine(typeof(OLHDBFOLGPF))]
	private Task LLOPIFGFKKK(ConversationItemDTO BHNJKAEPJMN, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7E375B0", Offset = "0x7E361B0", VA = "0x187E375B0")]
	[AsyncStateMachine(typeof(DEODKIPBCKI))]
	private Task<ResponseDTO> BGLLKJNIPAL(CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7E37AD0", Offset = "0x7E366D0", VA = "0x187E37AD0")]
	[AsyncStateMachine(typeof(PMBMMBLBALF))]
	private Task<ResponseDTO> CICLDCJOIAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7E374A0", Offset = "0x7E360A0", VA = "0x187E374A0")]
	private void BCGDHKNEGDC(ErrorEventDTO AKPHDFOCOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7E3A320", Offset = "0x7E38F20", VA = "0x187E3A320")]
	private void MHCPBKNMAAP(InputAudioBufferSpeechStartedEventDTO HPNKJCMLGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7E382D0", Offset = "0x7E36ED0", VA = "0x187E382D0")]
	private void FBKEKLPDIGO(InputAudioBufferSpeechStoppedEventDTO HPNKJCMLGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7E384F0", Offset = "0x7E370F0", VA = "0x187E384F0")]
	protected void GBBKDLKGNPF(string LENOHNAJDNM, [Optional] string? MFCHFPLNKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7E37F80", Offset = "0x7E36B80", VA = "0x187E37F80")]
	private bool DFKMBLJEKGH(ResponseDTO FLHCCHCJDKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7E38F00", Offset = "0x7E37B00", VA = "0x187E38F00")]
	protected void KEMNOAOJJCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7E379D0", Offset = "0x7E365D0", VA = "0x187E379D0")]
	[CompilerGenerated]
	private bool LFHEPPEMDHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7E37970", Offset = "0x7E36570", VA = "0x187E37970")]
	[CompilerGenerated]
	private bool CCEMNNHELBH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
public class OPELFLOIFHG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
	public OPELFLOIFHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface LCGIOCMMNOK
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CAOCDLCCOPC(GEDGKMHBFFD IFHJPMBJNDF, [Out] EGAPNKKDAEF NOMKKKJDNJF);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class EHEJAGOGFIM
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private class JDNBKKPCKKP
	{
		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public PropertyInfo CKNEDMBLDCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public Type ONIENPDOKKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x70C19F0", Offset = "0x70C05F0", VA = "0x1870C19F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public string PHADHDHLAMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool BOHGEIOFENE
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A350", VA = "0x180A5B750")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public Type? LBDKAEEKMGD
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xA5B5E0", Offset = "0xA5A1E0", VA = "0x180A5B5E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7E43F60", Offset = "0x7E42B60", VA = "0x187E43F60")]
		public JDNBKKPCKKP(PropertyInfo KCBLFAPDPHO, JsonPropertyAttribute? BLHADKFLKNK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly ConcurrentDictionary<Type, List<JDNBKKPCKKP>> GPNMKJCGMNL;

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F8B0", Offset = "0x7E3E4B0", VA = "0x187E3F8B0")]
	public static List<string> BAOAAHNFJAB(string EAEEONELOOJ, Type PMNKPAONFLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FD60", Offset = "0x7E3E960", VA = "0x187E3FD60")]
	private static void LJELHMOPFAF(Type MDCDODCGNEK, JObject KAHAMEFAGIO, List<string> OJGDNGDIMAI, string MGOLMCDKFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA50", Offset = "0x7E3E650", VA = "0x187E3FA50")]
	private static List<JDNBKKPCKKP> EPEFIAOBBHB(Type MDCDODCGNEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F9A0", Offset = "0x7E3E5A0", VA = "0x187E3F9A0")]
	private static bool EONGDPPMJCL(Type MDCDODCGNEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public EHEJAGOGFIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal class GBOHLAHNJPM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class LPKKCPPFJKB
	{
		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public string? EFNCKHLNDKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xA5B460", Offset = "0xA5A060", VA = "0x180A5B460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public int BJFMGOKILHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA5EBA0", Offset = "0xA5D7A0", VA = "0x180A5EBA0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA5FCA0", Offset = "0xA5E8A0", VA = "0x180A5FCA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int IEMNKMKDGAL
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA85600", Offset = "0xA84200", VA = "0x180A85600")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xE7F020", Offset = "0xE7DC20", VA = "0x180E7F020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7E483E0", Offset = "0x7E46FE0", VA = "0x187E483E0")]
		public LPKKCPPFJKB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private class MIEGEGCOLPK
	{
		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public string CKHNJNJFACM
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xA5B460", Offset = "0xA5A060", VA = "0x180A5B460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public ConversationItemType GJCIAOMMHGH
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xA5EBA0", Offset = "0xA5D7A0", VA = "0x180A5EBA0")]
			[CompilerGenerated]
			get
			{
				return default(ConversationItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xA5FCA0", Offset = "0xA5E8A0", VA = "0x180A5FCA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public string? AMIJGPLBMLF
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xA5C7A0", Offset = "0xA5B3A0", VA = "0x180A5C7A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public string? FEGHCLOCPPH
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xA5B5E0", Offset = "0xA5A1E0", VA = "0x180A5B5E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xA683D0", Offset = "0xA66FD0", VA = "0x180A683D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7E48DF0", Offset = "0x7E479F0", VA = "0x187E48DF0")]
		public MIEGEGCOLPK(ConversationItemDTO BHNJKAEPJMN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class JIOIMHMLGPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public IEnumerable<string> functionNames;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public JIOIMHMLGPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7E44100", Offset = "0x7E42D00", VA = "0x187E44100")]
		internal bool KBJAALLBHNK(MIEGEGCOLPK c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class LDKMBCCJCFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public MIEGEGCOLPK c;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public LDKMBCCJCFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7E460C0", Offset = "0x7E44CC0", VA = "0x187E460C0")]
		internal bool EDDBGFNMJCF(string n)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class DGAIAJOICGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public ConversationItemDTO item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public GBOHLAHNJPM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public DGAIAJOICGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7E3F090", Offset = "0x7E3DC90", VA = "0x187E3F090")]
		internal bool LMPAIHKIONP(string n)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7E3F0D0", Offset = "0x7E3DCD0", VA = "0x187E3F0D0")]
		internal bool PGHNDFFFCKF(MIEGEGCOLPK c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7E3EE70", Offset = "0x7E3DA70", VA = "0x187E3EE70")]
		internal void HHJEAOKCNLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class HOHLLCKCOHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public IEnumerable<string?> callIdsToRemove;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public HOHLLCKCOHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7E43E20", Offset = "0x7E42A20", VA = "0x187E43E20")]
		internal bool MGLFOGEALKN(MIEGEGCOLPK c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class LJJPBGJCIDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public IEnumerable<string> idsToRemove;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public LJJPBGJCIDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7E47B00", Offset = "0x7E46700", VA = "0x187E47B00")]
		internal bool OLJPEFOFAAB(MIEGEGCOLPK c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class JDLAPIKPPHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public Queue<string> queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public Func<bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public JDLAPIKPPHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7E43F10", Offset = "0x7E42B10", VA = "0x187E43F10")]
		internal bool OJCFJGDPKIP()
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct LLEIAIKNIEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public Queue<string> queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private JDLAPIKPPHC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public GBOHLAHNJPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7E47B60", Offset = "0x7E46760", VA = "0x187E47B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7E480D0", Offset = "0x7E46CD0", VA = "0x187E480D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly DOEKOMHJPCL CKEBICHIDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly NHOEKPEOKME NMNANFCNMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly HashSet<string> HAHBJOIFIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly LPKKCPPFJKB JKOBGGCGBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly List<MIEGEGCOLPK> KCBGEIAKACF;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static Queue<string> IMOAKEIKMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly CancellationTokenSource EHPLIDLPENO;

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x7E42120", Offset = "0x7E40D20", VA = "0x187E42120")]
	public GBOHLAHNJPM(DOEKOMHJPCL GLCHPGGOPEB, NHOEKPEOKME EMDEKJGELDK, LPKKCPPFJKB ENJHAFMCLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x7E41930", Offset = "0x7E40530", VA = "0x187E41930", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7E41A10", Offset = "0x7E40610", VA = "0x187E41A10")]
	public void LCLKCEKAOPC(IEnumerable<string> BJNLDBMDCGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7E41430", Offset = "0x7E40030", VA = "0x187E41430")]
	private void DEHBKIKCCLM(ConversationItemDTO BHNJKAEPJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7E41C00", Offset = "0x7E40800", VA = "0x187E41C00")]
	private void LJPFAHPMPBH(IEnumerable<string?> BAGOCHJCDKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7E41810", Offset = "0x7E40410", VA = "0x187E41810")]
	[AsyncStateMachine(typeof(LLEIAIKNIEG))]
	private Task DIKMLNPIPKM(Queue<string> OCCBFNHIGDM, CancellationToken JHCOCAANJDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal class GLBIBLJGPIM : NHOEKPEOKME, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal class AKCPPHKENGG
	{
		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public ConversationItemDTO KLGHGIBKAEH
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xA5B460", Offset = "0xA5A060", VA = "0x180A5B460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public bool GFCNOALBIKD
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xAB4C80", Offset = "0xAB3880", VA = "0x180AB4C80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0xA61310", Offset = "0xA5FF10", VA = "0x180A61310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x154BFE0", Offset = "0x154ABE0", VA = "0x18154BFE0")]
		public AKCPPHKENGG(ConversationItemDTO BHNJKAEPJMN, bool HJFNMIOINJB = false)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class ECLGGKJGJKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public ConversationItemCreatedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public ECLGGKJGJKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7E3F120", Offset = "0x7E3DD20", VA = "0x187E3F120")]
		internal bool MILHEOBELAN(AKCPPHKENGG c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7E3C5C0", Offset = "0x7E3B1C0", VA = "0x187E3C5C0")]
		internal bool JAGKMNMKJNF(AKCPPHKENGG c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class LAPCLLMDCMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public ConversationItemDTO conversationItem;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public LAPCLLMDCMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7E46080", Offset = "0x7E44C80", VA = "0x187E46080")]
		internal bool EDGPHFMFDEK(AKCPPHKENGG c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class BKBENANGCDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public ConversationItemInputAudioTranscriptionCompletedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public BKBENANGCDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7E3C5C0", Offset = "0x7E3B1C0", VA = "0x187E3C5C0")]
		internal bool IHAPINIFCGK(AKCPPHKENGG c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class ACKDKHCCOEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public ConversationItemDTO item;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public ACKDKHCCOEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7E34FD0", Offset = "0x7E33BD0", VA = "0x187E34FD0")]
		internal bool BFBMPFFJCJE(AKCPPHKENGG c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class PEIOLONDKGP : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private string <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private ConversationItemDTO item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public ConversationItemDTO <>3__item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public GLBIBLJGPIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private ACKDKHCCOEF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private List<ConversationItemContentDTO>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		string IEnumerator<string>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xF91620", Offset = "0xF90220", VA = "0x180F91620")]
		[DebuggerHidden]
		public PEIOLONDKGP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7E4E2E0", Offset = "0x7E4CEE0", VA = "0x187E4E2E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7E4D9E0", Offset = "0x7E4C5E0", VA = "0x187E4D9E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7E4D990", Offset = "0x7E4C590", VA = "0x187E4D990")]
		private void BOPPOGEKEOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7E4E290", Offset = "0x7E4CE90", VA = "0x187E4E290", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7E4E1D0", Offset = "0x7E4CDD0", VA = "0x187E4E1D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7E4E1D0", Offset = "0x7E4CDD0", VA = "0x187E4E1D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class LDKDCLNDFNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public string messageId;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public LDKDCLNDFNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x21403A0", Offset = "0x213EFA0", VA = "0x1821403A0")]
		internal bool GHEHEPKEKML(ConversationItemDTO m)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly ANNBMFDCHKA CKEBICHIDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private readonly LEABLAPMKHF JNPIFKDEGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly HDJJBEMDFDP GPGOOACFMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly List<AKCPPHKENGG> KNHBFDCMHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly List<string> KCBGEIAKACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly List<ConversationItemDTO> HLJDGIIHPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private string? HIPMHAEJEJA;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public GFJLLHFJBHN<ConversationItemDTO> DEHBKIKCCLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA5B690", Offset = "0xA5A290", VA = "0x180A5B690", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public IReadOnlyList<string> GNLGBNIPIHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5A0", Offset = "0xA5A1A0", VA = "0x180A5B5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public IReadOnlyList<ConversationItemDTO> PLCHCECHHPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA5B560", Offset = "0xA5A160", VA = "0x180A5B560", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x7E43950", Offset = "0x7E42550", VA = "0x187E43950")]
	public GLBIBLJGPIM(ANNBMFDCHKA GLCHPGGOPEB, IReadOnlyCollection<string> LOALLKPDMGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x7E42E70", Offset = "0x7E41A70", VA = "0x187E42E70", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x7E434B0", Offset = "0x7E420B0", VA = "0x187E434B0")]
	public List<string> NMPLANEMCPN(bool FFOFIDKKHPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x7E42980", Offset = "0x7E41580", VA = "0x187E42980")]
	private void DNGDLBNBALC(ConversationItemCreatedEventDTO AKPHDFOCOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7E436A0", Offset = "0x7E422A0", VA = "0x187E436A0")]
	private void OIDBAJALPPH(ResponseEventDTO AKPHDFOCOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7E427C0", Offset = "0x7E413C0", VA = "0x187E427C0")]
	private void BMDBNFNEKAF(ConversationItemInputAudioTranscriptionCompletedEventDTO AKPHDFOCOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7E43190", Offset = "0x7E41D90", VA = "0x187E43190")]
	private void IOHAIOFIBJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7E430F0", Offset = "0x7E41CF0", VA = "0x187E430F0", Slot = "6")]
	[IteratorStateMachine(typeof(PEIOLONDKGP))]
	public IEnumerable<string> HEHNCHJBALJ(ConversationItemDTO BHNJKAEPJMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7E433D0", Offset = "0x7E41FD0", VA = "0x187E433D0", Slot = "7")]
	public void NJGDGKLECHA(string BABCMIEBHAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal class NMEODMCOPMD : LIFLBGOOBJB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct OCNDFKKEEAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public IReadOnlyCollection<string> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public NMEODMCOPMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x7E4BA00", Offset = "0x7E4A600", VA = "0x187E4BA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x7E4BFF0", Offset = "0x7E4ABF0", VA = "0x187E4BFF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly ANNBMFDCHKA CKEBICHIDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly string PEBAPMAGKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly int FDFOMNMPMCB;

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x5DA6620", Offset = "0x5DA5220", VA = "0x185DA6620")]
	public NMEODMCOPMD(ANNBMFDCHKA GLCHPGGOPEB, string OELCBHOJPGG, int HCABDCMDCJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7E4B860", Offset = "0x7E4A460", VA = "0x187E4B860", Slot = "4")]
	[AsyncStateMachine(typeof(OCNDFKKEEAH))]
	public Task LCHKJPIIHCP(IReadOnlyCollection<string> HNCIJLJMHHL, CancellationToken JHCOCAANJDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class EOHDAEOHAFB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Type MKHNENJDMKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xAC01F0", Offset = "0xABEDF0", VA = "0x180AC01F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public string MDJNNFBMLKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xA5EB20", Offset = "0xA5D720", VA = "0x180A5EB20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7E408D0", Offset = "0x7E3F4D0", VA = "0x187E408D0")]
	public EOHDAEOHAFB(Type JIIMJAJFHEA, string EAEEONELOOJ, Exception BOEANKIKAPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class LIJNMIECNBL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct HKLBHFOJDPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public string args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public LIJNMIECNBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private Dictionary<GEDGKMHBFFD, EGAPNKKDAEF?>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private TaskAwaiter<string?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x7E4FA90", Offset = "0x7E4E690", VA = "0x187E4FA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7E50560", Offset = "0x7E4F160", VA = "0x187E50560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private static readonly PEOHNMCPNIJ OJAPELLDHBE;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static readonly List<LCGIOCMMNOK> JKEKJBBCHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly Dictionary<GEDGKMHBFFD, EGAPNKKDAEF?> JBMECEPLCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly KLPJLNGNINA<GEDGKMHBFFD, EGAPNKKDAEF?> PDPMJKPLJCC;

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7E476E0", Offset = "0x7E462E0", VA = "0x187E476E0")]
	static LIJNMIECNBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7E46A50", Offset = "0x7E45650", VA = "0x187E46A50")]
	public void DBACAICPHJI(params GEDGKMHBFFD[] HALDBIBMFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7E469F0", Offset = "0x7E455F0", VA = "0x187E469F0")]
	public bool DADMANBENMM(GEDGKMHBFFD IFHJPMBJNDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7E47330", Offset = "0x7E45F30", VA = "0x187E47330")]
	public void MKDAFOOOIOM(params GEDGKMHBFFD[] HALDBIBMFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7E47650", Offset = "0x7E46250", VA = "0x187E47650")]
	public void PBPHEPENLPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7E471D0", Offset = "0x7E45DD0", VA = "0x187E471D0")]
	[AsyncStateMachine(typeof(HKLBHFOJDPK))]
	public Task<string> LLOPIFGFKKK(string BKILENEPEEB, string AHEPAEIEJIO, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7E46FE0", Offset = "0x7E45BE0", VA = "0x187E46FE0")]
	public List<ToolDTO> KDDPCDJJIGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7E46D10", Offset = "0x7E45910", VA = "0x187E46D10")]
	private static EGAPNKKDAEF DGMCIEOLCHP(GEDGKMHBFFD IFHJPMBJNDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7E47A20", Offset = "0x7E46620", VA = "0x187E47A20")]
	public LIJNMIECNBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class EODLOBCNOHL
{
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public static JsonSerializerSettings JNJLIBOFNCJ;

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7E4F840", Offset = "0x7E4E440", VA = "0x187E4F840")]
	static EODLOBCNOHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class LKINOAOEJON : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private class NDKCICAALAI
	{
		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public ConversationItemDTO KLGHGIBKAEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xA5B460", Offset = "0xA5A060", VA = "0x180A5B460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool GFCNOALBIKD
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0xAB4C80", Offset = "0xAB3880", VA = "0x180AB4C80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0xA61310", Offset = "0xA5FF10", VA = "0x180A61310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x154BFE0", Offset = "0x154ABE0", VA = "0x18154BFE0")]
		public NDKCICAALAI(ConversationItemDTO BHNJKAEPJMN, bool HJFNMIOINJB = false)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	private abstract class LEAGFHEPNNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly StringBuilder HGAPPCKDFFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly TimeSpan CMIPBCCPODB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private DateTime JMDJKHGGPMN;

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7E50AF0", Offset = "0x7E4F6F0", VA = "0x187E50AF0")]
		public LEAGFHEPNNF(TimeSpan ALNADHDEMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7E50960", Offset = "0x7E4F560", VA = "0x187E50960")]
		public void EGHLDEFCOLL(string HPDLADMCCPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7E509B0", Offset = "0x7E4F5B0", VA = "0x187E509B0")]
		public void NHFBHENGOFH(bool GPAPPOJDLEG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void JMEJEMNIIMB(string BCBLEPPKJPP);
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private class PBGEBDLBEPB : LEAGFHEPNNF
	{
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private static readonly TimeSpan KOALEHCCJFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly string MEHDLOMHNPM;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7E52A30", Offset = "0x7E51630", VA = "0x187E52A30")]
		public PBGEBDLBEPB(string HFMDAFKADOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7E52950", Offset = "0x7E51550", VA = "0x187E52950", Slot = "4")]
		protected override void JMEJEMNIIMB(string BCBLEPPKJPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private class NFOBCIOEKBA : LEAGFHEPNNF
	{
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private static readonly TimeSpan KOALEHCCJFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private readonly GPLIMJALPFA DLMPCMMBKOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private readonly string NBGBNIMDLFO;

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7E528B0", Offset = "0x7E514B0", VA = "0x187E528B0")]
		public NFOBCIOEKBA(GPLIMJALPFA LPDELPLFMKC, string APLKCLBHHOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x7E52720", Offset = "0x7E51320", VA = "0x187E52720", Slot = "4")]
		protected override void JMEJEMNIIMB(string BCBLEPPKJPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private class JDHMNFBGMPF : LEAGFHEPNNF
	{
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private static readonly TimeSpan KOALEHCCJFL;

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x7E50900", Offset = "0x7E4F500", VA = "0x187E50900")]
		public JDHMNFBGMPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7E50810", Offset = "0x7E4F410", VA = "0x187E50810", Slot = "4")]
		protected override void JMEJEMNIIMB(string BCBLEPPKJPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class GHEODIFHEKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public ConversationItemCreatedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public GHEODIFHEKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7E3C5C0", Offset = "0x7E3B1C0", VA = "0x187E3C5C0")]
		internal bool MILHEOBELAN(NDKCICAALAI c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class GPGKDIAFFKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public ConversationItemDTO conversationItem;

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public GPGKDIAFFKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7E46080", Offset = "0x7E44C80", VA = "0x187E46080")]
		internal bool EDGPHFMFDEK(NDKCICAALAI c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class NIJEECBMMNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public ConversationItemInputAudioTranscriptionCompletedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public NIJEECBMMNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x7E3C5C0", Offset = "0x7E3B1C0", VA = "0x187E3C5C0")]
		internal bool IHAPINIFCGK(NDKCICAALAI c)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct IPOOOEMNKFJ : IAsyncStateMachine
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
		public LKINOAOEJON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x7E505D0", Offset = "0x7E4F1D0", VA = "0x187E505D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x7E507B0", Offset = "0x7E4F3B0", VA = "0x187E507B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private static readonly TimeSpan KOALEHCCJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly ANNBMFDCHKA CKEBICHIDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly LEABLAPMKHF JNPIFKDEGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly GPLIMJALPFA DLMPCMMBKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly HDJJBEMDFDP GPGOOACFMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly List<LEAGFHEPNNF> JNJGOJCKKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly List<NDKCICAALAI> KNHBFDCMHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private string? HIPMHAEJEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private CancellationTokenSource? KECLILCDLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private Task? KHMAHPDCINI;

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7E51F70", Offset = "0x7E50B70", VA = "0x187E51F70")]
	public LKINOAOEJON(ANNBMFDCHKA GLCHPGGOPEB, GPLIMJALPFA LPDELPLFMKC, bool OEPHOFGAJJJ, bool IEBKBGFGNIN, string? IJEGEGMIHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7E512F0", Offset = "0x7E4FEF0", VA = "0x187E512F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7E50E80", Offset = "0x7E4FA80", VA = "0x187E50E80")]
	private void DNGDLBNBALC(ConversationItemCreatedEventDTO AKPHDFOCOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7E519C0", Offset = "0x7E505C0", VA = "0x187E519C0")]
	private void OIDBAJALPPH(ResponseEventDTO AKPHDFOCOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7E50CC0", Offset = "0x7E4F8C0", VA = "0x187E50CC0")]
	private void BMDBNFNEKAF(ConversationItemInputAudioTranscriptionCompletedEventDTO AKPHDFOCOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7E517B0", Offset = "0x7E503B0", VA = "0x187E517B0")]
	private void KPEFOKLDHBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7E51C70", Offset = "0x7E50870", VA = "0x187E51C70")]
	private void POLDOHMBJBO(ConversationItemDTO BHNJKAEPJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7E51600", Offset = "0x7E50200", VA = "0x187E51600")]
	private void EGHLDEFCOLL(string HPDLADMCCPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7E518D0", Offset = "0x7E504D0", VA = "0x187E518D0")]
	[AsyncStateMachine(typeof(IPOOOEMNKFJ))]
	private Task MMOFCGKKEEA(CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7E50BA0", Offset = "0x7E4F7A0", VA = "0x187E50BA0")]
	private void AJEMBAJIBCI(bool GPAPPOJDLEG = false)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class MBCOCJPKMMG
{
	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public MBCOCJPKMMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x72D6160", Offset = "0x72D4D60", VA = "0x1872D6160")]
	public static string LPPJLLMHBCD(byte[] CHJDNJBAAFA, byte[] MIBBFFFNMGG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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

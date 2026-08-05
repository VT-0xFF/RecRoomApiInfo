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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EBAC40", Offset = "0x7EB9C40", VA = "0x187EBAC40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA8B7C0", Offset = "0xA8A7C0", VA = "0x180A8B7C0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA8B800", Offset = "0xA8A800", VA = "0x180A8B800")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_AI_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : AOMECLICLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7EB7150", Offset = "0x7EB6150", VA = "0x187EB7150", Slot = "4")]
		public override void AMNFOKHCMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum FMCBMOPHMDE
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
public class MOJPLFJNOMI : IEquatable<MOJPLFJNOMI>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Type HENDJOPJCBH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7EB8520", Offset = "0x7EB7520", VA = "0x187EB8520", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FMCBMOPHMDE HHDOJPCILPE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(FMCBMOPHMDE);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string FMJEMOMMPEK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool NKIAAOCDLDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xC333C0", Offset = "0xC323C0", VA = "0x180C333C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xBB3410", Offset = "0xBB2410", VA = "0x180BB3410")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7EB8DC0", Offset = "0x7EB7DC0", VA = "0x187EB8DC0")]
	public MOJPLFJNOMI(FMCBMOPHMDE HHDOJPCILPE, string GHLJANJDNGM, string FMJEMOMMPEK = "", bool NKIAAOCDLDK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7EB8C50", Offset = "0x7EB7C50", VA = "0x187EB8C50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7EB89D0", Offset = "0x7EB79D0", VA = "0x187EB89D0", Slot = "6")]
	protected virtual bool JOGJFECJHFK(StringBuilder FJCCOAKCNIN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1204BD0", Offset = "0x1203BD0", VA = "0x181204BD0")]
	public static bool BDCEBPMLGHE(MOJPLFJNOMI? MACAGNGMFOK, MOJPLFJNOMI? IHEPOLKBHPP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x12050A0", Offset = "0x12040A0", VA = "0x1812050A0")]
	public static bool PHGIAKEDBEK(MOJPLFJNOMI? MACAGNGMFOK, MOJPLFJNOMI? IHEPOLKBHPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7EB87D0", Offset = "0x7EB77D0", VA = "0x187EB87D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7EB8580", Offset = "0x7EB7580", VA = "0x187EB8580", Slot = "0")]
	public override bool Equals(object? PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7EB8610", Offset = "0x7EB7610", VA = "0x187EB8610", Slot = "7")]
	public virtual bool Equals(MOJPLFJNOMI? EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7EB8BC0", Offset = "0x7EB7BC0", VA = "0x187EB8BC0", Slot = "8")]
	public virtual MOJPLFJNOMI LCLCDINMEDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7EB8D60", Offset = "0x7EB7D60", VA = "0x187EB8D60")]
	protected MOJPLFJNOMI(MOJPLFJNOMI NKCMILOENIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7EB8980", Offset = "0x7EB7980", VA = "0x187EB8980")]
	public void HBLCGHBNJLA([Out] FMCBMOPHMDE HHDOJPCILPE, [Out] string GHLJANJDNGM, [Out] string FMJEMOMMPEK, [Out] bool NKIAAOCDLDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class IHFOFKMOKKK : IEquatable<IHFOFKMOKKK>
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	protected virtual Type HENDJOPJCBH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7EB3F00", Offset = "0x7EB2F00", VA = "0x187EB3F00", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public JToken PGBJGODECMH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public MOJPLFJNOMI FEEEMMJLJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1206060", Offset = "0x1205060", VA = "0x181206060")]
	public IHFOFKMOKKK(JToken PGBJGODECMH, MOJPLFJNOMI FEEEMMJLJHL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7EB4050", Offset = "0x7EB3050", VA = "0x187EB4050")]
	public static int EKEDNCKHCND(IHFOFKMOKKK IOALKPFEKEK)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7EB4610", Offset = "0x7EB3610", VA = "0x187EB4610")]
	public static float EKEDNCKHCND(IHFOFKMOKKK IOALKPFEKEK)
	{
		return default(float);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7EB4110", Offset = "0x7EB3110", VA = "0x187EB4110")]
	public static bool EKEDNCKHCND(IHFOFKMOKKK IOALKPFEKEK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7EB3F60", Offset = "0x7EB2F60", VA = "0x187EB3F60")]
	public static string EKEDNCKHCND(IHFOFKMOKKK IOALKPFEKEK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7EB43F0", Offset = "0x7EB33F0", VA = "0x187EB43F0")]
	public static int[] EKEDNCKHCND(IHFOFKMOKKK IOALKPFEKEK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7EB42E0", Offset = "0x7EB32E0", VA = "0x187EB42E0")]
	public static float[] EKEDNCKHCND(IHFOFKMOKKK IOALKPFEKEK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7EB4500", Offset = "0x7EB3500", VA = "0x187EB4500")]
	public static bool[] EKEDNCKHCND(IHFOFKMOKKK IOALKPFEKEK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7EB41D0", Offset = "0x7EB31D0", VA = "0x187EB41D0")]
	public static string[] EKEDNCKHCND(IHFOFKMOKKK IOALKPFEKEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7EB4B80", Offset = "0x7EB3B80", VA = "0x187EB4B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7EB4A00", Offset = "0x7EB3A00", VA = "0x187EB4A00", Slot = "6")]
	protected virtual bool JOGJFECJHFK(StringBuilder FJCCOAKCNIN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1204BD0", Offset = "0x1203BD0", VA = "0x181204BD0")]
	public static bool BDCEBPMLGHE(IHFOFKMOKKK? MACAGNGMFOK, IHFOFKMOKKK? IHEPOLKBHPP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x12050A0", Offset = "0x12040A0", VA = "0x1812050A0")]
	public static bool PHGIAKEDBEK(IHFOFKMOKKK? MACAGNGMFOK, IHFOFKMOKKK? IHEPOLKBHPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7EB48A0", Offset = "0x7EB38A0", VA = "0x187EB48A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7EB4810", Offset = "0x7EB3810", VA = "0x187EB4810", Slot = "0")]
	public override bool Equals(object? PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7EB46D0", Offset = "0x7EB36D0", VA = "0x187EB46D0", Slot = "7")]
	public virtual bool Equals(IHFOFKMOKKK? EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7EB4AF0", Offset = "0x7EB3AF0", VA = "0x187EB4AF0", Slot = "8")]
	public virtual IHFOFKMOKKK LCLCDINMEDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7EB4C90", Offset = "0x7EB3C90", VA = "0x187EB4C90")]
	protected IHFOFKMOKKK(IHFOFKMOKKK NKCMILOENIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7EB49C0", Offset = "0x7EB39C0", VA = "0x187EB49C0")]
	public void HBLCGHBNJLA([Out] JToken PGBJGODECMH, [Out] MOJPLFJNOMI FEEEMMJLJHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class OMHGBPMOPHF : PCJNLCJBMCC
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const string FNPFJOLOGJH = "Open AI Realtime API";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private const string BDLDPABAING = "endpoint";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string GHMBPPDMLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly List<Func<CJGEBBKCBNE.JOLHKGGEFMJ, CJGEBBKCBNE.JOLHKGGEFMJ>> DADHJAFKHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly List<Func<CJGEBBKCBNE.JOLHKGGEFMJ, CJGEBBKCBNE.JOLHKGGEFMJ>> CNGALJFOHEP;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public JFMNKMDGLEF? DCEBBPGBKEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public decimal LPLBHNKGNFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xF0CDA0", Offset = "0xF0BDA0", VA = "0x180F0CDA0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xF0D8F0", Offset = "0xF0C8F0", VA = "0x180F0D8F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string ONBJKKNBCNO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA674F0", Offset = "0xA664F0", VA = "0x180A674F0", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public BLEPHEDKDBG CPBFDBAINFH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA68520", Offset = "0xA67520", VA = "0x180A68520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool BILMAODCMCG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7EBDBA0", Offset = "0x7EBCBA0", VA = "0x187EBDBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7EBDF00", Offset = "0x7EBCF00", VA = "0x187EBDF00")]
	public OMHGBPMOPHF(BLEPHEDKDBG NHNMJKIIIBC, string AAHBJDOBPLI, string FILDCGMOOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7EBD540", Offset = "0x7EBC540", VA = "0x187EBD540")]
	private static CJGEBBKCBNE.JOLHKGGEFMJ ICKIMKNKJOA(string LJFJACIJLOL, string JOPIACLCKLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7EBD500", Offset = "0x7EBC500", VA = "0x187EBD500")]
	private CJGEBBKCBNE.JOLHKGGEFMJ ICHHDFAPDJC(string LJFJACIJLOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7EBDC20", Offset = "0x7EBCC20", VA = "0x187EBDC20", Slot = "9")]
	public void NIJBBAOOKDP(string? DIKAKHCHMCD, string HDAKANCKKDM, string HPDKLMKJBCF, float FPLFDLIJGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7EBBC20", Offset = "0x7EBAC20", VA = "0x187EBBC20", Slot = "11")]
	public void AFACBMCOLMM(string? DIKAKHCHMCD, ErrorEventDTO CFJNFPEHMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7EBC5D0", Offset = "0x7EBB5D0", VA = "0x187EBC5D0")]
	public static void BKCJJBCGEKG(string DGMLMPAOEHN, string JOPIACLCKLJ, decimal OPDIBJAEANI, string IEGLIFIOOBM, params (string key, string val)[] MJEOPHAJJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7EBC3C0", Offset = "0x7EBB3C0", VA = "0x187EBC3C0", Slot = "12")]
	public void BKCJJBCGEKG(string? DIKAKHCHMCD, decimal OPDIBJAEANI, string IEGLIFIOOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7EBCF90", Offset = "0x7EBBF90", VA = "0x187EBCF90", Slot = "13")]
	public void HMBHJDANKAJ(string? DIKAKHCHMCD, ConversationItemDTO ADPMEPGEIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7EBBE40", Offset = "0x7EBAE40", VA = "0x187EBBE40", Slot = "16")]
	public void BJOAFOGDDJG(string? DIKAKHCHMCD, ResponseEventDTO CFJNFPEHMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7EBD680", Offset = "0x7EBC680", VA = "0x187EBD680")]
	private (decimal?, string, string, string, string, string) JPMAGJJLIIM(ResponseEventDTO CFJNFPEHMPA)
	{
		return default((decimal?, string, string, string, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7EBC760", Offset = "0x7EBB760", VA = "0x187EBC760", Slot = "14")]
	public void FLBKFCNMGKJ(string? DIKAKHCHMCD, ResponseEventDTO CFJNFPEHMPA, float? LGLPMBAAPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7EBD5D0", Offset = "0x7EBC5D0", VA = "0x187EBD5D0", Slot = "15")]
	public void JALCFGOEAEO(Func<CJGEBBKCBNE.JOLHKGGEFMJ, CJGEBBKCBNE.JOLHKGGEFMJ> NAPGDLMDBGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7EBCEE0", Offset = "0x7EBBEE0", VA = "0x187EBCEE0", Slot = "10")]
	public void GOIINPGJCGJ(Func<CJGEBBKCBNE.JOLHKGGEFMJ, CJGEBBKCBNE.JOLHKGGEFMJ> NAPGDLMDBGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7EBDA30", Offset = "0x7EBCA30", VA = "0x187EBDA30", Slot = "17")]
	public void KPDCFHDHHPJ(string? DIKAKHCHMCD, string LPKJHGCILMN, string? ILDPPJINJGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class NEPFGOFIIDL : PCJNLCJBMCC
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public JFMNKMDGLEF? DCEBBPGBKEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public decimal LPLBHNKGNFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7EBA700", Offset = "0x7EB9700", VA = "0x187EBA700", Slot = "6")]
		get
		{
			return default(decimal);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string ONBJKKNBCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public BLEPHEDKDBG? CPBFDBAINFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "9")]
	public void NIJBBAOOKDP(string? DIKAKHCHMCD, string HDAKANCKKDM, string HPDKLMKJBCF, float FPLFDLIJGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "10")]
	public void GOIINPGJCGJ(Func<CJGEBBKCBNE.JOLHKGGEFMJ, CJGEBBKCBNE.JOLHKGGEFMJ> NAPGDLMDBGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "11")]
	public void AFACBMCOLMM(string? DIKAKHCHMCD, ErrorEventDTO CFJNFPEHMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "12")]
	public void BKCJJBCGEKG(string? DIKAKHCHMCD, decimal OPDIBJAEANI, string IEGLIFIOOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "13")]
	public void HMBHJDANKAJ(string? DIKAKHCHMCD, ConversationItemDTO ADPMEPGEIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "16")]
	public void BJOAFOGDDJG(string? DIKAKHCHMCD, ResponseEventDTO CFJNFPEHMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "14")]
	public void FLBKFCNMGKJ(string? DIKAKHCHMCD, ResponseEventDTO CFJNFPEHMPA, float? LGLPMBAAPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "15")]
	public void JALCFGOEAEO(Func<CJGEBBKCBNE.JOLHKGGEFMJ, CJGEBBKCBNE.JOLHKGGEFMJ> NAPGDLMDBGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "17")]
	public void KPDCFHDHHPJ(string? DIKAKHCHMCD, string LPKJHGCILMN, string? ILDPPJINJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7EBA760", Offset = "0x7EB9760", VA = "0x187EBA760")]
	public NEPFGOFIIDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DMKJLDOFKCO
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	FHLIAIDPCMK<ConversationItemDTO> EELAEHKPPLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	IReadOnlyList<ConversationItemDTO> MGIPHNLLBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<string> JLDBKPDHODI(ConversationItemDTO ADPMEPGEIDH);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FGJCKNFHMEE(string MDNCLKPJKMB);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface AONPKPMGOJF
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DOPJMDKBNBP(IReadOnlyCollection<string> KBHEABEDOIP, CancellationToken KGALDHLEDNC);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DKNGMKOIPPG
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ToolDTO[] PCMINKKPCAK();

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<string> MBGCELEFCNB(string PGEDMIEEBID, string BEBOBINELHL, CancellationToken KGALDHLEDNC);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface IMCNBKPIBGC
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BLEPHEDKDBG
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	const string EKNIMIBILKD = "gpt-4o-mini-realtime-preview-2024-12-17";

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	const string KNCECIAIOHO = "gpt-4o-mini-transcribe";

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	HFGJLIBLOMH LLNCDBFJDCF
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	AudioSource? OGICOIOPIHM
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	DMKJLDOFKCO? EAMJNMIGPKI
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	AONPKPMGOJF? KLIPPOCPMKG
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string? GJGAFBHFKMI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool FEOIIEHPOCP
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool INEHHJICIGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool GECPMBIFDEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool COMNNMNGAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool LMBNIJIHJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool NKCOIMMLHDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool JLOGEBPOMOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool FJHDHEEANLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool BIIKKPHJMGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool FMMMOAHGGHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool CDOHLDDNLDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool FHCDOGMNPCN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	decimal LPLBHNKGNFE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	FHLIAIDPCMK<bool> OJCGMMFOGGM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	LELKCPPPMEI PHMANGJGOGB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	MDNONHHFIOF<string, string> ELHNOLIBEAM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	LELKCPPPMEI BCPMIBICGEP
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	LELKCPPPMEI HEGLGCGFCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	FHLIAIDPCMK<List<ToolDTO>> JMKPJADFJNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	LELKCPPPMEI OMINNBFLNID
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	MDNONHHFIOF<float, string> APCAOFCNLAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	FHLIAIDPCMK<string> ABCDJMNPADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string ONBJKKNBCNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool DHLDFDHENPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task EHPNKKJDIMD(string ILMAJBEODOH, VoiceOption LJACCABGBPN, float FPLFDLIJGBK = 0.6f, string JBPNADAGCNC = "gpt-4o-mini-realtime-preview-2024-12-17", string HPDKLMKJBCF = "gpt-4o-mini-transcribe", [Optional] IReadOnlyCollection<string>? KONEHBMODOL, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void EMGOHOCPKHH();

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task LADJPIJJILM(string ILMAJBEODOH, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task BLKCPBBJNDD(float FPLFDLIJGBK, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task PBFPFDDDGEK(bool OPEAEGJENDN, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void OFCFPJFDBJL(params IMCNBKPIBGC[] HLDPKFEFEAO);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool DMNDNCGNHBN(IMCNBKPIBGC ALOEDGKCAMA);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void NMAIMHDDIJD(params IMCNBKPIBGC[] HLDPKFEFEAO);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void GBAMDCCPCKD(GKBPMJBFGGP GFDDDAIMFOH, bool FNOHOIMJENF = false);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void MENNBBFMCED(GKBPMJBFGGP GFDDDAIMFOH, bool FNOHOIMJENF = false);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void NLOLKAJLAMN(GKBPMJBFGGP GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void HLBOGHCMCMB(GKBPMJBFGGP GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void PABAHGADAHI(decimal OPDIBJAEANI, string IEGLIFIOOBM);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task MHMNHOOBCGN(string OBCNAJEENCI, [Optional] string? LOEALLHMJGH, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task EGDDGLAMOBC(string OBCNAJEENCI, [Optional] string? LOEALLHMJGH, [Optional] string? LLFPLDJIELG, bool MPGCIBFLIIH = false, bool PEOIHBMAKDO = false, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task FGJCKNFHMEE(string LOEALLHMJGH, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<ResponseDTO> FJFHNELIGGB(bool OMOKHBJFPHF = true, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<string> HPMIHOJLIBE(string ILMAJBEODOH, [Optional] IReadOnlyList<ConversationItemDTO>? KBHEABEDOIP, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<TOutput> HPMIHOJLIBE<TOutput>(string ILMAJBEODOH, [Optional] IReadOnlyList<ConversationItemDTO>? KBHEABEDOIP, [Optional] CancellationToken KGALDHLEDNC) where TOutput : class;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<List<IHFOFKMOKKK>> HPMIHOJLIBE(string ILMAJBEODOH, IReadOnlyList<ConversationItemDTO>? KBHEABEDOIP, IReadOnlyList<MOJPLFJNOMI> MGBJOIHOELH, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool AGPIDDGEDHD(string MDNCLKPJKMB);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool LCAJKKHHPCH(string MDNCLKPJKMB);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "49")]
	bool CKJBKCCPDNF(string HHFAAEJEJLC);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "50")]
	Task OKGOCAOEINK(bool IJCGKBJBKFJ, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "54")]
	IReadOnlyCollection<string> CLJEJCBNOIE();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface PCJNLCJBMCC
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	JFMNKMDGLEF? DCEBBPGBKEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	decimal LPLBHNKGNFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string ONBJKKNBCNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NIJBBAOOKDP(string? DIKAKHCHMCD, string HDAKANCKKDM, string HPDKLMKJBCF, float FPLFDLIJGBK);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GOIINPGJCGJ(Func<CJGEBBKCBNE.JOLHKGGEFMJ, CJGEBBKCBNE.JOLHKGGEFMJ> NAPGDLMDBGL);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AFACBMCOLMM(string? DIKAKHCHMCD, ErrorEventDTO CFJNFPEHMPA);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BKCJJBCGEKG(string? DIKAKHCHMCD, decimal OPDIBJAEANI, string IEGLIFIOOBM);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HMBHJDANKAJ(string? DIKAKHCHMCD, ConversationItemDTO ADPMEPGEIDH);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FLBKFCNMGKJ(string? DIKAKHCHMCD, ResponseEventDTO CFJNFPEHMPA, float? LGLPMBAAPMN);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JALCFGOEAEO(Func<CJGEBBKCBNE.JOLHKGGEFMJ, CJGEBBKCBNE.JOLHKGGEFMJ> NAPGDLMDBGL);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BJOAFOGDDJG(string? DIKAKHCHMCD, ResponseEventDTO CFJNFPEHMPA);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KPDCFHDHHPJ(string? DIKAKHCHMCD, string LPKJHGCILMN, string? ILDPPJINJGO);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface AHNONNMHEGK
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void FPEBPEAFHCK(ReadOnlySpan<float> KNEHCBOFJBG, int CNKKHLMNAKG, int AELBFPLMDBC);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PCMHFAINGOM(FPEBPEAFHCK KBILBMDMHMH);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AHHCEPCOKKO(FPEBPEAFHCK KBILBMDMHMH);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class HKMCCFMHOCN
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private enum BMAMEKFOMCI
	{
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		array,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		boolean,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		@enum,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		integer,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		number,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		@object,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		@string
	}

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static ConcurrentDictionary<Type, JsonSchema> PMLHDAEGLFO;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly Type[] MIFGBGLAPCH;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly Type[] DNEBEPMKGOC;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3C81C80", Offset = "0x3C80C80", VA = "0x183C81C80")]
	public static JsonSchema LMKONLJOAEP<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7EB2210", Offset = "0x7EB1210", VA = "0x187EB2210")]
	public static JsonSchema AAIKELOCPPE(IReadOnlyList<MOJPLFJNOMI> DELLHDJPKBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7EB27D0", Offset = "0x7EB17D0", VA = "0x187EB27D0")]
	private static JsonSchema JDENCOBAEHO(Type BJLNCBFOGNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7EB2E20", Offset = "0x7EB1E20", VA = "0x187EB2E20")]
	private static JsonSchema MCBOJLNMBOB(Type BJLNCBFOGNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7EB2C20", Offset = "0x7EB1C20", VA = "0x187EB2C20")]
	private static BMAMEKFOMCI KOCNJMIIOPD(Type BJLNCBFOGNL, [Out] Type? BJLEJLJJDIL)
	{
		return default(BMAMEKFOMCI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7EB2560", Offset = "0x7EB1560", VA = "0x187EB2560")]
	private static bool APPNKKBPOME(Type BJLNCBFOGNL, [Out][MaybeNullWhen(false)] Type JNHLMOEAJGN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class HIDIMFHDELE : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct FFHFHDGCGAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public HIDIMFHDELE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskAwaiter<MPKGNLKJDEG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7EAB3C0", Offset = "0x7EAA3C0", VA = "0x187EAB3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xAB7210", Offset = "0xAB6210", VA = "0x180AB7210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct PEFBPNIPADA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncTaskMethodBuilder<MPKGNLKJDEG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public HIDIMFHDELE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private decimal <cost>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter<MPKGNLKJDEG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7EBE470", Offset = "0x7EBD470", VA = "0x187EBE470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7EBE8C0", Offset = "0x7EBD8C0", VA = "0x187EBE8C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly ONIHMLNNEEF APKHGLJHJLF;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly TimeSpan LIODJBBEIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly CancellationTokenSource FCMFMMJGLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly FOINMAOKOCE KCPNCLGLPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly ACNHELPKEEL CCEOKBEGCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly long LIBFAOILBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly long EHINDKOLFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private string DPGAHHDNMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private decimal OJAMPIKPDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private Guid IGKEKOFGIDP;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1770", Offset = "0x7EB0770", VA = "0x187EB1770")]
	public HIDIMFHDELE(FOINMAOKOCE NHNMJKIIIBC, ACNHELPKEEL HEGKGGCPELA, string NJPDPBODLFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1580", Offset = "0x7EB0580", VA = "0x187EB1580", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7EB15F0", Offset = "0x7EB05F0", VA = "0x187EB15F0")]
	[AsyncStateMachine(typeof(FFHFHDGCGAJ))]
	private void PFAPLBOFOHB(CancellationToken KGALDHLEDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1460", Offset = "0x7EB0460", VA = "0x187EB1460")]
	[AsyncStateMachine(typeof(PEFBPNIPADA))]
	private Task<MPKGNLKJDEG> CJLBGGJAAHI(CancellationToken KGALDHLEDNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class BJJMPMDFJFF : IMCNBKPIBGC, DKNGMKOIPPG
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate Task<string> CEJCKIBFCPE(List<IHFOFKMOKKK> GHNOIAMBGEA);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct KBCBDFFAHJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public string methodName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public BJJMPMDFJFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public string methodArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7EB5240", Offset = "0x7EB4240", VA = "0x187EB5240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7EB58E0", Offset = "0x7EB48E0", VA = "0x187EB58E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly string OFFBGMGPCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly string ANPGCFHAAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly IReadOnlyList<MOJPLFJNOMI> JCOOEIJGHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly CEJCKIBFCPE BKJHJCPBIBH;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x109CF30", Offset = "0x109BF30", VA = "0x18109CF30")]
	public BJJMPMDFJFF(string HJLBILHBIIC, string GAPCMICLLJD, IReadOnlyList<MOJPLFJNOMI> DELLHDJPKBE, CEJCKIBFCPE NCAIPIHIMAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7EA6BD0", Offset = "0x7EA5BD0", VA = "0x187EA6BD0", Slot = "4")]
	private ToolDTO[] MNKHLAFLFNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7EA6A90", Offset = "0x7EA5A90", VA = "0x187EA6A90", Slot = "5")]
	[AsyncStateMachine(typeof(KBCBDFFAHJN))]
	private Task<string> ABNHHIAHNCP(string PGEDMIEEBID, string BEBOBINELHL, CancellationToken KGALDHLEDNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class APDLCNBHOCO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
	public APDLCNBHOCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GFKOBJIFODK : Exception, ACOHEBNAIHI
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string IOMFGAJJHDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x4924730", Offset = "0x4923730", VA = "0x184924730", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1110", Offset = "0x7EB0110", VA = "0x187EB1110")]
	public GFKOBJIFODK(string JAGEKBMLOEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public abstract class FOINMAOKOCE : BLEPHEDKDBG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private enum PBLIOLOMFLC
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		NotConnected,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		Connected
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct EIIANMICIKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public FOINMAOKOCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int? reconnectAttempt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private CancellationTokenSource <cts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private CancellationToken <originalCancellationToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private IDisposable <combinedTokenDisposer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private string <instructions>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private float <temperature>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private TaskAwaiter<HFGJLIBLOMH> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<bool> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7EA8D90", Offset = "0x7EA7D90", VA = "0x187EA8D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7EAB0C0", Offset = "0x7EAA0C0", VA = "0x187EAB0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct CJFJFFKJLIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public FOINMAOKOCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool keepConversationHistory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7EA84E0", Offset = "0x7EA74E0", VA = "0x187EA84E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7EA86F0", Offset = "0x7EA76F0", VA = "0x187EA86F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct MPACALHDGEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public FOINMAOKOCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7EB8E10", Offset = "0x7EB7E10", VA = "0x187EB8E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7EB9040", Offset = "0x7EB8040", VA = "0x187EB9040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct PHHNFEHAONJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public FOINMAOKOCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public float temperature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7EBE930", Offset = "0x7EBD930", VA = "0x187EBE930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7EBEB40", Offset = "0x7EBDB40", VA = "0x187EBEB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct ELHBLIIPFAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public FOINMAOKOCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7EAB120", Offset = "0x7EAA120", VA = "0x187EAB120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7EAB330", Offset = "0x7EAA330", VA = "0x187EAB330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct BNBDIMKJANN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public FOINMAOKOCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7EA6F40", Offset = "0x7EA5F40", VA = "0x187EA6F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7EA7240", Offset = "0x7EA6240", VA = "0x187EA7240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct HMOODBMLEPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public FOINMAOKOCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string conversationItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7EB3990", Offset = "0x7EB2990", VA = "0x187EB3990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7EB3E00", Offset = "0x7EB2E00", VA = "0x187EB3E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct ANMAPFHKMPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public FOINMAOKOCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public string conversationItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public bool suppressFromConversationLog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public bool excludeFromConversationPruning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public string previousItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7EA5B00", Offset = "0x7EA4B00", VA = "0x187EA5B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7EA6050", Offset = "0x7EA5050", VA = "0x187EA6050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct CMCEKBGJCAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public FOINMAOKOCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public string convresationItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7EA8750", Offset = "0x7EA7750", VA = "0x187EA8750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7EA8C80", Offset = "0x7EA7C80", VA = "0x187EA8C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class FBKKMPHLPAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public ResponseDTO response;

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public FBKKMPHLPAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7EAB390", Offset = "0x7EAA390", VA = "0x187EAB390")]
		internal bool JHBIAPCEMME(OutputAudioBufferEventDTO ev)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct HKIOOHAMDBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public AsyncTaskMethodBuilder<ResponseDTO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public FOINMAOKOCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private FBKKMPHLPAG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public bool waitForAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private TaskAwaiter<ResponseDTO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private TaskAwaiter<OutputAudioBufferEventDTO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7EB1970", Offset = "0x7EB0970", VA = "0x187EB1970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7EB21A0", Offset = "0x7EB11A0", VA = "0x187EB21A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct MFOKFNGLENM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public FOINMAOKOCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private TaskAwaiter<List<ConversationItemDTO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7EB77C0", Offset = "0x7EB67C0", VA = "0x187EB77C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7EB7D70", Offset = "0x7EB6D70", VA = "0x187EB7D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct OHJGLLHFPNG<TOutput> : IAsyncStateMachine where TOutput : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public AsyncTaskMethodBuilder<TOutput> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public FOINMAOKOCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TaskAwaiter<List<ConversationItemDTO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x5930910", Offset = "0x592F910", VA = "0x185930910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x5931140", Offset = "0x5930140", VA = "0x185931140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct MOAAAHBNGAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public AsyncTaskMethodBuilder<List<IHFOFKMOKKK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public IReadOnlyList<MOJPLFJNOMI> responseArgSchemas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public FOINMAOKOCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private TaskAwaiter<List<ConversationItemDTO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7EB7DE0", Offset = "0x7EB6DE0", VA = "0x187EB7DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7EB84B0", Offset = "0x7EB74B0", VA = "0x187EB84B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class BMIFELEMHJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public FOINMAOKOCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public ResponseCreateEventDTO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public string id;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public BMIFELEMHJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7EA6DB0", Offset = "0x7EA5DB0", VA = "0x187EA6DB0")]
		internal void JBBMNNFDACB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7EA6EB0", Offset = "0x7EA5EB0", VA = "0x187EA6EB0")]
		internal bool MGILBCFPDNM(ResponseEventDTO ev)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct FHEHKBFJHJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public AsyncTaskMethodBuilder<List<ConversationItemDTO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public FOINMAOKOCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public JsonSchema responseSchema;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private TaskAwaiter<ResponseEventDTO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7EAB8F0", Offset = "0x7EAA8F0", VA = "0x187EAB8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7EAC160", Offset = "0x7EAB160", VA = "0x187EAC160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct ONMHFODCKFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public DateTime expirationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public FOINMAOKOCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7EBE020", Offset = "0x7EBD020", VA = "0x187EBE020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7EBE410", Offset = "0x7EBD410", VA = "0x187EBE410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct NJKBEFFPHCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public FOINMAOKOCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private List<ToolDTO> <tools>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7EBA7C0", Offset = "0x7EB97C0", VA = "0x187EBA7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7EBABE0", Offset = "0x7EB9BE0", VA = "0x187EBABE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct MCCKIMNCFCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public FOINMAOKOCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public ResponseEventDTO ev;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private string <responseId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7EB7260", Offset = "0x7EB6260", VA = "0x187EB7260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xAB7210", Offset = "0xAB6210", VA = "0x180AB7210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class JGBMKKLJAJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public FOINMAOKOCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public JGBMKKLJAJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7EB50B0", Offset = "0x7EB40B0", VA = "0x187EB50B0")]
		internal Task NOLNEPKEGPH(ConversationItemDTO outputItem)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct KNMJCLKAJJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public FOINMAOKOCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public ResponseDTO response;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private JGBMKKLJAJN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7EB5C50", Offset = "0x7EB4C50", VA = "0x187EB5C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7EB6400", Offset = "0x7EB5400", VA = "0x187EB6400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct KNBKBJIEOCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public ConversationItemDTO item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public FOINMAOKOCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7EB5950", Offset = "0x7EB4950", VA = "0x187EB5950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7EB5BF0", Offset = "0x7EB4BF0", VA = "0x187EB5BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct IJDLHAOJGOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public AsyncTaskMethodBuilder<ResponseDTO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public FOINMAOKOCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private TaskAwaiter<ResponseDTO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7EB4CE0", Offset = "0x7EB3CE0", VA = "0x187EB4CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7EB5040", Offset = "0x7EB4040", VA = "0x187EB5040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct OCDHKNFFAKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public AsyncTaskMethodBuilder<ResponseDTO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public FOINMAOKOCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private CancellationToken <cancellationToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private DateTime? <startTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private TaskAwaiter<ResponseDTO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7EBACC0", Offset = "0x7EB9CC0", VA = "0x187EBACC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7EBB4D0", Offset = "0x7EBA4D0", VA = "0x187EBB4D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static readonly ONIHMLNNEEF APKHGLJHJLF;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private const ToolChoice KKIONMKEPBH = ToolChoice.Auto;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private const float MHBFBBOACHC = 0.01f;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly TimeSpan[] GIJGLJHHJNN;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly TimeSpan EFFDNDIIAHG;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly TimeSpan GLEAAJNEJEF;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly TimeSpan OMOIKEFFOGC;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly TimeSpan NKJKDHJCGJE;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly TimeSpan NALEOHCODGH;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private const string OBHGDEDBOJO = "out-of-band-id";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly KOCFMAJFLMA KDFKLOABLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly AHNONNMHEGK EGMNHKPNMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	protected readonly ACNHELPKEEL CCEOKBEGCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly PIENCKHCHMJ JIMNMFCLBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly CKAAAFLMEJP NOKCOEFFMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly CKAAAFLMEJP KJKNOFMLHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<string, DateTime> OJMEFPNNMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Lazy<PCJNLCJBMCC> DBOJDINAHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly CGIHCGKKCCH? MGEHEFAIGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private string OPKPABFMGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private VoiceOption DNJBJHHCOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private float APIHKIHPPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private string LMJCMPDELDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private string PNAPIMOIEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private PBLIOLOMFLC MGOIEOFFAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private CancellationTokenSource? FCMFMMJGLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	protected HFGJLIBLOMH? MPJLKPJOPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private GameObject? CDODNDDKFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private AudioSource? AJFBIEMIFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private AudioSourceSimpleLevelMeter? NONHAPGNDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private MPGNJMEHFCG? OJFOLHLGFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NKFEFEHMHCJ? KGGCCMHEPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private CGFOBFCNJHM? GDILJFMCLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private MJFNCGHILNL? OLNGDCCIDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private IReadOnlyCollection<string> PKEHNKDHCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private DateTime? ADJDIMMIFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private Task<ResponseDTO>? AKKGAKOKNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private uint PHGEJAAEIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly HashSet<string> BCKBCPPOHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly HashSet<string> GPGKGGAPNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly HashSet<string> FDAEJBBABBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool HDDINEMMNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private GKBPMJBFGGP? CBFAGDLMBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private bool FEMOKOGNNFP;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public HFGJLIBLOMH LLNCDBFJDCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7EAC780", Offset = "0x7EAB780", VA = "0x187EAC780", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string? GJGAFBHFKMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7EAF3C0", Offset = "0x7EAE3C0", VA = "0x187EAF3C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public abstract bool FEOIIEHPOCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public abstract bool INEHHJICIGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public abstract bool GECPMBIFDEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	protected abstract bool COOKBBLMECJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected abstract string? PNHDEKFIBHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected abstract string LFHPNAGOHGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected abstract int BGECMFDHLJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	protected abstract int MOBNIJDDOIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	protected abstract DEKDPGDEEGG JHBPKCOOEEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	protected abstract string LJCKJEMMCGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	protected virtual bool EJCCAJDMAPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "71")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	protected TimeSpan NFCDBHHAOMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xBBA480", Offset = "0xBB9480", VA = "0x180BBA480")]
		[CompilerGenerated]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2656C10", Offset = "0x2655C10", VA = "0x182656C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool COMNNMNGAAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7EAE8A0", Offset = "0x7EAD8A0", VA = "0x187EAE8A0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool LMBNIJIHJHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7EAE1F0", Offset = "0x7EAD1F0", VA = "0x187EAE1F0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool NKCOIMMLHDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7EAF020", Offset = "0x7EAE020", VA = "0x187EAF020", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool JLOGEBPOMOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xBB5A30", Offset = "0xBB4A30", VA = "0x180BB5A30", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xBB7D90", Offset = "0xBB6D90", VA = "0x180BB7D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool FJHDHEEANLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7EAD040", Offset = "0x7EAC040", VA = "0x187EAD040", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool BIIKKPHJMGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7EB0150", Offset = "0x7EAF150", VA = "0x187EB0150", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool FMMMOAHGGHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xB72C80", Offset = "0xB71C80", VA = "0x180B72C80", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool CDOHLDDNLDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7EADB60", Offset = "0x7EACB60", VA = "0x187EADB60", Slot = "19")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool FHCDOGMNPCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7EAE660", Offset = "0x7EAD660", VA = "0x187EAE660", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public decimal LPLBHNKGNFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7EAF410", Offset = "0x7EAE410", VA = "0x187EAF410", Slot = "21")]
		get
		{
			return default(decimal);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private bool KNOPPBCBLJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7EAEA90", Offset = "0x7EADA90", VA = "0x187EAEA90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	private bool PKMBHNBFCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7EAC730", Offset = "0x7EAB730", VA = "0x187EAC730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	private bool KEODDKFPNKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7EB0140", Offset = "0x7EAF140", VA = "0x187EB0140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool DHLDFDHENPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x262DFF0", Offset = "0x262CFF0", VA = "0x18262DFF0", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7EAF5F0", Offset = "0x7EAE5F0", VA = "0x187EAF5F0", Slot = "57")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private uint ABLCKOGDOEO
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xAED400", Offset = "0xAEC400", VA = "0x180AED400")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7EAE830", Offset = "0x7EAD830", VA = "0x187EAE830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public AudioSource? OGICOIOPIHM
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA6EE70", Offset = "0xA6DE70", VA = "0x180A6EE70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public DMKJLDOFKCO? EAMJNMIGPKI
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xA62800", Offset = "0xA61800", VA = "0x180A62800", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public AONPKPMGOJF? KLIPPOCPMKG
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xB12000", Offset = "0xB11000", VA = "0x180B12000", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public string ONBJKKNBCNO
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7EAE8B0", Offset = "0x7EAD8B0", VA = "0x187EAE8B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7EAE110", Offset = "0x7EAD110", VA = "0x187EAE110", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	protected virtual string? GLEBFLIPCEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xB2DDB0", Offset = "0xB2CDB0", VA = "0x180B2DDB0", Slot = "72")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	protected virtual ONIHMLNNEEF? AAEMJDGCLEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	protected virtual ONIHMLNNEEF? MCGLNCLCDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "74")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public FHLIAIDPCMK<bool> OJCGMMFOGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xBBE3A0", Offset = "0xBBD3A0", VA = "0x180BBE3A0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public LELKCPPPMEI PHMANGJGOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xBB8140", Offset = "0xBB7140", VA = "0x180BB8140", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public MDNONHHFIOF<string, string> ELHNOLIBEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xBB9A50", Offset = "0xBB8A50", VA = "0x180BB9A50", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public FHLIAIDPCMK<List<ToolDTO>> JMKPJADFJNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xBD2150", Offset = "0xBD1150", VA = "0x180BD2150", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public LELKCPPPMEI BCPMIBICGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xBC3C60", Offset = "0xBC2C60", VA = "0x180BC3C60", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public LELKCPPPMEI HEGLGCGFCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xBB72D0", Offset = "0xBB62D0", VA = "0x180BB72D0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public LELKCPPPMEI OMINNBFLNID
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xBBD2C0", Offset = "0xBBC2C0", VA = "0x180BBD2C0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public MDNONHHFIOF<float, string> APCAOFCNLAM
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xBD22F0", Offset = "0xBD12F0", VA = "0x180BD22F0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public FHLIAIDPCMK<string> ABCDJMNPADC
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xBB5BB0", Offset = "0xBB4BB0", VA = "0x180BB5BB0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7EB08F0", Offset = "0x7EAF8F0", VA = "0x187EB08F0")]
	public FOINMAOKOCE(KOCFMAJFLMA IIDDFDCCGMP, AHNONNMHEGK AABHBOCADNO, ACNHELPKEEL HEGKGGCPELA, [Optional] CGIHCGKKCCH? BPKOEEJMKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "60")]
	protected abstract PCJNLCJBMCC CreateDataReporter();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7EAC290", Offset = "0x7EAB290", VA = "0x187EAC290")]
	private void BHPIAJIPEEO(IMCNBKPIBGC EMDOKHPMGEI, DKNGMKOIPPG? NCAIPIHIMAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7EAD290", Offset = "0x7EAC290", VA = "0x187EAD290", Slot = "31")]
	public Task EHPNKKJDIMD(string ILMAJBEODOH, VoiceOption LJACCABGBPN, float FPLFDLIJGBK, string JBPNADAGCNC, string HPDKLMKJBCF, [Optional] IReadOnlyCollection<string>? KONEHBMODOL, [Optional] CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7EADF80", Offset = "0x7EACF80", VA = "0x187EADF80")]
	[AsyncStateMachine(typeof(EIIANMICIKK))]
	private Task GAMAAJFEJAF(int? NKADJMKICAC, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7EACB30", Offset = "0x7EABB30", VA = "0x187EACB30", Slot = "75")]
	protected virtual Task CheckAccess(CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0680", Offset = "0x7EAF680", VA = "0x187EB0680", Slot = "76")]
	protected virtual Task<bool> UploadTranscriptsForModeration(CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7EAD330", Offset = "0x7EAC330", VA = "0x187EAD330", Slot = "32")]
	public void EMGOHOCPKHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0030", Offset = "0x7EAF030", VA = "0x187EB0030", Slot = "54")]
	[AsyncStateMachine(typeof(CJFJFFKJLIJ))]
	public Task OKGOCAOEINK(bool IJCGKBJBKFJ, [Optional] CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7EACD50", Offset = "0x7EABD50", VA = "0x187EACD50", Slot = "77")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7EAE920", Offset = "0x7EAD920", VA = "0x187EAE920", Slot = "33")]
	[AsyncStateMachine(typeof(MPACALHDGEM))]
	public Task LADJPIJJILM(string ILMAJBEODOH, [Optional] CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7EAC620", Offset = "0x7EAB620", VA = "0x187EAC620", Slot = "34")]
	[AsyncStateMachine(typeof(PHHNFEHAONJ))]
	public Task BLKCPBBJNDD(float FPLFDLIJGBK, [Optional] CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7EAC900", Offset = "0x7EAB900", VA = "0x187EAC900")]
	[AsyncStateMachine(typeof(ELHBLIIPFAA))]
	public Task COPFOCMAAGJ(bool OPEAEGJENDN, [Optional] CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0320", Offset = "0x7EAF320", VA = "0x187EB0320", Slot = "35")]
	[AsyncStateMachine(typeof(BNBDIMKJANN))]
	public Task PBFPFDDDGEK(bool OPEAEGJENDN, [Optional] CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF850", Offset = "0x7EAE850", VA = "0x187EAF850", Slot = "36")]
	public void OFCFPJFDBJL(params IMCNBKPIBGC[] HLDPKFEFEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7EACBC0", Offset = "0x7EABBC0", VA = "0x187EACBC0", Slot = "37")]
	public bool DMNDNCGNHBN(IMCNBKPIBGC ALOEDGKCAMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF570", Offset = "0x7EAE570", VA = "0x187EAF570", Slot = "38")]
	public void NMAIMHDDIJD(params IMCNBKPIBGC[] HLDPKFEFEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7EAE0A0", Offset = "0x7EAD0A0", VA = "0x187EAE0A0", Slot = "39")]
	public void GBAMDCCPCKD(GKBPMJBFGGP GFDDDAIMFOH, bool FNOHOIMJENF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7EAEF10", Offset = "0x7EADF10", VA = "0x187EAEF10", Slot = "40")]
	public void MENNBBFMCED(GKBPMJBFGGP GFDDDAIMFOH, bool FNOHOIMJENF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF530", Offset = "0x7EAE530", VA = "0x187EAF530", Slot = "41")]
	public void NLOLKAJLAMN(GKBPMJBFGGP GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x7EAE350", Offset = "0x7EAD350", VA = "0x187EAE350", Slot = "42")]
	public void HLBOGHCMCMB(GKBPMJBFGGP GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x7EAC8A0", Offset = "0x7EAB8A0", VA = "0x187EAC8A0", Slot = "58")]
	public IReadOnlyCollection<string> CLJEJCBNOIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x7EB01C0", Offset = "0x7EAF1C0", VA = "0x187EB01C0", Slot = "43")]
	public void PABAHGADAHI(decimal OPDIBJAEANI, string IEGLIFIOOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF0B0", Offset = "0x7EAE0B0", VA = "0x187EAF0B0", Slot = "44")]
	[AsyncStateMachine(typeof(HMOODBMLEPA))]
	public Task MHMNHOOBCGN(string OBCNAJEENCI, string? LOEALLHMJGH, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7EAD080", Offset = "0x7EAC080", VA = "0x187EAD080", Slot = "45")]
	[AsyncStateMachine(typeof(ANMAPFHKMPB))]
	public Task EGDDGLAMOBC(string OBCNAJEENCI, string? LOEALLHMJGH, string? LLFPLDJIELG, bool MPGCIBFLIIH, bool PEOIHBMAKDO, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7EADBB0", Offset = "0x7EACBB0", VA = "0x187EADBB0", Slot = "46")]
	[AsyncStateMachine(typeof(CMCEKBGJCAO))]
	public Task FGJCKNFHMEE(string BOOALCFGPII, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7EAC1D0", Offset = "0x7EAB1D0", VA = "0x187EAC1D0", Slot = "51")]
	public bool AGPIDDGEDHD(string MDNCLKPJKMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7EAEA30", Offset = "0x7EADA30", VA = "0x187EAEA30", Slot = "52")]
	public bool LCAJKKHHPCH(string MDNCLKPJKMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7EAC820", Offset = "0x7EAB820", VA = "0x187EAC820", Slot = "53")]
	public bool CKJBKCCPDNF(string HHFAAEJEJLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7EADCD0", Offset = "0x7EACCD0", VA = "0x187EADCD0", Slot = "47")]
	[AsyncStateMachine(typeof(HKIOOHAMDBK))]
	public Task<ResponseDTO> FJFHNELIGGB(bool OMOKHBJFPHF = true, [Optional] CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7EAE390", Offset = "0x7EAD390", VA = "0x187EAE390", Slot = "48")]
	[AsyncStateMachine(typeof(MFOKFNGLENM))]
	public Task<string> HPMIHOJLIBE(string ILMAJBEODOH, [Optional] IReadOnlyList<ConversationItemDTO>? KBHEABEDOIP, [Optional] CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3C465D0", Offset = "0x3C455D0", VA = "0x183C465D0", Slot = "49")]
	[AsyncStateMachine(typeof(OHJGLLHFPNG<>))]
	public Task<TOutput> HPMIHOJLIBE<TOutput>(string ILMAJBEODOH, [Optional] IReadOnlyList<ConversationItemDTO>? KBHEABEDOIP, [Optional] CancellationToken KGALDHLEDNC) where TOutput : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7EAE4F0", Offset = "0x7EAD4F0", VA = "0x187EAE4F0", Slot = "50")]
	[AsyncStateMachine(typeof(MOAAAHBNGAG))]
	public Task<List<IHFOFKMOKKK>> HPMIHOJLIBE(string ILMAJBEODOH, IReadOnlyList<ConversationItemDTO>? KBHEABEDOIP, IReadOnlyList<MOJPLFJNOMI> MGBJOIHOELH, [Optional] CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7EADE10", Offset = "0x7EACE10", VA = "0x187EADE10")]
	[AsyncStateMachine(typeof(FHEHKBFJHJK))]
	private Task<List<ConversationItemDTO>> GAAOJJCPEBC(string ILMAJBEODOH, IReadOnlyList<ConversationItemDTO>? KBHEABEDOIP, JsonSchema? AOFHJCMIFAA, [Optional] CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7EAEE00", Offset = "0x7EADE00", VA = "0x187EAEE00")]
	[AsyncStateMachine(typeof(ONMHFODCKFM))]
	private Task MDCOPKMMPND(DateTime GEKNPFBMDID, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF600", Offset = "0x7EAE600", VA = "0x187EAF600")]
	private bool ODIJKLDFBJG(ResponseDTO GLGHOKJGILM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7EAEF80", Offset = "0x7EADF80", VA = "0x187EAEF80")]
	private void MFCAJMDAGJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7EAE790", Offset = "0x7EAD790", VA = "0x187EAE790")]
	private void IKMFLFKHHHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7EACE10", Offset = "0x7EABE10", VA = "0x187EACE10")]
	[AsyncStateMachine(typeof(NJKBEFFPHCF))]
	private Task EDMLDGDCPLP([Optional] CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7EAE260", Offset = "0x7EAD260", VA = "0x187EAE260")]
	private void HKFMBFMOGPP(ReadOnlySpan<float> KNEHCBOFJBG, int CNKKHLMNAKG, int AELBFPLMDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7EAD1D0", Offset = "0x7EAC1D0", VA = "0x187EAD1D0")]
	private void EHMPLGJPPKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7EB04A0", Offset = "0x7EAF4A0", VA = "0x187EB04A0")]
	[AsyncStateMachine(typeof(MCCKIMNCFCF))]
	private void PCDCKHMHMGH(ResponseEventDTO CFJNFPEHMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7EACF00", Offset = "0x7EABF00", VA = "0x187EACF00")]
	private void EELAEHKPPLG(ConversationItemDTO ADPMEPGEIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF8D0", Offset = "0x7EAE8D0", VA = "0x187EAF8D0")]
	private void OGOBJNNMOCH(ResponseEventDTO CFJNFPEHMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7EACBE0", Offset = "0x7EABBE0", VA = "0x187EACBE0")]
	private void DPGABILPDFI(string HDAKANCKKDM, string HPDKLMKJBCF, float FPLFDLIJGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7EACA10", Offset = "0x7EABA10", VA = "0x187EACA10")]
	[AsyncStateMachine(typeof(KNMJCLKAJJJ))]
	private Task CPFIIIAHPFB(ResponseDTO GLGHOKJGILM, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7EAECF0", Offset = "0x7EADCF0", VA = "0x187EAECF0")]
	[AsyncStateMachine(typeof(KNBKBJIEOCG))]
	private Task MBGCELEFCNB(ConversationItemDTO ADPMEPGEIDH, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0570", Offset = "0x7EAF570", VA = "0x187EB0570")]
	[AsyncStateMachine(typeof(IJDLHAOJGOP))]
	private Task<ResponseDTO> PGDOFGCFEBI(CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7EAE680", Offset = "0x7EAD680", VA = "0x187EAE680")]
	[AsyncStateMachine(typeof(OCDHKNFFAKF))]
	private Task<ResponseDTO> IHPPKAIFIJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF1F0", Offset = "0x7EAE1F0", VA = "0x187EAF1F0")]
	private void MIPGMNELMBG(ErrorEventDTO CFJNFPEHMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF500", Offset = "0x7EAE500", VA = "0x187EAF500")]
	private void NEDADNJAJEC(InputAudioBufferSpeechStartedEventDTO CIABMLDDFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF330", Offset = "0x7EAE330", VA = "0x187EAF330")]
	private void MJAPDBIABEG(InputAudioBufferSpeechStoppedEventDTO CIABMLDDFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7EAEBA0", Offset = "0x7EADBA0", VA = "0x187EAEBA0")]
	protected void LPGLJPEIFEO(string LPKJHGCILMN, [Optional] string? ILDPPJINJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0430", Offset = "0x7EAF430", VA = "0x187EB0430")]
	private bool PCBIKHJFLCO(ResponseDTO GLGHOKJGILM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7EB01A0", Offset = "0x7EAF1A0", VA = "0x187EB01A0")]
	protected void ONAFHCKKLHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7EAD040", Offset = "0x7EAC040", VA = "0x187EAD040")]
	[CompilerGenerated]
	private bool KBMPNLGFHAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7EAC230", Offset = "0x7EAB230", VA = "0x187EAC230")]
	[CompilerGenerated]
	private bool ANBDBONHKKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
public class NFGCOCANAFA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
	public NFGCOCANAFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface BBGDCFFGOKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CJPMLIFIENC(IMCNBKPIBGC ALOEDGKCAMA, [Out] DKNGMKOIPPG NCAIPIHIMAM);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class LJIBCJKMAGM
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private class LKJDIEGJOFE
	{
		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public PropertyInfo MILDLDGFONH
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public Type JNPPOBJDBFK
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x712FBD0", Offset = "0x712EBD0", VA = "0x18712FBD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public string KPEIJDDKBFI
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool EBBFJGKHIDC
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xA68390", Offset = "0xA67390", VA = "0x180A68390")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Type? BIAKLMINAOL
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7EB6FB0", Offset = "0x7EB5FB0", VA = "0x187EB6FB0")]
		public LKJDIEGJOFE(PropertyInfo MNMJPIFHGAK, JsonPropertyAttribute? CGEFLPJEDGD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly ConcurrentDictionary<Type, List<LKJDIEGJOFE>> BAMBLKMNPCH;

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7EB6460", Offset = "0x7EB5460", VA = "0x187EB6460")]
	public static List<string> EIIDAONEKLE(string KLLAHLEHMOI, Type NDPHOBFFCIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7EB6600", Offset = "0x7EB5600", VA = "0x187EB6600")]
	private static void OABMJNFEANC(Type BJLNCBFOGNL, JObject ECEOFMJLKOE, List<string> CHDPOACJNGJ, string JFFBLMBMJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7EB6C10", Offset = "0x7EB5C10", VA = "0x187EB6C10")]
	private static List<LKJDIEGJOFE> OHILFJFKCIJ(Type BJLNCBFOGNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7EB6550", Offset = "0x7EB5550", VA = "0x187EB6550")]
	private static bool MBKGDDGANLC(Type BJLNCBFOGNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public LJIBCJKMAGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal class CGFOBFCNJHM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class GKBEHHDLLEA
	{
		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public string? HIMOMOOGBDB
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public int GPPOMHMILNN
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xA6A6F0", Offset = "0xA696F0", VA = "0x180A6A6F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public int KMMHBGOHCMB
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xA88A10", Offset = "0xA87A10", VA = "0x180A88A10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xE8AAE0", Offset = "0xE89AE0", VA = "0x180E8AAE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7EB1190", Offset = "0x7EB0190", VA = "0x187EB1190")]
		public GKBEHHDLLEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private class JJNCKNGOCCB
	{
		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public string CMGKJAEFCGA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public ConversationItemType HHDOJPCILPE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
			[CompilerGenerated]
			get
			{
				return default(ConversationItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xA6A6F0", Offset = "0xA696F0", VA = "0x180A6A6F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public string? NNOCFIIEOOC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public string? GHLJANJDNGM
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7EB51D0", Offset = "0x7EB41D0", VA = "0x187EB51D0")]
		public JJNCKNGOCCB(ConversationItemDTO ADPMEPGEIDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class OLMLPJLACAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public IEnumerable<string> functionNames;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public OLMLPJLACAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7EBBB10", Offset = "0x7EBAB10", VA = "0x187EBBB10")]
		internal bool JGFDIHJKLAK(JJNCKNGOCCB c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class BODBJLONIKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public JJNCKNGOCCB c;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public BODBJLONIKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7EA72A0", Offset = "0x7EA62A0", VA = "0x187EA72A0")]
		internal bool NAKADGALHOK(string n)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class GPMJPMPLNIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public ConversationItemDTO item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public CGFOBFCNJHM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public GPMJPMPLNIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7EB1420", Offset = "0x7EB0420", VA = "0x187EB1420")]
		internal bool JGMACCCGIMN(string n)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7EB11B0", Offset = "0x7EB01B0", VA = "0x187EB11B0")]
		internal bool EBPFGMCMKIK(JJNCKNGOCCB c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7EB1200", Offset = "0x7EB0200", VA = "0x187EB1200")]
		internal void EEENNCJEGFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class EBNMJINCOMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public IEnumerable<string?> callIdsToRemove;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public EBNMJINCOMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7EA8D20", Offset = "0x7EA7D20", VA = "0x187EA8D20")]
		internal bool EANJOCLHNON(JJNCKNGOCCB c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class ACANLMGBDCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public IEnumerable<string> idsToRemove;

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public ACANLMGBDCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7EA5AA0", Offset = "0x7EA4AA0", VA = "0x187EA5AA0")]
		internal bool BMDCEPBLIJI(JJNCKNGOCCB c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class BKMJGLPDGJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public Queue<string> queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public Func<bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public BKMJGLPDGJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7EA6D60", Offset = "0x7EA5D60", VA = "0x187EA6D60")]
		internal bool FJMIHAFPMHA()
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct OLJPDOPEDAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public Queue<string> queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private BKMJGLPDGJB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public CGFOBFCNJHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7EBB540", Offset = "0x7EBA540", VA = "0x187EBB540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7EBBAB0", Offset = "0x7EBAAB0", VA = "0x187EBBAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly BLEPHEDKDBG KCPNCLGLPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly DMKJLDOFKCO OJFOLHLGFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly HashSet<string> OHLCJAMGDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly GKBEHHDLLEA EKLOAJCBABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly List<JJNCKNGOCCB> PKEHNKDHCBD;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static Queue<string> OJIEIDKIOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly CancellationTokenSource BLKMPGKBGNB;

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7EA7FD0", Offset = "0x7EA6FD0", VA = "0x187EA7FD0")]
	public CGFOBFCNJHM(BLEPHEDKDBG NHNMJKIIIBC, DMKJLDOFKCO OFBKIENFGJC, GKBEHHDLLEA EGBMNBJEHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7EA72E0", Offset = "0x7EA62E0", VA = "0x187EA72E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7EA77A0", Offset = "0x7EA67A0", VA = "0x187EA77A0")]
	public void GCIMNJOOPCF(IEnumerable<string> BCHGEJNHJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7EA73C0", Offset = "0x7EA63C0", VA = "0x187EA73C0")]
	private void EELAEHKPPLG(ConversationItemDTO ADPMEPGEIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7EA7990", Offset = "0x7EA6990", VA = "0x187EA7990")]
	private void NHPKBDAGDAK(IEnumerable<string?> MGNKMOJANCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7EA7E20", Offset = "0x7EA6E20", VA = "0x187EA7E20")]
	[AsyncStateMachine(typeof(OLJPDOPEDAA))]
	private Task OEMJALJKBLH(Queue<string> IINKJMKBHLF, CancellationToken KGALDHLEDNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class MPGNJMEHFCG : DMKJLDOFKCO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	internal class CLDKDLOGKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public ConversationItemDTO LJHNMNJFPNL
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool JPKJGDMCHMA
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xAB8160", Offset = "0xAB7160", VA = "0x180AB8160")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xA69F60", Offset = "0xA68F60", VA = "0x180A69F60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x155F0C0", Offset = "0x155E0C0", VA = "0x18155F0C0")]
		public CLDKDLOGKGJ(ConversationItemDTO ADPMEPGEIDH, bool LMFKELGAKPH = false)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class HONMEDMNLII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public ConversationItemCreatedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public HONMEDMNLII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7EB3E60", Offset = "0x7EB2E60", VA = "0x187EB3E60")]
		internal bool KIDDCIIILKO(CLDKDLOGKGJ c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x7EB10D0", Offset = "0x7EB00D0", VA = "0x187EB10D0")]
		internal bool BCJIKKBNLEN(CLDKDLOGKGJ c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class DKCPIOBFJGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public ConversationItemDTO conversationItem;

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public DKCPIOBFJGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x7EA8CE0", Offset = "0x7EA7CE0", VA = "0x187EA8CE0")]
		internal bool PIEGOBAOMFK(CLDKDLOGKGJ c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class GBAMEKADEME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public ConversationItemInputAudioTranscriptionCompletedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public GBAMEKADEME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x7EB10D0", Offset = "0x7EB00D0", VA = "0x187EB10D0")]
		internal bool BCKCDCACJNN(CLDKDLOGKGJ c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class HPABJHNPCEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public ConversationItemDTO item;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public HPABJHNPCEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x7EB3EB0", Offset = "0x7EB2EB0", VA = "0x187EB3EB0")]
		internal bool CFIKPFFKIPE(CLDKDLOGKGJ c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class BGKNGCGPKEC : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private string <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private ConversationItemDTO item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public ConversationItemDTO <>3__item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public MPGNJMEHFCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private HPABJHNPCEG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private List<ConversationItemContentDTO>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		string IEnumerator<string>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0xF97DB0", Offset = "0xF96DB0", VA = "0x180F97DB0")]
		[DebuggerHidden]
		public BGKNGCGPKEC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7EA6A00", Offset = "0x7EA5A00", VA = "0x187EA6A00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7EA6100", Offset = "0x7EA5100", VA = "0x187EA6100", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7EA60B0", Offset = "0x7EA50B0", VA = "0x187EA60B0")]
		private void FEADENMJGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7EA69B0", Offset = "0x7EA59B0", VA = "0x187EA69B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x7EA68F0", Offset = "0x7EA58F0", VA = "0x187EA68F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x7EA68F0", Offset = "0x7EA58F0", VA = "0x187EA68F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class LBGJCIGLFJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public string messageId;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public LBGJCIGLFJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x215EB50", Offset = "0x215DB50", VA = "0x18215EB50")]
		internal bool DBOEJLGMKCK(ConversationItemDTO m)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly FOINMAOKOCE KCPNCLGLPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly HFGJLIBLOMH MPJLKPJOPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly GKBPMJBFGGP AGLPDILFKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly List<CLDKDLOGKGJ> MLNBAEDDPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly List<string> PKEHNKDHCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly List<ConversationItemDTO> JKANKDBDKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private string? IHHMADMABOK;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public FHLIAIDPCMK<ConversationItemDTO> EELAEHKPPLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public IReadOnlyList<string> BOFKJEPCMKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public IReadOnlyList<ConversationItemDTO> MGIPHNLLBKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7EBA230", Offset = "0x7EB9230", VA = "0x187EBA230")]
	public MPGNJMEHFCG(FOINMAOKOCE NHNMJKIIIBC, IReadOnlyCollection<string> MHGPNLNJLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7EB9780", Offset = "0x7EB8780", VA = "0x187EB9780", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x7EB9590", Offset = "0x7EB8590", VA = "0x187EB9590")]
	public List<string> CLJEJCBNOIE(bool OJNGAEEMINC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7EB90A0", Offset = "0x7EB80A0", VA = "0x187EB90A0")]
	private void APMMBGCKNKI(ConversationItemCreatedEventDTO CFJNFPEHMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7EB9F80", Offset = "0x7EB8F80", VA = "0x187EB9F80")]
	private void OGOBJNNMOCH(ResponseEventDTO CFJNFPEHMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7EB9DC0", Offset = "0x7EB8DC0", VA = "0x187EB9DC0")]
	private void KHMIANHLLNN(ConversationItemInputAudioTranscriptionCompletedEventDTO CFJNFPEHMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7EB9A00", Offset = "0x7EB8A00", VA = "0x187EB9A00")]
	private void ENHPJELJODM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7EB9D20", Offset = "0x7EB8D20", VA = "0x187EB9D20", Slot = "6")]
	[IteratorStateMachine(typeof(BGKNGCGPKEC))]
	public IEnumerable<string> JLDBKPDHODI(ConversationItemDTO ADPMEPGEIDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7EB9C40", Offset = "0x7EB8C40", VA = "0x187EB9C40", Slot = "7")]
	public void FGJCKNFHMEE(string MDNCLKPJKMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class NKFEFEHMHCJ : AONPKPMGOJF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct NGAHKACAJDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public IReadOnlyCollection<string> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public NKFEFEHMHCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7EC2300", Offset = "0x7EC1300", VA = "0x187EC2300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7EC2790", Offset = "0x7EC1790", VA = "0x187EC2790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly FOINMAOKOCE KCPNCLGLPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly string JDKGNMBOMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly int NOLHFBPMOCI;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E01820", Offset = "0x5E00820", VA = "0x185E01820")]
	public NKFEFEHMHCJ(FOINMAOKOCE NHNMJKIIIBC, string MPJADFMDHAN, int FKNJHCJEJHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7EC2B60", Offset = "0x7EC1B60", VA = "0x187EC2B60", Slot = "4")]
	[AsyncStateMachine(typeof(NGAHKACAJDB))]
	public Task DOPJMDKBNBP(IReadOnlyCollection<string> KBHEABEDOIP, CancellationToken KGALDHLEDNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class GJIAFBBGFOM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public Type KBFMDJMLBMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xAC8EE0", Offset = "0xAC7EE0", VA = "0x180AC8EE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public string OHHPNCCLOHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA6EE70", Offset = "0xA6DE70", VA = "0x180A6EE70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7EC02A0", Offset = "0x7EBF2A0", VA = "0x187EC02A0")]
	public GJIAFBBGFOM(Type BFEANECLDFP, string KLLAHLEHMOI, Exception BMHAEMEHBKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class PIENCKHCHMJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct EEDGPDPAIEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public string args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public PIENCKHCHMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private Dictionary<IMCNBKPIBGC, DKNGMKOIPPG?>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private TaskAwaiter<string?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7EBF760", Offset = "0x7EBE760", VA = "0x187EBF760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7EC0230", Offset = "0x7EBF230", VA = "0x187EC0230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private static readonly ONIHMLNNEEF APKHGLJHJLF;

	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private static readonly List<BBGDCFFGOKJ> LCHMBCAMKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private readonly Dictionary<IMCNBKPIBGC, DKNGMKOIPPG?> DJHFEKGDHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public readonly MDNONHHFIOF<IMCNBKPIBGC, DKNGMKOIPPG?> BHPIAJIPEEO;

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7EC3AE0", Offset = "0x7EC2AE0", VA = "0x187EC3AE0")]
	static PIENCKHCHMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7EC3820", Offset = "0x7EC2820", VA = "0x187EC3820")]
	public void OFCFPJFDBJL(params IMCNBKPIBGC[] HLDPKFEFEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7EC2DF0", Offset = "0x7EC1DF0", VA = "0x187EC2DF0")]
	public bool DMNDNCGNHBN(IMCNBKPIBGC ALOEDGKCAMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7EC3500", Offset = "0x7EC2500", VA = "0x187EC3500")]
	public void NMAIMHDDIJD(params IMCNBKPIBGC[] HLDPKFEFEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7EC2E50", Offset = "0x7EC1E50", VA = "0x187EC2E50")]
	public void FPOGGACHHLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7EC33A0", Offset = "0x7EC23A0", VA = "0x187EC33A0")]
	[AsyncStateMachine(typeof(EEDGPDPAIEI))]
	public Task<string> MBGCELEFCNB(string HJLBILHBIIC, string DELLHDJPKBE, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7EC2EE0", Offset = "0x7EC1EE0", VA = "0x187EC2EE0")]
	public List<ToolDTO> HFCNHJHFDGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7EC30D0", Offset = "0x7EC20D0", VA = "0x187EC30D0")]
	private static DKNGMKOIPPG LCPPPKNAJAN(IMCNBKPIBGC ALOEDGKCAMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x7EC3E20", Offset = "0x7EC2E20", VA = "0x187EC3E20")]
	public PIENCKHCHMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class HJCFPJNOCJK
{
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public static JsonSerializerSettings INNGEAOKFML;

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0370", Offset = "0x7EBF370", VA = "0x187EC0370")]
	static HJCFPJNOCJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class MJFNCGHILNL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	private class FHMKPIDIHBP
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public ConversationItemDTO LJHNMNJFPNL
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool JPKJGDMCHMA
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xAB8160", Offset = "0xAB7160", VA = "0x180AB8160")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0xA69F60", Offset = "0xA68F60", VA = "0x180A69F60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x155F0C0", Offset = "0x155E0C0", VA = "0x18155F0C0")]
		public FHMKPIDIHBP(ConversationItemDTO ADPMEPGEIDH, bool LMFKELGAKPH = false)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private abstract class APFCMNCKLMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private readonly StringBuilder DCMIENOBOCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private readonly TimeSpan CDBHAJHDDJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private DateTime ECELIBHMCNK;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7EBF560", Offset = "0x7EBE560", VA = "0x187EBF560")]
		public APFCMNCKLMG(TimeSpan HEAKKLPAMCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x7EBF510", Offset = "0x7EBE510", VA = "0x187EBF510")]
		public void KJJAHEFGMGM(string EMHBCDBCCJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x7EBF3D0", Offset = "0x7EBE3D0", VA = "0x187EBF3D0")]
		public void CIINNEMCPEF(bool HOJOMGEINAH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void JBFHPEDDBCM(string NCBKJJBPLBE);
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private class PDPNMCBNBGO : APFCMNCKLMG
	{
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private static readonly TimeSpan CEFFOFPFBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private readonly string IKHADLLOOGJ;

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7EC2D60", Offset = "0x7EC1D60", VA = "0x187EC2D60")]
		public PDPNMCBNBGO(string JFHJLFLGHLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7EC2C80", Offset = "0x7EC1C80", VA = "0x187EC2C80", Slot = "4")]
		protected override void JBFHPEDDBCM(string NCBKJJBPLBE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private class NGKEBNAMMLN : APFCMNCKLMG
	{
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private static readonly TimeSpan CEFFOFPFBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private readonly ACNHELPKEEL CCEOKBEGCEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private readonly HFGJLIBLOMH MPJLKPJOPGG;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7EC2AC0", Offset = "0x7EC1AC0", VA = "0x187EC2AC0")]
		public NGKEBNAMMLN(ACNHELPKEEL HEGKGGCPELA, HFGJLIBLOMH LDDKHGFDCNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7EC27F0", Offset = "0x7EC17F0", VA = "0x187EC27F0", Slot = "4")]
		protected override void JBFHPEDDBCM(string NCBKJJBPLBE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	private class DHGFIJLIHJE : APFCMNCKLMG
	{
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private static readonly TimeSpan CEFFOFPFBLM;

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x7EBF700", Offset = "0x7EBE700", VA = "0x187EBF700")]
		public DHGFIJLIHJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x7EBF610", Offset = "0x7EBE610", VA = "0x187EBF610", Slot = "4")]
		protected override void JBFHPEDDBCM(string NCBKJJBPLBE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class ELMFDFOIFJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public ConversationItemCreatedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public ELMFDFOIFJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x7EB10D0", Offset = "0x7EB00D0", VA = "0x187EB10D0")]
		internal bool KIDDCIIILKO(FHMKPIDIHBP c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class KCLNKJMHLNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public ConversationItemDTO conversationItem;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public KCLNKJMHLNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x7EA8CE0", Offset = "0x7EA7CE0", VA = "0x187EA8CE0")]
		internal bool PIEGOBAOMFK(FHMKPIDIHBP c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class DEMIICNDOPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public ConversationItemInputAudioTranscriptionCompletedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public DEMIICNDOPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x7EB10D0", Offset = "0x7EB00D0", VA = "0x187EB10D0")]
		internal bool BCKCDCACJNN(FHMKPIDIHBP c)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct JDCAGADHDEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public MJFNCGHILNL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x7EC05C0", Offset = "0x7EBF5C0", VA = "0x187EC05C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7EC07A0", Offset = "0x7EBF7A0", VA = "0x187EC07A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly TimeSpan CEFFOFPFBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly FOINMAOKOCE KCPNCLGLPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly HFGJLIBLOMH MPJLKPJOPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly ACNHELPKEEL CCEOKBEGCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly GKBPMJBFGGP AGLPDILFKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly List<APFCMNCKLMG> INNAGOELJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly List<FHMKPIDIHBP> MLNBAEDDPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private string? IHHMADMABOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private CancellationTokenSource? OBFCMOPDPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private Task? FBOFJNFNMCK;

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x7EC1BD0", Offset = "0x7EC0BD0", VA = "0x187EC1BD0")]
	public MJFNCGHILNL(FOINMAOKOCE NHNMJKIIIBC, ACNHELPKEEL HEGKGGCPELA, bool MPOGKDHJDHH, bool OPNFECFAPCI, string? MDANFBAKMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0C70", Offset = "0x7EBFC70", VA = "0x187EC0C70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0800", Offset = "0x7EBF800", VA = "0x187EC0800")]
	private void APMMBGCKNKI(ConversationItemCreatedEventDTO CFJNFPEHMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x7EC18B0", Offset = "0x7EC08B0", VA = "0x187EC18B0")]
	private void OGOBJNNMOCH(ResponseEventDTO CFJNFPEHMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x7EC12B0", Offset = "0x7EC02B0", VA = "0x187EC12B0")]
	private void KHMIANHLLNN(ConversationItemInputAudioTranscriptionCompletedEventDTO CFJNFPEHMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0F80", Offset = "0x7EBFF80", VA = "0x187EC0F80")]
	private void FMBBNLPFLAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7EC1620", Offset = "0x7EC0620", VA = "0x187EC1620")]
	private void OGMPFBABGPB(ConversationItemDTO ADPMEPGEIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x7EC1470", Offset = "0x7EC0470", VA = "0x187EC1470")]
	private void KJJAHEFGMGM(string EMHBCDBCCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x7EC10A0", Offset = "0x7EC00A0", VA = "0x187EC10A0")]
	[AsyncStateMachine(typeof(JDCAGADHDEM))]
	private Task FPKLJODKAEA(CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7EC1190", Offset = "0x7EC0190", VA = "0x187EC1190")]
	private void HBACNPBKOKC(bool HOJOMGEINAH = false)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class HLGNEFPMHEK
{
	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public HLGNEFPMHEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x7343BF0", Offset = "0x7342BF0", VA = "0x187343BF0")]
	public static string KDHGMCJJDJH(byte[] APPLLJJBAIJ, byte[] ONHOGPDMCCD)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
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

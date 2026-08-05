using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Circuits.All.RecRoom.Integration.Adapter;
using Cpp2IlInjected;
using Google.Protobuf;
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
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5ABFA70", Offset = "0x5ABEC70", VA = "0x185ABFA70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7018E0", Offset = "0x700AE0", VA = "0x1807018E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x701910", Offset = "0x700B10", VA = "0x180701910")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NJKIKPKBBJC : HHFBDBEGDIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Action OOAAENDOJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public string ANGEAOLECFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public Func<bool> DKGPPAMNHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Func<bool> FNPBAMGOEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Func<bool> AJOAGODPOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public bool KOEGAJAODKO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5ABF4C0", Offset = "0x5ABE6C0", VA = "0x185ABF4C0")]
	public NJKIKPKBBJC(Action CCLGFCNAFEB, string OEPJBAJNCNJ = "", [Optional] Func<bool> KIOMKOPLEEH, [Optional] Func<bool> FPEOAKJKHMN, [Optional] Func<bool> JPJLGDNKPKB, bool NJJFJLIGHHJ = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BDANCCDDPDO : HHFBDBEGDIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public Func<int> MPNAEOLKHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public Action<int> AOILKLNIGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public Func<bool> DKGPPAMNHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public Func<bool> FNPBAMGOEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool AMPKIJALIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public string ANGEAOLECFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Func<bool> AJOAGODPOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public bool AEEABLGLGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public bool KOEGAJAODKO;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HHFBDBEGDIK
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public enum EGNPKCAGDNL
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		Standard,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		Autocorrected,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		IntegerNumber,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		DecimalNumber,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Alphanumeric,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		Name,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		EmailAddress,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Password,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Pin,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Custom
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int CLGBEHOBKFN = 999;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public HHFBDBEGDIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class BAEHBKPNMGJ : HHFBDBEGDIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public Func<string> PJGONLKPECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public Action<string> CGNHEOJHMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public int PIOOFFKPHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Func<string, bool> EPBEDHLPEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public string CIGNNCECHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Func<bool> DKGPPAMNHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Func<bool> FNPBAMGOEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public string ANGEAOLECFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public string DCPPCBLKOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public string LPEHAGFPPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public string OLMEMAMBELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public bool GFIHKEDAEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public bool KOEGAJAODKO;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class AODKHBBJGLA : HHFBDBEGDIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Func<float> PJGONLKPECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public Action<float> CGNHEOJHMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public string ANGEAOLECFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public string DCPPCBLKOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public string FNEEHCHIMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public string LPEHAGFPPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public string OLMEMAMBELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public bool DAAAEDNPAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float INAHKPODGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float ANHBFKMKBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Func<bool> DKGPPAMNHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Func<bool> FNPBAMGOEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Func<bool> AJOAGODPOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool KOEGAJAODKO;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class DDBCOOIMHOL : HHFBDBEGDIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Func<float> PJGONLKPECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Action<float> CGNHEOJHMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public float INAHKPODGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public float ANHBFKMKBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Func<bool> AODCBLFAAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public int AOEPBJLBCAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public string ANGEAOLECFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public string DCPPCBLKOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public string FNEEHCHIMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public string LPEHAGFPPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public string OLMEMAMBELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Func<float, float> MKLBAALCLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Func<float, float> HGPCMAOCECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Func<bool> AJOAGODPOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public bool KOEGAJAODKO;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class CIHLDKKGNAP : HHFBDBEGDIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public Func<string> PJGONLKPECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public Action<string> CGNHEOJHMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public Func<bool> DKGPPAMNHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public Func<bool> FNPBAMGOEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public int? IONAIGHDCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public bool KFFLNBAAOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public string ANGEAOLECFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public string LPEHAGFPPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public string OLMEMAMBELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public Func<bool> AJOAGODPOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public bool KOEGAJAODKO;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PFNJDABAHEN : HHFBDBEGDIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Func<string> PJGONLKPECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public Action<string> CGNHEOJHMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Action OOAAENDOJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public Func<bool> DKGPPAMNHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public EGNPKCAGDNL MMMENNAAGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string ANGEAOLECFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public string LPEHAGFPPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public string OLMEMAMBELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public string BGCGLMGHDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public string KHIHHFGKIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public bool KOEGAJAODKO;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class EEMLHDAHIIK : HHFBDBEGDIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public Func<string> PJGONLKPECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public Action<string> CGNHEOJHMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public Func<bool> DKGPPAMNHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public Func<bool> FNPBAMGOEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public int? IONAIGHDCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public bool KFFLNBAAOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public string ANGEAOLECFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public string LPEHAGFPPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public string OLMEMAMBELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Func<bool> AJOAGODPOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public bool KOEGAJAODKO;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class AAJOJACBNBF : HHFBDBEGDIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public string KKHKFIGPMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Func<bool> DKGPPAMNHMM;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class IKHKALMLCGP : HHFBDBEGDIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public Func<bool> PJGONLKPECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Action<bool> CGNHEOJHMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Func<bool> DKGPPAMNHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Func<bool> FNPBAMGOEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public string ANGEAOLECFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public string DCPPCBLKOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public string LPEHAGFPPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public string OLMEMAMBELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public int LDHIBGALEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Func<bool> AJOAGODPOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool KOEGAJAODKO;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DNIANAKBLEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HGJACDFHCLO.GAPIFPCCBCC IKOMMDAJGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	NIFIFDPHODO.IJNLJHDKPJC AJBAPPHKLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	ACMKJNGKBGH.NOADCICHGKG LBMBPGCNOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	MOLDCCAMOLJ.HNKDHPPEHCE KCNAPBALABP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	MCGECNINFGJ.NEFDHCLEIOG INODLHDLNOC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	EOCBIPMGBHI ANPMIEHIEFA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class CIAOJDPEPHK
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5AB9670", Offset = "0x5AB8870", VA = "0x185AB9670")]
	public static CAFMMAJMNLD NJHPIJAAEDJ(this MCPEBLPFGDE DIJPFIMLAFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct MCPEBLPFGDE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct FPOFEJLPAHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AsyncTaskMethodBuilder<global::LAFJBBFBCGA<object, HODHNINHENI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public ACMKJNGKBGH root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public MCPEBLPFGDE self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CE830", Offset = "0x5CDC30")]
		private TaskAwaiter<global::LAFJBBFBCGA<object, HODHNINHENI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5ABAF50", Offset = "0x5ABA150", VA = "0x185ABAF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5ABB1D0", Offset = "0x5ABA3D0", VA = "0x185ABB1D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly ByteString LKDHJKNGKHD;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7AF920", Offset = "0x7AEB20", VA = "0x1807AF920")]
	private MCPEBLPFGDE(ByteString IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5ABDE40", Offset = "0x5ABD040", VA = "0x185ABDE40")]
	public static global::BNNACKHHFFC<OCKMNPJBBFI, MCPEBLPFGDE> PPICLLNAIBI(CAFMMAJMNLD LEEEHBCCIGH)
	{
		return default(global::BNNACKHHFFC<OCKMNPJBBFI, MCPEBLPFGDE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5ABDD00", Offset = "0x5ABCF00", VA = "0x185ABDD00")]
	[AsyncStateMachine(typeof(FPOFEJLPAHE))]
	public static Task<global::LAFJBBFBCGA<object, HODHNINHENI>> DGCBHJNCMIG(ACMKJNGKBGH KPDGHDGLMHO, MCPEBLPFGDE DIJPFIMLAFB)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct KFBGHKPIBNL
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5ABCCC0", Offset = "0x5ABBEC0", VA = "0x185ABCCC0")]
	public static CAFMMAJMNLD DHNIEKIGEGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5ABCDE0", Offset = "0x5ABBFE0", VA = "0x185ABCDE0")]
	public static global::BNNACKHHFFC<OCKMNPJBBFI, KFBGHKPIBNL> PPICLLNAIBI(CAFMMAJMNLD LEEEHBCCIGH)
	{
		return default(global::BNNACKHHFFC<OCKMNPJBBFI, KFBGHKPIBNL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5ABCD60", Offset = "0x5ABBF60", VA = "0x185ABCD60")]
	public static global::LAFJBBFBCGA<MFEHAEMCKCJ, HODHNINHENI> LNCALKLBEJG(ACMKJNGKBGH KPDGHDGLMHO, in KFBGHKPIBNL DIJPFIMLAFB)
	{
		return default(global::LAFJBBFBCGA<MFEHAEMCKCJ, HODHNINHENI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct NHODFGAJDAP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct KHHBNEEFGAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder<global::LAFJBBFBCGA<MFEHAEMCKCJ, HODHNINHENI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public ACMKJNGKBGH root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public NHODFGAJDAP self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private global::LAFJBBFBCGA<MFEHAEMCKCJ, HODHNINHENI> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5ABCE50", Offset = "0x5ABC050", VA = "0x185ABCE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5ABD210", Offset = "0x5ABC410", VA = "0x185ABD210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly KAAMMJLINCK PLMLJNMBNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly ECNCNNBLHJH CONFBPFCDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly JFPOIAPCMPC NDJJAHDONPC;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x881CB0", Offset = "0x880EB0", VA = "0x180881CB0")]
	private NHODFGAJDAP(KAAMMJLINCK IMDAGNMLCEA, ECNCNNBLHJH EMLJOBICHBA, JFPOIAPCMPC FBAEJBINMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5ABEF10", Offset = "0x5ABE110", VA = "0x185ABEF10")]
	public static CAFMMAJMNLD DHNIEKIGEGG(KAAMMJLINCK IMDAGNMLCEA, ECNCNNBLHJH EMLJOBICHBA, JFPOIAPCMPC FBAEJBINMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5ABF000", Offset = "0x5ABE200", VA = "0x185ABF000")]
	public static global::BNNACKHHFFC<OCKMNPJBBFI, NHODFGAJDAP> PPICLLNAIBI(CAFMMAJMNLD LEEEHBCCIGH)
	{
		return default(global::BNNACKHHFFC<OCKMNPJBBFI, NHODFGAJDAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5ABEDC0", Offset = "0x5ABDFC0", VA = "0x185ABEDC0")]
	[AsyncStateMachine(typeof(KHHBNEEFGAN))]
	public static Task<global::LAFJBBFBCGA<MFEHAEMCKCJ, HODHNINHENI>> DGCBHJNCMIG(ACMKJNGKBGH KPDGHDGLMHO, NHODFGAJDAP DIJPFIMLAFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct OMKGBIICELK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct GAHKFNEOOKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder<global::LAFJBBFBCGA<JHFMIMDLHNN, HODHNINHENI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public OMKGBIICELK self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public ACMKJNGKBGH root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private global::LAFJBBFBCGA<JHFMIMDLHNN, HODHNINHENI> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private global::LAFJBBFBCGA<object, BBMENPGBPEA>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private global::LAFJBBFBCGA<object, BBMENPGBPEA> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CE930", Offset = "0x5CDD30")]
		private TaskAwaiter<global::LAFJBBFBCGA<object, HODHNINHENI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5ABB220", Offset = "0x5ABA420", VA = "0x185ABB220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5ABB610", Offset = "0x5ABA810", VA = "0x185ABB610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly IReadOnlyList<CAFMMAJMNLD> NJLKDGFLJCK;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7AF920", Offset = "0x7AEB20", VA = "0x1807AF920")]
	private OMKGBIICELK(IReadOnlyList<CAFMMAJMNLD> KIFOHHMNMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5ABFC40", Offset = "0x5ABEE40", VA = "0x185ABFC40")]
	public static CAFMMAJMNLD DHNIEKIGEGG(IReadOnlyList<CAFMMAJMNLD> KIFOHHMNMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5ABFD00", Offset = "0x5ABEF00", VA = "0x185ABFD00")]
	public static global::BNNACKHHFFC<OCKMNPJBBFI, OMKGBIICELK> PPICLLNAIBI(CAFMMAJMNLD LEEEHBCCIGH)
	{
		return default(global::BNNACKHHFFC<OCKMNPJBBFI, OMKGBIICELK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5ABFB00", Offset = "0x5ABED00", VA = "0x185ABFB00")]
	[AsyncStateMachine(typeof(GAHKFNEOOKF))]
	public static Task<global::LAFJBBFBCGA<JHFMIMDLHNN, HODHNINHENI>> DGCBHJNCMIG(ACMKJNGKBGH KPDGHDGLMHO, OMKGBIICELK DIJPFIMLAFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct NJPMIPOHDKP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct MFHOHPHJILG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder<global::LAFJBBFBCGA<bool, HODHNINHENI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public ACMKJNGKBGH root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public NJPMIPOHDKP self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private global::LAFJBBFBCGA<bool, HODHNINHENI> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<global::LAFJBBFBCGA<MFEHAEMCKCJ, HODHNINHENI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5ABDEF0", Offset = "0x5ABD0F0", VA = "0x185ABDEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5ABE4D0", Offset = "0x5ABD6D0", VA = "0x185ABE4D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly int BPIIJGBNBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly int BCGMDEIHEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly byte[] OOJPBADIODK;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x19AA950", Offset = "0x19A9B50", VA = "0x1819AA950")]
	private NJPMIPOHDKP(int BFFJHKFEFPP, int GMEHLIHLGEH, byte[] PCPEJHIMHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5ABF6A0", Offset = "0x5ABE8A0", VA = "0x185ABF6A0")]
	public static CAFMMAJMNLD DHNIEKIGEGG(int BFFJHKFEFPP, int GMEHLIHLGEH, ByteString PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5ABF780", Offset = "0x5ABE980", VA = "0x185ABF780")]
	public static CAFMMAJMNLD[] GNDBKBNDOOB(int FMMKLNFMMIP, KAAMMJLINCK IMDAGNMLCEA, ECNCNNBLHJH EMLJOBICHBA, JFPOIAPCMPC FBAEJBINMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5ABF990", Offset = "0x5ABEB90", VA = "0x185ABF990")]
	public static global::BNNACKHHFFC<OCKMNPJBBFI, NJPMIPOHDKP> PPICLLNAIBI(CAFMMAJMNLD LEEEHBCCIGH)
	{
		return default(global::BNNACKHHFFC<OCKMNPJBBFI, NJPMIPOHDKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5ABF560", Offset = "0x5ABE760", VA = "0x185ABF560")]
	[AsyncStateMachine(typeof(MFHOHPHJILG))]
	public static Task<global::LAFJBBFBCGA<bool, HODHNINHENI>> DGCBHJNCMIG(ACMKJNGKBGH KPDGHDGLMHO, NJPMIPOHDKP DIJPFIMLAFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class MOLDCCAMOLJ : PCDAOBCHCHF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface HNKDHPPEHCE
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		IHIGKPLCENK KJPFJANJDCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<ECNCNNBLHJH> KIFFLDOAJPM(CancellationToken NDKAKDJMDIF);

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<JFPOIAPCMPC> BPIBLDBBNNN(CancellationToken NDKAKDJMDIF);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<DILENLPDIOG> HFLJGCAFACP(CancellationToken NDKAKDJMDIF);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct EGBMKHFMMIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder<MOLDCCAMOLJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public DNIANAKBLEJ deps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public ECNCNNBLHJH roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public JFPOIAPCMPC superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public GFGFOPDHAFC.KGIBKDGPJLD cv2StateCreationArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private HNKDHPPEHCE <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CEAB0", Offset = "0x5CDEB0")]
		private TaskAwaiter<ECNCNNBLHJH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CEB10", Offset = "0x5CDF10")]
		private TaskAwaiter<JFPOIAPCMPC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CEB70", Offset = "0x5CDF70")]
		private TaskAwaiter<DILENLPDIOG> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5ABA5F0", Offset = "0x5AB97F0", VA = "0x185ABA5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5ABACA0", Offset = "0x5AB9EA0", VA = "0x185ABACA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly GFGFOPDHAFC HFPEOMICPAM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GFGFOPDHAFC BACMDLCHPKI
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7A4ED0", Offset = "0x7A40D0", VA = "0x1807A4ED0")]
	private MOLDCCAMOLJ(GFGFOPDHAFC HMEMNPBHAHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5ABEC20", Offset = "0x5ABDE20", VA = "0x185ABEC20")]
	[AsyncStateMachine(typeof(EGBMKHFMMIG))]
	public static Task<MOLDCCAMOLJ> MIBBGNPILCF(DNIANAKBLEJ JCHGABJHIIM, GFGFOPDHAFC.KGIBKDGPJLD GJKPFMBPDDL, ECNCNNBLHJH? KGMPBFBAMCF, JFPOIAPCMPC? FBAEJBINMJJ, CancellationToken NDKAKDJMDIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5ABEC00", Offset = "0x5ABDE00", VA = "0x185ABEC00", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class HGJACDFHCLO : BGIOLBIACLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface GAPIFPCCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<PCDAOBCHCHF> COFCDKIBCAE(DNIANAKBLEJ JCHGABJHIIM, GFGFOPDHAFC.KGIBKDGPJLD GJKPFMBPDDL, ECNCNNBLHJH? NPCGGFJJKAB, JFPOIAPCMPC? DJEPPCOCDLD, CancellationToken NDKAKDJMDIF);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		DAHKJHAPHGH APFFNAAGKNB(in DEEEMAJBBGI MMIHGABIFMM, KAAMMJLINCK GHAOEOKBLGC);
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class DLCKEOMOCII : GAPIFPCCBCC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private struct BOIIBGGMIBE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public AsyncTaskMethodBuilder<PCDAOBCHCHF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public DNIANAKBLEJ deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public GFGFOPDHAFC.KGIBKDGPJLD cv2StateCreationArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public ECNCNNBLHJH cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public JFPOIAPCMPC cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CECB0", Offset = "0x5CE0B0")]
			private TaskAwaiter<MOLDCCAMOLJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5AB8EF0", Offset = "0x5AB80F0", VA = "0x185AB8EF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5AB9230", Offset = "0x5AB8430", VA = "0x185AB9230", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public static readonly DLCKEOMOCII OFDKPDDLIJC;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		private DLCKEOMOCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5AB9DF0", Offset = "0x5AB8FF0", VA = "0x185AB9DF0", Slot = "4")]
		[AsyncStateMachine(typeof(BOIIBGGMIBE))]
		public Task<PCDAOBCHCHF> COFCDKIBCAE(DNIANAKBLEJ JCHGABJHIIM, GFGFOPDHAFC.KGIBKDGPJLD GJKPFMBPDDL, ECNCNNBLHJH? NPCGGFJJKAB, JFPOIAPCMPC? DJEPPCOCDLD, CancellationToken NDKAKDJMDIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5AB9D70", Offset = "0x5AB8F70", VA = "0x185AB9D70")]
		public DAHKJHAPHGH APFFNAAGKNB(in DEEEMAJBBGI MMIHGABIFMM, KAAMMJLINCK GHAOEOKBLGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5AB9D70", Offset = "0x5AB8F70", VA = "0x185AB9D70", Slot = "5")]
		private DAHKJHAPHGH NNEOFNLKFGN(in DEEEMAJBBGI MMIHGABIFMM, KAAMMJLINCK GHAOEOKBLGC)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct MJDIDNJLDAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public AsyncTaskMethodBuilder<HGJACDFHCLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public DNIANAKBLEJ deps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public GFGFOPDHAFC.KGIBKDGPJLD cv2StateCreationArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public ECNCNNBLHJH cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public JFPOIAPCMPC cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public DEEEMAJBBGI registry;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public KAAMMJLINCK evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private GAPIFPCCBCC <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CED10", Offset = "0x5CE110")]
		private TaskAwaiter<PCDAOBCHCHF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5ABE640", Offset = "0x5ABD840", VA = "0x185ABE640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5ABEB10", Offset = "0x5ABDD10", VA = "0x185ABEB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly PCDAOBCHCHF OJHOOILNKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly DAHKJHAPHGH AFIJEAFEHOB;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public EKNNEOJNNMP DLPJLKHBAPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5ABBC00", Offset = "0x5ABAE00", VA = "0x185ABBC00", Slot = "4")]
		get
		{
			return default(EKNNEOJNNMP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public MJFBPJOGLCM BFBCFFPHNCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5ABBEA0", Offset = "0x5ABB0A0", VA = "0x185ABBEA0", Slot = "5")]
		get
		{
			return default(MJFBPJOGLCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public DBGAENBEDII BBNHDKGAIKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6F6390", Offset = "0x6F5590", VA = "0x1806F6390", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public DEIBNFAFNGH AAIBGICBHDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x75C710", Offset = "0x75B910", VA = "0x18075C710", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3E54890", Offset = "0x3E53A90", VA = "0x183E54890")]
	private HGJACDFHCLO(PCDAOBCHCHF AENHKHGBEHN, DAHKJHAPHGH LAMGKDOHBEB, DBGAENBEDII NDFDEDCBLIG, DEIBNFAFNGH NJOAKFEKDII, PKBMOOAPHGP LDCCOPNINLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5ABBCC0", Offset = "0x5ABAEC0", VA = "0x185ABBCC0")]
	[AsyncStateMachine(typeof(MJDIDNJLDAD))]
	public static Task<HGJACDFHCLO> MIBBGNPILCF(DNIANAKBLEJ JCHGABJHIIM, DEEEMAJBBGI MMIHGABIFMM, GFGFOPDHAFC.KGIBKDGPJLD GJKPFMBPDDL, KAAMMJLINCK GHAOEOKBLGC, ECNCNNBLHJH? NPCGGFJJKAB, JFPOIAPCMPC? DJEPPCOCDLD, CancellationToken NDKAKDJMDIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5ABBC60", Offset = "0x5ABAE60", VA = "0x185ABBC60", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class NIFIFDPHODO : KEIFMIIGANC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface IJNLJHDKPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<BGIOLBIACLF> LAAIGGOGDMO(DNIANAKBLEJ JCHGABJHIIM, DEEEMAJBBGI MMIHGABIFMM, GFGFOPDHAFC.KGIBKDGPJLD GJKPFMBPDDL, KAAMMJLINCK GHAOEOKBLGC, ECNCNNBLHJH? NPCGGFJJKAB, JFPOIAPCMPC? DJEPPCOCDLD, CancellationToken NDKAKDJMDIF);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class BGKGLGOKKFA : IJNLJHDKPJC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct HHBFOIHBGCO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public AsyncTaskMethodBuilder<BGIOLBIACLF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public DNIANAKBLEJ deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public DEEEMAJBBGI registry;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public GFGFOPDHAFC.KGIBKDGPJLD cv2StateCreationArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public KAAMMJLINCK evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public ECNCNNBLHJH cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public JFPOIAPCMPC cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CEE80", Offset = "0x5CE280")]
			private TaskAwaiter<HGJACDFHCLO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5ABBF00", Offset = "0x5ABB100", VA = "0x185ABBF00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x5ABC300", Offset = "0x5ABB500", VA = "0x185ABC300", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public static readonly BGKGLGOKKFA OFDKPDDLIJC;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		private BGKGLGOKKFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5AB8AB0", Offset = "0x5AB7CB0", VA = "0x185AB8AB0", Slot = "4")]
		[AsyncStateMachine(typeof(HHBFOIHBGCO))]
		public Task<BGIOLBIACLF> LAAIGGOGDMO(DNIANAKBLEJ JCHGABJHIIM, DEEEMAJBBGI MMIHGABIFMM, GFGFOPDHAFC.KGIBKDGPJLD GJKPFMBPDDL, KAAMMJLINCK GHAOEOKBLGC, ECNCNNBLHJH? NPCGGFJJKAB, JFPOIAPCMPC? DJEPPCOCDLD, CancellationToken NDKAKDJMDIF)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct KBGFHBFPBDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public NIFIFDPHODO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public DNIANAKBLEJ deps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public DEEEMAJBBGI registry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public GFGFOPDHAFC.KGIBKDGPJLD cv2StateCreationArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public KAAMMJLINCK evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public ECNCNNBLHJH cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public JFPOIAPCMPC cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CEEE0", Offset = "0x5CE2E0")]
		private TaskAwaiter<BGIOLBIACLF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5ABC760", Offset = "0x5ABB960", VA = "0x185ABC760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x87A5F0", Offset = "0x8797F0", VA = "0x18087A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly IJNLJHDKPJC LDMMCHHPBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly TaskCompletionSource<MFEHAEMCKCJ> ADCPNLJDGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly TaskCompletionSource<MFEHAEMCKCJ> BIEDOGJPLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly CancellationTokenSource POOBMINLPEN;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool JALJLIECFKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x96D880", Offset = "0x96CA80", VA = "0x18096D880", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xEDA1C0", Offset = "0xED93C0", VA = "0x180EDA1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool KKKHNMGIFMF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9B27A0", Offset = "0x9B19A0", VA = "0x1809B27A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2AC2420", Offset = "0x2AC1620", VA = "0x182AC2420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool GAIDLOGGLNE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xD46380", Offset = "0xD45580", VA = "0x180D46380")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x37ADF50", Offset = "0x37AD150", VA = "0x1837ADF50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public BGIOLBIACLF? KEECHBPJBAL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6FB850", Offset = "0x6FAA50", VA = "0x1806FB850", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x814E40", Offset = "0x814040", VA = "0x180814E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5ABF3C0", Offset = "0x5ABE5C0", VA = "0x185ABF3C0")]
	public NIFIFDPHODO(IJNLJHDKPJC JCHGABJHIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5ABF110", Offset = "0x5ABE310", VA = "0x185ABF110", Slot = "7")]
	[AsyncStateMachine(typeof(KBGFHBFPBDE))]
	public Task BILCODGOKCJ(DNIANAKBLEJ JCHGABJHIIM, DEEEMAJBBGI MMIHGABIFMM, GFGFOPDHAFC.KGIBKDGPJLD GJKPFMBPDDL, KAAMMJLINCK GHAOEOKBLGC, ECNCNNBLHJH? NPCGGFJJKAB, JFPOIAPCMPC? DJEPPCOCDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5ABF2D0", Offset = "0x5ABE4D0", VA = "0x185ABF2D0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class ACMKJNGKBGH : IDisposable, ELFLIEDGBMI, JKGLIKEGOEB, EGKNHDEIFON
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public abstract class LCLOCDOBFJO : NOADCICHGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5ABD450", Offset = "0x5ABC650", VA = "0x185ABD450", Slot = "4")]
		public KEIFMIIGANC HBDDACNJPHD(NIFIFDPHODO.IJNLJHDKPJC JCHGABJHIIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void KBFKADJILEC();

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void FKMFNBONPAB();

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void AMAGNEHGEBB();

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		protected LCLOCDOBFJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public readonly struct FDEALNGKJJL : AOEMGIPMAOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly ACMKJNGKBGH OCGIFMNMJPL;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ACMKJNGKBGH KNKHDBNLOOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x75A7C0", Offset = "0x7599C0", VA = "0x18075A7C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7AF920", Offset = "0x7AEB20", VA = "0x1807AF920")]
		public FDEALNGKJJL(ACMKJNGKBGH IKDGOPDIPEN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface NOADCICHGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		KEIFMIIGANC HBDDACNJPHD(NIFIFDPHODO.IJNLJHDKPJC JCHGABJHIIM);

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KBFKADJILEC();

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void FKMFNBONPAB();

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void AMAGNEHGEBB();
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct LAAFPOPDGPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CF2C0", Offset = "0x5CE6C0")]
		public readonly global::MMBGOPJGKAP<OCKMNPJBBFI, CAFMMAJMNLD, ACMKJNGKBGH, EOCBIPMGBHI> DLGMOOCFLIK;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x192FF80", Offset = "0x192F180", VA = "0x18192FF80")]
		internal LAAFPOPDGPG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CF320", Offset = "0x5CE720")] global::MMBGOPJGKAP<OCKMNPJBBFI, CAFMMAJMNLD, ACMKJNGKBGH, EOCBIPMGBHI> IDCNELICAAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public sealed class LIADKMBODEI : EOCBIPMGBHI
	{
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public static readonly LIADKMBODEI OFDKPDDLIJC;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		private LIADKMBODEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x88D170", Offset = "0x88C370", VA = "0x18088D170", Slot = "4")]
		public OCKMNPJBBFI EMCOJBAEGOJ(CAFMMAJMNLD DIJPFIMLAFB)
		{
			return default(OCKMNPJBBFI);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "5")]
		public void MCMKHPPOOBA(ACMKJNGKBGH KPDGHDGLMHO, CAFMMAJMNLD IBKGKDECOEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private struct LHJFGCPCBON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CF380", Offset = "0x5CE780")]
		public global::JGACPCCOPIL<OCKMNPJBBFI, CAFMMAJMNLD, ACMKJNGKBGH, EOCBIPMGBHI> DLGMOOCFLIK;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x37E33B0", Offset = "0x37E25B0", VA = "0x1837E33B0")]
		internal LHJFGCPCBON([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CF3E0", Offset = "0x5CE7E0")] global::JGACPCCOPIL<OCKMNPJBBFI, CAFMMAJMNLD, ACMKJNGKBGH, EOCBIPMGBHI> IDCNELICAAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5ABD8F0", Offset = "0x5ABCAF0", VA = "0x185ABD8F0")]
		public static LHJFGCPCBON ELCFDEFNBDD()
		{
			return default(LHJFGCPCBON);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public readonly struct DOGIHGOEIMP : FELHJHFLFGJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private struct GJCFHODGNJN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CF4C0", Offset = "0x5CE8C0")]
			public AsyncTaskMethodBuilder<global::LAFJBBFBCGA<object, HODHNINHENI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public ACMKJNGKBGH receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public CAFMMAJMNLD action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public DOGIHGOEIMP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CF520", Offset = "0x5CE920")]
			private TaskAwaiter<global::LAFJBBFBCGA<object, HODHNINHENI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5ABB900", Offset = "0x5ABAB00", VA = "0x185ABB900", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5ABBA90", Offset = "0x5ABAC90", VA = "0x185ABBA90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x88D170", Offset = "0x88C370", VA = "0x18088D170", Slot = "4")]
		public global::MPNGGJINIEL<BKANGJDJCKL> JFPJNHFBJGO(ACMKJNGKBGH HHOOFBDANAJ)
		{
			return default(global::MPNGGJINIEL<BKANGJDJCKL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5ABA4A0", Offset = "0x5AB96A0", VA = "0x185ABA4A0", Slot = "5")]
		[AsyncStateMachine(typeof(GJCFHODGNJN))]
		public Task<global::LAFJBBFBCGA<object, HODHNINHENI>> GJKEHKMHBJP(ACMKJNGKBGH HHOOFBDANAJ, CAFMMAJMNLD IBKGKDECOEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5ABA290", Offset = "0x5AB9490", VA = "0x185ABA290", Slot = "6")]
		public CAFMMAJMNLD[] BEKIJCMMIAJ(ACMKJNGKBGH HHOOFBDANAJ)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct FLFNGKNKBJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CF580", Offset = "0x5CE980")]
		public AsyncTaskMethodBuilder<global::LAFJBBFBCGA<bool, HODHNINHENI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public ACMKJNGKBGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public KAAMMJLINCK rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public ECNCNNBLHJH circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public JFPOIAPCMPC superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter<global::LAFJBBFBCGA<bool, HODHNINHENI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5ABACF0", Offset = "0x5AB9EF0", VA = "0x185ABACF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5ABAF00", Offset = "0x5ABA100", VA = "0x185ABAF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct DGPKHODJDBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CF5E0", Offset = "0x5CE9E0")]
		public AsyncTaskMethodBuilder<global::LAFJBBFBCGA<MFEHAEMCKCJ, HODHNINHENI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public ACMKJNGKBGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private TaskAwaiter<global::LAFJBBFBCGA<MFEHAEMCKCJ, HODHNINHENI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5AB9B90", Offset = "0x5AB8D90", VA = "0x185AB9B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5AB9D20", Offset = "0x5AB8F20", VA = "0x185AB9D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct KOMMOMMKGNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CF640", Offset = "0x5CEA40")]
		public AsyncTaskMethodBuilder<global::LAFJBBFBCGA<object, HODHNINHENI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public ACMKJNGKBGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public CAFMMAJMNLD action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private TaskAwaiter<global::LAFJBBFBCGA<object, HODHNINHENI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5ABD260", Offset = "0x5ABC460", VA = "0x185ABD260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5ABD400", Offset = "0x5ABC600", VA = "0x185ABD400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CEF40", Offset = "0x5CE340")]
	private readonly global::MPNGGJINIEL<BKANGJDJCKL> CHEHEDNLIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly LAAFPOPDGPG FPGIPKAGLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly DEEEMAJBBGI MFMPEOPCHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	internal readonly DNIANAKBLEJ ACHHIELFMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	internal readonly GFGFOPDHAFC.KGIBKDGPJLD GCANHDMOEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private BDBKOEJPACP HCPLCBIFPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	internal readonly DEEEMAJBBGI.HOKJCOACKGO GFPLKPJPHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	internal readonly CDDBFBBBDGP BDPPEGNCDHB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public FDEALNGKJJL GEHHAKHJJKK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9A0840", Offset = "0x99FA40", VA = "0x1809A0840")]
		get
		{
			return default(FDEALNGKJJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DEEEMAJBBGI DBJAHJGGGJM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3379360", Offset = "0x3378560", VA = "0x183379360")]
		get
		{
			return default(DEEEMAJBBGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private NOADCICHGKG ODKOLGHOCFO
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5AB77E0", Offset = "0x5AB69E0", VA = "0x185AB77E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public KEIFMIIGANC EACALKEIBCF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6F9880", Offset = "0x6F8A80", VA = "0x1806F9880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x91EA60", Offset = "0x91DC60", VA = "0x18091EA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool JALJLIECFKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xCEBF80", Offset = "0xCEB180", VA = "0x180CEBF80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xFF1BB0", Offset = "0xFF0DB0", VA = "0x180FF1BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private EKNNEOJNNMP? CAHBEOHNMCH
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5AB8230", Offset = "0x5AB7430", VA = "0x185AB8230", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private MJFBPJOGLCM? BHGEHFFFDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5AB84C0", Offset = "0x5AB76C0", VA = "0x185AB84C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public DEIBNFAFNGH? AAIBGICBHDF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5AB83C0", Offset = "0x5AB75C0", VA = "0x185AB83C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public DBGAENBEDII? BBNHDKGAIKA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5AB8440", Offset = "0x5AB7640", VA = "0x185AB8440", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5AB85F0", Offset = "0x5AB77F0", VA = "0x185AB85F0")]
	private ACMKJNGKBGH(DNIANAKBLEJ HJOOFGLHNBG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CEFA0", Offset = "0x5CE3A0")] global::MPNGGJINIEL<BKANGJDJCKL> AMMLAHNGBBA, LAAFPOPDGPG JMMPMBJJNJP, DEEEMAJBBGI MMIHGABIFMM, KEIFMIIGANC FBCDDJGNMEF, in GFGFOPDHAFC.KGIBKDGPJLD AKKNMJKCFEJ, DEEEMAJBBGI.HOKJCOACKGO BICOMHIHKEA, CDDBFBBBDGP PKJCGBCFGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5AB7830", Offset = "0x5AB6A30", VA = "0x185AB7830")]
	public static ACMKJNGKBGH ELCFDEFNBDD(DNIANAKBLEJ JCHGABJHIIM, DEEEMAJBBGI.AIOPBHFIEAI OMPKAADLMOJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CF000", Offset = "0x5CE400")] global::MPNGGJINIEL<BKANGJDJCKL> AMMLAHNGBBA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CF060", Offset = "0x5CE460")] global::MPNGGJINIEL<IPGAKKHFLAO> MKEJAAFDNOA, GMDKLIKFJCL OJNNCAABMHA, MCOHGDMKIFF GDFBOICCPIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5AB78E0", Offset = "0x5AB6AE0", VA = "0x185AB78E0")]
	public static ACMKJNGKBGH ELCFDEFNBDD(DNIANAKBLEJ HJOOFGLHNBG, in DEEEMAJBBGI MMIHGABIFMM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CF0C0", Offset = "0x5CE4C0")] global::MPNGGJINIEL<BKANGJDJCKL> AMMLAHNGBBA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CF120", Offset = "0x5CE520")] global::MPNGGJINIEL<IPGAKKHFLAO> MKEJAAFDNOA, GMDKLIKFJCL OJNNCAABMHA, MCOHGDMKIFF GDFBOICCPIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5AB75F0", Offset = "0x5AB67F0", VA = "0x185AB75F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5AB7D00", Offset = "0x5AB6F00", VA = "0x185AB7D00")]
	[AsyncStateMachine(typeof(FLFNGKNKBJG))]
	public Task<global::LAFJBBFBCGA<bool, HODHNINHENI?>>? FLKNCFJNJKJ(KAAMMJLINCK? IMDAGNMLCEA, ECNCNNBLHJH? EMLJOBICHBA, JFPOIAPCMPC? FBAEJBINMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5AB8090", Offset = "0x5AB7290", VA = "0x185AB8090")]
	[AsyncStateMachine(typeof(DGPKHODJDBK))]
	public Task<global::LAFJBBFBCGA<MFEHAEMCKCJ, HODHNINHENI>> IFHKILOODMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5AB7E80", Offset = "0x5AB7080", VA = "0x185AB7E80")]
	internal void HADEGMICHBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5AB81B0", Offset = "0x5AB73B0", VA = "0x185AB81B0")]
	internal global::FHJHGBHFPAM<CAFMMAJMNLD> IKNLOMDCBFD(in NJPMIPOHDKP LDDNIFDALOG)
	{
		return default(global::FHJHGBHFPAM<CAFMMAJMNLD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5AB8360", Offset = "0x5AB7560", VA = "0x185AB8360")]
	internal bool JHPDJJMKJAK(in NJPMIPOHDKP LDDNIFDALOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5AB74B0", Offset = "0x5AB66B0", VA = "0x185AB74B0")]
	[AsyncStateMachine(typeof(KOMMOMMKGNM))]
	internal Task<global::LAFJBBFBCGA<object, HODHNINHENI>> DGCBHJNCMIG(CAFMMAJMNLD IBKGKDECOEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct CDDBFBBBDGP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct IHMLBPPLHFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public AsyncTaskMethodBuilder<global::LAFJBBFBCGA<object, HODHNINHENI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public CDDBFBBBDGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public CAFMMAJMNLD action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private TaskAwaiter<global::LAFJBBFBCGA<object, HODHNINHENI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5ABC350", Offset = "0x5ABB550", VA = "0x185ABC350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5ABC4F0", Offset = "0x5ABB6F0", VA = "0x185ABC4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct LGFICKBEHLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public AsyncTaskMethodBuilder<global::LAFJBBFBCGA<bool, HODHNINHENI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public KAAMMJLINCK rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public ECNCNNBLHJH circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public JFPOIAPCMPC superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public CDDBFBBBDGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private CAFMMAJMNLD[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private TaskAwaiter<global::LAFJBBFBCGA<object, HODHNINHENI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5ABD570", Offset = "0x5ABC770", VA = "0x185ABD570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5ABD8A0", Offset = "0x5ABCAA0", VA = "0x185ABD8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct DNOLKIJBOKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public AsyncTaskMethodBuilder<global::LAFJBBFBCGA<MFEHAEMCKCJ, HODHNINHENI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public CDDBFBBBDGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private TaskAwaiter<global::LAFJBBFBCGA<object, HODHNINHENI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5AB9FE0", Offset = "0x5AB91E0", VA = "0x185AB9FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5ABA240", Offset = "0x5AB9440", VA = "0x185ABA240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly GMDKLIKFJCL GBLEONIKKIF;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7AF920", Offset = "0x7AEB20", VA = "0x1807AF920")]
	public CDDBFBBBDGP(GMDKLIKFJCL OJNNCAABMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5AB93A0", Offset = "0x5AB85A0", VA = "0x185AB93A0")]
	[AsyncStateMachine(typeof(IHMLBPPLHFD))]
	private Task<global::LAFJBBFBCGA<object, HODHNINHENI>> JJANLECJAOJ(CAFMMAJMNLD IBKGKDECOEG, bool MBMBCHFDDHJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5AB94F0", Offset = "0x5AB86F0", VA = "0x185AB94F0")]
	[AsyncStateMachine(typeof(LGFICKBEHLL))]
	public Task<global::LAFJBBFBCGA<bool, HODHNINHENI>> JMGNDMELOAF(int FMMKLNFMMIP, KAAMMJLINCK IMDAGNMLCEA, ECNCNNBLHJH EMLJOBICHBA, JFPOIAPCMPC FBAEJBINMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5AB9280", Offset = "0x5AB8480", VA = "0x185AB9280")]
	[AsyncStateMachine(typeof(DNOLKIJBOKH))]
	public Task<global::LAFJBBFBCGA<MFEHAEMCKCJ, HODHNINHENI>> DPHICADNPGH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class MOBPAMNINNF : DAHKJHAPHGH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly KNIGGHFLLOP JMIJJOCGDHI;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public KNIGGHFLLOP FNHFALABOGE
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7A4ED0", Offset = "0x7A40D0", VA = "0x1807A4ED0")]
	private MOBPAMNINNF(KNIGGHFLLOP LJHAOAKEMMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5ABEB60", Offset = "0x5ABDD60", VA = "0x185ABEB60")]
	public static MOBPAMNINNF BBCFAILGGHN(in DEEEMAJBBGI MMIHGABIFMM, KAAMMJLINCK GHAOEOKBLGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5ABEBE0", Offset = "0x5ABDDE0", VA = "0x185ABEBE0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface PCDAOBCHCHF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	GFGFOPDHAFC BACMDLCHPKI
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface PANAKDJMKLD
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	Action<PANAKDJMKLD> AHMCGPMFCKM
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FEDDEDGCPBH();

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PJBBPHMBONK(HHFBDBEGDIK KKEGEFOJBBF);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GNOEKBBDMPI(HHFBDBEGDIK KKEGEFOJBBF);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface BGIOLBIACLF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	EKNNEOJNNMP DLPJLKHBAPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	MJFBPJOGLCM BFBCFFPHNCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	DBGAENBEDII BBNHDKGAIKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	DEIBNFAFNGH AAIBGICBHDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface KEIFMIIGANC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	BGIOLBIACLF? KEECHBPJBAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool KKKHNMGIFMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool JALJLIECFKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task BILCODGOKCJ(DNIANAKBLEJ JCHGABJHIIM, DEEEMAJBBGI MMIHGABIFMM, GFGFOPDHAFC.KGIBKDGPJLD GJKPFMBPDDL, KAAMMJLINCK GHAOEOKBLGC, ECNCNNBLHJH? NPCGGFJJKAB, JFPOIAPCMPC? DJEPPCOCDLD);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface AOEMGIPMAOJ
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	ACMKJNGKBGH KNKHDBNLOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class CHFELMIIGFA
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x11536C0", Offset = "0x11528C0", VA = "0x1811536C0")]
	public static BGIOLBIACLF PONIHCNJFEC<TSelf>(this TSelf DIJPFIMLAFB) where TSelf : notnull, AOEMGIPMAOJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1153590", Offset = "0x1152790", VA = "0x181153590")]
	public static KEIFMIIGANC IMJPOBPFDNP<TSelf>(this TSelf DIJPFIMLAFB) where TSelf : notnull, AOEMGIPMAOJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x11535F0", Offset = "0x11527F0", VA = "0x1811535F0")]
	public static bool KFMGKHICCLH<TSelf>(this TSelf DIJPFIMLAFB) where TSelf : notnull, AOEMGIPMAOJ
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface DAHKJHAPHGH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	KNIGGHFLLOP FNHFALABOGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class AHHKANHBKKN : IDisposable, EGKNHDEIFON
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class MBAONOGGMOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public AHHKANHBKKN result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public BLHEIACBFCP legacyCV2Root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CF810", Offset = "0x5CEC10")]
		public Action<EGKNHDEIFON?>? onStateDidInitialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CF870", Offset = "0x5CEC70")]
		public Action<EGKNHDEIFON?>? onStateWillDestroy;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public MBAONOGGMOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5ABD9E0", Offset = "0x5ABCBE0", VA = "0x185ABD9E0")]
		internal void <FromLegacyCV2Root>b__0()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5ABDB00", Offset = "0x5ABCD00", VA = "0x185ABDB00")]
		internal void <FromLegacyCV2Root>b__1()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly BLHEIACBFCP OLDOCLAPMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly Action KOBBAPIOLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly Action LDAPPNKOLFK;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public DBGAENBEDII? BBNHDKGAIKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x75C710", Offset = "0x75B910", VA = "0x18075C710", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7BB010", Offset = "0x7BA210", VA = "0x1807BB010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private PKBMOOAPHGP? OHKONPJMECE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7B43F0", Offset = "0x7B35F0", VA = "0x1807B43F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3E54890", Offset = "0x3E53A90", VA = "0x183E54890")]
	private AHHKANHBKKN(BLHEIACBFCP GDABBFFLHFL, Action DNKPHKONLJB, Action LHDGJJGPDCA, DBGAENBEDII? NEBMDPHJHAJ, PKBMOOAPHGP? HCGOHCHGOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5AB87A0", Offset = "0x5AB79A0", VA = "0x185AB87A0")]
	public static AHHKANHBKKN KPBDPNAGMPP(BLHEIACBFCP GDABBFFLHFL, Action<EGKNHDEIFON> DNKPHKONLJB, Action<EGKNHDEIFON> LHDGJJGPDCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5AB8760", Offset = "0x5AB7960", VA = "0x185AB8760", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class CMNHIHMPIHM
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5AB9760", Offset = "0x5AB8960", VA = "0x185AB9760")]
	public static global::JGACPCCOPIL<OCKMNPJBBFI, CAFMMAJMNLD, ACMKJNGKBGH, EOCBIPMGBHI> NIBGKCNJNIF(this in global::JGACPCCOPIL<OCKMNPJBBFI, CAFMMAJMNLD, ACMKJNGKBGH, EOCBIPMGBHI> PIKOGEFEJJG)
	{
		return default(global::JGACPCCOPIL<OCKMNPJBBFI, CAFMMAJMNLD, ACMKJNGKBGH, EOCBIPMGBHI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface DBGAENBEDII
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IBIADJADAIJ(in Guid GLLFFIFLOAG);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface EGKNHDEIFON
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	DBGAENBEDII? BBNHDKGAIKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface PKBMOOAPHGP
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface DEIBNFAFNGH
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CAFMMAJMNLD[] BEKIJCMMIAJ();
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface AGBJGJLLJFN
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	object EBCMHCLDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	Guid PENGDHINDBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	Guid EOJGBOJCNOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool HDFICJIFKKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	string PALADLMJNAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool HLIMAFLAOLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	int OHPPOFOLCOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	KEMGPCPONLA FKOGGALCFNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	NodeVisualizationKey EGJKFMADELN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	global::MPNGGJINIEL<MDALFJIODBI> KOKBFIDHHDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool KIPIOHPEEFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	Guid NKBLIMFMIJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool PANLOPMMCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool BHDCBPFPGLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool EELOHKGCMAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool LPNPNKNAKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool FBIEIDNIJLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool CHGLLAPHILM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	int AHNPFMOLGLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool CBNHHFPAIPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	bool AOLAOOJKNNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string CIDLKBBCMNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool BGJIFIKPNGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	bool AGMDNHPCFAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	bool OBBNIINONKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool IFAGACKJCHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool DPHPLHHPAHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool MEGFJCIGJAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	MPDEOEGEEIC KIJJFLMPGME
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	HIAGCLNJBPN NELEDPLLGGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool DADOEKMBALO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool MJNKBHHAFIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	NJJLGHIHLHD? PKIEAGICFAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	ADDCDIBDJKJ? EFFNENLOMCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CF8D0", Offset = "0x5CECD0")]
	IEnumerable<EKIIIJIOBCC> JOKAMBLHPNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action KOOJPBMMOAK;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event GMOGOHKCKFP AOLHICIAKBG;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event GPEJDKGBOCL LHCDKFMGNDC;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action HPBMPMINKJD;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<int> AGMDAFJAOBF;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action ONOIBCEPBFK;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DLMJBPBJDDN(string INIOBIJJMJP);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KOAAHJPPJOE(int FMHCCJDJFBA);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void DAHMNDIEKOJ(in MPDEOEGEEIC IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void CCIMDIMBMEJ(in HIAGCLNJBPN IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void HPAKKDPPCHI();

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void OKODBEKMEGB();

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void KALLKIBPMJO();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void GCMMNEBCEKJ();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool CHELOJCOPHN(int LJGFGPLHADF);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void GPECMILCNKA(string KNOPFGAGMCN);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void NGOKEHHAJGO(int GMEHLIHLGEH);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "53")]
	global::FAIKNKAIPLB<MFEHAEMCKCJ> KKPLFNNKJOH(string INIOBIJJMJP);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "54")]
	bool OCAOJCEJMLM(out Guid PFEBBONNCEI);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "55")]
	bool MMKLBJLCBGP(in Guid GLLFFIFLOAG);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void PAKIMOKGMBI();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void HEGENLMAODF(bool FPMKKJKAHFN);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class MDALFJIODBI
{
}
namespace Circuits.All.RecRoom.Integration.Adapter
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public enum NodeVisualizationKey
	{
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		Execution,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		Circuit,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		EventSender,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		EventReceiver,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		EventDefinition,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		Variable,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		ControlPanel,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		InBus,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		OutBus,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		Reroute,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		Comment,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		StudioEventSender,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		Constant,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		DataTable
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class MBGBOHDHIOA : DBGAENBEDII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly PCDAOBCHCHF OJHOOILNKEK;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7A4ED0", Offset = "0x7A40D0", VA = "0x1807A4ED0")]
	public MBGBOHDHIOA(PCDAOBCHCHF AENHKHGBEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5ABDB80", Offset = "0x5ABCD80", VA = "0x185ABDB80")]
	public bool IBIADJADAIJ(in Guid GLLFFIFLOAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5ABDB80", Offset = "0x5ABCD80", VA = "0x185ABDB80", Slot = "4")]
	private bool OJAJKNFOALM(in Guid GLLFFIFLOAG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public sealed class FGOOMGFDGJO : PKBMOOAPHGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly PCDAOBCHCHF OJHOOILNKEK;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7A4ED0", Offset = "0x7A40D0", VA = "0x1807A4ED0")]
	public FGOOMGFDGJO(PCDAOBCHCHF AENHKHGBEHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class MCGECNINFGJ : DEIBNFAFNGH
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public interface NEFDHCLEIOG
	{
		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		int BDPAIGBIOOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly NEFDHCLEIOG LDMMCHHPBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly PCDAOBCHCHF OJHOOILNKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly DAHKJHAPHGH AFIJEAFEHOB;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x82BD80", Offset = "0x82AF80", VA = "0x18082BD80")]
	public MCGECNINFGJ(NEFDHCLEIOG JCHGABJHIIM, PCDAOBCHCHF AENHKHGBEHN, DAHKJHAPHGH LAMGKDOHBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5ABDC10", Offset = "0x5ABCE10", VA = "0x185ABDC10", Slot = "4")]
	public CAFMMAJMNLD[] BEKIJCMMIAJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate void GMOGOHKCKFP(in MPDEOEGEEIC FJDPKNPNDDO);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public delegate void GPEJDKGBOCL(in HIAGCLNJBPN CPOKLKIGKAG);
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class LPOMONEGHIG
{
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5ABD9A0", Offset = "0x5ABCBA0", VA = "0x185ABD9A0")]
	internal static bool IBIADJADAIJ(this GFGFOPDHAFC HMEMNPBHAHB, in Guid GLLFFIFLOAG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public sealed class AJANDFPBEOC : DBGAENBEDII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private readonly GFGFOPDHAFC HFPEOMICPAM;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7A4ED0", Offset = "0x7A40D0", VA = "0x1807A4ED0")]
	public AJANDFPBEOC(GFGFOPDHAFC HMEMNPBHAHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5AB8A10", Offset = "0x5AB7C10", VA = "0x185AB8A10")]
	public bool IBIADJADAIJ(in Guid GLLFFIFLOAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5AB8A10", Offset = "0x5AB7C10", VA = "0x185AB8A10", Slot = "4")]
	private bool OJAJKNFOALM(in Guid GLLFFIFLOAG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public sealed class HDPCCALDDFH : PKBMOOAPHGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private readonly GFGFOPDHAFC HFPEOMICPAM;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7A4ED0", Offset = "0x7A40D0", VA = "0x1807A4ED0")]
	public HDPCCALDDFH(GFGFOPDHAFC HMEMNPBHAHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class LBHDDOOHOKM<TNode> : AGBJGJLLJFN where TNode : EKIIIJIOBCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	[CompilerGenerated]
	private Action<int> PHGIDDHEMFK;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	protected TNode IHBCENOMMLH
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public object EBCMHCLDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x892030", Offset = "0x891230", VA = "0x180892030", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public Guid PENGDHINDBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7BA0", Offset = "0x3BD6DA0", VA = "0x183BD7BA0", Slot = "5")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public Guid EOJGBOJCNOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7DE0", Offset = "0x3BD6FE0", VA = "0x183BD7DE0", Slot = "6")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public virtual string PALADLMJNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "67")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6FFB00", Offset = "0x6FED00", VA = "0x1806FFB00", Slot = "68")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool HDFICJIFKKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7AF0", Offset = "0x3BD6CF0", VA = "0x183BD7AF0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public virtual bool HLIMAFLAOLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7004F0", Offset = "0x6FF6F0", VA = "0x1807004F0", Slot = "69")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public int OHPPOFOLCOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7B70", Offset = "0x3BD6D70", VA = "0x183BD7B70", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public KEMGPCPONLA FKOGGALCFNB
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7B30", Offset = "0x3BD6D30", VA = "0x183BD7B30", Slot = "13")]
		get
		{
			return default(KEMGPCPONLA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public virtual NodeVisualizationKey EGJKFMADELN
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6F8490", Offset = "0x6F7690", VA = "0x1806F8490", Slot = "72")]
		get
		{
			return default(NodeVisualizationKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public global::MPNGGJINIEL<MDALFJIODBI> KOKBFIDHHDL
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6FB720", Offset = "0x6FA920", VA = "0x1806FB720", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(global::MPNGGJINIEL<MDALFJIODBI>);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4A0", Offset = "0x6FA6A0", VA = "0x1806FB4A0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public virtual bool KIPIOHPEEFG
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0", Slot = "73")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public virtual Guid NKBLIMFMIJH
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7BE0", Offset = "0x3BD6DE0", VA = "0x183BD7BE0", Slot = "74")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public virtual bool PANLOPMMCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0", Slot = "75")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public virtual bool BHDCBPFPGLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0", Slot = "76")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool EELOHKGCMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2132030", Offset = "0x2131230", VA = "0x182132030", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool LPNPNKNAKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2131FF0", Offset = "0x21311F0", VA = "0x182131FF0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public virtual bool FBIEIDNIJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0", Slot = "77")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool CHGLLAPHILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2132070", Offset = "0x2131270", VA = "0x182132070", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int AHNPFMOLGLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7DB0", Offset = "0x3BD6FB0", VA = "0x183BD7DB0", Slot = "24")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool CBNHHFPAIPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7D00", Offset = "0x3BD6F00", VA = "0x183BD7D00", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool AOLAOOJKNNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7CB0", Offset = "0x3BD6EB0", VA = "0x183BD7CB0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public string CIDLKBBCMNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7C40", Offset = "0x3BD6E40", VA = "0x183BD7C40", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public virtual bool BGJIFIKPNGM
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0", Slot = "78")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool AGMDNHPCFAK
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7AB0", Offset = "0x3BD6CB0", VA = "0x183BD7AB0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool OBBNIINONKP
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9F78A0", Offset = "0x9F6AA0", VA = "0x1809F78A0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9F78C0", Offset = "0x9F6AC0", VA = "0x1809F78C0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public virtual bool IFAGACKJCHD
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0", Slot = "79")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual bool DPHPLHHPAHE
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7A70", Offset = "0x3BD6C70", VA = "0x183BD7A70", Slot = "80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public bool MEGFJCIGJAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7C70", Offset = "0x3BD6E70", VA = "0x183BD7C70", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public MPDEOEGEEIC KIJJFLMPGME
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7D30", Offset = "0x3BD6F30", VA = "0x183BD7D30", Slot = "34")]
		get
		{
			return default(MPDEOEGEEIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public HIAGCLNJBPN NELEDPLLGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7D70", Offset = "0x3BD6F70", VA = "0x183BD7D70", Slot = "36")]
		get
		{
			return default(HIAGCLNJBPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public virtual bool DADOEKMBALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0", Slot = "94")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public virtual bool MJNKBHHAFIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0", Slot = "95")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public virtual NJJLGHIHLHD? PKIEAGICFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x6F8490", Offset = "0x6F7690", VA = "0x1806F8490", Slot = "96")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public virtual ADDCDIBDJKJ? EFFNENLOMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x6F8490", Offset = "0x6F7690", VA = "0x1806F8490", Slot = "97")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5CF970", Offset = "0x5CED70")]
	public virtual IEnumerable<EKIIIJIOBCC> JOKAMBLHPNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6F8490", Offset = "0x6F7690", VA = "0x1806F8490", Slot = "98")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action KOOJPBMMOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x3BD6F90", Offset = "0x3BD6190", VA = "0x183BD6F90", Slot = "41")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3BD6DB0", Offset = "0x3BD5FB0", VA = "0x183BD6DB0", Slot = "42")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event GMOGOHKCKFP AOLHICIAKBG
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x3BD6EA0", Offset = "0x3BD60A0", VA = "0x183BD6EA0", Slot = "43")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7250", Offset = "0x3BD6450", VA = "0x183BD7250", Slot = "44")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event GPEJDKGBOCL LHCDKFMGNDC
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3BD66E0", Offset = "0x3BD58E0", VA = "0x183BD66E0", Slot = "45")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3BD6AA0", Offset = "0x3BD5CA0", VA = "0x183BD6AA0", Slot = "46")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action HPBMPMINKJD
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3BD71A0", Offset = "0x3BD63A0", VA = "0x183BD71A0", Slot = "47")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7040", Offset = "0x3BD6240", VA = "0x183BD7040", Slot = "48")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public virtual event Action<int> AGMDAFJAOBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7340", Offset = "0x3BD6540", VA = "0x183BD7340", Slot = "84")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7660", Offset = "0x3BD6860", VA = "0x183BD7660", Slot = "85")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action ONOIBCEPBFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x3BD69B0", Offset = "0x3BD5BB0", VA = "0x183BD69B0", Slot = "51")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x3BD6840", Offset = "0x3BD5A40", VA = "0x183BD6840", Slot = "52")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3BD77A0", Offset = "0x3BD69A0", VA = "0x183BD77A0")]
	public LBHDDOOHOKM(TNode KNBPIEINLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3BD6A60", Offset = "0x3BD5C60", VA = "0x183BD6A60", Slot = "70")]
	public virtual void DLMJBPBJDDN(string INIOBIJJMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3BD7160", Offset = "0x3BD6360", VA = "0x183BD7160", Slot = "71")]
	public virtual void KOAAHJPPJOE(int FMHCCJDJFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3BD67F0", Offset = "0x3BD59F0", VA = "0x183BD67F0")]
	public void DAHMNDIEKOJ(in MPDEOEGEEIC IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3BD6690", Offset = "0x3BD5890", VA = "0x183BD6690")]
	public void CCIMDIMBMEJ(in HIAGCLNJBPN IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3BD6F50", Offset = "0x3BD6150", VA = "0x183BD6F50", Slot = "81")]
	public virtual void HPAKKDPPCHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "82")]
	public virtual void OKODBEKMEGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "83")]
	public virtual void KALLKIBPMJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x907690", Offset = "0x906890", VA = "0x180907690")]
	protected void GNNJGPMKJBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0xDCA8E0", Offset = "0xDC9AE0", VA = "0x180DCA8E0")]
	protected void FAGLLCEHFMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x3BD7410", Offset = "0x3BD6610", VA = "0x183BD7410")]
	private void OBPFAFIALIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3BD6B50", Offset = "0x3BD5D50", VA = "0x183BD6B50", Slot = "86")]
	public virtual void GCMMNEBCEKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3BD67D0", Offset = "0x3BD59D0", VA = "0x183BD67D0")]
	private void CMEGLGJEDBF(in MPDEOEGEEIC INLGLHIPOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3BD6670", Offset = "0x3BD5870", VA = "0x183BD6670")]
	private void BKIAGGKIFLF(in HIAGCLNJBPN HEGBBJCMANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3BD73C0", Offset = "0x3BD65C0", VA = "0x183BD73C0")]
	private void OBJBNALDCGG(int GMEHLIHLGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3BD68F0", Offset = "0x3BD5AF0", VA = "0x183BD68F0")]
	private void DKONFINALBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3BD6790", Offset = "0x3BD5990", VA = "0x183BD6790", Slot = "87")]
	public virtual bool CHELOJCOPHN(int LJGFGPLHADF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3BD6E60", Offset = "0x3BD6060", VA = "0x183BD6E60", Slot = "88")]
	public virtual void GPECMILCNKA(string KNOPFGAGMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3BD7380", Offset = "0x3BD6580", VA = "0x183BD7380", Slot = "89")]
	public virtual void NGOKEHHAJGO(int GMEHLIHLGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3BD76E0", Offset = "0x3BD68E0", VA = "0x183BD76E0", Slot = "90")]
	public virtual IEnumerable<CAFMMAJMNLD> PMEEFOMNLEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3BD70F0", Offset = "0x3BD62F0", VA = "0x183BD70F0", Slot = "57")]
	public global::FAIKNKAIPLB<MFEHAEMCKCJ> KKPLFNNKJOH(string INIOBIJJMJP)
	{
		return default(global::FAIKNKAIPLB<MFEHAEMCKCJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x3BD74E0", Offset = "0x3BD66E0", VA = "0x183BD74E0", Slot = "58")]
	public bool OCAOJCEJMLM(out Guid PFEBBONNCEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x3BD7300", Offset = "0x3BD6500", VA = "0x183BD7300", Slot = "91")]
	public virtual bool MMKLBJLCBGP(in Guid GLLFFIFLOAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x3BD76A0", Offset = "0x3BD68A0", VA = "0x183BD76A0", Slot = "92")]
	public virtual void PAKIMOKGMBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "93")]
	public virtual void HEGENLMAODF(bool FPMKKJKAHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x2391880", Offset = "0x2390A80", VA = "0x182391880", Slot = "35")]
	private void KGOJNFNEJBA(in MPDEOEGEEIC IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3BD6640", Offset = "0x3BD5840", VA = "0x183BD6640", Slot = "37")]
	private void BJBFOAAIGCO(in HIAGCLNJBPN IPMIIEAGJKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public abstract class MHAOPJENNEB : DNIANAKBLEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public HGJACDFHCLO.GAPIFPCCBCC IKOMMDAJGCG
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5ABE5E0", Offset = "0x5ABD7E0", VA = "0x185ABE5E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public NIFIFDPHODO.IJNLJHDKPJC AJBAPPHKLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x5ABE520", Offset = "0x5ABD720", VA = "0x185ABE520", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public abstract ACMKJNGKBGH.NOADCICHGKG LBMBPGCNOOL
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public abstract MOLDCCAMOLJ.HNKDHPPEHCE KCNAPBALABP
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public abstract MCGECNINFGJ.NEFDHCLEIOG INODLHDLNOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public EOCBIPMGBHI ANPMIEHIEFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5ABE580", Offset = "0x5ABD780", VA = "0x185ABE580", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	protected MHAOPJENNEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public sealed class GFCDGMLFNHO : FIEBADPDMMN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct BIFKLJODILL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public AsyncTaskMethodBuilder<global::LAFJBBFBCGA<object, HODHNINHENI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public GFCDGMLFNHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public CAFMMAJMNLD action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private TaskAwaiter<global::LAFJBBFBCGA<object, HODHNINHENI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x5AB8CE0", Offset = "0x5AB7EE0", VA = "0x185AB8CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x5AB8EA0", Offset = "0x5AB80A0", VA = "0x185AB8EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct OMLGKMNLOGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public AsyncTaskMethodBuilder<global::LAFJBBFBCGA<JHFMIMDLHNN, HODHNINHENI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public GFCDGMLFNHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public IReadOnlyList<CAFMMAJMNLD> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private TaskAwaiter<global::LAFJBBFBCGA<object, HODHNINHENI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5ABFDA0", Offset = "0x5ABEFA0", VA = "0x185ABFDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5AC0170", Offset = "0x5ABF370", VA = "0x185AC0170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly GMDKLIKFJCL GBLEONIKKIF;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7A4ED0", Offset = "0x7A40D0", VA = "0x1807A4ED0")]
	public GFCDGMLFNHO(GMDKLIKFJCL OJNNCAABMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB7B0", Offset = "0x5ABA9B0", VA = "0x185ABB7B0")]
	[AsyncStateMachine(typeof(BIFKLJODILL))]
	private Task<global::LAFJBBFBCGA<object, HODHNINHENI>> JJANLECJAOJ(CAFMMAJMNLD IBKGKDECOEG, bool MBMBCHFDDHJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB660", Offset = "0x5ABA860", VA = "0x185ABB660", Slot = "4")]
	[AsyncStateMachine(typeof(OMLGKMNLOGG))]
	public Task<global::LAFJBBFBCGA<JHFMIMDLHNN, HODHNINHENI>> CDFDCOHFBDK(IReadOnlyList<CAFMMAJMNLD> KIFOHHMNMEP, bool MBMBCHFDDHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct BDBKOEJPACP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	internal global::HGBECKJBNCD<NJPMIPOHDKP, CAFMMAJMNLD, JFPMHDCMHIL> LHEMLAJENLD;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x192FF80", Offset = "0x192F180", VA = "0x18192FF80")]
	private BDBKOEJPACP(in global::HGBECKJBNCD<NJPMIPOHDKP, CAFMMAJMNLD, JFPMHDCMHIL> CPPFECOKKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5AB8A50", Offset = "0x5AB7C50", VA = "0x185AB8A50")]
	public static BDBKOEJPACP ELCFDEFNBDD()
	{
		return default(BDBKOEJPACP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class ILDDHPHFPBA
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85CB60", VA = "0x18085D960")]
	public static global::HGBECKJBNCD<NJPMIPOHDKP, CAFMMAJMNLD, JFPMHDCMHIL> DPPLJMJHLNN(this ref BDBKOEJPACP DIJPFIMLAFB)
	{
		return default(global::HGBECKJBNCD<NJPMIPOHDKP, CAFMMAJMNLD, JFPMHDCMHIL>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct JFPMHDCMHIL : GIFEODJLPKP
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8D42C0", Offset = "0x8D34C0", VA = "0x1808D42C0")]
	public int KEPLACBBJLM(in NJPMIPOHDKP MFDAGLBPHAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5ABC540", Offset = "0x5ABB740", VA = "0x185ABC540", Slot = "5")]
	public CAFMMAJMNLD HELFLMLBJOA(NJPMIPOHDKP[] HENKJBJLEIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x8D42C0", Offset = "0x8D34C0", VA = "0x1808D42C0", Slot = "4")]
	private int BIOKIBPMFGA(in NJPMIPOHDKP MFDAGLBPHAI)
	{
		return default(int);
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

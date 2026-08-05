using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0x88DF140", Offset = "0x88DD740", VA = "0x1888DF140")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD1940", Offset = "0xACFF40", VA = "0x180AD1940")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Preferences_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x88E12F0", Offset = "0x88DF8F0", VA = "0x1888E12F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x29CB0D0", Offset = "0x29C96D0", VA = "0x1829CB0D0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum JDPHJKOPAGO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class KIIGHHFFHPA
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal delegate void HJFNGOHFFDD(BOKHLEOMJIO CHKLIDOHCMP);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x88DE2B0", Offset = "0x88DC8B0", VA = "0x1888DE2B0")]
	private static void JHEIAMFFCFG(BOKHLEOMJIO CHKLIDOHCMP, HJFNGOHFFDD BCEGKBFJGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x88DE150", Offset = "0x88DC750", VA = "0x1888DE150")]
	public static bool FFHONJKFBDC(this BOKHLEOMJIO CHKLIDOHCMP, string JKLGGALPDGD, [Optional] HJFNGOHFFDD BCEGKBFJGDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x88DDD70", Offset = "0x88DC370", VA = "0x1888DDD70")]
	public static KLFJAMDAPLK BJMHADNKHAM(this BOKHLEOMJIO CHKLIDOHCMP, string JKLGGALPDGD, string KOPHBHGIACG, [Optional] HJFNGOHFFDD BCEGKBFJGDE)
	{
		return default(KLFJAMDAPLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x88DE010", Offset = "0x88DC610", VA = "0x1888DE010")]
	public static KLFJAMDAPLK FACAKCCCOOJ(this BOKHLEOMJIO CHKLIDOHCMP, string JKLGGALPDGD, int KOPHBHGIACG, [Optional] HJFNGOHFFDD BCEGKBFJGDE)
	{
		return default(KLFJAMDAPLK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x88DDEC0", Offset = "0x88DC4C0", VA = "0x1888DDEC0")]
	public static KLFJAMDAPLK BPJMPCOBFKE(this BOKHLEOMJIO CHKLIDOHCMP, string JKLGGALPDGD, bool KOPHBHGIACG, [Optional] HJFNGOHFFDD BCEGKBFJGDE)
	{
		return default(KLFJAMDAPLK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x88DDC20", Offset = "0x88DC220", VA = "0x1888DDC20")]
	public static KLFJAMDAPLK BAGJPHIFNHC(this BOKHLEOMJIO CHKLIDOHCMP, string JKLGGALPDGD, float KOPHBHGIACG, [Optional] HJFNGOHFFDD BCEGKBFJGDE)
	{
		return default(KLFJAMDAPLK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x88DDAB0", Offset = "0x88DC0B0", VA = "0x1888DDAB0")]
	public static KLFJAMDAPLK ACKNNLAMCDG(this BOKHLEOMJIO CHKLIDOHCMP, string JKLGGALPDGD, DateTime KOPHBHGIACG, [Optional] HJFNGOHFFDD BCEGKBFJGDE)
	{
		return default(KLFJAMDAPLK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x88DD970", Offset = "0x88DBF70", VA = "0x1888DD970")]
	public static KLFJAMDAPLK ABBFMJMGHPN(this BOKHLEOMJIO CHKLIDOHCMP, string JKLGGALPDGD, long KOPHBHGIACG, [Optional] HJFNGOHFFDD BCEGKBFJGDE)
	{
		return default(KLFJAMDAPLK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class PKOHIIBFFOC : NPHIIEEHGEM, BOKHLEOMJIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly KAPEGBJLOBH KPAHJHHMCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, byte> LDPMEPILKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private Dictionary<string, string> EFILHINOLDM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool NMKMFLCMAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> KIBLGLMNKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x88DF850", Offset = "0x88DDE50", VA = "0x1888DF850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action LIBKCLHNBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x88E1160", Offset = "0x88DF760", VA = "0x1888E1160")]
	[UnityEngine.Scripting.Preserve]
	public PKOHIIBFFOC([EDHLHMEHMKO(null)] KAPEGBJLOBH KPAHJHHMCCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "8")]
	public void LLCOMIDCGPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x88DF9D0", Offset = "0x88DDFD0", VA = "0x1888DF9D0")]
	private DirectoryInfo GCKICOBDBEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x88DFC20", Offset = "0x88DE220", VA = "0x1888DFC20", Slot = "6")]
	public Task ILHOLEIIFAJ(long FOOADKCMEKE, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x88DF890", Offset = "0x88DDE90", VA = "0x1888DF890", Slot = "14")]
	public float DMBOAIOMFIE(string HAELBKGFDIJ, float APJDJFMLEAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x88DFCB0", Offset = "0x88DE2B0", VA = "0x1888DFCB0", Slot = "13")]
	public void ILNOIDENCNB(string HAELBKGFDIJ, bool KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x88DF900", Offset = "0x88DDF00", VA = "0x1888DF900", Slot = "12")]
	public bool FJBICNAHDCK(string HAELBKGFDIJ, bool APJDJFMLEAP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x88DF7E0", Offset = "0x88DDDE0", VA = "0x1888DF7E0", Slot = "10")]
	public int BFKBMPCOKDL(string HAELBKGFDIJ, int APJDJFMLEAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x88DFD20", Offset = "0x88DE320", VA = "0x1888DFD20", Slot = "18")]
	public DateTime JOCJLJKBFHK(string JKLGGALPDGD, [Optional] DateTime APJDJFMLEAP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x88DFBB0", Offset = "0x88DE1B0", VA = "0x1888DFBB0", Slot = "19")]
	public void ILHHMCHHCML(string HAELBKGFDIJ, DateTime KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x88DFB40", Offset = "0x88DE140", VA = "0x1888DFB40", Slot = "15")]
	public void IAMKLGPLLOI(string HAELBKGFDIJ, float KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x88DFE90", Offset = "0x88DE490", VA = "0x1888DFE90", Slot = "11")]
	public void KJJMJGDKFEK(string HAELBKGFDIJ, int KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x88E0B00", Offset = "0x88DF100", VA = "0x1888E0B00", Slot = "20")]
	public long MMOPFEFLEPC(string JKLGGALPDGD, long APJDJFMLEAP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x88DFF00", Offset = "0x88DE500", VA = "0x1888DFF00", Slot = "21")]
	public void KKCAEFCAMNK(string JKLGGALPDGD, long KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3BD89D0", Offset = "0x3BD6FD0", VA = "0x183BD89D0", Slot = "22")]
	public T PMDJEGBDNKF<T>(string JKLGGALPDGD, T APJDJFMLEAP, DBKDDFMBAOI<T> ANLGJMCLLOP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3F46B00", Offset = "0x3F45100", VA = "0x183F46B00", Slot = "23")]
	public void JKDCNDNJJCM<T>(string JKLGGALPDGD, T KOPHBHGIACG, DBKDDFMBAOI<T> ANLGJMCLLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x88E0B70", Offset = "0x88DF170", VA = "0x1888E0B70", Slot = "16")]
	public string NDDCEMAKOME(string HAELBKGFDIJ, string APJDJFMLEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x88DFAD0", Offset = "0x88DE0D0", VA = "0x1888DFAD0", Slot = "17")]
	public void HADACJCHHDJ(string HAELBKGFDIJ, string KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x88DF600", Offset = "0x88DDC00", VA = "0x1888DF600", Slot = "24")]
	public void ACDAGEGBLDK(string HAELBKGFDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x88DF750", Offset = "0x88DDD50", VA = "0x1888DF750", Slot = "9")]
	public bool BFGOHODHBAI(string HAELBKGFDIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x88E0E20", Offset = "0x88DF420", VA = "0x1888E0E20", Slot = "25")]
	public Task OJCKECCIJKA(CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x88E0740", Offset = "0x88DED40", VA = "0x1888E0740")]
	private void LCPGNBCMBBB(DirectoryInfo DCKGCFHDIAD, string AMLNFFJJBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x88E0C20", Offset = "0x88DF220", VA = "0x1888E0C20")]
	private static string NEFNLKPAMNM(string HAELBKGFDIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x88DFD90", Offset = "0x88DE390", VA = "0x1888DFD90")]
	private static string KINEEIDGIOO(byte[] EIJIDGHNNNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3F99F60", Offset = "0x3F98560", VA = "0x183F99F60")]
	private T HBAOOBIPNDD<T>(string JKLGGALPDGD, T APJDJFMLEAP, [Optional] DBKDDFMBAOI<T> JBNDOAEEELB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3F9B0B0", Offset = "0x3F996B0", VA = "0x183F9B0B0")]
	private void IAMMACFOCIM<T>(string JKLGGALPDGD, T KOPHBHGIACG, [Optional] DBKDDFMBAOI<T> JBNDOAEEELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x88DFF70", Offset = "0x88DE570", VA = "0x1888DFF70")]
	private Dictionary<string, string> KLOHNINEKPD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class CAOPHIOKMFE
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x88D8030", Offset = "0x88D6630", VA = "0x1888D8030")]
	[EGNICHGEFDG.KHJDAJHJKCM]
	internal static void FBMOEFONPBI(NMNJFHODGJA JBBCAANONNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class BAGMIMAMMLC : FHGLELHGIKK
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x88D7EC0", Offset = "0x88D64C0", VA = "0x1888D7EC0")]
	[UnityEngine.Scripting.Preserve]
	public BAGMIMAMMLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class FHGLELHGIKK : NPHIIEEHGEM, BOKHLEOMJIO, PAOIJILPCHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Dictionary<string, object> DBAPBKILOEM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NMKMFLCMAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action LIBKCLHNBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "8")]
	public void LLCOMIDCGPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x88DC530", Offset = "0x88DAB30", VA = "0x1888DC530", Slot = "6")]
	public Task ILHOLEIIFAJ(long FOOADKCMEKE, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x88DC290", Offset = "0x88DA890", VA = "0x1888DC290", Slot = "9")]
	public bool BFGOHODHBAI(string JKLGGALPDGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x88DC2F0", Offset = "0x88DA8F0", VA = "0x1888DC2F0", Slot = "10")]
	public int BFKBMPCOKDL(string JKLGGALPDGD, int APJDJFMLEAP = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x88DC680", Offset = "0x88DAC80", VA = "0x1888DC680", Slot = "11")]
	public void KJJMJGDKFEK(string JKLGGALPDGD, int KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x88DC3B0", Offset = "0x88DA9B0", VA = "0x1888DC3B0", Slot = "12")]
	public bool FJBICNAHDCK(string JKLGGALPDGD, bool APJDJFMLEAP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x88DC5C0", Offset = "0x88DABC0", VA = "0x1888DC5C0", Slot = "13")]
	public void ILNOIDENCNB(string JKLGGALPDGD, bool KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x88DC350", Offset = "0x88DA950", VA = "0x1888DC350", Slot = "14")]
	public float DMBOAIOMFIE(string JKLGGALPDGD, float APJDJFMLEAP = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x88DC470", Offset = "0x88DAA70", VA = "0x1888DC470", Slot = "15")]
	public void IAMKLGPLLOI(string JKLGGALPDGD, float KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x88DC7A0", Offset = "0x88DADA0", VA = "0x1888DC7A0", Slot = "16")]
	public string NDDCEMAKOME(string JKLGGALPDGD, [Optional] string APJDJFMLEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x88DC410", Offset = "0x88DAA10", VA = "0x1888DC410", Slot = "17")]
	public void HADACJCHHDJ(string JKLGGALPDGD, string KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x88DC620", Offset = "0x88DAC20", VA = "0x1888DC620", Slot = "18")]
	public DateTime JOCJLJKBFHK(string JKLGGALPDGD, [Optional] DateTime APJDJFMLEAP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x88DC4D0", Offset = "0x88DAAD0", VA = "0x1888DC4D0", Slot = "19")]
	public void ILHHMCHHCML(string JKLGGALPDGD, DateTime KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x88DC740", Offset = "0x88DAD40", VA = "0x1888DC740", Slot = "20")]
	public long MMOPFEFLEPC(string JKLGGALPDGD, long APJDJFMLEAP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x88DC6E0", Offset = "0x88DACE0", VA = "0x1888DC6E0", Slot = "21")]
	public void KKCAEFCAMNK(string JKLGGALPDGD, long KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1170", Offset = "0x3DBF770", VA = "0x183DC1170", Slot = "22")]
	public T PMDJEGBDNKF<T>(string JKLGGALPDGD, T APJDJFMLEAP, DBKDDFMBAOI<T> ANLGJMCLLOP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3DC10D0", Offset = "0x3DBF6D0", VA = "0x183DC10D0", Slot = "23")]
	public void JKDCNDNJJCM<T>(string JKLGGALPDGD, T KOPHBHGIACG, DBKDDFMBAOI<T> ANLGJMCLLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3DC03A0", Offset = "0x3DBE9A0", VA = "0x183DC03A0")]
	public T HBAOOBIPNDD<T>(string JKLGGALPDGD, T APJDJFMLEAP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3DC0BE0", Offset = "0x3DBF1E0", VA = "0x183DC0BE0")]
	public void IAMMACFOCIM<T>(string JKLGGALPDGD, T KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x88DC230", Offset = "0x88DA830", VA = "0x1888DC230", Slot = "24")]
	public void ACDAGEGBLDK(string JKLGGALPDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x88DC800", Offset = "0x88DAE00", VA = "0x1888DC800", Slot = "25")]
	public Task OJCKECCIJKA(CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x88D7EC0", Offset = "0x88D64C0", VA = "0x1888D7EC0")]
	public FHGLELHGIKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class KIANFPKACOI<TParent> where TParent : BOKHLEOMJIO
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly HashSet<KIANFPKACOI<TParent>> MAEOLJHBOKB;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x567A0C0", Offset = "0x56786C0", VA = "0x18567A0C0")]
	protected KIANFPKACOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void ELFNJAKNOMA();

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void MKNFNMCLCOK(string HAELBKGFDIJ);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5679D50", Offset = "0x5678350", VA = "0x185679D50")]
	public static void JHDMADJHJGM(string HAELBKGFDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5679B10", Offset = "0x5678110", VA = "0x185679B10")]
	public static void ANIOEBIJDKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class IOBONMDOKGL<TParent, TValue> : KIANFPKACOI<TParent> where TParent : BOKHLEOMJIO
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly IOBONMDOKGL<TParent, TValue> DKABDBMACEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Dictionary<string, TValue> FCBJBEFIDFH;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x52A74D0", Offset = "0x52A5AD0", VA = "0x1852A74D0")]
	public bool DCJACLLMOIN(string KAIPGEJNEGO, [Out] TValue NOHACJENFBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x52A7510", Offset = "0x52A5B10", VA = "0x1852A7510")]
	public void OCBBKKJMNED(string KAIPGEJNEGO, TValue KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4AFF960", Offset = "0x4AFDF60", VA = "0x184AFF960", Slot = "4")]
	protected override void ELFNJAKNOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x524B200", Offset = "0x5249800", VA = "0x18524B200", Slot = "5")]
	protected override void MKNFNMCLCOK(string KAIPGEJNEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x52A7740", Offset = "0x52A5D40", VA = "0x1852A7740")]
	public IOBONMDOKGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BOKHLEOMJIO
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NMKMFLCMAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LLCOMIDCGPM();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BFGOHODHBAI(string JKLGGALPDGD);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int BFKBMPCOKDL(string JKLGGALPDGD, int APJDJFMLEAP = 0);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KJJMJGDKFEK(string JKLGGALPDGD, int KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FJBICNAHDCK(string JKLGGALPDGD, bool APJDJFMLEAP = false);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ILNOIDENCNB(string JKLGGALPDGD, bool KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float DMBOAIOMFIE(string JKLGGALPDGD, float APJDJFMLEAP = 0f);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IAMKLGPLLOI(string JKLGGALPDGD, float KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string NDDCEMAKOME(string JKLGGALPDGD, [Optional] string APJDJFMLEAP);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HADACJCHHDJ(string JKLGGALPDGD, string KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime JOCJLJKBFHK(string JKLGGALPDGD, [Optional] DateTime LPBIHAPMHPB);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ILHHMCHHCML(string JKLGGALPDGD, DateTime LPBIHAPMHPB);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long MMOPFEFLEPC(string JKLGGALPDGD, long APJDJFMLEAP);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KKCAEFCAMNK(string JKLGGALPDGD, long KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T PMDJEGBDNKF<T>(string JKLGGALPDGD, T APJDJFMLEAP, DBKDDFMBAOI<T> ANLGJMCLLOP);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JKDCNDNJJCM<T>(string JKLGGALPDGD, T KOPHBHGIACG, DBKDDFMBAOI<T> ANLGJMCLLOP);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ACDAGEGBLDK(string JKLGGALPDGD);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task OJCKECCIJKA([Optional] CancellationToken PJCIHHKJKBP);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NPHIIEEHGEM : BOKHLEOMJIO
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action LIBKCLHNBCJ;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task ILHOLEIIFAJ(long FOOADKCMEKE, CancellationToken PJCIHHKJKBP);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PAOIJILPCHO : BOKHLEOMJIO
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IILNOHPFHLL : NPHIIEEHGEM, BOKHLEOMJIO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct OJIGHEOENKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public IILNOHPFHLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x88DF1C0", Offset = "0x88DD7C0", VA = "0x1888DF1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x88DF5A0", Offset = "0x88DDBA0", VA = "0x1888DF5A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class EJKENNJALDN : IEnumerator<KAIBAKBEOHB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private KAIBAKBEOHB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public IILNOHPFHLL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private KAIBAKBEOHB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
		[DebuggerHidden]
		public EJKENNJALDN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x88DC170", Offset = "0x88DA770", VA = "0x1888DC170", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x88DC1E0", Offset = "0x88DA7E0", VA = "0x1888DC1E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly KAPEGBJLOBH KPAHJHHMCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool DKFNHCIEJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool PHDEPODOLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private DJEIDPKGCPH PEACDDCMCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private FAKIPBKLGEB EKPGMLFOLCB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool NMKMFLCMAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action LIBKCLHNBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x88DD6B0", Offset = "0x88DBCB0", VA = "0x1888DD6B0")]
	[UnityEngine.Scripting.Preserve]
	public IILNOHPFHLL([EDHLHMEHMKO(null)] KAPEGBJLOBH KPAHJHHMCCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "8")]
	public void LLCOMIDCGPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x88DD140", Offset = "0x88DB740", VA = "0x1888DD140", Slot = "6")]
	public Task ILHOLEIIFAJ(long FOOADKCMEKE, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1E77860", Offset = "0x1E75E60", VA = "0x181E77860")]
	private static int GLKIHJMAGNE(bool KOPHBHGIACG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x88DCF30", Offset = "0x88DB530", VA = "0x1888DCF30", Slot = "9")]
	public bool BFGOHODHBAI(string JKLGGALPDGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x88DCF50", Offset = "0x88DB550", VA = "0x1888DCF50", Slot = "10")]
	public int BFKBMPCOKDL(string JKLGGALPDGD, int APJDJFMLEAP = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x88DD290", Offset = "0x88DB890", VA = "0x1888DD290", Slot = "11")]
	public void KJJMJGDKFEK(string JKLGGALPDGD, int KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x88DD040", Offset = "0x88DB640", VA = "0x1888DD040", Slot = "12")]
	public bool FJBICNAHDCK(string JKLGGALPDGD, bool APJDJFMLEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x88DD1D0", Offset = "0x88DB7D0", VA = "0x1888DD1D0", Slot = "13")]
	public void ILNOIDENCNB(string JKLGGALPDGD, bool KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x88DCFA0", Offset = "0x88DB5A0", VA = "0x1888DCFA0", Slot = "14")]
	public float DMBOAIOMFIE(string JKLGGALPDGD, float APJDJFMLEAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x88DD0A0", Offset = "0x88DB6A0", VA = "0x1888DD0A0", Slot = "15")]
	public void IAMKLGPLLOI(string JKLGGALPDGD, float KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x88DD220", Offset = "0x88DB820", VA = "0x1888DD220", Slot = "18")]
	public DateTime JOCJLJKBFHK(string JKLGGALPDGD, [Optional] DateTime APJDJFMLEAP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x88DD0D0", Offset = "0x88DB6D0", VA = "0x1888DD0D0", Slot = "19")]
	public void ILHHMCHHCML(string JKLGGALPDGD, DateTime LPBIHAPMHPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x88DD3D0", Offset = "0x88DB9D0", VA = "0x1888DD3D0", Slot = "20")]
	public long MMOPFEFLEPC(string JKLGGALPDGD, long APJDJFMLEAP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x88DD2C0", Offset = "0x88DB8C0", VA = "0x1888DD2C0", Slot = "21")]
	public void KKCAEFCAMNK(string JKLGGALPDGD, long KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3E236B0", Offset = "0x3E21CB0", VA = "0x183E236B0", Slot = "22")]
	public T PMDJEGBDNKF<T>(string JKLGGALPDGD, T APJDJFMLEAP, DBKDDFMBAOI<T> ANLGJMCLLOP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3E22B30", Offset = "0x3E21130", VA = "0x183E22B30", Slot = "23")]
	public void JKDCNDNJJCM<T>(string JKLGGALPDGD, T KOPHBHGIACG, DBKDDFMBAOI<T> ANLGJMCLLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3E22C60", Offset = "0x3E21260", VA = "0x183E22C60")]
	private T KDINHLBKAPO<T>(string JKLGGALPDGD, T APJDJFMLEAP, [Optional] DBKDDFMBAOI<T> JBNDOAEEELB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3E22460", Offset = "0x3E20A60", VA = "0x183E22460")]
	private void CKGGKOMMKLC<T>(string JKLGGALPDGD, T KOPHBHGIACG, [Optional] DBKDDFMBAOI<T> JBNDOAEEELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x88DD440", Offset = "0x88DBA40", VA = "0x1888DD440", Slot = "16")]
	public string NDDCEMAKOME(string JKLGGALPDGD, string APJDJFMLEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x88DD070", Offset = "0x88DB670", VA = "0x1888DD070", Slot = "17")]
	public void HADACJCHHDJ(string JKLGGALPDGD, string KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x88DD200", Offset = "0x88DB800", VA = "0x1888DD200")]
	private void IMNCLKLJKGJ(string JKLGGALPDGD, string KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x88DCF80", Offset = "0x88DB580", VA = "0x1888DCF80")]
	private string BPGIOPBKHPN(string JKLGGALPDGD, string APJDJFMLEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x88DCEA0", Offset = "0x88DB4A0", VA = "0x1888DCEA0", Slot = "24")]
	public void ACDAGEGBLDK(string JKLGGALPDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x88DD330", Offset = "0x88DB930", VA = "0x1888DD330")]
	private string LGMOJDLNGKA(string HAELBKGFDIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x88DD4E0", Offset = "0x88DBAE0", VA = "0x1888DD4E0", Slot = "25")]
	[AsyncStateMachine(typeof(OJIGHEOENKM))]
	public Task OJCKECCIJKA(CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x88DD630", Offset = "0x88DBC30", VA = "0x1888DD630")]
	[IteratorStateMachine(typeof(EJKENNJALDN))]
	private IEnumerator<KAIBAKBEOHB> PNIIJOAHKOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x88DD5D0", Offset = "0x88DBBD0", VA = "0x1888DD5D0")]
	private void ONEGBALIMDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x88DCFD0", Offset = "0x88DB5D0", VA = "0x1888DCFD0")]
	private void EAFPEKKHJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x88DD470", Offset = "0x88DBA70", VA = "0x1888DD470")]
	private void OHHOOLOLOBK(bool IAFBPKCPKGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NLDKEMNDFGN : NPHIIEEHGEM, BOKHLEOMJIO
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct KVP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public string k;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public string v;
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct KVPs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public KVP[] kvps;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Dictionary<string, string> EFILHINOLDM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool NMKMFLCMAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private string KDPPMKGHIJP
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x88DE530", Offset = "0x88DCB30", VA = "0x1888DE530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Dictionary<string, string> KIBLGLMNKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x88DE4F0", Offset = "0x88DCAF0", VA = "0x1888DE4F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action LIBKCLHNBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	[UnityEngine.Scripting.Preserve]
	public NLDKEMNDFGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "8")]
	public void LLCOMIDCGPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x88DE860", Offset = "0x88DCE60", VA = "0x1888DE860", Slot = "6")]
	public Task ILHOLEIIFAJ(long FOOADKCMEKE, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x88DE5A0", Offset = "0x88DCBA0", VA = "0x1888DE5A0", Slot = "14")]
	public float DMBOAIOMFIE(string HAELBKGFDIJ, float APJDJFMLEAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x88DE8F0", Offset = "0x88DCEF0", VA = "0x1888DE8F0", Slot = "13")]
	public void ILNOIDENCNB(string HAELBKGFDIJ, bool KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x88DE610", Offset = "0x88DCC10", VA = "0x1888DE610", Slot = "12")]
	public bool FJBICNAHDCK(string HAELBKGFDIJ, bool APJDJFMLEAP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x88DE480", Offset = "0x88DCA80", VA = "0x1888DE480", Slot = "10")]
	public int BFKBMPCOKDL(string HAELBKGFDIJ, int APJDJFMLEAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x88DE960", Offset = "0x88DCF60", VA = "0x1888DE960", Slot = "18")]
	public DateTime JOCJLJKBFHK(string JKLGGALPDGD, [Optional] DateTime APJDJFMLEAP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x88DE7F0", Offset = "0x88DCDF0", VA = "0x1888DE7F0", Slot = "19")]
	public void ILHHMCHHCML(string HAELBKGFDIJ, DateTime KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x88DE780", Offset = "0x88DCD80", VA = "0x1888DE780", Slot = "15")]
	public void IAMKLGPLLOI(string HAELBKGFDIJ, float KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x88DE9D0", Offset = "0x88DCFD0", VA = "0x1888DE9D0", Slot = "11")]
	public void KJJMJGDKFEK(string HAELBKGFDIJ, int KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x88DEDB0", Offset = "0x88DD3B0", VA = "0x1888DEDB0", Slot = "20")]
	public long MMOPFEFLEPC(string JKLGGALPDGD, long APJDJFMLEAP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x88DEA40", Offset = "0x88DD040", VA = "0x1888DEA40", Slot = "21")]
	public void KKCAEFCAMNK(string JKLGGALPDGD, long KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3BD89D0", Offset = "0x3BD6FD0", VA = "0x183BD89D0", Slot = "22")]
	public T PMDJEGBDNKF<T>(string JKLGGALPDGD, T APJDJFMLEAP, DBKDDFMBAOI<T> ANLGJMCLLOP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3F46B00", Offset = "0x3F45100", VA = "0x183F46B00", Slot = "23")]
	public void JKDCNDNJJCM<T>(string JKLGGALPDGD, T KOPHBHGIACG, DBKDDFMBAOI<T> ANLGJMCLLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x88DEE20", Offset = "0x88DD420", VA = "0x1888DEE20", Slot = "16")]
	public string NDDCEMAKOME(string HAELBKGFDIJ, string APJDJFMLEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x88DE6E0", Offset = "0x88DCCE0", VA = "0x1888DE6E0", Slot = "17")]
	public void HADACJCHHDJ(string HAELBKGFDIJ, string KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x88DE330", Offset = "0x88DC930", VA = "0x1888DE330", Slot = "24")]
	public void ACDAGEGBLDK(string HAELBKGFDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x88DE3F0", Offset = "0x88DC9F0", VA = "0x1888DE3F0", Slot = "9")]
	public bool BFGOHODHBAI(string HAELBKGFDIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x88DEED0", Offset = "0x88DD4D0", VA = "0x1888DEED0", Slot = "25")]
	public Task OJCKECCIJKA(CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3F502D0", Offset = "0x3F4E8D0", VA = "0x183F502D0")]
	private T HBAOOBIPNDD<T>(string JKLGGALPDGD, T APJDJFMLEAP, [Optional] DBKDDFMBAOI<T> JBNDOAEEELB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3F51420", Offset = "0x3F4FA20", VA = "0x183F51420")]
	private void IAMMACFOCIM<T>(string JKLGGALPDGD, T KOPHBHGIACG, [Optional] DBKDDFMBAOI<T> JBNDOAEEELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x88DEAB0", Offset = "0x88DD0B0", VA = "0x1888DEAB0")]
	private Dictionary<string, string> KLOHNINEKPD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface KBKAIDBHKPF
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action LIBKCLHNBCJ;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LLCOMIDCGPM();

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task COKPMEPPBOO(long FOOADKCMEKE);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LAEEJILOHEF(JDPHJKOPAGO ACJDOENJGFC = JDPHJKOPAGO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KHBOFEKPCNM(string JKLGGALPDGD, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KEGEHFIODLP(string JKLGGALPDGD, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string IFOKBKIPOOP(string JKLGGALPDGD, [Optional] string APJDJFMLEAP, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KLFJAMDAPLK LEODFJHKGJK(string JKLGGALPDGD, string KOPHBHGIACG, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int MBFCOBIJGHA(string JKLGGALPDGD, int APJDJFMLEAP = 0, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KLFJAMDAPLK LIOLPPMCCOL(string JKLGGALPDGD, int KOPHBHGIACG, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool NMLPFOPMHFN(string JKLGGALPDGD, bool APJDJFMLEAP, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	KLFJAMDAPLK MKMBNPNMDOH(string JKLGGALPDGD, bool KOPHBHGIACG, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float OGJNDEGBOOO(string JKLGGALPDGD, float APJDJFMLEAP = 0f, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	KLFJAMDAPLK OONHCJGLIIB(string JKLGGALPDGD, float KOPHBHGIACG, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime FDJNKIMOHKM(string JKLGGALPDGD, [Optional] DateTime APJDJFMLEAP, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "16")]
	KLFJAMDAPLK ACGLPMNEKNJ(string JKLGGALPDGD, DateTime KOPHBHGIACG, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long EKDNELKAPAG(string JKLGGALPDGD, long APJDJFMLEAP = 0L, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	KLFJAMDAPLK OKJABLIOJDD(string JKLGGALPDGD, long KOPHBHGIACG, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T ALCKNOBJMBE<T>(string JKLGGALPDGD, [Optional] T APJDJFMLEAP, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	KLFJAMDAPLK EEBOLHFLOPP<T>(string JKLGGALPDGD, T KOPHBHGIACG, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool PGPICAFHLIK(string JKLGGALPDGD);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool HIFDDADLDMJ(string JKLGGALPDGD);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string IPIOLEJKEBI(string JKLGGALPDGD, [Optional] string APJDJFMLEAP);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "24")]
	KLFJAMDAPLK NAKDJCGNJLD(string JKLGGALPDGD, string KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int IFNJPOGDIHK(string JKLGGALPDGD, int APJDJFMLEAP = 0);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "26")]
	KLFJAMDAPLK EKGGMOIALEA(string JKLGGALPDGD, int KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool EHCGDLCCGCL(string JKLGGALPDGD, bool APJDJFMLEAP);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "28")]
	KLFJAMDAPLK FLNMONJGNGO(string JKLGGALPDGD, bool KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float CFMNOJEHMCN(string JKLGGALPDGD, float APJDJFMLEAP = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "30")]
	KLFJAMDAPLK KMEEGCOJHHH(string JKLGGALPDGD, float KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime LDGMFGCKEHC(string JKLGGALPDGD, [Optional] DateTime APJDJFMLEAP);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "32")]
	KLFJAMDAPLK LFJBFMMEJOL(string JKLGGALPDGD, DateTime KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long DGBDDGNNLOE(string JKLGGALPDGD, long APJDJFMLEAP = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "34")]
	KLFJAMDAPLK LPIFEPGOHAJ(string JKLGGALPDGD, long KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void GAJJAAPDCAM<T>(DBKDDFMBAOI<T> ANLGJMCLLOP, [Optional] IEqualityComparer<T> HPIFCOACPPF);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void OJOFIEEPLCD<T>();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable JDLPBCDPEBB();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void EJEKIBNEJDN(float OEDPOHDPEIB);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task ONEGBALIMDD([Optional] CancellationToken PJCIHHKJKBP);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum KLFJAMDAPLK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CHBIDEPHKLI : KBKAIDBHKPF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private abstract class JFPLGADEKFA
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		protected static readonly HashSet<JFPLGADEKFA> OEOGOKGCNDD;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x88DD7A0", Offset = "0x88DBDA0", VA = "0x1888DD7A0")]
		public static void ANIOEBIJDKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void ELFNJAKNOMA();

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		protected JFPLGADEKFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class GDLHPIKGKNL<T> : JFPLGADEKFA
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly GDLHPIKGKNL<T> EHBCEBDHHPE;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public DBKDDFMBAOI<T> CMAOMHHFPDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEqualityComparer<T> GAOAPAHEICJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool FDOENMHDKKC
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x4AEFAC0", Offset = "0x4AEE0C0", VA = "0x184AEFAC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x50EA920", Offset = "0x50E8F20", VA = "0x1850EA920")]
		private GDLHPIKGKNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x50EA320", Offset = "0x50E8920", VA = "0x1850EA320")]
		public void NCEHDCEOICJ(DBKDDFMBAOI<T> JBNDOAEEELB, [Optional] IEqualityComparer<T> HPIFCOACPPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x50EA2D0", Offset = "0x50E88D0", VA = "0x1850EA2D0", Slot = "4")]
		public override void ELFNJAKNOMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class BOOALMHDOLM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly CHBIDEPHKLI PJOEKAENFGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly object MDCDJGBMMDN;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x88D7F80", Offset = "0x88D6580", VA = "0x1888D7F80")]
		public BOOALMHDOLM(CHBIDEPHKLI PJOEKAENFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x88D7F50", Offset = "0x88D6550", VA = "0x1888D7F50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct CHAILHKJLFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public CHBIDEPHKLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public long playerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x88D8190", Offset = "0x88D6790", VA = "0x1888D8190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x88D8470", Offset = "0x88D6A70", VA = "0x1888D8470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct EHAFMHLHEIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CHBIDEPHKLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public BOKHLEOMJIO backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x88DBFE0", Offset = "0x88DA5E0", VA = "0x1888DBFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xB035A0", Offset = "0xB01BA0", VA = "0x180B035A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct HFCIIOEPGDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CHBIDEPHKLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x88DC970", Offset = "0x88DAF70", VA = "0x1888DC970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x88DCE40", Offset = "0x88DB440", VA = "0x1888DCE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GAMMIDKIDON : IEnumerator<KAIBAKBEOHB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private KAIBAKBEOHB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CHBIDEPHKLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private KAIBAKBEOHB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
		[DebuggerHidden]
		public GAMMIDKIDON(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x88DC890", Offset = "0x88DAE90", VA = "0x1888DC890", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x88DC920", Offset = "0x88DAF20", VA = "0x1888DC920", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly NPHIIEEHGEM ECDGGOPHOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly NPHIIEEHGEM DCKIAHFDCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly PAOIJILPCHO IOHECJMLHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly DJEIDPKGCPH PEACDDCMCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly KIIGHHFFHPA.HJFNGOHFFDD BCEGKBFJGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly PBCNGJENIAB FLFOJJPJCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly HashSet<BOKHLEOMJIO> BINFKPDANJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private Task IIGFNEFKJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<string, string> JJOIFDEMJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private FAKIPBKLGEB JHMLBPLGNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly object AFKHLLHENHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly object IGJOKJBJCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private long INIFDFJJLJC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private bool HCHBABNOEJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x88DA8D0", Offset = "0x88D8ED0", VA = "0x1888DA8D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private CancellationTokenSource GINPEAEOLLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xAA5710", Offset = "0xAA3D10", VA = "0x180AA5710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xAA5590", Offset = "0xAA3B90", VA = "0x180AA5590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action LIBKCLHNBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x88DAF30", Offset = "0x88D9530", VA = "0x1888DAF30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x88D9900", Offset = "0x88D7F00", VA = "0x1888D9900", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x88D9F00", Offset = "0x88D8500", VA = "0x1888D9F00")]
	[EGNICHGEFDG.KHJDAJHJKCM]
	internal static void KHFEDOGILIL(NMNJFHODGJA JBBCAANONNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x88DB340", Offset = "0x88D9940", VA = "0x1888DB340")]
	[UnityEngine.Scripting.Preserve]
	public CHBIDEPHKLI([EDHLHMEHMKO("Disk")] NPHIIEEHGEM ECDGGOPHOFE, [EDHLHMEHMKO("Cloud")] NPHIIEEHGEM DCKIAHFDCIK, [EDHLHMEHMKO(null)] PAOIJILPCHO IOHECJMLHIF, [EDHLHMEHMKO(null)] DJEIDPKGCPH PEACDDCMCEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x88D8C40", Offset = "0x88D7240", VA = "0x1888D8C40", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x88D91F0", Offset = "0x88D77F0", VA = "0x1888D91F0")]
	private void FGEAHNCNJFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x88DA410", Offset = "0x88D8A10", VA = "0x1888DA410", Slot = "6")]
	public void LLCOMIDCGPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x88D89D0", Offset = "0x88D6FD0", VA = "0x1888D89D0", Slot = "7")]
	public Task COKPMEPPBOO(long FOOADKCMEKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x88DB1D0", Offset = "0x88D97D0", VA = "0x1888DB1D0")]
	[AsyncStateMachine(typeof(CHAILHKJLFB))]
	private Task PCCPAPNNGAO(long FOOADKCMEKE, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x88D8940", Offset = "0x88D6F40", VA = "0x1888D8940")]
	private void BCHKGADLICN(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x88DA850", Offset = "0x88D8E50", VA = "0x1888DA850")]
	private void NBCGLGOKNBK(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x88DAA50", Offset = "0x88D9050", VA = "0x1888DAA50")]
	private string OHLFEMOLOHO(string DHGDKCMCCGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x88D9280", Offset = "0x88D7880", VA = "0x1888D9280")]
	private void IDCNDKBMGCI(JDPHJKOPAGO ACJDOENJGFC, string HAELBKGFDIJ, [Out] NPHIIEEHGEM CHKLIDOHCMP, [Out] string ABOHCKMODOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x88DB150", Offset = "0x88D9750", VA = "0x1888DB150")]
	private NPHIIEEHGEM OPJDANPOINP(JDPHJKOPAGO ACJDOENJGFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x88D9FA0", Offset = "0x88D85A0", VA = "0x1888D9FA0", Slot = "8")]
	public bool LAEEJILOHEF(JDPHJKOPAGO ACJDOENJGFC = JDPHJKOPAGO.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x88D9E60", Offset = "0x88D8460", VA = "0x1888D9E60", Slot = "9")]
	public bool KHBOFEKPCNM(string JKLGGALPDGD, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x88D9CE0", Offset = "0x88D82E0", VA = "0x1888D9CE0", Slot = "10")]
	public bool KEGEHFIODLP(string JKLGGALPDGD, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x88D9490", Offset = "0x88D7A90", VA = "0x1888D9490", Slot = "11")]
	public string IFOKBKIPOOP(string JKLGGALPDGD, [Optional] string APJDJFMLEAP, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x88DA0D0", Offset = "0x88D86D0", VA = "0x1888DA0D0", Slot = "12")]
	public KLFJAMDAPLK LEODFJHKGJK(string JKLGGALPDGD, string KOPHBHGIACG, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD)
	{
		return default(KLFJAMDAPLK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x88DA4B0", Offset = "0x88D8AB0", VA = "0x1888DA4B0", Slot = "13")]
	public int MBFCOBIJGHA(string JKLGGALPDGD, int APJDJFMLEAP = 0, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x88DA290", Offset = "0x88D8890", VA = "0x1888DA290", Slot = "14")]
	public KLFJAMDAPLK LIOLPPMCCOL(string JKLGGALPDGD, int KOPHBHGIACG, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD)
	{
		return default(KLFJAMDAPLK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x88DA8F0", Offset = "0x88D8EF0", VA = "0x1888DA8F0", Slot = "15")]
	public bool NMLPFOPMHFN(string JKLGGALPDGD, bool APJDJFMLEAP, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x88DA6A0", Offset = "0x88D8CA0", VA = "0x1888DA6A0", Slot = "16")]
	public KLFJAMDAPLK MKMBNPNMDOH(string JKLGGALPDGD, bool KOPHBHGIACG, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD)
	{
		return default(KLFJAMDAPLK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x88DA9A0", Offset = "0x88D8FA0", VA = "0x1888DA9A0", Slot = "17")]
	public float OGJNDEGBOOO(string JKLGGALPDGD, float APJDJFMLEAP = 0f, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x88DAFD0", Offset = "0x88D95D0", VA = "0x1888DAFD0", Slot = "18")]
	public KLFJAMDAPLK OONHCJGLIIB(string JKLGGALPDGD, float KOPHBHGIACG, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD)
	{
		return default(KLFJAMDAPLK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x88D9150", Offset = "0x88D7750", VA = "0x1888D9150", Slot = "19")]
	public DateTime FDJNKIMOHKM(string JKLGGALPDGD, [Optional] DateTime APJDJFMLEAP, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x88D84D0", Offset = "0x88D6AD0", VA = "0x1888D84D0", Slot = "20")]
	public KLFJAMDAPLK ACGLPMNEKNJ(string JKLGGALPDGD, DateTime KOPHBHGIACG, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD)
	{
		return default(KLFJAMDAPLK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x88D8F40", Offset = "0x88D7540", VA = "0x1888D8F40", Slot = "21")]
	public long EKDNELKAPAG(string JKLGGALPDGD, long APJDJFMLEAP = 0L, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x88DACC0", Offset = "0x88D92C0", VA = "0x1888DACC0", Slot = "22")]
	public KLFJAMDAPLK OKJABLIOJDD(string JKLGGALPDGD, long KOPHBHGIACG, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD)
	{
		return default(KLFJAMDAPLK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3BD94C0", Offset = "0x3BD7AC0", VA = "0x183BD94C0", Slot = "23")]
	public T ALCKNOBJMBE<T>(string JKLGGALPDGD, [Optional] T APJDJFMLEAP, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3BD94C0", Offset = "0x3BD7AC0", VA = "0x183BD94C0", Slot = "24")]
	public KLFJAMDAPLK EEBOLHFLOPP<T>(string JKLGGALPDGD, T KOPHBHGIACG, JDPHJKOPAGO OFPDDKPMDJB = JDPHJKOPAGO.CLOUD)
	{
		return default(KLFJAMDAPLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x88DB2E0", Offset = "0x88D98E0", VA = "0x1888DB2E0", Slot = "25")]
	public bool PGPICAFHLIK(string JKLGGALPDGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x88D9270", Offset = "0x88D7870", VA = "0x1888D9270", Slot = "26")]
	public bool HIFDDADLDMJ(string JKLGGALPDGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x88D97B0", Offset = "0x88D7DB0", VA = "0x1888D97B0", Slot = "27")]
	public string IPIOLEJKEBI(string JKLGGALPDGD, [Optional] string APJDJFMLEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x88DA820", Offset = "0x88D8E20", VA = "0x1888DA820", Slot = "28")]
	public KLFJAMDAPLK NAKDJCGNJLD(string JKLGGALPDGD, string KOPHBHGIACG)
	{
		return default(KLFJAMDAPLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x88D9420", Offset = "0x88D7A20", VA = "0x1888D9420", Slot = "29")]
	public int IFNJPOGDIHK(string JKLGGALPDGD, int APJDJFMLEAP = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x88D8FE0", Offset = "0x88D75E0", VA = "0x1888D8FE0", Slot = "30")]
	public KLFJAMDAPLK EKGGMOIALEA(string JKLGGALPDGD, int KOPHBHGIACG)
	{
		return default(KLFJAMDAPLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x88D8E60", Offset = "0x88D7460", VA = "0x1888D8E60", Slot = "31")]
	public bool EHCGDLCCGCL(string JKLGGALPDGD, bool APJDJFMLEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x88D9240", Offset = "0x88D7840", VA = "0x1888D9240", Slot = "32")]
	public KLFJAMDAPLK FLNMONJGNGO(string JKLGGALPDGD, bool KOPHBHGIACG)
	{
		return default(KLFJAMDAPLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x88D8960", Offset = "0x88D6F60", VA = "0x1888D8960", Slot = "33")]
	public float CFMNOJEHMCN(string JKLGGALPDGD, float APJDJFMLEAP = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x88D9F70", Offset = "0x88D8570", VA = "0x1888D9F70", Slot = "34")]
	public KLFJAMDAPLK KMEEGCOJHHH(string JKLGGALPDGD, float KOPHBHGIACG)
	{
		return default(KLFJAMDAPLK);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x88DA060", Offset = "0x88D8660", VA = "0x1888DA060", Slot = "35")]
	public DateTime LDGMFGCKEHC(string JKLGGALPDGD, [Optional] DateTime APJDJFMLEAP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x88DA260", Offset = "0x88D8860", VA = "0x1888DA260", Slot = "36")]
	public KLFJAMDAPLK LFJBFMMEJOL(string JKLGGALPDGD, DateTime KOPHBHGIACG)
	{
		return default(KLFJAMDAPLK);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x88D8BA0", Offset = "0x88D71A0", VA = "0x1888D8BA0", Slot = "37")]
	public long DGBDDGNNLOE(string JKLGGALPDGD, long APJDJFMLEAP = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x88DA480", Offset = "0x88D8A80", VA = "0x1888DA480", Slot = "38")]
	public KLFJAMDAPLK LPIFEPGOHAJ(string JKLGGALPDGD, long KOPHBHGIACG)
	{
		return default(KLFJAMDAPLK);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x88D8ED0", Offset = "0x88D74D0", VA = "0x1888D8ED0")]
	private bool EHFPIKGDOEH(BOKHLEOMJIO CHKLIDOHCMP, string JKLGGALPDGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x88D99A0", Offset = "0x88D7FA0", VA = "0x1888D99A0")]
	private bool KAJKIAFHKII(BOKHLEOMJIO CHKLIDOHCMP, string JKLGGALPDGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x88D87F0", Offset = "0x88D6DF0", VA = "0x1888D87F0")]
	private KLFJAMDAPLK BBCHOMGIPCL(BOKHLEOMJIO CHKLIDOHCMP, string JKLGGALPDGD, string KOPHBHGIACG)
	{
		return default(KLFJAMDAPLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x88DA560", Offset = "0x88D8B60", VA = "0x1888DA560")]
	private KLFJAMDAPLK MDHGINDJPKH(BOKHLEOMJIO CHKLIDOHCMP, string JKLGGALPDGD, int KOPHBHGIACG)
	{
		return default(KLFJAMDAPLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x88DAB80", Offset = "0x88D9180", VA = "0x1888DAB80")]
	private KLFJAMDAPLK OJFGOJOHFGN(BOKHLEOMJIO CHKLIDOHCMP, string JKLGGALPDGD, bool KOPHBHGIACG)
	{
		return default(KLFJAMDAPLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x88D9B90", Offset = "0x88D8190", VA = "0x1888D9B90")]
	private KLFJAMDAPLK KBNIHMHEHCE(BOKHLEOMJIO CHKLIDOHCMP, string JKLGGALPDGD, float KOPHBHGIACG)
	{
		return default(KLFJAMDAPLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x88D8680", Offset = "0x88D6C80", VA = "0x1888D8680")]
	private KLFJAMDAPLK AKKINMHJGEF(BOKHLEOMJIO CHKLIDOHCMP, string JKLGGALPDGD, DateTime KOPHBHGIACG)
	{
		return default(KLFJAMDAPLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x88D9010", Offset = "0x88D7610", VA = "0x1888D9010")]
	private KLFJAMDAPLK EMMLLIIEDCG(BOKHLEOMJIO CHKLIDOHCMP, string JKLGGALPDGD, long KOPHBHGIACG)
	{
		return default(KLFJAMDAPLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3BDA420", Offset = "0x3BD8A20", VA = "0x183BDA420")]
	private T PIDOGKHLCNP<T>(BOKHLEOMJIO CHKLIDOHCMP, string JKLGGALPDGD, T APJDJFMLEAP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3BD96C0", Offset = "0x3BD7CC0", VA = "0x183BD96C0")]
	private KLFJAMDAPLK BMMDDECBIOC<T>(BOKHLEOMJIO CHKLIDOHCMP, string JKLGGALPDGD, T KOPHBHGIACG)
	{
		return default(KLFJAMDAPLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3BDA300", Offset = "0x3BD8900", VA = "0x183BDA300", Slot = "39")]
	public void GAJJAAPDCAM<T>(DBKDDFMBAOI<T> ANLGJMCLLOP, [Optional] IEqualityComparer<T> HPIFCOACPPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3BDA3A0", Offset = "0x3BD89A0", VA = "0x183BDA3A0", Slot = "40")]
	public void OJOFIEEPLCD<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x88DAAB0", Offset = "0x88D90B0", VA = "0x1888DAAB0")]
	[AsyncStateMachine(typeof(EHAFMHLHEIE))]
	private void OJCKECCIJKA(BOKHLEOMJIO LMHCDNEHHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x88DAE40", Offset = "0x88D9440", VA = "0x1888DAE40", Slot = "43")]
	[AsyncStateMachine(typeof(HFCIIOEPGDP))]
	public Task ONEGBALIMDD([Optional] CancellationToken INEEADCBMPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x88D8C80", Offset = "0x88D7280", VA = "0x1888D8C80")]
	private void EHAJIBPONPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x88D9820", Offset = "0x88D7E20", VA = "0x1888D9820", Slot = "41")]
	public IDisposable JDLPBCDPEBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x88D8F30", Offset = "0x88D7530", VA = "0x1888D8F30", Slot = "42")]
	public void EJEKIBNEJDN(float OEDPOHDPEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x88D9530", Offset = "0x88D7B30", VA = "0x1888D9530")]
	private void IJJMLMLLLIH(float OLEKJKBFIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x88D9B00", Offset = "0x88D8100", VA = "0x1888D9B00")]
	[IteratorStateMachine(typeof(GAMMIDKIDON))]
	private IEnumerator<KAIBAKBEOHB> KBBOCIELHKO(float OEDPOHDPEIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x88D8C10", Offset = "0x88D7210", VA = "0x1888D8C10")]
	[CompilerGenerated]
	private void DHPCPPBHAKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class CPPLFFPMBIN
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x88DB710", Offset = "0x88D9D10", VA = "0x1888DB710")]
	public static string AOBLOANDKLN(this KBKAIDBHKPF JNMMMBJNOND, string HAELBKGFDIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x88DB990", Offset = "0x88D9F90", VA = "0x1888DB990")]
	public static byte[] IOEBLABKLKK(this KBKAIDBHKPF JNMMMBJNOND, string HAELBKGFDIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x88DB880", Offset = "0x88D9E80", VA = "0x1888DB880")]
	public static KLFJAMDAPLK HFKDGOGKMIL(this KBKAIDBHKPF JNMMMBJNOND, string HAELBKGFDIJ, ReadOnlySpan<byte> KOPHBHGIACG)
	{
		return default(KLFJAMDAPLK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class EFCNAFOCHGP : HAHHNFCMALN<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static EFCNAFOCHGP EHBCEBDHHPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x88DBC30", Offset = "0x88DA230", VA = "0x1888DBC30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x88DBB40", Offset = "0x88DA140", VA = "0x1888DBB40", Slot = "9")]
	public override string ANHNANMIGBP(bool ECBHOIMIBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x88DBC80", Offset = "0x88DA280", VA = "0x1888DBC80", Slot = "10")]
	protected override bool MEIFKFJCAFB(string ECBHOIMIBKD, [Out] bool KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x88DBFA0", Offset = "0x88DA5A0", VA = "0x1888DBFA0")]
	public EFCNAFOCHGP()
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

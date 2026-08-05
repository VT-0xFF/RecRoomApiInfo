using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using Google.Protobuf;
using Google.Protobuf.Collections;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecNet;
using RecRoom.NoEngine.Common;
using RecRoom.Persistence;
using UnityEngine;
using UnityEngine.SceneManagement;
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
		[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
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
		[Cpp2IlInjected.Address(RVA = "0x28B7510", Offset = "0x28B6710", VA = "0x1828B7510")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E3190", Offset = "0x7E2390", VA = "0x1807E3190")]
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
		[Cpp2IlInjected.Address(RVA = "0x17C7540", Offset = "0x17C6740", VA = "0x1817C7540")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BGPLFENKJGO
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<GMJLKBDAIPD> BLIBCOPAJAP;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CPPJHBCMHBE(long HBFBDJIOFCF, long HHIFFPJLPIC, CKEACEFIEED LLJFOILBDJN, BIPGMDDBGPD BHKOGCBJNKO);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EFJOOIPOFJF(long HBFBDJIOFCF, long HHIFFPJLPIC, out GMJLKBDAIPD OPBMLMJIHBP);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EDMDENKMMLC(long HBFBDJIOFCF, long HHIFFPJLPIC, BIPGMDDBGPD BHKOGCBJNKO, out GMJLKBDAIPD OPBMLMJIHBP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MEKABHKCNAJ(long HBFBDJIOFCF, long HHIFFPJLPIC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[UnityEngine.Scripting.Preserve]
internal class NBPEGFAONAB : GBNLMHKMPCE, CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class KHDKLIIPLLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public CONHHIMJCNJ roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public KHDKLIIPLLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4EE6CC0", Offset = "0x4EE5EC0", VA = "0x184EE6CC0")]
		internal object ICMHDGGKAOL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action AFOBIDPDANN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x28B47F0", Offset = "0x28B39F0", VA = "0x1828B47F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x28B4BD0", Offset = "0x28B3DD0", VA = "0x1828B4BD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event MIAMIMOOMAC FBMPILIGMOD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x28B4A90", Offset = "0x28B3C90", VA = "0x1828B4A90", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28B45E0", Offset = "0x28B37E0", VA = "0x1828B45E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event MIAMIMOOMAC FLFDEGBICCE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28B4250", Offset = "0x28B3450", VA = "0x1828B4250", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28B4680", Offset = "0x28B3880", VA = "0x1828B4680", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event MIAMIMOOMAC CODEDBMFFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28B4D10", Offset = "0x28B3F10", VA = "0x1828B4D10", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28B4750", Offset = "0x28B3950", VA = "0x1828B4750", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<CGPDIEAJPGM, bool> DJKJNLIGOPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28B4B30", Offset = "0x28B3D30", VA = "0x1828B4B30", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28B4C70", Offset = "0x28B3E70", VA = "0x1828B4C70", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "19")]
	public void KCEHONPEIFO(GGGLHECDAMD BFBBPILOBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x28B42F0", Offset = "0x28B34F0", VA = "0x1828B42F0", Slot = "14")]
	public void DLNAPJPBLGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x28B4DB0", Offset = "0x28B3FB0", VA = "0x1828B4DB0", Slot = "15")]
	public void POEBMALHPBN(CONHHIMJCNJ GEMCJBEAJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x28B4500", Offset = "0x28B3700", VA = "0x1828B4500", Slot = "16")]
	public void FDLBLAABGOO(CONHHIMJCNJ GEMCJBEAJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x28B4720", Offset = "0x28B3920", VA = "0x1828B4720", Slot = "17")]
	public void HLBGPJPJDLC(CONHHIMJCNJ GEMCJBEAJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x28B4530", Offset = "0x28B3730", VA = "0x1828B4530", Slot = "18")]
	public void FLABOCAELGM(CGPDIEAJPGM BDIHIOJPHJO, bool KECICGODINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x28B4890", Offset = "0x28B3A90", VA = "0x1828B4890")]
	private void LDFPBHJMNFE(MIAMIMOOMAC ILPONDPFHDP, CONHHIMJCNJ GEMCJBEAJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public NBPEGFAONAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface FBKALKKBACA : CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	LKGIPCJDHDA NMBGPPEFELF
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCEMEFNJCLB();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IJEAOHANHOE();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface PAJNMOEGIGE : CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NIJBFDNCANL GIGOKAIHLBK(GBOAMHGCLHL ACNPMGGIPME);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NKPCAINNPCA(Guid OAOAFDNAJNM, Task CHEEIAMKAGL);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal struct HPBLEFKLNKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly IDictionary<object, object> BABPGEEPJFH;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8BADB0", Offset = "0x8B9FB0", VA = "0x1808BADB0")]
	public HPBLEFKLNKJ(IDictionary<object, object> BABPGEEPJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1F72870", Offset = "0x1F71A70", VA = "0x181F72870")]
	public bool FDKHDEBEBAI(out GBOAMHGCLHL JPOEHOENKPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1F72930", Offset = "0x1F71B30", VA = "0x181F72930")]
	public Guid HPAIABGEDJJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1F72760", Offset = "0x1F71960", VA = "0x181F72760")]
	public FGEDLIOJPHD FAPLMNGBCIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1F72A10", Offset = "0x1F71C10", VA = "0x181F72A10")]
	public static ExitGames.Client.Photon.Hashtable JKAAGGANCJG(GBOAMHGCLHL JPOEHOENKPI, FGEDLIOJPHD HBGNHMKPIBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HHPIKNMCMBP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GHNBKENMJJA(MFJNMMICGAE.GCNDFCJBOGE GPIGCINBIMO);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHODGILIJIB(MFJNMMICGAE.GCNDFCJBOGE GPIGCINBIMO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class MFJNMMICGAE : HHPIKNMCMBP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate FGEDLIOJPHD GCNDFCJBOGE([NotNull] CPCMBHAGMBL IGDKNPAEELF);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class HJFCIEBJCEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public CPCMBHAGMBL photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public HJFCIEBJCEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4EE4DE0", Offset = "0x4EE3FE0", VA = "0x184EE4DE0")]
		internal FGEDLIOJPHD PFEDEGCBBCP(GCNDFCJBOGE v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool OLAIFPCFFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly HashSet<GCNDFCJBOGE> BBLEBDOABJO;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x28B2270", Offset = "0x28B1470", VA = "0x1828B2270", Slot = "4")]
	public void GHNBKENMJJA(GCNDFCJBOGE GPIGCINBIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x28B22D0", Offset = "0x28B14D0", VA = "0x1828B22D0", Slot = "5")]
	public void IHODGILIJIB(GCNDFCJBOGE GPIGCINBIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x28B2220", Offset = "0x28B1420", VA = "0x1828B2220", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x28B2000", Offset = "0x28B1200", VA = "0x1828B2000")]
	protected FGEDLIOJPHD CFDAKNBLCMD(CPCMBHAGMBL NHLBBNCBMOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x28B2330", Offset = "0x28B1530", VA = "0x1828B2330")]
	protected MFJNMMICGAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class KHJPHKNAMPO
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class GNNIOJGIGIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public FNMBADLGNPC subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public GNNIOJGIGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3ADBEF0", Offset = "0x3ADB0F0", VA = "0x183ADBEF0")]
		internal bool DFFGCOKFIJC(NKFEOLDLFPD s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x28AAF00", Offset = "0x28AA100", VA = "0x1828AAF00")]
	public static NAFOEDAKNOD JKAAGGANCJG(long HAJMGOKOEPH, long BGOPDGBJMDP, string LBNNLDOBOIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x28AAD00", Offset = "0x28A9F00", VA = "0x1828AAD00")]
	public static NAFOEDAKNOD JKAAGGANCJG(long HAJMGOKOEPH, long BGOPDGBJMDP, PEFGNKCLLMB GPHICPODLBN, long NKFLEOFOPLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x28AADD0", Offset = "0x28A9FD0", VA = "0x1828AADD0")]
	public static NAFOEDAKNOD JKAAGGANCJG(ONNIIAMENKC GEKJFGPDPPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x28AAAC0", Offset = "0x28A9CC0", VA = "0x1828AAAC0")]
	public static NAFOEDAKNOD JKAAGGANCJG(JICMMHOABAL JEHLJLNCFEN, FNMBADLGNPC MGBICFOICAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x28AA9C0", Offset = "0x28A9BC0", VA = "0x1828AA9C0")]
	public static NAFOEDAKNOD EAGDKFCDPJK(this NAFOEDAKNOD GJNKBDPFGGF, JICMMHOABAL LDEFJBDHNEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x28AA830", Offset = "0x28A9A30", VA = "0x1828AA830")]
	public static NAFOEDAKNOD ABNEDHFDALJ(this NAFOEDAKNOD GJNKBDPFGGF, FNMBADLGNPC EJCHEBDMOFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum JGIIIGMNPKM
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum CGPDIEAJPGM
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	InitialRoomLoad,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	AutoSave,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	SaveToDisk,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	SaveToRecNet,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	RestoreAutoSave,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct CONHHIMJCNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly long HAJMGOKOEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly long BGOPDGBJMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly JGIIIGMNPKM FBNKHAJKFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[CanBeNull]
	public readonly Exception AJPIBMHNELN;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1F60010", Offset = "0x1F5F210", VA = "0x181F60010")]
	public CONHHIMJCNJ(long HAJMGOKOEPH, long BGOPDGBJMDP, JGIIIGMNPKM FBNKHAJKFLM, [CanBeNull] Exception AJPIBMHNELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1F5FFC0", Offset = "0x1F5F1C0", VA = "0x181F5FFC0")]
	public static CONHHIMJCNJ LKEFLLNHKFJ(KDLCCGABAHG DLJJINDIADH, JGIIIGMNPKM FBNKHAJKFLM, [Optional] Exception AJPIBMHNELN)
	{
		return default(CONHHIMJCNJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public delegate void MIAMIMOOMAC(CONHHIMJCNJ GEMCJBEAJOK);
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface GBNLMHKMPCE : CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action AFOBIDPDANN;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event MIAMIMOOMAC FBMPILIGMOD;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event MIAMIMOOMAC FLFDEGBICCE;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event MIAMIMOOMAC CODEDBMFFBC;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<CGPDIEAJPGM, bool> DJKJNLIGOPI;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DLNAPJPBLGE();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void POEBMALHPBN(CONHHIMJCNJ GEMCJBEAJOK);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FDLBLAABGOO(CONHHIMJCNJ GEMCJBEAJOK);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HLBGPJPJDLC(CONHHIMJCNJ GEMCJBEAJOK);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FLABOCAELGM(CGPDIEAJPGM BDIHIOJPHJO, bool KECICGODINP);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[UnityEngine.Scripting.Preserve]
internal class GAFCABNJMJJ : LCLLGEFLIBP, CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class JCGOANMLKKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public GAFCABNJMJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GAKPIOFBDII<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private IPCBCDPDIGB <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public JCGOANMLKKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x3E56280", Offset = "0x3E55480", VA = "0x183E56280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private IJHNPMDMGIK NPDKCJPJIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private GGGLHECDAMD BFBBPILOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private BFHFKPNDBGJ AEAAOAENKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private JIPBJFBAGHG MANAFLPNCHE;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1F6AAD0", Offset = "0x1F69CD0", VA = "0x181F6AAD0", Slot = "6")]
	public void KCEHONPEIFO(GGGLHECDAMD BFBBPILOBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1F6A8D0", Offset = "0x1F69AD0", VA = "0x181F6A8D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1F6A920", Offset = "0x1F69B20", VA = "0x181F6A920", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JCGOANMLKKM))]
	public Task GPCJOJNBKLF(string NOFBJAIDPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1F6AA70", Offset = "0x1F69C70", VA = "0x181F6AA70", Slot = "4")]
	public FGEDLIOJPHD HHEHOAPHLIE(CPCMBHAGMBL IDJKEADFEIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1F6ACE0", Offset = "0x1F69EE0", VA = "0x181F6ACE0")]
	private IPCBCDPDIGB LBAAGEJBPKK(string NOFBJAIDPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public GAFCABNJMJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface MFJKEMECNGI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool BGLJJNGEJHL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool JNKCDAEGNAG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	JFCNENLAIHN CCLGHGGBCMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action AFOBIDPDANN;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event MIAMIMOOMAC FBMPILIGMOD;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event MIAMIMOOMAC FLFDEGBICCE;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event MIAMIMOOMAC CODEDBMFFBC;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<CGPDIEAJPGM, bool> DJKJNLIGOPI;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PCCBHEFBPDH();

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "13")]
	AFJGHJAKFME HDOCENBJFHA();

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OKKGMBNHAPB BAECCMGAANK();

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<FGEDLIOJPHD> LFOKINGHCPB(GMJLKBDAIPD PEIFNOKHAJA);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task PALEOIEBKEB(CancellationToken MELLLMEKJLC);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface DBLLAAAALEB : CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FGEDLIOJPHD> LFOKINGHCPB(GMJLKBDAIPD OPBMLMJIHBP);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PALEOIEBKEB(CancellationToken MELLLMEKJLC);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[RecRoom.NoEngine.Common.Preserve]
internal class DABOHCBKAFB : EAEEJEIDIPI, CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class GFOJNCONHLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public KDLCCGABAHG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public JFCNENLAIHN customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public DABOHCBKAFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Task <task>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public GFOJNCONHLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x3E52B80", Offset = "0x3E51D80", VA = "0x183E52B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class EOFMNJIFELH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public KDLCCGABAHG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public JFCNENLAIHN customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public DABOHCBKAFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private GAKPIOFBDII<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private MDHCFBFJDKN <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private JGALLCINBGJ <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private OperationCanceledException <oce>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private Exception <ex>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public EOFMNJIFELH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3E4E0F0", Offset = "0x3E4D2F0", VA = "0x183E4E0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class EMAMLFACNHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Matchmaking.JKDFOKALMIF result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public INCLMMPMLDF errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public EMAMLFACNHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3E4E040", Offset = "0x3E4D240", VA = "0x183E4E040")]
		internal object EKFEENDKKEE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class ONPOBKDELJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Task<NAFOEDAKNOD> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public ONPOBKDELJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110")]
		internal Task<NAFOEDAKNOD> ODFCJLCPAOJ(GAKPIOFBDII<string>.JOKPHMHCDCF _)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class FOOMCEODKBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public KDLCCGABAHG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public JFCNENLAIHN customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public MDHCFBFJDKN joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public DABOHCBKAFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private LDFPHEEBEDP <multiProgressTracker>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private IDisposable <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <connectToRoomAndRunLoadLogicTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private CancellationTokenSource <roomTokenSource>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private CancellationTokenRegistration <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private ONPOBKDELJI <>8__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private EEMHMDDCNGF <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Task<Matchmaking.OKPCCFFGNKM> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private EKENKMHAPBN <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private Matchmaking.OKPCCFFGNKM <serverConnectionInfo>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private CancellationTokenSource <cameraFadeCts>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private CancellationTokenSource <loadingScreenCts>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <loadingScreenScope>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private Matchmaking.OKPCCFFGNKM <>s__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private CancellationTokenSource <photonJoinedTokenSource>5__18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private CancellationToken <photonJoinedToken>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private NAFOEDAKNOD <initialRoomLoadPayload>5__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private Task <roomLoadTask>5__21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private NAFOEDAKNOD <>s__22;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__23;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter<Matchmaking.OKPCCFFGNKM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<NAFOEDAKNOD> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public FOOMCEODKBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3E4F490", Offset = "0x3E4E690", VA = "0x183E4F490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class IJGDIDLEBAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public DABOHCBKAFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <disconnectTimerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private object <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Exception <ex>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public IJGDIDLEBAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3E55120", Offset = "0x3E54320", VA = "0x183E55120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class IPKCBAHDMMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public DABOHCBKAFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private JFLMNMMPBBG <roomContainer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public IPKCBAHDMMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3E55E50", Offset = "0x3E55050", VA = "0x183E55E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class JMMMCGNEHBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<Matchmaking.OKPCCFFGNKM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public KDLCCGABAHG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public DABOHCBKAFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private Matchmaking.OKPCCFFGNKM <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private TaskAwaiter<Matchmaking.OKPCCFFGNKM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public JMMMCGNEHBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3E57810", Offset = "0x3E56A10", VA = "0x183E57810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class LAKOBNAKAPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Matchmaking.OKPCCFFGNKM serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public MDHCFBFJDKN joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public DABOHCBKAFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private NNGBEGHHEFA <photonRoomConnectionInfo>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<NNGBEGHHEFA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public LAKOBNAKAPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3E58CB0", Offset = "0x3E57EB0", VA = "0x183E58CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class PFMPACGPPEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public KDLCCGABAHG targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public PFMPACGPPEE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class NFOFOCBFCJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public PFMPACGPPEE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public NFOFOCBFCJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3E598C0", Offset = "0x3E58AC0", VA = "0x183E598C0")]
		internal object IJCEBEBHGIP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3E599C0", Offset = "0x3E58BC0", VA = "0x183E599C0")]
		internal string MCAFMKLABMN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class HHFEEAMPDBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public KDLCCGABAHG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public DABOHCBKAFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private PFMPACGPPEE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private NFOFOCBFCJF <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private Task <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private object <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private Exception <ex>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public HHFEEAMPDBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3E532F0", Offset = "0x3E524F0", VA = "0x183E532F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class CPKJLHOANDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public NAFOEDAKNOD initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public LDFPHEEBEDP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public KDLCCGABAHG targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public MDHCFBFJDKN joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public DABOHCBKAFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <roomLoadLogicTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private MDHCFBFJDKN <initialLoadOpPauseToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private NOBGNHCOPKP <op>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public CPKJLHOANDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3E4B650", Offset = "0x3E4A850", VA = "0x183E4B650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class EJPLENAEIHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public DABOHCBKAFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <spawnLocalPlayerTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private CancellationTokenSource <timeoutTcs>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private CancellationToken <timeoutToken>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public EJPLENAEIHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3E4CD70", Offset = "0x3E4BF70", VA = "0x183E4CD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class DFFAELJFEGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public LPHBDDFNIEM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public DABOHCBKAFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private int <version>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private bool <canUpdateRoom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x55")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private bool <shouldSave>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x56")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private bool <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private TaskAwaiter<FGEDLIOJPHD> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public DFFAELJFEGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3E4C5E0", Offset = "0x3E4B7E0", VA = "0x183E4C5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class MDNDFAIKDCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public KDLCCGABAHG targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public MDNDFAIKDCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3E596F0", Offset = "0x3E588F0", VA = "0x183E596F0")]
		internal object GCAKGFGHCJM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class KAHNAMNGBKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public KAHNAMNGBKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3E57E20", Offset = "0x3E57020", VA = "0x183E57E20")]
		internal void AEOOIAMFDHB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class KNOELFBECOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public KDLCCGABAHG targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public KNOELFBECOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3E58C30", Offset = "0x3E57E30", VA = "0x183E58C30")]
		internal object OELBAEFGMIJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class CDOECPDJHIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public KDLCCGABAHG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public CDOECPDJHIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3E48BF0", Offset = "0x3E47DF0", VA = "0x183E48BF0")]
		internal string JIPKNPKDOIK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly PEKDFCFCENH ENCLCINDEHJ;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly PEKDFCFCENH OEEGANELJMI;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly PEKDFCFCENH CLLANOLINCL;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static readonly string CBOIFKBMFNO;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static readonly string IAFCFMLKGCC;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly string GBKJAJECBEO;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly Guid HLNALEKMOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private KPKLBEKJJDL ELHDKJIFJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private ADEGNLPFACK HHGCDIJMEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private ALKNFJDHKDJ FPIOPDMALNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private GGGLHECDAMD BFBBPILOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private KANPCPNLPMN LJKHADFBIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private PJLINKOOKPL PNBMBCDGIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private NGEKBCOEECJ JGCOKEDLLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private GBNLMHKMPCE GMLEHOPIEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private GGDCLFNNDGD EKPFECEECGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private MLAIMLPDPAE GBBLODABHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private IDisposable CCBALAHDIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly DEILOLEAADK AGECLCHEBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly DEILOLEAADK IMEKJMGCLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EKENKMHAPBN JOKHPKPGHHK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public TaskStatus GDJKIIAHEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xFCB3F0", Offset = "0xFCA5F0", VA = "0x180FCB3F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xFCB3D0", Offset = "0xFCA5D0", VA = "0x180FCB3D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private NBJPFMBJGMB LJJGEEJCHJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1F62790", Offset = "0x1F61990", VA = "0x181F62790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1F62FD0", Offset = "0x1F621D0", VA = "0x181F62FD0", Slot = "6")]
	public void KCEHONPEIFO(GGGLHECDAMD BFBBPILOBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1F62320", Offset = "0x1F61520", VA = "0x181F62320", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1F62E30", Offset = "0x1F62030", VA = "0x181F62E30", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GFOJNCONHLL))]
	public Task KBDKLJCMHLB(KDLCCGABAHG ACAELJFOOBM, JFCNENLAIHN NALGJPOFHKM, CancellationToken JIEKCCCMBMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1F62A60", Offset = "0x1F61C60", VA = "0x181F62A60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EOFMNJIFELH))]
	private Task HHMCHGFKKDE(KDLCCGABAHG ACAELJFOOBM, JFCNENLAIHN NALGJPOFHKM, CancellationToken JIEKCCCMBMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1F61190", Offset = "0x1F60390", VA = "0x181F61190")]
	private static void AIMBBOCPLCM(GGDCLFNNDGD EKPFECEECGM, KDLCCGABAHG ACAELJFOOBM, Exception JBOMBKDPEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1F639A0", Offset = "0x1F62BA0", VA = "0x181F639A0")]
	private static void NEIEPPFILJP(JGALLCINBGJ PLDPNLDFPJP, Exception JBOMBKDPEGF, [Optional] List<int> EKNAIGFDOLN, int CNOFFIPNANP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1F60EC0", Offset = "0x1F600C0", VA = "0x181F60EC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FOOMCEODKBP))]
	private Task AECCMOHGOEJ(GAKPIOFBDII<string>.JOKPHMHCDCF ENNBBCEBKAC, KDLCCGABAHG ACAELJFOOBM, JFCNENLAIHN NALGJPOFHKM, MDHCFBFJDKN JCKJBCGOGNO, CancellationToken JIEKCCCMBMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1F64790", Offset = "0x1F63990", VA = "0x181F64790")]
	private void PEGMMOBKDAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1F62530", Offset = "0x1F61730", VA = "0x181F62530")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IJGDIDLEBAA))]
	private Task FEENKNGEHFH(GAKPIOFBDII<string>.JOKPHMHCDCF ENNBBCEBKAC, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1F63460", Offset = "0x1F62660", VA = "0x181F63460")]
	private void LHICHCIPEOH(KDLCCGABAHG ACAELJFOOBM, CancellationToken JIEKCCCMBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1F618C0", Offset = "0x1F60AC0", VA = "0x181F618C0")]
	private void BIGJIMNLEED(KDLCCGABAHG ACAELJFOOBM, MDHCFBFJDKN JCKJBCGOGNO, OperationCanceledException FHJNFIONEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1F61ED0", Offset = "0x1F610D0", VA = "0x181F61ED0")]
	private void DAJMDBFHHGD(KDLCCGABAHG ACAELJFOOBM, MDHCFBFJDKN JCKJBCGOGNO, Exception JBOMBKDPEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1F62850", Offset = "0x1F61A50", VA = "0x181F62850")]
	private void HHINGCBCPFF(KDLCCGABAHG ACAELJFOOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1F626A0", Offset = "0x1F618A0", VA = "0x181F626A0")]
	private static CONHHIMJCNJ FHFDNDEJBKP(KDLCCGABAHG ACAELJFOOBM)
	{
		return default(CONHHIMJCNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1F64500", Offset = "0x1F63700", VA = "0x181F64500")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IPKCBAHDMMJ))]
	private Task OOIAKCKJMHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1F62C90", Offset = "0x1F61E90", VA = "0x181F62C90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JMMMCGNEHBG))]
	private Task<Matchmaking.OKPCCFFGNKM> JHMNBLFGANP(KDLCCGABAHG ACAELJFOOBM, GAKPIOFBDII<string>.JOKPHMHCDCF ENNBBCEBKAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1F61B00", Offset = "0x1F60D00", VA = "0x181F61B00")]
	private static NNGBEGHHEFA BMBBMIPKMMJ(Matchmaking.OKPCCFFGNKM DHHPIIEDNHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1F61D10", Offset = "0x1F60F10", VA = "0x181F61D10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LAKOBNAKAPG))]
	private Task CLLDKPJLGGK(Matchmaking.OKPCCFFGNKM DHHPIIEDNHK, MDHCFBFJDKN JCKJBCGOGNO, GAKPIOFBDII<string>.JOKPHMHCDCF ENNBBCEBKAC, CancellationToken HBJKEFJEIIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1F62180", Offset = "0x1F61380", VA = "0x181F62180")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HHFEEAMPDBP))]
	private Task DOFEPMBBFPB(KDLCCGABAHG ACAELJFOOBM, CancellationTokenSource HLLBCCBKPCN, Task NNAFJNJHDNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1F616C0", Offset = "0x1F608C0", VA = "0x181F616C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CPKJLHOANDM))]
	private Task BGFFEAFHIHI(NAFOEDAKNOD LMDLDLEHDDN, LDFPHEEBEDP GAAMHIGAPHP, KDLCCGABAHG PDAGFOFIPAJ, MDHCFBFJDKN PLLJPEEOGIE, GAKPIOFBDII<string>.JOKPHMHCDCF ENNBBCEBKAC, CancellationToken MCMLEDLEPBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1F62370", Offset = "0x1F61570", VA = "0x181F62370")]
	private MDHCFBFJDKN EOCODBKHCHB(MDHCFBFJDKN PLLJPEEOGIE, ref CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1F61550", Offset = "0x1F60750", VA = "0x181F61550")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EJPLENAEIHH))]
	private Task AOFCEHPBGNO(GAKPIOFBDII<string>.JOKPHMHCDCF ENNBBCEBKAC, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1F64620", Offset = "0x1F63820", VA = "0x181F64620")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DFFAELJFEGF))]
	private Task PBAOHOAGFCI(LPHBDDFNIEM JFGIPFOFKHL, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1F632F0", Offset = "0x1F624F0", VA = "0x181F632F0")]
	private static void KPBIPMBAMIF(KDLCCGABAHG ACAELJFOOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1F63780", Offset = "0x1F62980", VA = "0x181F63780")]
	private void MPADCPBPEEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1F62C00", Offset = "0x1F61E00", VA = "0x181F62C00")]
	private void JFJKLPAFADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1F62700", Offset = "0x1F61900", VA = "0x181F62700")]
	private void FJNKCAJJHGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1F63260", Offset = "0x1F62460", VA = "0x181F63260")]
	private void KDJOGIHEIIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1F61C10", Offset = "0x1F60E10", VA = "0x181F61C10")]
	private static void BNBJBBKGAGN(KDLCCGABAHG ACAELJFOOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1F610A0", Offset = "0x1F602A0", VA = "0x181F610A0")]
	private static CancellationTokenRegistration AIABKBBMADL(KDLCCGABAHG ACAELJFOOBM, CancellationToken HBJKEFJEIIC)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1F641D0", Offset = "0x1F633D0", VA = "0x181F641D0")]
	private static void NJOOLMPNBBO(KDLCCGABAHG ACAELJFOOBM, Exception JBOMBKDPEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1F642D0", Offset = "0x1F634D0", VA = "0x181F642D0")]
	private void OHPAGEKBDHH(KDLCCGABAHG ACAELJFOOBM, Task NNAFJNJHDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1F627E0", Offset = "0x1F619E0", VA = "0x181F627E0")]
	private static void GMDPMBHBMHO(Func<string> CLEOAKJCLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1F64AD0", Offset = "0x1F63CD0", VA = "0x181F64AD0")]
	public DABOHCBKAFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1F62110", Offset = "0x1F61310", VA = "0x181F62110")]
	[CompilerGenerated]
	internal static (int, int?) DHHEDEOMHDI(INCLMMPMLDF CGJBDJNHGPB)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface HHLEGOLKPOO
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PINPMIPFEPJ<PJPFDBKHDOJ, EAICBCFAACM>> BFCHDJNDDDA(string JHFBHDCCEFE, long FNJOKPDAGJN, NKKIHOOPLKJ.JLLODPBOBLL NNLODNNNDLH, CancellationToken MELLLMEKJLC);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal class GOBHPMKOKLM : NHNFGFKABKN<GBOAMHGCLHL>
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class KJGBOBENMFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public GBOAMHGCLHL message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public KJGBOBENMFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3AE2B60", Offset = "0x3AE1D60", VA = "0x183AE2B60")]
		internal object JNJCCPHODPF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static readonly GOBHPMKOKLM JHOAALADPKE;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1F6F3E0", Offset = "0x1F6E5E0", VA = "0x181F6F3E0")]
	public ExitGames.Client.Photon.Hashtable IOAMGHHAJNN(GBOAMHGCLHL JPOEHOENKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1F6F190", Offset = "0x1F6E390", VA = "0x181F6F190", Slot = "5")]
	protected override void EJONLGMEKCM(GBOAMHGCLHL JPOEHOENKPI, IDictionary<object, object> JFGIPFOFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1F6F460", Offset = "0x1F6E660", VA = "0x181F6F460", Slot = "6")]
	public override GBOAMHGCLHL JHIOLOAEPHF(IDictionary<object, object> JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1F6F2C0", Offset = "0x1F6E4C0", VA = "0x181F6F2C0")]
	private static void GMDPMBHBMHO(string ELIOMKBNADL, GBOAMHGCLHL JPOEHOENKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1F6F9E0", Offset = "0x1F6EBE0", VA = "0x181F6F9E0")]
	public GOBHPMKOKLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x1F6F660", Offset = "0x1F6E860", VA = "0x181F6F660")]
	[CompilerGenerated]
	internal static string KOKGNCMNMPH(NAFOEDAKNOD GJNKBDPFGGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface DDMOHEMDKOH<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PINPMIPFEPJ<byte[], EAICBCFAACM>> NDHCJLKPDNI(TGetDataArg CIKBJELAGAP, CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PINPMIPFEPJ<GKGNJAPPBLB<TData>, EAICBCFAACM> BJCOHDFPAMK(byte[] JFGIPFOFKHL);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface FIJJFANJMMC : HHPIKNMCMBP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FGEDLIOJPHD LOBFNOABJLL(CPCMBHAGMBL NHLBBNCBMOF);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class LMCBJJJMGEK : PKDIIABCKLO, FJPDCCNGODG, ILNACKPLCPP, LIHLNNEIDFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly FJPDCCNGODG LDFCLKJGPHI;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public CPCMBHAGMBL AFECNDFGPLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x28ADC20", Offset = "0x28ACE20", VA = "0x1828ADC20", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int JIAEMLEGGDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x28AD9A0", Offset = "0x28ACBA0", VA = "0x1828AD9A0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int AKDJJPIPNNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x28AD810", Offset = "0x28ACA10", VA = "0x1828AD810", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool MAJHLEHMHBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7E30C0", Offset = "0x7E22C0", VA = "0x1807E30C0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int KEJMGGCEKJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x890110", Offset = "0x88F310", VA = "0x180890110", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event EOGNNODCNCJ.IGOIJFLBNNA PAHMDOGNFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event HCADKBKGOHH ANBFFEKDIEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x28AD860", Offset = "0x28ACA60", VA = "0x1828AD860", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x28AD770", Offset = "0x28AC970", VA = "0x1828AD770", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<bool> AFCOMFDLILF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<CPCMBHAGMBL> LEEDALILKCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action GOJCOAJOJPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x28AD9F0", Offset = "0x28ACBF0", VA = "0x1828AD9F0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x28AD900", Offset = "0x28ACB00", VA = "0x1828AD900", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x962030", Offset = "0x961230", VA = "0x180962030")]
	public LMCBJJJMGEK(FJPDCCNGODG LDFCLKJGPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x28ADB70", Offset = "0x28ACD70", VA = "0x1828ADB70", Slot = "8")]
	public bool NDJEAKONOPM(byte DALOMDBLGHH, ExitGames.Client.Photon.Hashtable HBIKPHDBPDM, FJBMOLBANMF MNCHAILDOCJ, SendOptions GMJGIMLMMEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x28ADA90", Offset = "0x28ACC90", VA = "0x1828ADA90", Slot = "16")]
	public CPCMBHAGMBL MGOKHNNEIEN(int EEKAMFMHHFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "19")]
	public void CFODHJIEENM(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "20")]
	public void HMDKHIJIDKK(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "21")]
	public void ECMDMOGPMNJ(object FDCOCHLAHJD, bool EDMIOIOHODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x28ADC70", Offset = "0x28ACE70", VA = "0x1828ADC70", Slot = "22")]
	public IDisposable ODJJJNLCBPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "23")]
	private bool KKBBFNODIEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "24")]
	public void IBCEKILENIP(StringBuilder DFMGHENBLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x28ADCD0", Offset = "0x28ACED0", VA = "0x1828ADCD0", Slot = "25")]
	public bool OJBFIKEFBAN(bool LCBMKCJPEHF, out string BMNKLBFFLLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x8BF3D0", Offset = "0x8BE5D0", VA = "0x1808BF3D0", Slot = "28")]
	public void LNPPHIJHLGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal struct BNMALNHFLLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly TaskCompletionSource<(FGEDLIOJPHD, Task)> FOKEFMEIBOK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Task<(FGEDLIOJPHD, Task)> FDLDLFMHPKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x1F5CE00", Offset = "0x1F5C000", VA = "0x181F5CE00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x1F5D0A0", Offset = "0x1F5C2A0", VA = "0x181F5D0A0")]
	public BNMALNHFLLO(TimeSpan JOGKMNMDFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1F5CE40", Offset = "0x1F5C040", VA = "0x181F5CE40")]
	public void GFCHPHKBLOG(Task CHEEIAMKAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1F5CF30", Offset = "0x1F5C130", VA = "0x181F5CF30")]
	public void IKCDBIOKBHD(FGEDLIOJPHD HBGNHMKPIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1F5CFC0", Offset = "0x1F5C1C0", VA = "0x181F5CFC0")]
	public void JGPFMPPPPDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1F5D010", Offset = "0x1F5C210", VA = "0x181F5D010")]
	internal void LDKAJGEGKGK(string JPOEHOENKPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal class JOKGOLHCCMI : FBKALKKBACA, CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private bool LDCHEMMNMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private LKGIPCJDHDA AGNNCCCKHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private ALKNFJDHKDJ FPIOPDMALNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private EMJBILGMCGN EDIJJHKDDAP;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public LKGIPCJDHDA NMBGPPEFELF
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1F769C0", Offset = "0x1F75BC0", VA = "0x181F769C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1F76A30", Offset = "0x1F75C30", VA = "0x181F76A30", Slot = "7")]
	public void KCEHONPEIFO(GGGLHECDAMD BFBBPILOBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x1F767C0", Offset = "0x1F759C0", VA = "0x181F767C0", Slot = "5")]
	public void BCEMEFNJCLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1F76980", Offset = "0x1F75B80", VA = "0x181F76980", Slot = "6")]
	public void IJEAOHANHOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1F76740", Offset = "0x1F75940", VA = "0x181F76740")]
	private Task BBPFBAKCANH(KIHMBFNPIKO JBFDNABELLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1F76980", Offset = "0x1F75B80", VA = "0x181F76980", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0xA3F7A0", Offset = "0xA3E9A0", VA = "0x180A3F7A0")]
	public JOKGOLHCCMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal struct CFIMCDMFDAK
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class BGIOEEAIMJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public GGGLHECDAMD manager;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public BGIOEEAIMJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x28A25C0", Offset = "0x28A17C0", VA = "0x1828A25C0")]
		internal Task CPDMAIKIKFA(LPHBDDFNIEM data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class HIHMGEENPIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public CFIMCDMFDAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private GMJLKBDAIPD <autosaveInfo>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private DOJNNAILMBC <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private DOJNNAILMBC <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private DOJNNAILMBC <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private TaskAwaiter<DOJNNAILMBC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private TaskAwaiter<FGEDLIOJPHD> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public HIHMGEENPIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x28A77A0", Offset = "0x28A69A0", VA = "0x1828A77A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class EABGLBAHHBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public CFIMCDMFDAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public EABGLBAHHBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x28A3710", Offset = "0x28A2910", VA = "0x1828A3710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly CancellationToken MELLLMEKJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly GGGLHECDAMD MHGFMGGOLKA;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private ALKNFJDHKDJ DPDAAMHMDLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x1F5D980", Offset = "0x1F5CB80", VA = "0x181F5D980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private KANPCPNLPMN JOECKGCKOMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x1F5DF70", Offset = "0x1F5D170", VA = "0x181F5DF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private NBJPFMBJGMB LJJGEEJCHJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x1F5DC80", Offset = "0x1F5CE80", VA = "0x181F5DC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private DBLLAAAALEB PINMHLKHODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1F5D9D0", Offset = "0x1F5CBD0", VA = "0x181F5D9D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x1F5E160", Offset = "0x1F5D360", VA = "0x181F5E160")]
	public CFIMCDMFDAK(CancellationToken MELLLMEKJLC, GGGLHECDAMD MHGFMGGOLKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x1F5DBC0", Offset = "0x1F5CDC0", VA = "0x181F5DBC0")]
	public static CMMCJABFBOJ ENHEIKOIAKK(GGGLHECDAMD MHGFMGGOLKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x1F5DD00", Offset = "0x1F5CF00", VA = "0x181F5DD00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HIHMGEENPIJ))]
	public Task<bool> GNJLBDDANJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x1F5DFC0", Offset = "0x1F5D1C0", VA = "0x181F5DFC0")]
	private bool ONPIHCLBCHH(out GMJLKBDAIPD OPBMLMJIHBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1F5DE50", Offset = "0x1F5D050", VA = "0x181F5DE50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EABGLBAHHBO))]
	private Task JGHMCKLCPGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x1F5DA20", Offset = "0x1F5CC20", VA = "0x181F5DA20")]
	private Task<DOJNNAILMBC> CAGBLBCFHLD(GMJLKBDAIPD LMCGGBKAHGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal class MINBPGAKJHI : EMJBILGMCGN
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class OFFAOPBBDGH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private readonly ABJPHNNDPLE CJGKPKOFFDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly string JCEGKCPOPDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly T HMGHIIACOGF;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T HDFPEMDEFEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xAAB280", Offset = "0xAAA480", VA = "0x180AAB280")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xAAB100", Offset = "0xAAA300", VA = "0x180AAB100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x201B950", Offset = "0x201AB50", VA = "0x18201B950")]
		public OFFAOPBBDGH(ABJPHNNDPLE CJGKPKOFFDL, string JCEGKCPOPDM, T HMGHIIACOGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201A900", VA = "0x18201B700")]
		private void ACEHPNKMBJM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ABJPHNNDPLE CJGKPKOFFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly OFFAOPBBDGH<TimeSpan> GOKLBLBMAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly OFFAOPBBDGH<TimeSpan> AFBILEBIICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly OFFAOPBBDGH<TimeSpan> AGCAICCDAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly OFFAOPBBDGH<TimeSpan> KLEAFCBDMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly OFFAOPBBDGH<bool> JBHCPPDHDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly OFFAOPBBDGH<bool> GAFECCBMPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly OFFAOPBBDGH<bool> FGLEHBJHMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly OFFAOPBBDGH<int> AHIKACEDDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly OFFAOPBBDGH<bool> KNMHHPFGADH;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TimeSpan CMADLLNAPFN
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x28B2620", Offset = "0x28B1820", VA = "0x1828B2620", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TimeSpan IFEGBFPKIPO
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x28B27E0", Offset = "0x28B19E0", VA = "0x1828B27E0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TimeSpan NECGCGNJEIA
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x28B2660", Offset = "0x28B1860", VA = "0x1828B2660", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TimeSpan KEPEDLANLLO
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x28B2760", Offset = "0x28B1960", VA = "0x1828B2760", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool HOIIKDFKOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x28B26A0", Offset = "0x28B18A0", VA = "0x1828B26A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool ILGHPGJFGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x28B25E0", Offset = "0x28B17E0", VA = "0x1828B25E0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool IKPAPJEAHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x28B27A0", Offset = "0x28B19A0", VA = "0x1828B27A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int DEMEAFHEBCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x28B26E0", Offset = "0x28B18E0", VA = "0x1828B26E0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool PBADOLPDPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x28B2720", Offset = "0x28B1920", VA = "0x1828B2720", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x28B2820", Offset = "0x28B1A20", VA = "0x1828B2820")]
	[UnityEngine.Scripting.Preserve]
	public MINBPGAKJHI([NDGONEEEGIA(null)] ABJPHNNDPLE CJGKPKOFFDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal struct BDIDECKAKEA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class CGNIJPALIAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public BDIDECKAKEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private List<Task> <tasks>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public CGNIJPALIAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x28A2600", Offset = "0x28A1800", VA = "0x1828A2600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly CancellationTokenSource OEIHHLAPKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private bool OLAIFPCFFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private Task EEILDIKJMBL;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool HEOJOBHHAMK
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x1F5B700", Offset = "0x1F5A900", VA = "0x181F5B700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x1F5B780", Offset = "0x1F5A980", VA = "0x181F5B780")]
	public BDIDECKAKEA(CancellationToken MELLLMEKJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x1F5B5A0", Offset = "0x1F5A7A0", VA = "0x181F5B5A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CGNIJPALIAD))]
	public Task AGBEKNKAPEE(Func<CancellationToken, List<Task>> COBGGDDGIMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x1F5B730", Offset = "0x1F5A930", VA = "0x181F5B730", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal interface DFIJEPJBKAJ : CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NIJBFDNCANL CKPKOIJGHLD(Guid OAOAFDNAJNM);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HCICIMHFKFM(Guid OAOAFDNAJNM);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FNANCFKMAIB(Guid OAOAFDNAJNM, Task CHEEIAMKAGL);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PAEMNFPCEEJ(Guid OAOAFDNAJNM, FGEDLIOJPHD BIHGHHPKHND);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(FGEDLIOJPHD, Task)> ABLKHDIAKOJ(Guid OAOAFDNAJNM);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal interface BFHFKPNDBGJ : CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FGEDLIOJPHD DNFHMMIBCOJ(CPCMBHAGMBL IDJKEADFEIO, COPCGKNOMKI ENJDJKNAHAK);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FGEDLIOJPHD KMKNKILEMIJ(CPCMBHAGMBL NHLBBNCBMOF);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal class EAGFPFNJGPD : DADHPGKOHBD
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class EONPMJEMJMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public EAGFPFNJGPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private KDLCCGABAHG <localRoomInstance>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private KDLCCGABAHG <newPresenceRoomInstance>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private float <timeoutTime>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public EONPMJEMJMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3E4EB60", Offset = "0x3E4DD60", VA = "0x183E4EB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly GGGLHECDAMD BFBBPILOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly KANPCPNLPMN LJKHADFBIKG;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private NBJPFMBJGMB LJJGEEJCHJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1F67300", Offset = "0x1F66500", VA = "0x181F67300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x927D00", Offset = "0x926F00", VA = "0x180927D00")]
	public EAGFPFNJGPD(GGGLHECDAMD BFBBPILOBDE, KANPCPNLPMN LJKHADFBIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x1F67190", Offset = "0x1F66390", VA = "0x181F67190", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EONPMJEMJMM))]
	public Task<bool> EJNNGEAFANP(CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1F67350", Offset = "0x1F66550", VA = "0x181F67350")]
	[CompilerGenerated]
	private object PHKAEKGMLAJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal interface JELOKDHPDJI : CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LICJOLPIMOC(GBOAMHGCLHL JPOEHOENKPI);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NPANEEGFGJB(GBOAMHGCLHL JPOEHOENKPI);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<COPCGKNOMKI> CEMFMMIHIMF(CancellationToken NNJCAEDFEIM);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal interface LCLLGEFLIBP : CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FGEDLIOJPHD HHEHOAPHLIE(CPCMBHAGMBL IDJKEADFEIO);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GPCJOJNBKLF(string NOFBJAIDPEL);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[UnityEngine.Scripting.Preserve]
internal class DIIAKABALLF : NGEKBCOEECJ, CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class GFKJCDECIBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public DIIAKABALLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public GFKJCDECIBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3E52490", Offset = "0x3E51690", VA = "0x183E52490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly DEILOLEAADK NAJLOCONLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private string MFMBFEGEDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private Task JMIOJIFHGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private GGGLHECDAMD BFBBPILOBDE;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool ACIIDLIMGDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x1F64BB0", Offset = "0x1F63DB0", VA = "0x181F64BB0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public Task LALLGJNEPFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x1F64F10", Offset = "0x1F64110", VA = "0x181F64F10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x88F7E0", Offset = "0x88E9E0", VA = "0x18088F7E0", Slot = "7")]
	public void KCEHONPEIFO(GGGLHECDAMD BFBBPILOBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x1F64D50", Offset = "0x1F63F50", VA = "0x181F64D50", Slot = "6")]
	public void DMBOFCLDFIB(Task EEILDIKJMBL, string PONLGNOMPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x1F64BE0", Offset = "0x1F63DE0", VA = "0x181F64BE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GFKJCDECIBK))]
	private Task DEGPFGAPFBI(Task CFMLNJGJABG, string PONLGNOMPCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x1F64F70", Offset = "0x1F64170", VA = "0x181F64F70")]
	public DIIAKABALLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal struct NIJBFDNCANL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly DFIJEPJBKAJ PLDBGCAPDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly Guid OAOAFDNAJNM;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Task<(FGEDLIOJPHD, Task)> FDLDLFMHPKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x28B5990", Offset = "0x28B4B90", VA = "0x1828B5990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x15BC7D0", Offset = "0x15BB9D0", VA = "0x1815BC7D0")]
	public NIJBFDNCANL(DFIJEPJBKAJ PLDBGCAPDNH, Guid OAOAFDNAJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x28B5B30", Offset = "0x28B4D30", VA = "0x1828B5B30")]
	public TaskAwaiter<(FGEDLIOJPHD, Task)> MNBEJFECGED()
	{
		return default(TaskAwaiter<(FGEDLIOJPHD, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x28B5A60", Offset = "0x28B4C60", VA = "0x1828B5A60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[UnityEngine.Scripting.Preserve]
internal sealed class JPDILAKLFBI : DBLLAAAALEB, CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class JJGGLFBCIJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public AsyncTaskMethodBuilder<FGEDLIOJPHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public GMJLKBDAIPD autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public JPDILAKLFBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private GAKPIOFBDII<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private PJADLMCHFPP <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private NAFOEDAKNOD <roomLoadPayload>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private FGEDLIOJPHD <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private TaskAwaiter<FGEDLIOJPHD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public JJGGLFBCIJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0980", Offset = "0x3ADFB80", VA = "0x183AE0980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class OBCKDMLOCKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public JPDILAKLFBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private CancellationTokenSource <combinedTokenSource>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public OBCKDMLOCKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3AE68E0", Offset = "0x3AE5AE0", VA = "0x183AE68E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class HCBPMGBNHPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public LPHBDDFNIEM _;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public JPDILAKLFBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public HCBPMGBNHPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3ADC490", Offset = "0x3ADB690", VA = "0x183ADC490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class GOCEIJDHKPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public JPDILAKLFBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private object <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private int <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public GOCEIJDHKPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3ADBF20", Offset = "0x3ADB120", VA = "0x183ADBF20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class EEELCNNLHNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public JPDILAKLFBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public EEELCNNLHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3ADA190", Offset = "0x3AD9390", VA = "0x183ADA190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class BDCPPHEMGIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public JPDILAKLFBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private CancellationToken <nextAutosaveToken>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public BDCPPHEMGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3AD7180", Offset = "0x3AD6380", VA = "0x183AD7180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class CMFALELLEFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public JPDILAKLFBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private Task <delayTask>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private Task<int> <intervalChangedTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private Task <resultTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private Task <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public CMFALELLEFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9D20", Offset = "0x3AD8F20", VA = "0x183AD9D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class IIEFGFPJIGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public BIPGMDDBGPD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public JPDILAKLFBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private GAKPIOFBDII<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private MDHCFBFJDKN <operationPauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private NNHLNONEOHJ <autosaveOp>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public IIEFGFPJIGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3ADEC40", Offset = "0x3ADDE40", VA = "0x183ADEC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private ALKNFJDHKDJ FPIOPDMALNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private GGGLHECDAMD BFBBPILOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private KANPCPNLPMN LJKHADFBIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private JIPBJFBAGHG MANAFLPNCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private NGEKBCOEECJ JGCOKEDLLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private NNLHBEANOAE EGHDBPOCILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private CancellationTokenSource APMLPPGNCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private Task KKCFFMJMGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private TaskCompletionSource<int> JIOFOOHABCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int LFKODKJKKBL;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x28A9790", Offset = "0x28A8990", VA = "0x1828A9790", Slot = "6")]
	public void KCEHONPEIFO(GGGLHECDAMD BFBBPILOBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xD134D0", Offset = "0xD126D0", VA = "0x180D134D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x28A9940", Offset = "0x28A8B40", VA = "0x1828A9940")]
	private void KFGHPAHDJEC(float DBHIJMNFOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x28A9A20", Offset = "0x28A8C20", VA = "0x1828A9A20", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JJGGLFBCIJN))]
	public Task<FGEDLIOJPHD> LFOKINGHCPB(GMJLKBDAIPD OPBMLMJIHBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x28AA0F0", Offset = "0x28A92F0", VA = "0x1828AA0F0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OBCKDMLOCKM))]
	public Task PALEOIEBKEB([Optional] CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xD134D0", Offset = "0xD126D0", VA = "0x180D134D0")]
	public void PCNAFONLGJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x28AA390", Offset = "0x28A9590", VA = "0x1828AA390")]
	private PJADLMCHFPP PFGOGLHMBLD(GMJLKBDAIPD OPBMLMJIHBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x28A9E30", Offset = "0x28A9030", VA = "0x1828A9E30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HCBPMGBNHPF))]
	private Task NOJMJNHIMAC(LPHBDDFNIEM JBFDNABELLI, CancellationToken JIEKCCCMBMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x28AA240", Offset = "0x28A9440", VA = "0x1828AA240")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GOCEIJDHKPA))]
	private Task PFEHADFGGOC(CancellationToken JIEKCCCMBMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x28A9CE0", Offset = "0x28A8EE0", VA = "0x1828A9CE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EEELCNNLHNE))]
	private Task NDPCOPLBEOB([Optional] CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x28A9B90", Offset = "0x28A8D90", VA = "0x1828A9B90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BDCPPHEMGIN))]
	private Task LKKJBMFKNBO(CancellationToken JIEKCCCMBMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x28A9FA0", Offset = "0x28A91A0", VA = "0x1828A9FA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CMFALELLEFC))]
	private Task PAEPAPKOMOA(CancellationToken LOPICCCLDLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x28A91B0", Offset = "0x28A83B0", VA = "0x1828A91B0")]
	private Task AIGKGPHIFGN(BIPGMDDBGPD BHKOGCBJNKO, CancellationToken JIEKCCCMBMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x28A94C0", Offset = "0x28A86C0", VA = "0x1828A94C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IIEFGFPJIGF))]
	private Task GLPKDCDBBCN(BIPGMDDBGPD BHKOGCBJNKO, CancellationToken JIEKCCCMBMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x28A9620", Offset = "0x28A8820", VA = "0x1828A9620")]
	private bool HHEHOAPHLIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public JPDILAKLFBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface IJHNPMDMGIK : HHPIKNMCMBP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FGEDLIOJPHD HHEHOAPHLIE(CPCMBHAGMBL BJENOGCANAN);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[UnityEngine.Scripting.Preserve]
internal class DKLIDBCPBPM : LAPGCNHFJDO, CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class JOBOBACIJKB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly KDLCCGABAHG LLHBCCHGJPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly CancellationTokenSource OEIHHLAPKPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public readonly CancellationToken JDDJPKHEHEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private bool MLLHJKHGHHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private bool IFCDFOBKGCM;

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3E57D70", Offset = "0x3E56F70", VA = "0x183E57D70")]
		public JOBOBACIJKB(KDLCCGABAHG LLHBCCHGJPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3E57BE0", Offset = "0x3E56DE0", VA = "0x183E57BE0")]
		public void ACJHAMOBBFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3E57D40", Offset = "0x3E56F40", VA = "0x183E57D40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class EBLEKINIKDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public KIHMBFNPIKO disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public EBLEKINIKDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3E4CC60", Offset = "0x3E4BE60", VA = "0x183E4CC60")]
		internal object EHOFIIEKBHN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class JFJNFLNKKKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public KIHMBFNPIKO disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public DKLIDBCPBPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private EBLEKINIKDH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public JFJNFLNKKKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3E56700", Offset = "0x3E55900", VA = "0x183E56700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class COMPANLLLBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public COMPANLLLBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3E4B110", Offset = "0x3E4A310", VA = "0x183E4B110")]
		internal object GFIIIGIEFJB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class JGKEMCMEKDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public DKLIDBCPBPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private COMPANLLLBH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private IDisposable <logFlagsScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private IDisposable <logTraceScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private IDisposable <logRegistryScope>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private IDisposable <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private IDisposable <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private IDisposable <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private KDLCCGABAHG <newRoomInstance>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private JFCNENLAIHN <customRoomLoadPayload>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private Exception <ex>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public JGKEMCMEKDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3E56AA0", Offset = "0x3E55CA0", VA = "0x183E56AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class CJHOIHOJMJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public KDLCCGABAHG newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public CJHOIHOJMJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3E49490", Offset = "0x3E48690", VA = "0x183E49490")]
		internal object MKCONBCBCIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3E49530", Offset = "0x3E48730", VA = "0x183E49530")]
		internal object MODBGKCJOBJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3E49450", Offset = "0x3E48650", VA = "0x183E49450")]
		internal object APBIMLAADIB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class AGDLMKJADKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public AGDLMKJADKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3E47B10", Offset = "0x3E46D10", VA = "0x183E47B10")]
		internal void BJBIMEPJBLG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class KLDDFPGGJKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public KDLCCGABAHG newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public JFCNENLAIHN customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public DKLIDBCPBPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private CJHOIHOJMJI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private AGDLMKJADKJ <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private CancellationToken <token>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private CancellationTokenRegistration <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private object <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private int <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private OperationCanceledException <oce>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private Exception <ex>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public KLDDFPGGJKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3E57EC0", Offset = "0x3E570C0", VA = "0x183E57EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private static readonly IJPDCLCEFFF.AHDEJJKHKMI GBMOHBMHJMD;

	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private static readonly LNKLKDIODGL NFNJDAFFGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private ADEGNLPFACK HHGCDIJMEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private GGGLHECDAMD BFBBPILOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private PJLINKOOKPL PNBMBCDGIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private KANPCPNLPMN LJKHADFBIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private EMJBILGMCGN EDIJJHKDDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private EAEEJEIDIPI EGMFBGHNICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private long FOLGIMOPBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private JOBOBACIJKB OPCLJALGALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private bool NGABHBHPMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private Task KBDGFAAJMEG;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private NBJPFMBJGMB LJJGEEJCHJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x1F65FB0", Offset = "0x1F651B0", VA = "0x181F65FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool HGHFHGJOJMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x90C1D0", Offset = "0x90B3D0", VA = "0x18090C1D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x1F66BF0", Offset = "0x1F65DF0", VA = "0x181F66BF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x1F66660", Offset = "0x1F65860", VA = "0x181F66660", Slot = "4")]
	public void KCEHONPEIFO(GGGLHECDAMD BFBBPILOBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x1F65E30", Offset = "0x1F65030", VA = "0x181F65E30", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x1F66260", Offset = "0x1F65460", VA = "0x181F66260")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JFJNFLNKKKE))]
	private Task HLJGDIAOIBE(KIHMBFNPIKO GJCEMCKPCJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x1F65AF0", Offset = "0x1F64CF0", VA = "0x181F65AF0")]
	private void AIHNMCABPCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x1F65C90", Offset = "0x1F64E90", VA = "0x181F65C90")]
	private void CJEMKFIFNIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x1F668B0", Offset = "0x1F65AB0", VA = "0x181F668B0")]
	private void LHJJECKAMHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x1F66A80", Offset = "0x1F65C80", VA = "0x181F66A80")]
	private bool OILOPJFFLDI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x1F66B00", Offset = "0x1F65D00", VA = "0x181F66B00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JGKEMCMEKDJ))]
	private void PKOBHCELHHP(int MIOMNEOFMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x1F663A0", Offset = "0x1F655A0", VA = "0x181F663A0")]
	private void KBLMLOHEAIL(out IDisposable PALIGNNFNBF, out IDisposable CPBMKECMKLI, out IDisposable LOPCCKJFCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x1F66000", Offset = "0x1F65200", VA = "0x181F66000")]
	private bool GGLKHFJCLNK(KDLCCGABAHG LLHBCCHGJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x1F66A40", Offset = "0x1F65C40", VA = "0x181F66A40")]
	private void MANBDFHJBDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x1F660F0", Offset = "0x1F652F0", VA = "0x181F660F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KLDDFPGGJKI))]
	private Task HHMCHGFKKDE(KDLCCGABAHG LLHBCCHGJPC, JFCNENLAIHN NALGJPOFHKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x1F67050", Offset = "0x1F66250", VA = "0x181F67050")]
	public DKLIDBCPBPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[UnityEngine.Scripting.Preserve]
internal sealed class MDBBIGLBDEM : PAJNMOEGIGE, CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class HHDFEKKCHKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public HHDFEKKCHKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x4EE4D70", Offset = "0x4EE3F70", VA = "0x184EE4D70")]
		internal object EGLCFFBKBPI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class BBKNCLILLBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public BBKNCLILLBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x4EE2F20", Offset = "0x4EE2120", VA = "0x184EE2F20")]
		internal object EKOHPDDKKMO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private ALKNFJDHKDJ FPIOPDMALNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private BFHFKPNDBGJ AEAAOAENKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private JELOKDHPDJI BOJGEHKFCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private DFIJEPJBKAJ PLDBGCAPDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private PLMDPHAGAEE MNIHEGBFIBB;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x28B0B20", Offset = "0x28AFD20", VA = "0x1828B0B20", Slot = "6")]
	public void KCEHONPEIFO(GGGLHECDAMD BFBBPILOBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x28B0150", Offset = "0x28AF350", VA = "0x1828B0150", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x28B01F0", Offset = "0x28AF3F0", VA = "0x1828B01F0", Slot = "4")]
	public NIJBFDNCANL GIGOKAIHLBK(GBOAMHGCLHL ACNPMGGIPME)
	{
		return default(NIJBFDNCANL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x28B1920", Offset = "0x28B0B20", VA = "0x1828B1920", Slot = "5")]
	public void NKPCAINNPCA(Guid OAOAFDNAJNM, Task CHEEIAMKAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x28B0080", Offset = "0x28AF280", VA = "0x1828B0080")]
	private void CFGNBFJICEB(byte DALOMDBLGHH, int KOBHCNPLFGJ, object AMGBIPCCJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x28B0C90", Offset = "0x28AFE90", VA = "0x1828B0C90")]
	private void KEKMBHGJALF(HPBLEFKLNKJ BABPGEEPJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x28B1D20", Offset = "0x28B0F20", VA = "0x1828B1D20")]
	private void PLFKOJFKBOP(HPBLEFKLNKJ BABPGEEPJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x28B08D0", Offset = "0x28AFAD0", VA = "0x1828B08D0")]
	private void JOLLCOJPIKJ(HPBLEFKLNKJ BABPGEEPJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x28B16D0", Offset = "0x28B08D0", VA = "0x1828B16D0")]
	private FGEDLIOJPHD NIGGFGNOBCA(GBOAMHGCLHL GBANBELFDDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x28B14D0", Offset = "0x28B06D0", VA = "0x1828B14D0")]
	private void LGIBPLHLEIH(GBOAMHGCLHL FLNEBLMBGEF, FGEDLIOJPHD HBGNHMKPIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x28B1B30", Offset = "0x28B0D30", VA = "0x1828B1B30")]
	private bool PJJIEFMFAFO(GBOAMHGCLHL FLNEBLMBGEF, FGEDLIOJPHD HBGNHMKPIBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x28B12A0", Offset = "0x28B04A0", VA = "0x1828B12A0")]
	private bool KIACELNFEHH(GBOAMHGCLHL POIJMJPGHFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x28B0630", Offset = "0x28AF830", VA = "0x1828B0630")]
	private bool HHILEMHNFDI(byte DALOMDBLGHH, ExitGames.Client.Photon.Hashtable BABPGEEPJFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public MDBBIGLBDEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[UnityEngine.Scripting.Preserve]
internal sealed class AKHNGDBDLBL : JELOKDHPDJI, CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class PMJCHKLIOAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public AsyncTaskMethodBuilder<COPCGKNOMKI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public AKHNGDBDLBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private COPCGKNOMKI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private TaskAwaiter<COPCGKNOMKI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public PMJCHKLIOAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x28BAA40", Offset = "0x28B9C40", VA = "0x1828BAA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class KDHNHFBMBML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public GBOAMHGCLHL message;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public KDHNHFBMBML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x28AA650", Offset = "0x28A9850", VA = "0x1828AA650")]
		internal object FBEHAAFJOOP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class GBKFBINJKGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public GBOAMHGCLHL messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public GBKFBINJKGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x28A7120", Offset = "0x28A6320", VA = "0x1828A7120")]
		internal object BAILICFGIOA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class AOMLDAFMJDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public GBOAMHGCLHL request;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public AOMLDAFMJDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x28A1E80", Offset = "0x28A1080", VA = "0x1828A1E80")]
		internal object DLBOHJMIKIL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class DGLIAGIPBCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public GBOAMHGCLHL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public AKHNGDBDLBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private AOMLDAFMJDD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private IDGCAAGDMGH <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private IDGCAAGDMGH <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private TaskAwaiter<IDGCAAGDMGH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public DGLIAGIPBCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x28A3070", Offset = "0x28A2270", VA = "0x1828A3070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class HAJNJCGDEKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public GBOAMHGCLHL operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public HAJNJCGDEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x28A74D0", Offset = "0x28A66D0", VA = "0x1828A74D0")]
		internal object KNPFFDOBNNO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class NAMPMADAAHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public GBOAMHGCLHL operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public AKHNGDBDLBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private HAJNJCGDEKM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private MDHCFBFJDKN <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private GBOAMHGCLHL <syncedMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private IDGCAAGDMGH <operation>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private GBOAMHGCLHL <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private TaskAwaiter<GBOAMHGCLHL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public NAMPMADAAHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x28B3260", Offset = "0x28B2460", VA = "0x1828B3260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class FBKHHFJMIOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public AsyncTaskMethodBuilder<IDGCAAGDMGH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public GBOAMHGCLHL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public AKHNGDBDLBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private APOFPHAHIKC.HODEONBBDAD <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private MDHCFBFJDKN <pauseToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private GBOAMHGCLHL <response>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private GBOAMHGCLHL <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private TaskAwaiter<GBOAMHGCLHL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public FBKHHFJMIOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x28A6000", Offset = "0x28A5200", VA = "0x1828A6000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class FGIBKHHBMJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public IDGCAAGDMGH operation;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public FGIBKHHBMJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x28A6530", Offset = "0x28A5730", VA = "0x1828A6530")]
		internal object EOKCCIEGKHD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class BCALMGNNMKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public IDGCAAGDMGH operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public AKHNGDBDLBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private FGIBKHHBMJK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private GAKPIOFBDII<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <timerScope>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private Task <task>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public BCALMGNNMKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x28A1EE0", Offset = "0x28A10E0", VA = "0x1828A1EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class MEJHLEABHNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public GBOAMHGCLHL request;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public MEJHLEABHNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x28B1FA0", Offset = "0x28B11A0", VA = "0x1828B1FA0")]
		internal object FMKKOECELOP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class EPPKFNBJBOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public GBOAMHGCLHL request;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public EPPKFNBJBOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x28A5F60", Offset = "0x28A5160", VA = "0x1828A5F60")]
		internal object CGGLIOGDNNF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private GGGLHECDAMD BFBBPILOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private NGEKBCOEECJ JGCOKEDLLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private PAJNMOEGIGE CJPOPBAOCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private JIPBJFBAGHG MANAFLPNCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private ALKNFJDHKDJ FPIOPDMALNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private TaskCompletionSource<COPCGKNOMKI> NMCDBLOOILH;

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x1F581D0", Offset = "0x1F573D0", VA = "0x181F581D0", Slot = "7")]
	public void KCEHONPEIFO(GGGLHECDAMD BFBBPILOBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x1F57710", Offset = "0x1F56910", VA = "0x181F57710", Slot = "6")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PMJCHKLIOAP))]
	public Task<COPCGKNOMKI> CEMFMMIHIMF(CancellationToken NNJCAEDFEIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x1F582B0", Offset = "0x1F574B0", VA = "0x181F582B0", Slot = "4")]
	public void LICJOLPIMOC(GBOAMHGCLHL JPOEHOENKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x1F586D0", Offset = "0x1F578D0", VA = "0x181F586D0", Slot = "5")]
	public void NPANEEGFGJB(GBOAMHGCLHL FAEMJKFDFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x1F58AB0", Offset = "0x1F57CB0", VA = "0x181F58AB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DGLIAGIPBCB))]
	private Task OAGHDDEIIEL(GBOAMHGCLHL DMFMJBFFPPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x1F57AA0", Offset = "0x1F56CA0", VA = "0x181F57AA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NAMPMADAAHG))]
	private Task GLGFDCHJFOL(GBOAMHGCLHL FLNEBLMBGEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1F57570", Offset = "0x1F56770", VA = "0x181F57570")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FBKHHFJMIOO))]
	private Task<IDGCAAGDMGH> AADLIPDOBPE(GBOAMHGCLHL DMFMJBFFPPI, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x1F57D60", Offset = "0x1F56F60", VA = "0x181F57D60")]
	private MDHCFBFJDKN HGNOHFCFDHC(GBOAMHGCLHL GBANBELFDDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x1F57BF0", Offset = "0x1F56DF0", VA = "0x181F57BF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BCALMGNNMKJ))]
	private Task HAKAIGOMKIF(IDGCAAGDMGH BGHGOMFIAIP, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x1F57880", Offset = "0x1F56A80", VA = "0x181F57880")]
	private IDGCAAGDMGH DNPCFBKLJBI(GBOAMHGCLHL DMFMJBFFPPI, MDHCFBFJDKN LAHNBFHCLHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x1FD02D0", Offset = "0x1FCF4D0", VA = "0x181FD02D0")]
	private T IOKKMGEHAFC<T>(T NABCGCEIEGG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x1F57DE0", Offset = "0x1F56FE0", VA = "0x181F57DE0")]
	private IDGCAAGDMGH JHNFMALKDFE(GBOAMHGCLHL DMFMJBFFPPI, MDHCFBFJDKN LAHNBFHCLHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public AKHNGDBDLBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal interface EMJBILGMCGN
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	TimeSpan CMADLLNAPFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	TimeSpan IFEGBFPKIPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	TimeSpan NECGCGNJEIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TimeSpan KEPEDLANLLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool HOIIKDFKOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool ILGHPGJFGIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool IKPAPJEAHJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int DEMEAFHEBCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool PBADOLPDPJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal interface FJEGMDKGNDL : CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NAFOEDAKNOD> MKDCIIGKLMD(GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, KDLCCGABAHG ACAELJFOOBM, CancellationToken MELLLMEKJLC);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal class LDKMLINKFFH : DADHPGKOHBD
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class NNOGALGFHBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public LDKMLINKFFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public Matchmaking.HGGMBHKOIED result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public KDLCCGABAHG newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public NNOGALGFHBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3AE66F0", Offset = "0x3AE58F0", VA = "0x183AE66F0")]
		internal object GIGJFMFBNON()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6680", Offset = "0x3AE5880", VA = "0x183AE6680")]
		internal object FDHCNEFIHHL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6840", Offset = "0x3AE5A40", VA = "0x183AE6840")]
		internal object OFOKOPLCNIB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class NIJADALHOAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public LDKMLINKFFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private NNOGALGFHBL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private Matchmaking.HGGMBHKOIED <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TaskAwaiter<Matchmaking.HGGMBHKOIED> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public NIJADALHOAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3AE5D00", Offset = "0x3AE4F00", VA = "0x183AE5D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly GGGLHECDAMD BFBBPILOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private readonly KANPCPNLPMN LJKHADFBIKG;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private NBJPFMBJGMB LJJGEEJCHJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x28AD1C0", Offset = "0x28AC3C0", VA = "0x1828AD1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x927D00", Offset = "0x926F00", VA = "0x180927D00")]
	public LDKMLINKFFH(GGGLHECDAMD BFBBPILOBDE, KANPCPNLPMN LJKHADFBIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x28AD050", Offset = "0x28AC250", VA = "0x1828AD050", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NIJADALHOAP))]
	public Task<bool> EJNNGEAFANP(CancellationToken MELLLMEKJLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal interface LAPGCNHFJDO : CKGJKOFFHNM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal interface DADHPGKOHBD
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> EJNNGEAFANP(CancellationToken MELLLMEKJLC);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public interface EGGHGMHHKBL
{
	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFKKKBOBBEL(JGALLCINBGJ DNGIONCECGP);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GPGEIGEFAAM(JGALLCINBGJ DNGIONCECGP);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GCLOGMBINGC(JGALLCINBGJ DNGIONCECGP);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FHNOPMNBLFM(JGALLCINBGJ DNGIONCECGP);
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class JGALLCINBGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public readonly KDLCCGABAHG OEEHDLGAHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private Dictionary<string, string> AJLFGELBIJH;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public GAKPIOFBDII<string> OAGKPJFMKGN
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x94C6C0", Offset = "0x94B8C0", VA = "0x18094C6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x8888D0", Offset = "0x887AD0", VA = "0x1808888D0")]
	public JGALLCINBGJ(KDLCCGABAHG PEBBOOOPJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x1F76480", Offset = "0x1F75680", VA = "0x181F76480")]
	public JGALLCINBGJ LGLOOHFNOKG(string JCEGKCPOPDM, string NABCGCEIEGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x1F763C0", Offset = "0x1F755C0", VA = "0x181F763C0")]
	public bool GLHCJKAPGCB(out IEnumerable<KeyValuePair<string, string>> MHFLGFOKOKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x1F76460", Offset = "0x1F75660", VA = "0x181F76460")]
	public JGALLCINBGJ HHFKCDFLFBB(GAKPIOFBDII<string> ENNBBCEBKAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class MFEDJFDGPOD : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xD8E6D0", Offset = "0xD8D8D0", VA = "0x180D8E6D0")]
	public MFEDJFDGPOD(string JPOEHOENKPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public interface NBJPFMBJGMB
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	KDLCCGABAHG EDDIDJKBCEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	JICMMHOABAL BGNCKIDAPPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NKFEOLDLFPD FGBCCBOPKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool ACNOELFKAIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool PJCELNLGJEG
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int GNBMNLOCACL
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action AIHNMCABPCA;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event Action<int> PKOBHCELHHP;

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CEDAELBJHIP();

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.OKPCCFFGNKM> JHMNBLFGANP(long FNJOKPDAGJN, [Optional] CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<Matchmaking.HGGMBHKOIED> MHBFKJDIHJJ();

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task GFPOCOCPPEM();

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(KDLCCGABAHG, JFCNENLAIHN) JPLIAGEJGFN();

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "15")]
	EDKAOGBNBOB FHMDOFFNFHD();

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JKMAEKJBKOE(long FNJOKPDAGJN);
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal interface JIPBJFBAGHG : CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GBOAMHGCLHL> NPFMFAPNMBH(GBOAMHGCLHL DMFMJBFFPPI, MDHCFBFJDKN LAHNBFHCLHC, CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<GBOAMHGCLHL> KJAPCJEPAOM(CancellationToken MELLLMEKJLC, MDHCFBFJDKN LAHNBFHCLHC);

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HGFHAMOOEPL GCFDMPBFOPG(IDGCAAGDMGH OEJIAIJDFHP, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD);

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HGFHAMOOEPL CJBOFNMJDDP(IDGCAAGDMGH OEJIAIJDFHP, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class FAOAFOBIBOP : GGGLHECDAMD, MFJKEMECNGI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class BOLKOIGLHDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public AsyncTaskMethodBuilder<FGEDLIOJPHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public GMJLKBDAIPD autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public FAOAFOBIBOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private FGEDLIOJPHD <canRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private FGEDLIOJPHD <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private TaskAwaiter<FGEDLIOJPHD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public BOLKOIGLHDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x3E488C0", Offset = "0x3E47AC0", VA = "0x183E488C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class BNDJPFAAGKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public FAOAFOBIBOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private FGEDLIOJPHD <canRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public BNDJPFAAGKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x3E48660", Offset = "0x3E47860", VA = "0x183E48660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class LJODLHMPGNP : IEnumerable<CKGJKOFFHNM>, IEnumerable, IEnumerator<CKGJKOFFHNM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private CKGJKOFFHNM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public FAOAFOBIBOP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private CKGJKOFFHNM System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xA122A0", Offset = "0xA114A0", VA = "0x180A122A0")]
		[DebuggerHidden]
		public LJODLHMPGNP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x3E59230", Offset = "0x3E58430", VA = "0x183E59230", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x3E596B0", Offset = "0x3E588B0", VA = "0x183E596B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x3E59610", Offset = "0x3E58810", VA = "0x183E59610", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CKGJKOFFHNM> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x3E59610", Offset = "0x3E58810", VA = "0x183E59610", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private readonly CancellationTokenSource FHKLONCDFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private readonly JFLMNMMPBBG AKLNKNCLGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private bool OLAIFPCFFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private BBBKOJIGONM ODFKOODGILH;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public ALKNFJDHKDJ DPDAAMHMDLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x928E20", Offset = "0x928020", VA = "0x180928E20", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x9ED510", Offset = "0x9EC710", VA = "0x1809ED510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public ADEGNLPFACK COBDAJCIDNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x903CB0", Offset = "0x902EB0", VA = "0x180903CB0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x903CE0", Offset = "0x902EE0", VA = "0x180903CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public KANPCPNLPMN JOECKGCKOMK
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x97BA90", Offset = "0x97AC90", VA = "0x18097BA90", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x9ED500", Offset = "0x9EC700", VA = "0x1809ED500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public GFBJKCOKDNB CMPKILKFPNI
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x99DC40", Offset = "0x99CE40", VA = "0x18099DC40", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x99DCE0", Offset = "0x99CEE0", VA = "0x18099DCE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public FIJJFANJMMC HOCDKHOBGDG
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x9B1AE0", Offset = "0x9B0CE0", VA = "0x1809B1AE0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x9AF470", Offset = "0x9AE670", VA = "0x1809AF470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public IJHNPMDMGIK IJOGOLEMEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x9CCD40", Offset = "0x9CBF40", VA = "0x1809CCD40", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x978C00", Offset = "0x977E00", VA = "0x180978C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public KPKLBEKJJDL ICOKONPBOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8DBFD0", Offset = "0x8DB1D0", VA = "0x1808DBFD0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8D8BA0", Offset = "0x8D7DA0", VA = "0x1808D8BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NGEKBCOEECJ GIBKPDMCLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x999860", Offset = "0x998A60", VA = "0x180999860", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x9ADD00", Offset = "0x9ACF00", VA = "0x1809ADD00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DBLLAAAALEB PINMHLKHODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4E0", Offset = "0x8D96E0", VA = "0x1808DA4E0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x8D8C80", Offset = "0x8D7E80", VA = "0x1808D8C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public GBNLMHKMPCE JJHHBMFDCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xA15620", Offset = "0xA14820", VA = "0x180A15620", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xA15700", Offset = "0xA14900", VA = "0x180A15700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public PJLINKOOKPL GCIGIJKHDMC
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8D4EA0", Offset = "0x8D40A0", VA = "0x1808D4EA0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x8D4E70", Offset = "0x8D4070", VA = "0x1808D4E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public EAEEJEIDIPI ILMCOGINPGM
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xA13AD0", Offset = "0xA12CD0", VA = "0x180A13AD0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xA13AC0", Offset = "0xA12CC0", VA = "0x180A13AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public NNLHBEANOAE BLJGKADMFFE
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xB1D850", Offset = "0xB1CA50", VA = "0x180B1D850", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7CC50", VA = "0x180B7DA50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public DFIJEPJBKAJ MMEKKFLDKOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xA07360", Offset = "0xA06560", VA = "0x180A07360", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA40", Offset = "0xB7CC40", VA = "0x180B7DA40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public LAPGCNHFJDO MHCAFCBHNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xA2EC30", Offset = "0xA2DE30", VA = "0x180A2EC30", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x965970", Offset = "0x964B70", VA = "0x180965970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public JELOKDHPDJI GONGAJDJEFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xE14440", Offset = "0xE13640", VA = "0x180E14440", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x9659E0", Offset = "0x964BE0", VA = "0x1809659E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public PAJNMOEGIGE BKFGNMPLIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8CC4B0", Offset = "0x8CB6B0", VA = "0x1808CC4B0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8CB690", Offset = "0x8CA890", VA = "0x1808CB690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public EBBHGGLBFKP JFMPEJDGNMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8CC480", Offset = "0x8CB680", VA = "0x1808CC480", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x8CAA40", Offset = "0x8C9C40", VA = "0x1808CAA40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public FJEGMDKGNDL AGFOCFOOFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x96DB70", Offset = "0x96CD70", VA = "0x18096DB70", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x96DA00", Offset = "0x96CC00", VA = "0x18096DA00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public JIPBJFBAGHG DDPABMMHHAE
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x99CAA0", Offset = "0x99BCA0", VA = "0x18099CAA0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xD75100", Offset = "0xD74300", VA = "0x180D75100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public LCLLGEFLIBP GHECCAACHPC
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xC9B750", Offset = "0xC9A950", VA = "0x180C9B750", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xD69FF0", Offset = "0xD691F0", VA = "0x180D69FF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public BFHFKPNDBGJ OJIAMCHEKHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x898D10", Offset = "0x897F10", VA = "0x180898D10", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8A2550", Offset = "0x8A1750", VA = "0x1808A2550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public EGGHGMHHKBL IAKJLIJOLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8C8830", Offset = "0x8C7A30", VA = "0x1808C8830", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8A01C0", Offset = "0x89F3C0", VA = "0x1808A01C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public PLMDPHAGAEE FNNEOBADFBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB40", Offset = "0x8ACD40", VA = "0x1808ADB40", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x89FAB0", Offset = "0x89ECB0", VA = "0x18089FAB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public FBKALKKBACA JFICGBDIFPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8ADA10", Offset = "0x8ACC10", VA = "0x1808ADA10", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8A3050", Offset = "0x8A2250", VA = "0x1808A3050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public EMJBILGMCGN HFEOCPCGLAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8ADA00", Offset = "0x8ACC00", VA = "0x1808ADA00", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x89C550", Offset = "0x89B750", VA = "0x18089C550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public JMHFFEDDFAM MCNFFDCKALH
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8AB7C0", Offset = "0x8AA9C0", VA = "0x1808AB7C0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8A3AA0", Offset = "0x8A2CA0", VA = "0x1808A3AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public BGPLFENKJGO CFJCMGKLPAO
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x976340", Offset = "0x975540", VA = "0x180976340", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public MLAIMLPDPAE HEIKGCFBBDN
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x99FCA0", Offset = "0x99EEA0", VA = "0x18099FCA0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public GGDCLFNNDGD IPJFIFPCENI
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x10376F0", Offset = "0x10368F0", VA = "0x1810376F0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public JFCNENLAIHN CCLGHGGBCMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x9CCB30", Offset = "0x9CBD30", VA = "0x1809CCB30", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x96F1C0", Offset = "0x96E3C0", VA = "0x18096F1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private bool DHEFMKDALNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x1F69080", Offset = "0x1F68280", VA = "0x181F69080", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	private bool GJHJDOMFJDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x1F68E50", Offset = "0x1F68050", VA = "0x181F68E50", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	private CancellationToken PCNAGMLBOLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x1F69090", Offset = "0x1F68290", VA = "0x181F69090", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private JFLMNMMPBBG EGCAFEALEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	private event Action BFHMAKBGKOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x1F690B0", Offset = "0x1F682B0", VA = "0x181F690B0", Slot = "36")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x1F685B0", Offset = "0x1F677B0", VA = "0x181F685B0", Slot = "37")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	private event MIAMIMOOMAC DAMOEKJIHAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x1F688D0", Offset = "0x1F67AD0", VA = "0x181F688D0", Slot = "38")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x1F68ED0", Offset = "0x1F680D0", VA = "0x181F68ED0", Slot = "39")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	private event MIAMIMOOMAC PAEABJBAAGP
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x1F68810", Offset = "0x1F67A10", VA = "0x181F68810", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x1F68990", Offset = "0x1F67B90", VA = "0x181F68990", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	private event MIAMIMOOMAC LKCLJEGHIFP
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x1F68930", Offset = "0x1F67B30", VA = "0x181F68930", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x1F68B30", Offset = "0x1F67D30", VA = "0x181F68B30", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	private event Action<CGPDIEAJPGM, bool> LCAGOEPJAIH
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x1F68870", Offset = "0x1F67A70", VA = "0x181F68870", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x1F68DF0", Offset = "0x1F67FF0", VA = "0x181F68DF0", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x96F1C0", Offset = "0x96E3C0", VA = "0x18096F1C0", Slot = "35")]
	public void BOKMHOCCFEP(JFCNENLAIHN DBCNBPNKOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x1F69110", Offset = "0x1F68310", VA = "0x181F69110")]
	[UnityEngine.Scripting.Preserve]
	internal FAOAFOBIBOP([NDGONEEEGIA(null)] JFLMNMMPBBG AKLNKNCLGHB, [NDGONEEEGIA(null)] ALKNFJDHKDJ FPIOPDMALNF, [NDGONEEEGIA(null)] ADEGNLPFACK HHGCDIJMEJP, [NDGONEEEGIA(null)] KANPCPNLPMN LJKHADFBIKG, [NDGONEEEGIA(null)] GFBJKCOKDNB AIKAADLFCJG, [NDGONEEEGIA(null)] FIJJFANJMMC IGFMGLLOHJE, [NDGONEEEGIA(null)] IJHNPMDMGIK NPDKCJPJIJG, [NDGONEEEGIA(null)] KPKLBEKJJDL ELHDKJIFJKI, [NDGONEEEGIA(null)] NGEKBCOEECJ JGCOKEDLLJF, [NDGONEEEGIA(null)] DBLLAAAALEB CJFOMJJADGO, [NDGONEEEGIA(null)] GBNLMHKMPCE GMLEHOPIEEM, [NDGONEEEGIA(null)] PJLINKOOKPL PNBMBCDGIHB, [NDGONEEEGIA(null)] EAEEJEIDIPI EGMFBGHNICA, [NDGONEEEGIA(null)] NNLHBEANOAE EGHDBPOCILP, [NDGONEEEGIA(null)] DFIJEPJBKAJ PLDBGCAPDNH, [NDGONEEEGIA(null)] LAPGCNHFJDO NOBPKJAMLMG, [NDGONEEEGIA(null)] JELOKDHPDJI BOJGEHKFCOF, [NDGONEEEGIA(null)] PAJNMOEGIGE CJPOPBAOCFH, [NDGONEEEGIA(null)] EBBHGGLBFKP IPBDAPKHKJI, [NDGONEEEGIA(null)] FJEGMDKGNDL GHPEHPHOMJO, [NDGONEEEGIA(null)] LCLLGEFLIBP FEOEBKFOFAH, [NDGONEEEGIA(null)] JIPBJFBAGHG MANAFLPNCHE, [NDGONEEEGIA(null)] BFHFKPNDBGJ AEAAOAENKCO, [NDGONEEEGIA(null)] EGGHGMHHKBL GEEKEMPGPKI, [NDGONEEEGIA(null)] PLMDPHAGAEE MNIHEGBFIBB, [NDGONEEEGIA(null)] EMJBILGMCGN EDIJJHKDDAP, [NDGONEEEGIA(null)] JMHFFEDDFAM OJLOGOEFAJK, [NDGONEEEGIA(null)] BGPLFENKJGO JLFBEBGJBKE, [NDGONEEEGIA(null)] MLAIMLPDPAE GBBLODABHLP, [NDGONEEEGIA(null)] GGDCLFNNDGD EKPFECEECGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x1F68D00", Offset = "0x1F67F00", VA = "0x181F68D00")]
	private void KCEHONPEIFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x1F68610", Offset = "0x1F67810", VA = "0x181F68610", Slot = "54")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x1F68500", Offset = "0x1F67700", VA = "0x181F68500", Slot = "48")]
	private void CCLMKFCIMJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x1F689F0", Offset = "0x1F67BF0", VA = "0x181F689F0", Slot = "49")]
	private AFJGHJAKFME ILOECLGJAPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x1F68480", Offset = "0x1F67680", VA = "0x181F68480", Slot = "50")]
	private OKKGMBNHAPB BINAFACOLGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x1F68B90", Offset = "0x1F67D90", VA = "0x181F68B90", Slot = "51")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BOLKOIGLHDL))]
	private Task<FGEDLIOJPHD> IPHPLOHGOML(GMJLKBDAIPD OPBMLMJIHBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x1F68F30", Offset = "0x1F68130", VA = "0x181F68F30", Slot = "52")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BNDJPFAAGKI))]
	private Task MPJEIEIBIHO(CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x1F687A0", Offset = "0x1F679A0", VA = "0x181F687A0")]
	[IteratorStateMachine(typeof(LJODLHMPGNP))]
	private IEnumerable<CKGJKOFFHNM> ELDLIJKIPMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x1F68550", Offset = "0x1F67750", VA = "0x181F68550")]
	[CompilerGenerated]
	private void DHCEIBAGOMN(CKGJKOFFHNM HPFFEAJFMNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class AJFFBMGHOJB : FJEGMDKGNDL, CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class HELKPMBMAJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public AsyncTaskMethodBuilder<NAFOEDAKNOD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public KDLCCGABAHG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public AJFFBMGHOJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private long <subRoomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private JICMMHOABAL <details>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private JICMMHOABAL <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private TaskAwaiter<JICMMHOABAL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public HELKPMBMAJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x28A7530", Offset = "0x28A6730", VA = "0x1828A7530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class ANIGGKCJHDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public ANIGGKCJHDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x28A1DD0", Offset = "0x28A0FD0", VA = "0x1828A1DD0")]
		internal object KPOGNNEDEBM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class JAABOJDDLKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public AsyncTaskMethodBuilder<JICMMHOABAL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public KDLCCGABAHG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public AJFFBMGHOJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private ANIGGKCJHDH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private JICMMHOABAL <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private TaskAwaiter<JICMMHOABAL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public JAABOJDDLKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x28A88A0", Offset = "0x28A7AA0", VA = "0x1828A88A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class JHALINEMPKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public JHALINEMPKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xB27D40", Offset = "0xB26F40", VA = "0x180B27D40")]
		internal bool KCJKFMCAHMB(NKFEOLDLFPD sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	private KANPCPNLPMN LJKHADFBIKG;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	private static readonly (PEFGNKCLLMB superRoomData, long subRoomDataSaveId) BGEKFECGPCG;

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x1F56AE0", Offset = "0x1F55CE0", VA = "0x181F56AE0", Slot = "5")]
	public void KCEHONPEIFO(GGGLHECDAMD BFBBPILOBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x1F56B50", Offset = "0x1F55D50", VA = "0x181F56B50", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HELKPMBMAJD))]
	public Task<NAFOEDAKNOD> MKDCIIGKLMD(GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, KDLCCGABAHG ACAELJFOOBM, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x1F567E0", Offset = "0x1F559E0", VA = "0x181F567E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JAABOJDDLKG))]
	private Task<JICMMHOABAL> BMMJCGABODB(KDLCCGABAHG ACAELJFOOBM, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x1F569A0", Offset = "0x1F55BA0", VA = "0x181F569A0")]
	private NAFOEDAKNOD HIAKPBFBIDI(KDLCCGABAHG ACAELJFOOBM, JICMMHOABAL NJIPHLJIGDC, long HHIFFPJLPIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x1F56D10", Offset = "0x1F55F10", VA = "0x181F56D10")]
	private (PEFGNKCLLMB, long) OGGCFDLNLJN(KDLCCGABAHG ACAELJFOOBM, JICMMHOABAL NJIPHLJIGDC, long HHIFFPJLPIC)
	{
		return default((PEFGNKCLLMB, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public AJFFBMGHOJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public interface GFBJKCOKDNB
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool BCLDJILADGB
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	string GALKGPAALFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KOIOFNIJCLI(Scene CKCLNEINAPO);

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task FJLLGDDJLAH(PJPFDBKHDOJ PFLEMHCGPGF, CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task CHENLIMDHHK();
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[UnityEngine.Scripting.Preserve]
internal sealed class BDGBLNBGLFA : JIPBJFBAGHG, CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class NGJIKCGKICB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public GBOAMHGCLHL request;

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public NGJIKCGKICB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x28B53A0", Offset = "0x28B45A0", VA = "0x1828B53A0")]
		internal object FDGMAOFKDPK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class CPJKCLBNOPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public AsyncTaskMethodBuilder<GBOAMHGCLHL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public GBOAMHGCLHL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public MDHCFBFJDKN pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public BDGBLNBGLFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private NGJIKCGKICB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private GBOAMHGCLHL <response>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private GBOAMHGCLHL <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private TaskAwaiter<GBOAMHGCLHL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public CPJKCLBNOPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x28A2BE0", Offset = "0x28A1DE0", VA = "0x1828A2BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class LBCGOADKNIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public AsyncTaskMethodBuilder<GBOAMHGCLHL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public MDHCFBFJDKN pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public BDGBLNBGLFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private LKGIPCJDHDA.HBELCONLOEO<GBOAMHGCLHL> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private BPHPGODDCPA <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private TaskAwaiter<BPHPGODDCPA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public LBCGOADKNIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x28ACA80", Offset = "0x28ABC80", VA = "0x1828ACA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class FGHIBKCDAJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public GBOAMHGCLHL request;

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public FGHIBKCDAJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x28A64D0", Offset = "0x28A56D0", VA = "0x1828A64D0")]
		internal object NLBDNGNBFJG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class FHFMOHENBIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public AsyncTaskMethodBuilder<GBOAMHGCLHL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public GBOAMHGCLHL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public MDHCFBFJDKN pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public BDGBLNBGLFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private FGHIBKCDAJD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private FHNGOBBBPKK <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private LKNGKMBGPPG <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private CancellationToken <masterSwitchCancellationToken>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private bool <sent>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private LKGIPCJDHDA.HBELCONLOEO<GBOAMHGCLHL> <result>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private GBOAMHGCLHL <response>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private FHNGOBBBPKK <actualMessageKind>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private BPHPGODDCPA <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private TaskAwaiter<BPHPGODDCPA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public FHFMOHENBIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x28A65B0", Offset = "0x28A57B0", VA = "0x1828A65B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private ALKNFJDHKDJ FPIOPDMALNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private FBKALKKBACA OHFCNNHHBNB;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	private LKGIPCJDHDA NMBGPPEFELF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x1F5AE70", Offset = "0x1F5A070", VA = "0x181F5AE70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x1F5B1B0", Offset = "0x1F5A3B0", VA = "0x181F5B1B0", Slot = "8")]
	public void KCEHONPEIFO(GGGLHECDAMD BFBBPILOBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x1F5B3E0", Offset = "0x1F5A5E0", VA = "0x181F5B3E0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CPJKCLBNOPF))]
	public Task<GBOAMHGCLHL> NPFMFAPNMBH(GBOAMHGCLHL DMFMJBFFPPI, MDHCFBFJDKN LAHNBFHCLHC, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x1F5B240", Offset = "0x1F5A440", VA = "0x181F5B240", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LBCGOADKNIE))]
	public Task<GBOAMHGCLHL> KJAPCJEPAOM(CancellationToken MELLLMEKJLC, MDHCFBFJDKN LAHNBFHCLHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x1F5AF20", Offset = "0x1F5A120", VA = "0x181F5AF20", Slot = "6")]
	public HGFHAMOOEPL GCFDMPBFOPG(IDGCAAGDMGH OEJIAIJDFHP, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x1F5AA30", Offset = "0x1F59C30", VA = "0x181F5AA30", Slot = "7")]
	public HGFHAMOOEPL CJBOFNMJDDP(IDGCAAGDMGH OEJIAIJDFHP, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x1F5ACB0", Offset = "0x1F59EB0", VA = "0x181F5ACB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FHFMOHENBIM))]
	private Task<GBOAMHGCLHL> EJJNDABGHBN(GBOAMHGCLHL DMFMJBFFPPI, MDHCFBFJDKN LAHNBFHCLHC, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x1F5B1A0", Offset = "0x1F5A3A0", VA = "0x181F5B1A0")]
	private static byte[] JEBLDDPCICA(GBOAMHGCLHL JPOEHOENKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public BDGBLNBGLFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public readonly struct ICBEPNJEOJD<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class GHCLBNFDGBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<GKGNJAPPBLB<TData>, EAICBCFAACM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public ICBEPNJEOJD<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private byte[] <roomDataBytes>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private PINPMIPFEPJ<byte[], EAICBCFAACM> <res>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private PINPMIPFEPJ<byte[], EAICBCFAACM> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private TaskAwaiter<PINPMIPFEPJ<byte[], EAICBCFAACM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public GHCLBNFDGBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x52471C0", Offset = "0x52463C0", VA = "0x1852471C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private readonly DDMOHEMDKOH<TGetDataArg, TData> KBFCOPLBFPF;

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8BADB0", Offset = "0x8B9FB0", VA = "0x1808BADB0")]
	internal ICBEPNJEOJD(DDMOHEMDKOH<TGetDataArg, TData> NKPJOKLGAHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x127E480", Offset = "0x127D680", VA = "0x18127E480")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ICBEPNJEOJD<, >.GHCLBNFDGBK))]
	public Task<PINPMIPFEPJ<GKGNJAPPBLB<TData>, EAICBCFAACM>> KPFOIOCBMEL(TGetDataArg CIKBJELAGAP, string GJHNEPENIFI, GAKPIOFBDII<string>.JOKPHMHCDCF ENNBBCEBKAC, CancellationToken MELLLMEKJLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class MEIOMLGJJMP
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x1E209C0", Offset = "0x1E1FBC0", VA = "0x181E209C0")]
	public static ICBEPNJEOJD<TGetDataArg, TData> HBHNAKPOBBF<TGetDataArg, TData>(DDMOHEMDKOH<TGetDataArg, TData> NKPJOKLGAHM)
	{
		return default(ICBEPNJEOJD<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[UnityEngine.Scripting.Preserve]
internal sealed class NIABHLKCJJN : EBBHGGLBFKP, CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class AKKIODILKNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public COPCGKNOMKI operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public NIABHLKCJJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public GBOAMHGCLHL roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public AKKIODILKNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x4EE2D80", Offset = "0x4EE1F80", VA = "0x184EE2D80")]
		internal object GFOEHHHFAPJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x4EE2DF0", Offset = "0x4EE1FF0", VA = "0x184EE2DF0")]
		internal object JFNFBECKOBJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class AJKLGGLDCEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public AsyncTaskMethodBuilder<FGEDLIOJPHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public GBOAMHGCLHL roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public NIABHLKCJJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private AKKIODILKNJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private FGEDLIOJPHD <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private FGEDLIOJPHD <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private TaskAwaiter<FGEDLIOJPHD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public AJKLGGLDCEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x4EE27F0", Offset = "0x4EE19F0", VA = "0x184EE27F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class LDJNIPMNHAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public COPCGKNOMKI operationType;

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public LDJNIPMNHAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7C30", Offset = "0x4EE6E30", VA = "0x184EE7C30")]
		internal object ODHDCCNJMKJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class GGCNHFHBELN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public GBOAMHGCLHL request;

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public GGCNHFHBELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x4EE4080", Offset = "0x4EE3280", VA = "0x184EE4080")]
		internal object ICANNHCJIJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x4EE4100", Offset = "0x4EE3300", VA = "0x184EE4100")]
		internal object OOADDEPIAMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x4EE4180", Offset = "0x4EE3380", VA = "0x184EE4180")]
		internal object PLEDDKGPIMJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class MLAJKCFDNGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder<FGEDLIOJPHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public GBOAMHGCLHL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public NIABHLKCJJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private GGCNHFHBELN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private NIJBFDNCANL <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private FGEDLIOJPHD <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private Task <operation>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private (FGEDLIOJPHD validationResult, Task operation) <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private (FGEDLIOJPHD validationResult, Task operation) <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private TaskAwaiter<(FGEDLIOJPHD validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public MLAJKCFDNGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x4EE8BC0", Offset = "0x4EE7DC0", VA = "0x184EE8BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private ALKNFJDHKDJ FPIOPDMALNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private BFHFKPNDBGJ AEAAOAENKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private PAJNMOEGIGE CJPOPBAOCFH;

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x28B58E0", Offset = "0x28B4AE0", VA = "0x1828B58E0", Slot = "5")]
	public void KCEHONPEIFO(GGGLHECDAMD BFBBPILOBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x28B5770", Offset = "0x28B4970", VA = "0x1828B5770", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AJKLGGLDCEE))]
	private Task<FGEDLIOJPHD> JPAJHBCGDGH(GBOAMHGCLHL GBANBELFDDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x28B5400", Offset = "0x28B4600", VA = "0x1828B5400")]
	private bool AJBNDLDMLKB(COPCGKNOMKI BDIHIOJPHJO, out FGEDLIOJPHD GAMJEJDMFJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x28B5600", Offset = "0x28B4800", VA = "0x1828B5600")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MLAJKCFDNGD))]
	private Task<FGEDLIOJPHD> EJOLBJIHCDN(GBOAMHGCLHL DMFMJBFFPPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public NIABHLKCJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class JCNBAJFCENA
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static FGEDLIOJPHD NHHNOCBHMEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x1F6B940", Offset = "0x1F6AB40", VA = "0x181F6B940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x1F76390", Offset = "0x1F75590", VA = "0x181F76390")]
	public static bool JEHALCIINAE(this FGEDLIOJPHD HBGNHMKPIBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x1F6B8D0", Offset = "0x1F6AAD0", VA = "0x181F6B8D0")]
	public static FGEDLIOJPHD FJKJAFDEJGL(HHGOHIFFOJI HMDLBGKACJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x1F76170", Offset = "0x1F75370", VA = "0x181F76170")]
	public static FGEDLIOJPHD FIJOOCLPEIA(IEnumerable<FGEDLIOJPHD> PMAELKEKNKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x1F75EC0", Offset = "0x1F750C0", VA = "0x181F75EC0")]
	public static string DLKLCJAPIFO(this FGEDLIOJPHD GAMJEJDMFJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[UnityEngine.Scripting.Preserve]
internal sealed class GEEINCGDCGI : BFHFKPNDBGJ, CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private FIJJFANJMMC IGFMGLLOHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private ALKNFJDHKDJ FPIOPDMALNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private NGEKBCOEECJ JGCOKEDLLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private LCLLGEFLIBP FEOEBKFOFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private KANPCPNLPMN LJKHADFBIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	private EAEEJEIDIPI EGMFBGHNICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private NNLHBEANOAE EGHDBPOCILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	private EMJBILGMCGN EDIJJHKDDAP;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	private NBJPFMBJGMB LJJGEEJCHJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x1F6B9A0", Offset = "0x1F6ABA0", VA = "0x181F6B9A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	private static FGEDLIOJPHD NHHNOCBHMEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x1F6B940", Offset = "0x1F6AB40", VA = "0x181F6B940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x1F6B9F0", Offset = "0x1F6ABF0", VA = "0x181F6B9F0", Slot = "6")]
	public void KCEHONPEIFO(GGGLHECDAMD BFBBPILOBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x1F6B740", Offset = "0x1F6A940", VA = "0x181F6B740", Slot = "4")]
	public FGEDLIOJPHD DNFHMMIBCOJ(CPCMBHAGMBL IDJKEADFEIO, COPCGKNOMKI ENJDJKNAHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x1F6BB50", Offset = "0x1F6AD50", VA = "0x181F6BB50", Slot = "5")]
	public FGEDLIOJPHD KMKNKILEMIJ(CPCMBHAGMBL NHLBBNCBMOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x1F6B8D0", Offset = "0x1F6AAD0", VA = "0x181F6B8D0")]
	private static FGEDLIOJPHD FJKJAFDEJGL(HHGOHIFFOJI ACIPMAPBAPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public GEEINCGDCGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public delegate Task CMMCJABFBOJ(LPHBDDFNIEM DONGKHHNBIB, CancellationToken FDCOCHLAHJD);
[Cpp2IlInjected.Token(Token = "0x200009C")]
internal interface NNLHBEANOAE : CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MJOPJBMJOOO(CMMCJABFBOJ MDOGIOHICJN);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public interface PLMDPHAGAEE
{
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BEBOFHAFBLD(out IEnumerable<int> EEPPAMLJOKJ);

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PGKONGJDAAB(DEILOLEAADK FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OIAANLFCKJC(DEILOLEAADK FDCOCHLAHJD);
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public interface ILODIBBPLKI
{
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GPNELJNOJEN(FGEDLIOJPHD HBGNHMKPIBC);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal interface EBBHGGLBFKP : CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FGEDLIOJPHD> JFMPEJDGNMP(GBOAMHGCLHL GBANBELFDDC);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal interface GGGLHECDAMD : MFJKEMECNGI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	CancellationToken CCFKKNKNGAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	JFLMNMMPBBG HBEDEIFBKKH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	ALKNFJDHKDJ DPDAAMHMDLP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	ADEGNLPFACK COBDAJCIDNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	KANPCPNLPMN JOECKGCKOMK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	GFBJKCOKDNB CMPKILKFPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	FIJJFANJMMC HOCDKHOBGDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	IJHNPMDMGIK IJOGOLEMEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	KPKLBEKJJDL ICOKONPBOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	NGEKBCOEECJ GIBKPDMCLKF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	DBLLAAAALEB PINMHLKHODO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	GBNLMHKMPCE JJHHBMFDCMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	PJLINKOOKPL GCIGIJKHDMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	EAEEJEIDIPI ILMCOGINPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	NNLHBEANOAE BLJGKADMFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	DFIJEPJBKAJ MMEKKFLDKOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	JELOKDHPDJI GONGAJDJEFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	PAJNMOEGIGE BKFGNMPLIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	EBBHGGLBFKP JFMPEJDGNMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	FJEGMDKGNDL AGFOCFOOFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	JIPBJFBAGHG DDPABMMHHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	LCLLGEFLIBP GHECCAACHPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	BFHFKPNDBGJ OJIAMCHEKHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	EGGHGMHHKBL IAKJLIJOLPL
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	PLMDPHAGAEE FNNEOBADFBK
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	FBKALKKBACA JFICGBDIFPL
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	EMJBILGMCGN HFEOCPCGLAL
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	JMHFFEDDFAM MCNFFDCKALH
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	BGPLFENKJGO CFJCMGKLPAO
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	MLAIMLPDPAE HEIKGCFBBDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	GGDCLFNNDGD IPJFIFPCENI
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void BOKMHOCCFEP(JFCNENLAIHN DBCNBPNKOBH);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal interface PJLINKOOKPL : CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task IOOIPEGJCKD();

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PCCBHEFBPDH();

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ACJHAMOBBFB();
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class NNBCNMCDHHE
{
	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x28B5B80", Offset = "0x28B4D80", VA = "0x1828B5B80")]
	public static void CHFEDGFIPFB(JFLMNMMPBBG AKLNKNCLGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x28B61D0", Offset = "0x28B53D0", VA = "0x1828B61D0")]
	internal static void IJMOEJBGGHN(JFLMNMMPBBG AKLNKNCLGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x28B62F0", Offset = "0x28B54F0", VA = "0x1828B62F0")]
	internal static void OPJPELJNMFJ(JFLMNMMPBBG AKLNKNCLGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x28B5D80", Offset = "0x28B4F80", VA = "0x1828B5D80")]
	internal static void HMNIFPNAPPM(JFLMNMMPBBG AKLNKNCLGHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class JMLDAHDPAEF : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x1F76560", Offset = "0x1F75760", VA = "0x181F76560")]
	public JMLDAHDPAEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x9450F0", Offset = "0x9442F0", VA = "0x1809450F0")]
	public JMLDAHDPAEF(string JPOEHOENKPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal interface CKGJKOFFHNM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCEHONPEIFO(GGGLHECDAMD BFBBPILOBDE);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public interface KANPCPNLPMN
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	NBJPFMBJGMB LJJGEEJCHJO
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	bool PMLFKBIAMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	bool HNOHJEOINJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool FCCFOACADHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool OAEGJLDNKEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool GFMEBDHKKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	bool ILEECDDANLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	float IKFNCFPHAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event Action<float> JDDDNIJFNFA;

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JFLMNMMPBBG DFLNMPMCBNI(JFLMNMMPBBG JJEFLALKOOM);

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HMACNCCAOIH(JFLMNMMPBBG AKLNKNCLGHB);

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MIOGNELHAKB();

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task NBFMHBMDBDA(GAKPIOFBDII<string>.JOKPHMHCDCF HFGLPCCFMKB, CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EIPKCHGBACB(float BLBKLGDEKOM);

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LLKCJBIFLNL(string EJOOMEOOAEJ);

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<PFLLMDOGJCE> MGLJAJIMDDC();

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable DKALDKNOLJP(object JDFBABENAGD, PFLLMDOGJCE ILPONDPFHDP);

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(Slot = "10")]
	EHKJGJHNGOB FOOCBFMIDNM(IEnumerable<KHALLJGHNEA> JKPOBBNIMGM);

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void EEBLDAJGCMK(int GOKFOGAFIOF);

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task LFPFFIDLBCK();

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DNMIGCNGDDN();

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool IDNLGCKKAFC();

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task DIBIEGCKAAA(CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task JDEPPEPNFFK(CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task<DOJNNAILMBC> HDPGKJKCMGA(DateTime OFFKIIOODFI, CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<bool> GGCNBLLOOJJ(CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GPGDPPJKJOM(string HPLGFDKNMJK = "", float KPNFPBFKGFM = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(Slot = "22")]
	HEGFFDBOKBP EHCLIBDBBPI(KPDIBFDKKDG OLCOHMCKBID, DIGFFKIMPNG MHPKONNINLP, PPPFGNOFILG GBOIGNJKANC, IEnumerable<PersistenceView> DOMGJDOGIDP, KKKOLGLCNNB OGFJAEMFEFA);

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void KFELEGKFOIN(PPPFGNOFILG GBOIGNJKANC);

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void NJDKLEOFMGD(KHALLJGHNEA LDGNEFNKJHM, in HEGFFDBOKBP MJEJJAGDKCK);

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task KMNKGPHNCOH(PPPFGNOFILG MHCMHOAOIOG, bool JILIODCKCBP, CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task EPOPCAMCLOI(CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MLOMBGGBOIE(long HBFBDJIOFCF, long BGOPDGBJMDP, JICMMHOABAL NDCGCFMCEHC, FNMBADLGNPC LNKDGNMHEDA, CKEACEFIEED LLJFOILBDJN, FFHPOMEPNOI? FGKEDIKBDOG, POMIFCINIMK? HDOBONHEJNA);

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void NMGKJKPBKLL(long HBFBDJIOFCF, long BGOPDGBJMDP, POMIFCINIMK? HDOBONHEJNA);

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void DCKNFHMHBDO(PersistenceView DEBBGDMDDDP);

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool MOCGHABLCGH(PersistenceView NLBPABLMMCP);

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool JMIEMJMDIGH(KHALLJGHNEA LDGNEFNKJHM, NIFCDPEEFKO JDAOGOKKDKO, out EDCKJMEPEHF OKLDAKFNAID);

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task HKAPIFNBMIA(CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void DAFFAGJCJIP();

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(Slot = "34")]
	IDisposable KPJFEPMKIGI();

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void EMAJFONHHNL(PPPFGNOFILG MHCMHOAOIOG, NIFCDPEEFKO JDAOGOKKDKO);

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<bool> GJLHDMCPLPG(ALKNFJDHKDJ FPIOPDMALNF, CancellationToken MELLLMEKJLC, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD);

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void OHPGEECNDCN(CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<ONNIIAMENKC> FNOPBDHFCJN(JNGJJPMAKAH DMFMJBFFPPI);

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<JICMMHOABAL> OHINDCECDKJ(long HBFBDJIOFCF, bool HMHLBKCMBAI, CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<FNMBADLGNPC> KCCINONKJAA(long HBFBDJIOFCF, long BGOPDGBJMDP, long NKFLEOFOPLB, CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<CHACCCFMNKN> BCKPKCPCLMG(string LBNNLDOBOIC, CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<CHACCCFMNKN> DOEGHLBLCKD(string LBNNLDOBOIC, long HBFBDJIOFCF, long BGOPDGBJMDP, string JHFBHDCCEFE, BCMPMDCFMDJ.GJOFGLCEHLH DONGKHHNBIB, BCMPMDCFMDJ.GJOFGLCEHLH DBPEJIKLAFB, int GFNEMFOLLJJ);

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(Slot = "44")]
	bool GDJGFLKICLB();

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool OEHPIMKINMG();

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool ECGFOCEMGLH(IEnumerable<EDCKJMEPEHF> AOMLHJDMIKJ);

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void OCGGHJKOJMD(List<GameObject> DEIJHNFLHON);

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float HACJDCIEGBO();

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<Scene> MEIBNMDOACC(string NIMNFAHNKAM, LoadSceneMode CEEPGCOHBOI, bool JCBICPFAOBN, GAKPIOFBDII<string>.JOKPHMHCDCF ENNBBCEBKAC);

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void LECHJCJDOEN();

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool OMHHDPFHBOM(ByteString CCBKAEHNCPH);

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void LOAPFNKGENF(bool EECCCGAOPOH);

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "55")]
	Task OEPDCGJGIKE();

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task HGOGONEOKDI();

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void BNCECLOACBI();

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void CCLBPFBLEDA();

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void NBHAHPDKPFJ(KDLCCGABAHG LLHBCCHGJPC);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Task PCBLDAIBBOE(GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "64")]
	Task LLOFKAGKFJN(GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "65")]
	Task ANNMFDENGLF(GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "66")]
	IDisposable PDAJGDAJBEI();

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "67")]
	GOHIOILFMAP GFEAGMAMMMJ();

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task HKFHEDLKELE(CancellationToken MELLLMEKJLC);
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public interface GOHIOILFMAP
{
	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NPDNNHEFJJC(CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KFIFJGKIOGM(CancellationToken MELLLMEKJLC);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct HEGFFDBOKBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public HashSet<int> KGMBMLJOKNN;
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public enum DOJNNAILMBC : byte
{
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	No,
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct KPDIBFDKKDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public bool JFEJODKMMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public string PPIILIIMPLK;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal static class LGNNIEBLFBE
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class KBMNBGNKBLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public GAKPIOFBDII<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public KBMNBGNKBLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x3AE23C0", Offset = "0x3AE15C0", VA = "0x183AE23C0")]
		internal object OLHHNAIDDJI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x28AD2E0", Offset = "0x28AC4E0", VA = "0x1828AD2E0")]
	public static GAKPIOFBDII<string> BJBAIJOPBCL(PEKDFCFCENH LHCMKIAHBCL, [Optional] string GGGDNPJJLME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x28AD210", Offset = "0x28AC410", VA = "0x1828AD210")]
	public static void ACCLIJNCCLN(GAKPIOFBDII<string> ENNBBCEBKAC, PEKDFCFCENH LHCMKIAHBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x28AD3C0", Offset = "0x28AC5C0", VA = "0x1828AD3C0")]
	public static string LNMCLHHNBNF(GBOAMHGCLHL GBANBELFDDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[UnityEngine.Scripting.Preserve]
internal class MBHCEPMKBMJ : NNLHBEANOAE, CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class HOLAMOABDHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public LPHBDDFNIEM roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public MBHCEPMKBMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private Func<CancellationToken, List<Task>> <taskGenerator>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public HOLAMOABDHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x3ADC9A0", Offset = "0x3ADBBA0", VA = "0x183ADC9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class CBKMNKLMMPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public MBHCEPMKBMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public LPHBDDFNIEM roomData;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public CBKMNKLMMPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x3AD82F0", Offset = "0x3AD74F0", VA = "0x183AD82F0")]
		internal List<Task> KNILCAONOHI(CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class FLKDGMAKIBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public CMMCJABFBOJ taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public LPHBDDFNIEM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public MBHCEPMKBMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public FLKDGMAKIBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x3ADAE60", Offset = "0x3ADA060", VA = "0x183ADAE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class JCOPFDCLICI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public MBHCEPMKBMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public JCOPFDCLICI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x3AE01B0", Offset = "0x3ADF3B0", VA = "0x183AE01B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private readonly HashSet<CMMCJABFBOJ> JPOMHDBKHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private ADEGNLPFACK HHGCDIJMEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private GGGLHECDAMD BFBBPILOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private PFLLMDOGJCE OLHGKHHCHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private BDIDECKAKEA HAGPDFLDNBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private IDisposable CCBALAHDIEP;

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x28AFAA0", Offset = "0x28AECA0", VA = "0x1828AFAA0", Slot = "5")]
	public void KCEHONPEIFO(GGGLHECDAMD BFBBPILOBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x28AEEB0", Offset = "0x28AE0B0", VA = "0x1828AEEB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x28AFD70", Offset = "0x28AEF70", VA = "0x1828AFD70", Slot = "4")]
	public bool MJOPJBMJOOO(CMMCJABFBOJ MDOGIOHICJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x28AFDD0", Offset = "0x28AEFD0", VA = "0x1828AFDD0")]
	private void NIAJHGCDIDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x28AEF10", Offset = "0x28AE110", VA = "0x1828AEF10")]
	private void EKDJFABAMNG(LPHBDDFNIEM DONGKHHNBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x28AF690", Offset = "0x28AE890", VA = "0x1828AF690")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HOLAMOABDHG))]
	private Task IFIKHEFCIGK(LPHBDDFNIEM DONGKHHNBIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x28AFF20", Offset = "0x28AF120", VA = "0x1828AFF20")]
	private Func<CancellationToken, List<Task>> PNJLMKADODA(LPHBDDFNIEM DONGKHHNBIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x28AF170", Offset = "0x28AE370", VA = "0x1828AF170")]
	private List<Task> GOEEMKBMJEE(LPHBDDFNIEM DONGKHHNBIB, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x28AF900", Offset = "0x28AEB00", VA = "0x1828AF900")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FLKDGMAKIBA))]
	private Task JDJBDFFHHBF(CMMCJABFBOJ NBKBADNKMFP, LPHBDDFNIEM JFGIPFOFKHL, CancellationToken FDCOCHLAHJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x28AF7E0", Offset = "0x28AE9E0", VA = "0x1828AF7E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JCOPFDCLICI))]
	private Task IIFECJIGAIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x28AEE30", Offset = "0x28AE030", VA = "0x1828AEE30")]
	private void ACJHAMOBBFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x28B0000", Offset = "0x28AF200", VA = "0x1828B0000")]
	public MBHCEPMKBMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal interface NGEKBCOEECJ : CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000086")]
	bool ACIIDLIMGDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Task LALLGJNEPFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DMBOFCLDFIB(Task EEILDIKJMBL, string PONLGNOMPCJ);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal class HJPAGHELMLM : DADHPGKOHBD
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class BJAFFJMIEAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public HJPAGHELMLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public BJAFFJMIEAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x3AD7D90", Offset = "0x3AD6F90", VA = "0x183AD7D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	private readonly GGGLHECDAMD BFBBPILOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	private readonly KANPCPNLPMN LJKHADFBIKG;

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x927D00", Offset = "0x926F00", VA = "0x180927D00")]
	public HJPAGHELMLM(GGGLHECDAMD BFBBPILOBDE, KANPCPNLPMN LJKHADFBIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x1F72510", Offset = "0x1F71710", VA = "0x181F72510", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BJAFFJMIEAO))]
	public Task<bool> EJNNGEAFANP(CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x1F72680", Offset = "0x1F71880", VA = "0x181F72680")]
	[CompilerGenerated]
	private object KJEOHOIKBLF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public class CMLILCBAIIK : MFJNMMICGAE, FIJJFANJMMC, HHPIKNMCMBP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class CGPNPABLOAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public FGEDLIOJPHD result;

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public CGPNPABLOAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x3E493F0", Offset = "0x3E485F0", VA = "0x183E493F0")]
		internal object MBIOAEEMFMB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x1F5FAB0", Offset = "0x1F5ECB0", VA = "0x181F5FAB0")]
	[UnityEngine.Scripting.Preserve]
	public CMLILCBAIIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x1F5F990", Offset = "0x1F5EB90", VA = "0x181F5F990", Slot = "8")]
	public FGEDLIOJPHD LOBFNOABJLL(CPCMBHAGMBL NHLBBNCBMOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public interface JMHFFEDDFAM
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	bool HLFKHDCGKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	string EONPHLLBJIF
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JAHBCMANPIE();

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HHLEGOLKPOO GIFHMFEPPPD(long FNJOKPDAGJN);

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DDMOHEMDKOH<PEFGNKCLLMB, EHKJGJHNGOB> DBGCMBPDFDG(long FNJOKPDAGJN);

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DDMOHEMDKOH<PEFGNKCLLMB, PPPFGNOFILG> KHBKOOBMFMO(long FNJOKPDAGJN);

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DDMOHEMDKOH<long, IBHFMJGAMEO> NMLPNPLCHKO();

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> FNPLHOPMHIO(byte[] GPHICPODLBN, byte[] DBPEJIKLAFB, CancellationToken MELLLMEKJLC);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[UnityEngine.Scripting.Preserve]
internal sealed class CJPNKHLNJAO : DFIJEPJBKAJ, CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class PHMALGGFBMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public PHMALGGFBMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x28BA710", Offset = "0x28B9910", VA = "0x1828BA710")]
		internal object NCIFFABONPK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class BFAEGHIGNLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public BFAEGHIGNLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x28A2560", Offset = "0x28A1760", VA = "0x1828A2560")]
		internal object AKGIJDEEPDD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private sealed class BNJPKANMAGB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public BNJPKANMAGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class IJGOAEDKOCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public IJGOAEDKOCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x28A7ED0", Offset = "0x28A70D0", VA = "0x1828A7ED0")]
		internal object LEDGKDLGIAD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class JPJGJNNOMNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public JPJGJNNOMNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x28AA5F0", Offset = "0x28A97F0", VA = "0x1828AA5F0")]
		internal object MCHGEHKJIAP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private readonly Dictionary<Guid, BNMALNHFLLO> PLDBGCAPDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private readonly TimeSpan APLIDPIFBEJ;

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "9")]
	public void KCEHONPEIFO(GGGLHECDAMD BFBBPILOBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x1F5E6A0", Offset = "0x1F5D8A0", VA = "0x181F5E6A0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x1F5E230", Offset = "0x1F5D430", VA = "0x181F5E230", Slot = "4")]
	public NIJBFDNCANL CKPKOIJGHLD(Guid OAOAFDNAJNM)
	{
		return default(NIJBFDNCANL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x1F5EA00", Offset = "0x1F5DC00", VA = "0x181F5EA00", Slot = "5")]
	public bool HCICIMHFKFM(Guid OAOAFDNAJNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x1F5E6B0", Offset = "0x1F5D8B0", VA = "0x181F5E6B0", Slot = "6")]
	public bool FNANCFKMAIB(Guid OAOAFDNAJNM, Task CHEEIAMKAGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x1F5EC30", Offset = "0x1F5DE30", VA = "0x181F5EC30", Slot = "7")]
	public bool PAEMNFPCEEJ(Guid OAOAFDNAJNM, FGEDLIOJPHD HBGNHMKPIBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x1F5E1A0", Offset = "0x1F5D3A0", VA = "0x181F5E1A0", Slot = "8")]
	public Task<(FGEDLIOJPHD, Task)> ABLKHDIAKOJ(Guid OAOAFDNAJNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x1F5E460", Offset = "0x1F5D660", VA = "0x181F5E460")]
	private void DGGCEEADDIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x1F5EE80", Offset = "0x1F5E080", VA = "0x181F5EE80")]
	public CJPNKHLNJAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public class FBDAFKGAOGL : MFJNMMICGAE, IJHNPMDMGIK, HHPIKNMCMBP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class EGLAEBHDPDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public FGEDLIOJPHD result;

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public EGLAEBHDPDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x3E4CD10", Offset = "0x3E4BF10", VA = "0x183E4CD10")]
		internal object ONHIBEECNFK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x1F5FAB0", Offset = "0x1F5ECB0", VA = "0x181F5FAB0")]
	[UnityEngine.Scripting.Preserve]
	public FBDAFKGAOGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x1F69520", Offset = "0x1F68720", VA = "0x181F69520", Slot = "8")]
	public FGEDLIOJPHD HHEHOAPHLIE(CPCMBHAGMBL BJENOGCANAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal interface EAEEJEIDIPI : CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	TaskStatus GDJKIIAHEKB
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KBDKLJCMHLB(KDLCCGABAHG ACAELJFOOBM, JFCNENLAIHN NALGJPOFHKM, CancellationToken JIEKCCCMBMG);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal static class OACMGOBIDFK
{
	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x28B8D40", Offset = "0x28B7F40", VA = "0x1828B8D40")]
	public static bool BGLJJNGEJHL(this EAEEJEIDIPI EGMFBGHNICA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal static class BNBPOPKOGMO
{
	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x1F5CD70", Offset = "0x1F5BF70", VA = "0x181F5CD70")]
	public static bool AEGDLNMHLNA(this KDLCCGABAHG PEBBOOOPJMA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[UnityEngine.Scripting.Preserve]
internal class CPAPPLGOCGH : PJLINKOOKPL, CKGJKOFFHNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class OMNONKHFNEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public CPAPPLGOCGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public OMNONKHFNEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x3E59C60", Offset = "0x3E58E60", VA = "0x183E59C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class IIHCCBEJBID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public CPAPPLGOCGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private bool <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public IIHCCBEJBID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x3E54DA0", Offset = "0x3E53FA0", VA = "0x183E54DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class DEIODLAOALM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public DEIODLAOALM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x3E4C570", Offset = "0x3E4B770", VA = "0x183E4C570")]
		internal object IMHCMLJDMBG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class CODICNAACOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public CPAPPLGOCGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private DEIODLAOALM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private DADHPGKOHBD <provider>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private bool <success>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private bool <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		private Exception <ex>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public CODICNAACOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x3E4ABF0", Offset = "0x3E49DF0", VA = "0x183E4ABF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class FKALOFAIOCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public FKALOFAIOCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x3E4F420", Offset = "0x3E4E620", VA = "0x183E4F420")]
		internal object LEJLMAAKHCA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	private GGGLHECDAMD BFBBPILOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	private KANPCPNLPMN LJKHADFBIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	private DADHPGKOHBD[] OKACOELCKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	private CancellationTokenSource OEIHHLAPKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private int CNOFFIPNANP;

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x1F60A20", Offset = "0x1F5FC20", VA = "0x181F60A20", Slot = "7")]
	public void KCEHONPEIFO(GGGLHECDAMD BFBBPILOBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x1F60230", Offset = "0x1F5F430", VA = "0x181F60230", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x1F60030", Offset = "0x1F5F230", VA = "0x181F60030", Slot = "6")]
	public void ACJHAMOBBFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x1F60BF0", Offset = "0x1F5FDF0", VA = "0x181F60BF0", Slot = "5")]
	public void PCCBHEFBPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x1F60900", Offset = "0x1F5FB00", VA = "0x181F60900", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OMNONKHFNEI))]
	public Task IOOIPEGJCKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x1F60510", Offset = "0x1F5F710", VA = "0x181F60510")]
	private void HJMMLDPPNBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x1F60AA0", Offset = "0x1F5FCA0", VA = "0x181F60AA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IIHCCBEJBID))]
	private Task MLEEEFHJMMO(CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x1F60380", Offset = "0x1F5F580", VA = "0x181F60380")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CODICNAACOD))]
	private Task<bool> FBKLAGMKKLM(int NNAODBDJDNJ, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x1F60140", Offset = "0x1F5F340", VA = "0x181F60140")]
	private void BNPIILKOIKH(int NNAODBDJDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x1F60800", Offset = "0x1F5FA00", VA = "0x181F60800")]
	private void HPPIMLLAFPL(int NNAODBDJDNJ, bool KECICGODINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x1F60240", Offset = "0x1F5F440", VA = "0x181F60240")]
	private void ENAEKBLDPAP(int NNAODBDJDNJ, Exception JBOMBKDPEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x1F60CD0", Offset = "0x1F5FED0", VA = "0x181F60CD0")]
	private void PCDJDAOHEMO(CancellationToken MELLLMEKJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x1F60E80", Offset = "0x1F60080", VA = "0x181F60E80")]
	public CPAPPLGOCGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal static class BIIJBIHENCO
{
	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x1F5B8B0", Offset = "0x1F5AAB0", VA = "0x181F5B8B0")]
	public static void FFJHDMEPFLI(this ALKNFJDHKDJ FPIOPDMALNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x1F5B8A0", Offset = "0x1F5AAA0", VA = "0x181F5B8A0")]
	public static void DDLOJPGILIN(this ALKNFJDHKDJ FPIOPDMALNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x1F5B8C0", Offset = "0x1F5AAC0", VA = "0x181F5B8C0")]
	private static void LKPDGEHJOLA(this ALKNFJDHKDJ FPIOPDMALNF, bool FODANGEDOII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public struct DNCOIJJDFOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public readonly INCLMMPMLDF CELHLBONAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public readonly string KMFFOGIOGIO;

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x1F67170", Offset = "0x1F66370", VA = "0x181F67170")]
	public DNCOIJJDFOG(string HDLADEHADIM, INCLMMPMLDF CGJBDJNHGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x1F670D0", Offset = "0x1F662D0", VA = "0x181F670D0")]
	public string IKNDOMLLFJD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public delegate string HGCOHNFHGJD<in T>(T JBOMBKDPEGF) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public delegate int MHKLGOMGAMK<in T>(T JBOMBKDPEGF) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal class OABNHBIGMKA : GGDCLFNNDGD
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	private delegate string PJONJIEMMHL(Exception JBOMBKDPEGF);

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	private delegate int DDOFFKIPAAJ(Exception JBOMBKDPEGF);

	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	private class IKPPLKGBGMJ<T> : NLAJKJDADCF<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		[CompilerGenerated]
		private sealed class EBKNPIJEIEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
			public EBKNPIJEIEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110")]
			internal string JFJJCBLOKOP(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		[CompilerGenerated]
		private sealed class MKBGIIJJCHD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x680770", Offset = "0x67FB70")]
			public HGCOHNFHGJD<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
			public MKBGIIJJCHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x163BEA0", Offset = "0x163B0A0", VA = "0x18163BEA0")]
			internal string OKMLLPAIOEI(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		[CompilerGenerated]
		private sealed class EMMIEBBANOA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6807D0", Offset = "0x67FBD0")]
			public MHKLGOMGAMK<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
			public EMMIEBBANOA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x163BEA0", Offset = "0x163B0A0", VA = "0x18163BEA0")]
			internal int FAFEAFJNFFO(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private readonly OABNHBIGMKA EKPFECEECGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private readonly Type HHBBDPPPIBO;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x2540A10", Offset = "0x253FC10", VA = "0x182540A10")]
		internal IKPPLKGBGMJ(OABNHBIGMKA EKPFECEECGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x25407C0", Offset = "0x253F9C0", VA = "0x1825407C0", Slot = "4")]
		public void KHPKMKIPJNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x25407F0", Offset = "0x253F9F0", VA = "0x1825407F0", Slot = "5")]
		public NLAJKJDADCF<T> NDKNHBNOCBF(string EABGHJKOGFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x25406C0", Offset = "0x253F8C0", VA = "0x1825406C0", Slot = "6")]
		public NLAJKJDADCF<T> FOHIGKEICEL(HGCOHNFHGJD<T> DPCLBLCCFAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x2540680", Offset = "0x253F880", VA = "0x182540680", Slot = "7")]
		public NLAJKJDADCF<T> DHENPKFNMDO(int CGJBDJNHGPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x25408F0", Offset = "0x253FAF0", VA = "0x1825408F0", Slot = "8")]
		public NLAJKJDADCF<T> PGBOLCADMOO(int CGJBDJNHGPB, MHKLGOMGAMK<T> FBBPFPAKNHD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	private class BANJFFPGMIH<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private bool PIJKFFMEKOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private readonly List<Type> BACOAEGLJNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private readonly Dictionary<Type, TVal> NJNCLAPHFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private readonly Dictionary<Type, int> DDKHFPCANAF;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public IReadOnlyList<Type> EIBJOCKFBAC
		{
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0x507FB70", Offset = "0x507ED70", VA = "0x18507FB70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x507FD30", Offset = "0x507EF30", VA = "0x18507FD30")]
		public BANJFFPGMIH(Dictionary<Type, int> DDKHFPCANAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x507F910", Offset = "0x507EB10", VA = "0x18507F910")]
		public void CKPKOIJGHLD(Type JCEGKCPOPDM, TVal OGOIFONOCED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x507FA80", Offset = "0x507EC80", VA = "0x18507FA80")]
		public bool HEOJACEGBJG(Type HHBBDPPPIBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x507FA50", Offset = "0x507EC50", VA = "0x18507FA50")]
		public bool EBPPBGDGGCF(TVal NABCGCEIEGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x331FFC0", Offset = "0x331F1C0", VA = "0x18331FFC0")]
		public TVal MCKGCJAFOEM(Type FBNKHAJKFLM)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x507F870", Offset = "0x507EA70", VA = "0x18507F870")]
		[CompilerGenerated]
		private int CBNPIKGMGIL(Type LJBMAPIEDIP, Type CLJEHOBAJOL)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private sealed class IDBDIKOGCMF : IEnumerable<INCLMMPMLDF>, IEnumerable, IEnumerator<INCLMMPMLDF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private INCLMMPMLDF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public OABNHBIGMKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private AggregateException <aggregateException>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private IEnumerator<Exception> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private Exception <innerException>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private IEnumerator<INCLMMPMLDF> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private INCLMMPMLDF <innerErrorCode>5__5;

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		private INCLMMPMLDF System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x2216870", Offset = "0x2215A70", VA = "0x182216870", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(INCLMMPMLDF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0x4EE53C0", Offset = "0x4EE45C0", VA = "0x184EE53C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xA122A0", Offset = "0xA114A0", VA = "0x180A122A0")]
		[DebuggerHidden]
		public IDBDIKOGCMF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x4EE5410", Offset = "0x4EE4610", VA = "0x184EE5410", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x4EE4E60", Offset = "0x4EE4060", VA = "0x184EE4E60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x4EE4E10", Offset = "0x4EE4010", VA = "0x184EE4E10")]
		private void DNBEPMOBGPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x4EE5280", Offset = "0x4EE4480", VA = "0x184EE5280")]
		private void OGHDDOHNOGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x4EE5380", Offset = "0x4EE4580", VA = "0x184EE5380", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x4EE52D0", Offset = "0x4EE44D0", VA = "0x184EE52D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<INCLMMPMLDF> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x4EE52D0", Offset = "0x4EE44D0", VA = "0x184EE52D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private static readonly INCLMMPMLDF DDOPAMPFMHL;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private static readonly Dictionary<Type, int> CFDFNDGPNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private readonly HashSet<Type> CEMGDFFFCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private readonly BANJFFPGMIH<int> PHALFELOMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private readonly BANJFFPGMIH<DDOFFKIPAAJ> LNCOMJJPIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	private readonly BANJFFPGMIH<PJONJIEMMHL> KHJOLIDKBNH;

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x28B7850", Offset = "0x28B6A50", VA = "0x1828B7850")]
	[GKCPJLBLCDF(EHLDMJJGFKP.GameOnly)]
	private static void COJDMCIPHFF(JFLMNMMPBBG MKDJCBAHPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x28B8A30", Offset = "0x28B7C30", VA = "0x1828B8A30")]
	[RecRoom.NoEngine.Common.Preserve]
	public OABNHBIGMKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x1249EC0", Offset = "0x12490C0", VA = "0x181249EC0", Slot = "4")]
	public NLAJKJDADCF<T> EFBDOCPNDCF<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x28B78C0", Offset = "0x28B6AC0", VA = "0x1828B78C0", Slot = "5")]
	public DNCOIJJDFOG DNCCOAGPPKC(Exception JBOMBKDPEGF)
	{
		return default(DNCOIJJDFOG);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x28B75A0", Offset = "0x28B67A0", VA = "0x1828B75A0", Slot = "6")]
	public INCLMMPMLDF BKPIMFGPGHE(Exception? JBOMBKDPEGF)
	{
		return default(INCLMMPMLDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x28B77C0", Offset = "0x28B69C0", VA = "0x1828B77C0", Slot = "7")]
	[IteratorStateMachine(typeof(IDBDIKOGCMF))]
	public IEnumerable<INCLMMPMLDF> CAGKNFNFNGN(Exception JBOMBKDPEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x28B8570", Offset = "0x28B7770", VA = "0x1828B8570", Slot = "8")]
	public string MLCOEMDHIPF(Exception? JBOMBKDPEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x28B7980", Offset = "0x28B6B80", VA = "0x1828B7980")]
	private string DOHJOLMAJLD(AggregateException BENMENJNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x28B8030", Offset = "0x28B7230", VA = "0x1828B8030")]
	private void KBNNEFFNIDI(Type HHBBDPPPIBO, int CGJBDJNHGPB, DDOFFKIPAAJ? BEOHACJBMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x28B7D00", Offset = "0x28B6F00", VA = "0x1828B7D00")]
	private void GDNCJCCPNAM(Type HHBBDPPPIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x28B86B0", Offset = "0x28B78B0", VA = "0x1828B86B0")]
	private void OODKCGPIKBM(Type HHBBDPPPIBO, PJONJIEMMHL GHOEIONJDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x28B83D0", Offset = "0x28B75D0", VA = "0x1828B83D0")]
	private static int LMLEPIECKDP(Type HHBBDPPPIBO, Dictionary<Type, int> DDKHFPCANAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x3223810", Offset = "0x3222A10", VA = "0x183223810")]
	private static bool LAHCLLIIINJ<TVal>(BANJFFPGMIH<TVal> DGPLNKPEMNF, Type HHBBDPPPIBO, out TVal NABCGCEIEGG) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x28B7F40", Offset = "0x28B7140", VA = "0x1828B7F40")]
	[CompilerGenerated]
	internal static int GOCOBNNMFPC(Type EMBNFPBIABB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public struct INCLMMPMLDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public readonly int OENAMAOIPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public readonly int? MKIBMFBAIPN;

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x15BCED0", Offset = "0x15BC0D0", VA = "0x1815BCED0")]
	public INCLMMPMLDF(int GOKFOGAFIOF, [Optional] int? JCBMAGJFLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x1F755B0", Offset = "0x1F747B0", VA = "0x181F755B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public interface GGDCLFNNDGD
{
	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NLAJKJDADCF<T> EFBDOCPNDCF<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DNCOIJJDFOG DNCCOAGPPKC(Exception JBOMBKDPEGF);

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(Slot = "2")]
	INCLMMPMLDF BKPIMFGPGHE(Exception JBOMBKDPEGF);
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public interface NLAJKJDADCF<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KHPKMKIPJNA();

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NLAJKJDADCF<T> NDKNHBNOCBF(string EABGHJKOGFH);

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NLAJKJDADCF<T> FOHIGKEICEL(HGCOHNFHGJD<T> DPCLBLCCFAA);

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NLAJKJDADCF<T> DHENPKFNMDO(int CGJBDJNHGPB);

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NLAJKJDADCF<T> PGBOLCADMOO(int CGJBDJNHGPB, MHKLGOMGAMK<T> FBBPFPAKNHD);
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class AJFNJPHOAGF
{
	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x1F57170", Offset = "0x1F56370", VA = "0x181F57170")]
	[GKCPJLBLCDF(EHLDMJJGFKP.GameOnly)]
	private static void CBJFBKKBGCJ(JFLMNMMPBBG MKDJCBAHPLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public interface GMJLKBDAIPD : IEquatable<GMJLKBDAIPD>
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	DateTime EKJNJIIPKNO
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KHFNDNJHKCJ();

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JDCPADGLFAA(long HBFBDJIOFCF, long HHIFFPJLPIC, out CKEACEFIEED LLJFOILBDJN);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
internal class KOMBMKONPJF : BGPLFENKJGO
{
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private sealed class DLCKMCKHIGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public BIPGMDDBGPD autosaveType;

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public DLCKMCKHIGE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private sealed class CEPNEFIIGEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public DLCKMCKHIGE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public CEPNEFIIGEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8850", Offset = "0x3AD7A50", VA = "0x183AD8850")]
		internal object PKNFCBAJNIP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private readonly EBAFHHHAKAE HKNIHOCBMKH;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event Action<GMJLKBDAIPD> BLIBCOPAJAP
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x28AB6C0", Offset = "0x28AA8C0", VA = "0x1828AB6C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x28AB580", Offset = "0x28AA780", VA = "0x1828AB580", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x8888D0", Offset = "0x887AD0", VA = "0x1808888D0")]
	[UnityEngine.Scripting.Preserve]
	public KOMBMKONPJF([NDGONEEEGIA(null)] EBAFHHHAKAE HKNIHOCBMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x28AAFA0", Offset = "0x28AA1A0", VA = "0x1828AAFA0", Slot = "6")]
	public bool CPPJHBCMHBE(long HBFBDJIOFCF, long HHIFFPJLPIC, CKEACEFIEED LLJFOILBDJN, BIPGMDDBGPD BHKOGCBJNKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x28AB620", Offset = "0x28AA820", VA = "0x1828AB620")]
	private void FOPJNHMEHIM(GMJLKBDAIPD PEIFNOKHAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x28AB3F0", Offset = "0x28AA5F0", VA = "0x1828AB3F0", Slot = "7")]
	public bool EFJOOIPOFJF(long HBFBDJIOFCF, long HHIFFPJLPIC, out GMJLKBDAIPD OPBMLMJIHBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x28AB340", Offset = "0x28AA540", VA = "0x1828AB340", Slot = "8")]
	public bool EDMDENKMMLC(long HBFBDJIOFCF, long HHIFFPJLPIC, BIPGMDDBGPD BHKOGCBJNKO, out GMJLKBDAIPD OPBMLMJIHBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x28AB880", Offset = "0x28AAA80", VA = "0x1828AB880")]
	private void MJCNBNIHDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x28AB760", Offset = "0x28AA960", VA = "0x1828AB760", Slot = "9")]
	public void MEKABHKCNAJ(long HBFBDJIOFCF, long HHIFFPJLPIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public enum OOLMJGABGGG : byte
{
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
internal sealed class ANBLOLFOHMB : OJEIJEPMNDP
{
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private static readonly byte[] JCEGKCPOPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private readonly byte[] HKFJNAPBOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	private readonly byte[] FILFKALMPPH;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public override OOLMJGABGGG JALKEAINCEO
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x1F59670", Offset = "0x1F58870", VA = "0x181F59670", Slot = "8")]
		get
		{
			return default(OOLMJGABGGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x1F59F80", Offset = "0x1F59180", VA = "0x181F59F80")]
	public ANBLOLFOHMB([Optional] string OFNFKBJHDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x1F591B0", Offset = "0x1F583B0", VA = "0x181F591B0", Slot = "9")]
	internal override void CDANLHLFNKN(Stream OFONDFCNKJE, long HBFBDJIOFCF, long HHIFFPJLPIC, CKEACEFIEED LLJFOILBDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x1F59680", Offset = "0x1F58880", VA = "0x181F59680", Slot = "10")]
	internal override bool OOFLCLOKNNE(Stream APKGGMOFJDE, long HBFBDJIOFCF, long HHIFFPJLPIC, ILBNKAHIBPK MLPFBHLDLAA, out CKEACEFIEED LLJFOILBDJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x1F59560", Offset = "0x1F58760", VA = "0x181F59560")]
	private void EPGJBKKOKIF(byte[] NDONHPGBMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x1F59430", Offset = "0x1F58630", VA = "0x181F59430", Slot = "11")]
	protected override FileInfo DDKLONLLOBK(long HBFBDJIOFCF, long HHIFFPJLPIC, BIPGMDDBGPD BHKOGCBJNKO, PLCAAOAHMBK KGHPGBMNEDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x1F59DE0", Offset = "0x1F58FE0", VA = "0x181F59DE0", Slot = "12")]
	protected override DirectoryInfo PLLMLDMLCPL(BIPGMDDBGPD BHKOGCBJNKO, PLCAAOAHMBK KGHPGBMNEDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
internal class HBPNMIPOPIJ : OJEIJEPMNDP
{
	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public override OOLMJGABGGG JALKEAINCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x99FC90", Offset = "0x99EE90", VA = "0x18099FC90", Slot = "8")]
		get
		{
			return default(OOLMJGABGGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x1F70DC0", Offset = "0x1F6FFC0", VA = "0x181F70DC0")]
	public HBPNMIPOPIJ([Optional] string OFNFKBJHDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x1F70720", Offset = "0x1F6F920", VA = "0x181F70720")]
	private void IFLGKIAADOI(BIPGMDDBGPD BHKOGCBJNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x1F70400", Offset = "0x1F6F600", VA = "0x181F70400", Slot = "9")]
	internal override void CDANLHLFNKN(Stream OFONDFCNKJE, long HBFBDJIOFCF, long HHIFFPJLPIC, CKEACEFIEED LLJFOILBDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x1F707B0", Offset = "0x1F6F9B0", VA = "0x181F707B0", Slot = "10")]
	internal override bool OOFLCLOKNNE(Stream APKGGMOFJDE, long HBFBDJIOFCF, long HHIFFPJLPIC, ILBNKAHIBPK MLPFBHLDLAA, out CKEACEFIEED LLJFOILBDJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x1F70630", Offset = "0x1F6F830", VA = "0x181F70630", Slot = "11")]
	protected override FileInfo DDKLONLLOBK(long HBFBDJIOFCF, long HHIFFPJLPIC, BIPGMDDBGPD BHKOGCBJNKO, PLCAAOAHMBK KGHPGBMNEDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x1F70CB0", Offset = "0x1F6FEB0", VA = "0x181F70CB0", Slot = "12")]
	protected override DirectoryInfo PLLMLDMLCPL(BIPGMDDBGPD BHKOGCBJNKO, PLCAAOAHMBK KGHPGBMNEDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
internal abstract class OJEIJEPMNDP : EBAFHHHAKAE
{
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	protected enum PLCAAOAHMBK : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private sealed class LAADONFHBOA : IEnumerable<GMJLKBDAIPD>, IEnumerable, IEnumerator<GMJLKBDAIPD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private GMJLKBDAIPD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private BIPGMDDBGPD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public BIPGMDDBGPD <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public OJEIJEPMNDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private DirectoryInfo <autosaveDirectory>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private FileInfo[] <files>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private FileInfo[] <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private int <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private FileInfo <file>5__5;

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		private GMJLKBDAIPD System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xA122A0", Offset = "0xA114A0", VA = "0x180A122A0")]
		[DebuggerHidden]
		public LAADONFHBOA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7490", Offset = "0x4EE6690", VA = "0x184EE7490", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x4EE76F0", Offset = "0x4EE68F0", VA = "0x184EE76F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7640", Offset = "0x4EE6840", VA = "0x184EE7640", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GMJLKBDAIPD> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7640", Offset = "0x4EE6840", VA = "0x184EE7640", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private sealed class LOLHLGIBKGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public BIPGMDDBGPD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public LOLHLGIBKGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x4EE82D0", Offset = "0x4EE74D0", VA = "0x184EE82D0")]
		internal object EJEABBIAPDE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class NDJDGBGPLCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public OJEIJEPMNDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public NDJDGBGPLCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x4EE9770", Offset = "0x4EE8970", VA = "0x184EE9770")]
		internal void PHADPNCOGIO(ECAAHJMKOCF.PJFCEFCOPCA ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000365")]
	protected readonly string MMHFLLCFMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	private readonly object MFOKLJFDCKP;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public abstract OOLMJGABGGG JALKEAINCEO
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x28B9BA0", Offset = "0x28B8DA0", VA = "0x1828B9BA0")]
	protected OJEIJEPMNDP([CanBeNull] string OFNFKBJHDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x28B9600", Offset = "0x28B8800", VA = "0x1828B9600", Slot = "5")]
	public bool EOFEFOKKFKJ(long HBFBDJIOFCF, long HHIFFPJLPIC, BIPGMDDBGPD BHKOGCBJNKO, out GMJLKBDAIPD PEIFNOKHAJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x28B9B20", Offset = "0x28B8D20", VA = "0x1828B9B20", Slot = "6")]
	[IteratorStateMachine(typeof(LAADONFHBOA))]
	public IEnumerable<GMJLKBDAIPD> PIHGMFMEDHK(BIPGMDDBGPD BHKOGCBJNKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void CDANLHLFNKN(Stream OFONDFCNKJE, long HBFBDJIOFCF, long HHIFFPJLPIC, CKEACEFIEED LLJFOILBDJN);

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool OOFLCLOKNNE(Stream APKGGMOFJDE, long HBFBDJIOFCF, long HHIFFPJLPIC, ILBNKAHIBPK MLPFBHLDLAA, out CKEACEFIEED LLJFOILBDJN);

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x28B97B0", Offset = "0x28B89B0", VA = "0x1828B97B0", Slot = "7")]
	public GMJLKBDAIPD HJABECFNGGL(long HBFBDJIOFCF, long HHIFFPJLPIC, CKEACEFIEED LLJFOILBDJN, BIPGMDDBGPD BHKOGCBJNKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo DDKLONLLOBK(long HBFBDJIOFCF, long HHIFFPJLPIC, BIPGMDDBGPD BHKOGCBJNKO, PLCAAOAHMBK KGHPGBMNEDP);

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo PLLMLDMLCPL(BIPGMDDBGPD BHKOGCBJNKO, PLCAAOAHMBK KGHPGBMNEDP);

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x28B9AB0", Offset = "0x28B8CB0", VA = "0x1828B9AB0")]
	protected void LGHDEFNCMDH(ECAAHJMKOCF.PJFCEFCOPCA CGEOMIHFCPA, string CLEOAKJCLAF, FileInfo EEMDLEAHCMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x28B9350", Offset = "0x28B8550", VA = "0x1828B9350")]
	internal bool DKKGBFECEAM(FileInfo KKJAAHPKCMJ, long HBFBDJIOFCF, long HHIFFPJLPIC, out CKEACEFIEED LLJFOILBDJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	private void MIICLDJIMGO(Exception MGCANHHBOBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
internal interface EBAFHHHAKAE
{
	[Cpp2IlInjected.Token(Token = "0x17000094")]
	OOLMJGABGGG JALKEAINCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EOFEFOKKFKJ(long HBFBDJIOFCF, long HHIFFPJLPIC, BIPGMDDBGPD BHKOGCBJNKO, out GMJLKBDAIPD PEIFNOKHAJA);

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<GMJLKBDAIPD> PIHGMFMEDHK(BIPGMDDBGPD BHKOGCBJNKO);

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GMJLKBDAIPD HJABECFNGGL(long HBFBDJIOFCF, long HHIFFPJLPIC, CKEACEFIEED LLJFOILBDJN, BIPGMDDBGPD BHKOGCBJNKO);
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
internal class GAKEEGHKBEA : EBAFHHHAKAE
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private sealed class CKMCFONNDAB : IEnumerable<GMJLKBDAIPD>, IEnumerable, IEnumerator<GMJLKBDAIPD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private GMJLKBDAIPD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private BIPGMDDBGPD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public BIPGMDDBGPD <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public GAKEEGHKBEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private OOLMJGABGGG[] <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private int <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private OOLMJGABGGG <autosaveVersion>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private EBAFHHHAKAE <impl>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private IEnumerable<GMJLKBDAIPD> <records>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private IEnumerator<GMJLKBDAIPD> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private GMJLKBDAIPD <autosaveRecord>5__7;

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private GMJLKBDAIPD System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0xA122A0", Offset = "0xA114A0", VA = "0x180A122A0")]
		[DebuggerHidden]
		public CKMCFONNDAB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x3E49A00", Offset = "0x3E48C00", VA = "0x183E49A00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x3E495C0", Offset = "0x3E487C0", VA = "0x183E495C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x3E49570", Offset = "0x3E48770", VA = "0x183E49570")]
		private void DNBEPMOBGPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x3E499C0", Offset = "0x3E48BC0", VA = "0x183E499C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x3E49910", Offset = "0x3E48B10", VA = "0x183E49910", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GMJLKBDAIPD> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x3E49910", Offset = "0x3E48B10", VA = "0x183E49910", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000379")]
	private readonly OOLMJGABGGG[] KPMHHFODAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400037A")]
	private readonly Dictionary<OOLMJGABGGG, EBAFHHHAKAE> AEGOHDNCPFE;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public OOLMJGABGGG JALKEAINCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x1F6B310", Offset = "0x1F6A510", VA = "0x181F6B310", Slot = "4")]
		get
		{
			return default(OOLMJGABGGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x1F6B3D0", Offset = "0x1F6A5D0", VA = "0x181F6B3D0")]
	[UnityEngine.Scripting.Preserve]
	public GAKEEGHKBEA(params EBAFHHHAKAE[] JIJNFMOGDEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x1F6B060", Offset = "0x1F6A260", VA = "0x181F6B060", Slot = "5")]
	public bool EOFEFOKKFKJ(long HBFBDJIOFCF, long HHIFFPJLPIC, BIPGMDDBGPD BHKOGCBJNKO, out GMJLKBDAIPD PEIFNOKHAJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x1F6AE30", Offset = "0x1F6A030", VA = "0x181F6AE30")]
	private void BJJNNHEICNB(int AAALCJGNJNK, long HBFBDJIOFCF, long HHIFFPJLPIC, BIPGMDDBGPD BHKOGCBJNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x1F6B350", Offset = "0x1F6A550", VA = "0x181F6B350", Slot = "6")]
	[IteratorStateMachine(typeof(CKMCFONNDAB))]
	public IEnumerable<GMJLKBDAIPD> PIHGMFMEDHK(BIPGMDDBGPD BHKOGCBJNKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x1F6B1C0", Offset = "0x1F6A3C0", VA = "0x181F6B1C0", Slot = "7")]
	public GMJLKBDAIPD HJABECFNGGL(long HBFBDJIOFCF, long HHIFFPJLPIC, CKEACEFIEED LLJFOILBDJN, BIPGMDDBGPD BHKOGCBJNKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal static class LONCPCJAHLA
{
	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x28ADCF0", Offset = "0x28ACEF0", VA = "0x1828ADCF0")]
	internal static byte[] IBIMEIDLFLD(byte[] NDONHPGBMNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x28ADD90", Offset = "0x28ACF90", VA = "0x1828ADD90")]
	public static void IEIHKENKOCF(Stream MHCBCKNNNBF, byte[] DHNOKENJLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x28ADE10", Offset = "0x28AD010", VA = "0x1828ADE10")]
	public static bool KANKJJPDCEH(Stream MHCBCKNNNBF, long PDFBIIHKJCD, ILBNKAHIBPK JIHDIGMOPIB, out byte[] GFNCFALGCKD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public delegate void ILBNKAHIBPK(ECAAHJMKOCF.PJFCEFCOPCA NAEFKOLHHPK, string JPOEHOENKPI);
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal sealed class EGIFHCCCEHP : GMJLKBDAIPD, IEquatable<GMJLKBDAIPD>, IEquatable<EGIFHCCCEHP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400038C")]
	private readonly OJEIJEPMNDP ODFBLMBOEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public readonly FileInfo DICCLPIDHIO;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public OOLMJGABGGG JALKEAINCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x1F67D90", Offset = "0x1F66F90", VA = "0x181F67D90", Slot = "9")]
		get
		{
			return default(OOLMJGABGGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public DateTime EKJNJIIPKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x1F67B60", Offset = "0x1F66D60", VA = "0x181F67B60", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x1F67E70", Offset = "0x1F67070", VA = "0x181F67E70")]
	public EGIFHCCCEHP(OJEIJEPMNDP EOOIHHJEMBA, FileInfo KKJAAHPKCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x1F67DC0", Offset = "0x1F66FC0", VA = "0x181F67DC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x1F67CE0", Offset = "0x1F66EE0", VA = "0x181F67CE0", Slot = "5")]
	public void KHFNDNJHKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x1F67CA0", Offset = "0x1F66EA0", VA = "0x181F67CA0", Slot = "6")]
	public bool JDCPADGLFAA(long HBFBDJIOFCF, long HHIFFPJLPIC, out CKEACEFIEED LLJFOILBDJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x1F678D0", Offset = "0x1F66AD0", VA = "0x181F678D0", Slot = "7")]
	public bool Equals(GMJLKBDAIPD JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x1F679B0", Offset = "0x1F66BB0", VA = "0x181F679B0", Slot = "8")]
	public bool Equals(EGIFHCCCEHP JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x1F67A60", Offset = "0x1F66C60", VA = "0x181F67A60", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x1F67C00", Offset = "0x1F66E00", VA = "0x181F67C00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal struct MIHPAECIOIM
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class NDEECKPCDGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public HGFHAMOOEPL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public LPHBDDFNIEM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private GGGLHECDAMD <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public NDEECKPCDGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x4EE9330", Offset = "0x4EE8530", VA = "0x184EE9330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x28B2440", Offset = "0x28B1640", VA = "0x1828B2440")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NDEECKPCDGA))]
	public static Task GNJLBDDANJL(HGFHAMOOEPL GIICFIPJIBI, LPHBDDFNIEM JFGIPFOFKHL, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal struct HFLKGANPOBD
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private sealed class KJBFDAHBCFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public IDGCAAGDMGH operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public LPHBDDFNIEM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public EBKHDKDGJPI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private GGGLHECDAMD <roomManager>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private KANPCPNLPMN <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private NIFCDPEEFKO <DEPRECATED_version>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private IDisposable <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private IDisposable <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private List<(PersistenceView, KHALLJGHNEA)>.Enumerator <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private PersistenceView <view>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private KHALLJGHNEA <viewData>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public KJBFDAHBCFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x3AE2440", Offset = "0x3AE1640", VA = "0x183AE2440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x1F70E00", Offset = "0x1F70000", VA = "0x181F70E00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KJBFDAHBCFP))]
	public static Task GNJLBDDANJL(IDGCAAGDMGH BGHGOMFIAIP, LPHBDDFNIEM JFGIPFOFKHL, EBKHDKDGJPI ECBJHNFIHMD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal struct JKJGFKMFPBH
{
	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0")]
	public static JKJGFKMFPBH JKAAGGANCJG()
	{
		return default(JKJGFKMFPBH);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal struct GPJFBFABLHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	private GGGLHECDAMD BFBBPILOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	private LPHBDDFNIEM JFGIPFOFKHL;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private KANPCPNLPMN JOECKGCKOMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x1F6FCA0", Offset = "0x1F6EEA0", VA = "0x181F6FCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x1F6FC00", Offset = "0x1F6EE00", VA = "0x181F6FC00")]
	public static Task GNJLBDDANJL(GGGLHECDAMD BFBBPILOBDE, LPHBDDFNIEM JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x1F6FA20", Offset = "0x1F6EC20", VA = "0x181F6FA20")]
	private void GNJLBDDANJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
internal class IPCBCDPDIGB : IDGCAAGDMGH
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private sealed class MOCBOIELKBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public HGFHAMOOEPL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public IPCBCDPDIGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private long <subRoomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private string <unityAssetId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private BJLKOGNGHKA <serializeLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private KPDIBFDKKDG <roomSaveOptions>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private DIGFFKIMPNG <serializeType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private CKEACEFIEED <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private CKEACEFIEED <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private Exception <ex>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private TaskAwaiter<CKEACEFIEED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public MOCBOIELKBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x3AE4B60", Offset = "0x3AE3D60", VA = "0x183AE4B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	private readonly string EFLAIFHHJII;

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x1F75990", Offset = "0x1F74B90", VA = "0x181F75990")]
	public IPCBCDPDIGB(Guid OAOAFDNAJNM, GGGLHECDAMD BFBBPILOBDE, MDHCFBFJDKN LPFOCNKNJLE, string EFLAIFHHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x1F757F0", Offset = "0x1F749F0", VA = "0x181F757F0", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MOCBOIELKBJ))]
	protected override Task JOLJFFAOAGI(HGFHAMOOEPL GIICFIPJIBI, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
internal class IIBENEHJHPD
{
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class IEPLOMACAIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public JBHFADCJFPJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public LPHBDDFNIEM deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public IIBENEHJHPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public IEPLOMACAIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x3ADDE50", Offset = "0x3ADD050", VA = "0x183ADDE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class GEOLMGCAEKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public IIBENEHJHPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public LPHBDDFNIEM data;

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public GEOLMGCAEKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class MBIODLCGPHN
	{
		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		private sealed class <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public MBIODLCGPHN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public <<RunAuthorityHandler>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0x4EED100", Offset = "0x4EEC300", VA = "0x184EED100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public GEOLMGCAEKE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public MBIODLCGPHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x3AE4410", Offset = "0x3AE3610", VA = "0x183AE4410")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task IOMAGJNFGAK(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class INOKICDOMOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public LPHBDDFNIEM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public IIBENEHJHPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private GEOLMGCAEKE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private MBIODLCGPHN <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public INOKICDOMOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x3ADF710", Offset = "0x3ADE910", VA = "0x183ADF710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class JPNBMAGHJAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public LPHBDDFNIEM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public IIBENEHJHPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private Dictionary<Guid, List<PFGMEGIJAKE>>.Enumerator <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private KeyValuePair<Guid, List<PFGMEGIJAKE>> <guidMethodPair>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public JPNBMAGHJAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x3AE1900", Offset = "0x3AE0B00", VA = "0x183AE1900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class KAFOIDJBHLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public LPHBDDFNIEM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public IIBENEHJHPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private ALKNFJDHKDJ <networking>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private Dictionary<Guid, List<PFGMEGIJAKE>>.Enumerator <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private KeyValuePair<Guid, List<PFGMEGIJAKE>> <guidMethodPair>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public KAFOIDJBHLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x3AE1DF0", Offset = "0x3AE0FF0", VA = "0x183AE1DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class ALOOCBGOBFP
	{
		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		private sealed class <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public PFGMEGIJAKE handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public ALOOCBGOBFP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public <<InvokeMethodsInParallel>b__2>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x4EEA8A0", Offset = "0x4EE9AA0", VA = "0x184EEA8A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public KOHGBGDGIPB runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public List<PFGMEGIJAKE> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public LPHBDDFNIEM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public ALOOCBGOBFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6CF0", Offset = "0x3AD5EF0", VA = "0x183AD6CF0")]
		internal object GPDINHGKKAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6BA0", Offset = "0x3AD5DA0", VA = "0x183AD6BA0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task DABICIENDNG(PFGMEGIJAKE handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6DE0", Offset = "0x3AD5FE0", VA = "0x183AD6DE0")]
		internal object LJGHGCDLIAI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private sealed class CDCMCLOIILN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public List<PFGMEGIJAKE> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public KOHGBGDGIPB runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public LPHBDDFNIEM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public IIBENEHJHPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private ALOOCBGOBFP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private IEnumerable<Task> <handlerTasks>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private Exception <ex>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public CDCMCLOIILN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8320", Offset = "0x3AD7520", VA = "0x183AD8320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private sealed class AONIGMJGKKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public LPHBDDFNIEM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public IIBENEHJHPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private Guid <handlerIdToRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public AONIGMJGKKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6ED0", Offset = "0x3AD60D0", VA = "0x183AD6ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private sealed class MAFEFOELDKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public MAFEFOELDKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x3AE43A0", Offset = "0x3AE35A0", VA = "0x183AE43A0")]
		internal object JAFHOPPHDJL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class AJHCEOLFEHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public LPHBDDFNIEM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public IIBENEHJHPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private MAFEFOELDKM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private ALKNFJDHKDJ <networking>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private List<PFGMEGIJAKE> <handlerMethods>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public AJHCEOLFEHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x3AD66E0", Offset = "0x3AD58E0", VA = "0x183AD66E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private sealed class GLEDDJECNEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public GLEDDJECNEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x3ADBE80", Offset = "0x3ADB080", VA = "0x183ADBE80")]
		internal object MJAIOLCMJBN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private sealed class IFNKMJMADFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public IIBENEHJHPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private GLEDDJECNEJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private GBOAMHGCLHL <completedMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private GBOAMHGCLHL <syncedCompletionMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private ByteString <authorityCompletedMark>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private GBOAMHGCLHL <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private TaskAwaiter<GBOAMHGCLHL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public IFNKMJMADFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x3ADE1E0", Offset = "0x3ADD3E0", VA = "0x183ADE1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class PMNDPHLBENB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public PMNDPHLBENB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x3AE8780", Offset = "0x3AE7980", VA = "0x183AE8780")]
		internal object BGFKLFACCNF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	private readonly HGFHAMOOEPL GIICFIPJIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	private FPHBCIJMINJ PFPHCALNCFH;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private IDGCAAGDMGH LDDBKPOCCHB
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0xC0A1B0", Offset = "0xC093B0", VA = "0x180C0A1B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x8888D0", Offset = "0x887AD0", VA = "0x1808888D0")]
	public IIBENEHJHPD(HGFHAMOOEPL GIICFIPJIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x1F73930", Offset = "0x1F72B30", VA = "0x181F73930")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IEPLOMACAIP))]
	public Task GNJLBDDANJL(JBHFADCJFPJ HJFGMHGIDFB, LPHBDDFNIEM JEMHOAGGDPM, GAKPIOFBDII<string>.JOKPHMHCDCF ENNBBCEBKAC, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x1F74460", Offset = "0x1F73660", VA = "0x181F74460")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(INOKICDOMOG))]
	private Task NBCHEJJIBJL(LPHBDDFNIEM JFGIPFOFKHL, GAKPIOFBDII<string>.JOKPHMHCDCF ENNBBCEBKAC, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x1F73F80", Offset = "0x1F73180", VA = "0x181F73F80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JPNBMAGHJAG))]
	private Task JKEENNOCFNP(LPHBDDFNIEM JFGIPFOFKHL, GAKPIOFBDII<string>.JOKPHMHCDCF ENNBBCEBKAC, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x1F742C0", Offset = "0x1F734C0", VA = "0x181F742C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KAFOIDJBHLJ))]
	private Task MKEJJBAIGBI(LPHBDDFNIEM JFGIPFOFKHL, GAKPIOFBDII<string>.JOKPHMHCDCF ENNBBCEBKAC, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x1F747D0", Offset = "0x1F739D0", VA = "0x181F747D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CDCMCLOIILN))]
	private Task NNGIPIEHEKJ(Guid FGHKCHNBILD, List<PFGMEGIJAKE> DGEHAIGHCKC, KOHGBGDGIPB EBDGELCDFDD, LPHBDDFNIEM JFGIPFOFKHL, CancellationToken FDCOCHLAHJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x1F74120", Offset = "0x1F73320", VA = "0x181F74120")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AONIGMJGKKH))]
	private Task KKOFOMNPGAJ(LPHBDDFNIEM JFGIPFOFKHL, GAKPIOFBDII<string>.JOKPHMHCDCF ENNBBCEBKAC, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x1F73770", Offset = "0x1F72970", VA = "0x181F73770")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AJHCEOLFEHL))]
	private Task GDNLOMGPEPB(Guid AMFNGHCKKJP, LPHBDDFNIEM JFGIPFOFKHL, GAKPIOFBDII<string>.JOKPHMHCDCF ENNBBCEBKAC, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x1F73C20", Offset = "0x1F72E20", VA = "0x181F73C20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IFNKMJMADFI))]
	private Task HJDGIGOAHPJ(Guid AMFNGHCKKJP, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x1F73AF0", Offset = "0x1F72CF0", VA = "0x181F73AF0")]
	private void HBLOBCMOOOF(Guid AMFNGHCKKJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x1F736B0", Offset = "0x1F728B0", VA = "0x181F736B0")]
	private void EDAAKMNCPGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x1F73DC0", Offset = "0x1F72FC0", VA = "0x181F73DC0")]
	public Guid IFHKOMKGBFO(JBHFADCJFPJ JPIFBMAMJBM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x1F74600", Offset = "0x1F73800", VA = "0x181F74600")]
	[CompilerGenerated]
	private object NKBNAIKGOHF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
internal struct EOGCALPKEIF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	private readonly HGFHAMOOEPL GIICFIPJIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	private readonly Guid JFPOCODONBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	private bool KECICGODINP;

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x1F67F70", Offset = "0x1F67170", VA = "0x181F67F70")]
	public static EOGCALPKEIF AGKKACJKDKN(HGFHAMOOEPL GIICFIPJIBI)
	{
		return default(EOGCALPKEIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x10A6880", Offset = "0x10A5A80", VA = "0x1810A6880")]
	public void JOICIFLGHNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x1F67FA0", Offset = "0x1F671A0", VA = "0x181F67FA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x1F682C0", Offset = "0x1F674C0", VA = "0x181F682C0")]
	private EOGCALPKEIF(HGFHAMOOEPL GIICFIPJIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x1F67FB0", Offset = "0x1F671B0", VA = "0x181F67FB0")]
	private void NINANDLNGBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x1F68210", Offset = "0x1F67410", VA = "0x181F68210")]
	private Func<Guid, bool> OIGINKCLCHE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
internal struct CFGIFJKPLJK
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private sealed class JOLJJMHKMBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public AsyncTaskMethodBuilder<LLFMDKPFMOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public CFGIFJKPLJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <subTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private LLFMDKPFMOB <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private TaskAwaiter<LLFMDKPFMOB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public JOLJJMHKMBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x28A8D80", Offset = "0x28A7F80", VA = "0x1828A8D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private sealed class GLBEJAGCFEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public AsyncTaskMethodBuilder<LLFMDKPFMOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public CFGIFJKPLJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private LLFMDKPFMOB <roomDetails>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private LLFMDKPFMOB <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private TaskAwaiter<LLFMDKPFMOB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public GLBEJAGCFEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x28A71D0", Offset = "0x28A63D0", VA = "0x1828A71D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private sealed class EKGMBKMFONO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public EKGMBKMFONO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xB27D40", Offset = "0xB26F40", VA = "0x180B27D40")]
		internal bool FDIJGNPGPKC(NKFEOLDLFPD sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class MBGLBEIAGMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public AsyncTaskMethodBuilder<LLFMDKPFMOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public KANPCPNLPMN callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public PEFGNKCLLMB superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private EKGMBKMFONO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private JICMMHOABAL <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private NKFEOLDLFPD <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private PEFGNKCLLMB <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		private PEFGNKCLLMB <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private JICMMHOABAL <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private CHACCCFMNKN <session>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private CHACCCFMNKN <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private FNMBADLGNPC <saveData>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private FNMBADLGNPC <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private TaskAwaiter<JICMMHOABAL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private TaskAwaiter<CHACCCFMNKN> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private TaskAwaiter<FNMBADLGNPC> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public MBGLBEIAGMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x28AE070", Offset = "0x28AD270", VA = "0x1828AE070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	private KANPCPNLPMN LJKHADFBIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	private KPKLBEKJJDL ELHDKJIFJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	private GAKPIOFBDII<string>.JOKPHMHCDCF ENNBBCEBKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042E")]
	private long HBFBDJIOFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400042F")]
	private long HHIFFPJLPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000430")]
	private long NKFLEOFOPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	private string LBNNLDOBOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	private PEFGNKCLLMB CIILDJJIDPC;

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x1F5D630", Offset = "0x1F5C830", VA = "0x181F5D630")]
	public static Task<LLFMDKPFMOB> EANABNFMFAF(GGGLHECDAMD BFBBPILOBDE, NAFOEDAKNOD DMFMJBFFPPI, GAKPIOFBDII<string>.JOKPHMHCDCF ENNBBCEBKAC, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x1F5D7F0", Offset = "0x1F5C9F0", VA = "0x181F5D7F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JOLJJMHKMBC))]
	private Task<LLFMDKPFMOB> GNJLBDDANJL(CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x1F5D440", Offset = "0x1F5C640", VA = "0x181F5D440")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GLBEJAGCFEG))]
	private Task<LLFMDKPFMOB> ADIOEIIBDNL(GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x1F5D210", Offset = "0x1F5C410", VA = "0x181F5D210")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MBGLBEIAGMA))]
	private static Task<LLFMDKPFMOB> ADIOEIIBDNL(KANPCPNLPMN LJKHADFBIKG, long HBFBDJIOFCF, long HHIFFPJLPIC, long NKFLEOFOPLB, string LBNNLDOBOIC, PEFGNKCLLMB CIILDJJIDPC, CancellationToken MELLLMEKJLC, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x1F5D600", Offset = "0x1F5C800", VA = "0x181F5D600")]
	private void BFAOHLJEPHN(JICMMHOABAL NDCGCFMCEHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal struct ALMMEAECJIM
{
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class ALKDJGGPHCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public GGGLHECDAMD roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public LPHBDDFNIEM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public HGFHAMOOEPL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public bool isReloadingSceneForObjectModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public ALKDJGGPHCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x28A1BD0", Offset = "0x28A0DD0", VA = "0x1828A1BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private sealed class EOBEKCIPPOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public ALMMEAECJIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public EOBEKCIPPOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x28A5C30", Offset = "0x28A4E30", VA = "0x1828A5C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	private static readonly PEKDFCFCENH BMDAAMBKBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	private GGGLHECDAMD BFBBPILOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000460")]
	private LPHBDDFNIEM JFGIPFOFKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000461")]
	private ByteString IJMEBENKHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000462")]
	private HGFHAMOOEPL GIICFIPJIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000463")]
	private bool LIILJNNIBHE;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private KANPCPNLPMN JOECKGCKOMK
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x1F590E0", Offset = "0x1F582E0", VA = "0x181F590E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private bool GFMEBDHKKFK
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x1F58C00", Offset = "0x1F57E00", VA = "0x181F58C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	private bool KOLJHIPPCMM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x1F58FF0", Offset = "0x1F581F0", VA = "0x181F58FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x1F58E10", Offset = "0x1F58010", VA = "0x181F58E10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ALKDJGGPHCJ))]
	public static Task GNJLBDDANJL(GGGLHECDAMD BFBBPILOBDE, LPHBDDFNIEM JFGIPFOFKHL, HGFHAMOOEPL GIICFIPJIBI, bool LIILJNNIBHE, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x1F58C80", Offset = "0x1F57E80", VA = "0x181F58C80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EOBEKCIPPOJ))]
	private Task GNJLBDDANJL(GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
internal static class AJAMODLLCMD
{
	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x1F56690", Offset = "0x1F55890", VA = "0x181F56690")]
	public static void OBAJHMJFLNH(this EDKAOGBNBOB KPLFLIKHOKI, KDLCCGABAHG AJNCKFOALHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x1F565B0", Offset = "0x1F557B0", VA = "0x181F565B0")]
	public static void KPBIPMBAMIF(this KDLCCGABAHG PEBBOOOPJMA, [Optional] string JPOEHOENKPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal struct MMLLFILFBDM
{
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class JFMPBAHJPEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public MMLLFILFBDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private float <nextResendTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public JFMPBAHJPEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x4EE61A0", Offset = "0x4EE53A0", VA = "0x184EE61A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	private KANPCPNLPMN LJKHADFBIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000475")]
	private LPHBDDFNIEM JFGIPFOFKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	private GAKPIOFBDII<string>.JOKPHMHCDCF ENNBBCEBKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	private float NJFMLKBHIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	private float FCOJLMDGFDE;

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x28B30B0", Offset = "0x28B22B0", VA = "0x1828B30B0")]
	public static Task NOICODLEELD(GGGLHECDAMD BFBBPILOBDE, LPHBDDFNIEM JFGIPFOFKHL, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x28B2DE0", Offset = "0x28B1FE0", VA = "0x1828B2DE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JFMPBAHJPEF))]
	public Task GNJLBDDANJL(CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x28B2C90", Offset = "0x28B1E90", VA = "0x1828B2C90")]
	private static void GJFODCIHJGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x28B2F30", Offset = "0x28B2130", VA = "0x1828B2F30")]
	private void LBHKIEMLBHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x28B2BE0", Offset = "0x28B1DE0", VA = "0x1828B2BE0")]
	private static float BAJLFNDGCPE(KANPCPNLPMN LJKHADFBIKG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x28B3240", Offset = "0x28B2440", VA = "0x1828B3240")]
	private static float OCNLHNKHFFF()
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal class HGFHAMOOEPL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class MGDKANDDMOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public AsyncTaskMethodBuilder<GBOAMHGCLHL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public GBOAMHGCLHL roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public HGFHAMOOEPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private GBOAMHGCLHL <message>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private LKGIPCJDHDA.HBELCONLOEO<GBOAMHGCLHL> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private TaskAwaiter<LKGIPCJDHDA.HBELCONLOEO<GBOAMHGCLHL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public MGDKANDDMOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x3AE4560", Offset = "0x3AE3760", VA = "0x183AE4560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private struct NNPOFFEHMNN<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private sealed class MOFICIIFLON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public GBOAMHGCLHL roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public MOFICIIFLON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x3AE5050", Offset = "0x3AE4250", VA = "0x183AE5050")]
		internal GBOAMHGCLHL EEMJAKFFPJG(byte[] msg)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private sealed class GDLFBCEKNJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public AsyncTaskMethodBuilder<LKGIPCJDHDA.HBELCONLOEO<GBOAMHGCLHL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public GBOAMHGCLHL roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public HGFHAMOOEPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private MOFICIIFLON <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private FHNGOBBBPKK <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private LKGIPCJDHDA.HBELCONLOEO<GBOAMHGCLHL> <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private FHNGOBBBPKK <actualMessageKind>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private LKGIPCJDHDA.HBELCONLOEO<GBOAMHGCLHL> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private string <errorMessage>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private ByteString <actualOperationId>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private string <errorMessage>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private TaskAwaiter<LKGIPCJDHDA.HBELCONLOEO<GBOAMHGCLHL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public GDLFBCEKNJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x3ADB1A0", Offset = "0x3ADA3A0", VA = "0x183ADB1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private sealed class CAJBDJGJDID<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public HGFHAMOOEPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private T <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public CAJBDJGJDID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x1E40B20", Offset = "0x1E3FD20", VA = "0x181E40B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private sealed class BLEOAGGADPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public HGFHAMOOEPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public BLEOAGGADPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x3AD80E0", Offset = "0x3AD72E0", VA = "0x183AD80E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private sealed class NLMHFOEKGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public NLMHFOEKGIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6510", Offset = "0x3AE5710", VA = "0x183AE6510")]
		internal object CHMIPEJHOPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6570", Offset = "0x3AE5770", VA = "0x183AE6570")]
		internal bool IFKMKIILFPO(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private sealed class OGLGPBAOEOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public OGLGPBAOEOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6F00", Offset = "0x3AE6100", VA = "0x183AE6F00")]
		internal object KPIHOLNAKND()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class LOGGBNLCPIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public LOGGBNLCPIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x3AE42C0", Offset = "0x3AE34C0", VA = "0x183AE42C0")]
		internal object FLLLEAFHNCD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private sealed class LPGNACIGMGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public LPGNACIGMGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x3AE4330", Offset = "0x3AE3530", VA = "0x183AE4330")]
		internal object AOAFBIPOBFG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private sealed class MIHNBEMEHFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public HGFHAMOOEPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public MIHNBEMEHFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x3AE48E0", Offset = "0x3AE3AE0", VA = "0x183AE48E0")]
		internal object JNJCCPHODPF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private static readonly Guid KKCNMAMLAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public readonly IDGCAAGDMGH LDDBKPOCCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	private readonly LKGIPCJDHDA CMBPONCMCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	private readonly ILNACKPLCPP FPIOPDMALNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	private readonly LIHLNNEIDFD HDCFALCHGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	private bool EIIHGJFGKMK;

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x1F72300", Offset = "0x1F71500", VA = "0x181F72300")]
	public HGFHAMOOEPL(IDGCAAGDMGH BGHGOMFIAIP, LKGIPCJDHDA CMBPONCMCLO, ILNACKPLCPP FPIOPDMALNF, LIHLNNEIDFD HDCFALCHGNO, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x1F71410", Offset = "0x1F70610", VA = "0x181F71410", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x1F71410", Offset = "0x1F70610", VA = "0x181F71410")]
	public void COLLFCHPFOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x1F719A0", Offset = "0x1F70BA0", VA = "0x181F719A0")]
	public void KIOABINIIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x1F717B0", Offset = "0x1F709B0", VA = "0x181F717B0")]
	public void GGHIDPGLBEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x1F72060", Offset = "0x1F71260", VA = "0x181F72060")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MGDKANDDMOA))]
	internal Task<GBOAMHGCLHL> PAFIMAGFBDC(GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, GBOAMHGCLHL GBANBELFDDC, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x1F5B1A0", Offset = "0x1F5A3A0", VA = "0x181F5B1A0")]
	private static byte[] DCMLHGHGHMC<T>(T JPOEHOENKPI) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x2176290", Offset = "0x2175490", VA = "0x182176290")]
	private static T ACHJDHIDJDD<T>(MessageParser<T> DBKJGMCEKDH, byte[] JPOEHOENKPI, T LHACNDMACAN) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x1F71C00", Offset = "0x1F70E00", VA = "0x181F71C00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GDLFBCEKNJM))]
	private Task<LKGIPCJDHDA.HBELCONLOEO<GBOAMHGCLHL>> MLMMDCDHAOA(GBOAMHGCLHL GBANBELFDDC, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x2176A30", Offset = "0x2175C30", VA = "0x182176A30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CAJBDJGJDID<>))]
	internal Task<T> MIANPMDEHFM<T>(CancellationToken JIEKCCCMBMG, Func<CancellationToken, Task<T>> PGGLIFFOLJD, int ENINODCDEGF = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x1F71A70", Offset = "0x1F70C70", VA = "0x181F71A70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BLEOAGGADPM))]
	internal Task MIANPMDEHFM(CancellationToken JIEKCCCMBMG, Func<CancellationToken, Task> PGGLIFFOLJD, int ENINODCDEGF = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x1F71310", Offset = "0x1F70510", VA = "0x181F71310")]
	public AOJOEBHKBAP CGIBOMLGPGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x1F72220", Offset = "0x1F71420", VA = "0x181F72220")]
	public GFDEABGKDAE PHOFJIEEPGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x1F71DA0", Offset = "0x1F70FA0", VA = "0x181F71DA0")]
	public BJLKOGNGHKA NCKNLDOHNEN([Optional] PEKDFCFCENH? LHCMKIAHBCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x1F71150", Offset = "0x1F70350", VA = "0x181F71150")]
	public void BALBGHLPOBM(Func<Guid, bool> LDGDFFKHFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x1F71530", Offset = "0x1F70730", VA = "0x181F71530")]
	public void FCIOKEKABCA(Func<Guid, bool> EEAKFAFPNPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x1F70FA0", Offset = "0x1F701A0", VA = "0x181F70FA0")]
	public Guid AGKKACJKDKN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x1F71F30", Offset = "0x1F71130", VA = "0x181F71F30")]
	public void NINANDLNGBL(Guid JFPOCODONBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x1F71660", Offset = "0x1F70860", VA = "0x181F71660")]
	public void FOMHPGBKMDJ(GBOAMHGCLHL KDIOCBGEHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x1F71880", Offset = "0x1F70A80", VA = "0x181F71880")]
	public void GMDPMBHBMHO(string EOKMMINFMOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x2176750", Offset = "0x2175950", VA = "0x182176750")]
	private T IOKKMGEHAFC<T>(T NABCGCEIEGG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x1F712C0", Offset = "0x1F704C0", VA = "0x181F712C0")]
	public void CFCEAHJNOMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x2176440", Offset = "0x2175640", VA = "0x182176440")]
	[CompilerGenerated]
	internal static string ILMOHIFNMEC<T>(byte[] NDONHPGBMNB, int JFAGLBDJNCF, ref NNPOFFEHMNN<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
internal struct HAOMGFGJIGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private sealed class HKIANDAANMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public GGGLHECDAMD roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public bool omShouldBeEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public HKIANDAANMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x3ADC830", Offset = "0x3ADBA30", VA = "0x183ADC830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private sealed class JKHIFPKBAKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public HAOMGFGJIGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private EDKAOGBNBOB <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public JKHIFPKBAKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x3AE11E0", Offset = "0x3AE03E0", VA = "0x183AE11E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	private GGGLHECDAMD BFBBPILOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	private bool CBJEONBKCGJ;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private KANPCPNLPMN JOECKGCKOMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x1F70330", Offset = "0x1F6F530", VA = "0x181F70330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private NBJPFMBJGMB LJJGEEJCHJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x1F6FCF0", Offset = "0x1F6EEF0", VA = "0x181F6FCF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x1F6FD70", Offset = "0x1F6EF70", VA = "0x181F6FD70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HKIANDAANMN))]
	public static Task GNJLBDDANJL(GGGLHECDAMD BFBBPILOBDE, bool CBJEONBKCGJ, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x1F6FF10", Offset = "0x1F6F110", VA = "0x181F6FF10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JKHIFPKBAKE))]
	private Task GNJLBDDANJL(GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x1F70090", Offset = "0x1F6F290", VA = "0x181F70090")]
	private void LFDLGOENMBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
internal struct DILJPBGBCFH
{
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private sealed class BAPEGKABGIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public GGGLHECDAMD roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public LPHBDDFNIEM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public HGFHAMOOEPL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public BAPEGKABGIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x3E47FC0", Offset = "0x3E471C0", VA = "0x183E47FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private sealed class APJPNGAPFHO
	{
		[Cpp2IlInjected.Token(Token = "0x2000129")]
		private sealed class <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004DF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004E1")]
			public GAKPIOFBDII<string>.JOKPHMHCDCF timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004E2")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004E3")]
			public APJPNGAPFHO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40004E5")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public <<Run>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054A")]
			[Cpp2IlInjected.Address(RVA = "0x4EED280", Offset = "0x4EEC480", VA = "0x184EED280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public APJPNGAPFHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x3E47E50", Offset = "0x3E47050", VA = "0x183E47E50")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task HPLINGMNNLM(GAKPIOFBDII<string>.JOKPHMHCDCF timer, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private sealed class DEAEGFIGIFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public DILJPBGBCFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private AGRoomRuntimeConfig.Location <locationConfig>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private APJPNGAPFHO <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private GBOAMHGCLHL <completeMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private object <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private TaskAwaiter<GBOAMHGCLHL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public DEAEGFIGIFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x3E4BCE0", Offset = "0x3E4AEE0", VA = "0x183E4BCE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private sealed class ODAAJGHJDHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public NIFCDPEEFKO version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public ODAAJGHJDHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x3E59AD0", Offset = "0x3E58CD0", VA = "0x183E59AD0")]
		internal object OEHHKHPKHBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x3E59BB0", Offset = "0x3E58DB0", VA = "0x183E59BB0")]
		internal object PCLHDCJGPBG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private GGGLHECDAMD BFBBPILOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private LPHBDDFNIEM JFGIPFOFKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	private HGFHAMOOEPL GIICFIPJIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	private bool GAOJHADMCHM;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	private static readonly ByteString EFPKBHHIHKO;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private KANPCPNLPMN JOECKGCKOMK
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x1F659C0", Offset = "0x1F64BC0", VA = "0x181F659C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private NBJPFMBJGMB LJJGEEJCHJO
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x1F655E0", Offset = "0x1F647E0", VA = "0x181F655E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x1F657E0", Offset = "0x1F649E0", VA = "0x181F657E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BAPEGKABGIL))]
	public static Task GNJLBDDANJL(GGGLHECDAMD BFBBPILOBDE, LPHBDDFNIEM JFGIPFOFKHL, HGFHAMOOEPL GIICFIPJIBI, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC, bool GAOJHADMCHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x1F65660", Offset = "0x1F64860", VA = "0x181F65660")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DEAEGFIGIFD))]
	private Task GNJLBDDANJL(GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x1F65000", Offset = "0x1F64200", VA = "0x181F65000")]
	private void FDKPKDGDKPM([NotNull] PPPFGNOFILG MHCMHOAOIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x1F65A10", Offset = "0x1F64C10", VA = "0x181F65A10")]
	private bool PGHGLNEIHPM(NIFCDPEEFKO KBIJDJHCEBH, PPPFGNOFILG MHCMHOAOIOG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
internal abstract class IOAACHJKDOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public readonly IDGCAAGDMGH LDDBKPOCCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public readonly HGFHAMOOEPL FFOOOGMKGFE;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public KANPCPNLPMN JOECKGCKOMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x1F75740", Offset = "0x1F74940", VA = "0x181F75740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public NBJPFMBJGMB LJJGEEJCHJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x1F75690", Offset = "0x1F74890", VA = "0x181F75690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x1F75790", Offset = "0x1F74990", VA = "0x181F75790")]
	protected IOAACHJKDOE(HGFHAMOOEPL GIICFIPJIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x1F75720", Offset = "0x1F74920", VA = "0x181F75720")]
	protected void GMDPMBHBMHO(string EOKMMINFMOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal class GFDEABGKDAE : IOAACHJKDOE, HPFNPAGBIDJ
{
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	public delegate Task<JBHFADCJFPJ> IKBNAIPNKAF(LPHBDDFNIEM JFGIPFOFKHL, EBKHDKDGJPI GOKMMJGAMEF, EEMHMDDCNGF GAAMHIGAPHP, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private sealed class IHGPLPFNCGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public NAFOEDAKNOD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public GFDEABGKDAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private EOGCALPKEIF <lifetime>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private GBOAMHGCLHL <synced>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private GBOAMHGCLHL <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private TaskAwaiter<GBOAMHGCLHL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public IHGPLPFNCGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x3ADE820", Offset = "0x3ADDA20", VA = "0x183ADE820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private sealed class JAOGJICCNMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public AsyncTaskMethodBuilder<GBOAMHGCLHL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public NAFOEDAKNOD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public GFDEABGKDAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <syncTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private GBOAMHGCLHL <message>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private GBOAMHGCLHL <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private TaskAwaiter<GBOAMHGCLHL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public JAOGJICCNMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x3ADFBA0", Offset = "0x3ADEDA0", VA = "0x183ADFBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class ANLKCJFCGBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public NAFOEDAKNOD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public GFDEABGKDAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <loadRoomLocalTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public ANLKCJFCGBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x3E47BB0", Offset = "0x3E46DB0", VA = "0x183E47BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private sealed class LHANKGJODOG
	{
		[Cpp2IlInjected.Token(Token = "0x2000133")]
		private sealed class <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000525")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000526")]
			public AsyncTaskMethodBuilder<LLFMDKPFMOB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000527")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000528")]
			public LHANKGJODOG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000529")]
			private LLFMDKPFMOB <innerData>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400052A")]
			private LLFMDKPFMOB <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400052B")]
			private TaskAwaiter<JBHFADCJFPJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400052C")]
			private TaskAwaiter<LLFMDKPFMOB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public <<LoadRoomLocal>b__2>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000589")]
			[Cpp2IlInjected.Address(RVA = "0x4EEBE70", Offset = "0x4EEB070", VA = "0x184EEBE70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058A")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000134")]
		private sealed class <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			public AsyncTaskMethodBuilder<LPHBDDFNIEM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			public LHANKGJODOG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			private LPHBDDFNIEM <innerPhaseArgs>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private LPHBDDFNIEM <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private TaskAwaiter<JBHFADCJFPJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			private TaskAwaiter<LPHBDDFNIEM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600058B")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public <<LoadRoomLocal>b__4>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058C")]
			[Cpp2IlInjected.Address(RVA = "0x4EEC5C0", Offset = "0x4EEB7C0", VA = "0x184EEC5C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058D")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000135")]
		private sealed class <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000535")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000536")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000537")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000538")]
			public LHANKGJODOG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			private bool <isReloadingSceneForObjectModel>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
			[Cpp2IlInjected.Token(Token = "0x400053A")]
			private bool <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400053B")]
			private EBKHDKDGJPI <timedYielder>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400053C")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400053D")]
			private TaskAwaiter<JBHFADCJFPJ> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400053E")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x600058E")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public <<LoadRoomLocal>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0x4EEAA00", Offset = "0x4EE9C00", VA = "0x184EEAA00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000590")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public GFDEABGKDAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public NAFOEDAKNOD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public EEMHMDDCNGF preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public EEMHMDDCNGF downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public LLFMDKPFMOB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public EEMHMDDCNGF postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public LPHBDDFNIEM phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public NKKIHOOPLKJ.JLLODPBOBLL <>9__6;

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public LHANKGJODOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3270", Offset = "0x3AE2470", VA = "0x183AE3270")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<LLFMDKPFMOB> DAAKOAFAEFL(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x3AE33E0", Offset = "0x3AE25E0", VA = "0x183AE33E0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<LPHBDDFNIEM> EAHKDFBBCJC(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x3AE36A0", Offset = "0x3AE28A0", VA = "0x183AE36A0")]
		internal void IECLNMLFPIJ(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3550", Offset = "0x3AE2750", VA = "0x183AE3550")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task GDPOOMNJJFG(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private sealed class PGKALJHOBAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public NAFOEDAKNOD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public GFDEABGKDAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private LHANKGJODOG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private bool <hasAssetBundle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private float <dataDownloadProgressRangeUpperBound>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private LLFMDKPFMOB <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private LPHBDDFNIEM <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private TaskAwaiter<LLFMDKPFMOB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private TaskAwaiter<LPHBDDFNIEM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public PGKALJHOBAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x3AE7560", Offset = "0x3AE6760", VA = "0x183AE7560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private sealed class CEFCAJNHCGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public GFDEABGKDAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public CEFCAJNHCGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x3E48CF0", Offset = "0x3E47EF0", VA = "0x183E48CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private sealed class OPDAGOJINDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public LPHBDDFNIEM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public EEMHMDDCNGF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public GFDEABGKDAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <legacyLoadRoomDataTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private TaskAwaiter<JBHFADCJFPJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public OPDAGOJINDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6F60", Offset = "0x3AE6160", VA = "0x183AE6F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private sealed class LJEKFOLGIFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public AsyncTaskMethodBuilder<JBHFADCJFPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public LPHBDDFNIEM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public EBKHDKDGJPI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public EEMHMDDCNGF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public GFDEABGKDAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <destroyAndRebuildObjectsTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private TaskAwaiter<JBHFADCJFPJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public LJEKFOLGIFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x3AE36E0", Offset = "0x3AE28E0", VA = "0x183AE36E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private sealed class CMECDAFPKHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public AsyncTaskMethodBuilder<JBHFADCJFPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public LPHBDDFNIEM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public EBKHDKDGJPI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public EEMHMDDCNGF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public GFDEABGKDAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <deserializeAllObjectsTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private TaskAwaiter<JBHFADCJFPJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public CMECDAFPKHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x3E49A90", Offset = "0x3E48C90", VA = "0x183E49A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private sealed class GIDAPIOOGFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public AsyncTaskMethodBuilder<JBHFADCJFPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public JBHFADCJFPJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public LPHBDDFNIEM deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public EEMHMDDCNGF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public GFDEABGKDAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private JBHFADCJFPJ <result>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private JBHFADCJFPJ <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private TaskAwaiter<JBHFADCJFPJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public GIDAPIOOGFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x3E530D0", Offset = "0x3E522D0", VA = "0x183E530D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private sealed class IPILBNMBMGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public GFDEABGKDAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public LPHBDDFNIEM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public EEMHMDDCNGF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public IKBNAIPNKAF masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public EBKHDKDGJPI timedYielder;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public IPILBNMBMGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class GBENLAFJBDP
	{
		[Cpp2IlInjected.Token(Token = "0x200013F")]
		private sealed class <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400058C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400058D")]
			public AsyncTaskMethodBuilder<JBHFADCJFPJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400058E")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400058F")]
			public GBENLAFJBDP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000590")]
			private IDisposable <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000591")]
			private JBHFADCJFPJ <result>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000592")]
			private JBHFADCJFPJ <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000593")]
			private TaskAwaiter<JBHFADCJFPJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public <<MasterLockedPhaseChangeBlock>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x4EECBB0", Offset = "0x4EEBDB0", VA = "0x184EECBB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public JBHFADCJFPJ originalRoomLoadPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public IPILBNMBMGO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public GBENLAFJBDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x3E51F30", Offset = "0x3E51130", VA = "0x183E51F30")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<JBHFADCJFPJ> DNJPPMJPOCB(CancellationToken mlToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private sealed class NCGFCDKLDGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public AsyncTaskMethodBuilder<JBHFADCJFPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public LPHBDDFNIEM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public EBKHDKDGJPI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public EEMHMDDCNGF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public IKBNAIPNKAF masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public GFDEABGKDAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		private IPILBNMBMGO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private GBENLAFJBDP <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private JBHFADCJFPJ <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private TaskAwaiter<JBHFADCJFPJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public NCGFCDKLDGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x3AE5140", Offset = "0x3AE4340", VA = "0x183AE5140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private sealed class NFLNHJOJLHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public LPHBDDFNIEM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public EEMHMDDCNGF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public GFDEABGKDAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private JBHFADCJFPJ <legacyEndPhase>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private IEnumerator<JBHFADCJFPJ> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private JBHFADCJFPJ <phase>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private TaskAwaiter<JBHFADCJFPJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public NFLNHJOJLHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x3AE56A0", Offset = "0x3AE48A0", VA = "0x183AE56A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class NHNEHPHGPKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public LPHBDDFNIEM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public GFDEABGKDAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public NHNEHPHGPKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x3AE5B10", Offset = "0x3AE4D10", VA = "0x183AE5B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private sealed class FBJOKOJEHDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public LPHBDDFNIEM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public GFDEABGKDAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public FBJOKOJEHDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x3E4F2D0", Offset = "0x3E4E4D0", VA = "0x183E4F2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private readonly DEILOLEAADK KMGEKEBOLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly DEILOLEAADK OPFKOHELEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private readonly KPKLBEKJJDL ELHDKJIFJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private readonly IIBENEHJHPD PFPHCALNCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private readonly IKOBKKDPODB CHNBHNMPHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private readonly LDFPHEEBEDP FBEKJLFCCMN;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private GGGLHECDAMD HGLNLGDLOOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x1F5A230", Offset = "0x1F59430", VA = "0x181F5A230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event MLHFNLBGINN IDGOBMDILIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x1F6BE80", Offset = "0x1F6B080", VA = "0x181F6BE80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x1F6DD30", Offset = "0x1F6CF30", VA = "0x181F6DD30", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x1F6E0D0", Offset = "0x1F6D2D0", VA = "0x181F6E0D0")]
	public GFDEABGKDAE(HGFHAMOOEPL GIICFIPJIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x1F6CDA0", Offset = "0x1F6BFA0", VA = "0x181F6CDA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IHGPLPFNCGC))]
	public Task IODJFMLOKCD(NAFOEDAKNOD DMFMJBFFPPI, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x1F6C0A0", Offset = "0x1F6B2A0", VA = "0x181F6C0A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JAOGJICCNMJ))]
	private Task<GBOAMHGCLHL> BDDOPEDOLNH(NAFOEDAKNOD DMFMJBFFPPI, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x1F6D2F0", Offset = "0x1F6C4F0", VA = "0x181F6D2F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ANLKCJFCGBH))]
	private Task JPNKEOHJIOB(NAFOEDAKNOD DMFMJBFFPPI, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x1F6D150", Offset = "0x1F6C350", VA = "0x181F6D150")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PGKALJHOBAN))]
	private Task JIMALAIAGDA(NAFOEDAKNOD DMFMJBFFPPI, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken HNMLCBHCEII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x1F6DF60", Offset = "0x1F6D160", VA = "0x181F6DF60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CEFCAJNHCGB))]
	private Task PCBLDAIBBOE(GAKPIOFBDII<string>.JOKPHMHCDCF ENNBBCEBKAC, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x1F6CF40", Offset = "0x1F6C140", VA = "0x181F6CF40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OPDAGOJINDM))]
	private Task JBIFEGKKJAP(LPHBDDFNIEM JFGIPFOFKHL, EEMHMDDCNGF GAAMHIGAPHP, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x1F6CB70", Offset = "0x1F6BD70", VA = "0x181F6CB70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LJEKFOLGIFN))]
	private Task<JBHFADCJFPJ> HKDCNCAOMCP(LPHBDDFNIEM JFGIPFOFKHL, EBKHDKDGJPI ECBJHNFIHMD, EEMHMDDCNGF GAAMHIGAPHP, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x1F6DD50", Offset = "0x1F6CF50", VA = "0x181F6DD50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CMECDAFPKHC))]
	private Task<JBHFADCJFPJ> OIEMOIJOGED(LPHBDDFNIEM JFGIPFOFKHL, EBKHDKDGJPI ECBJHNFIHMD, EEMHMDDCNGF GAAMHIGAPHP, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x1F6D7E0", Offset = "0x1F6C9E0", VA = "0x181F6D7E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GIDAPIOOGFP))]
	private Task<JBHFADCJFPJ> MNPNEKDGJMH(JBHFADCJFPJ HJFGMHGIDFB, LPHBDDFNIEM JEMHOAGGDPM, EEMHMDDCNGF GAAMHIGAPHP, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC, bool JDLKLFHFKAN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x1F6D550", Offset = "0x1F6C750", VA = "0x181F6D550")]
	private bool LHFCDIENBLO(LPHBDDFNIEM KMBLINPHEHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x1F6C260", Offset = "0x1F6B460", VA = "0x181F6C260")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NCGFCDKLDGA))]
	protected Task<JBHFADCJFPJ> CELBPDFOAPF(LPHBDDFNIEM JFGIPFOFKHL, EBKHDKDGJPI ECBJHNFIHMD, EEMHMDDCNGF GAAMHIGAPHP, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC, IKBNAIPNKAF NMPPDCLFGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x1F6C600", Offset = "0x1F6B800", VA = "0x181F6C600")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NFLNHJOJLHB))]
	private Task DMBLNHMMDIE(LPHBDDFNIEM JFGIPFOFKHL, EEMHMDDCNGF GAAMHIGAPHP, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x1F6D100", Offset = "0x1F6C300", VA = "0x181F6D100")]
	private void JDPBIKIIBAA(JBHFADCJFPJ JPIFBMAMJBM, EEMHMDDCNGF GAAMHIGAPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x1F6D510", Offset = "0x1F6C710", VA = "0x181F6D510")]
	private void LFIBEONHIFC(JBHFADCJFPJ FLLNMIIGLGD, out JBHFADCJFPJ GGLINPBEBLO, out JBHFADCJFPJ JJGDIMIKKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x1F6BEA0", Offset = "0x1F6B0A0", VA = "0x181F6BEA0")]
	private Task<LLFMDKPFMOB> ADIOEIIBDNL(NAFOEDAKNOD DMFMJBFFPPI, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x1F6C980", Offset = "0x1F6BB80", VA = "0x181F6C980")]
	private Task<LPHBDDFNIEM> FFODICAEBHE(LLFMDKPFMOB JFGIPFOFKHL, NKKIHOOPLKJ.JLLODPBOBLL NNLODNNNDLH, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x1F6BEE0", Offset = "0x1F6B0E0", VA = "0x181F6BEE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NHNEHPHGPKE))]
	private Task ALLOECDKJNJ(LPHBDDFNIEM JFGIPFOFKHL, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC, bool GAOJHADMCHM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x1F6C490", Offset = "0x1F6B690", VA = "0x181F6C490")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FBJOKOJEHDJ))]
	private Task DIADJEMHHPA(LPHBDDFNIEM JFGIPFOFKHL, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x1F6D650", Offset = "0x1F6C850", VA = "0x181F6D650")]
	private Task MNAIOIOIJDG(LPHBDDFNIEM JFGIPFOFKHL, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x1F6C9C0", Offset = "0x1F6BBC0", VA = "0x181F6C9C0")]
	private Task FPNHKEBOIND(LPHBDDFNIEM JFGIPFOFKHL, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x1F6DB90", Offset = "0x1F6CD90", VA = "0x181F6DB90")]
	private Task NFDLHLABLAD(LPHBDDFNIEM JFGIPFOFKHL, EBKHDKDGJPI ECBJHNFIHMD, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x1F6C7C0", Offset = "0x1F6B9C0", VA = "0x181F6C7C0")]
	private Task FBNEKNNOGPO(LPHBDDFNIEM JFGIPFOFKHL, EBKHDKDGJPI ECBJHNFIHMD, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x1F6A220", Offset = "0x1F69420", VA = "0x181F6A220")]
	private static Task BHMEENPCDLA(CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x1F6D9F0", Offset = "0x1F6CBF0", VA = "0x181F6D9F0")]
	private Task NCMGGBAHFKG(LPHBDDFNIEM JFGIPFOFKHL, EBKHDKDGJPI ECBJHNFIHMD, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x1F6CB50", Offset = "0x1F6BD50", VA = "0x181F6CB50")]
	private Task GPOLEPGNOIK(LPHBDDFNIEM JFGIPFOFKHL, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x1F6D490", Offset = "0x1F6C690", VA = "0x181F6D490")]
	private void KPCDGGPCLGC(NAFOEDAKNOD DMFMJBFFPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x1F6CD80", Offset = "0x1F6BF80", VA = "0x181F6CD80")]
	public void HLGLOEMEJEJ(long FNJOKPDAGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	private static void OIFKPIBBBOE(JICMMHOABAL NDCGCFMCEHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
internal abstract class IDGCAAGDMGH : HPFNPAGBIDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	public delegate Task GGCPDMPNIOB(GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private sealed class NBOOCGCPMGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public IDGCAAGDMGH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public NBOOCGCPMGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x3AE5110", Offset = "0x3AE4310", VA = "0x183AE5110")]
		internal Task LHNDDELBFHF(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class PJFNDCHCPID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public NBOOCGCPMGP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public PJFNDCHCPID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x3AE8600", Offset = "0x3AE7800", VA = "0x183AE8600")]
		internal object AEIEKDANGKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x3AE86C0", Offset = "0x3AE78C0", VA = "0x183AE86C0")]
		internal object GODHIFLGAFF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private sealed class CGODKOJHPJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public Func<IDGCAAGDMGH, GAKPIOFBDII<string>.JOKPHMHCDCF, HGFHAMOOEPL> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public IDGCAAGDMGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private NBOOCGCPMGP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private HGFHAMOOEPL <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private Task <drivenTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		private GBOAMHGCLHL <completeMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private PJFNDCHCPID <>8__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private TaskAwaiter<GBOAMHGCLHL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public CGODKOJHPJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8AB0", Offset = "0x3AD7CB0", VA = "0x183AD8AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private sealed class CKKNNAELELF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public IDGCAAGDMGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private GGCPDMPNIOB <taskBuilder>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public CKKNNAELELF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9A20", Offset = "0x3AD8C20", VA = "0x183AD9A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005BB")]
	public readonly Guid KFFEAPGHNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005BC")]
	public readonly ByteString LEBGILFGHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005BD")]
	public readonly MDHCFBFJDKN CLKHHLKPDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005BE")]
	protected readonly string MFJBLLBKFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005BF")]
	private readonly GGGLHECDAMD BFBBPILOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	private readonly bool DBBMDEJCBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40005C1")]
	private readonly Queue<GGCPDMPNIOB> FHENIGEFGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005C2")]
	private readonly EEMHMDDCNGF ACBBFBBMBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	private readonly CGPDIEAJPGM BDIHIOJPHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40005C4")]
	private bool ENOEENGPFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	public JBHFADCJFPJ IBILKOJFBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	public JBHFADCJFPJ CDMLMAICAIG;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public GGGLHECDAMD HGLNLGDLOOE
	{
		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x89B300", Offset = "0x89A500", VA = "0x18089B300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public KANPCPNLPMN JOECKGCKOMK
	{
		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x1F734C0", Offset = "0x1F726C0", VA = "0x181F734C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public GFBJKCOKDNB CMPKILKFPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x1F72B20", Offset = "0x1F71D20", VA = "0x181F72B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public NBJPFMBJGMB LJJGEEJCHJO
	{
		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x1F73020", Offset = "0x1F72220", VA = "0x181F73020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event MLHFNLBGINN IDGOBMDILIL
	{
		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x1F72B00", Offset = "0x1F71D00", VA = "0x181F72B00", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x1F734A0", Offset = "0x1F726A0", VA = "0x181F734A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x1F73570", Offset = "0x1F72770", VA = "0x181F73570")]
	protected IDGCAAGDMGH(Guid OAOAFDNAJNM, GGGLHECDAMD BFBBPILOBDE, MDHCFBFJDKN LPFOCNKNJLE, string GNLHPBLPIHO, CGPDIEAJPGM BDIHIOJPHJO, bool DBBMDEJCBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x1F72B70", Offset = "0x1F71D70", VA = "0x181F72B70", Slot = "6")]
	protected virtual string BOAIIGCLKOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x1F73510", Offset = "0x1F72710", VA = "0x181F73510")]
	public void PEFJIOHNOBF(GGCPDMPNIOB NBKBADNKMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x1F72D20", Offset = "0x1F71F20", VA = "0x181F72D20")]
	protected void CLCDHBELFKJ(float DJFHFDKDHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x1F730A0", Offset = "0x1F722A0", VA = "0x181F730A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CGODKOJHPJG))]
	public Task GNJLBDDANJL(CancellationToken MELLLMEKJLC, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, [Optional] Func<IDGCAAGDMGH, GAKPIOFBDII<string>.JOKPHMHCDCF, HGFHAMOOEPL> JJLHCANDGDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x1F73320", Offset = "0x1F72520", VA = "0x181F73320")]
	private void KFILOFKJCGG(bool KECICGODINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x1F72D40", Offset = "0x1F71F40", VA = "0x181F72D40")]
	private void DDHNGGJMNJN(HGFHAMOOEPL GIICFIPJIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task JOLJFFAOAGI(HGFHAMOOEPL GIICFIPJIBI, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x1F72BB0", Offset = "0x1F71DB0", VA = "0x181F72BB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CKKNNAELELF))]
	private Task BPFMOLMIFPL(GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x1F72F90", Offset = "0x1F72190", VA = "0x181F72F90")]
	public GBOAMHGCLHL DFPJFEJMHEI(FHNGOBBBPKK LAFLECJPEDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x1F73240", Offset = "0x1F72440", VA = "0x181F73240")]
	[CompilerGenerated]
	private Task INCCFJHNKOP(CancellationToken APIDLMAPAPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
internal abstract class IJILLHGDBDN : IDGCAAGDMGH
{
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class LDDOLPMHIOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public IJILLHGDBDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public GOHIOILFMAP playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public LDDOLPMHIOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x3AE2F30", Offset = "0x3AE2130", VA = "0x183AE2F30")]
		internal Task AMDPPEOFHAB(GAKPIOFBDII<string>.JOKPHMHCDCF postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x3AE2F70", Offset = "0x3AE2170", VA = "0x183AE2F70")]
		internal object NMENDABIPHB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private sealed class IEDAGKJAOFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public HGFHAMOOEPL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public IJILLHGDBDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		private LDDOLPMHIOA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		private object <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		private int <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private MABENKHHNIG <recoverableRoomOperationException>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public IEDAGKJAOFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x3ADD670", Offset = "0x3ADC870", VA = "0x183ADD670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class FIKMCGGPKBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public GOHIOILFMAP playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public IJILLHGDBDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private Exception <e>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public FIKMCGGPKBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x3ADA940", Offset = "0x3AD9B40", VA = "0x183ADA940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x1F75030", Offset = "0x1F74230", VA = "0x181F75030")]
	public IJILLHGDBDN(Guid OAOAFDNAJNM, GGGLHECDAMD BFBBPILOBDE, MDHCFBFJDKN LPFOCNKNJLE, string GNLHPBLPIHO, CGPDIEAJPGM BDIHIOJPHJO, bool DBBMDEJCBCH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x1F74E90", Offset = "0x1F74090", VA = "0x181F74E90", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IEDAGKJAOFP))]
	protected override Task JOLJFFAOAGI(HGFHAMOOEPL GIICFIPJIBI, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task NJNHPFHMJNI(HGFHAMOOEPL GIICFIPJIBI, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x1F74CF0", Offset = "0x1F73EF0", VA = "0x181F74CF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FIKMCGGPKBE))]
	private Task DFLHGLPHDIC(IDisposable FBKCGBBMNOA, GOHIOILFMAP NOMINLJPJGM, GAKPIOFBDII<string>.JOKPHMHCDCF ENNBBCEBKAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
public readonly struct CKEACEFIEED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	public readonly PPPFGNOFILG? FPNDDJNIAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005FA")]
	public readonly DOEMMOCKGII JPNMCMPMPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005FB")]
	public readonly string? PPIILIIMPLK;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public IReadOnlyCollection<string> JEKDECCADPG
	{
		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x1F5EF60", Offset = "0x1F5E160", VA = "0x181F5EF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public IReadOnlyDictionary<long, int> CAIPOHOEGDG
	{
		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x1F5EF40", Offset = "0x1F5E140", VA = "0x181F5EF40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x1F5EF80", Offset = "0x1F5E180", VA = "0x181F5EF80")]
	public CKEACEFIEED(PPPFGNOFILG? DONGKHHNBIB, DOEMMOCKGII CMKNLMEKKBE, string? JHFBHDCCEFE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014F")]
internal struct JABEPIKLLGD
{
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private sealed class BIJKNAODIED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public HGFHAMOOEPL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public LPHBDDFNIEM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		private IDGCAAGDMGH <operation>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		private GGGLHECDAMD <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		private GNBNNEBCBLF.EKNHFFBFEID <instantiations>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		private TaskAwaiter<GBOAMHGCLHL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public BIJKNAODIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x3AD7840", Offset = "0x3AD6A40", VA = "0x183AD7840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private sealed class JCAJFLHFLHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public JCAJFLHFLHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x3ADFF20", Offset = "0x3ADF120", VA = "0x183ADFF20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x1F75B40", Offset = "0x1F74D40", VA = "0x181F75B40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BIJKNAODIED))]
	public static Task GNJLBDDANJL(HGFHAMOOEPL GIICFIPJIBI, LPHBDDFNIEM JFGIPFOFKHL, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x1F75CE0", Offset = "0x1F74EE0", VA = "0x181F75CE0")]
	private static Task<GBOAMHGCLHL> KEKMBADOAPN(HGFHAMOOEPL GIICFIPJIBI, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x1F75A40", Offset = "0x1F74C40", VA = "0x181F75A40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JCAJFLHFLHI))]
	private static Task CMELLNOJKKM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
internal class PJADLMCHFPP : IDGCAAGDMGH
{
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private sealed class JFGJPLGGFBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public HGFHAMOOEPL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public PJADLMCHFPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		private ObscuredInt <localPlayerAccountId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		private AOJOEBHKBAP <uploadLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		private bool <readSuccessfully>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		private CKEACEFIEED <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		private FFHPOMEPNOI <payload>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private DateTime <localTime>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		private ONNIIAMENKC <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		private TaskAwaiter<ONNIIAMENKC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public JFGJPLGGFBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x4EE57C0", Offset = "0x4EE49C0", VA = "0x184EE57C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400060C")]
	private readonly int CNDLPHFBPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400060D")]
	private readonly GMJLKBDAIPD PEIFNOKHAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400060E")]
	public readonly long ONPGOFFEAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400060F")]
	public readonly long BCDNMFIGJDA;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public ONNIIAMENKC PINLFJPEJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4E0", Offset = "0x8D96E0", VA = "0x1808DA4E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x8D8C80", Offset = "0x8D7E80", VA = "0x1808D8C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x28BA910", Offset = "0x28B9B10", VA = "0x1828BA910")]
	public PJADLMCHFPP(Guid OAOAFDNAJNM, GGGLHECDAMD BFBBPILOBDE, MDHCFBFJDKN LPFOCNKNJLE, int CNDLPHFBPJD, GMJLKBDAIPD PEIFNOKHAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x28BA770", Offset = "0x28B9970", VA = "0x1828BA770", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JFGJPLGGFBL))]
	protected override Task JOLJFFAOAGI(HGFHAMOOEPL GIICFIPJIBI, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
internal struct IKOBKKDPODB
{
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class FHBJOBFFNNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public AsyncTaskMethodBuilder<JBHFADCJFPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public JBHFADCJFPJ nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public LPHBDDFNIEM deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public IKOBKKDPODB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <moveToPhaseTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		private Guid <handlersGuid>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		private JBHFADCJFPJ <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private TaskAwaiter<JBHFADCJFPJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public FHBJOBFFNNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x3ADA300", Offset = "0x3AD9500", VA = "0x183ADA300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private sealed class PIFGHEECFBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public AsyncTaskMethodBuilder<JBHFADCJFPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public JBHFADCJFPJ state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public IKOBKKDPODB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		private GBOAMHGCLHL <message>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private GBOAMHGCLHL <returnMessage>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private JBHFADCJFPJ <authorityPhase>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private GBOAMHGCLHL <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private TaskAwaiter<GBOAMHGCLHL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public PIFGHEECFBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x3AE82B0", Offset = "0x3AE74B0", VA = "0x183AE82B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000623")]
	private readonly HGFHAMOOEPL GIICFIPJIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000624")]
	private readonly KPKLBEKJJDL ELHDKJIFJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000625")]
	private readonly IIBENEHJHPD PFPHCALNCFH;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private IDGCAAGDMGH LDDBKPOCCHB
	{
		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x1F752D0", Offset = "0x1F744D0", VA = "0x181F752D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x1F754C0", Offset = "0x1F746C0", VA = "0x181F754C0")]
	public IKOBKKDPODB(HGFHAMOOEPL GIICFIPJIBI, KPKLBEKJJDL ELHDKJIFJKI, IIBENEHJHPD PFPHCALNCFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x1F75080", Offset = "0x1F74280", VA = "0x181F75080")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FHBJOBFFNNA))]
	public Task<JBHFADCJFPJ> DFEFFMAHEBK(JBHFADCJFPJ NOPHMGCBAMC, LPHBDDFNIEM JEMHOAGGDPM, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC, bool JDLKLFHFKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x1F752F0", Offset = "0x1F744F0", VA = "0x181F752F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PIFGHEECFBD))]
	private Task<JBHFADCJFPJ> PEOLMFPAIBM(GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, JBHFADCJFPJ NJGLKOBADEO, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x1F752A0", Offset = "0x1F744A0", VA = "0x181F752A0")]
	private bool ILJIALPLIOK(JBHFADCJFPJ NFPKNBMMPEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x1F75280", Offset = "0x1F74480", VA = "0x181F75280")]
	private void GMDPMBHBMHO(string CLEOAKJCLAF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000157")]
internal struct GGLFENNILGM
{
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class IBENGOKBBIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public HGFHAMOOEPL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public LPHBDDFNIEM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public EBKHDKDGJPI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private IDGCAAGDMGH <operation>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private JBHFADCJFPJ <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		private GGGLHECDAMD <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private KANPCPNLPMN <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private JKJGFKMFPBH <metrics>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private IDisposable <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private List<(PersistenceView, KHALLJGHNEA)>.Enumerator <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private PersistenceView <view>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		private KHALLJGHNEA <viewData>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public IBENGOKBBIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x3ADCE60", Offset = "0x3ADC060", VA = "0x183ADCE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x1F6E310", Offset = "0x1F6D510", VA = "0x181F6E310")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IBENGOKBBIE))]
	public static Task GNJLBDDANJL(HGFHAMOOEPL GIICFIPJIBI, LPHBDDFNIEM JFGIPFOFKHL, EBKHDKDGJPI ECBJHNFIHMD, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x1F6E4D0", Offset = "0x1F6D6D0", VA = "0x181F6E4D0")]
	private static void OKCGBEEFDLI(PersistenceView NLBPABLMMCP, KHALLJGHNEA LDGNEFNKJHM, LPHBDDFNIEM JFGIPFOFKHL, JBHFADCJFPJ HJFGMHGIDFB, bool JILIODCKCBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal class BJLKOGNGHKA : IOAACHJKDOE
{
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private sealed class PBCFHHBGAKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public AsyncTaskMethodBuilder<CKEACEFIEED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public KPDIBFDKKDG roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public DIGFFKIMPNG serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public BJLKOGNGHKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private StringBuilder <outputBuilder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private IDisposable <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public PBCFHHBGAKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x28BA220", Offset = "0x28B9420", VA = "0x1828BA220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class ENCPIBCGPNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public DIGFFKIMPNG serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public BJLKOGNGHKA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public ENCPIBCGPNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x28A59F0", Offset = "0x28A4BF0", VA = "0x1828A59F0")]
		internal Task FHIKPCMHKDG(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x28A5920", Offset = "0x28A4B20", VA = "0x1828A5920")]
		internal Task AIOAAPECOPK(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private sealed class OPDAFFOCMBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public ENCPIBCGPNF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public OPDAFFOCMBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x28BA1B0", Offset = "0x28B93B0", VA = "0x1828BA1B0")]
		internal object EMPPNOJKGMN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private sealed class FBFDHKGIOKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public ENCPIBCGPNF CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public FBFDHKGIOKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x28A5FC0", Offset = "0x28A51C0", VA = "0x1828A5FC0")]
		internal Task KMOBECBIEIH(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class EEMFLOJGNGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public DIGFFKIMPNG serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public BJLKOGNGHKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		private ENCPIBCGPNF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		private OPDAFFOCMBD <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		private IEnumerable<Task> <pendingPreserializes>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public EEMFLOJGNGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x28A4170", Offset = "0x28A3370", VA = "0x1828A4170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000653")]
	private readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x4000654")]
	private static readonly TimeSpan DJDADKDBFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000655")]
	private readonly GGJDABNIJEB DJCAKEOBKML;

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x1F5CCE0", Offset = "0x1F5BEE0", VA = "0x181F5CCE0")]
	public BJLKOGNGHKA(HGFHAMOOEPL GIICFIPJIBI, GGJDABNIJEB DJCAKEOBKML, PEKDFCFCENH LHCMKIAHBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x1F5CA90", Offset = "0x1F5BC90", VA = "0x181F5CA90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PBCFHHBGAKL))]
	public Task<CKEACEFIEED> IOAMGHHAJNN(long HHIFFPJLPIC, KPDIBFDKKDG OLCOHMCKBID, DIGFFKIMPNG MHPKONNINLP, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x1F5C750", Offset = "0x1F5B950", VA = "0x181F5C750")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EEMFLOJGNGN))]
	private Task HEPCMOEDPLM(DIGFFKIMPNG MHPKONNINLP, IEnumerable<PersistenceView> DOMGJDOGIDP, StringBuilder MALPEMPFILB, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x1F5C0F0", Offset = "0x1F5B2F0", VA = "0x181F5C0F0")]
	private CKEACEFIEED GLKBLDKJFMH(long HHIFFPJLPIC, KPDIBFDKKDG OLCOHMCKBID, DIGFFKIMPNG MHPKONNINLP, IEnumerable<PersistenceView> DOMGJDOGIDP, StringBuilder MALPEMPFILB)
	{
		return default(CKEACEFIEED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x1F5C910", Offset = "0x1F5BB10", VA = "0x181F5C910")]
	private PPPFGNOFILG HGBBEAAICOG(long HHIFFPJLPIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x1F5B9D0", Offset = "0x1F5ABD0", VA = "0x181F5B9D0")]
	private void CGEKLFACJLF(PPPFGNOFILG GBOIGNJKANC, StringBuilder MALPEMPFILB, IEnumerable<PersistenceView> DOMGJDOGIDP, in HEGFFDBOKBP MJEJJAGDKCK, KKKOLGLCNNB OGFJAEMFEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x1F5BBE0", Offset = "0x1F5ADE0", VA = "0x181F5BBE0")]
	private void FPONKKHAOAP(PPPFGNOFILG GBOIGNJKANC, StringBuilder MALPEMPFILB, PersistenceView NLBPABLMMCP, ref KKKOLGLCNNB OGFJAEMFEFA, in HEGFFDBOKBP MJEJJAGDKCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal class NNHLNONEOHJ : IDGCAAGDMGH
{
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class KNKDJJDAJJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public HGFHAMOOEPL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public NNHLNONEOHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private KPDIBFDKKDG <roomSaveOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		private BJLKOGNGHKA <serializeLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		private DIGFFKIMPNG <serializeType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		private CKEACEFIEED <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		private CKEACEFIEED <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		private Exception <ex>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		private TaskAwaiter<CKEACEFIEED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public KNKDJJDAJJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x4EE6DC0", Offset = "0x4EE5FC0", VA = "0x184EE6DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400067A")]
	private readonly BIPGMDDBGPD BHKOGCBJNKO;

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x28B6B70", Offset = "0x28B5D70", VA = "0x1828B6B70")]
	public NNHLNONEOHJ(Guid OAOAFDNAJNM, GGGLHECDAMD BFBBPILOBDE, MDHCFBFJDKN LPFOCNKNJLE, BIPGMDDBGPD BHKOGCBJNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x28B68F0", Offset = "0x28B5AF0", VA = "0x1828B68F0", Slot = "6")]
	protected override string BOAIIGCLKOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x28B69D0", Offset = "0x28B5BD0", VA = "0x1828B69D0", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KNKDJJDAJJE))]
	protected override Task JOLJFFAOAGI(HGFHAMOOEPL GIICFIPJIBI, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal struct FPHBCIJMINJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068A")]
	public Dictionary<Guid, List<PFGMEGIJAKE>> FIOINJBNIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400068B")]
	public Dictionary<Guid, List<PFGMEGIJAKE>> FGAHMPBPBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400068C")]
	public Dictionary<Guid, List<PFGMEGIJAKE>> KIELPEIDOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400068D")]
	public List<Guid> OBEDJGNBBKB;

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x1F6A2C0", Offset = "0x1F694C0", VA = "0x181F6A2C0")]
	public static FPHBCIJMINJ MCKGCJAFOEM(KANPCPNLPMN LJKHADFBIKG, JBHFADCJFPJ HJFGMHGIDFB, LPHBDDFNIEM JEMHOAGGDPM)
	{
		return default(FPHBCIJMINJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
public readonly struct POMIFCINIMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000691")]
	public readonly bool JKOGBPFDOEK;

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0xE6A120", Offset = "0xE69320", VA = "0x180E6A120")]
	public POMIFCINIMK(bool NOMCJPLFDGA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000166")]
internal struct JNJIELJGHJP
{
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private sealed class JFCMHJBCKGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public IDGCAAGDMGH operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public LPHBDDFNIEM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public EBKHDKDGJPI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		private JBHFADCJFPJ <state>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		private IDisposable <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private List<(PersistenceView, KHALLJGHNEA)>.Enumerator <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		private (PersistenceView, KHALLJGHNEA) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private PersistenceView <view>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		private HBPPIHOMOHO <postDeserializeParams>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public JFCMHJBCKGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0430", Offset = "0x3ADF630", VA = "0x183AE0430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x1F765A0", Offset = "0x1F757A0", VA = "0x181F765A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JFCMHJBCKGJ))]
	public static Task GNJLBDDANJL(IDGCAAGDMGH BGHGOMFIAIP, LPHBDDFNIEM JFGIPFOFKHL, EBKHDKDGJPI ECBJHNFIHMD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct FFFIGEPGDDF
{
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class HIOENJAFMPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public AsyncTaskMethodBuilder<LPHBDDFNIEM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public NKKIHOOPLKJ.JLLODPBOBLL downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public FFFIGEPGDDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <downloadTimerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private Task<PINPMIPFEPJ<PJPFDBKHDOJ, EAICBCFAACM>> <assetBundleTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		private Task<PINPMIPFEPJ<GKGNJAPPBLB<PPPFGNOFILG>, EAICBCFAACM>> <subRoomTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		private Task<PINPMIPFEPJ<GKGNJAPPBLB<EHKJGJHNGOB>, EAICBCFAACM>> <superRoomTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		private Task<PINPMIPFEPJ<GKGNJAPPBLB<IBHFMJGAMEO>, EAICBCFAACM>> <playerSaveTask>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private Task<(PINPMIPFEPJ<PJPFDBKHDOJ, EAICBCFAACM>, PINPMIPFEPJ<GKGNJAPPBLB<PPPFGNOFILG>, EAICBCFAACM>, PINPMIPFEPJ<GKGNJAPPBLB<EHKJGJHNGOB>, EAICBCFAACM>, PINPMIPFEPJ<GKGNJAPPBLB<IBHFMJGAMEO>, EAICBCFAACM>)> <allTasks>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private PINPMIPFEPJ<PJPFDBKHDOJ, EAICBCFAACM> <assetBundleSource>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private PINPMIPFEPJ<GKGNJAPPBLB<PPPFGNOFILG>, EAICBCFAACM> <subRoomDataRes>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private PINPMIPFEPJ<GKGNJAPPBLB<EHKJGJHNGOB>, EAICBCFAACM> <superRoomDataRes>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private PINPMIPFEPJ<GKGNJAPPBLB<IBHFMJGAMEO>, EAICBCFAACM> <playerSaveDataRes>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private GKGNJAPPBLB<PPPFGNOFILG> <room>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private (PINPMIPFEPJ<PJPFDBKHDOJ, EAICBCFAACM>, PINPMIPFEPJ<GKGNJAPPBLB<PPPFGNOFILG>, EAICBCFAACM>, PINPMIPFEPJ<GKGNJAPPBLB<EHKJGJHNGOB>, EAICBCFAACM>, PINPMIPFEPJ<GKGNJAPPBLB<IBHFMJGAMEO>, EAICBCFAACM>) <>s__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private (PINPMIPFEPJ<PJPFDBKHDOJ, EAICBCFAACM>, PINPMIPFEPJ<GKGNJAPPBLB<PPPFGNOFILG>, EAICBCFAACM>, PINPMIPFEPJ<GKGNJAPPBLB<EHKJGJHNGOB>, EAICBCFAACM>, PINPMIPFEPJ<GKGNJAPPBLB<IBHFMJGAMEO>, EAICBCFAACM>) <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private TaskAwaiter<(PINPMIPFEPJ<PJPFDBKHDOJ, EAICBCFAACM>, PINPMIPFEPJ<GKGNJAPPBLB<PPPFGNOFILG>, EAICBCFAACM>, PINPMIPFEPJ<GKGNJAPPBLB<EHKJGJHNGOB>, EAICBCFAACM>, PINPMIPFEPJ<GKGNJAPPBLB<IBHFMJGAMEO>, EAICBCFAACM>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public HIOENJAFMPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x3E53DC0", Offset = "0x3E52FC0", VA = "0x183E53DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class AAPOJCNNAAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<PJPFDBKHDOJ, EAICBCFAACM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public NKKIHOOPLKJ.JLLODPBOBLL downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public FFFIGEPGDDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		private PINPMIPFEPJ<PJPFDBKHDOJ, EAICBCFAACM> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		private TaskAwaiter<PINPMIPFEPJ<PJPFDBKHDOJ, EAICBCFAACM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public AAPOJCNNAAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x3E47650", Offset = "0x3E46850", VA = "0x183E47650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006A0")]
	private ICBEPNJEOJD<PEFGNKCLLMB, EHKJGJHNGOB> CIJKHCGNMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006A1")]
	private ICBEPNJEOJD<PEFGNKCLLMB, PPPFGNOFILG> HHGKLHCMACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006A2")]
	private ICBEPNJEOJD<long, IBHFMJGAMEO> JLPOPAGHKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006A3")]
	private HHLEGOLKPOO BEFNGABBCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006A4")]
	private JICMMHOABAL NDCGCFMCEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006A5")]
	private NKFEOLDLFPD IKJABKAGDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006A6")]
	private string JHFBHDCCEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006A7")]
	private PEFGNKCLLMB GPHICPODLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006A8")]
	private PEFGNKCLLMB DBPEJIKLAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006A9")]
	private long FNJOKPDAGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006AA")]
	private GAKPIOFBDII<string>.JOKPHMHCDCF ENNBBCEBKAC;

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x1F69950", Offset = "0x1F68B50", VA = "0x181F69950")]
	public static Task<LPHBDDFNIEM> EANABNFMFAF(GGGLHECDAMD BFBBPILOBDE, in LLFMDKPFMOB JFGIPFOFKHL, NKKIHOOPLKJ.JLLODPBOBLL NNLODNNNDLH, GAKPIOFBDII<string>.JOKPHMHCDCF ENNBBCEBKAC, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x1F69EE0", Offset = "0x1F690E0", VA = "0x181F69EE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HIOENJAFMPJ))]
	private Task<LPHBDDFNIEM> GNJLBDDANJL(NKKIHOOPLKJ.JLLODPBOBLL NNLODNNNDLH, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x1F69CB0", Offset = "0x1F68EB0", VA = "0x181F69CB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AAPOJCNNAAL))]
	private Task<PINPMIPFEPJ<PJPFDBKHDOJ, EAICBCFAACM>> GEEMGBOJHLE(string JHFBHDCCEFE, long FNJOKPDAGJN, NKKIHOOPLKJ.JLLODPBOBLL NNLODNNNDLH, GAKPIOFBDII<string>.JOKPHMHCDCF NICFPLMAKBE, CancellationToken MELLLMEKJLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
public class KPKLBEKJJDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	private readonly GLPGJNOOMAG HBKEDJLNDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CC")]
	private string BFJDLBFNIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006CD")]
	private long? MDEIJOEIFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	private long? OLJADLLBDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	private long? AFCMNOGGHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40006D0")]
	private string DDABCOGMGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006D1")]
	private JBHFADCJFPJ GIFGAMLPDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006D2")]
	private long? JNONBKDDCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006D3")]
	private bool MFLNHGPCBAN;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public string IEMJEJIHFBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public long DGBPEPBIAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x28AC4E0", Offset = "0x28AB6E0", VA = "0x1828AC4E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public long FBCNGHPILGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x28AC100", Offset = "0x28AB300", VA = "0x1828AC100")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public long OAFCMNBADKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x28AC540", Offset = "0x28AB740", VA = "0x1828AC540")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public string ANPDHDMAMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x28AC0C0", Offset = "0x28AB2C0", VA = "0x1828AC0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public JBHFADCJFPJ NFNNEIGBIDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0xB647A0", Offset = "0xB639A0", VA = "0x180B647A0")]
		get
		{
			return default(JBHFADCJFPJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x28AC6C0", Offset = "0x28AB8C0", VA = "0x1828AC6C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public long GHCALPCMHLH
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x28AC9B0", Offset = "0x28ABBB0", VA = "0x1828AC9B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x28ACA10", Offset = "0x28ABC10", VA = "0x1828ACA10")]
	[UnityEngine.Scripting.Preserve]
	public KPKLBEKJJDL([NDGONEEEGIA(null)] GLPGJNOOMAG HBKEDJLNDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x28AC7A0", Offset = "0x28AB9A0", VA = "0x1828AC7A0")]
	private void OOJDFFLJAHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x28ABC70", Offset = "0x28AAE70", VA = "0x1828ABC70")]
	public void APBJBAGPEHJ(long HBFBDJIOFCF, long HHIFFPJLPIC, [Optional] long? FNJOKPDAGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x28AC5A0", Offset = "0x28AB7A0", VA = "0x1828AC5A0")]
	public void JIINBIGIABK(long FNJOKPDAGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x28AC640", Offset = "0x28AB840", VA = "0x1828AC640")]
	public void JOONPNFEHOK(string MNLEELJBGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x28AC160", Offset = "0x28AB360", VA = "0x1828AC160")]
	public void GBNEDDIEHAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
internal sealed class NOBGNHCOPKP : IDGCAAGDMGH
{
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class KALLHNHMCNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public KALLHNHMCNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x4EE6C50", Offset = "0x4EE5E50", VA = "0x184EE6C50")]
		internal object EAOJLJMDMMC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private sealed class LHPOONDEECN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		public HGFHAMOOEPL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public NOBGNHCOPKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		private EDKAOGBNBOB <presence>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		private GFDEABGKDAE <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public LHPOONDEECN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7CA0", Offset = "0x4EE6EA0", VA = "0x184EE7CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private sealed class IDMLLBNAKNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		public NOBGNHCOPKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private byte <omSaveVersion>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x42")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		private bool <omIsEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x43")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		private byte <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		private TaskAwaiter<byte> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public IDMLLBNAKNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x4EE54F0", Offset = "0x4EE46F0", VA = "0x184EE54F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private sealed class PDNNKMLJFMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		public NOBGNHCOPKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		private NAFOEDAKNOD <loadInfo>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		private FNMBADLGNPC <subRoomSaveData>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		private FNMBADLGNPC <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		private TaskAwaiter<FNMBADLGNPC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public PDNNKMLJFMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x4EEA4D0", Offset = "0x4EE96D0", VA = "0x184EEA4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class GDOEGCFEEEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public EDKAOGBNBOB presence;

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public GDOEGCFEEEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x4EE3F40", Offset = "0x4EE3140", VA = "0x184EE3F40")]
		internal object FEGOKMGFGKK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006D4")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	private static readonly PEKDFCFCENH BMDAAMBKBID;

	[Cpp2IlInjected.Token(Token = "0x40006D6")]
	private static readonly PEKDFCFCENH HMFKDAPADAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	private readonly NAFOEDAKNOD LMDLDLEHDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	private readonly KDLCCGABAHG AJNCKFOALHG;

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x28B7370", Offset = "0x28B6570", VA = "0x1828B7370")]
	public NOBGNHCOPKP(NAFOEDAKNOD LMDLDLEHDDN, KDLCCGABAHG AJNCKFOALHG, Guid OAOAFDNAJNM, GGGLHECDAMD BFBBPILOBDE, MDHCFBFJDKN LPFOCNKNJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x28B6E00", Offset = "0x28B6000", VA = "0x1828B6E00", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LHPOONDEECN))]
	protected override Task JOLJFFAOAGI(HGFHAMOOEPL GIICFIPJIBI, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x28B6FA0", Offset = "0x28B61A0", VA = "0x1828B6FA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IDMLLBNAKNI))]
	protected Task LOAPFNKGENF(CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x28B70F0", Offset = "0x28B62F0", VA = "0x1828B70F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PDNNKMLJFMK))]
	private Task<byte> OOAJPLGBHMD(CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x28B6C10", Offset = "0x28B5E10", VA = "0x1828B6C10")]
	private EDKAOGBNBOB FHMDOFFNFHD()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000172")]
internal struct FIOAJKHKGMD
{
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private sealed class GELCPFOAKMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public GGGLHECDAMD roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public LPHBDDFNIEM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		private bool <isMaster>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public GELCPFOAKMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x3E520A0", Offset = "0x3E512A0", VA = "0x183E520A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x1F6A0B0", Offset = "0x1F692B0", VA = "0x181F6A0B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GELCPFOAKMA))]
	public static Task GNJLBDDANJL(GGGLHECDAMD BFBBPILOBDE, LPHBDDFNIEM JFGIPFOFKHL, CancellationToken MELLLMEKJLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
internal struct EBBMPBPKKBP
{
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class COAILGDHGJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public EBBMPBPKKBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		private HNCOHELHGEO <sceneLocation>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		private string <sceneName>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		private Scene <mainScene>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		private Scene <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public COAILGDHGJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x3E4A770", Offset = "0x3E49970", VA = "0x183E4A770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private sealed class IEELANGHIBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public IEELANGHIBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x3E54D50", Offset = "0x3E53F50", VA = "0x183E54D50")]
		internal object PGJJMFBLHPF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class CPDJCAIJEEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		public EBBMPBPKKBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		private IEELANGHIBA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		private IKFHCCEPJHL <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		private Scene <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public CPDJCAIJEEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x3E4B180", Offset = "0x3E4A380", VA = "0x183E4B180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006FD")]
	private HNCOHELHGEO ADDBKKBKOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006FE")]
	private GAKPIOFBDII<string>.JOKPHMHCDCF ENNBBCEBKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006FF")]
	private GGGLHECDAMD BFBBPILOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000700")]
	private bool CCNODJGIONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000701")]
	private LPHBDDFNIEM JFGIPFOFKHL;

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x1F67460", Offset = "0x1F66660", VA = "0x181F67460")]
	public static Task<Scene> FCIPCGNEJDL(GGGLHECDAMD BFBBPILOBDE, HNCOHELHGEO NOMLINEALCE, GAKPIOFBDII<string>.JOKPHMHCDCF ENNBBCEBKAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x1F677C0", Offset = "0x1F669C0", VA = "0x181F677C0")]
	public static Task<Scene> KJEJEEHNCFL(GGGLHECDAMD BFBBPILOBDE, LPHBDDFNIEM JFGIPFOFKHL, GAKPIOFBDII<string>.JOKPHMHCDCF ENNBBCEBKAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x1F67660", Offset = "0x1F66860", VA = "0x181F67660")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(COAILGDHGJE))]
	private Task<Scene> GNJLBDDANJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x1F67430", Offset = "0x1F66630", VA = "0x181F67430")]
	private bool DJPIONECEAO(LPHBDDFNIEM JFGIPFOFKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x1F67860", Offset = "0x1F66A60", VA = "0x181F67860")]
	private void LECHJCJDOEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x1F674E0", Offset = "0x1F666E0", VA = "0x181F674E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CPDJCAIJEEA))]
	private Task<Scene> GKLMHOHLGEP(string NIMNFAHNKAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
public abstract class MFCBMKNKACL<T> where T : MFCBMKNKACL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000715")]
	internal readonly GGGLHECDAMD HJDNPKKKIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000716")]
	private int? FEGILJEMKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000717")]
	protected readonly Guid KFFEAPGHNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000718")]
	protected readonly COPCGKNOMKI AIHGKMHOMOM;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	protected T MIPAEHHILMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9E60", Offset = "0x2AF9060", VA = "0x182AF9E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA0B0", Offset = "0x2AF92B0", VA = "0x182AFA0B0")]
	internal MFCBMKNKACL(GGGLHECDAMD BNMDMGJNLBC, COPCGKNOMKI ENJDJKNAHAK, [Optional] Guid? OAOAFDNAJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9EC0", Offset = "0x2AF90C0", VA = "0x182AF9EC0")]
	private GBOAMHGCLHL LKBOLBEKKAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "4")]
	protected virtual void CKAGCICFPPN(GBOAMHGCLHL JPOEHOENKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9D00", Offset = "0x2AF8F00", VA = "0x182AF9D00")]
	public T BEJDHEFFAGG(CPCMBHAGMBL BJENOGCANAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9DE0", Offset = "0x2AF8FE0", VA = "0x182AF9DE0")]
	public T FACJDAHNKOL(int BCKCGGDPOIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9FB0", Offset = "0x2AF91B0", VA = "0x182AF9FB0", Slot = "5")]
	public virtual Task<FGEDLIOJPHD> MBPEGDLANCP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
public class AFJGHJAKFME : MFCBMKNKACL<AFJGHJAKFME>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000719")]
	private NAFOEDAKNOD GJNKBDPFGGF;

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x1F56490", Offset = "0x1F55690", VA = "0x181F56490")]
	internal AFJGHJAKFME(GGGLHECDAMD BNMDMGJNLBC, COPCGKNOMKI ENJDJKNAHAK, [Optional] Guid? OAOAFDNAJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0x1F563A0", Offset = "0x1F555A0", VA = "0x181F563A0")]
	public AFJGHJAKFME BJJKEHJHCNB(NAFOEDAKNOD GJNKBDPFGGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x1F563C0", Offset = "0x1F555C0", VA = "0x181F563C0", Slot = "4")]
	protected override void CKAGCICFPPN(GBOAMHGCLHL JPOEHOENKPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
public class OKKGMBNHAPB : MFCBMKNKACL<OKKGMBNHAPB>
{
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	internal enum BLNLNCFKDPD
	{
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		RecNet
	}

	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private sealed class LOOHJFAPHAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		public AsyncTaskMethodBuilder<FGEDLIOJPHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		public OKKGMBNHAPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		private FGEDLIOJPHD <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		private TaskAwaiter<FGEDLIOJPHD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public LOOHJFAPHAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x4EE8360", Offset = "0x4EE7560", VA = "0x184EE8360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400071A")]
	private BLNLNCFKDPD EHDHLHLALPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400071B")]
	private string NOCKDNFFNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400071C")]
	private FFHPOMEPNOI GJNKBDPFGGF;

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x28BA000", Offset = "0x28B9200", VA = "0x1828BA000")]
	internal OKKGMBNHAPB(GGGLHECDAMD BNMDMGJNLBC, COPCGKNOMKI ENJDJKNAHAK, [Optional] Guid? OAOAFDNAJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x28B9CB0", Offset = "0x28B8EB0", VA = "0x1828B9CB0")]
	public OKKGMBNHAPB CIPFECLAHFC(string HBCOIOANGHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x28B9E50", Offset = "0x28B9050", VA = "0x1828B9E50")]
	public OKKGMBNHAPB DEDCDBGOKIE(bool HKDPHBMEAHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x28B9C80", Offset = "0x28B8E80", VA = "0x1828B9C80")]
	public OKKGMBNHAPB BCCDDPCGIOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x28B9E80", Offset = "0x28B9080", VA = "0x1828B9E80")]
	public OKKGMBNHAPB HJKGJPCBAGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x28B9CE0", Offset = "0x28B8EE0", VA = "0x1828B9CE0", Slot = "4")]
	protected override void CKAGCICFPPN(GBOAMHGCLHL JPOEHOENKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x28B9EB0", Offset = "0x28B90B0", VA = "0x1828B9EB0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LOOHJFAPHAN))]
	public override Task<FGEDLIOJPHD> MBPEGDLANCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x28B9C40", Offset = "0x28B8E40", VA = "0x1828B9C40")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<FGEDLIOJPHD> AOOLGGAOGOE()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal struct OIKKBGHHBBF
{
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private sealed class AIEMFNLDKNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		public GNBNNEBCBLF.EKNHFFBFEID instantiations;

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public AIEMFNLDKNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x4EE2740", Offset = "0x4EE1940", VA = "0x184EE2740")]
		internal object HPLINGMNNLM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class OBINFMKIPIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public OBINFMKIPIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x4EE97A0", Offset = "0x4EE89A0", VA = "0x184EE97A0")]
		internal object LHNDDELBFHF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x28B8D90", Offset = "0x28B7F90", VA = "0x1828B8D90")]
	public static void GNJLBDDANJL(IDGCAAGDMGH BGHGOMFIAIP, LPHBDDFNIEM JFGIPFOFKHL, GNBNNEBCBLF.EKNHFFBFEID GBKEEACBDGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal struct GNBNNEBCBLF
{
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	public struct EKNHFFBFEID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		public List<EDCKJMEPEHF> EMNLDBCHFAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		public List<KHALLJGHNEA> PKIKIMMGNIG;

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x949BA0", Offset = "0x948DA0", VA = "0x180949BA0")]
		public EKNHFFBFEID(List<EDCKJMEPEHF> EMNLDBCHFAI, List<KHALLJGHNEA> PKIKIMMGNIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class BLGCIDJECFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		public IEnumerable<EDCKJMEPEHF> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public BLGCIDJECFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8270", Offset = "0x3AD7470", VA = "0x183AD8270")]
		internal object AHHINDDFAKN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400072A")]
	private GGGLHECDAMD BFBBPILOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400072B")]
	private LPHBDDFNIEM JFGIPFOFKHL;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private KANPCPNLPMN JOECKGCKOMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x1F6EBD0", Offset = "0x1F6DDD0", VA = "0x181F6EBD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EB60", Offset = "0x1F6DD60", VA = "0x181F6EB60")]
	public static EKNHFFBFEID GNJLBDDANJL(GGGLHECDAMD BFBBPILOBDE, LPHBDDFNIEM JFGIPFOFKHL)
	{
		return default(EKNHFFBFEID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x1F6E8C0", Offset = "0x1F6DAC0", VA = "0x181F6E8C0")]
	private EKNHFFBFEID GNJLBDDANJL()
	{
		return default(EKNHFFBFEID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EC20", Offset = "0x1F6DE20", VA = "0x181F6EC20")]
	private EKNHFFBFEID OICKEHFMNCJ(PPPFGNOFILG MHCMHOAOIOG, NIFCDPEEFKO JDAOGOKKDKO)
	{
		return default(EKNHFFBFEID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x1F6E6E0", Offset = "0x1F6D8E0", VA = "0x181F6E6E0")]
	private bool GGKMGCBFNHO(IEnumerable<EDCKJMEPEHF> EMNLDBCHFAI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal struct FDCEBKJBAIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private sealed class HODJILGMPPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		public FDCEBKJBAIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		private bool <stopOnEmptyScene>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		private string <preloadSceneName>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		private GAKPIOFBDII<string>.JOKPHMHCDCF <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public HODJILGMPPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x3E547D0", Offset = "0x3E539D0", VA = "0x183E547D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private sealed class PPFHMMBECDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public PPFHMMBECDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x3E5A040", Offset = "0x3E59240", VA = "0x183E5A040")]
		internal object PGJJMFBLHPF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private sealed class BLBDDHFOOAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		public FDCEBKJBAIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		private PPFHMMBECDH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		private IKFHCCEPJHL <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public BLBDDHFOOAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x3E48170", Offset = "0x3E47370", VA = "0x183E48170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400072F")]
	private bool AJIDLGOMKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000730")]
	private GAKPIOFBDII<string>.JOKPHMHCDCF ENNBBCEBKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000731")]
	private GGGLHECDAMD BFBBPILOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000732")]
	private CancellationToken MELLLMEKJLC;

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x1F698E0", Offset = "0x1F68AE0", VA = "0x181F698E0")]
	public static Task LLHDGJJKOKA(GGGLHECDAMD BFBBPILOBDE, bool AJIDLGOMKPJ, GAKPIOFBDII<string>.JOKPHMHCDCF ENNBBCEBKAC, CancellationToken HBJKEFJEIIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x1F697B0", Offset = "0x1F689B0", VA = "0x181F697B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HODJILGMPPE))]
	private Task GNJLBDDANJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x1F69640", Offset = "0x1F68840", VA = "0x181F69640")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BLBDDHFOOAJ))]
	private Task GKLMHOHLGEP(bool JCBICPFAOBN, string NIMNFAHNKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x929790", Offset = "0x928990", VA = "0x180929790")]
	private bool MAOFOAHACLH(bool AJIDLGOMKPJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal struct LLFMDKPFMOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000747")]
	public readonly JICMMHOABAL NDCGCFMCEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000748")]
	public readonly NKFEOLDLFPD IKJABKAGDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000749")]
	public readonly string JHFBHDCCEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400074A")]
	public readonly PEFGNKCLLMB GPHICPODLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400074B")]
	public readonly PEFGNKCLLMB DBPEJIKLAFB;

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x28AD6F0", Offset = "0x28AC8F0", VA = "0x1828AD6F0")]
	public LLFMDKPFMOB(JICMMHOABAL NDCGCFMCEHC, NKFEOLDLFPD IKJABKAGDPF, string JHFBHDCCEFE, PEFGNKCLLMB GPHICPODLBN, PEFGNKCLLMB DBPEJIKLAFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
internal sealed class LHMHCLGPKDK : IJILLHGDBDN
{
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private sealed class AGMFMEOPGCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		public HGFHAMOOEPL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		public LHMHCLGPKDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		private CONHHIMJCNJ <roomEvent>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		private GFDEABGKDAE <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public AGMFMEOPGCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6050", Offset = "0x3AD5250", VA = "0x183AD6050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400074C")]
	private readonly NAFOEDAKNOD DCLPBGIIBLO;

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x28AD640", Offset = "0x28AC840", VA = "0x1828AD640")]
	public LHMHCLGPKDK(Guid OAOAFDNAJNM, GGGLHECDAMD BFBBPILOBDE, NAFOEDAKNOD DCLPBGIIBLO, MDHCFBFJDKN LPFOCNKNJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x28AD4A0", Offset = "0x28AC6A0", VA = "0x1828AD4A0", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AGMFMEOPGCC))]
	protected override Task NJNHPFHMJNI(HGFHAMOOEPL GIICFIPJIBI, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200018A")]
internal struct FPCDFGIBONA
{
	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x1F6A220", Offset = "0x1F69420", VA = "0x181F6A220")]
	public static Task GNJLBDDANJL(CancellationToken MELLLMEKJLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal struct NDMKJFODPDB
{
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class DCFPIIEGCLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		public GGGLHECDAMD roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		public LPHBDDFNIEM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		public HGFHAMOOEPL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		private bool <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public DCFPIIEGCLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x4EE3360", Offset = "0x4EE2560", VA = "0x184EE3360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private sealed class LBEMFBAPBLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		public NDMKJFODPDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		private bool <shouldObjectModelBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		private bool <isOMFlagChanging>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6A")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		private bool <reloadSceneForObjectModel>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public LBEMFBAPBLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7730", Offset = "0x4EE6930", VA = "0x184EE7730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000756")]
	private GGGLHECDAMD BFBBPILOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000757")]
	private LPHBDDFNIEM JFGIPFOFKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000758")]
	private ByteString IJMEBENKHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000759")]
	private HGFHAMOOEPL GIICFIPJIBI;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private KANPCPNLPMN JOECKGCKOMK
	{
		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x28B5350", Offset = "0x28B4550", VA = "0x1828B5350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool GFMEBDHKKFK
	{
		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x28B4DE0", Offset = "0x28B3FE0", VA = "0x1828B4DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private bool KOLJHIPPCMM
	{
		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x28B51F0", Offset = "0x28B43F0", VA = "0x1828B51F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x28B4E60", Offset = "0x28B4060", VA = "0x1828B4E60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DCFPIIEGCLC))]
	public static Task<bool> GNJLBDDANJL(GGGLHECDAMD BFBBPILOBDE, LPHBDDFNIEM JFGIPFOFKHL, HGFHAMOOEPL GIICFIPJIBI, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x28B5050", Offset = "0x28B4250", VA = "0x1828B5050")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LBEMFBAPBLB))]
	private Task<bool> GNJLBDDANJL(GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
public static class KGNOFKAOOMI
{
	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x28AA770", Offset = "0x28A9970", VA = "0x1828AA770")]
	public static PEFGNKCLLMB HOLDFNMPOHL(this HHPHDPKPHJA GOPMEDINKMO)
	{
		return default(PEFGNKCLLMB);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x28AA6B0", Offset = "0x28A98B0", VA = "0x1828AA6B0")]
	public static HHPHDPKPHJA ADBOLOFCGBE(this PEFGNKCLLMB GJNKOFOHHHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
internal class AOJOEBHKBAP : IOAACHJKDOE
{
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private sealed class GIDEFELNFBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		public BCMPMDCFMDJ.GJOFGLCEHLH roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public GIDEFELNFBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x28A7180", Offset = "0x28A6380", VA = "0x1828A7180")]
		internal object PFPDOBIFHHO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private sealed class IPEAMIOOABN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		public AsyncTaskMethodBuilder<(BCMPMDCFMDJ.GJOFGLCEHLH roomDataUpload, BCMPMDCFMDJ.GJOFGLCEHLH subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		public CKEACEFIEED roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		public AOJOEBHKBAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		private GIDEFELNFBC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		private EHKJGJHNGOB <roomMetadata>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400077B")]
		private BCMPMDCFMDJ.GJOFGLCEHLH <subRoomDataUpload>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		private BCMPMDCFMDJ.GJOFGLCEHLH <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		private BCMPMDCFMDJ.GJOFGLCEHLH <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		private TaskAwaiter<BCMPMDCFMDJ.GJOFGLCEHLH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public IPEAMIOOABN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x28A7F30", Offset = "0x28A7130", VA = "0x1828A7F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private sealed class ECBLDLKDJJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public AsyncTaskMethodBuilder<ONNIIAMENKC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		public FFHPOMEPNOI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		public CKEACEFIEED roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		public AOJOEBHKBAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		private BCMPMDCFMDJ.GJOFGLCEHLH <roomDataUpload>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		private BCMPMDCFMDJ.GJOFGLCEHLH <subRoomDataUpload>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		private int <persistenceVersion>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		private bool <objectModelEnabledInSave>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x85")]
		[Cpp2IlInjected.Token(Token = "0x400078C")]
		private byte <omVersion>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400078D")]
		private JNGJJPMAKAH <request>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		private ONNIIAMENKC <response>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		private (BCMPMDCFMDJ.GJOFGLCEHLH roomDataUpload, BCMPMDCFMDJ.GJOFGLCEHLH subRoomDataUpload) <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		private (BCMPMDCFMDJ.GJOFGLCEHLH roomDataUpload, BCMPMDCFMDJ.GJOFGLCEHLH subRoomDataUpload) <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		private ONNIIAMENKC <>s__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		private TaskAwaiter<(BCMPMDCFMDJ.GJOFGLCEHLH roomDataUpload, BCMPMDCFMDJ.GJOFGLCEHLH subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		private TaskAwaiter<ONNIIAMENKC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public ECBLDLKDJJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x28A3990", Offset = "0x28A2B90", VA = "0x1828A3990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private sealed class NNBDAAKGPMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		public AsyncTaskMethodBuilder<CHACCCFMNKN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public CKEACEFIEED roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		public AOJOEBHKBAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400079C")]
		private BCMPMDCFMDJ.GJOFGLCEHLH <roomDataUpload>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400079D")]
		private BCMPMDCFMDJ.GJOFGLCEHLH <subRoomDataUpload>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400079E")]
		private CHACCCFMNKN <remoteRunDetails>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400079F")]
		private (BCMPMDCFMDJ.GJOFGLCEHLH roomDataUpload, BCMPMDCFMDJ.GJOFGLCEHLH subRoomDataUpload) <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007A0")]
		private (BCMPMDCFMDJ.GJOFGLCEHLH roomDataUpload, BCMPMDCFMDJ.GJOFGLCEHLH subRoomDataUpload) <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40007A1")]
		private CHACCCFMNKN <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40007A2")]
		private TaskAwaiter<(BCMPMDCFMDJ.GJOFGLCEHLH roomDataUpload, BCMPMDCFMDJ.GJOFGLCEHLH subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40007A3")]
		private TaskAwaiter<CHACCCFMNKN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public NNBDAAKGPMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x28B63D0", Offset = "0x28B55D0", VA = "0x1828B63D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private sealed class IIGFJJHMHGH
	{
		[Cpp2IlInjected.Token(Token = "0x2000195")]
		private sealed class <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007AC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007AD")]
			public AsyncTaskMethodBuilder<GBOAMHGCLHL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007AE")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007AF")]
			public IIGFJJHMHGH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007B0")]
			private GBOAMHGCLHL <reloadMessage>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007B1")]
			private RepeatedField<KHALLJGHNEA> <persistenceViewsOpt>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007B2")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x682D30", Offset = "0x682130")]
			private IEnumerable<KHALLJGHNEA> <persistenceViews>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007B3")]
			private bool <couldSaveLocalRoomData>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
			[Cpp2IlInjected.Token(Token = "0x40007B4")]
			private bool <>s__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007B5")]
			private CHACCCFMNKN <remoteRunDetails>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007B6")]
			private CHACCCFMNKN <>s__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40007B7")]
			private ONNIIAMENKC <saveDetails>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007B8")]
			private ONNIIAMENKC <>s__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007B9")]
			private GBOAMHGCLHL <>s__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007BA")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40007BB")]
			private TaskAwaiter<CHACCCFMNKN> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40007BC")]
			private TaskAwaiter<ONNIIAMENKC> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40007BD")]
			private TaskAwaiter<GBOAMHGCLHL> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006CC")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public <<UploadRoomDataBlobAndSyncReload>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CD")]
			[Cpp2IlInjected.Address(RVA = "0x4EED960", Offset = "0x4EECB60", VA = "0x184EED960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CE")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007A4")]
		public AOJOEBHKBAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		public CKEACEFIEED roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		public FFHPOMEPNOI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		public POMIFCINIMK roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x682C70", Offset = "0x682070")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public IIGFJJHMHGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x28A7D60", Offset = "0x28A6F60", VA = "0x1828A7D60")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<GBOAMHGCLHL> GHBDBGPJGGD(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private sealed class CMHPOJCDCBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		public AsyncTaskMethodBuilder<GBOAMHGCLHL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007C0")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		public FFHPOMEPNOI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007C2")]
		public CKEACEFIEED roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007C3")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007C4")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007C5")]
		public POMIFCINIMK roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007C6")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x682D90", Offset = "0x682190")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007C8")]
		public AOJOEBHKBAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007C9")]
		private IIGFJJHMHGH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007CA")]
		private GBOAMHGCLHL <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007CB")]
		private TaskAwaiter<GBOAMHGCLHL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public CMHPOJCDCBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x28A2810", Offset = "0x28A1A10", VA = "0x1828A2810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400076D")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x400076E")]
	private static readonly PEKDFCFCENH BMDAAMBKBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400076F")]
	private readonly FJEGMDKGNDL GHPEHPHOMJO;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private GGGLHECDAMD HGLNLGDLOOE
	{
		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x1F5A230", Offset = "0x1F59430", VA = "0x181F5A230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x1F5A970", Offset = "0x1F59B70", VA = "0x181F5A970")]
	public AOJOEBHKBAP(HGFHAMOOEPL GIICFIPJIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x1F5A070", Offset = "0x1F59270", VA = "0x181F5A070")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IPEAMIOOABN))]
	private Task<(BCMPMDCFMDJ.GJOFGLCEHLH, BCMPMDCFMDJ.GJOFGLCEHLH)> FCCLBCDIFBB(CKEACEFIEED LLJFOILBDJN, long HBFBDJIOFCF, long BGOPDGBJMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x1F5A260", Offset = "0x1F59460", VA = "0x181F5A260")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ECBLDLKDJJA))]
	public Task<ONNIIAMENKC> JOMKNAFEKNH(int GFNEMFOLLJJ, [CanBeNull] FFHPOMEPNOI FGKEDIKBDOG, CKEACEFIEED LLJFOILBDJN, long HBFBDJIOFCF, long BGOPDGBJMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x1F5A450", Offset = "0x1F59650", VA = "0x181F5A450")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NNBDAAKGPMG))]
	private Task<CHACCCFMNKN> LNIGCFLBBKG(string LBNNLDOBOIC, int GFNEMFOLLJJ, CKEACEFIEED LLJFOILBDJN, long HBFBDJIOFCF, long BGOPDGBJMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x1F5A650", Offset = "0x1F59850", VA = "0x181F5A650")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CMHPOJCDCBM))]
	public Task<GBOAMHGCLHL> OKMIAOEBIHO(int GFNEMFOLLJJ, FFHPOMEPNOI? FGKEDIKBDOG, CKEACEFIEED LLJFOILBDJN, long HBFBDJIOFCF, long BGOPDGBJMDP, POMIFCINIMK HDOBONHEJNA, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000197")]
internal class CKMKEADGNJM : IJILLHGDBDN
{
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class IKHHDCHKKNG
	{
		[Cpp2IlInjected.Token(Token = "0x2000199")]
		private sealed class <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007D8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007D9")]
			public AsyncTaskMethodBuilder<GBOAMHGCLHL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007DA")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007DB")]
			public IKHHDCHKKNG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007DC")]
			private CKEACEFIEED <data>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007DD")]
			private GBOAMHGCLHL <reloadMsg>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007DE")]
			private CKEACEFIEED <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007DF")]
			private GBOAMHGCLHL <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007E0")]
			private TaskAwaiter<CKEACEFIEED> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007E1")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x682F20", Offset = "0x682320")]
			private TaskAwaiter<GBOAMHGCLHL> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006DB")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public <<RunWhilePlayerDespawnedAsync>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006DC")]
			[Cpp2IlInjected.Address(RVA = "0x4EED500", Offset = "0x4EEC700", VA = "0x184EED500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006DD")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		public CKMKEADGNJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		public BJLKOGNGHKA serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		public KPDIBFDKKDG roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		public AOJOEBHKBAP uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		public POMIFCINIMK roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public IKHHDCHKKNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x3E559B0", Offset = "0x3E54BB0", VA = "0x183E559B0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<GBOAMHGCLHL> LAKINNHHBDH(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private sealed class EMGEIOJFPIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007E3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007E4")]
		public HGFHAMOOEPL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007E5")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		public CKMKEADGNJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		private IKHHDCHKKNG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		private CONHHIMJCNJ <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		private FNMBADLGNPC <currentRoomSave>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007EB")]
		private long <loadedSubroomSaveId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007EC")]
		private bool <currentLoadedSaveIsPublished>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007ED")]
		private GFDEABGKDAE <loadLogic>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007EE")]
		private GBOAMHGCLHL <saveReloadMessage>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		private bool <omEnabledChanged>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		private GBOAMHGCLHL <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40007F1")]
		private Exception <ex>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40007F2")]
		private bool <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40007F3")]
		private TaskAwaiter<GBOAMHGCLHL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40007F4")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40007F5")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public EMGEIOJFPIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x28A4970", Offset = "0x28A3B70", VA = "0x1828A4970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private sealed class IMHKAAOAIIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F7")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007F8")]
		public NAFOEDAKNOD loadInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007F9")]
		public GAKPIOFBDII<string>.JOKPHMHCDCF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007FB")]
		public CKMKEADGNJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007FC")]
		private FNMBADLGNPC <subRoomSaveData>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007FD")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x40007FE")]
		private bool <omIsEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x40007FF")]
		private bool <omEnabledChanged>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000800")]
		private FNMBADLGNPC <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000801")]
		private TaskAwaiter<FNMBADLGNPC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000802")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public IMHKAAOAIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x3E55B20", Offset = "0x3E54D20", VA = "0x183E55B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40007CC")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x40007CD")]
	private static readonly PEKDFCFCENH BMDAAMBKBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40007CE")]
	private readonly int GFNEMFOLLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40007CF")]
	[CanBeNull]
	private readonly FFHPOMEPNOI FGKEDIKBDOG;

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x1F5F8E0", Offset = "0x1F5EAE0", VA = "0x181F5F8E0")]
	public CKMKEADGNJM(Guid OAOAFDNAJNM, GGGLHECDAMD BFBBPILOBDE, int GFNEMFOLLJJ, FFHPOMEPNOI FGKEDIKBDOG, MDHCFBFJDKN LPFOCNKNJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x1F5F650", Offset = "0x1F5E850", VA = "0x181F5F650", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EMGEIOJFPIC))]
	protected override Task NJNHPFHMJNI(HGFHAMOOEPL GIICFIPJIBI, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x1F5F220", Offset = "0x1F5E420", VA = "0x181F5F220")]
	private void GPGDPPJKJOM(bool BBOCKGHBLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x1F5F390", Offset = "0x1F5E590", VA = "0x181F5F390")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IMHKAAOAIIH))]
	protected Task<bool> HIGLINKHHEO(NAFOEDAKNOD JGBANDHGKHN, GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x1F5F550", Offset = "0x1F5E750", VA = "0x181F5F550")]
	private void LGBJCDDNPAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x1F5F080", Offset = "0x1F5E280", VA = "0x181F5F080")]
	private void ANMBMDPNIBI(GAKPIOFBDII<string>.JOKPHMHCDCF MICDBODMMOD, CONHHIMJCNJ GEMCJBEAJOK)
	{
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200019D")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000806")]
			public HHGOHIFFOJI ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000807")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000808")]
			public HHGOHIFFOJI HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000809")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400080A")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400080B")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60006EA")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000803")]
		private static HHGOHIFFOJI[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000804")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000805")]
		private Dictionary<HHGOHIFFOJI, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x28BAF30", Offset = "0x28BA130", VA = "0x1828BAF30")]
		public bool IDFBHLLBDID(HHGOHIFFOJI HMDLBGKACJD, out ResultConfig EDIJJHKDDAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x28BAFA0", Offset = "0x28BA1A0", VA = "0x1828BAFA0")]
		public ResultConfig NHPPINMFOAB(HHGOHIFFOJI ACIPMAPBAPJ, [Optional] HashSet<HHGOHIFFOJI> PHKBFHPOMGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x28BB620", Offset = "0x28BA820", VA = "0x1828BB620", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x28BB0B0", Offset = "0x28BA2B0", VA = "0x1828BB0B0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x99A150", Offset = "0x999350", VA = "0x18099A150")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
public class MABENKHHNIG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x28ADFF0", Offset = "0x28AD1F0", VA = "0x1828ADFF0")]
	public MABENKHHNIG(string JPOEHOENKPI, Exception PMCFOCCCIAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public class NBDAGJMLNIJ
{
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	private sealed class BPIICFEKOOL : LJIHKCFIOKG, IEquatable<LJIHKCFIOKG>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A2")]
		[CompilerGenerated]
		private sealed class MIDFJJLGCPD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000818")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000819")]
			public AsyncTaskMethodBuilder<FGEDLIOJPHD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400081A")]
			public BPIICFEKOOL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400081B")]
			private MFJKEMECNGI <roomManager>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400081C")]
			private JICMMHOABAL <newRoomDetails>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400081D")]
			private NAFOEDAKNOD <roomLoadRequestPayload>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400081E")]
			private JICMMHOABAL <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400081F")]
			private FGEDLIOJPHD <>s__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000820")]
			private TaskAwaiter<JICMMHOABAL> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000821")]
			private TaskAwaiter<FGEDLIOJPHD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000702")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public MIDFJJLGCPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000703")]
			[Cpp2IlInjected.Address(RVA = "0x4EE86D0", Offset = "0x4EE78D0", VA = "0x184EE86D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000815")]
		private readonly FNMBADLGNPC ADJGMKHKAJD;

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public int FLEHEPEPNBI
		{
			[Cpp2IlInjected.Token(Token = "0x60006F6")]
			[Cpp2IlInjected.Address(RVA = "0x8C8C20", Offset = "0x8C7E20", VA = "0x1808C8C20", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public IBKPBJLCJKH JLAJBJAEGCF
		{
			[Cpp2IlInjected.Token(Token = "0x60006F7")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		private DateTime OINEMKNDANM
		{
			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0x185A640", Offset = "0x1859840", VA = "0x18185A640", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public KNEAFEIOKGC? BGDOBMNCGIP
		{
			[Cpp2IlInjected.Token(Token = "0x60006F9")]
			[Cpp2IlInjected.Address(RVA = "0xC7AA90", Offset = "0xC79C90", VA = "0x180C7AA90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public AGHBNDCEFAH? GAGINJBEKPD
		{
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0x2BDD260", Offset = "0x2BDC460", VA = "0x182BDD260", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public GKNPIECJEKA DCPAMCANDKG
		{
			[Cpp2IlInjected.Token(Token = "0x60006FD")]
			[Cpp2IlInjected.Address(RVA = "0x890110", Offset = "0x88F310", VA = "0x180890110", Slot = "10")]
			get
			{
				return default(GKNPIECJEKA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x4EE2FE0", Offset = "0x4EE21E0", VA = "0x184EE2FE0", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(MIDFJJLGCPD))]
		public Task<FGEDLIOJPHD> CBGLKADHECF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x4EE3300", Offset = "0x4EE2500", VA = "0x184EE3300")]
		public BPIICFEKOOL(int PDCCHJJIEPA, IBKPBJLCJKH GAHEFGDNMFL, FNMBADLGNPC ADJGMKHKAJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x4EE31D0", Offset = "0x4EE23D0", VA = "0x184EE31D0", Slot = "11")]
		public bool Equals(LJIHKCFIOKG JMNBIHILIIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x4EE3130", Offset = "0x4EE2330", VA = "0x184EE3130", Slot = "0")]
		public override bool Equals(object PPNJOAJJOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x4EE2F90", Offset = "0x4EE2190", VA = "0x184EE2F90")]
		private bool BOFNHECOBPI(BPIICFEKOOL JMNBIHILIIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x4EE3270", Offset = "0x4EE2470", VA = "0x184EE3270", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	private sealed class DCPNEHGLOON : LJIHKCFIOKG, IEquatable<LJIHKCFIOKG>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A4")]
		[CompilerGenerated]
		private sealed class EIBKJLAICNJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000825")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000826")]
			public AsyncTaskMethodBuilder<FGEDLIOJPHD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000827")]
			public DCPNEHGLOON <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000828")]
			private FGEDLIOJPHD <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000829")]
			private TaskAwaiter<FGEDLIOJPHD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public EIBKJLAICNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x4EE3CB0", Offset = "0x4EE2EB0", VA = "0x184EE3CB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000822")]
		private readonly GMJLKBDAIPD MFMBPFFILPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000823")]
		private readonly KNEAFEIOKGC IOGINGMPANN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000824")]
		private readonly AGHBNDCEFAH CFPCAONCPCK;

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public int FLEHEPEPNBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0x4EE39C0", Offset = "0x4EE2BC0", VA = "0x184EE39C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public IBKPBJLCJKH JLAJBJAEGCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000706")]
			[Cpp2IlInjected.Address(RVA = "0x4EE3A10", Offset = "0x4EE2C10", VA = "0x184EE3A10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private DateTime OINEMKNDANM
		{
			[Cpp2IlInjected.Token(Token = "0x6000707")]
			[Cpp2IlInjected.Address(RVA = "0x4EE38E0", Offset = "0x4EE2AE0", VA = "0x184EE38E0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public KNEAFEIOKGC? BGDOBMNCGIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000708")]
			[Cpp2IlInjected.Address(RVA = "0x4EE3A60", Offset = "0x4EE2C60", VA = "0x184EE3A60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public AGHBNDCEFAH? GAGINJBEKPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000709")]
			[Cpp2IlInjected.Address(RVA = "0x4EE3740", Offset = "0x4EE2940", VA = "0x184EE3740", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public GKNPIECJEKA DCPAMCANDKG
		{
			[Cpp2IlInjected.Token(Token = "0x600070C")]
			[Cpp2IlInjected.Address(RVA = "0x8AEE50", Offset = "0x8AE050", VA = "0x1808AEE50", Slot = "10")]
			get
			{
				return default(GKNPIECJEKA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x34B6710", Offset = "0x34B5910", VA = "0x1834B6710")]
		public DCPNEHGLOON(GMJLKBDAIPD PEIFNOKHAJA, KNEAFEIOKGC GJDABJFDJBD, AGHBNDCEFAH BCHOKJPHBCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x4EE35F0", Offset = "0x4EE27F0", VA = "0x184EE35F0", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(EIBKJLAICNJ))]
		public Task<FGEDLIOJPHD> CBGLKADHECF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x4EE3840", Offset = "0x4EE2A40", VA = "0x184EE3840", Slot = "11")]
		public bool Equals(LJIHKCFIOKG JMNBIHILIIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x4EE3790", Offset = "0x4EE2990", VA = "0x184EE3790", Slot = "0")]
		public override bool Equals(object PPNJOAJJOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x4EE3590", Offset = "0x4EE2790", VA = "0x184EE3590")]
		private bool BOFNHECOBPI(DCPNEHGLOON JMNBIHILIIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x4EE3930", Offset = "0x4EE2B30", VA = "0x184EE3930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	private sealed class KACDKGLELKK : LJIHKCFIOKG, IEquatable<LJIHKCFIOKG>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A6")]
		[CompilerGenerated]
		private sealed class DHMBEMBLGHC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400082D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400082E")]
			public AsyncTaskMethodBuilder<FGEDLIOJPHD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400082F")]
			public KACDKGLELKK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000830")]
			private FGEDLIOJPHD <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000831")]
			private TaskAwaiter<FGEDLIOJPHD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public DHMBEMBLGHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0x4EE3AB0", Offset = "0x4EE2CB0", VA = "0x184EE3AB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400082A")]
		private readonly IBKPBJLCJKH NKAJOLDBPIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400082B")]
		private readonly KNEAFEIOKGC IOGINGMPANN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400082C")]
		private readonly AGHBNDCEFAH CFPCAONCPCK;

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public int FLEHEPEPNBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x4EE6B80", Offset = "0x4EE5D80", VA = "0x184EE6B80", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		[NotNull]
		public IBKPBJLCJKH JLAJBJAEGCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		private DateTime OINEMKNDANM
		{
			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0x7E4D10", Offset = "0x7E3F10", VA = "0x1807E4D10", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public KNEAFEIOKGC? BGDOBMNCGIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000717")]
			[Cpp2IlInjected.Address(RVA = "0x4EE6C00", Offset = "0x4EE5E00", VA = "0x184EE6C00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public AGHBNDCEFAH? GAGINJBEKPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(RVA = "0x4EE67F0", Offset = "0x4EE59F0", VA = "0x184EE67F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public GKNPIECJEKA DCPAMCANDKG
		{
			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0x7E4D10", Offset = "0x7E3F10", VA = "0x1807E4D10", Slot = "10")]
			get
			{
				return default(GKNPIECJEKA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x34B6710", Offset = "0x34B5910", VA = "0x1834B6710")]
		public KACDKGLELKK(IBKPBJLCJKH GAHEFGDNMFL, KNEAFEIOKGC GJDABJFDJBD, AGHBNDCEFAH BCHOKJPHBCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x4EE66A0", Offset = "0x4EE58A0", VA = "0x184EE66A0", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(DHMBEMBLGHC))]
		public Task<FGEDLIOJPHD> CBGLKADHECF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x4EE6840", Offset = "0x4EE5A40", VA = "0x184EE6840", Slot = "11")]
		public bool Equals(LJIHKCFIOKG JMNBIHILIIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x4EE6980", Offset = "0x4EE5B80", VA = "0x184EE6980", Slot = "0")]
		public override bool Equals(object PPNJOAJJOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x4EE6AD0", Offset = "0x4EE5CD0", VA = "0x184EE6AD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x4EE6580", Offset = "0x4EE5780", VA = "0x184EE6580")]
		private bool BOFNHECOBPI(KACDKGLELKK JMNBIHILIIC)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[CompilerGenerated]
	private sealed class OPLEOMDIHJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000838")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000839")]
		public AsyncTaskMethodBuilder<IList<LJIHKCFIOKG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400083A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400083B")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400083C")]
		public bool forceRefreshSaveHistoryCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400083D")]
		public NBDAGJMLNIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400083E")]
		private (long roomId, long subroomId) <cacheKey>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400083F")]
		private IReadOnlyList<FNMBADLGNPC> <saveHistory>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000840")]
		private IReadOnlyList<(int accountId, IBKPBJLCJKH account, FNMBADLGNPC roomDataSaveDto)> <saveHistoryWithAccounts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000841")]
		private List<LJIHKCFIOKG> <restoreOptions>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000842")]
		private DateTime? <mostRecentSaveDate>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000843")]
		private GMJLKBDAIPD <autoSaveInfo>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000844")]
		private IReadOnlyList<FNMBADLGNPC> <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000845")]
		private IReadOnlyList<(int accountId, IBKPBJLCJKH account, FNMBADLGNPC roomDataSaveDto)> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000846")]
		private IEnumerator<(int accountId, IBKPBJLCJKH account, FNMBADLGNPC roomDataSaveDto)> <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000847")]
		private (int accountId, IBKPBJLCJKH account, FNMBADLGNPC roomDataSaveDto) <saveHistoryWithAccount>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000848")]
		private DCPNEHGLOON <autosaveOption>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000849")]
		private TaskAwaiter<IReadOnlyList<FNMBADLGNPC>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400084A")]
		private TaskAwaiter<IReadOnlyList<(int accountId, IBKPBJLCJKH account, FNMBADLGNPC roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public OPLEOMDIHJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x4EE9830", Offset = "0x4EE8A30", VA = "0x184EE9830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	[CompilerGenerated]
	private sealed class HEKCHMMDJNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400084B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400084C")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, IBKPBJLCJKH account, FNMBADLGNPC roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400084D")]
		public IReadOnlyList<FNMBADLGNPC> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400084E")]
		public NBDAGJMLNIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400084F")]
		private List<int> <accountIds>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000850")]
		private IReadOnlyList<IBKPBJLCJKH> <accounts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000851")]
		private Dictionary<ObscuredInt, IBKPBJLCJKH> <accountsDict>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000852")]
		private List<(int, IBKPBJLCJKH, FNMBADLGNPC)> <finalHistory>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000853")]
		private IReadOnlyList<IBKPBJLCJKH> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000854")]
		private IEnumerator<FNMBADLGNPC> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000855")]
		private FNMBADLGNPC <historyItem>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000856")]
		private int <savedByAccountId>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000857")]
		private IBKPBJLCJKH <savedByAccount>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000858")]
		private IBKPBJLCJKH <account>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000859")]
		private TaskAwaiter<IReadOnlyList<IBKPBJLCJKH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public HEKCHMMDJNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x4EE4200", Offset = "0x4EE3400", VA = "0x184EE4200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000811")]
	private readonly NKJMIAAHDPN IHEIIGNNIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000812")]
	private readonly JMJOOKGKNLE PBGENBCLAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000813")]
	private readonly BGPLFENKJGO LDMIAMDLMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000814")]
	private readonly NNHIMCGFECB<(long, long), IReadOnlyList<FNMBADLGNPC>> GFLJJGNCAKL;

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x28B4130", Offset = "0x28B3330", VA = "0x1828B4130")]
	[UnityEngine.Scripting.Preserve]
	public NBDAGJMLNIJ([NDGONEEEGIA(null)] JMJOOKGKNLE IHCGNJBAFLC, [NDGONEEEGIA(null)] BGPLFENKJGO FDMFOCNBEFM, [NDGONEEEGIA(null)] NKJMIAAHDPN KGBLPLMCPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x28B3C80", Offset = "0x28B2E80", VA = "0x1828B3C80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OPLEOMDIHJA))]
	public Task<IList<LJIHKCFIOKG>> CEDGDPICBKA(long HBFBDJIOFCF, long HHIFFPJLPIC, bool LJHPCGEODBP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x28B3F90", Offset = "0x28B3190", VA = "0x1828B3F90")]
	private bool PMINDKKJHPK(DateTime? DEODMOCMDHE, long HBFBDJIOFCF, long HHIFFPJLPIC, out GMJLKBDAIPD OPBMLMJIHBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x28B3E20", Offset = "0x28B3020", VA = "0x1828B3E20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HEKCHMMDJNJ))]
	private Task<IReadOnlyList<(int, IBKPBJLCJKH, FNMBADLGNPC)>> GOMKDIKDCBL(IReadOnlyList<FNMBADLGNPC> KBCIKOLMGEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AA")]
internal class IINNGNBDONI : JMJOOKGKNLE
{
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	private sealed class LDKIEEDMFNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400085A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400085B")]
		public AsyncTaskMethodBuilder<IReadOnlyList<FNMBADLGNPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400085C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400085D")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400085E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400085F")]
		public IINNGNBDONI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000860")]
		private HFEJEONHFMI<FNMBADLGNPC> <pagedResults>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000861")]
		private HFEJEONHFMI<FNMBADLGNPC> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000862")]
		private TaskAwaiter<HFEJEONHFMI<FNMBADLGNPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public LDKIEEDMFNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x3AE2FF0", Offset = "0x3AE21F0", VA = "0x183AE2FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[CompilerGenerated]
	private sealed class CFFCKMAPEGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000863")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000864")]
		public AsyncTaskMethodBuilder<IReadOnlyList<IBKPBJLCJKH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000865")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000866")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000867")]
		public IINNGNBDONI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000868")]
		private List<IBKPBJLCJKH> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000869")]
		private TaskAwaiter<List<IBKPBJLCJKH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public CFFCKMAPEGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x3AD88D0", Offset = "0x3AD7AD0", VA = "0x183AD88D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	[UnityEngine.Scripting.Preserve]
	public IINNGNBDONI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x1F74B40", Offset = "0x1F73D40", VA = "0x181F74B40", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LDKIEEDMFNO))]
	public Task<IReadOnlyList<FNMBADLGNPC>> NGJEAHAFJOD(long HBFBDJIOFCF, long BGOPDGBJMDP, [Optional] CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x1F749A0", Offset = "0x1F73BA0", VA = "0x181F749A0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CFFCKMAPEGH))]
	public Task<IReadOnlyList<IBKPBJLCJKH>> BDCONCIDAPG(IReadOnlyList<int> EOPKPFELKIM, [Optional] CancellationToken MELLLMEKJLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
public interface JMJOOKGKNLE
{
	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<FNMBADLGNPC>> NGJEAHAFJOD(long HBFBDJIOFCF, long BGOPDGBJMDP, [Optional] CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<IBKPBJLCJKH>> BDCONCIDAPG(IReadOnlyList<int> EOPKPFELKIM, [Optional] CancellationToken MELLLMEKJLC);
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
public interface LJIHKCFIOKG : IEquatable<LJIHKCFIOKG>
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	int FLEHEPEPNBI
	{
		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	[CanBeNull]
	IBKPBJLCJKH JLAJBJAEGCF
	{
		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	DateTime AJFPFLKELOF
	{
		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	KNEAFEIOKGC? BGDOBMNCGIP
	{
		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	AGHBNDCEFAH? GAGINJBEKPD
	{
		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	[CanBeNull]
	GKNPIECJEKA DCPAMCANDKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<FGEDLIOJPHD> CBGLKADHECF();
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
public enum GKNPIECJEKA
{
	[Cpp2IlInjected.Token(Token = "0x400086B")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x400086C")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x400086D")]
	DiskAutosave
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

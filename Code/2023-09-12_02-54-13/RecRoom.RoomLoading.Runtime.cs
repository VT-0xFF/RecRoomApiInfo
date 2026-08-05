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
		[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
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
		[Cpp2IlInjected.Address(RVA = "0x27E2090", Offset = "0x27E1490", VA = "0x1827E2090")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA6EF70", Offset = "0xA6E370", VA = "0x180A6EF70")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6EFA0", Offset = "0xA6E3A0", VA = "0x180A6EFA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KMGCJHHGHIL
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<MANOJAHNIFE> FNBBFLFPHJC;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CNBBALOGKDH(long KFHMHOFPIPN, long LHBCPOODKNA, DPAKJIPJCJD KFBJJKPIMFK, HBJIMGJNMKE JKNMNCOCLMI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ONNKFHAFBPF(long KFHMHOFPIPN, long LHBCPOODKNA, out MANOJAHNIFE FOFGMEHODIH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AKOCDJPGCNL(long KFHMHOFPIPN, long LHBCPOODKNA, HBJIMGJNMKE JKNMNCOCLMI, out MANOJAHNIFE FOFGMEHODIH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EPFJBGBMPFA(long KFHMHOFPIPN, long LHBCPOODKNA);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[UnityEngine.Scripting.Preserve]
internal class BKKKBJMMGFA : KBGCMGGOIPA, BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class FCKLNLDFBLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public PJKDLPBKDPA roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public FCKLNLDFBLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x27D2D70", Offset = "0x27D2170", VA = "0x1827D2D70")]
		internal object KECMNCLOOIE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action KDKCBMDFCDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2088B30", Offset = "0x2087F30", VA = "0x182088B30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x20885A0", Offset = "0x20879A0", VA = "0x1820885A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event OMKIMPBDNJP KDJFOIIOCJM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2088320", Offset = "0x2087720", VA = "0x182088320", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2088A60", Offset = "0x2087E60", VA = "0x182088A60", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event OMKIMPBDNJP BPCNIKFEMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x20886E0", Offset = "0x2087AE0", VA = "0x1820886E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2088460", Offset = "0x2087860", VA = "0x182088460", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event OMKIMPBDNJP JOLIFBBIAEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2088500", Offset = "0x2087900", VA = "0x182088500", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2088640", Offset = "0x2087A40", VA = "0x182088640", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<EALLAFIMFMG, bool> EIIMMDAMCNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x20883C0", Offset = "0x20877C0", VA = "0x1820883C0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2088BD0", Offset = "0x2087FD0", VA = "0x182088BD0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "19")]
	public void MHIDNOPDKCM(EEMPEMCEAHC MDIBAOPLIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2088C70", Offset = "0x2088070", VA = "0x182088C70", Slot = "14")]
	public void PANOCLDGFBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2088780", Offset = "0x2087B80", VA = "0x182088780", Slot = "15")]
	public void IAOJFKKOHMA(PJKDLPBKDPA NDLHNJOADNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2088B00", Offset = "0x2087F00", VA = "0x182088B00", Slot = "16")]
	public void NPKIJFLAMOG(PJKDLPBKDPA NDLHNJOADNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x20882F0", Offset = "0x20876F0", VA = "0x1820882F0", Slot = "17")]
	public void ACJMLEJOMFO(PJKDLPBKDPA NDLHNJOADNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x20887B0", Offset = "0x2087BB0", VA = "0x1820887B0", Slot = "18")]
	public void IOPIOCMOPPK(EALLAFIMFMG LFJAMNBIHGB, bool PKEPEKOBHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2088860", Offset = "0x2087C60", VA = "0x182088860")]
	private void LABHLMFNFCH(OMKIMPBDNJP IDKFBDPGAII, PJKDLPBKDPA NDLHNJOADNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public BKKKBJMMGFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface CBKJPDEIBGD : BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HGBBKLDKBDP OLKCDCGIEAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KKKFPOKJJDA();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KFLDFFDAFLN();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface ACHJPEIIGFP : BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EDOOAEOJHDG OFLFJAGLOFL(LJHBMNCDKEI PBKOCAOGIAF);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MFLBCCHEGCK(Guid JIDMDNKJFGM, Task POLOIIHCKEK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal struct NIEKBJIDLCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly IDictionary<object, object> FIOCENBHCHN;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8BE820", Offset = "0x8BDC20", VA = "0x1808BE820")]
	public NIEKBJIDLCL(IDictionary<object, object> FIOCENBHCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x27E0ED0", Offset = "0x27E02D0", VA = "0x1827E0ED0")]
	public bool ALEBBDFEJFA(out LJHBMNCDKEI FHDJIGKOLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x27E1190", Offset = "0x27E0590", VA = "0x1827E1190")]
	public Guid IHLKJGKJGOJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x27E1080", Offset = "0x27E0480", VA = "0x1827E1080")]
	public EIDINADMANL GEHEGGGEMHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x27E0F90", Offset = "0x27E0390", VA = "0x1827E0F90")]
	public static ExitGames.Client.Photon.Hashtable DEDAFMGEJMH(LJHBMNCDKEI FHDJIGKOLJM, EIDINADMANL NALHFDPHLJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FDNICCPNGND : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KDILOFNBCGL(AKAIENANBAO.NJOJFDAJFOG KHGDEMFHHGP);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OBGNOKKICFP(AKAIENANBAO.NJOJFDAJFOG KHGDEMFHHGP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class AKAIENANBAO : FDNICCPNGND, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate EIDINADMANL NJOJFDAJFOG([NotNull] NJNAENGEJEB ECNCNFMMPGE);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class GKBKPIOPHHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public NJNAENGEJEB photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public GKBKPIOPHHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x27D3710", Offset = "0x27D2B10", VA = "0x1827D3710")]
		internal EIDINADMANL IENNIOGAFGB(NJOJFDAJFOG v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool JOEDCLMPFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly HashSet<NJOJFDAJFOG> GGOMAPNMBDH;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2086E60", Offset = "0x2086260", VA = "0x182086E60", Slot = "4")]
	public void KDILOFNBCGL(NJOJFDAJFOG KHGDEMFHHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2086EC0", Offset = "0x20862C0", VA = "0x182086EC0", Slot = "5")]
	public void OBGNOKKICFP(NJOJFDAJFOG KHGDEMFHHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2086BA0", Offset = "0x2085FA0", VA = "0x182086BA0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2086BF0", Offset = "0x2085FF0", VA = "0x182086BF0")]
	protected EIDINADMANL EBJGANKJGFC(NJNAENGEJEB DPIHFNLNBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2086F20", Offset = "0x2086320", VA = "0x182086F20")]
	protected AKAIENANBAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class GNMHBBBDHML
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class ILEOJKPDODL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public KFJCLNMFLAB subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public ILEOJKPDODL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3A59790", Offset = "0x3A58B90", VA = "0x183A59790")]
		internal bool BLNMGKGAIMH(LENKAENGBGK s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x209BE50", Offset = "0x209B250", VA = "0x18209BE50")]
	public static OPAHMEFPIDH DEDAFMGEJMH(long NHBGNGOKOAD, long BCJGCHKGEMF, string IGLBCBOECHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x209BEF0", Offset = "0x209B2F0", VA = "0x18209BEF0")]
	public static OPAHMEFPIDH DEDAFMGEJMH(long NHBGNGOKOAD, long BCJGCHKGEMF, DJFLKAMMCHF OOGBKJBIGHG, long APEDKGLOCFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x209BAE0", Offset = "0x209AEE0", VA = "0x18209BAE0")]
	public static OPAHMEFPIDH DEDAFMGEJMH(NGIGNBDICFJ FBEFCLKJODL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x209BC10", Offset = "0x209B010", VA = "0x18209BC10")]
	public static OPAHMEFPIDH DEDAFMGEJMH(MFKMLKAPGOD CPCNCCDCALK, KFJCLNMFLAB JLCJJOPOAPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x209B9E0", Offset = "0x209ADE0", VA = "0x18209B9E0")]
	public static OPAHMEFPIDH DAJMHGGHAKP(this OPAHMEFPIDH HOJNLEBJGLH, MFKMLKAPGOD EJKBGMCKGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x209BFC0", Offset = "0x209B3C0", VA = "0x18209BFC0")]
	public static OPAHMEFPIDH GPEMNJDKFMO(this OPAHMEFPIDH HOJNLEBJGLH, KFJCLNMFLAB BAHGBBILPAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum KAIFKGLPIPH
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum EALLAFIMFMG
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
public struct PJKDLPBKDPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly long NHBGNGOKOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly long BCJGCHKGEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly KAIFKGLPIPH GANFKPHKNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[CanBeNull]
	public readonly Exception KDPHOFMMGDJ;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x27E9E20", Offset = "0x27E9220", VA = "0x1827E9E20")]
	public PJKDLPBKDPA(long NHBGNGOKOAD, long BCJGCHKGEMF, KAIFKGLPIPH GANFKPHKNKH, [CanBeNull] Exception KDPHOFMMGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x27E9DD0", Offset = "0x27E91D0", VA = "0x1827E9DD0")]
	public static PJKDLPBKDPA DJKLNEJICMK(GIFLFLGKBIH MFIKDLJMLAM, KAIFKGLPIPH GANFKPHKNKH, [Optional] Exception KDPHOFMMGDJ)
	{
		return default(PJKDLPBKDPA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public delegate void OMKIMPBDNJP(PJKDLPBKDPA NDLHNJOADNA);
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface KBGCMGGOIPA : BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action KDKCBMDFCDP;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event OMKIMPBDNJP KDJFOIIOCJM;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event OMKIMPBDNJP BPCNIKFEMNJ;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event OMKIMPBDNJP JOLIFBBIAEI;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<EALLAFIMFMG, bool> EIIMMDAMCNH;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PANOCLDGFBN();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IAOJFKKOHMA(PJKDLPBKDPA NDLHNJOADNA);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NPKIJFLAMOG(PJKDLPBKDPA NDLHNJOADNA);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ACJMLEJOMFO(PJKDLPBKDPA NDLHNJOADNA);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IOPIOCMOPPK(EALLAFIMFMG LFJAMNBIHGB, bool PKEPEKOBHMH);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[UnityEngine.Scripting.Preserve]
internal class CBBGHHAGOEF : CMMFFPEJGAH, BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class CKMIJFHCPAC : IAsyncStateMachine
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
		public CBBGHHAGOEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private CPMEPPENFLB<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private IEHAGJFCBEC <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public CKMIJFHCPAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x27D1900", Offset = "0x27D0D00", VA = "0x1827D1900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private PMICAKGHNFF MJJNPNJOEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private EEMPEMCEAHC MDIBAOPLIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private FGCGBIIICGK LBIPEFBIOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private LLOOMDABLJB BJCOHHALCHA;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x20890E0", Offset = "0x20884E0", VA = "0x1820890E0", Slot = "6")]
	public void MHIDNOPDKCM(EEMPEMCEAHC MDIBAOPLIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2089090", Offset = "0x2088490", VA = "0x182089090", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2088E80", Offset = "0x2088280", VA = "0x182088E80", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CKMIJFHCPAC))]
	public Task AJLLFEIEEFA(string GBGNJPBFOBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2088FD0", Offset = "0x20883D0", VA = "0x182088FD0", Slot = "4")]
	public EIDINADMANL BGHFAMBJLKL(NJNAENGEJEB LHMPIDCIMFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x20892F0", Offset = "0x20886F0", VA = "0x1820892F0")]
	private IEHAGJFCBEC NPMPDCPNMLN(string GBGNJPBFOBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public CBBGHHAGOEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface CFJAIONOPOH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool JFLKAKAGLOF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool OJPMPKEEDNF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	LOBICFHPEOG LAAKMJOKDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action KDKCBMDFCDP;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event OMKIMPBDNJP KDJFOIIOCJM;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event OMKIMPBDNJP BPCNIKFEMNJ;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event OMKIMPBDNJP JOLIFBBIAEI;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<EALLAFIMFMG, bool> EIIMMDAMCNH;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MBCJKMLBKKI();

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "13")]
	LJMNFMIEBEA PEBADICOGMA();

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CBINNBJHFGJ HNPEODDPEHJ();

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<EIDINADMANL> IJJPKPBGFNI(MANOJAHNIFE LGMCHOGOHPK);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task CMOCBPIBKJL(CancellationToken ODBDCIFDKPJ);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface AMIKADHECIN : BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EIDINADMANL> IJJPKPBGFNI(MANOJAHNIFE FOFGMEHODIH);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CMOCBPIBKJL(CancellationToken ODBDCIFDKPJ);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[RecRoom.NoEngine.Common.Preserve]
internal class DKFPLOAGHFL : OMFCKGEPCHJ, BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class GOJFLHPDBEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public GIFLFLGKBIH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public LOBICFHPEOG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public DKFPLOAGHFL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public GOJFLHPDBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x27D3B10", Offset = "0x27D2F10", VA = "0x1827D3B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class ILJINAICILM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public GIFLFLGKBIH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public LOBICFHPEOG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public DKFPLOAGHFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private CPMEPPENFLB<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private HACHIHGCJBL <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private GIAKOKFGLOP <analyticsData>5__5;

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
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public ILJINAICILM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3A59840", Offset = "0x3A58C40", VA = "0x183A59840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class ODDANOMDLEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Matchmaking.JBBHLEKOCBN result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public DDBGEGLAAFB errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public ODDANOMDLEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3A60EF0", Offset = "0x3A602F0", VA = "0x183A60EF0")]
		internal object OGMGHODLPNO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class OEIPNCLABPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Task<OPAHMEFPIDH> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public OEIPNCLABPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0")]
		internal Task<OPAHMEFPIDH> DGLBFPOLALM(CPMEPPENFLB<string>.PEFDMNJICBO _)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class IKBEEMLNJHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public CPMEPPENFLB<string>.PEFDMNJICBO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public GIFLFLGKBIH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public LOBICFHPEOG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public HACHIHGCJBL joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public DKFPLOAGHFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private AACAPNPHAPG <multiProgressTracker>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private IDisposable <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <connectToRoomAndRunLoadLogicTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private CancellationTokenSource <roomTokenSource>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private CancellationTokenRegistration <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private OEIPNCLABPA <>8__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private KDKPDCAOKBD <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Task<Matchmaking.HPGFHIEHHDN> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private KMFPJJAEIBH <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private Matchmaking.HPGFHIEHHDN <serverConnectionInfo>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private CancellationTokenSource <cameraFadeCts>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private CancellationTokenSource <loadingScreenCts>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <loadingScreenScope>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private Matchmaking.HPGFHIEHHDN <>s__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private CancellationTokenSource <photonJoinedTokenSource>5__18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private CancellationToken <photonJoinedToken>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private OPAHMEFPIDH <initialRoomLoadPayload>5__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private Task <roomLoadTask>5__21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private OPAHMEFPIDH <>s__22;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__23;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter<Matchmaking.HPGFHIEHHDN> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<OPAHMEFPIDH> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public IKBEEMLNJHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x27D5230", Offset = "0x27D4630", VA = "0x1827D5230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class HMLGFAJEIKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public CPMEPPENFLB<string>.PEFDMNJICBO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public DKFPLOAGHFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <disconnectTimerScope>5__2;

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
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public HMLGFAJEIKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x27D3FE0", Offset = "0x27D33E0", VA = "0x1827D3FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class FMBGEOINADN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public DKFPLOAGHFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IFJJAPHPIAE <roomContainer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public FMBGEOINADN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x27D2F00", Offset = "0x27D2300", VA = "0x1827D2F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class AOOLHJCKBMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<Matchmaking.HPGFHIEHHDN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public GIFLFLGKBIH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public CPMEPPENFLB<string>.PEFDMNJICBO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public DKFPLOAGHFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private Matchmaking.HPGFHIEHHDN <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private TaskAwaiter<Matchmaking.HPGFHIEHHDN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public AOOLHJCKBMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x27D0B40", Offset = "0x27CFF40", VA = "0x1827D0B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class CJDMABGFGHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Matchmaking.HPGFHIEHHDN serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public HACHIHGCJBL joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public CPMEPPENFLB<string>.PEFDMNJICBO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public DKFPLOAGHFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private LJFGIGCCGHP <photonRoomConnectionInfo>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<LJFGIGCCGHP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public CJDMABGFGHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x27D1380", Offset = "0x27D0780", VA = "0x1827D1380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class KNNBDIIDMKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public GIFLFLGKBIH targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public KNNBDIIDMKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class KOPMCFFKBMG
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
		public KNNBDIIDMKJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public KOPMCFFKBMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3A5C120", Offset = "0x3A5B520", VA = "0x183A5C120")]
		internal object OEMCJNAHHGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3A5C010", Offset = "0x3A5B410", VA = "0x183A5C010")]
		internal string GKIPAONKLNB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class PEEGAFIEGPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public GIFLFLGKBIH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public DKFPLOAGHFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private KNNBDIIDMKJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private KOPMCFFKBMG <>8__3;

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
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public PEEGAFIEGPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3A62B10", Offset = "0x3A61F10", VA = "0x183A62B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class OBKCDNJFBOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public OPAHMEFPIDH initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public AACAPNPHAPG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public GIFLFLGKBIH targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public HACHIHGCJBL joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public CPMEPPENFLB<string>.PEFDMNJICBO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public DKFPLOAGHFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <roomLoadLogicTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private HACHIHGCJBL <initialLoadOpPauseToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private CNGHAPPENLE <op>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public OBKCDNJFBOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3A603B0", Offset = "0x3A5F7B0", VA = "0x183A603B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class LLPJFPBECDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public CPMEPPENFLB<string>.PEFDMNJICBO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public DKFPLOAGHFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <spawnLocalPlayerTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__7;

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
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public LLPJFPBECDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3A5C500", Offset = "0x3A5B900", VA = "0x183A5C500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class OFFNBHMPADL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public AEEBPABFEDL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public DKFPLOAGHFL <>4__this;

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
		private TaskAwaiter<EIDINADMANL> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public OFFNBHMPADL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3A61460", Offset = "0x3A60860", VA = "0x183A61460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class FOOCEBDKNBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public GIFLFLGKBIH targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public FOOCEBDKNBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x27D3330", Offset = "0x27D2730", VA = "0x1827D3330")]
		internal object OMPDJBKKJCB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class GINBHJCFGMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public GINBHJCFGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x27D3670", Offset = "0x27D2A70", VA = "0x1827D3670")]
		internal void IFIKAHGILME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class DBBEJKIJOOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public GIFLFLGKBIH targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public DBBEJKIJOOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x27D2270", Offset = "0x27D1670", VA = "0x1827D2270")]
		internal object FJPFCPFDKLM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class PIEBEMBNFNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public GIFLFLGKBIH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public PIEBEMBNFNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3A635E0", Offset = "0x3A629E0", VA = "0x183A635E0")]
		internal string MCLAANCDGFP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly EHKEPJIBENP GCEEHICDBIO;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly EHKEPJIBENP CIBNMNAFLIN;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly EHKEPJIBENP DMDGFFGHENG;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static readonly string NIONJCNHGMC;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static readonly string PPAPNDBJKGL;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly string PHNPNDGPIMK;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly Guid HGNNPDMKKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DLMGJNBMKMD COFHFLANDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private BJJHOFECDMP BFAPBMMCPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private BOEFLMAPNBA COPLMJPOHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private EEMPEMCEAHC MDIBAOPLIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private ENPHMEADLAM EOPIGBOAJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private GONAGPLJKCD FDHKLBFGNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private CPDGGGDCIDJ PGGCGJPGJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private KBGCMGGOIPA PBBOHGPNEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private MPHGBLPIAOI EMDMAKECHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private FEEJGIIJOED CKHBMDCGNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private IDisposable CFPOMDHKNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly IBNOLCFAKOG HBFPKPGKOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly IBNOLCFAKOG FAECOBNBEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private KMFPJJAEIBH ALPCOMHOKDM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public TaskStatus EBMCAGNBPHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1F06550", Offset = "0x1F05950", VA = "0x181F06550", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1F052D0", Offset = "0x1F046D0", VA = "0x181F052D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private KDNPAEGHDGO CLDGCANEAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2091BE0", Offset = "0x2090FE0", VA = "0x182091BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2091320", Offset = "0x2090720", VA = "0x182091320", Slot = "6")]
	public void MHIDNOPDKCM(EEMPEMCEAHC MDIBAOPLIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x208F4E0", Offset = "0x208E8E0", VA = "0x18208F4E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2090930", Offset = "0x208FD30", VA = "0x182090930", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GOJFLHPDBEC))]
	public Task LCDFNNIOHJB(GIFLFLGKBIH EJIIHIOHIAP, LOBICFHPEOG GEAJEHCANLE, CancellationToken KPKCFPJKMGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x208E9A0", Offset = "0x208DDA0", VA = "0x18208E9A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ILJINAICILM))]
	private Task AILGBDMOAJO(GIFLFLGKBIH EJIIHIOHIAP, LOBICFHPEOG GEAJEHCANLE, CancellationToken KPKCFPJKMGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2092000", Offset = "0x2091400", VA = "0x182092000")]
	private static void PIMJJFKCJOH(MPHGBLPIAOI EMDMAKECHJM, GIFLFLGKBIH EJIIHIOHIAP, Exception DEFKCOPBBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x208ECB0", Offset = "0x208E0B0", VA = "0x18208ECB0")]
	private static void BBBBBFFINCK(GIAKOKFGLOP IJACHOANHHJ, Exception DEFKCOPBBKE, [Optional] List<int> LFHAJMLALPB, int OHDEDCMGOBB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x208FB10", Offset = "0x208EF10", VA = "0x18208FB10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IKBEEMLNJHG))]
	private Task GBLEJGGNDJH(CPMEPPENFLB<string>.PEFDMNJICBO INJHLEJHFLF, GIFLFLGKBIH EJIIHIOHIAP, LOBICFHPEOG GEAJEHCANLE, HACHIHGCJBL HIFFJHKCCEN, CancellationToken KPKCFPJKMGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2091750", Offset = "0x2090B50", VA = "0x182091750")]
	private void NKIHMNIPHLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x20911B0", Offset = "0x20905B0", VA = "0x1820911B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HMLGFAJEIKE))]
	private Task MFNDOHKFMMO(CPMEPPENFLB<string>.PEFDMNJICBO INJHLEJHFLF, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2090EA0", Offset = "0x20902A0", VA = "0x182090EA0")]
	private void MFFHCADNGLP(GIFLFLGKBIH EJIIHIOHIAP, CancellationToken KPKCFPJKMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x208FF30", Offset = "0x208F330", VA = "0x18208FF30")]
	private void HIKFEHMIPNK(GIFLFLGKBIH EJIIHIOHIAP, HACHIHGCJBL HIFFJHKCCEN, OperationCanceledException EHDFLJFMMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2090C70", Offset = "0x2090070", VA = "0x182090C70")]
	private void MEIPFDPHAEA(GIFLFLGKBIH EJIIHIOHIAP, HACHIHGCJBL HIFFJHKCCEN, Exception DEFKCOPBBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2090720", Offset = "0x208FB20", VA = "0x182090720")]
	private void KPJAAFPFELE(GIFLFLGKBIH EJIIHIOHIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x208FEF0", Offset = "0x208F2F0", VA = "0x18208FEF0")]
	private static PJKDLPBKDPA HAGNLEDLODP(GIFLFLGKBIH EJIIHIOHIAP)
	{
		return default(PJKDLPBKDPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x208F860", Offset = "0x208EC60", VA = "0x18208F860")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FMBGEOINADN))]
	private Task FINNBAILHPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2090AD0", Offset = "0x208FED0", VA = "0x182090AD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AOOLHJCKBMM))]
	private Task<Matchmaking.HPGFHIEHHDN> LPCOIGDIKHI(GIFLFLGKBIH EJIIHIOHIAP, CPMEPPENFLB<string>.PEFDMNJICBO INJHLEJHFLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x20901D0", Offset = "0x208F5D0", VA = "0x1820901D0")]
	private static LJFGIGCCGHP HMPNDPJAIAC(Matchmaking.HPGFHIEHHDN IAJHANLECIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x208F530", Offset = "0x208E930", VA = "0x18208F530")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CJDMABGFGHM))]
	private Task FAONIICAPJJ(Matchmaking.HPGFHIEHHDN IAJHANLECIN, HACHIHGCJBL HIFFJHKCCEN, CPMEPPENFLB<string>.PEFDMNJICBO INJHLEJHFLF, CancellationToken BFEAMMONPFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2091C30", Offset = "0x2091030", VA = "0x182091C30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PEEGAFIEGPN))]
	private Task PCJEOIHFLME(GIFLFLGKBIH EJIIHIOHIAP, CancellationTokenSource LOOOLDLNIML, Task HKBNNJJMLOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x208FCF0", Offset = "0x208F0F0", VA = "0x18208FCF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OBKCDNJFBOI))]
	private Task GNJJGLFFAEK(OPAHMEFPIDH FHMHKPCFBEH, AACAPNPHAPG FAJCLGECACE, GIFLFLGKBIH HPKIMKKEDCM, HACHIHGCJBL DAJPONBMGHD, CPMEPPENFLB<string>.PEFDMNJICBO INJHLEJHFLF, CancellationToken AKEKHOAHKGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2090560", Offset = "0x208F960", VA = "0x182090560")]
	private HACHIHGCJBL JPPBGLFMFFC(HACHIHGCJBL DAJPONBMGHD, ref CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x208EB40", Offset = "0x208DF40", VA = "0x18208EB40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LLPJFPBECDM))]
	private Task AJFJPLIFGIJ(CPMEPPENFLB<string>.PEFDMNJICBO INJHLEJHFLF, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x208F6F0", Offset = "0x208EAF0", VA = "0x18208F6F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OFFNBHMPADL))]
	private Task FBJEPHDEEOB(AEEBPABFEDL CLCAIFLMLCJ, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2091A70", Offset = "0x2090E70", VA = "0x182091A70")]
	private static void OJMOBMCFEIO(GIFLFLGKBIH EJIIHIOHIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x20918A0", Offset = "0x2090CA0", VA = "0x1820918A0")]
	private void OHBMFDPJAOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2090370", Offset = "0x208F770", VA = "0x182090370")]
	private void IJGHFIEEGBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x208FA80", Offset = "0x208EE80", VA = "0x18208FA80")]
	private void GBIDCFKHLEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x20902E0", Offset = "0x208F6E0", VA = "0x1820902E0")]
	private void IAJLGCHFDNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x208E8A0", Offset = "0x208DCA0", VA = "0x18208E8A0")]
	private static void ACPLCGIIGDL(GIFLFLGKBIH EJIIHIOHIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2090470", Offset = "0x208F870", VA = "0x182090470")]
	private static CancellationTokenRegistration JMAPENGCDID(GIFLFLGKBIH EJIIHIOHIAP, CancellationToken BFEAMMONPFJ)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x208F980", Offset = "0x208ED80", VA = "0x18208F980")]
	private static void FNFNJLHMNFI(GIFLFLGKBIH EJIIHIOHIAP, Exception DEFKCOPBBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2091DD0", Offset = "0x20911D0", VA = "0x182091DD0")]
	private void PHNFBKFHONE(GIFLFLGKBIH EJIIHIOHIAP, Task HKBNNJJMLOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2090400", Offset = "0x208F800", VA = "0x182090400")]
	private static void JGFJHJADKIM(Func<string> FENGPJBOMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x20925B0", Offset = "0x20919B0", VA = "0x1820925B0")]
	public DKFPLOAGHFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2090160", Offset = "0x208F560", VA = "0x182090160")]
	[CompilerGenerated]
	internal static (int, int?) HLNGHCJIAAK(DDBGEGLAAFB JPJMOKBNPPJ)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface OMBNINLPKPC
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ADOGIEMPLPD<BPMAKGGBAAK, OMNBHFGADPA>> PGLOPMKCFFH(string FFEMBJOCHMB, long PNFBLDJLDCL, DIAGOJHAELB.PCBKDJIEKPL AGFIHCBKMJD, CancellationToken ODBDCIFDKPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal class AKGHEDNNGJH : JANAGIKJDEA<LJHBMNCDKEI>
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class HNDOOIGHJPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public LJHBMNCDKEI message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public HNDOOIGHJPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x27D4870", Offset = "0x27D3C70", VA = "0x1827D4870")]
		internal object OJJJJEKKOHD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static readonly AKGHEDNNGJH FNGGPKJOCFE;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x20872A0", Offset = "0x20866A0", VA = "0x1820872A0")]
	public ExitGames.Client.Photon.Hashtable CJMDONJKOCN(LJHBMNCDKEI FHDJIGKOLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2087640", Offset = "0x2086A40", VA = "0x182087640", Slot = "5")]
	protected override void MNEDAAFADLE(LJHBMNCDKEI FHDJIGKOLJM, IDictionary<object, object> CLCAIFLMLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2087320", Offset = "0x2086720", VA = "0x182087320", Slot = "6")]
	public override LJHBMNCDKEI EFFJDOFDOEN(IDictionary<object, object> CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2087520", Offset = "0x2086920", VA = "0x182087520")]
	private static void JGFJHJADKIM(string NEMNGPCIMEC, LJHBMNCDKEI FHDJIGKOLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x20877F0", Offset = "0x2086BF0", VA = "0x1820877F0")]
	public AKGHEDNNGJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2086FA0", Offset = "0x20863A0", VA = "0x182086FA0")]
	[CompilerGenerated]
	internal static string BHMLCJHDBFJ(OPAHMEFPIDH HOJNLEBJGLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface MCOOKILLDMM<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ADOGIEMPLPD<byte[], OMNBHFGADPA>> PDHEJHKHGDD(TGetDataArg LBKPMPMCPAG, CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ADOGIEMPLPD<LBJGNEPGLFD<TData>, OMNBHFGADPA> DOMPBMLHKPJ(byte[] CLCAIFLMLCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface DHECAGBHHPN : FDNICCPNGND, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EIDINADMANL GDMJKMOJHIM(NJNAENGEJEB DPIHFNLNBDD);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class CDOAODCMIPI : OCDBAIODJKG, PJGDEHEEDPP, JNLEBLAMECC, IKDPOBOLGGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly PJGDEHEEDPP AOMCAIIAINL;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public NJNAENGEJEB JOGPMLOLHDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x208AB80", Offset = "0x2089F80", VA = "0x18208AB80", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int EAAJGAOPFDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x208AA90", Offset = "0x2089E90", VA = "0x18208AA90", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int ELLGBFOGHML
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x208AD20", Offset = "0x208A120", VA = "0x18208AD20", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool PPIMJLMJCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x823C20", Offset = "0x823020", VA = "0x180823C20", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int EOJNDENKIPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x822D80", Offset = "0x822180", VA = "0x180822D80", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event KNIAEMCEPIJ.NBAEMFGBOGC AKBBDLCEBEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event LJJDGMLMEDC OCHGKIPLGIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x208AC80", Offset = "0x208A080", VA = "0x18208AC80", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x208A890", Offset = "0x2089C90", VA = "0x18208A890", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<bool> FKHHGJBKAFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<NJNAENGEJEB> BPALODHEAIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action EOHIPBBCFPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x208A7F0", Offset = "0x2089BF0", VA = "0x18208A7F0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x208AAE0", Offset = "0x2089EE0", VA = "0x18208AAE0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0xEFBDB0", Offset = "0xEFB1B0", VA = "0x180EFBDB0")]
	public CDOAODCMIPI(PJGDEHEEDPP AOMCAIIAINL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x208ABD0", Offset = "0x2089FD0", VA = "0x18208ABD0", Slot = "8")]
	public bool KMHCPHCAKPJ(byte NAGJNEKCACP, ExitGames.Client.Photon.Hashtable HCIAHLMJJIK, OJFJFLOJHNM LCKNFDOKKMF, SendOptions BPNAPEJACNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x208A990", Offset = "0x2089D90", VA = "0x18208A990", Slot = "16")]
	public NJNAENGEJEB FBMLILNDGDA(int BGDDDLJMKIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "19")]
	public void EDGIMNPIDAL(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "20")]
	public void MADIPGJGJCB(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "21")]
	public void HHHAEGDFHID(object AEMEEHLIDCM, bool NFDBPIPHJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x208A930", Offset = "0x2089D30", VA = "0x18208A930", Slot = "22")]
	public IDisposable EDMECEMNOCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "23")]
	private bool HKLKIOCIGED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "24")]
	public void EOHPELJLIOM(StringBuilder CGDINPCIEMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x208AA70", Offset = "0x2089E70", VA = "0x18208AA70", Slot = "25")]
	public bool HAJHMJJIOHL(bool LAOJGKCCBCB, out string FOMNCGOADBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0xC61130", Offset = "0xC60530", VA = "0x180C61130", Slot = "28")]
	public void HKEOEAEFIHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal struct ALOIGJIMAOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly TaskCompletionSource<(EIDINADMANL, Task)> PNHKJELFONA;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Task<(EIDINADMANL, Task)> FJKJONPMKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2087A00", Offset = "0x2086E00", VA = "0x182087A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2087AD0", Offset = "0x2086ED0", VA = "0x182087AD0")]
	public ALOIGJIMAOG(TimeSpan GKNKCKJFGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2087830", Offset = "0x2086C30", VA = "0x182087830")]
	public void BFEDEIIOGOO(Task POLOIIHCKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2087970", Offset = "0x2086D70", VA = "0x182087970")]
	public void GLPKEGFMLFN(EIDINADMANL NALHFDPHLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2087920", Offset = "0x2086D20", VA = "0x182087920")]
	public void GDJDBPGKPGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2087A40", Offset = "0x2086E40", VA = "0x182087A40")]
	internal void LHFILJCNGMO(string FHDJIGKOLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal class JPHAAFLNHAC : CBKJPDEIBGD, BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private bool MDBANILEBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private HGBBKLDKBDP HDLFHIHIMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private BOEFLMAPNBA COPLMJPOHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private KPCOCGHFKKD PPCPEOGMHIJ;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public HGBBKLDKBDP OLKCDCGIEAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x27D8790", Offset = "0x27D7B90", VA = "0x1827D8790", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x27D8A40", Offset = "0x27D7E40", VA = "0x1827D8A40", Slot = "7")]
	public void MHIDNOPDKCM(EEMPEMCEAHC MDIBAOPLIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x27D8880", Offset = "0x27D7C80", VA = "0x1827D8880", Slot = "5")]
	public void KKKFPOKJJDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x27D8750", Offset = "0x27D7B50", VA = "0x1827D8750", Slot = "6")]
	public void KFLDFFDAFLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x27D8800", Offset = "0x27D7C00", VA = "0x1827D8800")]
	private Task ICBJENHFKPG(CAFNMCEILBJ PIALDONBLBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x27D8750", Offset = "0x27D7B50", VA = "0x1827D8750", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8C18F0", Offset = "0x8C0CF0", VA = "0x1808C18F0")]
	public JPHAAFLNHAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal struct KACLOEIHKEC
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class PDKKMECNNHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public EEMPEMCEAHC manager;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public PDKKMECNNHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3C03850", Offset = "0x3C02C50", VA = "0x183C03850")]
		internal Task JLDIAIKKGNF(AEEBPABFEDL data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class FFKGCNNCPIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public KACLOEIHKEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private MANOJAHNIFE <autosaveInfo>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private JJIIEOBJIJM <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private JJIIEOBJIJM <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private JJIIEOBJIJM <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private TaskAwaiter<JJIIEOBJIJM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private TaskAwaiter<EIDINADMANL> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public FFKGCNNCPIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3BF67E0", Offset = "0x3BF5BE0", VA = "0x183BF67E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class PICBEIGOCGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public KACLOEIHKEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public PICBEIGOCGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x3C03890", Offset = "0x3C02C90", VA = "0x183C03890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly CancellationToken ODBDCIFDKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly EEMPEMCEAHC CHLJPKFIHHL;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private BOEFLMAPNBA KKOAFDPGPJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x27D8F40", Offset = "0x27D8340", VA = "0x1827D8F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private ENPHMEADLAM OLJLNILBIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x27D8EF0", Offset = "0x27D82F0", VA = "0x1827D8EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private KDNPAEGHDGO CLDGCANEAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x27D91E0", Offset = "0x27D85E0", VA = "0x1827D91E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private AMIKADHECIN ELPLHPILNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x27D9190", Offset = "0x27D8590", VA = "0x1827D9190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x232CD60", Offset = "0x232C160", VA = "0x18232CD60")]
	public KACLOEIHKEC(CancellationToken ODBDCIFDKPJ, EEMPEMCEAHC CHLJPKFIHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x27D90E0", Offset = "0x27D84E0", VA = "0x1827D90E0")]
	public static FMAOGPLOMFD GBDMKAKCCDC(EEMPEMCEAHC CHLJPKFIHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x27D8F90", Offset = "0x27D8390", VA = "0x1827D8F90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FFKGCNNCPIC))]
	public Task<bool> FOLFCGOHDPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x27D8BB0", Offset = "0x27D7FB0", VA = "0x1827D8BB0")]
	private bool AECCMPJDCPO(out MANOJAHNIFE FOFGMEHODIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x27D9260", Offset = "0x27D8660", VA = "0x1827D9260")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PICBEIGOCGL))]
	private Task PEINGOJMPAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x27D8D50", Offset = "0x27D8150", VA = "0x1827D8D50")]
	private Task<JJIIEOBJIJM> DBBBCKAEFDM(MANOJAHNIFE JAHLLAOLDLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal class CBLAHKMGBHM : KPCOCGHFKKD
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class AACBHBOGNEC<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private readonly DLINHDPINMI OMIBPOLHBMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly string PMMAAICOJOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly T CHKFHALGEFG;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T EKGBCCDIAJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x8BD740", Offset = "0x8BCB40", VA = "0x1808BD740")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x8C1870", Offset = "0x8C0C70", VA = "0x1808C1870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x3129830", Offset = "0x3128C30", VA = "0x183129830")]
		public AACBHBOGNEC(DLINHDPINMI OMIBPOLHBMI, string PMMAAICOJOP, T CHKFHALGEFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x31294A0", Offset = "0x31288A0", VA = "0x1831294A0")]
		private void EBEOABPHMBP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly DLINHDPINMI OMIBPOLHBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly AACBHBOGNEC<TimeSpan> CFAKFABOJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly AACBHBOGNEC<TimeSpan> NAFLJBOLGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly AACBHBOGNEC<TimeSpan> ODIFMFGILFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly AACBHBOGNEC<TimeSpan> GEFAMCMDNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly AACBHBOGNEC<bool> KCLFFPBMGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly AACBHBOGNEC<bool> EKNCADCOEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly AACBHBOGNEC<bool> IKKMKAHGAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly AACBHBOGNEC<int> KLJPGMLAOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly AACBHBOGNEC<bool> MFOBFKJFGDK;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TimeSpan MBGNHEDAGJG
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2089D90", Offset = "0x2089190", VA = "0x182089D90", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TimeSpan DFEFIHBECNG
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2089CD0", Offset = "0x20890D0", VA = "0x182089CD0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TimeSpan BOFIOOGNHGG
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2089C90", Offset = "0x2089090", VA = "0x182089C90", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TimeSpan IJBAIOBIFIE
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2089D50", Offset = "0x2089150", VA = "0x182089D50", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool FDBEFABDGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2089D10", Offset = "0x2089110", VA = "0x182089D10", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool ECLMLHJDJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2089E10", Offset = "0x2089210", VA = "0x182089E10", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool JHFNDLJPAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2089C10", Offset = "0x2089010", VA = "0x182089C10", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int KDOHDJBLMIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2089DD0", Offset = "0x20891D0", VA = "0x182089DD0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool MNDNKJJNIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2089C50", Offset = "0x2089050", VA = "0x182089C50", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2089E50", Offset = "0x2089250", VA = "0x182089E50")]
	[UnityEngine.Scripting.Preserve]
	public CBLAHKMGBHM([JLJFOFICIEA(null)] DLINHDPINMI OMIBPOLHBMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal struct JFONFNJKMKB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class ILHJMLJMACL : IAsyncStateMachine
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
		public JFONFNJKMKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private List<Task> <tasks>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public ILHJMLJMACL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x3BFBB70", Offset = "0x3BFAF70", VA = "0x183BFBB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly CancellationTokenSource OCLAFKPHAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private bool JOEDCLMPFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private Task NOKNMHIKNGD;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool NNGOFJDJNOF
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x20A3300", Offset = "0x20A2700", VA = "0x1820A3300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x20A3330", Offset = "0x20A2730", VA = "0x1820A3330")]
	public JFONFNJKMKB(CancellationToken ODBDCIFDKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x20A31A0", Offset = "0x20A25A0", VA = "0x1820A31A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ILHJMLJMACL))]
	public Task FPDIMKMHMNM(Func<CancellationToken, List<Task>> JFOFCDKOLIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x20A3150", Offset = "0x20A2550", VA = "0x1820A3150", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal interface JPPKFCCAFEC : BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EDOOAEOJHDG NNFBEGDMHOD(Guid JIDMDNKJFGM);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LOBOHMPHNJE(Guid JIDMDNKJFGM);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BJBEDBPABPI(Guid JIDMDNKJFGM, Task POLOIIHCKEK);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DFCPLDPHOCE(Guid JIDMDNKJFGM, EIDINADMANL FPJHBBJIHFO);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(EIDINADMANL, Task)> JGHEMPCGCOH(Guid JIDMDNKJFGM);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal interface FGCGBIIICGK : BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EIDINADMANL NNLLHDBIDJA(NJNAENGEJEB LHMPIDCIMFG, PMDGAPKKPNC OOOABFDGACF);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EIDINADMANL IFHKEIBCLAK(NJNAENGEJEB DPIHFNLNBDD);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal class IADCAMBJIJH : APHHPEMPPDG
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class NJAAJDMNOHA : IAsyncStateMachine
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
		public IADCAMBJIJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private GIFLFLGKBIH <localRoomInstance>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private GIFLFLGKBIH <newPresenceRoomInstance>5__4;

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
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public NJAAJDMNOHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3A5FAF0", Offset = "0x3A5EEF0", VA = "0x183A5FAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly EEMPEMCEAHC MDIBAOPLIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly ENPHMEADLAM EOPIGBOAJOB;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private KDNPAEGHDGO CLDGCANEAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x209FBB0", Offset = "0x209EFB0", VA = "0x18209FBB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8C50F0", Offset = "0x8C44F0", VA = "0x1808C50F0")]
	public IADCAMBJIJH(EEMPEMCEAHC MDIBAOPLIIF, ENPHMEADLAM EOPIGBOAJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x209FA40", Offset = "0x209EE40", VA = "0x18209FA40", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NJAAJDMNOHA))]
	public Task<bool> HIGMEHHEGFO(CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x209F960", Offset = "0x209ED60", VA = "0x18209F960")]
	[CompilerGenerated]
	private object BMIPHOMEKAL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal interface NKEECIDEDCF : BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLECADFPKAK(LJHBMNCDKEI FHDJIGKOLJM);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HKEHLNBOOMA(LJHBMNCDKEI FHDJIGKOLJM);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<PMDGAPKKPNC> ELPNLGNABAM(CancellationToken DCLLKACCGJH);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal interface CMMFFPEJGAH : BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EIDINADMANL BGHFAMBJLKL(NJNAENGEJEB LHMPIDCIMFG);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AJLLFEIEEFA(string GBGNJPBFOBA);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[UnityEngine.Scripting.Preserve]
internal class MHOFOJLNHII : CPDGGGDCIDJ, BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class JOMFKJBEOIJ : IAsyncStateMachine
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
		public MHOFOJLNHII <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JOMFKJBEOIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3BFDB70", Offset = "0x3BFCF70", VA = "0x183BFDB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly IBNOLCFAKOG OFPHMLJLPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private string JKLHBHFMDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private Task LBPIOMHKHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private EEMPEMCEAHC MDIBAOPLIIF;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool PMGCPCIJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x27DF4C0", Offset = "0x27DE8C0", VA = "0x1827DF4C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public Task KPJOGEDKMAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x27DF2F0", Offset = "0x27DE6F0", VA = "0x1827DF2F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x8BBD30", Offset = "0x8BB130", VA = "0x1808BBD30", Slot = "7")]
	public void MHIDNOPDKCM(EEMPEMCEAHC MDIBAOPLIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x27DF130", Offset = "0x27DE530", VA = "0x1827DF130", Slot = "6")]
	public void CBNHHCBAGEG(Task NOKNMHIKNGD, string MMKIFNMGBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x27DF350", Offset = "0x27DE750", VA = "0x1827DF350")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JOMFKJBEOIJ))]
	private Task IMCIKBKIFBN(Task CKEAJGBCIKK, string MMKIFNMGBAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x27DF4F0", Offset = "0x27DE8F0", VA = "0x1827DF4F0")]
	public MHOFOJLNHII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal struct EDOOAEOJHDG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly JPPKFCCAFEC KFJODKFGLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly Guid JIDMDNKJFGM;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Task<(EIDINADMANL, Task)> FJKJONPMKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2093C80", Offset = "0x2093080", VA = "0x182093C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x176A680", Offset = "0x1769A80", VA = "0x18176A680")]
	public EDOOAEOJHDG(JPPKFCCAFEC KFJODKFGLND, Guid JIDMDNKJFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2093D50", Offset = "0x2093150", VA = "0x182093D50")]
	public TaskAwaiter<(EIDINADMANL, Task)> OHPNENBCPKD()
	{
		return default(TaskAwaiter<(EIDINADMANL, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x2093BB0", Offset = "0x2092FB0", VA = "0x182093BB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[UnityEngine.Scripting.Preserve]
internal sealed class ONDEJEHJKNO : AMIKADHECIN, BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class JGKMBPMBOEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public AsyncTaskMethodBuilder<EIDINADMANL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public MANOJAHNIFE autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public ONDEJEHJKNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private CPMEPPENFLB<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private GFDHIMNMAKL <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private OPAHMEFPIDH <roomLoadPayload>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private EIDINADMANL <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private TaskAwaiter<EIDINADMANL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JGKMBPMBOEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6038AA0", Offset = "0x6037EA0", VA = "0x186038AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class OPHEMKNHHBA : IAsyncStateMachine
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
		public ONDEJEHJKNO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public OPHEMKNHHBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x603BB30", Offset = "0x603AF30", VA = "0x18603BB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class CNDPGOMDABI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public AEEBPABFEDL _;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public ONDEJEHJKNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public CNDPGOMDABI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6036E50", Offset = "0x6036250", VA = "0x186036E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class KELBJMFHCFC : IAsyncStateMachine
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
		public ONDEJEHJKNO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public KELBJMFHCFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x60398F0", Offset = "0x6038CF0", VA = "0x1860398F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class OOKAHIKFJNB : IAsyncStateMachine
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
		public ONDEJEHJKNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public OOKAHIKFJNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x603B9C0", Offset = "0x603ADC0", VA = "0x18603B9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class CFCAKKANDLB : IAsyncStateMachine
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
		public ONDEJEHJKNO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public CFCAKKANDLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3BF3CB0", Offset = "0x3BF30B0", VA = "0x183BF3CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class LKBEBCFMKBJ : IAsyncStateMachine
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
		public ONDEJEHJKNO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public LKBEBCFMKBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x603AC00", Offset = "0x603A000", VA = "0x18603AC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class AEDIAFPMOOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public HBJIMGJNMKE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public ONDEJEHJKNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private CPMEPPENFLB<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private HACHIHGCJBL <operationPauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private KOFGDIOHFOE <autosaveOp>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public AEDIAFPMOOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3BF2030", Offset = "0x3BF1430", VA = "0x183BF2030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private BOEFLMAPNBA COPLMJPOHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private EEMPEMCEAHC MDIBAOPLIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private ENPHMEADLAM EOPIGBOAJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private LLOOMDABLJB BJCOHHALCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private CPDGGGDCIDJ PGGCGJPGJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private LJDEPIOJEBG EJAEMGEIFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private CancellationTokenSource LBMDGAGOODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private Task PKLEKDMCPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private TaskCompletionSource<int> CJMIJMNLAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int PGOODHIDIPD;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x27E68A0", Offset = "0x27E5CA0", VA = "0x1827E68A0", Slot = "6")]
	public void MHIDNOPDKCM(EEMPEMCEAHC MDIBAOPLIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xBF2F60", Offset = "0xBF2360", VA = "0x180BF2F60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x27E64A0", Offset = "0x27E58A0", VA = "0x1827E64A0")]
	private void KIODLMJIAHE(float CGLIBFEDPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x27E6330", Offset = "0x27E5730", VA = "0x1827E6330", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JGKMBPMBOEA))]
	public Task<EIDINADMANL> IJJPKPBGFNI(MANOJAHNIFE FOFGMEHODIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x27E5F40", Offset = "0x27E5340", VA = "0x1827E5F40", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OPHEMKNHHBA))]
	public Task CMOCBPIBKJL([Optional] CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xBF2F60", Offset = "0xBF2360", VA = "0x180BF2F60")]
	public void BPCFFHBMBJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x27E66E0", Offset = "0x27E5AE0", VA = "0x1827E66E0")]
	private GFDHIMNMAKL MBAJMEBFNPF(MANOJAHNIFE FOFGMEHODIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x27E6AD0", Offset = "0x27E5ED0", VA = "0x1827E6AD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CNDPGOMDABI))]
	private Task MHPKAHIENNN(AEEBPABFEDL PIALDONBLBA, CancellationToken KPKCFPJKMGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x27E5B90", Offset = "0x27E4F90", VA = "0x1827E5B90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KELBJMFHCFC))]
	private Task AADFHBFOPIB(CancellationToken KPKCFPJKMGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x27E6C40", Offset = "0x27E6040", VA = "0x1827E6C40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OOKAHIKFJNB))]
	private Task NLDJFDKCEFM([Optional] CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x27E6D90", Offset = "0x27E6190", VA = "0x1827E6D90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CFCAKKANDLB))]
	private Task PONNIINFGLB(CancellationToken KPKCFPJKMGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x27E5CE0", Offset = "0x27E50E0", VA = "0x1827E5CE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LKBEBCFMKBJ))]
	private Task APIDHAIEKDJ(CancellationToken HPGGGDNHPPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x27E6090", Offset = "0x27E5490", VA = "0x1827E6090")]
	private Task GAGDGGDNPBN(HBJIMGJNMKE JKNMNCOCLMI, CancellationToken KPKCFPJKMGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x27E6580", Offset = "0x27E5980", VA = "0x1827E6580")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AEDIAFPMOOH))]
	private Task KJJCIOPJIDK(HBJIMGJNMKE JKNMNCOCLMI, CancellationToken KPKCFPJKMGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x27E5E30", Offset = "0x27E5230", VA = "0x1827E5E30")]
	private bool BGHFAMBJLKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public ONDEJEHJKNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface PMICAKGHNFF : FDNICCPNGND, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EIDINADMANL BGHFAMBJLKL(NJNAENGEJEB DOHCAABJNHK);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[UnityEngine.Scripting.Preserve]
internal class GIAFBNBBCMJ : CALDLKINOJJ, BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class DKOEEHFFKDC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly GIFLFLGKBIH LKMLKICKHPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly CancellationTokenSource OCLAFKPHAEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public readonly CancellationToken LAEPJJABMAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private bool LNNAOEMPGHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private bool IAEKIDJDAJF;

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3A53F10", Offset = "0x3A53310", VA = "0x183A53F10")]
		public DKOEEHFFKDC(GIFLFLGKBIH LKMLKICKHPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3A53DB0", Offset = "0x3A531B0", VA = "0x183A53DB0")]
		public void EIFJDOAKCLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3A53D80", Offset = "0x3A53180", VA = "0x183A53D80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class DNAKHOAAKCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public CAFNMCEILBJ disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public DNAKHOAAKCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3A54C10", Offset = "0x3A54010", VA = "0x183A54C10")]
		internal object FHOJAJDFGKO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class GBHPGDOLNEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public CAFNMCEILBJ disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public GIAFBNBBCMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private DNAKHOAAKCC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public GBHPGDOLNEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3A57850", Offset = "0x3A56C50", VA = "0x183A57850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class FLKPBDFOIDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public FLKPBDFOIDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3A56800", Offset = "0x3A55C00", VA = "0x183A56800")]
		internal object KFHNEIMAKCM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class CBJNLLOKGFG : IAsyncStateMachine
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
		public GIAFBNBBCMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private FLKPBDFOIDE <>8__1;

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
		private GIFLFLGKBIH <newRoomInstance>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private LOBICFHPEOG <customRoomLoadPayload>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private Exception <ex>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public CBJNLLOKGFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3A52CE0", Offset = "0x3A520E0", VA = "0x183A52CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class OCJHADCAJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public GIFLFLGKBIH newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public OCJHADCAJKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3A60DD0", Offset = "0x3A601D0", VA = "0x183A60DD0")]
		internal object EFJCAIOBDDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3A60E70", Offset = "0x3A60270", VA = "0x183A60E70")]
		internal object MCBHPMHCOHM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3A60EB0", Offset = "0x3A602B0", VA = "0x183A60EB0")]
		internal object PFBEAHIOPBB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class JKLDPBIPCGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JKLDPBIPCGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3A5B730", Offset = "0x3A5AB30", VA = "0x183A5B730")]
		internal void NCEPCFHNHMD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class JFBJIKFPNBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public GIFLFLGKBIH newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public LOBICFHPEOG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public GIAFBNBBCMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private OCJHADCAJKC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private JKLDPBIPCGJ <>8__3;

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
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JFBJIKFPNBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3A5A9C0", Offset = "0x3A59DC0", VA = "0x183A5A9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private static readonly DBIJHFDPOPM.KJNIICHGPGP AHDJOHIJPKI;

	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private static readonly OIPFLHGBCCL BICCDIMGBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private BJJHOFECDMP BFAPBMMCPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private EEMPEMCEAHC MDIBAOPLIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private GONAGPLJKCD FDHKLBFGNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private ENPHMEADLAM EOPIGBOAJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private KPCOCGHFKKD PPCPEOGMHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private OMFCKGEPCHJ HGCAHGIMKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private long OBCENHFHAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private DKOEEHFFKDC BJLFDIPHOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private bool BGJDKEBPEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private Task EOIJKNKIOOC;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private KDNPAEGHDGO CLDGCANEAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2099790", Offset = "0x2098B90", VA = "0x182099790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool MDMNOBBAHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA7EA10", Offset = "0xA7DE10", VA = "0x180A7EA10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x20987E0", Offset = "0x2097BE0", VA = "0x1820987E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x2099080", Offset = "0x2098480", VA = "0x182099080", Slot = "4")]
	public void MHIDNOPDKCM(EEMPEMCEAHC MDIBAOPLIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x20988E0", Offset = "0x2097CE0", VA = "0x1820988E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2098F00", Offset = "0x2098300", VA = "0x182098F00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GBHPGDOLNEN))]
	private Task GFAFJAGNJDN(CAFNMCEILBJ PKMDGFEEKBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x2098BD0", Offset = "0x2097FD0", VA = "0x182098BD0")]
	private void GCDKOAEBIBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x20995F0", Offset = "0x20989F0", VA = "0x1820995F0")]
	private void OEPNIGIIIGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x2098D70", Offset = "0x2098170", VA = "0x182098D70")]
	private void GCHICBJFPGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2098A60", Offset = "0x2097E60", VA = "0x182098A60")]
	private bool EACAMCOPGBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x2098AE0", Offset = "0x2097EE0", VA = "0x182098AE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CBJNLLOKGFG))]
	private void EJAGHFGJAOB(int GAAPLDCPBBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x2099330", Offset = "0x2098730", VA = "0x182099330")]
	private void NLPLJLPGIII(out IDisposable DDKIKDNCNFG, out IDisposable EJPGOJACGFF, out IDisposable BCGOJLPAINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x20987F0", Offset = "0x2097BF0", VA = "0x1820987F0")]
	private bool CCKLLGPLGGB(GIFLFLGKBIH LKMLKICKHPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x2099040", Offset = "0x2098440", VA = "0x182099040")]
	private void LOJEBPNDOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x2098670", Offset = "0x2097A70", VA = "0x182098670")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JFBJIKFPNBF))]
	private Task AILGBDMOAJO(GIFLFLGKBIH LKMLKICKHPO, LOBICFHPEOG GEAJEHCANLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x2099C30", Offset = "0x2099030", VA = "0x182099C30")]
	public GIAFBNBBCMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[UnityEngine.Scripting.Preserve]
internal sealed class OGBHMBPNMFA : ACHJPEIIGFP, BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class KNGDPPANFII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public KNGDPPANFII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3BFE6E0", Offset = "0x3BFDAE0", VA = "0x183BFE6E0")]
		internal object ECHDGOPKCJB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class JKIPLAHGKFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JKIPLAHGKFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3BFDB00", Offset = "0x3BFCF00", VA = "0x183BFDB00")]
		internal object LBBLLMMEFPN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private BOEFLMAPNBA COPLMJPOHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private FGCGBIIICGK LBIPEFBIOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private NKEECIDEDCF JBIMIPFGFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private JPPKFCCAFEC KFJODKFGLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private MPCEBLPGLPN OPBPDGBFJML;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x27E3C40", Offset = "0x27E3040", VA = "0x1827E3C40", Slot = "6")]
	public void MHIDNOPDKCM(EEMPEMCEAHC MDIBAOPLIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x27E3210", Offset = "0x27E2610", VA = "0x1827E3210", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x27E4280", Offset = "0x27E3680", VA = "0x1827E4280", Slot = "4")]
	public EDOOAEOJHDG OFLFJAGLOFL(LJHBMNCDKEI PBKOCAOGIAF)
	{
		return default(EDOOAEOJHDG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x27E3A30", Offset = "0x27E2E30", VA = "0x1827E3A30", Slot = "5")]
	public void MFLBCCHEGCK(Guid JIDMDNKJFGM, Task POLOIIHCKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x27E46C0", Offset = "0x27E3AC0", VA = "0x1827E46C0")]
	private void PCFGHLNFKOC(byte NAGJNEKCACP, int ABBAOCANCCL, object DHEDNHFANKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x27E28F0", Offset = "0x27E1CF0", VA = "0x1827E28F0")]
	private void APPBEOMEMPP(NIEKBJIDLCL FIOCENBHCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x27E3DB0", Offset = "0x27E31B0", VA = "0x1827E3DB0")]
	private void MNHHCBAEDMA(NIEKBJIDLCL FIOCENBHCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x27E4030", Offset = "0x27E3430", VA = "0x1827E4030")]
	private void NKANNOBEEBD(NIEKBJIDLCL FIOCENBHCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x27E2F00", Offset = "0x27E2300", VA = "0x1827E2F00")]
	private EIDINADMANL CFPNILJIFOL(LJHBMNCDKEI PKMGPKLHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x27E4790", Offset = "0x27E3B90", VA = "0x1827E4790")]
	private void PELJPEDJGBE(LJHBMNCDKEI GGJMMDPPLNB, EIDINADMANL NALHFDPHLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x27E3780", Offset = "0x27E2B80", VA = "0x1827E3780")]
	private bool LEMKFPOLGGF(LJHBMNCDKEI GGJMMDPPLNB, EIDINADMANL NALHFDPHLJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x27E32B0", Offset = "0x27E26B0", VA = "0x1827E32B0")]
	private bool HKEJKDELCJN(LJHBMNCDKEI DEKLGKNPMMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x27E34E0", Offset = "0x27E28E0", VA = "0x1827E34E0")]
	private bool LCLJCILAFFK(byte NAGJNEKCACP, ExitGames.Client.Photon.Hashtable FIOCENBHCHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public OGBHMBPNMFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[UnityEngine.Scripting.Preserve]
internal sealed class PFDOPPLKEEM : NKEECIDEDCF, BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class KKGEIEGHOLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public AsyncTaskMethodBuilder<PMDGAPKKPNC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public PFDOPPLKEEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private PMDGAPKKPNC <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private TaskAwaiter<PMDGAPKKPNC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public KKGEIEGHOLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6039EC0", Offset = "0x60392C0", VA = "0x186039EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class DFDLPPGIBBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public LJHBMNCDKEI message;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public DFDLPPGIBBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6037E70", Offset = "0x6037270", VA = "0x186037E70")]
		internal object DNDMGFNEAMA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class COELLFFJMON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public LJHBMNCDKEI messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public COELLFFJMON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6037C10", Offset = "0x6037010", VA = "0x186037C10")]
		internal object CNKOEJGCHIO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class NKFBKMBLEHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public LJHBMNCDKEI request;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public NKFBKMBLEHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x603B070", Offset = "0x603A470", VA = "0x18603B070")]
		internal object GCABCLKDHEO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class JMGNKIJFAEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public LJHBMNCDKEI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public PFDOPPLKEEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private NKFBKMBLEHK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private MOKCCACHPIF <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private MOKCCACHPIF <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private TaskAwaiter<MOKCCACHPIF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JMGNKIJFAEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6039250", Offset = "0x6038650", VA = "0x186039250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class BILDMDDMDMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public LJHBMNCDKEI operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public BILDMDDMDMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6036090", Offset = "0x6035490", VA = "0x186036090")]
		internal object GBBFKGBBACP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class CNIGLLAGHCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public LJHBMNCDKEI operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public PFDOPPLKEEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private BILDMDDMDMN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private HACHIHGCJBL <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private LJHBMNCDKEI <syncedMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private MOKCCACHPIF <operation>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private LJHBMNCDKEI <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private TaskAwaiter<LJHBMNCDKEI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public CNIGLLAGHCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x60371F0", Offset = "0x60365F0", VA = "0x1860371F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class LIIIIAIJDCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public AsyncTaskMethodBuilder<MOKCCACHPIF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public LJHBMNCDKEI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public PFDOPPLKEEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private JKDJMKNGDMO.EHPPFGBEMNA <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private HACHIHGCJBL <pauseToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private LJHBMNCDKEI <response>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private LJHBMNCDKEI <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private TaskAwaiter<LJHBMNCDKEI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public LIIIIAIJDCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x603A730", Offset = "0x6039B30", VA = "0x18603A730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class CGPAIDNFPNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public MOKCCACHPIF operation;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public CGPAIDNFPNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x60365D0", Offset = "0x60359D0", VA = "0x1860365D0")]
		internal object LBKFKOOEBIK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class OMJHKDCCOIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public MOKCCACHPIF operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public PFDOPPLKEEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private CGPAIDNFPNM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private CPMEPPENFLB<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <timerScope>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private Task <task>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public OMJHKDCCOIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x603B3E0", Offset = "0x603A7E0", VA = "0x18603B3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class HAOOBPOFFFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public LJHBMNCDKEI request;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public HAOOBPOFFFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6038260", Offset = "0x6037660", VA = "0x186038260")]
		internal object LELBOLLGOKL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class HOLMLNNEGAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public LJHBMNCDKEI request;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public HOLMLNNEGAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x60382C0", Offset = "0x60376C0", VA = "0x1860382C0")]
		internal object BKPDDHIBKOO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private EEMPEMCEAHC MDIBAOPLIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private CPDGGGDCIDJ PGGCGJPGJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private ACHJPEIIGFP JDCHGNNFHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private LLOOMDABLJB BJCOHHALCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private BOEFLMAPNBA COPLMJPOHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private TaskCompletionSource<PMDGAPKKPNC> NGCKKAACOAO;

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x27E9520", Offset = "0x27E8920", VA = "0x1827E9520", Slot = "7")]
	public void MHIDNOPDKCM(EEMPEMCEAHC MDIBAOPLIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x27E8A10", Offset = "0x27E7E10", VA = "0x1827E8A10", Slot = "6")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KKGEIEGHOLL))]
	public Task<PMDGAPKKPNC> ELPNLGNABAM(CancellationToken DCLLKACCGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x27E97A0", Offset = "0x27E8BA0", VA = "0x1827E97A0", Slot = "4")]
	public void NLECADFPKAK(LJHBMNCDKEI FHDJIGKOLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x27E8CD0", Offset = "0x27E80D0", VA = "0x1827E8CD0", Slot = "5")]
	public void HKEHLNBOOMA(LJHBMNCDKEI DJHOEFAPPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x27E8B80", Offset = "0x27E7F80", VA = "0x1827E8B80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JMGNKIJFAEN))]
	private Task FNEJNMFIPGM(LJHBMNCDKEI OALKBFHLHKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x27E9BC0", Offset = "0x27E8FC0", VA = "0x1827E9BC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CNIGLLAGHCM))]
	private Task PNNPCMBDJBC(LJHBMNCDKEI GGJMMDPPLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x27E9600", Offset = "0x27E8A00", VA = "0x1827E9600")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LIIIIAIJDCJ))]
	private Task<MOKCCACHPIF> NKGEENONMMG(LJHBMNCDKEI OALKBFHLHKE, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x27E94A0", Offset = "0x27E88A0", VA = "0x1827E94A0")]
	private HACHIHGCJBL MCNIBEELDDP(LJHBMNCDKEI PKMGPKLHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x27E88A0", Offset = "0x27E7CA0", VA = "0x1827E88A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OMJHKDCCOIK))]
	private Task BJNCDKBMGFB(MOKCCACHPIF CMBFEPDDNLN, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x27E8680", Offset = "0x27E7A80", VA = "0x1827E8680")]
	private MOKCCACHPIF ADMCDAFAAOJ(LJHBMNCDKEI OALKBFHLHKE, HACHIHGCJBL IAGJPJDPHKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x322AE40", Offset = "0x322A240", VA = "0x18322AE40")]
	private T EMMONPIONFL<T>(T AGLCIEKHLEE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x27E90B0", Offset = "0x27E84B0", VA = "0x1827E90B0")]
	private MOKCCACHPIF JCIPJEJLBLL(LJHBMNCDKEI OALKBFHLHKE, HACHIHGCJBL IAGJPJDPHKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public PFDOPPLKEEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal interface KPCOCGHFKKD
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	TimeSpan MBGNHEDAGJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	TimeSpan DFEFIHBECNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	TimeSpan BOFIOOGNHGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TimeSpan IJBAIOBIFIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool FDBEFABDGIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool ECLMLHJDJBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool JHFNDLJPAPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int KDOHDJBLMIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool MNDNKJJNIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal interface JOJINJHEHOK : BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OPAHMEFPIDH> CDOCIMOJEOO(CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, GIFLFLGKBIH EJIIHIOHIAP, CancellationToken ODBDCIFDKPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal class KFAKHNFKAHI : APHHPEMPPDG
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class IKFAAKHMNFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public KFAKHNFKAHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public Matchmaking.IBHEPKGFOAP result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public GIFLFLGKBIH newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public IKFAAKHMNFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3BFB910", Offset = "0x3BFAD10", VA = "0x183BFB910")]
		internal object EEGFLEECBLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3BFBB00", Offset = "0x3BFAF00", VA = "0x183BFBB00")]
		internal object NLGEPLKKLMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3BFBA60", Offset = "0x3BFAE60", VA = "0x183BFBA60")]
		internal object MNCDOBENLJJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class INBODKKFKKN : IAsyncStateMachine
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
		public KFAKHNFKAHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private IKFAAKHMNFH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private Matchmaking.IBHEPKGFOAP <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TaskAwaiter<Matchmaking.IBHEPKGFOAP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public INBODKKFKKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3BFBD80", Offset = "0x3BFB180", VA = "0x183BFBD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly EEMPEMCEAHC MDIBAOPLIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private readonly ENPHMEADLAM EOPIGBOAJOB;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private KDNPAEGHDGO CLDGCANEAEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x27DA5B0", Offset = "0x27D99B0", VA = "0x1827DA5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8C50F0", Offset = "0x8C44F0", VA = "0x1808C50F0")]
	public KFAKHNFKAHI(EEMPEMCEAHC MDIBAOPLIIF, ENPHMEADLAM EOPIGBOAJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x27DA440", Offset = "0x27D9840", VA = "0x1827DA440", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(INBODKKFKKN))]
	public Task<bool> HIGMEHHEGFO(CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal interface CALDLKINOJJ : BCAHAPDOMNP, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal interface APHHPEMPPDG
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> HIGMEHHEGFO(CancellationToken ODBDCIFDKPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public interface JMHAFANCMMG
{
	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBLFOADIGOF(GIAKOKFGLOP JOIDCIILCDL);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LGJMCJHFBNJ(GIAKOKFGLOP JOIDCIILCDL);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ODAPBLLDNMI(GIAKOKFGLOP JOIDCIILCDL);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KALLLEEGBCI(GIAKOKFGLOP JOIDCIILCDL);
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class GIAKOKFGLOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public readonly GIFLFLGKBIH GJBFFBDOGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private Dictionary<string, string> JGBBKAOGFLC;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public CPMEPPENFLB<string> BGAIFEJMMLI
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD60", Offset = "0x8BB160", VA = "0x1808BBD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x8C4170", Offset = "0x8C3570", VA = "0x1808C4170")]
	public GIAKOKFGLOP(GIFLFLGKBIH JMCLCDJKMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x2099CB0", Offset = "0x20990B0", VA = "0x182099CB0")]
	public GIAKOKFGLOP CMLPKJHJCCG(string PMMAAICOJOP, string AGLCIEKHLEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2099D90", Offset = "0x2099190", VA = "0x182099D90")]
	public bool HAFKPIAEIFA(out IEnumerable<KeyValuePair<string, string>> GIDJDFFHDBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x2099E30", Offset = "0x2099230", VA = "0x182099E30")]
	public GIAKOKFGLOP IGFDGGMCMMM(CPMEPPENFLB<string> INJHLEJHFLF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class EKOEOEFINDB : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x1CC7170", Offset = "0x1CC6570", VA = "0x181CC7170")]
	public EKOEOEFINDB(string FHDJIGKOLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public interface KDNPAEGHDGO
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	GIFLFLGKBIH MNNKKGKMEOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	MFKMLKAPGOD INHJKCNMIJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	LENKAENGBGK ADCFIBJMJJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool KEENJAGAOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool BNLFCJANNCO
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int EJHDEDBAHOA
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action GCDKOAEBIBF;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event Action<int> EJAGHFGJAOB;

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PAKLNANKIPP();

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.HPGFHIEHHDN> LPCOIGDIKHI(long PNFBLDJLDCL, [Optional] CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<Matchmaking.IBHEPKGFOAP> AGCHODCNCKF();

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task HEKBPNDOKLA();

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(GIFLFLGKBIH, LOBICFHPEOG) EHKIBABELFD();

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "15")]
	BJJLKBCPMFA DAOBKBAGMAG();

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HGDPBJACHDF(long PNFBLDJLDCL);
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal interface LLOOMDABLJB : BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LJHBMNCDKEI> GJJMOGDLJBK(LJHBMNCDKEI OALKBFHLHKE, HACHIHGCJBL IAGJPJDPHKP, CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<LJHBMNCDKEI> OOGHBHPNMGG(CancellationToken ODBDCIFDKPJ, HACHIHGCJBL IAGJPJDPHKP);

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CPBDLHAFGBN HHNEIDIDFEC(MOKCCACHPIF MILMGFBGPKK, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG);

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CPBDLHAFGBN LLCLINPEMPG(MOKCCACHPIF MILMGFBGPKK, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class HDKIEEIBDDJ : EEMPEMCEAHC, CFJAIONOPOH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class DAJNKBOFAGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public AsyncTaskMethodBuilder<EIDINADMANL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public MANOJAHNIFE autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public HDKIEEIBDDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private EIDINADMANL <canRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private EIDINADMANL <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private TaskAwaiter<EIDINADMANL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public DAJNKBOFAGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x3A53A50", Offset = "0x3A52E50", VA = "0x183A53A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class LJEOIAKKIKH : IAsyncStateMachine
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
		public HDKIEEIBDDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private EIDINADMANL <canRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public LJEOIAKKIKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x3A5C2A0", Offset = "0x3A5B6A0", VA = "0x183A5C2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class OEIIIGOJJHL : IEnumerable<BCAHAPDOMNP>, IEnumerable, IEnumerator<BCAHAPDOMNP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private BCAHAPDOMNP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public HDKIEEIBDDJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private BCAHAPDOMNP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x9C1680", Offset = "0x9C0A80", VA = "0x1809C1680")]
		[DebuggerHidden]
		public OEIIIGOJJHL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x3A60FA0", Offset = "0x3A603A0", VA = "0x183A60FA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x3A61420", Offset = "0x3A60820", VA = "0x183A61420", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x3A61380", Offset = "0x3A60780", VA = "0x183A61380", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BCAHAPDOMNP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x3A61380", Offset = "0x3A60780", VA = "0x183A61380", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private readonly CancellationTokenSource FHCPPNFACFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private readonly IFJJAPHPIAE DOJDGHDKCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private bool JOEDCLMPFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private OCLOLLIDAKI BBFJLPDCPEI;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public BOEFLMAPNBA KKOAFDPGPJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x9E5720", Offset = "0x9E4B20", VA = "0x1809E5720", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x9E3C00", Offset = "0x9E3000", VA = "0x1809E3C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public BJJHOFECDMP MCFFHKHJCFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xA48C70", Offset = "0xA48070", VA = "0x180A48C70", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xA490F0", Offset = "0xA484F0", VA = "0x180A490F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public ENPHMEADLAM OLJLNILBIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x997FD0", Offset = "0x9973D0", VA = "0x180997FD0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xABA5D0", Offset = "0xAB99D0", VA = "0x180ABA5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public MHLDLCLJDPN EEKDFFKICKH
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8CBFE0", Offset = "0x8CB3E0", VA = "0x1808CBFE0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8CBFF0", Offset = "0x8CB3F0", VA = "0x1808CBFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DHECAGBHHPN NPLMACOEMIE
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x99C4F0", Offset = "0x99B8F0", VA = "0x18099C4F0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x999290", Offset = "0x998690", VA = "0x180999290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public PMICAKGHNFF KJPMPIBKADI
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x9B7D80", Offset = "0x9B7180", VA = "0x1809B7D80", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xA48FA0", Offset = "0xA483A0", VA = "0x180A48FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DLMGJNBMKMD HLNNEKMKDBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8F8D80", Offset = "0x8F8180", VA = "0x1808F8D80", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8F8760", Offset = "0x8F7B60", VA = "0x1808F8760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public CPDGGGDCIDJ EOKCDACKEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8F8470", Offset = "0x8F7870", VA = "0x1808F8470", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8CB0F0", Offset = "0x8CA4F0", VA = "0x1808CB0F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public AMIKADHECIN ELPLHPILNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x9B8210", Offset = "0x9B7610", VA = "0x1809B8210", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xB9E0E0", Offset = "0xB9D4E0", VA = "0x180B9E0E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public KBGCMGGOIPA IKOLLGJPEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x8CA060", Offset = "0x8C9460", VA = "0x1808CA060", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x8F8480", Offset = "0x8F7880", VA = "0x1808F8480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public GONAGPLJKCD KCJFDDAFHKO
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8BE5D0", Offset = "0x8BD9D0", VA = "0x1808BE5D0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x822D70", Offset = "0x822170", VA = "0x180822D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public OMFCKGEPCHJ OAHBPGGEFON
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xAFBF00", Offset = "0xAFB300", VA = "0x180AFBF00", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xAFBEF0", Offset = "0xAFB2F0", VA = "0x180AFBEF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public LJDEPIOJEBG CDCGCBELMFL
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xA66160", Offset = "0xA65560", VA = "0x180A66160", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xD55B90", Offset = "0xD54F90", VA = "0x180D55B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public JPPKFCCAFEC LHHJOOIPNDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xA36AC0", Offset = "0xA35EC0", VA = "0x180A36AC0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xC1F1A0", Offset = "0xC1E5A0", VA = "0x180C1F1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public CALDLKINOJJ NMEPCHHGEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xA31EB0", Offset = "0xA312B0", VA = "0x180A31EB0", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xA32280", Offset = "0xA31680", VA = "0x180A32280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public NKEECIDEDCF FAJCCLOMJIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x9E36F0", Offset = "0x9E2AF0", VA = "0x1809E36F0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xB617B0", Offset = "0xB60BB0", VA = "0x180B617B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public ACHJPEIIGFP EMKBIANIKOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x973B50", Offset = "0x972F50", VA = "0x180973B50", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xB61820", Offset = "0xB60C20", VA = "0x180B61820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public KDHEPAIBMDB EMOKMANLKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x997310", Offset = "0x996710", VA = "0x180997310", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x997010", Offset = "0x996410", VA = "0x180997010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public JOJINJHEHOK KDJJIMOGNFI
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x9972F0", Offset = "0x9966F0", VA = "0x1809972F0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x996B50", Offset = "0x995F50", VA = "0x180996B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public LLOOMDABLJB LNHDAEDAPCK
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x9870C0", Offset = "0x9864C0", VA = "0x1809870C0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xC5AD70", Offset = "0xC5A170", VA = "0x180C5AD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public CMMFFPEJGAH NECFMCEPFKG
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x9870B0", Offset = "0x9864B0", VA = "0x1809870B0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xCA6520", Offset = "0xCA5920", VA = "0x180CA6520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public FGCGBIIICGK BDENEBCFMNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x9F3C80", Offset = "0x9F3080", VA = "0x1809F3C80", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xB0D490", Offset = "0xB0C890", VA = "0x180B0D490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public JMHAFANCMMG FMKIGDAMDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xA65150", Offset = "0xA64550", VA = "0x180A65150", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xB0C7A0", Offset = "0xB0BBA0", VA = "0x180B0C7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public MPCEBLPGLPN KJKCFOLNFDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xB1C970", Offset = "0xB1BD70", VA = "0x180B1C970", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xA31340", Offset = "0xA30740", VA = "0x180A31340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public CBKJPDEIBGD KBECOACGOPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xB1C840", Offset = "0xB1BC40", VA = "0x180B1C840", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xA2B180", Offset = "0xA2A580", VA = "0x180A2B180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public KPCOCGHFKKD NJCKLCOHLLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA21A10", Offset = "0xA20E10", VA = "0x180A21A10", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xB0ACB0", Offset = "0xB0A0B0", VA = "0x180B0ACB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public POPIPMMDBCG OCHDHFKKIPC
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x99C2F0", Offset = "0x99B6F0", VA = "0x18099C2F0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xB0B2E0", Offset = "0xB0A6E0", VA = "0x180B0B2E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public KMGCJHHGHIL BGCLAKNGEKO
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xB581D0", Offset = "0xB575D0", VA = "0x180B581D0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public FEEJGIIJOED NOAPKNALKGL
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x9B7860", Offset = "0x9B6C60", VA = "0x1809B7860", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public MPHGBLPIAOI NPNNFNBAAEK
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x98A210", Offset = "0x989610", VA = "0x18098A210", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public LOBICFHPEOG LAAKMJOKDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x9B7B70", Offset = "0x9B6F70", VA = "0x1809B7B70", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xB6F800", Offset = "0xB6EC00", VA = "0x180B6F800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private bool DAJFJDJCNNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x209C920", Offset = "0x209BD20", VA = "0x18209C920", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	private bool GOLEMIOIKAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x209CBC0", Offset = "0x209BFC0", VA = "0x18209CBC0", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	private CancellationToken KNKBBPJMOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x209C930", Offset = "0x209BD30", VA = "0x18209C930", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private IFJJAPHPIAE FIEBBGPMNAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	private event Action OFHIPLCDPDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x209CC40", Offset = "0x209C040", VA = "0x18209CC40", Slot = "36")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x209CA70", Offset = "0x209BE70", VA = "0x18209CA70", Slot = "37")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	private event OMKIMPBDNJP NIABACGCOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x209C320", Offset = "0x209B720", VA = "0x18209C320", Slot = "38")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x209C780", Offset = "0x209BB80", VA = "0x18209C780", Slot = "39")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	private event OMKIMPBDNJP HNOKHJOHFAH
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x209C7E0", Offset = "0x209BBE0", VA = "0x18209C7E0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x209C9C0", Offset = "0x209BDC0", VA = "0x18209C9C0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	private event OMKIMPBDNJP ECDCCDFGCDA
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x209C380", Offset = "0x209B780", VA = "0x18209C380", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x209CE10", Offset = "0x209C210", VA = "0x18209CE10", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	private event Action<EALLAFIMFMG, bool> BBOMEPCEGNL
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x209C720", Offset = "0x209BB20", VA = "0x18209C720", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x209C3E0", Offset = "0x209B7E0", VA = "0x18209C3E0", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0xB6F800", Offset = "0xB6EC00", VA = "0x180B6F800", Slot = "35")]
	public void JDCHOBFJICN(LOBICFHPEOG BMOFCMDGDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x209CE70", Offset = "0x209C270", VA = "0x18209CE70")]
	[UnityEngine.Scripting.Preserve]
	internal HDKIEEIBDDJ([JLJFOFICIEA(null)] IFJJAPHPIAE DOJDGHDKCLO, [JLJFOFICIEA(null)] BOEFLMAPNBA COPLMJPOHBN, [JLJFOFICIEA(null)] BJJHOFECDMP BFAPBMMCPJO, [JLJFOFICIEA(null)] ENPHMEADLAM EOPIGBOAJOB, [JLJFOFICIEA(null)] MHLDLCLJDPN OPGNKMGDAGI, [JLJFOFICIEA(null)] DHECAGBHHPN GIECCKMINLC, [JLJFOFICIEA(null)] PMICAKGHNFF MJJNPNJOEDI, [JLJFOFICIEA(null)] DLMGJNBMKMD COFHFLANDJM, [JLJFOFICIEA(null)] CPDGGGDCIDJ PGGCGJPGJBP, [JLJFOFICIEA(null)] AMIKADHECIN DBHHNCOKDFK, [JLJFOFICIEA(null)] KBGCMGGOIPA PBBOHGPNEEF, [JLJFOFICIEA(null)] GONAGPLJKCD FDHKLBFGNFO, [JLJFOFICIEA(null)] OMFCKGEPCHJ HGCAHGIMKEG, [JLJFOFICIEA(null)] LJDEPIOJEBG EJAEMGEIFGC, [JLJFOFICIEA(null)] JPPKFCCAFEC KFJODKFGLND, [JLJFOFICIEA(null)] CALDLKINOJJ FICJPGANKCN, [JLJFOFICIEA(null)] NKEECIDEDCF JBIMIPFGFOM, [JLJFOFICIEA(null)] ACHJPEIIGFP JDCHGNNFHEJ, [JLJFOFICIEA(null)] KDHEPAIBMDB JOPHLCCJCKC, [JLJFOFICIEA(null)] JOJINJHEHOK HEINNPALGHO, [JLJFOFICIEA(null)] CMMFFPEJGAH NCHOAAMOKAD, [JLJFOFICIEA(null)] LLOOMDABLJB BJCOHHALCHA, [JLJFOFICIEA(null)] FGCGBIIICGK LBIPEFBIOGK, [JLJFOFICIEA(null)] JMHAFANCMMG PHLMDFMDOEF, [JLJFOFICIEA(null)] MPCEBLPGLPN OPBPDGBFJML, [JLJFOFICIEA(null)] KPCOCGHFKKD PPCPEOGMHIJ, [JLJFOFICIEA(null)] POPIPMMDBCG AGHAEJEABJH, [JLJFOFICIEA(null)] KMGCJHHGHIL DEHPIILCCIC, [JLJFOFICIEA(null)] FEEJGIIJOED CKHBMDCGNND, [JLJFOFICIEA(null)] MPHGBLPIAOI EMDMAKECHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x209CAD0", Offset = "0x209BED0", VA = "0x18209CAD0")]
	private void MHIDNOPDKCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x209C440", Offset = "0x209B840", VA = "0x18209C440", Slot = "54")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x209CA20", Offset = "0x209BE20", VA = "0x18209CA20", Slot = "48")]
	private void JHJPKBPLOIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x209C840", Offset = "0x209BC40", VA = "0x18209C840", Slot = "49")]
	private LJMNFMIEBEA HBJACMMPGJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x209C150", Offset = "0x209B550", VA = "0x18209C150", Slot = "50")]
	private CBINNBJHFGJ AOAMNJNNGEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x209CCA0", Offset = "0x209C0A0", VA = "0x18209CCA0", Slot = "51")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DAJNKBOFAGH))]
	private Task<EIDINADMANL> OMNCMHNGPGE(MANOJAHNIFE FOFGMEHODIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x209C5D0", Offset = "0x209B9D0", VA = "0x18209C5D0", Slot = "52")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LJEOIAKKIKH))]
	private Task EOOEJPIFGLC(CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x209C950", Offset = "0x209BD50", VA = "0x18209C950")]
	[IteratorStateMachine(typeof(OEIIIGOJJHL))]
	private IEnumerable<BCAHAPDOMNP> JBPFEIAOADO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x209C8C0", Offset = "0x209BCC0", VA = "0x18209C8C0")]
	[CompilerGenerated]
	private void HMBLJGEJNLP(BCAHAPDOMNP EGEAFOFCJOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class EJIKJGMGBLM : JOJINJHEHOK, BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class MPBAHBPHFAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public AsyncTaskMethodBuilder<OPAHMEFPIDH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public GIFLFLGKBIH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public EJIKJGMGBLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private long <subRoomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private MFKMLKAPGOD <details>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private MFKMLKAPGOD <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private TaskAwaiter<MFKMLKAPGOD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public MPBAHBPHFAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x3A5E9E0", Offset = "0x3A5DDE0", VA = "0x183A5E9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class MBFDKBLPCGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public MBFDKBLPCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x3A5E210", Offset = "0x3A5D610", VA = "0x183A5E210")]
		internal object PFMOLMMMHHL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class OODCDGFFFDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public AsyncTaskMethodBuilder<MFKMLKAPGOD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public GIFLFLGKBIH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public EJIKJGMGBLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private MBFDKBLPCGI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private MFKMLKAPGOD <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private TaskAwaiter<MFKMLKAPGOD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public OODCDGFFFDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x3A61B40", Offset = "0x3A60F40", VA = "0x183A61B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class HINMDJEMDBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public HINMDJEMDBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xBBE310", Offset = "0xBBD710", VA = "0x180BBE310")]
		internal bool PBEJIBNGGFM(LENKAENGBGK sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	private ENPHMEADLAM EOPIGBOAJOB;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	private static readonly (DJFLKAMMCHF superRoomData, long subRoomDataSaveId) DKBAKONGJIL;

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x2094BC0", Offset = "0x2093FC0", VA = "0x182094BC0", Slot = "5")]
	public void MHIDNOPDKCM(EEMPEMCEAHC MDIBAOPLIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x20944B0", Offset = "0x20938B0", VA = "0x1820944B0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MPBAHBPHFAA))]
	public Task<OPAHMEFPIDH> CDOCIMOJEOO(CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, GIFLFLGKBIH EJIIHIOHIAP, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x2094A00", Offset = "0x2093E00", VA = "0x182094A00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OODCDGFFFDH))]
	private Task<MFKMLKAPGOD> GELKOIPNFFG(GIFLFLGKBIH EJIIHIOHIAP, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x2094370", Offset = "0x2093770", VA = "0x182094370")]
	private OPAHMEFPIDH ABBKMEMMGEG(GIFLFLGKBIH EJIIHIOHIAP, MFKMLKAPGOD FKBFPEMHLED, long LHBCPOODKNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x2094670", Offset = "0x2093A70", VA = "0x182094670")]
	private (DJFLKAMMCHF, long) EOOBDHGCGDH(GIFLFLGKBIH EJIIHIOHIAP, MFKMLKAPGOD FKBFPEMHLED, long LHBCPOODKNA)
	{
		return default((DJFLKAMMCHF, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public EJIKJGMGBLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public interface MHLDLCLJDPN
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool PKGPGFIALAD
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	string DOCFAADANKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CFJFNAKKKCB(Scene MEDMBOHBMLF);

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task HDMDMCCLLFE(BPMAKGGBAAK AFLCKNHODPM, CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task IEGPHFKMKAM();
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[UnityEngine.Scripting.Preserve]
internal sealed class GBDIHFFKNDE : LLOOMDABLJB, BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class FFKHHMCAHBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public LJHBMNCDKEI request;

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public FFKHHMCAHBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x3A567A0", Offset = "0x3A55BA0", VA = "0x183A567A0")]
		internal object MDBOBCCKIIF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class GFCHIDGNELI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public AsyncTaskMethodBuilder<LJHBMNCDKEI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public LJHBMNCDKEI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public HACHIHGCJBL pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public GBDIHFFKNDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private FFKHHMCAHBG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private LJHBMNCDKEI <response>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private LJHBMNCDKEI <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private TaskAwaiter<LJHBMNCDKEI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public GFCHIDGNELI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x3A57BF0", Offset = "0x3A56FF0", VA = "0x183A57BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class JBJKKPIIOIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public AsyncTaskMethodBuilder<LJHBMNCDKEI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public HACHIHGCJBL pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public GBDIHFFKNDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private HGBBKLDKBDP.MPCMOHEDPCH<LJHBMNCDKEI> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private DEOBPIGMHBB <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private TaskAwaiter<DEOBPIGMHBB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JBJKKPIIOIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x3A5A360", Offset = "0x3A59760", VA = "0x183A5A360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class HFCIMAIIOOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public LJHBMNCDKEI request;

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public HFCIMAIIOOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x3A58A40", Offset = "0x3A57E40", VA = "0x183A58A40")]
		internal object CHFEBMLINLA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class AKILJPGIJIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public AsyncTaskMethodBuilder<LJHBMNCDKEI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public LJHBMNCDKEI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public HACHIHGCJBL pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public GBDIHFFKNDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private HFCIMAIIOOK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private FCINIFPDHLP <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private OCNMFANHIPK <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private CancellationToken <masterSwitchCancellationToken>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private bool <sent>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private HGBBKLDKBDP.MPCMOHEDPCH<LJHBMNCDKEI> <result>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private LJHBMNCDKEI <response>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private FCINIFPDHLP <actualMessageKind>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private DEOBPIGMHBB <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private TaskAwaiter<DEOBPIGMHBB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public AKILJPGIJIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x3A50FC0", Offset = "0x3A503C0", VA = "0x183A50FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private BOEFLMAPNBA COPLMJPOHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private CBKJPDEIBGD KIGFCNDCHMN;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	private HGBBKLDKBDP OLKCDCGIEAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x20978A0", Offset = "0x2096CA0", VA = "0x1820978A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x2097E50", Offset = "0x2097250", VA = "0x182097E50", Slot = "8")]
	public void MHIDNOPDKCM(EEMPEMCEAHC MDIBAOPLIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x20976E0", Offset = "0x2096AE0", VA = "0x1820976E0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GFCHIDGNELI))]
	public Task<LJHBMNCDKEI> GJJMOGDLJBK(LJHBMNCDKEI OALKBFHLHKE, HACHIHGCJBL IAGJPJDPHKP, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x2097EE0", Offset = "0x20972E0", VA = "0x182097EE0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JBJKKPIIOIK))]
	public Task<LJHBMNCDKEI> OOGHBHPNMGG(CancellationToken ODBDCIFDKPJ, HACHIHGCJBL IAGJPJDPHKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x2097950", Offset = "0x2096D50", VA = "0x182097950", Slot = "6")]
	public CPBDLHAFGBN HHNEIDIDFEC(MOKCCACHPIF MILMGFBGPKK, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x2097BD0", Offset = "0x2096FD0", VA = "0x182097BD0", Slot = "7")]
	public CPBDLHAFGBN LLCLINPEMPG(MOKCCACHPIF MILMGFBGPKK, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x2097510", Offset = "0x2096910", VA = "0x182097510")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AKILJPGIJIB))]
	private Task<LJHBMNCDKEI> DJHNJFFFIIC(LJHBMNCDKEI OALKBFHLHKE, HACHIHGCJBL IAGJPJDPHKP, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x20976D0", Offset = "0x2096AD0", VA = "0x1820976D0")]
	private static byte[] GANHCCKPAKM(LJHBMNCDKEI FHDJIGKOLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public GBDIHFFKNDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public readonly struct LBEOEJEGOBG<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class HHEEGMMDJNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public AsyncTaskMethodBuilder<ADOGIEMPLPD<LBJGNEPGLFD<TData>, OMNBHFGADPA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public CPMEPPENFLB<string>.PEFDMNJICBO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public LBEOEJEGOBG<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private byte[] <roomDataBytes>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private ADOGIEMPLPD<byte[], OMNBHFGADPA> <res>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private ADOGIEMPLPD<byte[], OMNBHFGADPA> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private TaskAwaiter<ADOGIEMPLPD<byte[], OMNBHFGADPA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public HHEEGMMDJNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x207DDF0", Offset = "0x207D1F0", VA = "0x18207DDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private readonly MCOOKILLDMM<TGetDataArg, TData> PGFDLLBOOHB;

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8BE820", Offset = "0x8BDC20", VA = "0x1808BE820")]
	internal LBEOEJEGOBG(MCOOKILLDMM<TGetDataArg, TData> AEPKLFBJEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x232F0F0", Offset = "0x232E4F0", VA = "0x18232F0F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LBEOEJEGOBG<, >.HHEEGMMDJNL))]
	public Task<ADOGIEMPLPD<LBJGNEPGLFD<TData>, OMNBHFGADPA>> NDPCIDAHDJB(TGetDataArg LBKPMPMCPAG, string DADDALOIDKA, CPMEPPENFLB<string>.PEFDMNJICBO INJHLEJHFLF, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class PMHDCHJCFOP
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x1BD35E0", Offset = "0x1BD29E0", VA = "0x181BD35E0")]
	public static LBEOEJEGOBG<TGetDataArg, TData> NAILOIKCJEC<TGetDataArg, TData>(MCOOKILLDMM<TGetDataArg, TData> AEPKLFBJEML)
	{
		return default(LBEOEJEGOBG<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[UnityEngine.Scripting.Preserve]
internal sealed class EOBOLDFPDOF : KDHEPAIBMDB, BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class BCJIOLNCLNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public PMDGAPKKPNC operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public EOBOLDFPDOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public LJHBMNCDKEI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public BCJIOLNCLNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x3A51CC0", Offset = "0x3A510C0", VA = "0x183A51CC0")]
		internal object LFGMCGNFKOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x3A51B90", Offset = "0x3A50F90", VA = "0x183A51B90")]
		internal object CCHMHMOEHJC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class PDEHLDNHGDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public AsyncTaskMethodBuilder<EIDINADMANL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public LJHBMNCDKEI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public EOBOLDFPDOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private BCJIOLNCLNN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private EIDINADMANL <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private EIDINADMANL <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private TaskAwaiter<EIDINADMANL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public PDEHLDNHGDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x3A62580", Offset = "0x3A61980", VA = "0x183A62580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class GHANNJOFLNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public PMDGAPKKPNC operationType;

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public GHANNJOFLNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x3A58080", Offset = "0x3A57480", VA = "0x183A58080")]
		internal object DOKGGANEOFF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class KIKHMHAMHEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public LJHBMNCDKEI request;

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public KIKHMHAMHEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x3A5BE90", Offset = "0x3A5B290", VA = "0x183A5BE90")]
		internal object AONNKADBCBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x3A5BF90", Offset = "0x3A5B390", VA = "0x183A5BF90")]
		internal object PNPIPEIHNDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x3A5BF10", Offset = "0x3A5B310", VA = "0x183A5BF10")]
		internal object IMIBEDKEPEP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class AGHDJPBNOPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder<EIDINADMANL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public LJHBMNCDKEI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public EOBOLDFPDOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private KIKHMHAMHEE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private EDOOAEOJHDG <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private EIDINADMANL <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private Task <operation>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private (EIDINADMANL validationResult, Task operation) <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private (EIDINADMANL validationResult, Task operation) <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private TaskAwaiter<(EIDINADMANL validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public AGHDJPBNOPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x3A50850", Offset = "0x3A4FC50", VA = "0x183A50850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private BOEFLMAPNBA COPLMJPOHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private FGCGBIIICGK LBIPEFBIOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private ACHJPEIIGFP JDCHGNNFHEJ;

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x2095520", Offset = "0x2094920", VA = "0x182095520", Slot = "5")]
	public void MHIDNOPDKCM(EEMPEMCEAHC MDIBAOPLIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x2094FE0", Offset = "0x20943E0", VA = "0x182094FE0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PDEHLDNHGDL))]
	private Task<EIDINADMANL> DNHPNLDLLDE(LJHBMNCDKEI PKMGPKLHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x20952C0", Offset = "0x20946C0", VA = "0x1820952C0")]
	private bool KAIAIFCMPLL(PMDGAPKKPNC LFJAMNBIHGB, out EIDINADMANL MOOEDNDCGLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x2095150", Offset = "0x2094550", VA = "0x182095150")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AGHDJPBNOPL))]
	private Task<EIDINADMANL> HCHMGAGPMIP(LJHBMNCDKEI OALKBFHLHKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public EOBOLDFPDOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class EEDJJEFGJFJ
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static EIDINADMANL DLEBFLCIOKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x2093DD0", Offset = "0x20931D0", VA = "0x182093DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2093DA0", Offset = "0x20931A0", VA = "0x182093DA0")]
	public static bool ACMAOMNDIGP(this EIDINADMANL NALHFDPHLJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x20940E0", Offset = "0x20934E0", VA = "0x1820940E0")]
	public static EIDINADMANL JJLJECOKLDB(GKAIKMMKGOC CHEKICDCEJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x2094150", Offset = "0x2093550", VA = "0x182094150")]
	public static EIDINADMANL ONKMDDCINNL(IEnumerable<EIDINADMANL> MDDAILDCJGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2093E30", Offset = "0x2093230", VA = "0x182093E30")]
	public static string GDHANFAGPAI(this EIDINADMANL MOOEDNDCGLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[UnityEngine.Scripting.Preserve]
internal sealed class OHPLEFAMMBB : FGCGBIIICGK, BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private DHECAGBHHPN GIECCKMINLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private BOEFLMAPNBA COPLMJPOHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private CPDGGGDCIDJ PGGCGJPGJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private CMMFFPEJGAH NCHOAAMOKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private ENPHMEADLAM EOPIGBOAJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	private OMFCKGEPCHJ HGCAHGIMKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private LJDEPIOJEBG EJAEMGEIFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	private KPCOCGHFKKD PPCPEOGMHIJ;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	private KDNPAEGHDGO CLDGCANEAEH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x27E5750", Offset = "0x27E4B50", VA = "0x1827E5750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	private static EIDINADMANL DLEBFLCIOKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x27E50E0", Offset = "0x27E44E0", VA = "0x1827E50E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x27E5460", Offset = "0x27E4860", VA = "0x1827E5460", Slot = "6")]
	public void MHIDNOPDKCM(EEMPEMCEAHC MDIBAOPLIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x27E55C0", Offset = "0x27E49C0", VA = "0x1827E55C0", Slot = "4")]
	public EIDINADMANL NNLLHDBIDJA(NJNAENGEJEB LHMPIDCIMFG, PMDGAPKKPNC OOOABFDGACF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x27E50F0", Offset = "0x27E44F0", VA = "0x1827E50F0", Slot = "5")]
	public EIDINADMANL IFHKEIBCLAK(NJNAENGEJEB DPIHFNLNBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x27E5450", Offset = "0x27E4850", VA = "0x1827E5450")]
	private static EIDINADMANL JJLJECOKLDB(GKAIKMMKGOC FOGPFBBPCHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public OHPLEFAMMBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public delegate Task FMAOGPLOMFD(AEEBPABFEDL LGMMPALIFIG, CancellationToken AEMEEHLIDCM);
[Cpp2IlInjected.Token(Token = "0x200009C")]
internal interface LJDEPIOJEBG : BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HAEANFCPLML(FMAOGPLOMFD OKLNJEKLLEA);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public interface MPCEBLPGLPN
{
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LLOJDJNKAPF(out IEnumerable<int> KPLDPIOMOPC);

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KGFEBJOJMCM(IBNOLCFAKOG AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BOBKOGKLBBI(IBNOLCFAKOG AEMEEHLIDCM);
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public interface DLFNMMOACKF
{
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IDOILICIEAO(EIDINADMANL NALHFDPHLJO);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal interface KDHEPAIBMDB : BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EIDINADMANL> EMOKMANLKBI(LJHBMNCDKEI PKMGPKLHPLM);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal interface EEMPEMCEAHC : CFJAIONOPOH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	CancellationToken CONPEPNJHAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	IFJJAPHPIAE KAOCOIFFGDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	BOEFLMAPNBA KKOAFDPGPJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	BJJHOFECDMP MCFFHKHJCFK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	ENPHMEADLAM OLJLNILBIHC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	MHLDLCLJDPN EEKDFFKICKH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	DHECAGBHHPN NPLMACOEMIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	PMICAKGHNFF KJPMPIBKADI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	DLMGJNBMKMD HLNNEKMKDBA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	CPDGGGDCIDJ EOKCDACKEPH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	AMIKADHECIN ELPLHPILNFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	KBGCMGGOIPA IKOLLGJPEEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	GONAGPLJKCD KCJFDDAFHKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	OMFCKGEPCHJ OAHBPGGEFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	LJDEPIOJEBG CDCGCBELMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	JPPKFCCAFEC LHHJOOIPNDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	NKEECIDEDCF FAJCCLOMJIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	ACHJPEIIGFP EMKBIANIKOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	KDHEPAIBMDB EMOKMANLKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	JOJINJHEHOK KDJJIMOGNFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	LLOOMDABLJB LNHDAEDAPCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	CMMFFPEJGAH NECFMCEPFKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	FGCGBIIICGK BDENEBCFMNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	JMHAFANCMMG FMKIGDAMDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	MPCEBLPGLPN KJKCFOLNFDP
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	CBKJPDEIBGD KBECOACGOPF
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	KPCOCGHFKKD NJCKLCOHLLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	POPIPMMDBCG OCHDHFKKIPC
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	KMGCJHHGHIL BGCLAKNGEKO
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	FEEJGIIJOED NOAPKNALKGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	MPHGBLPIAOI NPNNFNBAAEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void JDCHOBFJICN(LOBICFHPEOG BMOFCMDGDBO);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal interface GONAGPLJKCD : BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CJCOGKLGNLE();

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MBCJKMLBKKI();

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EIFJDOAKCLM();
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class IHFIOPLEGIE
{
	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x20A0230", Offset = "0x209F630", VA = "0x1820A0230")]
	public static void ABDIFBHBBNC(IFJJAPHPIAE DOJDGHDKCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x20A0430", Offset = "0x209F830", VA = "0x1820A0430")]
	internal static void INEJEJAGBKI(IFJJAPHPIAE DOJDGHDKCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x20A0550", Offset = "0x209F950", VA = "0x1820A0550")]
	internal static void KEKDEDLHPDK(IFJJAPHPIAE DOJDGHDKCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x20A0630", Offset = "0x209FA30", VA = "0x1820A0630")]
	internal static void KEMAECJLJGL(IFJJAPHPIAE DOJDGHDKCLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class MEMGGCDPDOC : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x27DC880", Offset = "0x27DBC80", VA = "0x1827DC880")]
	public MEMGGCDPDOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x27DC870", Offset = "0x27DBC70", VA = "0x1827DC870")]
	public MEMGGCDPDOC(string FHDJIGKOLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal interface BCAHAPDOMNP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MHIDNOPDKCM(EEMPEMCEAHC MDIBAOPLIIF);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public interface ENPHMEADLAM
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	KDNPAEGHDGO CLDGCANEAEH
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	bool GJDPAHDGGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	bool GLHNOJPIHKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool NIOIDNNNMGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool FEFKMOJJKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool BDBFACEIGEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	bool JDNLFCKFPLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	float NOPJGMHDACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event Action<float> GOJOOLMPEFA;

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IFJJAPHPIAE KJBBKCCGPEP(IFJJAPHPIAE CJOBAFBBGDK);

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OBENEJGHEDF(IFJJAPHPIAE DOJDGHDKCLO);

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NFMPOHCJNBD();

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task IAEOAJAJGKB(CPMEPPENFLB<string>.PEFDMNJICBO LOHOMCGFFJN, CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ILJLPIGCOAE(float HJHGEAOCBMB);

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HPACNJACGEO(string PBPMMNLOLHE);

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<JDLIPIMGGDN> FJBBHONJLME();

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable CEADCAHMOPC(object AKPCLGIGABA, JDLIPIMGGDN IDKFBDPGAII);

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(Slot = "10")]
	JEDGOKEIKMD OKNBAGOBLDA(IEnumerable<FEKGKBGNILG> FMKJCDJMOLH);

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HGIGJJOHICK(int BLBLLAALJCA);

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task EDMGEJLJIAF();

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JNJMHMJAFNL();

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool ALMJPBCECPJ();

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task MHHOAPDDCEP(CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task KALEJKKBDPK(CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task<JJIIEOBJIJM> OLKNBEDHDFJ(DateTime MPOMOLCCFCB, CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<bool> JCHAMOLJEBL(CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void IHGBDGDPFKP(string APGKIHJKGDP = "", float EOHBELFFLLO = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(Slot = "22")]
	FOIHEPLEJIL HCDJCBFCNBK(PHHKJAPOHHP OCDPCNGENKJ, NDLJIBMEGPJ FCLAKIBKNNH, DNADIKEEDJF IPKBLGEECJA, IEnumerable<PersistenceView> MHGONBHOMPC, FILJMAGHIDF LPFPIDIGDHB);

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void KMEOOLOAHEL(DNADIKEEDJF IPKBLGEECJA);

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void AFOOENJDNON(FEKGKBGNILG KEHGNKBKDPC, in FOIHEPLEJIL FHFLBNIDGKJ);

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task NBOIINNBFON(DNADIKEEDJF ONGJJDFLIMK, bool AEKPMJCEPPN, CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task FNCGKGCHFPC(CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void JLHHOIKPNOF(long KFHMHOFPIPN, long BCJGCHKGEMF, MFKMLKAPGOD PDHNLEDOMJM, KFJCLNMFLAB PMNEFNCNHDL, DPAKJIPJCJD KFBJJKPIMFK, ICKFPGBDHLK? GGIPAFOEMBC, FEPCCPLBANJ? GMHIHLHOFGA);

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void KPJDKHEHILP(long KFHMHOFPIPN, long BCJGCHKGEMF, FEPCCPLBANJ? GMHIHLHOFGA);

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void CGKDNIONKGD(PersistenceView DKHGGHFFPOO);

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool DGMCCANCDFL(PersistenceView CKAMNJPHKHD);

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool MACBJOEEIGO(FEKGKBGNILG KEHGNKBKDPC, KJEHFDNNDGH MJJKDFGBBEE, out JNLBJEGKLFJ NAKMHGLJJDA);

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task CHJLEHCCCJI(CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void OMJOEEJMEJI();

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(Slot = "34")]
	IDisposable KJPMFKCBBOC();

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void EOEMBBCBMEF(DNADIKEEDJF ONGJJDFLIMK, KJEHFDNNDGH MJJKDFGBBEE);

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<bool> KBBFEFCMEDP(BOEFLMAPNBA COPLMJPOHBN, CancellationToken ODBDCIFDKPJ, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG);

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void GICFJLIJNIM(CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<NGIGNBDICFJ> KOIELHLJCJE(OPCEMAJFPGO OALKBFHLHKE);

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<MFKMLKAPGOD> PKCAKAJHIFI(long KFHMHOFPIPN, bool FOBDMHEFELJ, CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<KFJCLNMFLAB> JEHJHJPJPAN(long KFHMHOFPIPN, long BCJGCHKGEMF, long APEDKGLOCFJ, CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<AJOBOMJDCOM> DHGMHNDNJOI(string IGLBCBOECHI, CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<AJOBOMJDCOM> PEGJOLBOLDJ(string IGLBCBOECHI, long KFHMHOFPIPN, long BCJGCHKGEMF, string FFEMBJOCHMB, FIKFCBBEEGH.BHMDIAHIKII LGMMPALIFIG, FIKFCBBEEGH.BHMDIAHIKII AAOHIBIMLID, int NKHLLKFKDAM);

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(Slot = "44")]
	bool JLGKCFBLOKL();

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool NDDJBFCPDJG();

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool JEEDGGAPPAB(IEnumerable<JNLBJEGKLFJ> CHBPKKDHNDM);

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void PNPAAEOOHJP(List<GameObject> AJHBCDDHJPF);

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float PDOHHPJHOEP();

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<Scene> MMLDLIFDOIK(string HGLBIHJJLGC, LoadSceneMode MMIFFMHGFEA, bool FPLFNEBCKDB, CPMEPPENFLB<string>.PEFDMNJICBO INJHLEJHFLF);

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void MFJDFKIPKIM();

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void FJDLLGFKIPL(bool OMIGIJBCKAP);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void HJJLMCBDFGB(GIFLFLGKBIH LKMLKICKHPO);

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "58")]
	Task EOCDFAOEGGK(CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "59")]
	Task CEKAGILOANJ(CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(Slot = "60")]
	Task GGBADNIODEF(CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(Slot = "61")]
	IDisposable JAJBEHIGGKE();

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "62")]
	FPALKFHNKOB FAENHMAMADG();

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Task FIPDDEDFKCM(CancellationToken ODBDCIFDKPJ);
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public interface FPALKFHNKOB
{
	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NHHBKHDDICG(CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PAHIDKIOCLH(CancellationToken ODBDCIFDKPJ);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct FOIHEPLEJIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public HashSet<int> COABMFHJBLL;
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public enum JJIIEOBJIJM : byte
{
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	No,
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct PHHKJAPOHHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public string EHCJGHMMCGE;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal static class CBHDJNBHDNN
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class IDJHJONAAEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public CPMEPPENFLB<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public IDJHJONAAEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x27D4C40", Offset = "0x27D4040", VA = "0x1827D4C40")]
		internal object FCGIBJPJPCO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x20895F0", Offset = "0x20889F0", VA = "0x1820895F0")]
	public static CPMEPPENFLB<string> PEDPCDMMAMM(EHKEPJIBENP IGCLICKKCHJ, [Optional] string EAECOJLBJDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x2089520", Offset = "0x2088920", VA = "0x182089520")]
	public static void NACOGEFPAAA(CPMEPPENFLB<string> INJHLEJHFLF, EHKEPJIBENP IGCLICKKCHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x2089440", Offset = "0x2088840", VA = "0x182089440")]
	public static string CAAOODALJKI(LJHBMNCDKEI PKMGPKLHPLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[UnityEngine.Scripting.Preserve]
internal class JPEGKINNOOI : LJDEPIOJEBG, BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class FNDJDBGIJOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public AEEBPABFEDL roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public JPEGKINNOOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private Func<CancellationToken, List<Task>> <taskGenerator>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public FNDJDBGIJOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x3BF6DA0", Offset = "0x3BF61A0", VA = "0x183BF6DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class JJOHJGHLGCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public JPEGKINNOOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public AEEBPABFEDL roomData;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JJOHJGHLGCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x3BFDAD0", Offset = "0x3BFCED0", VA = "0x183BFDAD0")]
		internal List<Task> GFILNFLOEEC(CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class LBKEMNAIPNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public FMAOGPLOMFD taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public AEEBPABFEDL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public JPEGKINNOOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public LBKEMNAIPNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x3BFEF80", Offset = "0x3BFE380", VA = "0x183BFEF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class LAEENFNODDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public JPEGKINNOOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public LAEENFNODDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x3BFECA0", Offset = "0x3BFE0A0", VA = "0x183BFECA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private readonly HashSet<FMAOGPLOMFD> PPIGEGNBKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private BJJHOFECDMP BFAPBMMCPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private EEMPEMCEAHC MDIBAOPLIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private JDLIPIMGGDN MBEDHHIHEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private JFONFNJKMKB OJGHCMPEKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private IDisposable CFPOMDHKNJO;

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x20A5140", Offset = "0x20A4540", VA = "0x1820A5140", Slot = "5")]
	public void MHIDNOPDKCM(EEMPEMCEAHC MDIBAOPLIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x20A4A00", Offset = "0x20A3E00", VA = "0x1820A4A00", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x20A4C10", Offset = "0x20A4010", VA = "0x1820A4C10", Slot = "4")]
	public bool HAEANFCPLML(FMAOGPLOMFD OKLNJEKLLEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x20A4890", Offset = "0x20A3C90", VA = "0x1820A4890")]
	private void DPKNEBOALDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x20A4C70", Offset = "0x20A4070", VA = "0x1820A4C70")]
	private void JOPKNNBPMPJ(AEEBPABFEDL LGMMPALIFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x20A4ED0", Offset = "0x20A42D0", VA = "0x1820A4ED0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FNDJDBGIJOB))]
	private Task LDIPFHIBBMD(AEEBPABFEDL LGMMPALIFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x20A4B30", Offset = "0x20A3F30", VA = "0x1820A4B30")]
	private Func<CancellationToken, List<Task>> GFDHBPHFDEA(AEEBPABFEDL LGMMPALIFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x20A5580", Offset = "0x20A4980", VA = "0x1820A5580")]
	private List<Task> OLAIOHKBDNJ(AEEBPABFEDL LGMMPALIFIG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x20A53E0", Offset = "0x20A47E0", VA = "0x1820A53E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LBKEMNAIPNF))]
	private Task MIGABBKMGGP(FMAOGPLOMFD NGNIPMJCNIF, AEEBPABFEDL CLCAIFLMLCJ, CancellationToken AEMEEHLIDCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x20A5020", Offset = "0x20A4420", VA = "0x1820A5020")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LAEENFNODDH))]
	private Task LMKNHAFPBLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x20A4A80", Offset = "0x20A3E80", VA = "0x1820A4A80")]
	private void EIFJDOAKCLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x20A5AA0", Offset = "0x20A4EA0", VA = "0x1820A5AA0")]
	public JPEGKINNOOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal interface CPDGGGDCIDJ : BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000086")]
	bool PMGCPCIJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Task KPJOGEDKMAL
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CBNHHCBAGEG(Task NOKNMHIKNGD, string MMKIFNMGBAH);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal class FMPDDMGEFLD : APHHPEMPPDG
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class MEOKJIJEDNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public FMPDDMGEFLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public MEOKJIJEDNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x3A5E2C0", Offset = "0x3A5D6C0", VA = "0x183A5E2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	private readonly EEMPEMCEAHC MDIBAOPLIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	private readonly ENPHMEADLAM EOPIGBOAJOB;

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x8C50F0", Offset = "0x8C44F0", VA = "0x1808C50F0")]
	public FMPDDMGEFLD(EEMPEMCEAHC MDIBAOPLIIF, ENPHMEADLAM EOPIGBOAJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x2096A70", Offset = "0x2095E70", VA = "0x182096A70", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MEOKJIJEDNH))]
	public Task<bool> HIGMEHHEGFO(CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x2096BE0", Offset = "0x2095FE0", VA = "0x182096BE0")]
	[CompilerGenerated]
	private object JJBAEFOJEMK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public class AJDFINNCFND : AKAIENANBAO, DHECAGBHHPN, FDNICCPNGND, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class ABFJNBEBOFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public EIDINADMANL result;

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public ABFJNBEBOFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x27CFC30", Offset = "0x27CF030", VA = "0x1827CFC30")]
		internal object PCOKMMGOJFJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x2086B90", Offset = "0x2085F90", VA = "0x182086B90")]
	[UnityEngine.Scripting.Preserve]
	public AJDFINNCFND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2086A70", Offset = "0x2085E70", VA = "0x182086A70", Slot = "8")]
	public EIDINADMANL GDMJKMOJHIM(NJNAENGEJEB DPIHFNLNBDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public interface POPIPMMDBCG
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	bool GECKPANIOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	string AJEBNMCFAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EHLNCNOMJNM();

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OMBNINLPKPC NHLFMLMMFIK(long PNFBLDJLDCL);

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MCOOKILLDMM<DJFLKAMMCHF, JEDGOKEIKMD> CDPLHBFKPAL(long PNFBLDJLDCL);

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MCOOKILLDMM<DJFLKAMMCHF, DNADIKEEDJF> FHMIIGEGKEC(long PNFBLDJLDCL);

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MCOOKILLDMM<long, LLLDIPNEBLP> GFPKHPAJMLM();

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> CEGCKFCHHIM(byte[] OOGBKJBIGHG, byte[] AAOHIBIMLID, CancellationToken ODBDCIFDKPJ);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[UnityEngine.Scripting.Preserve]
internal sealed class GNDAKEEFNKP : JPPKFCCAFEC, BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class AOBAKOOOCNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public AOBAKOOOCNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x3A51B30", Offset = "0x3A50F30", VA = "0x183A51B30")]
		internal object JOAKDLMOOND()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class LODAOMAJLLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public LODAOMAJLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x3A5E1B0", Offset = "0x3A5D5B0", VA = "0x183A5E1B0")]
		internal object IJGCOOCNJAP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private sealed class EJNHBOLGLDG
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public EJNHBOLGLDG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class HCCDIKECNEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public HCCDIKECNEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x3A589E0", Offset = "0x3A57DE0", VA = "0x183A589E0")]
		internal object CECLICOMOFN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class HAFCMBBAOFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public HAFCMBBAOFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x3A58980", Offset = "0x3A57D80", VA = "0x183A58980")]
		internal object NHCDMNJNGAN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private readonly Dictionary<Guid, ALOIGJIMAOG> KFJODKFGLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private readonly TimeSpan HCGEKGKJFDB;

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "9")]
	public void MHIDNOPDKCM(EEMPEMCEAHC MDIBAOPLIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x209B1F0", Offset = "0x209A5F0", VA = "0x18209B1F0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x209B700", Offset = "0x209AB00", VA = "0x18209B700", Slot = "4")]
	public EDOOAEOJHDG NNFBEGDMHOD(Guid JIDMDNKJFGM)
	{
		return default(EDOOAEOJHDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x209B290", Offset = "0x209A690", VA = "0x18209B290", Slot = "5")]
	public bool LOBOHMPHNJE(Guid JIDMDNKJFGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x209AC50", Offset = "0x209A050", VA = "0x18209AC50", Slot = "6")]
	public bool BJBEDBPABPI(Guid JIDMDNKJFGM, Task POLOIIHCKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x209AFA0", Offset = "0x209A3A0", VA = "0x18209AFA0", Slot = "7")]
	public bool DFCPLDPHOCE(Guid JIDMDNKJFGM, EIDINADMANL NALHFDPHLJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x209B200", Offset = "0x209A600", VA = "0x18209B200", Slot = "8")]
	public Task<(EIDINADMANL, Task)> JGHEMPCGCOH(Guid JIDMDNKJFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x209B4C0", Offset = "0x209A8C0", VA = "0x18209B4C0")]
	private void MPNGMFCNMLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x209B920", Offset = "0x209AD20", VA = "0x18209B920")]
	public GNDAKEEFNKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public class EKEHOBMEMGJ : AKAIENANBAO, PMICAKGHNFF, FDNICCPNGND, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class KGCJOFINDCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public EIDINADMANL result;

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public KGCJOFINDCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x3A5BCA0", Offset = "0x3A5B0A0", VA = "0x183A5BCA0")]
		internal object BOCIHHMPLIE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x2086B90", Offset = "0x2085F90", VA = "0x182086B90")]
	[UnityEngine.Scripting.Preserve]
	public EKEHOBMEMGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x2094D90", Offset = "0x2094190", VA = "0x182094D90", Slot = "8")]
	public EIDINADMANL BGHFAMBJLKL(NJNAENGEJEB DOHCAABJNHK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal interface OMFCKGEPCHJ : BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	TaskStatus EBMCAGNBPHG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LCDFNNIOHJB(GIFLFLGKBIH EJIIHIOHIAP, LOBICFHPEOG GEAJEHCANLE, CancellationToken KPKCFPJKMGP);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal static class OACNGHEGOIB
{
	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x27E2120", Offset = "0x27E1520", VA = "0x1827E2120")]
	public static bool JFLKAKAGLOF(this OMFCKGEPCHJ HGCAHGIMKEG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal static class EJKBMGGEFIA
{
	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x2094D00", Offset = "0x2094100", VA = "0x182094D00")]
	public static bool JDCKOIFMLAL(this GIFLFLGKBIH JMCLCDJKMBJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[UnityEngine.Scripting.Preserve]
internal class KCJHAIIKAAC : GONAGPLJKCD, BCAHAPDOMNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class MKNCLEBMLIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public KCJHAIIKAAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public MKNCLEBMLIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x3C009C0", Offset = "0x3BFFDC0", VA = "0x183C009C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class GNIGJFEHCMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public KCJHAIIKAAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private bool <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public GNIGJFEHCMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x3BF83E0", Offset = "0x3BF77E0", VA = "0x183BF83E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class NGMBKNHCIKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public NGMBKNHCIKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x3C01A80", Offset = "0x3C00E80", VA = "0x183C01A80")]
		internal object CIONEAMNNMD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class MHKAPFFFNLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public KCJHAIIKAAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private NGMBKNHCIKA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private APHHPEMPPDG <provider>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private bool <success>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private bool <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private Exception <ex>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public MHKAPFFFNLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x3BFFE30", Offset = "0x3BFF230", VA = "0x183BFFE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class BBCLEHOMNNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public BBCLEHOMNNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x3BF2920", Offset = "0x3BF1D20", VA = "0x183BF2920")]
		internal object BAIKFFEBEEM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	private EEMPEMCEAHC MDIBAOPLIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	private ENPHMEADLAM EOPIGBOAJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	private APHHPEMPPDG[] NODOFAIMCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	private CancellationTokenSource OCLAFKPHAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	private int OHDEDCMGOBB;

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x27D9FB0", Offset = "0x27D93B0", VA = "0x1827D9FB0", Slot = "7")]
	public void MHIDNOPDKCM(EEMPEMCEAHC MDIBAOPLIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x27D9710", Offset = "0x27D8B10", VA = "0x1827D9710", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x27D9720", Offset = "0x27D8B20", VA = "0x1827D9720", Slot = "6")]
	public void EIFJDOAKCLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x27D9ED0", Offset = "0x27D92D0", VA = "0x1827D9ED0", Slot = "5")]
	public void MBCJKMLBKKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x27D9380", Offset = "0x27D8780", VA = "0x1827D9380", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MKNCLEBMLIL))]
	public Task CJCOGKLGNLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x27D9A70", Offset = "0x27D8E70", VA = "0x1827D9A70")]
	private void KLGAACDKFBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x27D95C0", Offset = "0x27D89C0", VA = "0x1827D95C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GNIGJFEHCMD))]
	private Task DIHLNJAPLMP(CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x27D9D40", Offset = "0x27D9140", VA = "0x1827D9D40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MHKAPFFFNLM))]
	private Task<bool> LIFFNFGPKJK(int BNOAGGNAMKG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x27DA030", Offset = "0x27D9430", VA = "0x1827DA030")]
	private void NPELAMADKAK(int BNOAGGNAMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x27D9830", Offset = "0x27D8C30", VA = "0x1827D9830")]
	private void HCCAAMFOCOC(int BNOAGGNAMKG, bool PKEPEKOBHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x27D9930", Offset = "0x27D8D30", VA = "0x1827D9930")]
	private void HJLPGDFPNFC(int BNOAGGNAMKG, Exception DEFKCOPBBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x27D94A0", Offset = "0x27D88A0", VA = "0x1827D94A0")]
	private void DCCPPKFCLEP(CancellationToken ODBDCIFDKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x27DA1B0", Offset = "0x27D95B0", VA = "0x1827DA1B0")]
	public KCJHAIIKAAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal static class EKJIKJKLEPN
{
	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x2094FC0", Offset = "0x20943C0", VA = "0x182094FC0")]
	public static void LMIPADCHFJP(this BOEFLMAPNBA COPLMJPOHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2094FD0", Offset = "0x20943D0", VA = "0x182094FD0")]
	public static void MLLLLBFJNAJ(this BOEFLMAPNBA COPLMJPOHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x2094EB0", Offset = "0x20942B0", VA = "0x182094EB0")]
	private static void ANDNKFBHEJK(this BOEFLMAPNBA COPLMJPOHBN, bool MOGNIHLGAFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public struct PGIFBHEGEML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public readonly DDBGEGLAAFB DNBFKGHHIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public readonly string HIMBPJNOJNF;

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x27E9DB0", Offset = "0x27E91B0", VA = "0x1827E9DB0")]
	public PGIFBHEGEML(string MBJENEEGCCM, DDBGEGLAAFB JPJMOKBNPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x27E9D10", Offset = "0x27E9110", VA = "0x1827E9D10")]
	public string EJADMGKHIJK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public delegate string EMPCLKLHLCB<in T>(T DEFKCOPBBKE) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public delegate int KPLFGFIIDOK<in T>(T DEFKCOPBBKE) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal class JFAFKHMBNKF : MPHGBLPIAOI
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	private delegate string IPIANEJGEDI(Exception DEFKCOPBBKE);

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	private delegate int PIGIKGMCONA(Exception DEFKCOPBBKE);

	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	private class MDGOAEIJLEL<T> : AOIIGPJPBLD<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		[CompilerGenerated]
		private sealed class ECCEHEAGJGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
			public ECCEHEAGJGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0")]
			internal string KBODKGOPANH(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		[CompilerGenerated]
		private sealed class GEDNHCPHPDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6BD660", Offset = "0x6BCA60")]
			public EMPCLKLHLCB<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
			public GEDNHCPHPDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x29EB300", Offset = "0x29EA700", VA = "0x1829EB300")]
			internal string FODJMNMKCOJ(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		[CompilerGenerated]
		private sealed class IKKEEELOIJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6BD6C0", Offset = "0x6BCAC0")]
			public KPLFGFIIDOK<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
			public IKKEEELOIJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x29EB300", Offset = "0x29EA700", VA = "0x1829EB300")]
			internal int PFJGEAOPILO(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private readonly JFAFKHMBNKF EMDMAKECHJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private readonly Type INLEGFMOENE;

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x22EF190", Offset = "0x22EE590", VA = "0x1822EF190")]
		internal MDGOAEIJLEL(JFAFKHMBNKF EMDMAKECHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x22EF060", Offset = "0x22EE460", VA = "0x1822EF060", Slot = "4")]
		public void HMNBKMFLIDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x22EF090", Offset = "0x22EE490", VA = "0x1822EF090", Slot = "5")]
		public AOIIGPJPBLD<T> KNGMDNPCMEL(string NKADMIGGGNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x22EEF60", Offset = "0x22EE360", VA = "0x1822EEF60", Slot = "6")]
		public AOIIGPJPBLD<T> DCCIFHNCHDH(EMPCLKLHLCB<T> LIODFABIADE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x22EEE00", Offset = "0x22EE200", VA = "0x1822EEE00", Slot = "7")]
		public AOIIGPJPBLD<T> BAHEIJNIIJJ(int JPJMOKBNPPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x22EEE40", Offset = "0x22EE240", VA = "0x1822EEE40", Slot = "8")]
		public AOIIGPJPBLD<T> CNBMDBDFAED(int JPJMOKBNPPJ, KPLFGFIIDOK<T> PCEAFLDGDMD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	private class KOMGIOHABOD<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private bool KEOHNEEMOPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private readonly List<Type> DHFGABPMPCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private readonly Dictionary<Type, TVal> DIODANPKJHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private readonly Dictionary<Type, int> JJODFNFBMBC;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public IReadOnlyList<Type> NMAEICLEEPH
		{
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x2E65AF0", Offset = "0x2E64EF0", VA = "0x182E65AF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x2E65D70", Offset = "0x2E65170", VA = "0x182E65D70")]
		public KOMGIOHABOD(Dictionary<Type, int> JJODFNFBMBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x2E65A50", Offset = "0x2E64E50", VA = "0x182E65A50")]
		public void NNFBEGDMHOD(Type PMMAAICOJOP, TVal GBFJPNOAMDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x2E65980", Offset = "0x2E64D80", VA = "0x182E65980")]
		public bool JFKEPOPMFME(Type INLEGFMOENE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x2E65950", Offset = "0x2E64D50", VA = "0x182E65950")]
		public bool HHCAPJEIIKO(TVal AGLCIEKHLEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x2A24430", Offset = "0x2A23830", VA = "0x182A24430")]
		public TVal PHGLOPEHIMO(Type GANFKPHKNKH)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x2E65810", Offset = "0x2E64C10", VA = "0x182E65810")]
		[CompilerGenerated]
		private int FGGLLKBFMLA(Type JJMLELCFGNB, Type GNIJDBALAEA)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private sealed class EEFEFJPOCOE : IEnumerable<DDBGEGLAAFB>, IEnumerable, IEnumerator<DDBGEGLAAFB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private DDBGEGLAAFB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public JFAFKHMBNKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private AggregateException <aggregateException>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private IEnumerator<Exception> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private Exception <innerException>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private IEnumerator<DDBGEGLAAFB> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private DDBGEGLAAFB <innerErrorCode>5__5;

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		private DDBGEGLAAFB System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0x27B2480", Offset = "0x27B1880", VA = "0x1827B2480", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(DDBGEGLAAFB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x3A559D0", Offset = "0x3A54DD0", VA = "0x183A559D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x9C1680", Offset = "0x9C0A80", VA = "0x1809C1680")]
		[DebuggerHidden]
		public EEFEFJPOCOE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x3A55A20", Offset = "0x3A54E20", VA = "0x183A55A20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x3A55470", Offset = "0x3A54870", VA = "0x183A55470", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x3A55890", Offset = "0x3A54C90", VA = "0x183A55890")]
		private void PPOPDODPNIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x3A55420", Offset = "0x3A54820", VA = "0x183A55420")]
		private void MKCFKGNFONF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x3A55990", Offset = "0x3A54D90", VA = "0x183A55990", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x3A558E0", Offset = "0x3A54CE0", VA = "0x183A558E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DDBGEGLAAFB> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x3A558E0", Offset = "0x3A54CE0", VA = "0x183A558E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private static readonly DDBGEGLAAFB LGCIFIKDILJ;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private static readonly Dictionary<Type, int> GFFMGBKOBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private readonly HashSet<Type> CKEDAGDJJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private readonly KOMGIOHABOD<int> BBIOCKGDFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private readonly KOMGIOHABOD<PIGIKGMCONA> AMDINDPINIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private readonly KOMGIOHABOD<IPIANEJGEDI> BKNBHNOPFFK;

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x20A2D20", Offset = "0x20A2120", VA = "0x1820A2D20")]
	[PGKDFPMEDOJ(CDFBKAGHDGH.GameOnly)]
	private static void PIJPEIOOLKO(IFJJAPHPIAE LDNJCMFLLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x20A2E40", Offset = "0x20A2240", VA = "0x1820A2E40")]
	[RecRoom.NoEngine.Common.Preserve]
	public JFAFKHMBNKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x163D130", Offset = "0x163C530", VA = "0x18163D130", Slot = "4")]
	public AOIIGPJPBLD<T> DLONDMHOHHC<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x20A23D0", Offset = "0x20A17D0", VA = "0x1820A23D0", Slot = "5")]
	public PGIFBHEGEML HICJLFEMFPD(Exception DEFKCOPBBKE)
	{
		return default(PGIFBHEGEML);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x20A2B10", Offset = "0x20A1F10", VA = "0x1820A2B10", Slot = "6")]
	public DDBGEGLAAFB ONBBMNNLMCI(Exception? DEFKCOPBBKE)
	{
		return default(DDBGEGLAAFB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x20A2720", Offset = "0x20A1B20", VA = "0x1820A2720", Slot = "7")]
	[IteratorStateMachine(typeof(EEFEFJPOCOE))]
	public IEnumerable<DDBGEGLAAFB> NLACAFKKGBC(Exception DEFKCOPBBKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x20A19F0", Offset = "0x20A0DF0", VA = "0x1820A19F0", Slot = "8")]
	public string BKJBJDBFPKA(Exception? DEFKCOPBBKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x20A27B0", Offset = "0x20A1BB0", VA = "0x1820A27B0")]
	private string NPLNJKBDDKN(AggregateException IFFNMJHPOKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x20A1B30", Offset = "0x20A0F30", VA = "0x1820A1B30")]
	private void CHGEJMELKPK(Type INLEGFMOENE, int JPJMOKBNPPJ, PIGIKGMCONA? DJIFOGDCCOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x20A2190", Offset = "0x20A1590", VA = "0x1820A2190")]
	private void FJNOJOFCLNF(Type INLEGFMOENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x20A1ED0", Offset = "0x20A12D0", VA = "0x1820A1ED0")]
	private void EFFEGPEMDHN(Type INLEGFMOENE, IPIANEJGEDI EEDLPCBKFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x20A2490", Offset = "0x20A1890", VA = "0x1820A2490")]
	private static int KJBONLKKNLN(Type INLEGFMOENE, Dictionary<Type, int> JJODFNFBMBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x163D190", Offset = "0x163C590", VA = "0x18163D190")]
	private static bool MBFPOPJCKBP<TVal>(KOMGIOHABOD<TVal> IKBLLODDBLI, Type INLEGFMOENE, out TVal AGLCIEKHLEE) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x20A2630", Offset = "0x20A1A30", VA = "0x1820A2630")]
	[CompilerGenerated]
	internal static int MEKJOLJDHEA(Type NLAFDODKHHH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public struct DDBGEGLAAFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public readonly int CNDEIHDKOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public readonly int? KFDLAGNJIML;

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x176ACB0", Offset = "0x176A0B0", VA = "0x18176ACB0")]
	public DDBGEGLAAFB(int BLBLLAALJCA, [Optional] int? EJICIGHGDKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x208E510", Offset = "0x208D910", VA = "0x18208E510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public interface MPHGBLPIAOI
{
	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AOIIGPJPBLD<T> DLONDMHOHHC<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PGIFBHEGEML HICJLFEMFPD(Exception DEFKCOPBBKE);

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DDBGEGLAAFB ONBBMNNLMCI(Exception DEFKCOPBBKE);
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public interface AOIIGPJPBLD<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMNBKMFLIDF();

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AOIIGPJPBLD<T> KNGMDNPCMEL(string NKADMIGGGNG);

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AOIIGPJPBLD<T> DCCIFHNCHDH(EMPCLKLHLCB<T> LIODFABIADE);

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AOIIGPJPBLD<T> BAHEIJNIIJJ(int JPJMOKBNPPJ);

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AOIIGPJPBLD<T> CNBMDBDFAED(int JPJMOKBNPPJ, KPLFGFIIDOK<T> PCEAFLDGDMD);
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class GMNLEMNANEK
{
	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x209A7A0", Offset = "0x2099BA0", VA = "0x18209A7A0")]
	[PGKDFPMEDOJ(CDFBKAGHDGH.GameOnly)]
	private static void JOJBKOBJJHB(IFJJAPHPIAE LDNJCMFLLMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public interface MANOJAHNIFE : IEquatable<MANOJAHNIFE>
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	DateTime MBFIOEMFGHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LFMIEKDMAIB();

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LDDADOOMNPM(long KFHMHOFPIPN, long LHBCPOODKNA, out DPAKJIPJCJD KFBJJKPIMFK);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
internal class HOEMPMJOMJA : KMGCJHHGHIL
{
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private sealed class AKCFJKDIEKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public HBJIMGJNMKE autosaveType;

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public AKCFJKDIEKC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private sealed class LAHPNHDPFAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public AKCFJKDIEKC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public LAHPNHDPFAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x3A5C220", Offset = "0x3A5B620", VA = "0x183A5C220")]
		internal object EAHDHPDJJCG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private readonly HLEAMHOEOJB MBCCIBGKBLG;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event Action<MANOJAHNIFE> FNBBFLFPHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x209E6A0", Offset = "0x209DAA0", VA = "0x18209E6A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x209ECA0", Offset = "0x209E0A0", VA = "0x18209ECA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x8C4170", Offset = "0x8C3570", VA = "0x1808C4170")]
	[UnityEngine.Scripting.Preserve]
	public HOEMPMJOMJA([JLJFOFICIEA(null)] HLEAMHOEOJB MBCCIBGKBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x209E740", Offset = "0x209DB40", VA = "0x18209E740", Slot = "6")]
	public bool CNBBALOGKDH(long KFHMHOFPIPN, long LHBCPOODKNA, DPAKJIPJCJD KFBJJKPIMFK, HBJIMGJNMKE JKNMNCOCLMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x209EC00", Offset = "0x209E000", VA = "0x18209EC00")]
	private void KOJGPNHENFH(MANOJAHNIFE LGMCHOGOHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x209ED40", Offset = "0x209E140", VA = "0x18209ED40", Slot = "7")]
	public bool ONNKFHAFBPF(long KFHMHOFPIPN, long LHBCPOODKNA, out MANOJAHNIFE FOFGMEHODIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x209E5F0", Offset = "0x209D9F0", VA = "0x18209E5F0", Slot = "8")]
	public bool AKOCDJPGCNL(long KFHMHOFPIPN, long LHBCPOODKNA, HBJIMGJNMKE JKNMNCOCLMI, out MANOJAHNIFE FOFGMEHODIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x209EED0", Offset = "0x209E2D0", VA = "0x18209EED0")]
	private void PFOPAMHLNGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x209EAE0", Offset = "0x209DEE0", VA = "0x18209EAE0", Slot = "9")]
	public void EPFJBGBMPFA(long KFHMHOFPIPN, long LHBCPOODKNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public enum FJGLIFNFCHG : byte
{
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
internal sealed class FLEGEGIDHCA : CJBCEHKIOHH
{
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private static readonly byte[] PMMAAICOJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private readonly byte[] HHNPDHFIKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private readonly byte[] ECNBPNDFKMA;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public override FJGLIFNFCHG JPOFPKHKJPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x2095CC0", Offset = "0x20950C0", VA = "0x182095CC0", Slot = "8")]
		get
		{
			return default(FJGLIFNFCHG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x2096880", Offset = "0x2095C80", VA = "0x182096880")]
	public FLEGEGIDHCA([Optional] string KLMECFEGDGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x20958D0", Offset = "0x2094CD0", VA = "0x1820958D0", Slot = "9")]
	internal override void BILKODAOHNP(Stream MODCNPCJOPO, long KFHMHOFPIPN, long LHBCPOODKNA, DPAKJIPJCJD KFBJJKPIMFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x2095E00", Offset = "0x2095200", VA = "0x182095E00", Slot = "10")]
	internal override bool FOADFCANGEN(Stream DKENIAIMKPI, long KFHMHOFPIPN, long LHBCPOODKNA, IAHACKJPBMF AJFKONFIEJF, out DPAKJIPJCJD KFBJJKPIMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x20966F0", Offset = "0x2095AF0", VA = "0x1820966F0")]
	private void MBHFNKDKCEJ(byte[] GIJGKJOCENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x2095CD0", Offset = "0x20950D0", VA = "0x182095CD0", Slot = "11")]
	protected override FileInfo DGDAMBIAJIJ(long KFHMHOFPIPN, long LHBCPOODKNA, HBJIMGJNMKE JKNMNCOCLMI, BFCPBBJICPF BBPELNFADMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x2095BA0", Offset = "0x2094FA0", VA = "0x182095BA0", Slot = "12")]
	protected override DirectoryInfo CBFJOCDNEPE(HBJIMGJNMKE JKNMNCOCLMI, BFCPBBJICPF BBPELNFADMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
internal class JCBDALIGJKP : CJBCEHKIOHH
{
	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public override FJGLIFNFCHG JPOFPKHKJPH
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x98A2B0", Offset = "0x9896B0", VA = "0x18098A2B0", Slot = "8")]
		get
		{
			return default(FJGLIFNFCHG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x20A1930", Offset = "0x20A0D30", VA = "0x1820A1930")]
	public JCBDALIGJKP([Optional] string KLMECFEGDGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x20A0D90", Offset = "0x20A0190", VA = "0x1820A0D90")]
	private void AFEPIEINFOF(HBJIMGJNMKE JKNMNCOCLMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x20A0E20", Offset = "0x20A0220", VA = "0x1820A0E20", Slot = "9")]
	internal override void BILKODAOHNP(Stream MODCNPCJOPO, long KFHMHOFPIPN, long LHBCPOODKNA, DPAKJIPJCJD KFBJJKPIMFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x20A12B0", Offset = "0x20A06B0", VA = "0x1820A12B0", Slot = "10")]
	internal override bool FOADFCANGEN(Stream DKENIAIMKPI, long KFHMHOFPIPN, long LHBCPOODKNA, IAHACKJPBMF AJFKONFIEJF, out DPAKJIPJCJD KFBJJKPIMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x20A11C0", Offset = "0x20A05C0", VA = "0x1820A11C0", Slot = "11")]
	protected override FileInfo DGDAMBIAJIJ(long KFHMHOFPIPN, long LHBCPOODKNA, HBJIMGJNMKE JKNMNCOCLMI, BFCPBBJICPF BBPELNFADMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x20A10B0", Offset = "0x20A04B0", VA = "0x1820A10B0", Slot = "12")]
	protected override DirectoryInfo CBFJOCDNEPE(HBJIMGJNMKE JKNMNCOCLMI, BFCPBBJICPF BBPELNFADMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
internal abstract class CJBCEHKIOHH : HLEAMHOEOJB
{
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	protected enum BFCPBBJICPF : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private sealed class NEDNOHDCJIE : IEnumerable<MANOJAHNIFE>, IEnumerable, IEnumerator<MANOJAHNIFE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private MANOJAHNIFE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private HBJIMGJNMKE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public HBJIMGJNMKE <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public CJBCEHKIOHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private DirectoryInfo <autosaveDirectory>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private FileInfo[] <files>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private FileInfo[] <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private int <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private FileInfo <file>5__5;

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		private MANOJAHNIFE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x9C1680", Offset = "0x9C0A80", VA = "0x1809C1680")]
		[DebuggerHidden]
		public NEDNOHDCJIE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x27E0960", Offset = "0x27DFD60", VA = "0x1827E0960", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x27E0BC0", Offset = "0x27DFFC0", VA = "0x1827E0BC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x27E0B10", Offset = "0x27DFF10", VA = "0x1827E0B10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MANOJAHNIFE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x27E0B10", Offset = "0x27DFF10", VA = "0x1827E0B10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private sealed class FGLMCAKPEBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public HBJIMGJNMKE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public FGLMCAKPEBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x27D2E70", Offset = "0x27D2270", VA = "0x1827D2E70")]
		internal object HDIBADMPAAL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class CIDAAHIEAOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public CJBCEHKIOHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public CIDAAHIEAOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x27D1350", Offset = "0x27D0750", VA = "0x1827D1350")]
		internal void CNIJAJCDDOF(PAHJLOGPGEB.DKNGMJCPKAO ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	protected readonly string PNMFLMAPFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000365")]
	private readonly object LIGAGBHCOGG;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public abstract FJGLIFNFCHG JPOFPKHKJPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x208B800", Offset = "0x208AC00", VA = "0x18208B800")]
	protected CJBCEHKIOHH([CanBeNull] string KLMECFEGDGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x208B630", Offset = "0x208AA30", VA = "0x18208B630", Slot = "5")]
	public bool NCEPCMMDKHM(long KFHMHOFPIPN, long LHBCPOODKNA, HBJIMGJNMKE JKNMNCOCLMI, out MANOJAHNIFE LGMCHOGOHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x208B280", Offset = "0x208A680", VA = "0x18208B280", Slot = "6")]
	[IteratorStateMachine(typeof(NEDNOHDCJIE))]
	public IEnumerable<MANOJAHNIFE> JNACNEPJNMF(HBJIMGJNMKE JKNMNCOCLMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void BILKODAOHNP(Stream MODCNPCJOPO, long KFHMHOFPIPN, long LHBCPOODKNA, DPAKJIPJCJD KFBJJKPIMFK);

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool FOADFCANGEN(Stream DKENIAIMKPI, long KFHMHOFPIPN, long LHBCPOODKNA, IAHACKJPBMF AJFKONFIEJF, out DPAKJIPJCJD KFBJJKPIMFK);

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x208AF10", Offset = "0x208A310", VA = "0x18208AF10", Slot = "7")]
	public MANOJAHNIFE BIMLENOCJMP(long KFHMHOFPIPN, long LHBCPOODKNA, DPAKJIPJCJD KFBJJKPIMFK, HBJIMGJNMKE JKNMNCOCLMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo DGDAMBIAJIJ(long KFHMHOFPIPN, long LHBCPOODKNA, HBJIMGJNMKE JKNMNCOCLMI, BFCPBBJICPF BBPELNFADMO);

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo CBFJOCDNEPE(HBJIMGJNMKE JKNMNCOCLMI, BFCPBBJICPF BBPELNFADMO);

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x208B300", Offset = "0x208A700", VA = "0x18208B300")]
	protected void MCKDEEABJEG(PAHJLOGPGEB.DKNGMJCPKAO KGKIOGKPJPJ, string FENGPJBOMEE, FileInfo GLPOOONCGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x208B370", Offset = "0x208A770", VA = "0x18208B370")]
	internal bool MICJIOANBCN(FileInfo NNPIKJPCHAG, long KFHMHOFPIPN, long LHBCPOODKNA, out DPAKJIPJCJD KFBJJKPIMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	private void JHLEJHGFDLC(Exception KEDDDEAIDBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
internal interface HLEAMHOEOJB
{
	[Cpp2IlInjected.Token(Token = "0x17000094")]
	FJGLIFNFCHG JPOFPKHKJPH
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NCEPCMMDKHM(long KFHMHOFPIPN, long LHBCPOODKNA, HBJIMGJNMKE JKNMNCOCLMI, out MANOJAHNIFE LGMCHOGOHPK);

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<MANOJAHNIFE> JNACNEPJNMF(HBJIMGJNMKE JKNMNCOCLMI);

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MANOJAHNIFE BIMLENOCJMP(long KFHMHOFPIPN, long LHBCPOODKNA, DPAKJIPJCJD KFBJJKPIMFK, HBJIMGJNMKE JKNMNCOCLMI);
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
internal class NOMDDIOILIG : HLEAMHOEOJB
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private sealed class FBPNBBHPJEC : IEnumerable<MANOJAHNIFE>, IEnumerable, IEnumerator<MANOJAHNIFE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private MANOJAHNIFE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private HBJIMGJNMKE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public HBJIMGJNMKE <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public NOMDDIOILIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private FJGLIFNFCHG[] <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private int <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private FJGLIFNFCHG <autosaveVersion>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private HLEAMHOEOJB <impl>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private IEnumerable<MANOJAHNIFE> <records>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private IEnumerator<MANOJAHNIFE> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private MANOJAHNIFE <autosaveRecord>5__7;

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private MANOJAHNIFE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x9C1680", Offset = "0x9C0A80", VA = "0x1809C1680")]
		[DebuggerHidden]
		public FBPNBBHPJEC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x3BF60C0", Offset = "0x3BF54C0", VA = "0x183BF60C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x3BF5C30", Offset = "0x3BF5030", VA = "0x183BF5C30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x3BF5F80", Offset = "0x3BF5380", VA = "0x183BF5F80")]
		private void PPOPDODPNIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x3BF6080", Offset = "0x3BF5480", VA = "0x183BF6080", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x3BF5FD0", Offset = "0x3BF53D0", VA = "0x183BF5FD0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MANOJAHNIFE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x3BF5FD0", Offset = "0x3BF53D0", VA = "0x183BF5FD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000378")]
	private readonly FJGLIFNFCHG[] LBNLIEACIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000379")]
	private readonly Dictionary<FJGLIFNFCHG, HLEAMHOEOJB> KNBJGHFCDMM;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public FJGLIFNFCHG JPOFPKHKJPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x27E1770", Offset = "0x27E0B70", VA = "0x1827E1770", Slot = "4")]
		get
		{
			return default(FJGLIFNFCHG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x27E1BC0", Offset = "0x27E0FC0", VA = "0x1827E1BC0")]
	[UnityEngine.Scripting.Preserve]
	public NOMDDIOILIG(params HLEAMHOEOJB[] NNJCIPCLGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x27E1A60", Offset = "0x27E0E60", VA = "0x1827E1A60", Slot = "5")]
	public bool NCEPCMMDKHM(long KFHMHOFPIPN, long LHBCPOODKNA, HBJIMGJNMKE JKNMNCOCLMI, out MANOJAHNIFE LGMCHOGOHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x27E1830", Offset = "0x27E0C30", VA = "0x1827E1830")]
	private void MFPDIMCMAKJ(int GFPBMIDCLDH, long KFHMHOFPIPN, long LHBCPOODKNA, HBJIMGJNMKE JKNMNCOCLMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x27E17B0", Offset = "0x27E0BB0", VA = "0x1827E17B0", Slot = "6")]
	[IteratorStateMachine(typeof(FBPNBBHPJEC))]
	public IEnumerable<MANOJAHNIFE> JNACNEPJNMF(HBJIMGJNMKE JKNMNCOCLMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x27E1620", Offset = "0x27E0A20", VA = "0x1827E1620", Slot = "7")]
	public MANOJAHNIFE BIMLENOCJMP(long KFHMHOFPIPN, long LHBCPOODKNA, DPAKJIPJCJD KFBJJKPIMFK, HBJIMGJNMKE JKNMNCOCLMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal static class FCGLEBMCEEI
{
	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x2095830", Offset = "0x2094C30", VA = "0x182095830")]
	internal static byte[] OKLNPEMIKLM(byte[] GIJGKJOCENH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x20955D0", Offset = "0x20949D0", VA = "0x1820955D0")]
	public static void CEAJNBHODFC(Stream ICGCONBOMPO, byte[] MMMGCNLHDAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x2095650", Offset = "0x2094A50", VA = "0x182095650")]
	public static bool FAOHALMJOEN(Stream ICGCONBOMPO, long JGHKGKOPHHI, IAHACKJPBMF JLHLDIBBIBJ, out byte[] HGMEIDOEHDH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public delegate void IAHACKJPBMF(PAHJLOGPGEB.DKNGMJCPKAO OHFPHAHJJEC, string FHDJIGKOLJM);
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal sealed class HOHBPEGHNPE : MANOJAHNIFE, IEquatable<MANOJAHNIFE>, IEquatable<HOHBPEGHNPE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400038B")]
	private readonly CJBCEHKIOHH IAKFCEFCDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public readonly FileInfo CNOHFBJLPDF;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public FJGLIFNFCHG JPOFPKHKJPH
	{
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x209F2C0", Offset = "0x209E6C0", VA = "0x18209F2C0", Slot = "9")]
		get
		{
			return default(FJGLIFNFCHG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public DateTime MBFIOEMFGHD
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x209F710", Offset = "0x209EB10", VA = "0x18209F710", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x209F860", Offset = "0x209EC60", VA = "0x18209F860")]
	public HOHBPEGHNPE(CJBCEHKIOHH GGBLOHNHEBE, FileInfo NNPIKJPCHAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x209F7B0", Offset = "0x209EBB0", VA = "0x18209F7B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x209F660", Offset = "0x209EA60", VA = "0x18209F660", Slot = "5")]
	public void LFMIEKDMAIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x209F620", Offset = "0x209EA20", VA = "0x18209F620", Slot = "6")]
	public bool LDDADOOMNPM(long KFHMHOFPIPN, long LHBCPOODKNA, out DPAKJIPJCJD KFBJJKPIMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x209F3F0", Offset = "0x209E7F0", VA = "0x18209F3F0", Slot = "7")]
	public bool Equals(MANOJAHNIFE ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x209F4D0", Offset = "0x209E8D0", VA = "0x18209F4D0", Slot = "8")]
	public bool Equals(HOHBPEGHNPE ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x209F2F0", Offset = "0x209E6F0", VA = "0x18209F2F0", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x209F580", Offset = "0x209E980", VA = "0x18209F580", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal struct GDDEEBNMNEO
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class BLGOBHFINJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public CPBDLHAFGBN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public AEEBPABFEDL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private EEMPEMCEAHC <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public BLGOBHFINJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x3A51D30", Offset = "0x3A51130", VA = "0x183A51D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x2098200", Offset = "0x2097600", VA = "0x182098200")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BLGOBHFINJP))]
	public static Task FOLFCGOHDPG(CPBDLHAFGBN NGMMDGIIBLN, AEEBPABFEDL CLCAIFLMLCJ, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal struct CIAFKLFNGJE
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private sealed class ODGBJEMKCDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public MOKCCACHPIF operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public AEEBPABFEDL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public HHJNDLHLIDF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private EEMPEMCEAHC <roomManager>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private ENPHMEADLAM <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private KJEHFDNNDGH <DEPRECATED_version>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private IDisposable <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private IDisposable <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private List<(PersistenceView, FEKGKBGNILG)>.Enumerator <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private PersistenceView <view>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private FEKGKBGNILG <viewData>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public ODGBJEMKCDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x27E21D0", Offset = "0x27E15D0", VA = "0x1827E21D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x208AD70", Offset = "0x208A170", VA = "0x18208AD70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ODGBJEMKCDI))]
	public static Task FOLFCGOHDPG(MOKCCACHPIF CMBFEPDDNLN, AEEBPABFEDL CLCAIFLMLCJ, HHJNDLHLIDF EMPBPHENLHN, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal struct MJJOHDCCLOJ
{
	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60")]
	public static MJJOHDCCLOJ DEDAFMGEJMH()
	{
		return default(MJJOHDCCLOJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal struct NHNGHNDOHNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	private EEMPEMCEAHC MDIBAOPLIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	private AEEBPABFEDL CLCAIFLMLCJ;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private ENPHMEADLAM OLJLNILBIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x27E0C00", Offset = "0x27E0000", VA = "0x1827E0C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x27E0C50", Offset = "0x27E0050", VA = "0x1827E0C50")]
	public static Task FOLFCGOHDPG(EEMPEMCEAHC MDIBAOPLIIF, AEEBPABFEDL CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x27E0CF0", Offset = "0x27E00F0", VA = "0x1827E0CF0")]
	private void FOLFCGOHDPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
internal class IEHAGJFCBEC : MOKCCACHPIF
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private sealed class JMDGDGNIPLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public CPBDLHAFGBN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public IEHAGJFCBEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private long <subRoomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private string <unityAssetId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private PDAPGAJCBAI <serializeLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private PHHKJAPOHHP <roomSaveOptions>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private NDLJIBMEGPJ <serializeType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private DPAKJIPJCJD <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private DPAKJIPJCJD <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private Exception <ex>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private TaskAwaiter<DPAKJIPJCJD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JMDGDGNIPLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x3A5B7D0", Offset = "0x3A5ABD0", VA = "0x183A5B7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	private readonly string LPBCOGOFFBN;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x20A0180", Offset = "0x209F580", VA = "0x1820A0180")]
	public IEHAGJFCBEC(Guid JIDMDNKJFGM, EEMPEMCEAHC MDIBAOPLIIF, HACHIHGCJBL FPKJCMGGANH, string LPBCOGOFFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x209FFE0", Offset = "0x209F3E0", VA = "0x18209FFE0", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JMDGDGNIPLL))]
	protected override Task MHNOKJCCNLP(CPBDLHAFGBN NGMMDGIIBLN, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
internal class KMPGBMBDOCO
{
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class PLLBKDJLCKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public BBGJGBPKMJE operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public AEEBPABFEDL deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public CPMEPPENFLB<string>.PEFDMNJICBO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public KMPGBMBDOCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public PLLBKDJLCKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x3C03B10", Offset = "0x3C02F10", VA = "0x183C03B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class DBCJJALDKCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public KMPGBMBDOCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public AEEBPABFEDL data;

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public DBCJJALDKCL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class EOOMBHBJPHG
	{
		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		private sealed class <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public EOOMBHBJPHG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public <<RunAuthorityHandler>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x603E600", Offset = "0x603DA00", VA = "0x18603E600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public CPMEPPENFLB<string>.PEFDMNJICBO handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public DBCJJALDKCL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public EOOMBHBJPHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x3BF5AE0", Offset = "0x3BF4EE0", VA = "0x183BF5AE0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task LAMMIKBHIKO(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class DIFNMKLCNBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public AEEBPABFEDL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public CPMEPPENFLB<string>.PEFDMNJICBO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public KMPGBMBDOCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private DBCJJALDKCL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private EOOMBHBJPHG <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public DIFNMKLCNBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x3BF5180", Offset = "0x3BF4580", VA = "0x183BF5180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class GMAHNLJJGAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public AEEBPABFEDL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public CPMEPPENFLB<string>.PEFDMNJICBO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public KMPGBMBDOCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private Dictionary<Guid, List<IAAIDDIJMBP>>.Enumerator <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private KeyValuePair<Guid, List<IAAIDDIJMBP>> <guidMethodPair>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public GMAHNLJJGAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x3BF7BC0", Offset = "0x3BF6FC0", VA = "0x183BF7BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class JFBKECHHFJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public AEEBPABFEDL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public CPMEPPENFLB<string>.PEFDMNJICBO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public KMPGBMBDOCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private BOEFLMAPNBA <networking>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private Dictionary<Guid, List<IAAIDDIJMBP>>.Enumerator <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private KeyValuePair<Guid, List<IAAIDDIJMBP>> <guidMethodPair>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JFBKECHHFJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x3BFC640", Offset = "0x3BFBA40", VA = "0x183BFC640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class GMAKOIHAHII
	{
		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		private sealed class <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public IAAIDDIJMBP handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public GMAKOIHAHII <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public <<InvokeMethodsInParallel>b__2>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x603C1C0", Offset = "0x603B5C0", VA = "0x18603C1C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public MPNJIMHNDNB runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public List<IAAIDDIJMBP> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public AEEBPABFEDL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public GMAKOIHAHII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x3BF8200", Offset = "0x3BF7600", VA = "0x183BF8200")]
		internal object OEBEKLLNCGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x3BF80B0", Offset = "0x3BF74B0", VA = "0x183BF80B0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task AIKCLFFAANI(IAAIDDIJMBP handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x3BF82F0", Offset = "0x3BF76F0", VA = "0x183BF82F0")]
		internal object OHCELFEKFNL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private sealed class LJLODPFDJNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public List<IAAIDDIJMBP> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public MPNJIMHNDNB runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public AEEBPABFEDL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public KMPGBMBDOCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private GMAKOIHAHII <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private IEnumerable<Task> <handlerTasks>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private Exception <ex>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public LJLODPFDJNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x3BFF2C0", Offset = "0x3BFE6C0", VA = "0x183BFF2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private sealed class CPGLKABEFEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public AEEBPABFEDL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public CPMEPPENFLB<string>.PEFDMNJICBO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public KMPGBMBDOCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private Guid <handlerIdToRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public CPGLKABEFEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x3BF49B0", Offset = "0x3BF3DB0", VA = "0x183BF49B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private sealed class EKLFANMBKFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public EKLFANMBKFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x3BF5A00", Offset = "0x3BF4E00", VA = "0x183BF5A00")]
		internal object EHBAHMGLBOD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class GPAKJCEELAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public AEEBPABFEDL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public CPMEPPENFLB<string>.PEFDMNJICBO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public KMPGBMBDOCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private EKLFANMBKFP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private BOEFLMAPNBA <networking>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private List<IAAIDDIJMBP> <handlerMethods>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public GPAKJCEELAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x3BF8760", Offset = "0x3BF7B60", VA = "0x183BF8760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private sealed class ICMPMADOADB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public ICMPMADOADB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x3BFA480", Offset = "0x3BF9880", VA = "0x183BFA480")]
		internal object NEKNOCFKCPH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private sealed class MEAOIBDLHHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public KMPGBMBDOCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private ICMPMADOADB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private LJHBMNCDKEI <completedMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private LJHBMNCDKEI <syncedCompletionMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private ByteString <authorityCompletedMark>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private LJHBMNCDKEI <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private TaskAwaiter<LJHBMNCDKEI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public MEAOIBDLHHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x3BFF7F0", Offset = "0x3BFEBF0", VA = "0x183BFF7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class EKLNHGDKGIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public EKLNHGDKGIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x3BF5A70", Offset = "0x3BF4E70", VA = "0x183BF5A70")]
		internal object FAHEAKCGHAN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	private readonly CPBDLHAFGBN NGMMDGIIBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	private ANIEFLBIPML PIEOFIIJBJN;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private MOKCCACHPIF BGAIICNFBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0xE04DF0", Offset = "0xE041F0", VA = "0x180E04DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x8C4170", Offset = "0x8C3570", VA = "0x1808C4170")]
	public KMPGBMBDOCO(CPBDLHAFGBN NGMMDGIIBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x27DAAC0", Offset = "0x27D9EC0", VA = "0x1827DAAC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PLLBKDJLCKM))]
	public Task FOLFCGOHDPG(BBGJGBPKMJE LJCPJMIJAKA, AEEBPABFEDL HBIKHDDJPIH, CPMEPPENFLB<string>.PEFDMNJICBO INJHLEJHFLF, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x27DB6C0", Offset = "0x27DAAC0", VA = "0x1827DB6C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DIFNMKLCNBC))]
	private Task NOGICPFAOCC(AEEBPABFEDL CLCAIFLMLCJ, CPMEPPENFLB<string>.PEFDMNJICBO INJHLEJHFLF, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x27DA920", Offset = "0x27D9D20", VA = "0x1827DA920")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GMAHNLJJGAF))]
	private Task EOEGIEDMJHP(AEEBPABFEDL CLCAIFLMLCJ, CPMEPPENFLB<string>.PEFDMNJICBO INJHLEJHFLF, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x27DB380", Offset = "0x27DA780", VA = "0x1827DB380")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JFBKECHHFJH))]
	private Task LLGDKAJKBHE(AEEBPABFEDL CLCAIFLMLCJ, CPMEPPENFLB<string>.PEFDMNJICBO INJHLEJHFLF, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x27DAC80", Offset = "0x27DA080", VA = "0x1827DAC80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LJLODPFDJNB))]
	private Task IKNFEHLJMFN(Guid LAKCLHDNPJI, List<IAAIDDIJMBP> PGCBHOKCABM, MPNJIMHNDNB NHIEGKNDGHK, AEEBPABFEDL CLCAIFLMLCJ, CancellationToken AEMEEHLIDCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x27DB520", Offset = "0x27DA920", VA = "0x1827DB520")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CPGLKABEFEJ))]
	private Task MGPIAGGHKEG(AEEBPABFEDL CLCAIFLMLCJ, CPMEPPENFLB<string>.PEFDMNJICBO INJHLEJHFLF, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x27DB860", Offset = "0x27DAC60", VA = "0x1827DB860")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GPAKJCEELAB))]
	private Task PNFGNMPPMPK(Guid DKKGLBFPIFC, AEEBPABFEDL CLCAIFLMLCJ, CPMEPPENFLB<string>.PEFDMNJICBO INJHLEJHFLF, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x27DB010", Offset = "0x27DA410", VA = "0x1827DB010")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MEAOIBDLHHA))]
	private Task KJIKEICJGOM(Guid DKKGLBFPIFC, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x27DA7F0", Offset = "0x27D9BF0", VA = "0x1827DA7F0")]
	private void DECJFAOLPJP(Guid DKKGLBFPIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x27DA730", Offset = "0x27D9B30", VA = "0x1827DA730")]
	private void BGPDINIGAOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x27DAE50", Offset = "0x27DA250", VA = "0x1827DAE50")]
	public Guid JICLMGODKCE(BBGJGBPKMJE ACFAJKFKCBH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x27DB1B0", Offset = "0x27DA5B0", VA = "0x1827DB1B0")]
	[CompilerGenerated]
	private object KMMFJHIAFEC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
internal struct ABAHNLENHPF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000427")]
	private readonly CPBDLHAFGBN NGMMDGIIBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	private readonly Guid IPKIHBMPDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	private bool PKEPEKOBHMH;

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x2086570", Offset = "0x2085970", VA = "0x182086570")]
	public static ABAHNLENHPF GAGDJJLBILC(CPBDLHAFGBN NGMMDGIIBLN)
	{
		return default(ABAHNLENHPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x14372C0", Offset = "0x14366C0", VA = "0x1814372C0")]
	public void DPHNNJLIMOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x2086560", Offset = "0x2085960", VA = "0x182086560", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x20868B0", Offset = "0x2085CB0", VA = "0x1820868B0")]
	private ABAHNLENHPF(CPBDLHAFGBN NGMMDGIIBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x2086650", Offset = "0x2085A50", VA = "0x182086650")]
	private void MJMJNEDDFMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x20865A0", Offset = "0x20859A0", VA = "0x1820865A0")]
	private Func<Guid, bool> JELMGDBMJGI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
internal struct FPMGOLLANOB
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private sealed class NCLGMNDFAIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public AsyncTaskMethodBuilder<PLLNJBBBBDK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public FPMGOLLANOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <subTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private PLLNJBBBBDK <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private TaskAwaiter<PLLNJBBBBDK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public NCLGMNDFAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x3A5EC50", Offset = "0x3A5E050", VA = "0x183A5EC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private sealed class DOGHFLAJIJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public AsyncTaskMethodBuilder<PLLNJBBBBDK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public FPMGOLLANOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		private PLLNJBBBBDK <roomDetails>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private PLLNJBBBBDK <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private TaskAwaiter<PLLNJBBBBDK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public DOGHFLAJIJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x3A54CC0", Offset = "0x3A540C0", VA = "0x183A54CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private sealed class PILHELIONGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public PILHELIONGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0xBBE310", Offset = "0xBBD710", VA = "0x180BBE310")]
		internal bool MBAJNFBCJGA(LENKAENGBGK sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class FNLHBFLDBOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public AsyncTaskMethodBuilder<PLLNJBBBBDK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public ENPHMEADLAM callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public DJFLKAMMCHF superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private PILHELIONGB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private MFKMLKAPGOD <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private LENKAENGBGK <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private DJFLKAMMCHF <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private DJFLKAMMCHF <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private MFKMLKAPGOD <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private AJOBOMJDCOM <session>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private AJOBOMJDCOM <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private KFJCLNMFLAB <saveData>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private KFJCLNMFLAB <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private TaskAwaiter<MFKMLKAPGOD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private TaskAwaiter<AJOBOMJDCOM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private TaskAwaiter<KFJCLNMFLAB> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public FNLHBFLDBOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x3A569E0", Offset = "0x3A55DE0", VA = "0x183A569E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	private ENPHMEADLAM EOPIGBOAJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	private DLMGJNBMKMD COFHFLANDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	private CPMEPPENFLB<string>.PEFDMNJICBO INJHLEJHFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	private long KFHMHOFPIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400042E")]
	private long LHBCPOODKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400042F")]
	private long APEDKGLOCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000430")]
	private string IGLBCBOECHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	private DJFLKAMMCHF DKCBFIKFGIH;

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x2096CC0", Offset = "0x20960C0", VA = "0x182096CC0")]
	public static Task<PLLNJBBBBDK> AOHHCCJKCMA(EEMPEMCEAHC MDIBAOPLIIF, OPAHMEFPIDH OALKBFHLHKE, CPMEPPENFLB<string>.PEFDMNJICBO INJHLEJHFLF, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x2096F00", Offset = "0x2096300", VA = "0x182096F00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NCLGMNDFAIK))]
	private Task<PLLNJBBBBDK> FOLFCGOHDPG(CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x20972C0", Offset = "0x20966C0", VA = "0x1820972C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DOGHFLAJIJA))]
	private Task<PLLNJBBBBDK> OILBPMMPIND(CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x2097090", Offset = "0x2096490", VA = "0x182097090")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FNLHBFLDBOE))]
	private static Task<PLLNJBBBBDK> OILBPMMPIND(ENPHMEADLAM EOPIGBOAJOB, long KFHMHOFPIPN, long LHBCPOODKNA, long APEDKGLOCFJ, string IGLBCBOECHI, DJFLKAMMCHF DKCBFIKFGIH, CancellationToken ODBDCIFDKPJ, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x2097480", Offset = "0x2096880", VA = "0x182097480")]
	private void PJFNBFDJBNM(MFKMLKAPGOD PDHNLEDOMJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal static class DGNPGBHKDJF
{
	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x208E5F0", Offset = "0x208D9F0", VA = "0x18208E5F0")]
	public static void ADNAEPOLPEM(this BJJLKBCPMFA FAHDJNCNBPN, GIFLFLGKBIH BMMMMGGHBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x208E740", Offset = "0x208DB40", VA = "0x18208E740")]
	public static void OJMOBMCFEIO(this GIFLFLGKBIH JMCLCDJKMBJ, [Optional] string FHDJIGKOLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
internal struct HGCNGIMHLAO
{
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private sealed class OCFONBNOGMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public HGCNGIMHLAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private float <nextResendTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public OCFONBNOGMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x3A609F0", Offset = "0x3A5FDF0", VA = "0x183A609F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400045D")]
	private ENPHMEADLAM EOPIGBOAJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400045E")]
	private AEEBPABFEDL CLCAIFLMLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	private CPMEPPENFLB<string>.PEFDMNJICBO INJHLEJHFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000460")]
	private float PIEAMMNPOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000461")]
	private float APMPALMBFMD;

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x209D420", Offset = "0x209C820", VA = "0x18209D420")]
	public static Task COCGDLMDEHB(EEMPEMCEAHC MDIBAOPLIIF, AEEBPABFEDL CLCAIFLMLCJ, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x209D5B0", Offset = "0x209C9B0", VA = "0x18209D5B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OCFONBNOGMG))]
	public Task FOLFCGOHDPG(CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x209D700", Offset = "0x209CB00", VA = "0x18209D700")]
	private static void KGBOAJKJHGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x209D850", Offset = "0x209CC50", VA = "0x18209D850")]
	private void LNPDBEBKBMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x209D9D0", Offset = "0x209CDD0", VA = "0x18209D9D0")]
	private static float MLPDJNMOAAM(ENPHMEADLAM EOPIGBOAJOB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x209DA80", Offset = "0x209CE80", VA = "0x18209DA80")]
	private static float OPCDLBKNILJ()
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal class CPBDLHAFGBN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class OHKLOHJJEGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public AsyncTaskMethodBuilder<LJHBMNCDKEI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public LJHBMNCDKEI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public CPBDLHAFGBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private LJHBMNCDKEI <message>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private HGBBKLDKBDP.MPCMOHEDPCH<LJHBMNCDKEI> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private TaskAwaiter<HGBBKLDKBDP.MPCMOHEDPCH<LJHBMNCDKEI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public OHKLOHJJEGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x27E4D60", Offset = "0x27E4160", VA = "0x1827E4D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct OOLOHJHFFNJ<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class KMCHDDDJJDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public LJHBMNCDKEI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public KMCHDDDJJDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x27DA670", Offset = "0x27D9A70", VA = "0x1827DA670")]
		internal LJHBMNCDKEI HOKAEOHGLFN(byte[] msg)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private sealed class MEPGNLDGMHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public AsyncTaskMethodBuilder<HGBBKLDKBDP.MPCMOHEDPCH<LJHBMNCDKEI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public LJHBMNCDKEI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public CPBDLHAFGBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private KMCHDDDJJDB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private FCINIFPDHLP <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private HGBBKLDKBDP.MPCMOHEDPCH<LJHBMNCDKEI> <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private FCINIFPDHLP <actualMessageKind>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private HGBBKLDKBDP.MPCMOHEDPCH<LJHBMNCDKEI> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private string <errorMessage>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private ByteString <actualOperationId>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private string <errorMessage>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private TaskAwaiter<HGBBKLDKBDP.MPCMOHEDPCH<LJHBMNCDKEI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public MEPGNLDGMHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x27DC8C0", Offset = "0x27DBCC0", VA = "0x1827DC8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class INADOCMPMND<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public CPBDLHAFGBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private T <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public INADOCMPMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x29F5820", Offset = "0x29F4C20", VA = "0x1829F5820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private sealed class BFCFIMLDIGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public CPBDLHAFGBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public BFCFIMLDIGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x27D0F10", Offset = "0x27D0310", VA = "0x1827D0F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private sealed class GELGFKMDCED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public GELGFKMDCED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x27D3610", Offset = "0x27D2A10", VA = "0x1827D3610")]
		internal object LBCCDEGDAJO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x27D3500", Offset = "0x27D2900", VA = "0x1827D3500")]
		internal bool GPCFJMEDCIC(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private sealed class LLIHGOIODBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public LLIHGOIODBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x27DC810", Offset = "0x27DBC10", VA = "0x1827DC810")]
		internal object HMNLIFCILEC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private sealed class EMBGLBNDEBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public EMBGLBNDEBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x27D2D00", Offset = "0x27D2100", VA = "0x1827D2D00")]
		internal object MFLONINBAEB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private sealed class PBCFBPKNMLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public PBCFBPKNMLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x27E6EE0", Offset = "0x27E62E0", VA = "0x1827E6EE0")]
		internal object FPCDCKBPEHH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class MIKGAPDBFAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public CPBDLHAFGBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public MIKGAPDBFAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x27DF580", Offset = "0x27DE980", VA = "0x1827DF580")]
		internal object OJJJJEKKOHD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	private static readonly Guid MJFNPEBDCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public readonly MOKCCACHPIF BGAIICNFBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	private readonly HGBBKLDKBDP JIIJAGOGNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	private readonly JNLEBLAMECC COPLMJPOHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	private readonly IKDPOBOLGGC DNGIOLGEEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000471")]
	private bool ENLNNJLLCJO;

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x208DE80", Offset = "0x208D280", VA = "0x18208DE80")]
	public CPBDLHAFGBN(MOKCCACHPIF CMBFEPDDNLN, HGBBKLDKBDP JIIJAGOGNKI, JNLEBLAMECC COPLMJPOHBN, IKDPOBOLGGC DNGIOLGEEEM, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x208CB80", Offset = "0x208BF80", VA = "0x18208CB80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x208CB80", Offset = "0x208BF80", VA = "0x18208CB80")]
	public void AEJPJCKPPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x208CCA0", Offset = "0x208C0A0", VA = "0x18208CCA0")]
	public void CAPINCFFOPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x208DA80", Offset = "0x208CE80", VA = "0x18208DA80")]
	public void NOPIDPPOIGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x208D450", Offset = "0x208C850", VA = "0x18208D450")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OHKLOHJJEGK))]
	internal Task<LJHBMNCDKEI> LECMGEDKOJK(CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, LJHBMNCDKEI PKMGPKLHPLM, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x20976D0", Offset = "0x2096AD0", VA = "0x1820976D0")]
	private static byte[] MOEODFMDCOB<T>(T FHDJIGKOLJM) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x2187D00", Offset = "0x2187100", VA = "0x182187D00")]
	private static T DEPOIECPDAF<T>(MessageParser<T> PNELCCIFLJB, byte[] FHDJIGKOLJM, T DHGLPENOPHB) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x208CD70", Offset = "0x208C170", VA = "0x18208CD70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MEPGNLDGMHM))]
	private Task<HGBBKLDKBDP.MPCMOHEDPCH<LJHBMNCDKEI>> EBGDNPBDPAE(LJHBMNCDKEI PKMGPKLHPLM, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x21882A0", Offset = "0x21876A0", VA = "0x1821882A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(INADOCMPMND<>))]
	internal Task<T> ONFCAGHPEPN<T>(CancellationToken KPKCFPJKMGP, Func<CancellationToken, Task<T>> BEJINDHBFPB, int JMHEIIJOFIO = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x208DC80", Offset = "0x208D080", VA = "0x18208DC80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BFCFIMLDIGF))]
	internal Task ONFCAGHPEPN(CancellationToken KPKCFPJKMGP, Func<CancellationToken, Task> BEJINDHBFPB, int JMHEIIJOFIO = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x208D380", Offset = "0x208C780", VA = "0x18208D380")]
	public JLHDIGLBFCK JPAEHDMONEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610")]
	public MGKINDOGNEG MEHLADJIBPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x208D680", Offset = "0x208CA80", VA = "0x18208D680")]
	public PDAPGAJCBAI MHFLJFCDAHI([Optional] EHKEPJIBENP? IGCLICKKCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x208D910", Offset = "0x208CD10", VA = "0x18208D910")]
	public void MMJJDACCPJG(Func<Guid, bool> NCCOCOOBCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x208DB50", Offset = "0x208CF50", VA = "0x18208DB50")]
	public void NPACBAOFLJL(Func<Guid, bool> PPBLDNAFMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x208CF10", Offset = "0x208C310", VA = "0x18208CF10")]
	public Guid GAGDJJLBILC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x208D7E0", Offset = "0x208CBE0", VA = "0x18208D7E0")]
	public void MJMJNEDDFMB(Guid IPKIHBMPDKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x208D110", Offset = "0x208C510", VA = "0x18208D110")]
	public void IJEAJIALIMP(LJHBMNCDKEI EKOKJFNEBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x208D260", Offset = "0x208C660", VA = "0x18208D260")]
	public void JGFJHJADKIM(string EHKAFKHKIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x2187EB0", Offset = "0x21872B0", VA = "0x182187EB0")]
	private T EMMONPIONFL<T>(T AGLCIEKHLEE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x208D0C0", Offset = "0x208C4C0", VA = "0x18208D0C0")]
	public void HADJGIKHEOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x2187F90", Offset = "0x2187390", VA = "0x182187F90")]
	[CompilerGenerated]
	internal static string LAKCNGFANHI<T>(byte[] GIJGKJOCENH, int GECDAKMBGDI, ref OOLOHJHFFNJ<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal struct HIOBODJLJNJ
{
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class NKOLAEIDNKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public EEMPEMCEAHC roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public AEEBPABFEDL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public CPBDLHAFGBN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public NKOLAEIDNKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x3A60200", Offset = "0x3A5F600", VA = "0x183A60200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private sealed class FLPGNEBPBPE
	{
		[Cpp2IlInjected.Token(Token = "0x2000123")]
		private sealed class <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004B6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004B7")]
			public CPMEPPENFLB<string>.PEFDMNJICBO timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004B8")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004B9")]
			public FLPGNEBPBPE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004BA")]
			private CPMEPPENFLB<string>.PEFDMNJICBO <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40004BB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600052C")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public <<Run>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052D")]
			[Cpp2IlInjected.Address(RVA = "0x603E780", Offset = "0x603DB80", VA = "0x18603E780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052E")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public FLPGNEBPBPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x3A56870", Offset = "0x3A55C70", VA = "0x183A56870")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task ABIIKCCGPDJ(CPMEPPENFLB<string>.PEFDMNJICBO timer, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private sealed class GPHNJDKIANO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public HIOBODJLJNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private AGRoomRuntimeConfig.Location <locationConfig>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private FLPGNEBPBPE <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private LJHBMNCDKEI <completeMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private object <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private TaskAwaiter<LJHBMNCDKEI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public GPHNJDKIANO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x3A580F0", Offset = "0x3A574F0", VA = "0x183A580F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private sealed class KGPNEPIDAKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public KJEHFDNNDGH version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public KGPNEPIDAKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x3A5BD00", Offset = "0x3A5B100", VA = "0x183A5BD00")]
		internal object CCJOEEJHJLP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x3A5BDE0", Offset = "0x3A5B1E0", VA = "0x183A5BDE0")]
		internal object OMMDGBFPNKH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	private EEMPEMCEAHC MDIBAOPLIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	private AEEBPABFEDL CLCAIFLMLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	private CPBDLHAFGBN NGMMDGIIBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	private bool BALDMDAILKN;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private static readonly ByteString DELKEDOIKJE;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private ENPHMEADLAM OLJLNILBIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x209DAA0", Offset = "0x209CEA0", VA = "0x18209DAA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private KDNPAEGHDGO CLDGCANEAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x209E4F0", Offset = "0x209D8F0", VA = "0x18209E4F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x209E130", Offset = "0x209D530", VA = "0x18209E130")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NKOLAEIDNKF))]
	public static Task FOLFCGOHDPG(EEMPEMCEAHC MDIBAOPLIIF, AEEBPABFEDL CLCAIFLMLCJ, CPBDLHAFGBN NGMMDGIIBLN, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ, bool BALDMDAILKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x209E310", Offset = "0x209D710", VA = "0x18209E310")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GPHNJDKIANO))]
	private Task FOLFCGOHDPG(CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x209DAF0", Offset = "0x209CEF0", VA = "0x18209DAF0")]
	private void EJKMKLNEADP([NotNull] DNADIKEEDJF ONGJJDFLIMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x209E490", Offset = "0x209D890", VA = "0x18209E490")]
	private bool KMFDCMKOFHG(KJEHFDNNDGH LJJHJABONIO, DNADIKEEDJF ONGJJDFLIMK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
internal abstract class NPMBFPENBLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public readonly MOKCCACHPIF BGAIICNFBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public readonly CPBDLHAFGBN OIAJCGJHLLB;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public ENPHMEADLAM OLJLNILBIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x27E1F30", Offset = "0x27E1330", VA = "0x1827E1F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public KDNPAEGHDGO CLDGCANEAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x27E1FA0", Offset = "0x27E13A0", VA = "0x1827E1FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x27E2030", Offset = "0x27E1430", VA = "0x1827E2030")]
	protected NPMBFPENBLA(CPBDLHAFGBN NGMMDGIIBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x27E1F80", Offset = "0x27E1380", VA = "0x1827E1F80")]
	protected void JGFJHJADKIM(string EHKAFKHKIJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
internal class MGKINDOGNEG : NPMBFPENBLA, FGEHDHMGPHB
{
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	public delegate Task<BBGJGBPKMJE> BENOJOAKNMM(AEEBPABFEDL CLCAIFLMLCJ, HHJNDLHLIDF DEDHNBAPGBK, KDKPDCAOKBD FAJCLGECACE, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private sealed class PBLLLDODBLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public OPAHMEFPIDH request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public MGKINDOGNEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private ABAHNLENHPF <lifetime>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private LJHBMNCDKEI <synced>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private LJHBMNCDKEI <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private TaskAwaiter<LJHBMNCDKEI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public PBLLLDODBLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x3C03430", Offset = "0x3C02830", VA = "0x183C03430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private sealed class AJBFGHIBIKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public AsyncTaskMethodBuilder<LJHBMNCDKEI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public OPAHMEFPIDH request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public MGKINDOGNEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <syncTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private LJHBMNCDKEI <message>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private LJHBMNCDKEI <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private TaskAwaiter<LJHBMNCDKEI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public AJBFGHIBIKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x3BF2550", Offset = "0x3BF1950", VA = "0x183BF2550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private sealed class CLJGPBNCCPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public OPAHMEFPIDH request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public MGKINDOGNEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <loadRoomLocalTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public CLJGPBNCCPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x3BF4710", Offset = "0x3BF3B10", VA = "0x183BF4710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class GJHKEKEBMLF
	{
		[Cpp2IlInjected.Token(Token = "0x200012D")]
		private sealed class <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004FB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004FC")]
			public AsyncTaskMethodBuilder<PLLNJBBBBDK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004FD")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004FE")]
			public GJHKEKEBMLF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004FF")]
			private PLLNJBBBBDK <innerData>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000500")]
			private PLLNJBBBBDK <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000501")]
			private TaskAwaiter<BBGJGBPKMJE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000502")]
			private TaskAwaiter<PLLNJBBBBDK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600056B")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public <<LoadRoomLocal>b__2>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600056C")]
			[Cpp2IlInjected.Address(RVA = "0x603D370", Offset = "0x603C770", VA = "0x18603D370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600056D")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012E")]
		private sealed class <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000503")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000504")]
			public AsyncTaskMethodBuilder<AEEBPABFEDL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000505")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000506")]
			public GJHKEKEBMLF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000507")]
			private AEEBPABFEDL <innerPhaseArgs>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000508")]
			private AEEBPABFEDL <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000509")]
			private TaskAwaiter<BBGJGBPKMJE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400050A")]
			private TaskAwaiter<AEEBPABFEDL> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600056E")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public <<LoadRoomLocal>b__4>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600056F")]
			[Cpp2IlInjected.Address(RVA = "0x603DAC0", Offset = "0x603CEC0", VA = "0x18603DAC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000570")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012F")]
		private sealed class <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400050B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400050C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400050D")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400050E")]
			public GJHKEKEBMLF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400050F")]
			private HHJNDLHLIDF <timedYielder>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000510")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000511")]
			private TaskAwaiter<BBGJGBPKMJE> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000571")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public <<LoadRoomLocal>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(RVA = "0x603C320", Offset = "0x603B720", VA = "0x18603C320", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public MGKINDOGNEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public OPAHMEFPIDH request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public KDKPDCAOKBD preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public KDKPDCAOKBD downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public PLLNJBBBBDK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public KDKPDCAOKBD postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public AEEBPABFEDL phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public DIAGOJHAELB.PCBKDJIEKPL <>9__6;

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public GJHKEKEBMLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x3BF78C0", Offset = "0x3BF6CC0", VA = "0x183BF78C0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<PLLNJBBBBDK> DOIEBJHGJCA(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x3BF7750", Offset = "0x3BF6B50", VA = "0x183BF7750")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<AEEBPABFEDL> CLCOFBPJOPC(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x3BF7A30", Offset = "0x3BF6E30", VA = "0x183BF7A30")]
		internal void IOEPDMGLNBI(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x3BF7A70", Offset = "0x3BF6E70", VA = "0x183BF7A70")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task OOKCGAGNHKD(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class JGEADNGACAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public OPAHMEFPIDH request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public MGKINDOGNEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private GJHKEKEBMLF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		private bool <hasAssetBundle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private float <dataDownloadProgressRangeUpperBound>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private PLLNJBBBBDK <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private AEEBPABFEDL <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		private TaskAwaiter<PLLNJBBBBDK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private TaskAwaiter<AEEBPABFEDL> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JGEADNGACAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x3BFCD80", Offset = "0x3BFC180", VA = "0x183BFCD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private sealed class IAPMCLPHAIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public CPMEPPENFLB<string>.PEFDMNJICBO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public MGKINDOGNEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public IAPMCLPHAIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x3BF9C10", Offset = "0x3BF9010", VA = "0x183BF9C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private sealed class MHLPKILPLDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public AEEBPABFEDL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public KDKPDCAOKBD progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public MGKINDOGNEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <legacyLoadRoomDataTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private TaskAwaiter<BBGJGBPKMJE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public MHLPKILPLDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x3C003C0", Offset = "0x3BFF7C0", VA = "0x183C003C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private sealed class IJGDFENIIPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public AsyncTaskMethodBuilder<BBGJGBPKMJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public AEEBPABFEDL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public HHJNDLHLIDF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public KDKPDCAOKBD progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public MGKINDOGNEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <destroyAndRebuildObjectsTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private TaskAwaiter<BBGJGBPKMJE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public IJGDFENIIPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x3BFAD30", Offset = "0x3BFA130", VA = "0x183BFAD30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private sealed class NCKIHKFEANH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public AsyncTaskMethodBuilder<BBGJGBPKMJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public AEEBPABFEDL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public HHJNDLHLIDF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public KDKPDCAOKBD progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public MGKINDOGNEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <deserializeAllObjectsTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private TaskAwaiter<BBGJGBPKMJE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public NCKIHKFEANH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x3C00DA0", Offset = "0x3C001A0", VA = "0x183C00DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private sealed class CLBFNECCOAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public AsyncTaskMethodBuilder<BBGJGBPKMJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public BBGJGBPKMJE operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public AEEBPABFEDL deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public KDKPDCAOKBD progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public MGKINDOGNEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private BBGJGBPKMJE <result>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private BBGJGBPKMJE <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private TaskAwaiter<BBGJGBPKMJE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public CLBFNECCOAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x3BF44F0", Offset = "0x3BF38F0", VA = "0x183BF44F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private sealed class IDJGOMNEAIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public MGKINDOGNEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public AEEBPABFEDL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public KDKPDCAOKBD progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public BENOJOAKNMM masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public HHJNDLHLIDF timedYielder;

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public IDJGOMNEAIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private sealed class ICFEBEOFFIB
	{
		[Cpp2IlInjected.Token(Token = "0x2000139")]
		private sealed class <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400055F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000560")]
			public AsyncTaskMethodBuilder<BBGJGBPKMJE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000561")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000562")]
			public ICFEBEOFFIB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000563")]
			private IDisposable <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000564")]
			private BBGJGBPKMJE <result>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000565")]
			private BBGJGBPKMJE <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000566")]
			private TaskAwaiter<BBGJGBPKMJE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public <<MasterLockedPhaseChangeBlock>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000590")]
			[Cpp2IlInjected.Address(RVA = "0x603E0B0", Offset = "0x603D4B0", VA = "0x18603E0B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000591")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public BBGJGBPKMJE originalRoomLoadPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public IDJGOMNEAIF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public ICFEBEOFFIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x3BFA310", Offset = "0x3BF9710", VA = "0x183BFA310")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<BBGJGBPKMJE> AGAOGHNNNCC(CancellationToken mlToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private sealed class GFGEAECDLJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public AsyncTaskMethodBuilder<BBGJGBPKMJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public AEEBPABFEDL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public HHJNDLHLIDF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public KDKPDCAOKBD progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public BENOJOAKNMM masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public MGKINDOGNEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private IDJGOMNEAIF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private ICFEBEOFFIB <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private BBGJGBPKMJE <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private TaskAwaiter<BBGJGBPKMJE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public GFGEAECDLJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x3BF71F0", Offset = "0x3BF65F0", VA = "0x183BF71F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private sealed class POLPEOJOOEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public AEEBPABFEDL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public KDKPDCAOKBD progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public MGKINDOGNEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		private BBGJGBPKMJE <legacyEndPhase>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private IEnumerator<BBGJGBPKMJE> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private BBGJGBPKMJE <phase>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private TaskAwaiter<BBGJGBPKMJE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public POLPEOJOOEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x3C03EA0", Offset = "0x3C032A0", VA = "0x183C03EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private sealed class ODOOLONJBLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public AEEBPABFEDL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public MGKINDOGNEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public ODOOLONJBLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x3C01AF0", Offset = "0x3C00EF0", VA = "0x183C01AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private sealed class CBDCFOHKHBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public AEEBPABFEDL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public MGKINDOGNEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public CBDCFOHKHBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x3BF2F40", Offset = "0x3BF2340", VA = "0x183BF2F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private readonly IBNOLCFAKOG GLBAGOBDOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private readonly IBNOLCFAKOG CPEIGLNCGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private readonly DLMGJNBMKMD COFHFLANDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	private readonly KMPGBMBDOCO PIEOFIIJBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	private readonly PEIFGELAPEI LOCENONAMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	private readonly AACAPNPHAPG HENKPMPCHKK;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private EEMPEMCEAHC OIFFBBNLCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x20A3F00", Offset = "0x20A3300", VA = "0x1820A3F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event FGJHIBLKFBB DOACPPDFDGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x27DE340", Offset = "0x27DD740", VA = "0x1827DE340", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x27DDCC0", Offset = "0x27DD0C0", VA = "0x1827DDCC0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x27DEE90", Offset = "0x27DE290", VA = "0x1827DEE90")]
	public MGKINDOGNEG(CPBDLHAFGBN NGMMDGIIBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x27DD870", Offset = "0x27DCC70", VA = "0x1827DD870")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PBLLLDODBLE))]
	public Task FAMKGEKBJDM(OPAHMEFPIDH OALKBFHLHKE, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x27DE8E0", Offset = "0x27DDCE0", VA = "0x1827DE8E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AJBFGHIBIKG))]
	private Task<LJHBMNCDKEI> MPBHONHGELP(OPAHMEFPIDH OALKBFHLHKE, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x27DE740", Offset = "0x27DDB40", VA = "0x1827DE740")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CLJGPBNCCPO))]
	private Task MMHDIGEADEB(OPAHMEFPIDH OALKBFHLHKE, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x27DE5A0", Offset = "0x27DD9A0", VA = "0x1827DE5A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JGEADNGACAJ))]
	private Task MENJFJDGGKN(OPAHMEFPIDH OALKBFHLHKE, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken JMHCKDGPOBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x27DD700", Offset = "0x27DCB00", VA = "0x1827DD700")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IAPMCLPHAIA))]
	private Task EOCDFAOEGGK(CPMEPPENFLB<string>.PEFDMNJICBO INJHLEJHFLF, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x27DDD00", Offset = "0x27DD100", VA = "0x1827DDD00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MHLPKILPLDP))]
	private Task HJAACNMBFFL(AEEBPABFEDL CLCAIFLMLCJ, KDKPDCAOKBD FAJCLGECACE, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x27DE0D0", Offset = "0x27DD4D0", VA = "0x1827DE0D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IJGDFENIIPO))]
	private Task<BBGJGBPKMJE> ILIODMHEPNP(AEEBPABFEDL CLCAIFLMLCJ, HHJNDLHLIDF EMPBPHENLHN, KDKPDCAOKBD FAJCLGECACE, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x27DD110", Offset = "0x27DC510", VA = "0x1827DD110")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NCKIHKFEANH))]
	private Task<BBGJGBPKMJE> AFNIHJFCKDO(AEEBPABFEDL CLCAIFLMLCJ, HHJNDLHLIDF EMPBPHENLHN, KDKPDCAOKBD FAJCLGECACE, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x27DDEC0", Offset = "0x27DD2C0", VA = "0x1827DDEC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CLBFNECCOAF))]
	private Task<BBGJGBPKMJE> IAIGMPOEANE(BBGJGBPKMJE LJCPJMIJAKA, AEEBPABFEDL HBIKHDDJPIH, KDKPDCAOKBD FAJCLGECACE, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ, bool AEJNABMOOEB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x27DD650", Offset = "0x27DCA50", VA = "0x1827DD650")]
	private bool EKKHEECCEGP(AEEBPABFEDL JOLFPFHIHLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x27DDA40", Offset = "0x27DCE40", VA = "0x1827DDA40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GFGEAECDLJP))]
	protected Task<BBGJGBPKMJE> GLJGMMCBMKA(AEEBPABFEDL CLCAIFLMLCJ, HHJNDLHLIDF EMPBPHENLHN, KDKPDCAOKBD FAJCLGECACE, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ, BENOJOAKNMM DKKDBBPJODB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x27DD320", Offset = "0x27DC720", VA = "0x1827DD320")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(POLPEOJOOEK))]
	private Task AINIFPEACLF(AEEBPABFEDL CLCAIFLMLCJ, KDKPDCAOKBD FAJCLGECACE, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x27DDC70", Offset = "0x27DD070", VA = "0x1827DDC70")]
	private void HBDMFCHCMAC(BBGJGBPKMJE ACFAJKFKCBH, KDKPDCAOKBD FAJCLGECACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x27DE2E0", Offset = "0x27DD6E0", VA = "0x1827DE2E0")]
	private void IPGNPBCAJGO(BBGJGBPKMJE FPHLDGKPFFH, out BBGJGBPKMJE IEPPCANIHOE, out BBGJGBPKMJE MOFJIGPJKEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x27DEAC0", Offset = "0x27DDEC0", VA = "0x1827DEAC0")]
	private Task<PLLNJBBBBDK> OILBPMMPIND(OPAHMEFPIDH OALKBFHLHKE, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x27DECC0", Offset = "0x27DE0C0", VA = "0x1827DECC0")]
	private Task<AEEBPABFEDL> PDNJBIJLMAE(PLLNJBBBBDK CLCAIFLMLCJ, DIAGOJHAELB.PCBKDJIEKPL AGFIHCBKMJD, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x27DEB00", Offset = "0x27DDF00", VA = "0x1827DEB00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ODOOLONJBLI))]
	private Task OKEJAJBCPEN(AEEBPABFEDL CLCAIFLMLCJ, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ, bool BALDMDAILKN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x27DD4E0", Offset = "0x27DC8E0", VA = "0x1827DD4E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CBDCFOHKHBE))]
	private Task DENHBMKJOPH(AEEBPABFEDL CLCAIFLMLCJ, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x27DED00", Offset = "0x27DE100", VA = "0x1827DED00")]
	private Task PLHJDAPPCBO(AEEBPABFEDL CLCAIFLMLCJ, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x27DDCE0", Offset = "0x27DD0E0", VA = "0x1827DDCE0")]
	private Task HHOKAJIIIMA(AEEBPABFEDL CLCAIFLMLCJ, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x27DEAA0", Offset = "0x27DDEA0", VA = "0x1827DEAA0")]
	private Task OEBEAMNBPCE(AEEBPABFEDL CLCAIFLMLCJ, HHJNDLHLIDF EMPBPHENLHN, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x27DE360", Offset = "0x27DD760", VA = "0x1827DE360")]
	private Task LEJCJFBPKHE(AEEBPABFEDL CLCAIFLMLCJ, HHJNDLHLIDF EMPBPHENLHN, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x27DDA10", Offset = "0x27DCE10", VA = "0x1827DDA10")]
	private static Task FIHBNDDANMP(CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x27DE320", Offset = "0x27DD720", VA = "0x1827DE320")]
	private Task IPOOCAMDGCF(AEEBPABFEDL CLCAIFLMLCJ, HHJNDLHLIDF EMPBPHENLHN, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x27DDA20", Offset = "0x27DCE20", VA = "0x1827DDA20")]
	private Task GBMELCOCAIB(AEEBPABFEDL CLCAIFLMLCJ, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x27DE520", Offset = "0x27DD920", VA = "0x1827DE520")]
	private void LMCPMAANOPH(OPAHMEFPIDH OALKBFHLHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x27DD6E0", Offset = "0x27DCAE0", VA = "0x1827DD6E0")]
	public void ELNCEKFCJFK(long PNFBLDJLDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	private static void BHGINFPNLMA(MFKMLKAPGOD PDHNLEDOMJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
internal abstract class MOKCCACHPIF : FGEHDHMGPHB
{
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	public delegate Task OIDGKJAJEGB(CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private sealed class IFNICACGBGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public CPMEPPENFLB<string>.PEFDMNJICBO operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public MOKCCACHPIF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public IFNICACGBGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x3BFA4F0", Offset = "0x3BF98F0", VA = "0x183BFA4F0")]
		internal Task KNBMNKNBOLH(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private sealed class CLAMOCLIBBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public IFNICACGBGF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public CLAMOCLIBBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x3BF4430", Offset = "0x3BF3830", VA = "0x183BF4430")]
		internal object OEBHIDGDAGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x3BF4370", Offset = "0x3BF3770", VA = "0x183BF4370")]
		internal object FBGMEFOLJJB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class HHAEHIKFNLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public Func<MOKCCACHPIF, CPMEPPENFLB<string>.PEFDMNJICBO, CPBDLHAFGBN> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public MOKCCACHPIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private IFNICACGBGF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private CPBDLHAFGBN <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private Task <drivenTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private LJHBMNCDKEI <completeMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private CLAMOCLIBBB <>8__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private TaskAwaiter<LJHBMNCDKEI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public HHAEHIKFNLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x3BF8C20", Offset = "0x3BF8020", VA = "0x183BF8C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private sealed class CEKIFKEBPCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public MOKCCACHPIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		private OIDGKJAJEGB <taskBuilder>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public CEKIFKEBPCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x3BF3090", Offset = "0x3BF2490", VA = "0x183BF3090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400058E")]
	public readonly Guid OBAAIFGAIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400058F")]
	public readonly ByteString MEGJCGLBGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	public readonly HACHIHGCJBL LDGBIGBBGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	protected readonly string MAGBFLGHCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000592")]
	private readonly EEMPEMCEAHC MDIBAOPLIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000593")]
	private readonly bool NKLHHANHDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000594")]
	private readonly Queue<OIDGKJAJEGB> KBJNNHGLLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	private readonly KDKPDCAOKBD KAGBJMCNPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000596")]
	private readonly EALLAFIMFMG LFJAMNBIHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000597")]
	private bool EKMDAIONLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	public BBGJGBPKMJE GJJEJJFPAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000599")]
	public BBGJGBPKMJE GDKDIPIECEJ;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public EEMPEMCEAHC OIFFBBNLCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x9857F0", Offset = "0x984BF0", VA = "0x1809857F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public ENPHMEADLAM OLJLNILBIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x27DF850", Offset = "0x27DEC50", VA = "0x1827DF850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public MHLDLCLJDPN EEKDFFKICKH
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x27DF800", Offset = "0x27DEC00", VA = "0x1827DF800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public KDNPAEGHDGO CLDGCANEAEH
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x27E0110", Offset = "0x27DF510", VA = "0x1827E0110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event FGJHIBLKFBB DOACPPDFDGA
	{
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x27E0030", Offset = "0x27DF430", VA = "0x1827E0030", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x27DFEA0", Offset = "0x27DF2A0", VA = "0x1827DFEA0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x27E0190", Offset = "0x27DF590", VA = "0x1827E0190")]
	protected MOKCCACHPIF(Guid JIDMDNKJFGM, EEMPEMCEAHC MDIBAOPLIIF, HACHIHGCJBL FPKJCMGGANH, string OLMANHEIJGK, EALLAFIMFMG LFJAMNBIHGB, bool NKLHHANHDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x27E00B0", Offset = "0x27DF4B0", VA = "0x1827E00B0", Slot = "6")]
	protected virtual string KDFLOOJFGGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x27E0050", Offset = "0x27DF450", VA = "0x1827E0050")]
	public void KAPBMKPCECB(OIDGKJAJEGB NGNIPMJCNIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x27E00F0", Offset = "0x27DF4F0", VA = "0x1827E00F0")]
	protected void MIILNPMMJAD(float LPFEMKLCPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x27DFAF0", Offset = "0x27DEEF0", VA = "0x1827DFAF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HHAEHIKFNLP))]
	public Task FOLFCGOHDPG(CancellationToken ODBDCIFDKPJ, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, [Optional] Func<MOKCCACHPIF, CPMEPPENFLB<string>.PEFDMNJICBO, CPBDLHAFGBN> OABIAEJPLHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x27DFC90", Offset = "0x27DF090", VA = "0x1827DFC90")]
	private void GHDANIKJCOE(bool PKEPEKOBHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x27DF980", Offset = "0x27DED80", VA = "0x1827DF980")]
	private void FLCLAFFJAGP(CPBDLHAFGBN NGMMDGIIBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task MHNOKJCCNLP(CPBDLHAFGBN NGMMDGIIBLN, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x27DFEC0", Offset = "0x27DF2C0", VA = "0x1827DFEC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CEKIFKEBPCP))]
	private Task IDGNONKCMAL(CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x27DFE10", Offset = "0x27DF210", VA = "0x1827DFE10")]
	public LJHBMNCDKEI GJBJCGJGBIJ(FCINIFPDHLP FKOBNAMIAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x27DF8A0", Offset = "0x27DECA0", VA = "0x1827DF8A0")]
	[CompilerGenerated]
	private Task FBFKIJIIMHP(CancellationToken NINFMGLENJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
internal abstract class GIDJDKALFAF : MOKCCACHPIF
{
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private sealed class FPMNNIAECEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public GIDJDKALFAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public FPALKFHNKOB playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public FPMNNIAECEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x3A57790", Offset = "0x3A56B90", VA = "0x183A57790")]
		internal Task FHHKPELGGGJ(CPMEPPENFLB<string>.PEFDMNJICBO postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x3A577D0", Offset = "0x3A56BD0", VA = "0x183A577D0")]
		internal object OCNHMIANJFH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private sealed class ILCLGIAGJOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public CPBDLHAFGBN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public GIDJDKALFAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private FPMNNIAECEC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private object <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private int <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private DKAMADKEEIF <recoverableRoomOperationException>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public ILCLGIAGJOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x3A58FC0", Offset = "0x3A583C0", VA = "0x183A58FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class IICNMLLIDIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public FPALKFHNKOB playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public CPMEPPENFLB<string>.PEFDMNJICBO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public GIDJDKALFAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		private Exception <e>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public IICNMLLIDIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x3A58AA0", Offset = "0x3A57EA0", VA = "0x183A58AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x209A190", Offset = "0x2099590", VA = "0x18209A190")]
	public GIDJDKALFAF(Guid JIDMDNKJFGM, EEMPEMCEAHC MDIBAOPLIIF, HACHIHGCJBL FPKJCMGGANH, string OLMANHEIJGK, EALLAFIMFMG LFJAMNBIHGB, bool NKLHHANHDKF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x2099FF0", Offset = "0x20993F0", VA = "0x182099FF0", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ILCLGIAGJOL))]
	protected override Task MHNOKJCCNLP(CPBDLHAFGBN NGMMDGIIBLN, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task FGKDJFEPLEF(CPBDLHAFGBN NGMMDGIIBLN, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x2099E50", Offset = "0x2099250", VA = "0x182099E50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IICNMLLIDIO))]
	private Task AKJPLPAHEMG(IDisposable HOJDKHAEIJC, FPALKFHNKOB ODFKGEMPFKO, CPMEPPENFLB<string>.PEFDMNJICBO INJHLEJHFLF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
public readonly struct DPAKJIPJCJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CC")]
	public readonly DNADIKEEDJF? GANACBGNCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005CD")]
	public readonly PCAEOBOCMGB JBCBBIAAFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	public readonly string? EHCJGHMMCGE;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public IReadOnlyCollection<string> GCDDKBKHIKA
	{
		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x2093A70", Offset = "0x2092E70", VA = "0x182093A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public IReadOnlyDictionary<long, int> KJCLHDCOPDA
	{
		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x2093A90", Offset = "0x2092E90", VA = "0x182093A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x2093AB0", Offset = "0x2092EB0", VA = "0x182093AB0")]
	public DPAKJIPJCJD(DNADIKEEDJF? LGMMPALIFIG, PCAEOBOCMGB OHEOGPOOFGO, string? FFEMBJOCHMB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal struct DBGAIOJGMAB
{
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private sealed class JCLCHFMIDMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public CPBDLHAFGBN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public AEEBPABFEDL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private MOKCCACHPIF <operation>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private EEMPEMCEAHC <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private JHAGEABDIDH.DCOGDPFENCB <instantiations>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private TaskAwaiter<LJHBMNCDKEI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JCLCHFMIDMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x27D7D40", Offset = "0x27D7140", VA = "0x1827D7D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class NCMLGNEIPDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public NCMLGNEIPDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x27E02D0", Offset = "0x27DF6D0", VA = "0x1827E02D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x208E190", Offset = "0x208D590", VA = "0x18208E190")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JCLCHFMIDMK))]
	public static Task FOLFCGOHDPG(CPBDLHAFGBN NGMMDGIIBLN, AEEBPABFEDL CLCAIFLMLCJ, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x208E330", Offset = "0x208D730", VA = "0x18208E330")]
	private static Task<LJHBMNCDKEI> HKIDOKLMCIH(CPBDLHAFGBN NGMMDGIIBLN, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x208E090", Offset = "0x208D490", VA = "0x18208E090")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NCMLGNEIPDO))]
	private static Task FCJFODGHBLO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal class GFDHIMNMAKL : MOKCCACHPIF
{
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class LOBPJOAKBIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public CPBDLHAFGBN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public GFDHIMNMAKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		private ObscuredInt <localPlayerAccountId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private JLHDIGLBFCK <uploadLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private bool <readSuccessfully>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private DPAKJIPJCJD <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		private ICKFPGBDHLK <payload>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private DateTime <localTime>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		private NGIGNBDICFJ <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		private TaskAwaiter<NGIGNBDICFJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public LOBPJOAKBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x3A5D7D0", Offset = "0x3A5CBD0", VA = "0x183A5D7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	private readonly int HDPDPDGMGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	private readonly MANOJAHNIFE LGMCHOGOHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	public readonly long GILNINBAGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	public readonly long DLOBBFCMKEM;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public NGIGNBDICFJ IFNEBNBIBLN
	{
		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x9B8210", Offset = "0x9B7610", VA = "0x1809B8210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0xB9E0E0", Offset = "0xB9D4E0", VA = "0x180B9E0E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x2098540", Offset = "0x2097940", VA = "0x182098540")]
	public GFDHIMNMAKL(Guid JIDMDNKJFGM, EEMPEMCEAHC MDIBAOPLIIF, HACHIHGCJBL FPKJCMGGANH, int HDPDPDGMGKI, MANOJAHNIFE LGMCHOGOHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x20983A0", Offset = "0x20977A0", VA = "0x1820983A0", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LOBPJOAKBIK))]
	protected override Task MHNOKJCCNLP(CPBDLHAFGBN NGMMDGIIBLN, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal struct PEIFGELAPEI
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class LIACAFCFMGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public AsyncTaskMethodBuilder<BBGJGBPKMJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public BBGJGBPKMJE nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public AEEBPABFEDL deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public PEIFGELAPEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <moveToPhaseTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private Guid <handlersGuid>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		private BBGJGBPKMJE <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		private TaskAwaiter<BBGJGBPKMJE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public LIACAFCFMGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x603A0F0", Offset = "0x60394F0", VA = "0x18603A0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private sealed class FACFDKCNKGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public AsyncTaskMethodBuilder<BBGJGBPKMJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public BBGJGBPKMJE state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public PEIFGELAPEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		private LJHBMNCDKEI <message>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		private LJHBMNCDKEI <returnMessage>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		private BBGJGBPKMJE <authorityPhase>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		private LJHBMNCDKEI <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private TaskAwaiter<LJHBMNCDKEI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public FACFDKCNKGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x6037F10", Offset = "0x6037310", VA = "0x186037F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private readonly CPBDLHAFGBN NGMMDGIIBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private readonly DLMGJNBMKMD COFHFLANDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private readonly KMPGBMBDOCO PIEOFIIJBJN;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private MOKCCACHPIF BGAIICNFBOC
	{
		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x27E81E0", Offset = "0x27E75E0", VA = "0x1827E81E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x27E8620", Offset = "0x27E7A20", VA = "0x1827E8620")]
	public PEIFGELAPEI(CPBDLHAFGBN NGMMDGIIBLN, DLMGJNBMKMD COFHFLANDJM, KMPGBMBDOCO PIEOFIIJBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x27E8200", Offset = "0x27E7600", VA = "0x1827E8200")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LIACAFCFMGD))]
	public Task<BBGJGBPKMJE> GHFLDDMJHHH(BBGJGBPKMJE BAGBHFFHCEK, AEEBPABFEDL HBIKHDDJPIH, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ, bool AEJNABMOOEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x27E8450", Offset = "0x27E7850", VA = "0x1827E8450")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FACFDKCNKGF))]
	private Task<BBGJGBPKMJE> MJKOLGKOKOD(CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, BBGJGBPKMJE HEAMCFPFNOL, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x27E8420", Offset = "0x27E7820", VA = "0x1827E8420")]
	private bool JJKFIDLFNMF(BBGJGBPKMJE MAMHPAAANLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x27E8400", Offset = "0x27E7800", VA = "0x1827E8400")]
	private void JGFJHJADKIM(string FENGPJBOMEE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal struct OGNMFFCHACL
{
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private sealed class IJFNNDHOMLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public CPBDLHAFGBN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public AEEBPABFEDL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public HHJNDLHLIDF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		private MOKCCACHPIF <operation>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		private BBGJGBPKMJE <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		private EEMPEMCEAHC <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		private ENPHMEADLAM <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		private MJJOHDCCLOJ <metrics>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		private IDisposable <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private List<(PersistenceView, FEKGKBGNILG)>.Enumerator <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		private PersistenceView <view>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		private FEKGKBGNILG <viewData>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public IJFNNDHOMLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x3BFA520", Offset = "0x3BF9920", VA = "0x183BFA520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x27E4990", Offset = "0x27E3D90", VA = "0x1827E4990")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IJFNNDHOMLI))]
	public static Task FOLFCGOHDPG(CPBDLHAFGBN NGMMDGIIBLN, AEEBPABFEDL CLCAIFLMLCJ, HHJNDLHLIDF EMPBPHENLHN, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x27E4B50", Offset = "0x27E3F50", VA = "0x1827E4B50")]
	private static void MOPCFCBGBNC(PersistenceView CKAMNJPHKHD, FEKGKBGNILG KEHGNKBKDPC, AEEBPABFEDL CLCAIFLMLCJ, BBGJGBPKMJE LJCPJMIJAKA, bool AEKPMJCEPPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
internal class PDAPGAJCBAI : NPMBFPENBLA
{
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class BJNNGABIFFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public AsyncTaskMethodBuilder<DPAKJIPJCJD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public PHHKJAPOHHP roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public NDLJIBMEGPJ serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public PDAPGAJCBAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private StringBuilder <outputBuilder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private IDisposable <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public BJNNGABIFFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x60360F0", Offset = "0x60354F0", VA = "0x1860360F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private sealed class OBDFLAFNNCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public NDLJIBMEGPJ serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public PDAPGAJCBAI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public OBDFLAFNNCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x603B1A0", Offset = "0x603A5A0", VA = "0x18603B1A0")]
		internal Task PHACOHODECO(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x603B0D0", Offset = "0x603A4D0", VA = "0x18603B0D0")]
		internal Task CJKCDEIFDPM(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private sealed class PEHHLCPGOJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public OBDFLAFNNCM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public PEHHLCPGOJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x603C150", Offset = "0x603B550", VA = "0x18603C150")]
		internal object LLNLGJPJLKF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class DGLKBJCGKOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public OBDFLAFNNCM CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public DGLKBJCGKOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x6037ED0", Offset = "0x60372D0", VA = "0x186037ED0")]
		internal Task INOJELGKLGG(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private sealed class CILNBLMAIIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public NDLJIBMEGPJ serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public PDAPGAJCBAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private OBDFLAFNNCM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private PEHHLCPGOJO <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private IEnumerable<Task> <pendingPreserializes>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public CILNBLMAIIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x6036650", Offset = "0x6035A50", VA = "0x186036650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000626")]
	private readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x4000627")]
	private static readonly TimeSpan ELHOJMFIPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000628")]
	private readonly OLKAHIPIKGB CFGFMPMOALJ;

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x27E8150", Offset = "0x27E7550", VA = "0x1827E8150")]
	public PDAPGAJCBAI(CPBDLHAFGBN NGMMDGIIBLN, OLKAHIPIKGB CFGFMPMOALJ, EHKEPJIBENP IGCLICKKCHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x27E7320", Offset = "0x27E6720", VA = "0x1827E7320")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BJNNGABIFFH))]
	public Task<DPAKJIPJCJD> CJMDONJKOCN(long LHBCPOODKNA, PHHKJAPOHHP OCDPCNGENKJ, NDLJIBMEGPJ FCLAKIBKNNH, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x27E6F50", Offset = "0x27E6350", VA = "0x1827E6F50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CILNBLMAIIP))]
	private Task BFOHDDLKGOC(NDLJIBMEGPJ FCLAKIBKNNH, IEnumerable<PersistenceView> MHGONBHOMPC, StringBuilder AAOABCINEDB, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x27E74F0", Offset = "0x27E68F0", VA = "0x1827E74F0")]
	private DPAKJIPJCJD CMGAICOLMOA(long LHBCPOODKNA, PHHKJAPOHHP OCDPCNGENKJ, NDLJIBMEGPJ FCLAKIBKNNH, IEnumerable<PersistenceView> MHGONBHOMPC, StringBuilder AAOABCINEDB)
	{
		return default(DPAKJIPJCJD);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x27E7F60", Offset = "0x27E7360", VA = "0x1827E7F60")]
	private DNADIKEEDJF NHMCFLEKGEC(long LHBCPOODKNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x27E7110", Offset = "0x27E6510", VA = "0x1827E7110")]
	private void CDAFGBKHJJG(DNADIKEEDJF IPKBLGEECJA, StringBuilder AAOABCINEDB, IEnumerable<PersistenceView> MHGONBHOMPC, in FOIHEPLEJIL FHFLBNIDGKJ, FILJMAGHIDF LPFPIDIGDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x27E7A50", Offset = "0x27E6E50", VA = "0x1827E7A50")]
	private void MDAFPILOAJH(DNADIKEEDJF IPKBLGEECJA, StringBuilder AAOABCINEDB, PersistenceView CKAMNJPHKHD, ref FILJMAGHIDF LPFPIDIGDHB, in FOIHEPLEJIL FHFLBNIDGKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015B")]
internal class KOFGDIOHFOE : MOKCCACHPIF
{
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class PAMIDOFILJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public CPBDLHAFGBN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public KOFGDIOHFOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private PHHKJAPOHHP <roomSaveOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		private PDAPGAJCBAI <serializeLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		private NDLJIBMEGPJ <serializeType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		private DPAKJIPJCJD <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		private DPAKJIPJCJD <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		private Exception <ex>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		private TaskAwaiter<DPAKJIPJCJD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public PAMIDOFILJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x3C02D20", Offset = "0x3C02120", VA = "0x183C02D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400064D")]
	private readonly HBJIMGJNMKE JKNMNCOCLMI;

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x27DBE10", Offset = "0x27DB210", VA = "0x1827DBE10")]
	public KOFGDIOHFOE(Guid JIDMDNKJFGM, EEMPEMCEAHC MDIBAOPLIIF, HACHIHGCJBL FPKJCMGGANH, HBJIMGJNMKE JKNMNCOCLMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x27DBB90", Offset = "0x27DAF90", VA = "0x1827DBB90", Slot = "6")]
	protected override string KDFLOOJFGGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x27DBC70", Offset = "0x27DB070", VA = "0x1827DBC70", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PAMIDOFILJP))]
	protected override Task MHNOKJCCNLP(CPBDLHAFGBN NGMMDGIIBLN, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
internal struct ANIEFLBIPML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400065D")]
	public Dictionary<Guid, List<IAAIDDIJMBP>> KHCGNDOGNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400065E")]
	public Dictionary<Guid, List<IAAIDDIJMBP>> ONBGOCNJKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400065F")]
	public Dictionary<Guid, List<IAAIDDIJMBP>> NEJPCEJCEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000660")]
	public List<Guid> NCBBMDMGFNM;

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x2087C40", Offset = "0x2087040", VA = "0x182087C40")]
	public static ANIEFLBIPML PHGLOPEHIMO(ENPHMEADLAM EOPIGBOAJOB, BBGJGBPKMJE LJCPJMIJAKA, AEEBPABFEDL HBIKHDDJPIH)
	{
		return default(ANIEFLBIPML);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
public readonly struct FEPCCPLBANJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000664")]
	public readonly bool FFPEECKOAGJ;

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0xCA7800", Offset = "0xCA6C00", VA = "0x180CA7800")]
	public FEPCCPLBANJ(bool NNHFAHEBCAN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal struct HECGJJEKPJO
{
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class NEMEOOPPEGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public MOKCCACHPIF operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public AEEBPABFEDL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public HHJNDLHLIDF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private BBGJGBPKMJE <state>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private IDisposable <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private List<(PersistenceView, FEKGKBGNILG)>.Enumerator <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private (PersistenceView, FEKGKBGNILG) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		private PersistenceView <view>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		private CEGCGPAEAPL <postDeserializeParams>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public NEMEOOPPEGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x3A5F080", Offset = "0x3A5E480", VA = "0x183A5F080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x209D280", Offset = "0x209C680", VA = "0x18209D280")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NEMEOOPPEGM))]
	public static Task FOLFCGOHDPG(MOKCCACHPIF CMBFEPDDNLN, AEEBPABFEDL CLCAIFLMLCJ, HHJNDLHLIDF EMPBPHENLHN, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
internal struct CNCIHNJLLJF
{
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class DEPBBFNJMIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public AsyncTaskMethodBuilder<AEEBPABFEDL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public DIAGOJHAELB.PCBKDJIEKPL downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public CNCIHNJLLJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <downloadTimerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		private Task<ADOGIEMPLPD<BPMAKGGBAAK, OMNBHFGADPA>> <assetBundleTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		private Task<ADOGIEMPLPD<LBJGNEPGLFD<DNADIKEEDJF>, OMNBHFGADPA>> <subRoomTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		private Task<ADOGIEMPLPD<LBJGNEPGLFD<JEDGOKEIKMD>, OMNBHFGADPA>> <superRoomTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		private Task<ADOGIEMPLPD<LBJGNEPGLFD<LLLDIPNEBLP>, OMNBHFGADPA>> <playerSaveTask>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		private Task<(ADOGIEMPLPD<BPMAKGGBAAK, OMNBHFGADPA>, ADOGIEMPLPD<LBJGNEPGLFD<DNADIKEEDJF>, OMNBHFGADPA>, ADOGIEMPLPD<LBJGNEPGLFD<JEDGOKEIKMD>, OMNBHFGADPA>, ADOGIEMPLPD<LBJGNEPGLFD<LLLDIPNEBLP>, OMNBHFGADPA>)> <allTasks>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		private ADOGIEMPLPD<BPMAKGGBAAK, OMNBHFGADPA> <assetBundleSource>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		private ADOGIEMPLPD<LBJGNEPGLFD<DNADIKEEDJF>, OMNBHFGADPA> <subRoomDataRes>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		private ADOGIEMPLPD<LBJGNEPGLFD<JEDGOKEIKMD>, OMNBHFGADPA> <superRoomDataRes>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private ADOGIEMPLPD<LBJGNEPGLFD<LLLDIPNEBLP>, OMNBHFGADPA> <playerSaveDataRes>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		private LBJGNEPGLFD<DNADIKEEDJF> <room>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		private (ADOGIEMPLPD<BPMAKGGBAAK, OMNBHFGADPA>, ADOGIEMPLPD<LBJGNEPGLFD<DNADIKEEDJF>, OMNBHFGADPA>, ADOGIEMPLPD<LBJGNEPGLFD<JEDGOKEIKMD>, OMNBHFGADPA>, ADOGIEMPLPD<LBJGNEPGLFD<LLLDIPNEBLP>, OMNBHFGADPA>) <>s__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private (ADOGIEMPLPD<BPMAKGGBAAK, OMNBHFGADPA>, ADOGIEMPLPD<LBJGNEPGLFD<DNADIKEEDJF>, OMNBHFGADPA>, ADOGIEMPLPD<LBJGNEPGLFD<JEDGOKEIKMD>, OMNBHFGADPA>, ADOGIEMPLPD<LBJGNEPGLFD<LLLDIPNEBLP>, OMNBHFGADPA>) <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private TaskAwaiter<(ADOGIEMPLPD<BPMAKGGBAAK, OMNBHFGADPA>, ADOGIEMPLPD<LBJGNEPGLFD<DNADIKEEDJF>, OMNBHFGADPA>, ADOGIEMPLPD<LBJGNEPGLFD<JEDGOKEIKMD>, OMNBHFGADPA>, ADOGIEMPLPD<LBJGNEPGLFD<LLLDIPNEBLP>, OMNBHFGADPA>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public DEPBBFNJMIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x27D22F0", Offset = "0x27D16F0", VA = "0x1827D22F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class JDKOCMLCLHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public AsyncTaskMethodBuilder<ADOGIEMPLPD<BPMAKGGBAAK, OMNBHFGADPA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public DIAGOJHAELB.PCBKDJIEKPL downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public CPMEPPENFLB<string>.PEFDMNJICBO downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public CNCIHNJLLJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		private ADOGIEMPLPD<BPMAKGGBAAK, OMNBHFGADPA> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private TaskAwaiter<ADOGIEMPLPD<BPMAKGGBAAK, OMNBHFGADPA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JDKOCMLCLHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x27D8290", Offset = "0x27D7690", VA = "0x1827D8290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000673")]
	private LBEOEJEGOBG<DJFLKAMMCHF, JEDGOKEIKMD> DEPNJFEIMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	private LBEOEJEGOBG<DJFLKAMMCHF, DNADIKEEDJF> MKOFCKCLOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000675")]
	private LBEOEJEGOBG<long, LLLDIPNEBLP> MMKHKIALMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000676")]
	private OMBNINLPKPC FAGDLOEPOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000677")]
	private MFKMLKAPGOD PDHNLEDOMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000678")]
	private LENKAENGBGK DAIGEGBFOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000679")]
	private string FFEMBJOCHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400067A")]
	private DJFLKAMMCHF OOGBKJBIGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400067B")]
	private DJFLKAMMCHF AAOHIBIMLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400067C")]
	private long PNFBLDJLDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400067D")]
	private CPMEPPENFLB<string>.PEFDMNJICBO INJHLEJHFLF;

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x208B8A0", Offset = "0x208ACA0", VA = "0x18208B8A0")]
	public static Task<AEEBPABFEDL> AOHHCCJKCMA(EEMPEMCEAHC MDIBAOPLIIF, in PLLNJBBBBDK CLCAIFLMLCJ, DIAGOJHAELB.PCBKDJIEKPL AGFIHCBKMJD, CPMEPPENFLB<string>.PEFDMNJICBO INJHLEJHFLF, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x208BC00", Offset = "0x208B000", VA = "0x18208BC00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DEPBBFNJMIN))]
	private Task<AEEBPABFEDL> FOLFCGOHDPG(DIAGOJHAELB.PCBKDJIEKPL AGFIHCBKMJD, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x208BDD0", Offset = "0x208B1D0", VA = "0x18208BDD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JDKOCMLCLHC))]
	private Task<ADOGIEMPLPD<BPMAKGGBAAK, OMNBHFGADPA>> LBJKBHDJJKF(string FFEMBJOCHMB, long PNFBLDJLDCL, DIAGOJHAELB.PCBKDJIEKPL AGFIHCBKMJD, CPMEPPENFLB<string>.PEFDMNJICBO MEIGHMMMGNJ, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
public class DLMGJNBMKMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400069E")]
	private readonly IAJGLGCJAOD MEILFEKOGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400069F")]
	private string GNOPEPJJHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006A0")]
	private long? DMLMMALONIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006A1")]
	private long? GBIFNEIBNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006A2")]
	private long? PKPFBPNHHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40006A3")]
	private string PLLAFDONKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006A4")]
	private BBGJGBPKMJE EFJNJMPJKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006A5")]
	private long? PLPDJILMMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006A6")]
	private bool LKEJMNMEBLA;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public string GFOMIJGEGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public long BHDCGNNJLAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x2093150", Offset = "0x2092550", VA = "0x182093150")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public long ILALCCAMLAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x2092D00", Offset = "0x2092100", VA = "0x182092D00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public long HENLPELIALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x20930B0", Offset = "0x20924B0", VA = "0x1820930B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public string OHHHNNEHOOG
	{
		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x2093110", Offset = "0x2092510", VA = "0x182093110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public BBGJGBPKMJE DNBJBEIDPIG
	{
		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x9FF5F0", Offset = "0x9FE9F0", VA = "0x1809FF5F0")]
		get
		{
			return default(BBGJGBPKMJE);
		}
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x2092F70", Offset = "0x2092370", VA = "0x182092F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public long LNCJNIEPICI
	{
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x2093050", Offset = "0x2092450", VA = "0x182093050")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x2093A00", Offset = "0x2092E00", VA = "0x182093A00")]
	[UnityEngine.Scripting.Preserve]
	public DLMGJNBMKMD([JLJFOFICIEA(null)] IAJGLGCJAOD MEILFEKOGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x2092D60", Offset = "0x2092160", VA = "0x182092D60")]
	private void DMGODIEFIEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x20931B0", Offset = "0x20925B0", VA = "0x1820931B0")]
	public void MHNOHIMOFCF(long KFHMHOFPIPN, long LHBCPOODKNA, [Optional] long? PNFBLDJLDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x2092C60", Offset = "0x2092060", VA = "0x182092C60")]
	public void AHAKJDAEAPI(long PNFBLDJLDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x2093600", Offset = "0x2092A00", VA = "0x182093600")]
	public void OGNJPGOFAFE(string ABDFDJCMFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x2093680", Offset = "0x2092A80", VA = "0x182093680")]
	public void POBEEHHIMJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
internal sealed class CNGHAPPENLE : MOKCCACHPIF
{
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private sealed class KFGNJKFJOGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public KFGNJKFJOGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x27DA600", Offset = "0x27D9A00", VA = "0x1827DA600")]
		internal object GOINEOOFNLD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private sealed class LDJFACDLLFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public CPBDLHAFGBN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public CNGHAPPENLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		private BJJLKBCPMFA <presence>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		private MGKINDOGNEG <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public LDJFACDLLFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x27DBF70", Offset = "0x27DB370", VA = "0x1827DBF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class IIKILGMGBFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public CNGHAPPENLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private MFKMLKAPGOD <roomDetailsDTO>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private bool <omIsEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private byte <omSaveVersion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private MFKMLKAPGOD <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		private byte <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private TaskAwaiter<MFKMLKAPGOD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public IIKILGMGBFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x27D4CC0", Offset = "0x27D40C0", VA = "0x1827D4CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class GLBMPJBDEIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public CNGHAPPENLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		private OPAHMEFPIDH <loadInfo>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		private KFJCLNMFLAB <subRoomSaveData>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		private KFJCLNMFLAB <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		private TaskAwaiter<KFJCLNMFLAB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public GLBMPJBDEIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x27D3740", Offset = "0x27D2B40", VA = "0x1827D3740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class BIOAGPOPPNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public BJJLKBCPMFA presence;

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public BIOAGPOPPNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x27D10A0", Offset = "0x27D04A0", VA = "0x1827D10A0")]
		internal object NOOOKPBNDBJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006A7")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x40006A8")]
	private static readonly EHKEPJIBENP IPKOIFFPNCG;

	[Cpp2IlInjected.Token(Token = "0x40006A9")]
	private static readonly EHKEPJIBENP EHKPBHOOFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40006AA")]
	private readonly OPAHMEFPIDH FHMHKPCFBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006AB")]
	private readonly GIFLFLGKBIH BMMMMGGHBHB;

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x208C930", Offset = "0x208BD30", VA = "0x18208C930")]
	public CNGHAPPENLE(OPAHMEFPIDH FHMHKPCFBEH, GIFLFLGKBIH BMMMMGGHBHB, Guid JIDMDNKJFGM, EEMPEMCEAHC MDIBAOPLIIF, HACHIHGCJBL FPKJCMGGANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x208C680", Offset = "0x208BA80", VA = "0x18208C680", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LDJFACDLLFG))]
	protected override Task MHNOKJCCNLP(CPBDLHAFGBN NGMMDGIIBLN, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x208C3C0", Offset = "0x208B7C0", VA = "0x18208C3C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IIKILGMGBFN))]
	private Task FJDLLGFKIPL(CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x208C510", Offset = "0x208B910", VA = "0x18208C510")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GLBMPJBDEIE))]
	private Task<byte> JCLMMNKNAAM(CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x208C000", Offset = "0x208B400", VA = "0x18208C000")]
	private BJJLKBCPMFA DAOBKBAGMAG()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200016C")]
internal struct KNCDNHDCDGK
{
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class DLFBBJEPGBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public EEMPEMCEAHC roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public AEEBPABFEDL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		private bool <isMaster>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public DLFBBJEPGBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x3BF5610", Offset = "0x3BF4A10", VA = "0x183BF5610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x27DBA20", Offset = "0x27DAE20", VA = "0x1827DBA20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DLFBBJEPGBD))]
	public static Task FOLFCGOHDPG(EEMPEMCEAHC MDIBAOPLIIF, AEEBPABFEDL CLCAIFLMLCJ, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
internal struct NEDFCNJDGOP
{
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private sealed class KDOKONJKBNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		public NEDFCNJDGOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		private FNHFBEHPHCF <sceneLocation>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		private string <sceneName>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		private Scene <mainScene>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		private Scene <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public KDOKONJKBNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x3BFE260", Offset = "0x3BFD660", VA = "0x183BFE260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private sealed class AOGEOLJJBPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public AOGEOLJJBPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x3BF28D0", Offset = "0x3BF1CD0", VA = "0x183BF28D0")]
		internal object MIHDIGBPLMO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class KPJGDCEHCDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public NEDFCNJDGOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		private AOGEOLJJBPM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private EHHGGHOBIAA <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		private Scene <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public KPJGDCEHCDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x3BFE750", Offset = "0x3BFDB50", VA = "0x183BFE750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D3")]
	private FNHFBEHPHCF IIDFIFDAGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006D4")]
	private CPMEPPENFLB<string>.PEFDMNJICBO INJHLEJHFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	private EEMPEMCEAHC MDIBAOPLIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006D6")]
	private bool FEFLGAFBBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	private AEEBPABFEDL CLCAIFLMLCJ;

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x27E0590", Offset = "0x27DF990", VA = "0x1827E0590")]
	public static Task<Scene> EFJFMDGFFLD(EEMPEMCEAHC MDIBAOPLIIF, FNHFBEHPHCF AHBHBANMPHM, CPMEPPENFLB<string>.PEFDMNJICBO INJHLEJHFLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x27E0610", Offset = "0x27DFA10", VA = "0x1827E0610")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KDOKONJKBNO))]
	private Task<Scene> FOLFCGOHDPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x27E0560", Offset = "0x27DF960", VA = "0x1827E0560")]
	private bool AOEGPGFIEMA(AEEBPABFEDL CLCAIFLMLCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x27E08F0", Offset = "0x27DFCF0", VA = "0x1827E08F0")]
	private void MFJDFKIPKIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x27E0770", Offset = "0x27DFB70", VA = "0x1827E0770")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KPJGDCEHCDM))]
	private Task<Scene> KFKKIFCHHMH(string HGLBIHJJLGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
public abstract class PMFHPCDHJOG<T> where T : PMFHPCDHJOG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006EB")]
	internal readonly EEMPEMCEAHC KJPLNFCPFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006EC")]
	private int? KAKAOGFMFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006ED")]
	protected readonly Guid OBAAIFGAIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006EE")]
	protected readonly PMDGAPKKPNC MAEGKJPBKIC;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	protected T DDGBACNEBAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x3D0F470", Offset = "0x3D0E870", VA = "0x183D0F470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x3D0F4D0", Offset = "0x3D0E8D0", VA = "0x183D0F4D0")]
	internal PMFHPCDHJOG(EEMPEMCEAHC KFFEJBKKICE, PMDGAPKKPNC OOOABFDGACF, [Optional] Guid? JIDMDNKJFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x3D0F120", Offset = "0x3D0E520", VA = "0x183D0F120")]
	private LJHBMNCDKEI AMBHNLFLEDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "4")]
	protected virtual void MOKKPGOPONL(LJHBMNCDKEI FHDJIGKOLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x3D0F390", Offset = "0x3D0E790", VA = "0x183D0F390")]
	public T PBMKAAEGINK(NJNAENGEJEB DOHCAABJNHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x3D0F210", Offset = "0x3D0E610", VA = "0x183D0F210")]
	public T DFGLBFNCBDB(int OBFNOBLGOMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x3D0F290", Offset = "0x3D0E690", VA = "0x183D0F290", Slot = "5")]
	public virtual Task<EIDINADMANL> MNNJEIIIBMB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
public class LJMNFMIEBEA : PMFHPCDHJOG<LJMNFMIEBEA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006EF")]
	private OPAHMEFPIDH HOJNLEBJGLH;

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x27DC740", Offset = "0x27DBB40", VA = "0x1827DC740")]
	internal LJMNFMIEBEA(EEMPEMCEAHC KFFEJBKKICE, PMDGAPKKPNC OOOABFDGACF, [Optional] Guid? JIDMDNKJFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x27DC650", Offset = "0x27DBA50", VA = "0x1827DC650")]
	public LJMNFMIEBEA IPHLHLKAPPC(OPAHMEFPIDH HOJNLEBJGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x27DC670", Offset = "0x27DBA70", VA = "0x1827DC670", Slot = "4")]
	protected override void MOKKPGOPONL(LJHBMNCDKEI FHDJIGKOLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
public class CBINNBJHFGJ : PMFHPCDHJOG<CBINNBJHFGJ>
{
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	internal enum GLAMMGAPAOF
	{
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		RecNet
	}

	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private sealed class COBCKNBJENP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public AsyncTaskMethodBuilder<EIDINADMANL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public CBINNBJHFGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		private EIDINADMANL <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		private TaskAwaiter<EIDINADMANL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public COBCKNBJENP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x27D1F00", Offset = "0x27D1300", VA = "0x1827D1F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006F0")]
	private GLAMMGAPAOF AFFALBDNGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006F1")]
	private string DEFNKEMFIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006F2")]
	private ICKFPGBDHLK HOJNLEBJGLH;

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x2089A60", Offset = "0x2088E60", VA = "0x182089A60")]
	internal CBINNBJHFGJ(EEMPEMCEAHC KFFEJBKKICE, PMDGAPKKPNC OOOABFDGACF, [Optional] Guid? JIDMDNKJFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x2089740", Offset = "0x2088B40", VA = "0x182089740")]
	public CBINNBJHFGJ EIDEADGEBNK(string NLDGENPEJBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x20896D0", Offset = "0x2088AD0", VA = "0x1820896D0")]
	public CBINNBJHFGJ DAHPMKBBLJL(bool FDGFIKHOJIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x2089770", Offset = "0x2088B70", VA = "0x182089770")]
	public CBINNBJHFGJ GCOAALDLEGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x20898F0", Offset = "0x2088CF0", VA = "0x1820898F0", Slot = "4")]
	protected override void MOKKPGOPONL(LJHBMNCDKEI FHDJIGKOLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x20897A0", Offset = "0x2088BA0", VA = "0x1820897A0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(COBCKNBJENP))]
	public override Task<EIDINADMANL> MNNJEIIIBMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x2089700", Offset = "0x2088B00", VA = "0x182089700")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<EIDINADMANL> DIGHOEGGPLA()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000177")]
internal struct GJIEJPIAIOF
{
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private sealed class JAIMPPNJFFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		public JHAGEABDIDH.DCOGDPFENCB instantiations;

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JAIMPPNJFFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x3A5A2B0", Offset = "0x3A596B0", VA = "0x183A5A2B0")]
		internal object ABIIKCCGPDJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class JEGOCOOJDOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JEGOCOOJDOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x3A5A930", Offset = "0x3A59D30", VA = "0x183A5A930")]
		internal object KNBMNKNBOLH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x209A1E0", Offset = "0x20995E0", VA = "0x18209A1E0")]
	public static void FOLFCGOHDPG(MOKCCACHPIF CMBFEPDDNLN, AEEBPABFEDL CLCAIFLMLCJ, JHAGEABDIDH.DCOGDPFENCB EFIIMJEDCML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
internal struct JHAGEABDIDH
{
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	public struct DCOGDPFENCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		public List<JNLBJEGKLFJ> ODKIPOHNFDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		public List<FEKGKBGNILG> JCJKMAFMBFC;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0xD06A00", Offset = "0xD05E00", VA = "0x180D06A00")]
		public DCOGDPFENCB(List<JNLBJEGKLFJ> ODKIPOHNFDK, List<FEKGKBGNILG> JCJKMAFMBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private sealed class HHPAAMDNPCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public IEnumerable<JNLBJEGKLFJ> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public HHPAAMDNPCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x3BF9B90", Offset = "0x3BF8F90", VA = "0x183BF9B90")]
		internal object OCBFOFAAECF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000700")]
	private EEMPEMCEAHC MDIBAOPLIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000701")]
	private AEEBPABFEDL CLCAIFLMLCJ;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private ENPHMEADLAM OLJLNILBIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x20A3630", Offset = "0x20A2A30", VA = "0x1820A3630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x20A3680", Offset = "0x20A2A80", VA = "0x1820A3680")]
	public static DCOGDPFENCB FOLFCGOHDPG(EEMPEMCEAHC MDIBAOPLIIF, AEEBPABFEDL CLCAIFLMLCJ)
	{
		return default(DCOGDPFENCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x20A36F0", Offset = "0x20A2AF0", VA = "0x1820A36F0")]
	private DCOGDPFENCB FOLFCGOHDPG()
	{
		return default(DCOGDPFENCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x20A3990", Offset = "0x20A2D90", VA = "0x1820A3990")]
	private DCOGDPFENCB JAEEKLJPFEM(DNADIKEEDJF ONGJJDFLIMK, KJEHFDNNDGH MJJKDFGBBEE)
	{
		return default(DCOGDPFENCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x20A3450", Offset = "0x20A2850", VA = "0x1820A3450")]
	private bool BPEFJJJLPCN(IEnumerable<JNLBJEGKLFJ> ODKIPOHNFDK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal struct IOIDLMHMHNB
{
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private sealed class DLILNHEPAIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public IOIDLMHMHNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		private bool <stopOnEmptyScene>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		private string <preloadSceneName>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public DLILNHEPAIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x3A53FC0", Offset = "0x3A533C0", VA = "0x183A53FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class ILIDOPHPHEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public ILIDOPHPHEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x3A597C0", Offset = "0x3A58BC0", VA = "0x183A597C0")]
		internal object MIHDIGBPLMO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private sealed class PBLAFAKFLNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public IOIDLMHMHNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		private ILIDOPHPHEC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		private EHHGGHOBIAA <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public PBLAFAKFLNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x3A62020", Offset = "0x3A61420", VA = "0x183A62020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000705")]
	private bool NPBFHLFADKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000706")]
	private CPMEPPENFLB<string>.PEFDMNJICBO INJHLEJHFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000707")]
	private EEMPEMCEAHC MDIBAOPLIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000708")]
	private CancellationToken ODBDCIFDKPJ;

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x20A0A80", Offset = "0x209FE80", VA = "0x1820A0A80")]
	public static Task ECEFIJAMHIA(EEMPEMCEAHC MDIBAOPLIIF, bool NPBFHLFADKL, CPMEPPENFLB<string>.PEFDMNJICBO INJHLEJHFLF, CancellationToken BFEAMMONPFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x20A0AF0", Offset = "0x209FEF0", VA = "0x1820A0AF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DLILNHEPAIM))]
	private Task FOLFCGOHDPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x20A0C20", Offset = "0x20A0020", VA = "0x1820A0C20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PBLAFAKFLNL))]
	private Task KFKKIFCHHMH(bool FPLFNEBCKDB, string HGLBIHJJLGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x8228B0", Offset = "0x821CB0", VA = "0x1808228B0")]
	private bool LPGOIOMNCHF(bool NPBFHLFADKL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal struct PLLNJBBBBDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400071D")]
	public readonly MFKMLKAPGOD PDHNLEDOMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400071E")]
	public readonly LENKAENGBGK DAIGEGBFOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400071F")]
	public readonly string FFEMBJOCHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000720")]
	public readonly DJFLKAMMCHF OOGBKJBIGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000721")]
	public readonly DJFLKAMMCHF AAOHIBIMLID;

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x27E9E40", Offset = "0x27E9240", VA = "0x1827E9E40")]
	public PLLNJBBBBDK(MFKMLKAPGOD PDHNLEDOMJM, LENKAENGBGK DAIGEGBFOIO, string FFEMBJOCHMB, DJFLKAMMCHF OOGBKJBIGHG, DJFLKAMMCHF AAOHIBIMLID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
internal sealed class KCODPCDFPIF : GIDJDKALFAF
{
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class FDKEGBALBNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		public CPBDLHAFGBN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		public KCODPCDFPIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		private PJKDLPBKDPA <roomEvent>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		private MGKINDOGNEG <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public FDKEGBALBNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x3BF6150", Offset = "0x3BF5550", VA = "0x183BF6150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000722")]
	private readonly OPAHMEFPIDH LKALNEJIANG;

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x27DA390", Offset = "0x27D9790", VA = "0x1827DA390")]
	public KCODPCDFPIF(Guid JIDMDNKJFGM, EEMPEMCEAHC MDIBAOPLIIF, OPAHMEFPIDH LKALNEJIANG, HACHIHGCJBL FPKJCMGGANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x27DA1F0", Offset = "0x27D95F0", VA = "0x1827DA1F0", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FDKEGBALBNI))]
	protected override Task FGKDJFEPLEF(CPBDLHAFGBN NGMMDGIIBLN, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000184")]
internal struct BCACPBEJPEI
{
	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x2088250", Offset = "0x2087650", VA = "0x182088250")]
	public static Task FOLFCGOHDPG(CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public static class GDCBFGAPCJE
{
	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x2098080", Offset = "0x2097480", VA = "0x182098080")]
	public static DJFLKAMMCHF FFPCOBEJGFF(this HFCJBAKFJBN KJDGDJGKHPG)
	{
		return default(DJFLKAMMCHF);
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x2098140", Offset = "0x2097540", VA = "0x182098140")]
	public static HFCJBAKFJBN IBAKDGDHHDE(this DJFLKAMMCHF EABOMHGCKIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
internal class JLHDIGLBFCK : NPMBFPENBLA
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private sealed class IOHCFBHDGHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		public FIKFCBBEEGH.BHMDIAHIKII roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public IOHCFBHDGHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x3BFC5F0", Offset = "0x3BFB9F0", VA = "0x183BFC5F0")]
		internal object IBLMNGIGMKL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private sealed class CEPCOMJONJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		public AsyncTaskMethodBuilder<(FIKFCBBEEGH.BHMDIAHIKII roomDataUpload, FIKFCBBEEGH.BHMDIAHIKII subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		public DPAKJIPJCJD roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		public JLHDIGLBFCK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		private IOHCFBHDGHD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		private JEDGOKEIKMD <roomMetadata>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		private FIKFCBBEEGH.BHMDIAHIKII <subRoomDataUpload>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		private FIKFCBBEEGH.BHMDIAHIKII <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		private FIKFCBBEEGH.BHMDIAHIKII <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		private TaskAwaiter<FIKFCBBEEGH.BHMDIAHIKII> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public CEPCOMJONJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x3BF3390", Offset = "0x3BF2790", VA = "0x183BF3390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private sealed class OFNOHMPPCLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		public AsyncTaskMethodBuilder<NGIGNBDICFJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		public ICKFPGBDHLK roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		public DPAKJIPJCJD roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		public JLHDIGLBFCK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		private FIKFCBBEEGH.BHMDIAHIKII <roomDataUpload>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		private FIKFCBBEEGH.BHMDIAHIKII <subRoomDataUpload>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		private int <persistenceVersion>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		private byte <omVersion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		private OPCEMAJFPGO <request>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		private NGIGNBDICFJ <response>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		private (FIKFCBBEEGH.BHMDIAHIKII roomDataUpload, FIKFCBBEEGH.BHMDIAHIKII subRoomDataUpload) <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		private (FIKFCBBEEGH.BHMDIAHIKII roomDataUpload, FIKFCBBEEGH.BHMDIAHIKII subRoomDataUpload) <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		private NGIGNBDICFJ <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		private TaskAwaiter<(FIKFCBBEEGH.BHMDIAHIKII roomDataUpload, FIKFCBBEEGH.BHMDIAHIKII subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		private TaskAwaiter<NGIGNBDICFJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public OFNOHMPPCLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x3C01CE0", Offset = "0x3C010E0", VA = "0x183C01CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private sealed class DABIIDIAOIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		public AsyncTaskMethodBuilder<AJOBOMJDCOM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		public DPAKJIPJCJD roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		public JLHDIGLBFCK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		private FIKFCBBEEGH.BHMDIAHIKII <roomDataUpload>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		private FIKFCBBEEGH.BHMDIAHIKII <subRoomDataUpload>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		private AJOBOMJDCOM <remoteRunDetails>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		private (FIKFCBBEEGH.BHMDIAHIKII roomDataUpload, FIKFCBBEEGH.BHMDIAHIKII subRoomDataUpload) <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		private (FIKFCBBEEGH.BHMDIAHIKII roomDataUpload, FIKFCBBEEGH.BHMDIAHIKII subRoomDataUpload) <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		private AJOBOMJDCOM <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		private TaskAwaiter<(FIKFCBBEEGH.BHMDIAHIKII roomDataUpload, FIKFCBBEEGH.BHMDIAHIKII subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		private TaskAwaiter<AJOBOMJDCOM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public DABIIDIAOIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x3BF4C60", Offset = "0x3BF4060", VA = "0x183BF4C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private sealed class JFEDHIEGODN
	{
		[Cpp2IlInjected.Token(Token = "0x200018C")]
		private sealed class <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400076A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400076B")]
			public AsyncTaskMethodBuilder<LJHBMNCDKEI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400076C")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400076D")]
			public JFEDHIEGODN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400076E")]
			private LJHBMNCDKEI <reloadMessage>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400076F")]
			private RepeatedField<FEKGKBGNILG> <persistenceViewsOpt>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000770")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6BF9E0", Offset = "0x6BEDE0")]
			private IEnumerable<FEKGKBGNILG> <persistenceViews>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000771")]
			private bool <couldSaveLocalRoomData>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
			[Cpp2IlInjected.Token(Token = "0x4000772")]
			private bool <>s__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000773")]
			private AJOBOMJDCOM <remoteRunDetails>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000774")]
			private AJOBOMJDCOM <>s__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000775")]
			private NGIGNBDICFJ <saveDetails>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000776")]
			private NGIGNBDICFJ <>s__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000777")]
			private LJHBMNCDKEI <>s__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000778")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000779")]
			private TaskAwaiter<AJOBOMJDCOM> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400077A")]
			private TaskAwaiter<NGIGNBDICFJ> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400077B")]
			private TaskAwaiter<LJHBMNCDKEI> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006A2")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public <<UploadRoomDataBlobAndSyncReload>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A3")]
			[Cpp2IlInjected.Address(RVA = "0x603EE70", Offset = "0x603E270", VA = "0x18603EE70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A4")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		public JLHDIGLBFCK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		public DPAKJIPJCJD roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		public ICKFPGBDHLK roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		public FEPCCPLBANJ roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6BF920", Offset = "0x6BED20")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JFEDHIEGODN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x3BFCC10", Offset = "0x3BFC010", VA = "0x183BFCC10")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<LJHBMNCDKEI> NNJMADACDPK(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private sealed class OMFLFNFDPKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		public AsyncTaskMethodBuilder<LJHBMNCDKEI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		public ICKFPGBDHLK roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public DPAKJIPJCJD roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		public FEPCCPLBANJ roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6BFA40", Offset = "0x6BEE40")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		public JLHDIGLBFCK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		private JFEDHIEGODN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		private LJHBMNCDKEI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		private TaskAwaiter<LJHBMNCDKEI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public OMFLFNFDPKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x3C02950", Offset = "0x3C01D50", VA = "0x183C02950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400072C")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x400072D")]
	private static readonly EHKEPJIBENP IPKOIFFPNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400072E")]
	private readonly JOJINJHEHOK HEINNPALGHO;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private EEMPEMCEAHC OIFFBBNLCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x20A3F00", Offset = "0x20A3300", VA = "0x1820A3F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x20A4800", Offset = "0x20A3C00", VA = "0x1820A4800")]
	public JLHDIGLBFCK(CPBDLHAFGBN NGMMDGIIBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x20A4130", Offset = "0x20A3530", VA = "0x1820A4130")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CEPCOMJONJH))]
	private Task<(FIKFCBBEEGH.BHMDIAHIKII, FIKFCBBEEGH.BHMDIAHIKII)> HAICKMMMEIF(DPAKJIPJCJD KFBJJKPIMFK, long KFHMHOFPIPN, long BCJGCHKGEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x20A4540", Offset = "0x20A3940", VA = "0x1820A4540")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OFNOHMPPCLA))]
	public Task<NGIGNBDICFJ> PBNKNDECDMO(int NKHLLKFKDAM, [CanBeNull] ICKFPGBDHLK GGIPAFOEMBC, DPAKJIPJCJD KFBJJKPIMFK, long KFHMHOFPIPN, long BCJGCHKGEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x20A3F30", Offset = "0x20A3330", VA = "0x1820A3F30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DABIIDIAOIA))]
	private Task<AJOBOMJDCOM> CFOIDCFELEI(string IGLBCBOECHI, int NKHLLKFKDAM, DPAKJIPJCJD KFBJJKPIMFK, long KFHMHOFPIPN, long BCJGCHKGEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x20A42F0", Offset = "0x20A36F0", VA = "0x1820A42F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OMFLFNFDPKD))]
	public Task<LJHBMNCDKEI> LAIBMCEOPNK(int NKHLLKFKDAM, ICKFPGBDHLK? GGIPAFOEMBC, DPAKJIPJCJD KFBJJKPIMFK, long KFHMHOFPIPN, long BCJGCHKGEMF, FEPCCPLBANJ GMHIHLHOFGA, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
internal class CCPMKFAOOKI : GIDJDKALFAF
{
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[CompilerGenerated]
	private sealed class BOOACPPKGMI
	{
		[Cpp2IlInjected.Token(Token = "0x2000190")]
		private sealed class <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000796")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000797")]
			public AsyncTaskMethodBuilder<LJHBMNCDKEI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000798")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000799")]
			public BOOACPPKGMI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400079A")]
			private DPAKJIPJCJD <data>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400079B")]
			private LJHBMNCDKEI <reloadMsg>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400079C")]
			private DPAKJIPJCJD <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400079D")]
			private LJHBMNCDKEI <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400079E")]
			private TaskAwaiter<DPAKJIPJCJD> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400079F")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6BFB80", Offset = "0x6BEF80")]
			private TaskAwaiter<LJHBMNCDKEI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006AF")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public <<RunWhilePlayerDespawnedAsync>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B0")]
			[Cpp2IlInjected.Address(RVA = "0x603EA00", Offset = "0x603DE00", VA = "0x18603EA00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B1")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public CCPMKFAOOKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		public PDAPGAJCBAI serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		public PHHKJAPOHHP roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		public JLHDIGLBFCK uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		public FEPCCPLBANJ roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public BOOACPPKGMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x27D11E0", Offset = "0x27D05E0", VA = "0x1827D11E0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<LJHBMNCDKEI> EMIDKGEKNAH(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private sealed class AMPPDDGHMDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007A2")]
		public CPBDLHAFGBN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007A3")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		public CCPMKFAOOKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		private BOOACPPKGMI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		private PJKDLPBKDPA <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		private KFJCLNMFLAB <currentRoomSave>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		private long <loadedSubroomSaveId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		private bool <currentLoadedSaveIsPublished>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		private MGKINDOGNEG <loadLogic>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007AC")]
		private LJHBMNCDKEI <saveReloadMessage>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40007AD")]
		private LJHBMNCDKEI <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40007AE")]
		private Exception <ex>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40007AF")]
		private TaskAwaiter<LJHBMNCDKEI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40007B0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public AMPPDDGHMDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x27CFC90", Offset = "0x27CF090", VA = "0x1827CFC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400078A")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x400078B")]
	private static readonly EHKEPJIBENP IPKOIFFPNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400078C")]
	private readonly int NKHLLKFKDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400078D")]
	[CanBeNull]
	private readonly ICKFPGBDHLK GGIPAFOEMBC;

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x208A740", Offset = "0x2089B40", VA = "0x18208A740")]
	public CCPMKFAOOKI(Guid JIDMDNKJFGM, EEMPEMCEAHC MDIBAOPLIIF, int NKHLLKFKDAM, ICKFPGBDHLK GGIPAFOEMBC, HACHIHGCJBL FPKJCMGGANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x208A3B0", Offset = "0x20897B0", VA = "0x18208A3B0", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AMPPDDGHMDC))]
	protected override Task FGKDJFEPLEF(CPBDLHAFGBN NGMMDGIIBLN, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x208A550", Offset = "0x2089950", VA = "0x18208A550")]
	private void KMCPDGPCOBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x208A210", Offset = "0x2089610", VA = "0x18208A210")]
	private void CJILMKDBDBE(CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG, PJKDLPBKDPA NDLHNJOADNA)
	{
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000193")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007B4")]
			public GKAIKMMKGOC ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007B5")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007B6")]
			public GKAIKMMKGOC HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007B7")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007B8")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007B9")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60006BB")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007B1")]
		private static GKAIKMMKGOC[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007B2")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007B3")]
		private Dictionary<GKAIKMMKGOC, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x27EAC90", Offset = "0x27EA090", VA = "0x1827EAC90")]
		public bool PHCFKCBJOLI(GKAIKMMKGOC CHEKICDCEJC, out ResultConfig PPCPEOGMHIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x27EA410", Offset = "0x27E9810", VA = "0x1827EA410")]
		public ResultConfig HIKKHFHDCEP(GKAIKMMKGOC FOGPFBBPCHL, [Optional] HashSet<GKAIKMMKGOC> LGLHJHJGCDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x27EAA90", Offset = "0x27E9E90", VA = "0x1827EAA90", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x27EA520", Offset = "0x27E9920", VA = "0x1827EA520", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x9840D0", Offset = "0x9834D0", VA = "0x1809840D0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
public class DKAMADKEEIF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x208E820", Offset = "0x208DC20", VA = "0x18208E820")]
	public DKAMADKEEIF(string FHDJIGKOLJM, Exception FMNNOJDKJHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
public class DKMHAHAABIH
{
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	private sealed class MHKLPFFMCBB : DABDPGOMODH, IEquatable<DABDPGOMODH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000198")]
		[CompilerGenerated]
		private sealed class JBDEKGJKCEA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007C6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007C7")]
			public AsyncTaskMethodBuilder<EIDINADMANL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007C8")]
			public MHKLPFFMCBB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007C9")]
			private CFJAIONOPOH <roomManager>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007CA")]
			private MFKMLKAPGOD <newRoomDetails>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007CB")]
			private OPAHMEFPIDH <roomLoadRequestPayload>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007CC")]
			private MFKMLKAPGOD <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007CD")]
			private EIDINADMANL <>s__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007CE")]
			private TaskAwaiter<MFKMLKAPGOD> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007CF")]
			private TaskAwaiter<EIDINADMANL> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006D3")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public JBDEKGJKCEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D4")]
			[Cpp2IlInjected.Address(RVA = "0x60385B0", Offset = "0x60379B0", VA = "0x1860385B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D5")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007C3")]
		private readonly KFJCLNMFLAB GMPGKOABCIH;

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public int MIBILDPDPCI
		{
			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0x978170", Offset = "0x977570", VA = "0x180978170", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public PPBHHPDPECN MOMEDMCDOOB
		{
			[Cpp2IlInjected.Token(Token = "0x60006C8")]
			[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private DateTime JGADAEBBNJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60006C9")]
			[Cpp2IlInjected.Address(RVA = "0x18D6C80", Offset = "0x18D6080", VA = "0x1818D6C80", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public FABCIKBPEHF? AGCONHDEGOO
		{
			[Cpp2IlInjected.Token(Token = "0x60006CA")]
			[Cpp2IlInjected.Address(RVA = "0x9BC8F0", Offset = "0x9BBCF0", VA = "0x1809BC8F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public FNBGHGHMBMD? PANAAODFOGD
		{
			[Cpp2IlInjected.Token(Token = "0x60006CB")]
			[Cpp2IlInjected.Address(RVA = "0x2B5C560", Offset = "0x2B5B960", VA = "0x182B5C560", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public HALJPHALAHF HBNNDDGKGEO
		{
			[Cpp2IlInjected.Token(Token = "0x60006CE")]
			[Cpp2IlInjected.Address(RVA = "0x822D80", Offset = "0x822180", VA = "0x180822D80", Slot = "10")]
			get
			{
				return default(HALJPHALAHF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x3A5E750", Offset = "0x3A5DB50", VA = "0x183A5E750", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(JBDEKGJKCEA))]
		public Task<EIDINADMANL> GIOOOFGFPFD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x3A5E980", Offset = "0x3A5DD80", VA = "0x183A5E980")]
		public MHKLPFFMCBB(int JHLANNGPCAG, PPBHHPDPECN BPINLLEBEGO, KFJCLNMFLAB GMPGKOABCIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x3A5E610", Offset = "0x3A5DA10", VA = "0x183A5E610", Slot = "11")]
		public bool Equals(DABDPGOMODH ICELKIGIKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x3A5E6B0", Offset = "0x3A5DAB0", VA = "0x183A5E6B0", Slot = "0")]
		public override bool Equals(object HFAGBIOODHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x3A5E8A0", Offset = "0x3A5DCA0", VA = "0x183A5E8A0")]
		private bool GMMMAHNKJEN(MHKLPFFMCBB ICELKIGIKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x3A5E8F0", Offset = "0x3A5DCF0", VA = "0x183A5E8F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000199")]
	private sealed class NIJHNAENCEH : DABDPGOMODH, IEquatable<DABDPGOMODH>
	{
		[Cpp2IlInjected.Token(Token = "0x200019A")]
		[CompilerGenerated]
		private sealed class INEPBANHMOO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007D3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007D4")]
			public AsyncTaskMethodBuilder<EIDINADMANL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007D5")]
			public NIJHNAENCEH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007D6")]
			private EIDINADMANL <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007D7")]
			private TaskAwaiter<EIDINADMANL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006E2")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public INEPBANHMOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006E3")]
			[Cpp2IlInjected.Address(RVA = "0x6038320", Offset = "0x6037720", VA = "0x186038320", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006E4")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		private readonly MANOJAHNIFE PHOMJJJGGCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		private readonly FABCIKBPEHF IKFPDKFAMFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		private readonly FNBGHGHMBMD CKIEAJGBPNN;

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public int MIBILDPDPCI
		{
			[Cpp2IlInjected.Token(Token = "0x60006D6")]
			[Cpp2IlInjected.Address(RVA = "0x3A5FA50", Offset = "0x3A5EE50", VA = "0x183A5FA50", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public PPBHHPDPECN MOMEDMCDOOB
		{
			[Cpp2IlInjected.Token(Token = "0x60006D7")]
			[Cpp2IlInjected.Address(RVA = "0x3A5F770", Offset = "0x3A5EB70", VA = "0x183A5F770", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		private DateTime JGADAEBBNJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60006D8")]
			[Cpp2IlInjected.Address(RVA = "0x3A5F720", Offset = "0x3A5EB20", VA = "0x183A5F720", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public FABCIKBPEHF? AGCONHDEGOO
		{
			[Cpp2IlInjected.Token(Token = "0x60006D9")]
			[Cpp2IlInjected.Address(RVA = "0x3A5FA00", Offset = "0x3A5EE00", VA = "0x183A5FA00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public FNBGHGHMBMD? PANAAODFOGD
		{
			[Cpp2IlInjected.Token(Token = "0x60006DA")]
			[Cpp2IlInjected.Address(RVA = "0x3A5FAA0", Offset = "0x3A5EEA0", VA = "0x183A5FAA0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public HALJPHALAHF HBNNDDGKGEO
		{
			[Cpp2IlInjected.Token(Token = "0x60006DD")]
			[Cpp2IlInjected.Address(RVA = "0x8C05F0", Offset = "0x8BF9F0", VA = "0x1808C05F0", Slot = "10")]
			get
			{
				return default(HALJPHALAHF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x371EA00", Offset = "0x371DE00", VA = "0x18371EA00")]
		public NIJHNAENCEH(MANOJAHNIFE LGMCHOGOHPK, FABCIKBPEHF NPEBOPIJJLN, FNBGHGHMBMD NPOGFCJBKFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x3A5F7C0", Offset = "0x3A5EBC0", VA = "0x183A5F7C0", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(INEPBANHMOO))]
		public Task<EIDINADMANL> GIOOOFGFPFD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x3A5F5D0", Offset = "0x3A5E9D0", VA = "0x183A5F5D0", Slot = "11")]
		public bool Equals(DABDPGOMODH ICELKIGIKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x3A5F670", Offset = "0x3A5EA70", VA = "0x183A5F670", Slot = "0")]
		public override bool Equals(object HFAGBIOODHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x3A5F910", Offset = "0x3A5ED10", VA = "0x183A5F910")]
		private bool GMMMAHNKJEN(NIJHNAENCEH ICELKIGIKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x3A5F970", Offset = "0x3A5ED70", VA = "0x183A5F970", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019B")]
	private sealed class DMMGDFKNJOD : DABDPGOMODH, IEquatable<DABDPGOMODH>
	{
		[Cpp2IlInjected.Token(Token = "0x200019C")]
		[CompilerGenerated]
		private sealed class DAMCKPDIBCP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007DB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007DC")]
			public AsyncTaskMethodBuilder<EIDINADMANL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007DD")]
			public DMMGDFKNJOD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007DE")]
			private EIDINADMANL <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007DF")]
			private TaskAwaiter<EIDINADMANL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006F1")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public DAMCKPDIBCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F2")]
			[Cpp2IlInjected.Address(RVA = "0x6037C70", Offset = "0x6037070", VA = "0x186037C70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F3")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		private readonly PPBHHPDPECN OBOCAKLOLOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D9")]
		private readonly FABCIKBPEHF IKFPDKFAMFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40007DA")]
		private readonly FNBGHGHMBMD CKIEAJGBPNN;

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public int MIBILDPDPCI
		{
			[Cpp2IlInjected.Token(Token = "0x60006E5")]
			[Cpp2IlInjected.Address(RVA = "0x3A54B40", Offset = "0x3A53F40", VA = "0x183A54B40", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		[NotNull]
		public PPBHHPDPECN MOMEDMCDOOB
		{
			[Cpp2IlInjected.Token(Token = "0x60006E6")]
			[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		private DateTime JGADAEBBNJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60006E7")]
			[Cpp2IlInjected.Address(RVA = "0x821EB0", Offset = "0x8212B0", VA = "0x180821EB0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public FABCIKBPEHF? AGCONHDEGOO
		{
			[Cpp2IlInjected.Token(Token = "0x60006E8")]
			[Cpp2IlInjected.Address(RVA = "0x3A54AF0", Offset = "0x3A53EF0", VA = "0x183A54AF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public FNBGHGHMBMD? PANAAODFOGD
		{
			[Cpp2IlInjected.Token(Token = "0x60006E9")]
			[Cpp2IlInjected.Address(RVA = "0x3A54BC0", Offset = "0x3A53FC0", VA = "0x183A54BC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public HALJPHALAHF HBNNDDGKGEO
		{
			[Cpp2IlInjected.Token(Token = "0x60006EC")]
			[Cpp2IlInjected.Address(RVA = "0x821EB0", Offset = "0x8212B0", VA = "0x180821EB0", Slot = "10")]
			get
			{
				return default(HALJPHALAHF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x371EA00", Offset = "0x371DE00", VA = "0x18371EA00")]
		public DMMGDFKNJOD(PPBHHPDPECN BPINLLEBEGO, FABCIKBPEHF NPEBOPIJJLN, FNBGHGHMBMD NPOGFCJBKFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x3A547D0", Offset = "0x3A53BD0", VA = "0x183A547D0", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(DAMCKPDIBCP))]
		public Task<EIDINADMANL> GIOOOFGFPFD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x3A54540", Offset = "0x3A53940", VA = "0x183A54540", Slot = "11")]
		public bool Equals(DABDPGOMODH ICELKIGIKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x3A54680", Offset = "0x3A53A80", VA = "0x183A54680", Slot = "0")]
		public override bool Equals(object HFAGBIOODHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x3A54A40", Offset = "0x3A53E40", VA = "0x183A54A40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x3A54920", Offset = "0x3A53D20", VA = "0x183A54920")]
		private bool GMMMAHNKJEN(DMMGDFKNJOD ICELKIGIKKP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[CompilerGenerated]
	private sealed class ELNAOEGFDLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		public AsyncTaskMethodBuilder<IList<DABDPGOMODH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		public bool forceRefreshSaveHistoryCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007EB")]
		public DKMHAHAABIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007EC")]
		private (long roomId, long subroomId) <cacheKey>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007ED")]
		private IReadOnlyList<KFJCLNMFLAB> <saveHistory>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007EE")]
		private IReadOnlyList<(int accountId, PPBHHPDPECN account, KFJCLNMFLAB roomDataSaveDto)> <saveHistoryWithAccounts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		private List<DABDPGOMODH> <restoreOptions>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		private DateTime? <mostRecentSaveDate>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007F1")]
		private MANOJAHNIFE <autoSaveInfo>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007F2")]
		private IReadOnlyList<KFJCLNMFLAB> <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007F3")]
		private IReadOnlyList<(int accountId, PPBHHPDPECN account, KFJCLNMFLAB roomDataSaveDto)> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40007F4")]
		private IEnumerator<(int accountId, PPBHHPDPECN account, KFJCLNMFLAB roomDataSaveDto)> <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40007F5")]
		private (int accountId, PPBHHPDPECN account, KFJCLNMFLAB roomDataSaveDto) <saveHistoryWithAccount>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40007F6")]
		private NIJHNAENCEH <autosaveOption>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40007F7")]
		private TaskAwaiter<IReadOnlyList<KFJCLNMFLAB>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40007F8")]
		private TaskAwaiter<IReadOnlyList<(int accountId, PPBHHPDPECN account, KFJCLNMFLAB roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public ELNAOEGFDLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x3A55B00", Offset = "0x3A54F00", VA = "0x183A55B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private sealed class BMCNDKOEFIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007FA")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, PPBHHPDPECN account, KFJCLNMFLAB roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007FB")]
		public IReadOnlyList<KFJCLNMFLAB> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007FC")]
		public DKMHAHAABIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007FD")]
		private List<int> <accountIds>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007FE")]
		private IReadOnlyList<PPBHHPDPECN> <accounts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007FF")]
		private Dictionary<ObscuredInt, PPBHHPDPECN> <accountsDict>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000800")]
		private List<(int, PPBHHPDPECN, KFJCLNMFLAB)> <finalHistory>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000801")]
		private IReadOnlyList<PPBHHPDPECN> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000802")]
		private IEnumerator<KFJCLNMFLAB> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000803")]
		private KFJCLNMFLAB <historyItem>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000804")]
		private int <savedByAccountId>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000805")]
		private PPBHHPDPECN <savedByAccount>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000806")]
		private PPBHHPDPECN <account>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000807")]
		private TaskAwaiter<IReadOnlyList<PPBHHPDPECN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public BMCNDKOEFIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x3A52170", Offset = "0x3A51570", VA = "0x183A52170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007BF")]
	private readonly LNHGIMHBFPE JPFMANNFLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007C0")]
	private readonly LAIDBGOCOPO CAJLPPLBGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40007C1")]
	private readonly KMGCJHHGHIL DAJFCKPDNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40007C2")]
	private readonly EEOODGNAPMC<(long, long), IReadOnlyList<KFJCLNMFLAB>> POBFENKADEG;

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x2092B40", Offset = "0x2091F40", VA = "0x182092B40")]
	[UnityEngine.Scripting.Preserve]
	public DKMHAHAABIH([JLJFOFICIEA(null)] LAIDBGOCOPO KNFFCLOIBPN, [JLJFOFICIEA(null)] KMGCJHHGHIL JEPIMOMAFAB, [JLJFOFICIEA(null)] LNHGIMHBFPE ALOJKJNEAIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x2092830", Offset = "0x2091C30", VA = "0x182092830")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ELNAOEGFDLI))]
	public Task<IList<DABDPGOMODH>> JHLGFLOCOOL(long KFHMHOFPIPN, long LHBCPOODKNA, bool MNBGFBDCCDP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x2092690", Offset = "0x2091A90", VA = "0x182092690")]
	private bool GMMNFHDIMPA(DateTime? HHNHINNFGCM, long KFHMHOFPIPN, long LHBCPOODKNA, out MANOJAHNIFE FOFGMEHODIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x20929D0", Offset = "0x2091DD0", VA = "0x1820929D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BMCNDKOEFIH))]
	private Task<IReadOnlyList<(int, PPBHHPDPECN, KFJCLNMFLAB)>> PNPBILDPMCB(IReadOnlyList<KFJCLNMFLAB> HOKDOIMBKKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
internal class IBBEFBMPAMD : LAIDBGOCOPO
{
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[CompilerGenerated]
	private sealed class EDBOPAKCDFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000808")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000809")]
		public AsyncTaskMethodBuilder<IReadOnlyList<KFJCLNMFLAB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400080A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400080B")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400080C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400080D")]
		public IBBEFBMPAMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400080E")]
		private BPEAEEINGOP<KFJCLNMFLAB> <pagedResults>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400080F")]
		private BPEAEEINGOP<KFJCLNMFLAB> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000810")]
		private TaskAwaiter<BPEAEEINGOP<KFJCLNMFLAB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public EDBOPAKCDFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x3A551A0", Offset = "0x3A545A0", VA = "0x183A551A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	[CompilerGenerated]
	private sealed class EANCIADFBGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000811")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000812")]
		public AsyncTaskMethodBuilder<IReadOnlyList<PPBHHPDPECN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000813")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000814")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000815")]
		public IBBEFBMPAMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000816")]
		private List<PPBHHPDPECN> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000817")]
		private TaskAwaiter<List<PPBHHPDPECN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public EANCIADFBGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x3A54FC0", Offset = "0x3A543C0", VA = "0x183A54FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	[UnityEngine.Scripting.Preserve]
	public IBBEFBMPAMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x209FC90", Offset = "0x209F090", VA = "0x18209FC90", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EDBOPAKCDFO))]
	public Task<IReadOnlyList<KFJCLNMFLAB>> DCDLACMFFIM(long KFHMHOFPIPN, long BCJGCHKGEMF, [Optional] CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x209FE40", Offset = "0x209F240", VA = "0x18209FE40", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EANCIADFBGN))]
	public Task<IReadOnlyList<PPBHHPDPECN>> HJBEFMMGPOG(IReadOnlyList<int> DJNFOAHBOEK, [Optional] CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
public interface LAIDBGOCOPO
{
	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<KFJCLNMFLAB>> DCDLACMFFIM(long KFHMHOFPIPN, long BCJGCHKGEMF, [Optional] CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<PPBHHPDPECN>> HJBEFMMGPOG(IReadOnlyList<int> DJNFOAHBOEK, [Optional] CancellationToken ODBDCIFDKPJ);
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
public interface DABDPGOMODH : IEquatable<DABDPGOMODH>
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	int MIBILDPDPCI
	{
		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	[CanBeNull]
	PPBHHPDPECN MOMEDMCDOOB
	{
		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	DateTime FNEGGJJNKEG
	{
		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	FABCIKBPEHF? AGCONHDEGOO
	{
		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	FNBGHGHMBMD? PANAAODFOGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	[CanBeNull]
	HALJPHALAHF HBNNDDGKGEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<EIDINADMANL> GIOOOFGFPFD();
}
[Cpp2IlInjected.Token(Token = "0x20001A5")]
public enum HALJPHALAHF
{
	[Cpp2IlInjected.Token(Token = "0x4000819")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x400081A")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x400081B")]
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

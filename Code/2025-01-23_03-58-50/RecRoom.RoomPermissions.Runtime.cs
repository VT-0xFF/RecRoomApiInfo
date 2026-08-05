using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;
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
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x76E87E0", Offset = "0x76E6FE0", VA = "0x1876E87E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B60", Offset = "0x8DF360", VA = "0x1808E0B60")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8E0BA0", Offset = "0x8DF3A0", VA = "0x1808E0BA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum MMMOADOBLEB
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
namespace _AssemblyRegistry.RecRoom_RoomPermissions_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x76E9300", Offset = "0x76E7B00", VA = "0x1876E9300", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x21F3FE0", Offset = "0x21F27E0", VA = "0x1821F3FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void EKFPEJBEOKH<TPermission>(TPermission AOGBEJODONB);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void CEBDOLDPMME(OEDKOGGDKCO FGIHDJGGIMF);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum GLAKCBDGNFH
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BNIJGHJIOIK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KKOCBIFHIJL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool CGBDHICEBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool FMGNAHLLBGM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NKBABDHNEPF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool MGNNBMFJOCH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NAGENOCGPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class HAAGHIFDLGH
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum CNNMLBNGIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		AG_EVERYONE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		AG_CREATOR = 0x200000,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		AG_COOWNER = 0x400000,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		AG_HOST = 0x800000,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		AG_MODERATOR = 0x1000000
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Guid PJMJDHKLHBF;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid FOHJEPDHBBP;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid ADKHDNGMGBD;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid ENFKFHDGLFF;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid ANNNIKCMIAO;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid IEIPFEGFCPN;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly KJEONKDBJAM<NBGFMFDOHOO, Guid> HJJIEMMCGDD;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<NBGFMFDOHOO> PIMBJDPFDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x76E4630", Offset = "0x76E2E30", VA = "0x1876E4630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x76E48A0", Offset = "0x76E30A0", VA = "0x1876E48A0")]
	public static NBGFMFDOHOO NBGJDILFCKM(Guid PLMJELCKKDA)
	{
		return default(NBGFMFDOHOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x76E46B0", Offset = "0x76E2EB0", VA = "0x1876E46B0")]
	public static Guid HHEFBOKMLKP(NBGFMFDOHOO MEFCPJOMJEO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x76E4930", Offset = "0x76E3130", VA = "0x1876E4930")]
	public static bool OFHEAHLBJFB(NBGFMFDOHOO MEFCPJOMJEO, [Out] Guid PLMJELCKKDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x76E4750", Offset = "0x76E2F50", VA = "0x1876E4750")]
	public static bool JBCACBCJPJD(Guid PLMJELCKKDA, [Out] NBGFMFDOHOO MEFCPJOMJEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x76E45F0", Offset = "0x76E2DF0", VA = "0x1876E45F0")]
	public static NBGFMFDOHOO BCHNDFDOACO(NBGFMFDOHOO MEFCPJOMJEO)
	{
		return default(NBGFMFDOHOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x76E47F0", Offset = "0x76E2FF0", VA = "0x1876E47F0")]
	public static CNNMLBNGIEJ KLBNOLHKMGA(NBGFMFDOHOO EDEFGMALLLC)
	{
		return default(CNNMLBNGIEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x76E49C0", Offset = "0x76E31C0", VA = "0x1876E49C0")]
	internal static NBGFMFDOHOO OOOOLBEINLK(CNNMLBNGIEJ BFANGLJPDLL)
	{
		return default(NBGFMFDOHOO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DHEMDIHJAOF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	MHFDCEBLDCK ANALDEEPAHC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<AAEPDGMIKIM> MENLBLFGLBD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event CEBDOLDPMME PDPFOKBJGDA;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<AAEPDGMIKIM> FOIBNJJDGHL(bool FCDICPJMFAD = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AAEPDGMIKIM GJIIGLKAMAL(OEDKOGGDKCO FGIHDJGGIMF);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HBOFCPJGHID(OEDKOGGDKCO FGIHDJGGIMF);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<AAEPDGMIKIM> BFPMGJPEDBO(OEDKOGGDKCO FGIHDJGGIMF, bool FHKGMOGKNCL = false);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DNCNIJNDLAE(OEDKOGGDKCO NCKFLPIPOBC, NBGFMFDOHOO MEFCPJOMJEO);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	AAEPDGMIKIM FONCPBGDPFM(NBGFMFDOHOO MEFCPJOMJEO);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool ECACBJBDHDB<T>(NBGFMFDOHOO MEFCPJOMJEO, PNJBEGILGNN AOGBEJODONB, bool PNBHNPEAJLA, T HBIPIPALDEO, [Optional] Action FIGBMONMMBB) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string DOBFPDFFHOE(PNJBEGILGNN AOGBEJODONB);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DJGIANGJMMK
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KODJJDJJNBF(LAENOPFABFD NKIGLKBMOAI, CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OFOPLMGGPCD(LAENOPFABFD NKIGLKBMOAI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GEMFDHDCNGM
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	OEDKOGGDKCO GAJHHPEBEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DILBKEMEFHP CIDJDODKCNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	NIHPFEHJKNJ GIBCGILCNJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<LJAFLFBHFEG> OBBPHHBILNM;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action LJGLNOKLKNN;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NBGFMFDOHOO MHFHOFIDKFB(OEDKOGGDKCO FGIHDJGGIMF);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<LJAFLFBHFEG> IGIKNDAPBEP(CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task GHFKNIBCACB(long NKDNOGOOODN, IReadOnlyList<KAEIFEDOMBM> LPGOJLHCELC);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task JDNOMFDKIOL(long NKDNOGOOODN, long IFPDLCPBOCG, IReadOnlyList<KAEIFEDOMBM> LPGOJLHCELC);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<OEDKOGGDKCO> GIFNPBFCJDC();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GCGNHCNOEFG
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x76E3A10", Offset = "0x76E2210", VA = "0x1876E3A10")]
	public static NBGFMFDOHOO BMGKHIPOKHO(this GEMFDHDCNGM BNKOBKKKABM)
	{
		return default(NBGFMFDOHOO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface JGFELNCMIMM<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string BJHPKCLIJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event EKFPEJBEOKH<TPermission> EJBNOOGMGKA;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class KMLEKAJAPHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? NCJMHKIGNIF;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? AFCGGJCNNBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x76E7020", Offset = "0x76E5820", VA = "0x1876E7020")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x76E70F0", Offset = "0x76E58F0", VA = "0x1876E70F0")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x76E71F0", Offset = "0x76E59F0", VA = "0x1876E71F0")]
	protected KMLEKAJAPHJ(object? KEAFOBACOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool NNIJFPFCHML(object? INDENPJBLHO);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class OJJHIMJMLMD<T> : KMLEKAJAPHJ where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> HADPFNKGDNF;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T MHFLHGKPHDB
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4B57B40", Offset = "0x4B56340", VA = "0x184B57B40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4B57DF0", Offset = "0x4B565F0", VA = "0x184B57DF0", Slot = "4")]
	public override bool NNIJFPFCHML(object? INDENPJBLHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4B574B0", Offset = "0x4B55CB0", VA = "0x184B574B0")]
	public bool BOBGOELFALF(T FANFAJMEEGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4B58310", Offset = "0x4B56B10", VA = "0x184B58310")]
	public OJJHIMJMLMD(T DFEJJOPGBKP, IEqualityComparer<T> HADPFNKGDNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class AAEEFJMKDGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<PNJBEGILGNN, bool> OJEGOAKAPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<PNJBEGILGNN, KMLEKAJAPHJ> JCMAMOEGAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly IFOPKGOEMIE MEHNHJMHEOB;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x76DB190", Offset = "0x76D9990", VA = "0x1876DB190")]
	public AAEEFJMKDGN(IFOPKGOEMIE MEHNHJMHEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x76DAC00", Offset = "0x76D9400", VA = "0x1876DAC00")]
	public bool CLBNGLGDJIB(PNJBEGILGNN AOGBEJODONB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3730F80", Offset = "0x372F780", VA = "0x183730F80")]
	public bool JGBPDPFEBEI<T>(PNJBEGILGNN AOGBEJODONB, bool PNBHNPEAJLA, T INDENPJBLHO) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3731500", Offset = "0x372FD00", VA = "0x183731500")]
	public (bool, T?) OLCPIBIMKAK<T>(PNJBEGILGNN AOGBEJODONB) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x76DAF20", Offset = "0x76D9720", VA = "0x1876DAF20")]
	public bool JGBPDPFEBEI(PNJBEGILGNN AOGBEJODONB, bool PNBHNPEAJLA, object INDENPJBLHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x76DB000", Offset = "0x76D9800", VA = "0x1876DB000")]
	public (bool, object) OLCPIBIMKAK(PNJBEGILGNN AOGBEJODONB)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3730F20", Offset = "0x372F720", VA = "0x183730F20")]
	private void GLLFBGBKOLL<T>(PNJBEGILGNN AOGBEJODONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x76DAE50", Offset = "0x76D9650", VA = "0x1876DAE50")]
	private KMLEKAJAPHJ IJJHANPGCJF(PNJBEGILGNN AOGBEJODONB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x76DAC70", Offset = "0x76D9470", VA = "0x1876DAC70")]
	public void IGJKDNEDMHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class CALDHFBHFJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string FEFBPCBFNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type EFLKEIPPFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly PGEBABALIJN MGCDMAEEPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly PNJBEGILGNN DGDLDGALAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public OEMJGPIOFFC BBKNADDGNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public GJIPPCMAPHB CBOBDKJEPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public COFJFKHDPEB HMMHNGELIHE;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x76E1030", Offset = "0x76DF830", VA = "0x1876E1030")]
	public CALDHFBHFJB(Type MBPNHBINGNC, string CANHCNAPBAJ, PNJBEGILGNN AOGBEJODONB, OEMJGPIOFFC BNHMFMIJKEA, GJIPPCMAPHB BFLBPBAPDHM, COFJFKHDPEB JDCKECIFKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x76E0F30", Offset = "0x76DF730", VA = "0x1876E0F30")]
	public object AGHBOCCGCPH(object? LIHCAHPMPHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2E5AB30", Offset = "0x2E59330", VA = "0x182E5AB30")]
	public void GLLFBGBKOLL<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x76E0F80", Offset = "0x76DF780", VA = "0x1876E0F80")]
	public void GLLFBGBKOLL(Type FNMBGLEDDIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class PFEAFFILOKH<T> : CALDHFBHFJB where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string HGKOJDBHNCG(T INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T GKDLMHMFDJO(string? BOBECAKGCBG, T DFEJJOPGBKP);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class ILINJAOBPBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public HGKOJDBHNCG serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public GKDLMHMFDJO parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public ILINJAOBPBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4326720", Offset = "0x4324F20", VA = "0x184326720")]
		internal string AKIKFAPLAOA(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4326760", Offset = "0x4324F60", VA = "0x184326760")]
		internal object CPLLHGDJEOK(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4C33F70", Offset = "0x4C32770", VA = "0x184C33F70")]
	public PFEAFFILOKH(PNJBEGILGNN AOGBEJODONB, string CANHCNAPBAJ, [Optional] HGKOJDBHNCG? BNHMFMIJKEA, [Optional] GKDLMHMFDJO? BFLBPBAPDHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4C33310", Offset = "0x4C31B10", VA = "0x184C33310")]
	private static object? KDFBDMHOPOO(GKDLMHMFDJO? BFLBPBAPDHM, string? BOBECAKGCBG, object? DFEJJOPGBKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4C32A70", Offset = "0x4C31270", VA = "0x184C32A70")]
	private static string KBGBIJFEDIC(HGKOJDBHNCG? KDFLPJBLINE, object? INDENPJBLHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string OEMJGPIOFFC(object? INDENPJBLHO);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object GJIPPCMAPHB(string? BOBECAKGCBG, [Optional] object DFEJJOPGBKP);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate KMLEKAJAPHJ COFJFKHDPEB();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class IFOPKGOEMIE
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class NPIFGGLEBOK : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static NPIFGGLEBOK ODDIIHPHFEL;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x76E84A0", Offset = "0x76E6CA0", VA = "0x1876E84A0", Slot = "4")]
		public bool Equals(List<string> KHINBLFKKED, List<string> NCCBPIFKDGE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x76E85F0", Offset = "0x76E6DF0", VA = "0x1876E85F0", Slot = "5")]
		public int GetHashCode(List<string> INCBEIDOHDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public NPIFGGLEBOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class IGPCEALLNEM : LEEIPAMBINP<MMMOADOBLEB>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x76E6810", Offset = "0x76E5010", VA = "0x1876E6810", Slot = "9")]
		public override string KBGBIJFEDIC(MMMOADOBLEB AOJEAJGBMCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x76E6640", Offset = "0x76E4E40", VA = "0x1876E6640", Slot = "10")]
		protected override bool AOECFGGFNPG(string AOJEAJGBMCP, [Out] MMMOADOBLEB INDENPJBLHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x76E6900", Offset = "0x76E5100", VA = "0x1876E6900")]
		public IGPCEALLNEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly NNNNDMKOBAD EKPFJJJHGND;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly IGPCEALLNEM FNMLJBBGHGF;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<CALDHFBHFJB> GIOEHNAHLMG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<PNJBEGILGNN> NPCLCEJHMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<PNJBEGILGNN, CALDHFBHFJB> PDHLDAGDCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x76E62F0", Offset = "0x76E4AF0", VA = "0x1876E62F0")]
	public IFOPKGOEMIE([Optional] IList<CALDHFBHFJB>? EBPOIBJFFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x76E4DB0", Offset = "0x76E35B0", VA = "0x1876E4DB0")]
	public CALDHFBHFJB NNLIKHFGFFP(PNJBEGILGNN AOGBEJODONB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface MHFDCEBLDCK
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	AAEPDGMIKIM BKGGPGMLNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class MOPIHOOHPOL : MHFDCEBLDCK
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static MOPIHOOHPOL CAMBBGPBNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly FAOPEMAGCMH EBLGGCPOLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<FAOPEMAGCMH> JEPDCOKGOHM;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public AAEPDGMIKIM BKGGPGMLNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x76E8190", Offset = "0x76E6990", VA = "0x1876E8190")]
	public MOPIHOOHPOL(FAOPEMAGCMH BMGCPDBBKOJ, IReadOnlyList<FAOPEMAGCMH> EHAKPHMDMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x76E72F0", Offset = "0x76E5AF0", VA = "0x1876E72F0")]
	private static MOPIHOOHPOL FLEFFCCNPOB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class PGDOHOBLFLK
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<NBGFMFDOHOO> OJHLGNKHMML;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x76E8860", Offset = "0x76E7060", VA = "0x1876E8860")]
	public static bool CGJPKNBCIHG(this OEDKOGGDKCO FPHGJJIHFFP, NBGFMFDOHOO MEFCPJOMJEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x76E8940", Offset = "0x76E7140", VA = "0x1876E8940")]
	public static bool JBDBABMLBAJ(this OEDKOGGDKCO FPHGJJIHFFP, NBGFMFDOHOO MEFCPJOMJEO, NIHPFEHJKNJ MLGCKEJNBKC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface HGMGHBFCMPP
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool FODDJGBKOLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool PDEEEKGDFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool NDBOBIGICOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool KBFINFHGNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool GLNPKIKAKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool GFHGJMJMMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool JNPLFIHDNPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool IAGKOAOENFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool DDNCACAJOCM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool LAJBOEDPIFB
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool AJGMNLFILLG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool FLCIKOOLDBE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> LDAIEENJPME
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	MMMOADOBLEB LDMDBHIHLJM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface AAEPDGMIKIM : HGMGHBFCMPP, BNIJGHJIOIK, JGFELNCMIMM<PNJBEGILGNN>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string FAABKAHOHKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	NBGFMFDOHOO ONAFEANHPOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) FMAOOBPNLPP<T>(PNJBEGILGNN AOGBEJODONB) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum PNJBEGILGNN
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	CAN_EDIT_ROOM_ROLES = 1,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	VOTE_KICK_PERMISSION = 3,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	CAN_INVITE = 4,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CAN_TALK = 6,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CAN_PRINT_PHOTOS = 7,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CAN_START_GAMES = 8,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CAN_SELF_REVIVE = 9,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	AUTO_ASSIGNED_GAME_ROLES = 11,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	CAN_CHANGE_GAME_MODE = 12,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CAN_USE_MAKER_PEN = 13,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CAN_USE_DELETE_ALL_BUTTON = 14,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CAN_SAVE_INVENTIONS = 15,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	DISABLE_MIC_AUTO_MUTE = 16,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CAN_END_GAMES_EARLY = 17,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CAN_USE_SHARE_CAM = 18,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	DEPRECATED_CAN_EDIT_CIRCUITS = 19,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	CAN_SPAWN_INVENTIONS = 20,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	CAN_SPAWN_CONSUMABLES = 21,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CAN_USE_ROOM_RESET_BUTTON = 22,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	AUTO_ASSIGNED_PLAYER_TAGS = 24,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	CAN_USE_RRS = 25,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	ROOM_LEVEL_THRESHOLD = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	CAN_SAVE_ROOM = 1001,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	CAN_PUBLISH_ROOM = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CAN_CLONE_ROOM = 1003,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	CAN_RESTORE_ROOM = 1004,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CAN_EDIT_MAIN_ROOM_SETTINGS = 1006,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CAN_EDIT_ROOM_ECON_SETTINGS = 1007,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CAN_CREATE_SUBROOMS = 1008,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	CAN_NAME_SUBROOMS = 1009,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CAN_CLONE_SUBROOMS = 1010,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	CAN_MOVE_SUBROOMS = 1011,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	CAN_DELETE_SUBROOMS = 1012,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	CAN_EDIT_SUBROOM_SETTINGS = 1013,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	CAN_RESET_CLOUD_VARIABLES = 1014,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CAN_DELETE_CLOUD_VARIABLES = 1015,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	CAN_EDIT_ROOM_PROGRESSION = 1016,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	CAN_REMOVE_ROOM_BANS = 1017,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	CAN_ADD_ROOM_BANS = 1018
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal class FAOPEMAGCMH : AAEPDGMIKIM, HGMGHBFCMPP, BNIJGHJIOIK, JGFELNCMIMM<PNJBEGILGNN>
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly IFOPKGOEMIE PMFOJIGNOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal readonly AAEEFJMKDGN JLNPHMFEIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private string? EHNHJIPHPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? BHFELKPMLLA;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool AMGNDLLICBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x76E14F0", Offset = "0x76DFCF0", VA = "0x1876E14F0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool NIKLPKGGBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x76E1350", Offset = "0x76DFB50", VA = "0x1876E1350", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool BIFENJNNFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x76E1200", Offset = "0x76DFA00", VA = "0x1876E1200", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool BNNFGLEHADL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x76E14A0", Offset = "0x76DFCA0", VA = "0x1876E14A0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool FCCDHKJKJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x76E1540", Offset = "0x76DFD40", VA = "0x1876E1540", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool GLNHDAIOCII
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x76E1E60", Offset = "0x76E0660", VA = "0x1876E1E60", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public NBGFMFDOHOO ONAFEANHPOG
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9575D0", Offset = "0x955DD0", VA = "0x1809575D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(NBGFMFDOHOO);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8C0150", Offset = "0x8BE950", VA = "0x1808C0150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string BJHPKCLIJOM
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x76E21A0", Offset = "0x76E09A0", VA = "0x1876E21A0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x76E1830", Offset = "0x76E0030", VA = "0x1876E1830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string FAABKAHOHKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x76E21A0", Offset = "0x76E09A0", VA = "0x1876E21A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool FJPHKJADJBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9EA050", Offset = "0x9E8850", VA = "0x1809EA050")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9E9C10", Offset = "0x9E8410", VA = "0x1809E9C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool FODDJGBKOLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x76E2D30", Offset = "0x76E1530", VA = "0x1876E2D30", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public MMMOADOBLEB LDMDBHIHLJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x76E2E80", Offset = "0x76E1680", VA = "0x1876E2E80", Slot = "20")]
		get
		{
			return default(MMMOADOBLEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool PDEEEKGDFHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x76E17E0", Offset = "0x76DFFE0", VA = "0x1876E17E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool NDBOBIGICOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x76E1300", Offset = "0x76DFB00", VA = "0x1876E1300", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool KBFINFHGNAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x76E18D0", Offset = "0x76E00D0", VA = "0x1876E18D0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool GLNPKIKAKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x76E1590", Offset = "0x76DFD90", VA = "0x1876E1590", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool GFHGJMJMMBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x76E2CE0", Offset = "0x76E14E0", VA = "0x1876E2CE0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool JNPLFIHDNPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x76E1880", Offset = "0x76E0080", VA = "0x1876E1880", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool IAGKOAOENFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x76E2BC0", Offset = "0x76E13C0", VA = "0x1876E2BC0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool DDNCACAJOCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x76E2B70", Offset = "0x76E1370", VA = "0x1876E2B70", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> LDAIEENJPME
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x76E1D00", Offset = "0x76E0500", VA = "0x1876E1D00", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool GGILNPBODCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x76E14F0", Offset = "0x76DFCF0", VA = "0x1876E14F0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool AKPKJHHDNJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x76E1540", Offset = "0x76DFD40", VA = "0x1876E1540", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool BGELBDKHPHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x76E1350", Offset = "0x76DFB50", VA = "0x1876E1350", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool LAJBOEDPIFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x76E10D0", Offset = "0x76DF8D0", VA = "0x1876E10D0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool AJGMNLFILLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x76E2C10", Offset = "0x76E1410", VA = "0x1876E2C10", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool FOPAKNGAIJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x76E1200", Offset = "0x76DFA00", VA = "0x1876E1200", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool FLCIKOOLDBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x76E1E10", Offset = "0x76E0610", VA = "0x1876E1E10", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool IFBIEMINBJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x76E14A0", Offset = "0x76DFCA0", VA = "0x1876E14A0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool PLLHLPJOHEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x76E1E60", Offset = "0x76E0660", VA = "0x1876E1E60", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event EKFPEJBEOKH<PNJBEGILGNN> EJBNOOGMGKA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x76E1250", Offset = "0x76DFA50", VA = "0x1876E1250", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x76E2D80", Offset = "0x76E1580", VA = "0x1876E2D80", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x305F9B0", Offset = "0x305E1B0", VA = "0x18305F9B0", Slot = "6")]
	public (bool, T?) FMAOOBPNLPP<T>(PNJBEGILGNN AOGBEJODONB) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x305FBA0", Offset = "0x305E3A0", VA = "0x18305FBA0")]
	public FAOPEMAGCMH MHNCOKBPHOP<T>(PNJBEGILGNN AOGBEJODONB, bool PNBHNPEAJLA, T INDENPJBLHO) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x76E2F60", Offset = "0x76E1760", VA = "0x1876E2F60")]
	public FAOPEMAGCMH(NBGFMFDOHOO MEFCPJOMJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x76E3170", Offset = "0x76E1970", VA = "0x1876E3170")]
	public FAOPEMAGCMH(NBGFMFDOHOO MEFCPJOMJEO, [Optional] string? EHNHJIPHPED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x76E2F80", Offset = "0x76E1780", VA = "0x1876E2F80")]
	public FAOPEMAGCMH(FAOPEMAGCMH LHJDLBPKFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x76E3010", Offset = "0x76E1810", VA = "0x1876E3010")]
	internal FAOPEMAGCMH(NBGFMFDOHOO HMIHENOEFOB, [Optional] string? EHNHJIPHPED, [Optional] FAOPEMAGCMH? LHJDLBPKFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x76E2C60", Offset = "0x76E1460", VA = "0x1876E2C60")]
	public static PGEBABALIJN OJGPLACGBCA(PNJBEGILGNN AOGBEJODONB)
	{
		return default(PGEBABALIJN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x76E1D60", Offset = "0x76E0560", VA = "0x1876E1D60")]
	public void IGJKDNEDMHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x76E1EB0", Offset = "0x76E06B0", VA = "0x1876E1EB0")]
	internal FAOPEMAGCMH JKHOHOPGAOO(FAOPEMAGCMH KGKGIOHHJKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x76E1920", Offset = "0x76E0120", VA = "0x1876E1920")]
	internal IReadOnlyCollection<PNJBEGILGNN> GPGJNKBEMKC(FAOPEMAGCMH LHJDLBPKFNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x76E1120", Offset = "0x76DF920", VA = "0x1876E1120")]
	public bool ADFOMHJGHDP(PNJBEGILGNN AOGBEJODONB, bool PNBHNPEAJLA, string ACDIKMBKLKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x76E13A0", Offset = "0x76DFBA0", VA = "0x1876E13A0")]
	public (bool, string) BKHDLOFMBHF(PNJBEGILGNN AOGBEJODONB)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x76E2E30", Offset = "0x76E1630", VA = "0x1876E2E30")]
	internal void PJAJDKGJIEO(PNJBEGILGNN AOGBEJODONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x76E15E0", Offset = "0x76DFDE0", VA = "0x1876E15E0")]
	public JFPFHPCBINJ EHJDAECGPMM(Func<NBGFMFDOHOO, Guid> EHFHJDHPCEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x76E21F0", Offset = "0x76E09F0", VA = "0x1876E21F0")]
	public void JNCIHBJMFLK(JFPFHPCBINJ ANHABDCBOFO, Func<Guid, NBGFMFDOHOO> JGEPFGAHMPB, [Optional] NBGFMFDOHOO? OGFPJDMDAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x76E1D80", Offset = "0x76E0580", VA = "0x1876E1D80")]
	[CompilerGenerated]
	private void IKENGHPMDHA(PNJBEGILGNN IKOHHNDHMDN, GODPHAEIJLL CEJNOBMHGDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class BPILGPHADFM : DJGIANGJMMK, DHEMDIHJAOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class FFKPEAKHPNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public FAOPEMAGCMH newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public FFKPEAKHPNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x76E3190", Offset = "0x76E1990", VA = "0x1876E3190")]
		internal bool CDFLIBIFJLF(FAOPEMAGCMH rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class JAGGHGJFLHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public NBGFMFDOHOO roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public JAGGHGJFLHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x76E6940", Offset = "0x76E5140", VA = "0x1876E6940")]
		internal bool COBGHGOFBJK(NBGFMFDOHOO r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct JDNPCFEOEGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public BPILGPHADFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public LAENOPFABFD roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<LJAFLFBHFEG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x76E6950", Offset = "0x76E5150", VA = "0x1876E6950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x76E6FC0", Offset = "0x76E57C0", VA = "0x1876E6FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class NIMNPINLCCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public NIMNPINLCCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x76E82A0", Offset = "0x76E6AA0", VA = "0x1876E82A0")]
		internal void KLBLGANAOKB(JFPFHPCBINJ r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x76E8380", Offset = "0x76E6B80", VA = "0x1876E8380")]
		internal void LOBJHANJPEA(JFPFHPCBINJ r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct DBMJPFKBNNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public LAENOPFABFD roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class IFNOBHCMLIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Func<JFPFHPCBINJ, GODPHAEIJLL> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public IFNOBHCMLIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x76E4D50", Offset = "0x76E3550", VA = "0x1876E4D50")]
		internal void PHMDBKHCPMK(JFPFHPCBINJ r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x76E4D20", Offset = "0x76E3520", VA = "0x1876E4D20")]
		internal void NBMOGMKDKGP(JFPFHPCBINJ r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x76E4D80", Offset = "0x76E3580", VA = "0x1876E4D80")]
		internal void PKJIIANBNOA(JFPFHPCBINJ r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class OPMCLMFGJEB<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public OPMCLMFGJEB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter<LJAFLFBHFEG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x39C7A50", Offset = "0x39C6250", VA = "0x1839C7A50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x908140", Offset = "0x906940", VA = "0x180908140", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public PNJBEGILGNN rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public NBGFMFDOHOO accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public PGEBABALIJN recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public BPILGPHADFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public OPMCLMFGJEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4B71700", Offset = "0x4B6FF00", VA = "0x184B71700")]
		[AsyncStateMachine(typeof(OPMCLMFGJEB<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void HKAEIJHAAGE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct KDCBDGOJJHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public IReadOnlyList<KAEIFEDOMBM> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct GFPEHMGDHNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public GEMFDHDCNGM rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public LAENOPFABFD roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public IReadOnlyDictionary<NBGFMFDOHOO, FAOPEMAGCMH> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public HPEADDKCNII debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x76E3A70", Offset = "0x76E2270", VA = "0x1876E3A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x76E4590", Offset = "0x76E2D90", VA = "0x1876E4590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly GEMFDHDCNGM BNKOBKKKABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly MOPIHOOHPOL DDBIPDGFFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly HPEADDKCNII DIBOKBALCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Dictionary<int, FAOPEMAGCMH> NDOEEKEEADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	internal readonly Dictionary<NBGFMFDOHOO, FAOPEMAGCMH> DJFBKNMJDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<NBGFMFDOHOO, FAOPEMAGCMH> MCCHKLCIOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly List<FAOPEMAGCMH> GMDLCCEEBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private bool AJGPDDCIOPC;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly PNJBEGILGNN[] JOCHIFNNOJO;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public MHFDCEBLDCK ANALDEEPAHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<AAEPDGMIKIM> MENLBLFGLBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x76DBB40", Offset = "0x76DA340", VA = "0x1876DBB40", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event CEBDOLDPMME PDPFOKBJGDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x76DC0F0", Offset = "0x76DA8F0", VA = "0x1876DC0F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x76DB430", Offset = "0x76D9C30", VA = "0x1876DB430", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x76DFE90", Offset = "0x76DE690", VA = "0x1876DFE90")]
	[PDAMAKFHAHC.NMMFGDGMJIH]
	internal static void NJDIOBPBJFD(CMONJLKOOCI CGNEPIEHDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x76E0C70", Offset = "0x76DF470", VA = "0x1876E0C70")]
	[UnityEngine.Scripting.Preserve]
	internal BPILGPHADFM([NDCFMLCHJCI(null)] GEMFDHDCNGM ACMKJHPIFOH, [NDCFMLCHJCI(null)] MOPIHOOHPOL FHPFGACBFNJ, [NDCFMLCHJCI(null)] HPEADDKCNII DIBOKBALCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x76DD4B0", Offset = "0x76DBCB0", VA = "0x1876DD4B0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x76DC190", Offset = "0x76DA990", VA = "0x1876DC190")]
	private void DAIDOGLMOKD(IEnumerable<FAOPEMAGCMH> KLLKFANFFNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x76DEFE0", Offset = "0x76DD7E0", VA = "0x1876DEFE0", Slot = "12")]
	public bool HBOFCPJGHID(OEDKOGGDKCO FGIHDJGGIMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x76DFB50", Offset = "0x76DE350", VA = "0x1876DFB50")]
	private void LJGLNOKLKNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x76DBB90", Offset = "0x76DA390", VA = "0x1876DBB90")]
	private void CDDDKJKNCBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x76DDB70", Offset = "0x76DC370", VA = "0x1876DDB70", Slot = "10")]
	public IReadOnlyList<AAEPDGMIKIM> FOIBNJJDGHL(bool FCDICPJMFAD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x76DEAC0", Offset = "0x76DD2C0", VA = "0x1876DEAC0", Slot = "11")]
	public AAEPDGMIKIM GJIIGLKAMAL(OEDKOGGDKCO FGIHDJGGIMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x76DEF10", Offset = "0x76DD710", VA = "0x1876DEF10")]
	private NBGFMFDOHOO GPFAODBOIOC(OEDKOGGDKCO FGIHDJGGIMF)
	{
		return default(NBGFMFDOHOO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x76DD2A0", Offset = "0x76DBAA0", VA = "0x1876DD2A0", Slot = "14")]
	public bool DNCNIJNDLAE(OEDKOGGDKCO NCKFLPIPOBC, NBGFMFDOHOO MEFCPJOMJEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x76DDBF0", Offset = "0x76DC3F0", VA = "0x1876DDBF0", Slot = "15")]
	public AAEPDGMIKIM FONCPBGDPFM(NBGFMFDOHOO MEFCPJOMJEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x76DFB60", Offset = "0x76DE360", VA = "0x1876DFB60")]
	private static bool MPLNMGDKGGC(OHPDLCLDFFM OEFLJBKIJFB, NBGFMFDOHOO MEFCPJOMJEO, [Out] JFPFHPCBINJ? NFJHOIFCJFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x76DC000", Offset = "0x76DA800", VA = "0x1876DC000")]
	private static void CMCOPLBFNLB(OHPDLCLDFFM OEFLJBKIJFB, Action<JFPFHPCBINJ> JNLFAMADDBM, NBGFMFDOHOO IMBGBFDELPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x76DBD70", Offset = "0x76DA570", VA = "0x1876DBD70")]
	private static void CMCOPLBFNLB(OHPDLCLDFFM OEFLJBKIJFB, Action<JFPFHPCBINJ> JNLFAMADDBM, Predicate<NBGFMFDOHOO> OJAPGIDMGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x76DB4D0", Offset = "0x76D9CD0", VA = "0x1876DB4D0")]
	private void ANJHKIGNCGK(OEDKOGGDKCO FGIHDJGGIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x76DFA10", Offset = "0x76DE210", VA = "0x1876DFA10", Slot = "4")]
	[AsyncStateMachine(typeof(JDNPCFEOEGH))]
	public Task KODJJDJJNBF([CanBeNull] LAENOPFABFD NKIGLKBMOAI, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
	public void OFOPLMGGPCD(LAENOPFABFD NKIGLKBMOAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x76DEBD0", Offset = "0x76DD3D0", VA = "0x1876DEBD0")]
	private void GNICPDKAKPE(OHPDLCLDFFM IFPKJLONPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x76E0790", Offset = "0x76DEF90", VA = "0x1876E0790")]
	internal static string OEKEMELLLHF(GEMFDHDCNGM BNKOBKKKABM, LAENOPFABFD NKIGLKBMOAI, IReadOnlyDictionary<NBGFMFDOHOO, FAOPEMAGCMH> DJFBKNMJDGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x76DDC90", Offset = "0x76DC490", VA = "0x1876DDC90")]
	private static void GAPOOKDLAMP(LAENOPFABFD NKIGLKBMOAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x76DB7F0", Offset = "0x76D9FF0", VA = "0x1876DB7F0")]
	private static void BJMDEJIDIOK(OHPDLCLDFFM MDFJMKIGANL, IReadOnlyDictionary<NBGFMFDOHOO, FAOPEMAGCMH> DJFBKNMJDGE, StringBuilder NDKEDIEECGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x76DC9F0", Offset = "0x76DB1F0", VA = "0x1876DC9F0")]
	private static bool DEEEMIHBPMP(string JKKBPKPGPOA, [Out] Guid OMNLEKJIGOK, [Out] NBGFMFDOHOO MEFCPJOMJEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x76E0050", Offset = "0x76DE850", VA = "0x1876E0050")]
	private static void NJPGJNLDBNN(LAENOPFABFD NKIGLKBMOAI, StringBuilder NDKEDIEECGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2DF6BE0", Offset = "0x2DF53E0", VA = "0x182DF6BE0", Slot = "16")]
	public bool ECACBJBDHDB<T>(NBGFMFDOHOO MEFCPJOMJEO, PNJBEGILGNN AOGBEJODONB, bool PNBHNPEAJLA, T HBIPIPALDEO, [Optional] Action FIGBMONMMBB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x76DD430", Offset = "0x76DBC30", VA = "0x1876DD430", Slot = "17")]
	public string DOBFPDFFHOE(PNJBEGILGNN AOGBEJODONB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x76DF3A0", Offset = "0x76DDBA0", VA = "0x1876DF3A0")]
	private void HIOBCIBBNLF(NBGFMFDOHOO MEFCPJOMJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x76DFB30", Offset = "0x76DE330", VA = "0x1876DFB30")]
	private bool KOPNDOPHLCJ(OEDKOGGDKCO FGIHDJGGIMF, NBGFMFDOHOO MEFCPJOMJEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x76DF6E0", Offset = "0x76DDEE0", VA = "0x1876DF6E0")]
	internal FAOPEMAGCMH KLOGOIBFBJO(OEDKOGGDKCO FGIHDJGGIMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x76DB7E0", Offset = "0x76D9FE0", VA = "0x1876DB7E0", Slot = "13")]
	public IReadOnlyList<AAEPDGMIKIM> BFPMGJPEDBO(OEDKOGGDKCO FGIHDJGGIMF, bool FHKGMOGKNCL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x76DD5C0", Offset = "0x76DBDC0", VA = "0x1876DD5C0")]
	internal IReadOnlyList<FAOPEMAGCMH> EHEDEFFONPP(OEDKOGGDKCO FGIHDJGGIMF, bool FHKGMOGKNCL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x76DCB00", Offset = "0x76DB300", VA = "0x1876DCB00")]
	private void DGIPKHOELKF(LJAFLFBHFEG PLHJINCNLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x76DF0B0", Offset = "0x76DD8B0", VA = "0x1876DF0B0")]
	private static bool HHMFJPHCKFA(FAOPEMAGCMH MGDHKJANIDA, IReadOnlyDictionary<NBGFMFDOHOO, FAOPEMAGCMH> DJFBKNMJDGE, [Out] IReadOnlyList<PNJBEGILGNN> EOEKNBCIHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x76DF5A0", Offset = "0x76DDDA0", VA = "0x1876DF5A0")]
	[AsyncStateMachine(typeof(GFPEHMGDHNM))]
	private static Task KJJFJCFJJMG(GEMFDHDCNGM BNKOBKKKABM, LAENOPFABFD NKIGLKBMOAI, IReadOnlyDictionary<NBGFMFDOHOO, FAOPEMAGCMH> DJFBKNMJDGE, HPEADDKCNII DIBOKBALCMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x76DB540", Offset = "0x76D9D40", VA = "0x1876DB540")]
	[CompilerGenerated]
	internal static void AOLKGGBKLDF(Func<JFPFHPCBINJ, GODPHAEIJLL> GGCDANADGNB, DBMJPFKBNNK P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x76DD7F0", Offset = "0x76DBFF0", VA = "0x1876DD7F0")]
	[CompilerGenerated]
	internal static bool FCBIOAJKFFG(NBGFMFDOHOO MEFCPJOMJEO, PNJBEGILGNN AOGBEJODONB, [Out] KAEIFEDOMBM DECPBFKKLFG, KDCBDGOJJHP P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface KAEFFBOLFFK
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DNOCPLLBBHH(OEDKOGGDKCO HMBNNPBNNKF, OEDKOGGDKCO PNGEHMCDGGJ, IEnumerable<OEDKOGGDKCO> NLJJBEGCGOF, [Out] MMMOADOBLEB BIJEBAJFKNA, [Out] FPMGANMIOPA GIFNFOEHELK);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string ADBEBBKACCH(FPMGANMIOPA LHLCCOJDBEK);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum FPMGANMIOPA : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal class GCFPBLDDHKB : KAEFFBOLFFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly DHEMDIHJAOF KIHNHCBDLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly HOLBEKNCLCC OIHPDKEKLBO;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8C5E90", Offset = "0x8C4690", VA = "0x1808C5E90")]
	[RecRoom.NoEngine.Common.Preserve]
	public GCFPBLDDHKB([NDCFMLCHJCI(null)] DHEMDIHJAOF DLFCHGALDEA, [NDCFMLCHJCI(null)] HOLBEKNCLCC ODENCHFCDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x76E39D0", Offset = "0x76E21D0", VA = "0x1876E39D0")]
	private static NNDNNJJNDAA? KEDNEENNMNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x76E32C0", Offset = "0x76E1AC0", VA = "0x1876E32C0", Slot = "4")]
	public bool DNOCPLLBBHH(OEDKOGGDKCO HMBNNPBNNKF, OEDKOGGDKCO PNGEHMCDGGJ, IEnumerable<OEDKOGGDKCO> NLJJBEGCGOF, [Out] MMMOADOBLEB BIJEBAJFKNA, [Out] FPMGANMIOPA GIFNFOEHELK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x76E31C0", Offset = "0x76E19C0", VA = "0x1876E31C0", Slot = "5")]
	public string ADBEBBKACCH(FPMGANMIOPA LHLCCOJDBEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x76E33C0", Offset = "0x76E1BC0", VA = "0x1876E33C0")]
	internal bool GBFGJOMOFEH(OEDKOGGDKCO HMBNNPBNNKF, OEDKOGGDKCO PNGEHMCDGGJ, IEnumerable<OEDKOGGDKCO> NLJJBEGCGOF, NIHPFEHJKNJ MLGCKEJNBKC, NNDNNJJNDAA? HNKEDPMPMLG, [Out] MMMOADOBLEB BIJEBAJFKNA, [Out] FPMGANMIOPA GIFNFOEHELK)
	{
		return default(bool);
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

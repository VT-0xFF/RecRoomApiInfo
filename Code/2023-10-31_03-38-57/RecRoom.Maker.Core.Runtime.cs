using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CA8E60", Offset = "0x5CA8260", VA = "0x185CA8E60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x787CA0", Offset = "0x7870A0", VA = "0x180787CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x787CE0", Offset = "0x7870E0", VA = "0x180787CE0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OGOIMAJLBGI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(HGBCFBENMKI MIJLEIMAMEG);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData BGICHGONLEL, Collider IBJCDAGGPKP, HGBCFBENMKI MIJLEIMAMEG, [Optional] OKMBENJPNJO? AIBMKIGJALB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData BGICHGONLEL);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FJOAEJDPCGN<TData> : BKECAGAKOAK, DJHCFGAKEJC<TData>, IPPGMABNEKE<TData>, BGKFOCDBEJI<TData>, FLMHHHMLCNK, FIMKFJMEIND<TData>, FNDOBIGDAEM, PILIKLBJCOH
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FIMKFJMEIND<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 HJGLLCKAOEB, Vector3 PIOPMIBANBL, float EJKOOCGEPCD, [Out] T JCDPFHMLOMM, [Out] Vector3 NEKLHKCJIEH, [Out] Collider IBJCDAGGPKP);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 HJGLLCKAOEB, Vector3 PIOPMIBANBL, float GCPIAKLILKG, float EJKOOCGEPCD, T[] NFDPDNGDHHB, [Out] Vector3 KPJIKGOHECN, [Out] Collider NKKHDMEGOGJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 HJGLLCKAOEB, float GCPIAKLILKG, Vector3 HGDEMPCIGJB, T[] NFDPDNGDHHB);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BKECAGAKOAK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds PEELAJIDAGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform FEIEGKLLHLN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds PDNGLKEMHAO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform MKHEIKPEBEL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 KFLKAHLAGBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool NIMKPJKNNPJ = true, int NIOFAJNKMAD = 0);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool JCOKMJNNAOD, object KJAGMGIFCEM);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PILIKLBJCOH
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	OAELJMFAJKM GCKFJMNNHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BGKFOCDBEJI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool OFCBJKPNPGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int MHJAENKMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<TData> JLJAICEALDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData JJEIFGHOKOA);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData JJEIFGHOKOA);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DJHCFGAKEJC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T BAFDGKKJJJD, [Optional] OKMBENJPNJO? OPGIAEPOGBD, bool FLLBOCMFKND = true);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int OGEHFGGOGMJ, IEnumerable<T> EHLLEAGNEMN, bool FLLBOCMFKND = true);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int OGEHFGGOGMJ, IEnumerable<T> EHLLEAGNEMN, OKMBENJPNJO OPGIAEPOGBD, bool FLLBOCMFKND = true);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FNDOBIGDAEM
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FLMHHHMLCNK
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool NHMPAONKECB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool BILKBDMPCJB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool BPNBIPFHAKM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool EPAMJPJGABH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class FGPAGJGLDNG<TReceiver> : MEEEIOJCLIN<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x33B82F0", Offset = "0x33B76F0", VA = "0x1833B82F0")]
	public FGPAGJGLDNG(TReceiver CEICCLOGOBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class JLEIHCFFECI<TReceiver, TFromTask> : MEEEIOJCLIN<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x33B82F0", Offset = "0x33B76F0", VA = "0x1833B82F0")]
	public JLEIHCFFECI(TReceiver CEICCLOGOBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class MEEEIOJCLIN<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver CEICCLOGOBN;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3B61240", Offset = "0x3B60640", VA = "0x183B61240")]
	public MEEEIOJCLIN(TReceiver CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute PKJOKDNDIPB();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class MJDHJGJNPGL<TReceiver, TResult> : MEEEIOJCLIN<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x33B82F0", Offset = "0x33B76F0", VA = "0x1833B82F0")]
	public MJDHJGJNPGL(TReceiver CEICCLOGOBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct OJOBLBEDGDD<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup HNCFAPNIOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData LEMJGICDCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> MPGKMANNNCP;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x18EFB60", Offset = "0x18EEF60", VA = "0x1818EFB60")]
	public OJOBLBEDGDD(TGroup KCENHMKLFJA, TData NBCAHLPAFCL, IEnumerable<TData> LJFDPLLMPMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct LKCHJNNJAMC<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup HNCFAPNIOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> MPGKMANNNCP;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7EFC80", Offset = "0x7EF080", VA = "0x1807EFC80")]
	public LKCHJNNJAMC(TGroup KCENHMKLFJA, IEnumerable<TData> LJFDPLLMPMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct BGKFAIBPIKF<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup HNCFAPNIOPB;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7E8520", Offset = "0x7E7920", VA = "0x1807E8520")]
	public BGKFAIBPIKF(TGroup KCENHMKLFJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct NMHIDMFOEKG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> MPGKMANNNCP;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7E8520", Offset = "0x7E7920", VA = "0x1807E8520")]
	public NMHIDMFOEKG(IEnumerable<TData> LJFDPLLMPMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface BNDLPBJLGLN<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EMOEOBGAMFL JOBPGNFCMEA(OJOBLBEDGDD<TGroup, TData> FCIHPHNOKEF);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EMOEOBGAMFL IDODINMNECD(OJOBLBEDGDD<TGroup, TData> FCIHPHNOKEF);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EMOEOBGAMFL PBLPPDOLIOG(LKCHJNNJAMC<TGroup, TData> FCIHPHNOKEF);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EMOEOBGAMFL GPOBIDFHFLJ(BGKFAIBPIKF<TGroup> FCIHPHNOKEF);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface MFKGLCPBBFO<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EMOEOBGAMFL> JOBPGNFCMEA(NMHIDMFOEKG<TData> FCIHPHNOKEF);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LEDFBFNPIOI<TGroup, TData> : MJDHJGJNPGL<BNDLPBJLGLN<TGroup, TData>, EMOEOBGAMFL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly LKCHJNNJAMC<TGroup, TData> FCIHPHNOKEF;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3976690", Offset = "0x3975A90", VA = "0x183976690")]
	public LEDFBFNPIOI(TGroup KCENHMKLFJA, IEnumerable<TData> LJFDPLLMPMD, BNDLPBJLGLN<TGroup, TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x39765C0", Offset = "0x39759C0", VA = "0x1839765C0", Slot = "4")]
	public override EMOEOBGAMFL PKJOKDNDIPB()
	{
		return default(EMOEOBGAMFL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class PMAIOIHKJMG<TGroup, TData> : MJDHJGJNPGL<BNDLPBJLGLN<TGroup, TData>, EMOEOBGAMFL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly OJOBLBEDGDD<TGroup, TData> FCIHPHNOKEF;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3B5B750", Offset = "0x3B5AB50", VA = "0x183B5B750")]
	public PMAIOIHKJMG(TGroup KCENHMKLFJA, TData DJHKMJKGFBO, IEnumerable<TData> LJFDPLLMPMD, BNDLPBJLGLN<TGroup, TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3E07EB0", Offset = "0x3E072B0", VA = "0x183E07EB0", Slot = "4")]
	public override EMOEOBGAMFL PKJOKDNDIPB()
	{
		return default(EMOEOBGAMFL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class EKDJCNNFNMF<TGroup, TData> : MJDHJGJNPGL<BNDLPBJLGLN<TGroup, TData>, EMOEOBGAMFL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly BGKFAIBPIKF<TGroup> FCIHPHNOKEF;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x30765F0", Offset = "0x30759F0", VA = "0x1830765F0")]
	public EKDJCNNFNMF(TGroup KCENHMKLFJA, BNDLPBJLGLN<TGroup, TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3076520", Offset = "0x3075920", VA = "0x183076520", Slot = "4")]
	public override EMOEOBGAMFL PKJOKDNDIPB()
	{
		return default(EMOEOBGAMFL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class MBANNBECHON<TGroup, TData> : MJDHJGJNPGL<BNDLPBJLGLN<TGroup, TData>, EMOEOBGAMFL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly OJOBLBEDGDD<TGroup, TData> FCIHPHNOKEF;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3B5B750", Offset = "0x3B5AB50", VA = "0x183B5B750")]
	public MBANNBECHON(TGroup KCENHMKLFJA, TData NBCAHLPAFCL, IEnumerable<TData> LJFDPLLMPMD, BNDLPBJLGLN<TGroup, TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3B5B670", Offset = "0x3B5AA70", VA = "0x183B5B670", Slot = "4")]
	public override EMOEOBGAMFL PKJOKDNDIPB()
	{
		return default(EMOEOBGAMFL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JCGPCDDIOHM<TData> : JLEIHCFFECI<MFKGLCPBBFO<TData>, EMOEOBGAMFL> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct HCFIFNCJCMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<EMOEOBGAMFL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public JCGPCDDIOHM<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<EMOEOBGAMFL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3531970", Offset = "0x3530D70", VA = "0x183531970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3531C10", Offset = "0x3531010", VA = "0x183531C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private NMHIDMFOEKG<TData> FCIHPHNOKEF;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x30765F0", Offset = "0x30759F0", VA = "0x1830765F0")]
	public JCGPCDDIOHM(IEnumerable<TData> CFNLONIEIIB, MFKGLCPBBFO<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x382F520", Offset = "0x382E920", VA = "0x18382F520", Slot = "4")]
	[AsyncStateMachine(typeof(JCGPCDDIOHM<>.HCFIFNCJCMB))]
	public override Task<EMOEOBGAMFL> PKJOKDNDIPB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct OCDBHBBIGFO<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public TNode AHLJENGMNBB;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3CDD910", Offset = "0x3CDCD10", VA = "0x183CDD910")]
	public OCDBHBBIGFO(TNode AHLJENGMNBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct HNHJCKGKMHI<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public TNode KJLIHIEOJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public MBBIGKMMFLL BLGPNFINLLK;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3570190", Offset = "0x356F590", VA = "0x183570190")]
	public HNHJCKGKMHI(TNode KJLIHIEOJBD, MBBIGKMMFLL BLGPNFINLLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface BLGKOJGGLFC<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HOHECKHOFIF([In] OCDBHBBIGFO<TNode> GMADLPGCHDK);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HJDGGLFGKLO([In] HNHJCKGKMHI<TNode> GPIEDKEMJPP);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HBOFBHOPMPI();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FFKFIEBBCPJ<TNode> : FGPAGJGLDNG<BLGKOJGGLFC<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x33B82F0", Offset = "0x33B76F0", VA = "0x1833B82F0")]
	public FFKFIEBBCPJ(BLGKOJGGLFC<TNode> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x33CEC40", Offset = "0x33CE040", VA = "0x1833CEC40", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class CLKOBBCDFAJ<TNode> : FGPAGJGLDNG<BLGKOJGGLFC<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly HNHJCKGKMHI<TNode> GPIEDKEMJPP;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4AE52D0", Offset = "0x4AE46D0", VA = "0x184AE52D0")]
	public CLKOBBCDFAJ(TNode KJLIHIEOJBD, MBBIGKMMFLL BLGPNFINLLK, BLGKOJGGLFC<TNode> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x302A400", Offset = "0x3029800", VA = "0x18302A400", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class NCEKFCIKCNE<TNode> : FGPAGJGLDNG<BLGKOJGGLFC<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly OCDBHBBIGFO<TNode> GMADLPGCHDK;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3BFB8B0", Offset = "0x3BFACB0", VA = "0x183BFB8B0")]
	public NCEKFCIKCNE(TNode HDJGBODBMCI, BLGKOJGGLFC<TNode> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x33E3140", Offset = "0x33E2540", VA = "0x1833E3140", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct PNKAMLCABHK<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public TSpawnInfo JJMPALNKDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Vector3 LPAPEIIOLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Quaternion KBKHJHIFKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float NMGPAHAPPCF;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xD6DB50", Offset = "0xD6CF50", VA = "0x180D6DB50")]
	public PNKAMLCABHK(TSpawnInfo JJMPALNKDNN, Vector3 LPAPEIIOLFG, Quaternion KBKHJHIFKGI, float NMGPAHAPPCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface GBBNHIFCDJP<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> GFKBHNHIFOD([In] PNKAMLCABHK<TSpawnInfo> MCGFLNAFJHN, CancellationToken ELGJALILGJE);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class IJCEJNMFDEN<TSpawnType, TSpawnInfo> : JLEIHCFFECI<GBBNHIFCDJP<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly PNKAMLCABHK<TSpawnInfo> CAAIHKBHIAA;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x363AA50", Offset = "0x3639E50", VA = "0x18363AA50")]
	public IJCEJNMFDEN(TSpawnInfo MEJPLFDODPH, Vector3 LPAPEIIOLFG, Quaternion KBKHJHIFKGI, float NMGPAHAPPCF, GBBNHIFCDJP<TSpawnType, TSpawnInfo> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x363A780", Offset = "0x3639B80", VA = "0x18363A780", Slot = "4")]
	public override Task<TSpawnType> PKJOKDNDIPB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct LLOJNCGBIHH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly IEnumerable<TData> MPGKMANNNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly bool NNABHNIMCBL;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3983540", Offset = "0x3982940", VA = "0x183983540")]
	public LLOJNCGBIHH(IEnumerable<TData> LJFDPLLMPMD, bool OGDFCLDHMHG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface JGGDEEBFMDA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EMOEOBGAMFL> AOHNMFLFNHN([In] LLOJNCGBIHH<TData> NOIEGIONPHL, CancellationToken ELGJALILGJE);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class POIJEKLDMGC<TData> : JLEIHCFFECI<JGGDEEBFMDA<TData>, EMOEOBGAMFL> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly LLOJNCGBIHH<TData> OLICHGKFGDI;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3E10A30", Offset = "0x3E0FE30", VA = "0x183E10A30")]
	public POIJEKLDMGC(IEnumerable<TData> LJFDPLLMPMD, bool OGDFCLDHMHG, JGGDEEBFMDA<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x363A780", Offset = "0x3639B80", VA = "0x18363A780", Slot = "4")]
	public override Task<EMOEOBGAMFL> PKJOKDNDIPB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct LLGOMFNBBJO<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T BGICHGONLEL;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3982020", Offset = "0x3981420", VA = "0x183982020")]
	public LLGOMFNBBJO(T KACNOJDGCMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface FCJMCFFBJHE<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HOHECKHOFIF([In] LLGOMFNBBJO<T> MCPJHKGBCIF);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HJDGGLFGKLO();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface OCDFFOEGBGN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PKJOKDNDIPB([In] HEHEBMKBJHI<T> HJMLADJEIKM);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct HEHEBMKBJHI<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T BGICHGONLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool EFOLLNBJFNH;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x353AF30", Offset = "0x353A330", VA = "0x18353AF30")]
	public HEHEBMKBJHI(T KACNOJDGCMN, bool LEAFFJHDKDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class IJPBMPGHMCL<T> : FGPAGJGLDNG<FCJMCFFBJHE<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x33B82F0", Offset = "0x33B76F0", VA = "0x1833B82F0")]
	public IJPBMPGHMCL(FCJMCFFBJHE<T> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x363C190", Offset = "0x363B590", VA = "0x18363C190", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class BENMLIPOPDA<T> : FGPAGJGLDNG<FCJMCFFBJHE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly LLGOMFNBBJO<T> MCPJHKGBCIF;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4497670", Offset = "0x4496A70", VA = "0x184497670")]
	public BENMLIPOPDA(T BGICHGONLEL, FCJMCFFBJHE<T> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x33E3140", Offset = "0x33E2540", VA = "0x1833E3140", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class FNEPCHJEFHH<T> : FGPAGJGLDNG<OCDFFOEGBGN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly HEHEBMKBJHI<T> HJMLADJEIKM;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x33E3200", Offset = "0x33E2600", VA = "0x1833E3200")]
	public FNEPCHJEFHH(T BGICHGONLEL, bool LEAFFJHDKDB, OCDFFOEGBGN<T> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x33E3140", Offset = "0x33E2540", VA = "0x1833E3140", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct NGLMAIFCEPF<TData> where TData : notnull, GJOIGCBHEON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public IEnumerable<TData> MPGKMANNNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool IJGKNNKMEIP;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3C098F0", Offset = "0x3C08CF0", VA = "0x183C098F0")]
	public NGLMAIFCEPF(IEnumerable<TData> JCEMGBIPKOP, bool EHIDHDDLLEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct BCMDABBBAPD<TData> where TData : notnull, GJOIGCBHEON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public List<TData> MPGKMANNNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public List<bool> BBFGMBBFKCF;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x443E260", Offset = "0x443D660", VA = "0x18443E260")]
	public BCMDABBBAPD(List<TData> JCEMGBIPKOP, List<bool> BAALLLOPKNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface GJOIGCBHEON
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool BCNMJFDKGPF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface LEOAOBHGGNA<TData> where TData : GJOIGCBHEON
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PKJOKDNDIPB([In] NGLMAIFCEPF<TData> CGCMNLAJNFI);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PKJOKDNDIPB([In] BCMDABBBAPD<TData> CGCMNLAJNFI);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class IAIGKKDHHKB<TData> : FGPAGJGLDNG<LEOAOBHGGNA<TData>> where TData : notnull, GJOIGCBHEON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly NGLMAIFCEPF<TData> CGCMNLAJNFI;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x36073E0", Offset = "0x36067E0", VA = "0x1836073E0")]
	public IAIGKKDHHKB(List<TData> LJFDPLLMPMD, bool IJGKNNKMEIP, LEOAOBHGGNA<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x33E3140", Offset = "0x33E2540", VA = "0x1833E3140", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class HHCEIEEKCLM<TData> : FGPAGJGLDNG<LEOAOBHGGNA<TData>> where TData : notnull, GJOIGCBHEON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly BCMDABBBAPD<TData> CGCMNLAJNFI;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x35413A0", Offset = "0x35407A0", VA = "0x1835413A0")]
	public HHCEIEEKCLM(List<TData> LJFDPLLMPMD, List<bool> BBFGMBBFKCF, LEOAOBHGGNA<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x33E2C10", Offset = "0x33E2010", VA = "0x1833E2C10", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface FAGDJNKLAJL : GJOIGCBHEON
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface BAEDFPLPBOJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EMOEOBGAMFL> PKJOKDNDIPB(BPCFFBHEOPH<TData> KBIPPOCFHIN);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class DFAMEKJJAFF<TData> : JLEIHCFFECI<BAEDFPLPBOJ<TData>, EMOEOBGAMFL> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct KJMNBKMNPNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<EMOEOBGAMFL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public DFAMEKJJAFF<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<EMOEOBGAMFL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x38F3FC0", Offset = "0x38F33C0", VA = "0x1838F3FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x38F42B0", Offset = "0x38F36B0", VA = "0x1838F42B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly BPCFFBHEOPH<TData> HCEMPPDHNDM;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4C888F0", Offset = "0x4C87CF0", VA = "0x184C888F0")]
	public DFAMEKJJAFF(TData MMGFPGBOBBJ, IReadOnlyList<TData> AIPBPKBNLPA, bool OGDFCLDHMHG, BAEDFPLPBOJ<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4C887F0", Offset = "0x4C87BF0", VA = "0x184C887F0", Slot = "4")]
	[AsyncStateMachine(typeof(DFAMEKJJAFF<>.KJMNBKMNPNI))]
	public override Task<EMOEOBGAMFL> PKJOKDNDIPB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct BPCFFBHEOPH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public TData KLJHIPBMMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public IReadOnlyList<TData> DPLEMHKFONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public bool NNABHNIMCBL;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x42B80E0", Offset = "0x42B74E0", VA = "0x1842B80E0")]
	public BPCFFBHEOPH(TData MMGFPGBOBBJ, IReadOnlyList<TData> AIPBPKBNLPA, bool OGDFCLDHMHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface LJHHINCEBAD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PKJOKDNDIPB([In] BHJGDMMDJKM<TData> DFOJFIGMKGA);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface NLIHEJJGPGC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PKJOKDNDIPB([In] PJGBEIDNBJM<TData> DFOJFIGMKGA);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface PHKMCFIOJMJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GFHIGJCJPEO([In] JICBDNFILAB<TData> DFOJFIGMKGA);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HJDGGLFGKLO();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class ANHEKHALBDA<TData> : FGPAGJGLDNG<LJHHINCEBAD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly BHJGDMMDJKM<TData> DFOJFIGMKGA;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x36FFDA0", Offset = "0x36FF1A0", VA = "0x1836FFDA0")]
	public ANHEKHALBDA(IEnumerable<TData> LJFDPLLMPMD, OLOMHBFPEHM DJDNAMFLFCL, JPEOOMAIDEE JGKNCBCEPPI, float PGLBFGACPEE, bool OGDFCLDHMHG, LJHHINCEBAD<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x33E3140", Offset = "0x33E2540", VA = "0x1833E3140", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class NOANIMMKGEE<TData> : FGPAGJGLDNG<NLIHEJJGPGC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly PJGBEIDNBJM<TData> DFOJFIGMKGA;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3C34F10", Offset = "0x3C34310", VA = "0x183C34F10")]
	public NOANIMMKGEE(TData[] LJFDPLLMPMD, OLOMHBFPEHM[] DJDNAMFLFCL, JPEOOMAIDEE[] JGKNCBCEPPI, float[] PGLBFGACPEE, NLIHEJJGPGC<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x353CE30", Offset = "0x353C230", VA = "0x18353CE30", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class PHBOMHNMLFG<TData> : FGPAGJGLDNG<PHKMCFIOJMJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x33B82F0", Offset = "0x33B76F0", VA = "0x1833B82F0")]
	public PHBOMHNMLFG(PHKMCFIOJMJ<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3DCF2B0", Offset = "0x3DCE6B0", VA = "0x183DCF2B0", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class HEPAKIHDPPB<TData> : FGPAGJGLDNG<PHKMCFIOJMJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly JICBDNFILAB<TData> DFOJFIGMKGA;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x353CEF0", Offset = "0x353C2F0", VA = "0x18353CEF0")]
	public HEPAKIHDPPB(IEnumerable<TData> LJFDPLLMPMD, OLOMHBFPEHM DJDNAMFLFCL, JPEOOMAIDEE JGKNCBCEPPI, float PGLBFGACPEE, PHKMCFIOJMJ<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x353CE30", Offset = "0x353C230", VA = "0x18353CE30", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct BHJGDMMDJKM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public IEnumerable<TData> MPGKMANNNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public OLOMHBFPEHM FEPKEELHEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public JPEOOMAIDEE FLCAGAFJEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public float PGLBFGACPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public bool OGDFCLDHMHG;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x483ECD0", Offset = "0x483E0D0", VA = "0x18483ECD0")]
	public BHJGDMMDJKM(IEnumerable<TData> LJFDPLLMPMD, OLOMHBFPEHM DJDNAMFLFCL, JPEOOMAIDEE JGKNCBCEPPI, float PGLBFGACPEE, bool OGDFCLDHMHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct PJGBEIDNBJM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TData[] MPGKMANNNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public OLOMHBFPEHM[] FEPKEELHEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public JPEOOMAIDEE[] FLCAGAFJEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public float[] PGLBFGACPEE;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3230", Offset = "0x3DE2630", VA = "0x183DE3230")]
	public PJGBEIDNBJM(TData[] LJFDPLLMPMD, OLOMHBFPEHM[] DJDNAMFLFCL, JPEOOMAIDEE[] JGKNCBCEPPI, float[] PGLBFGACPEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct JICBDNFILAB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public IEnumerable<TData> MPGKMANNNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public OLOMHBFPEHM FEPKEELHEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public JPEOOMAIDEE FLCAGAFJEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float PGLBFGACPEE;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x383CC50", Offset = "0x383C050", VA = "0x18383CC50")]
	public JICBDNFILAB(IEnumerable<TData> LJFDPLLMPMD, OLOMHBFPEHM DJDNAMFLFCL, JPEOOMAIDEE JGKNCBCEPPI, float PGLBFGACPEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface IPPGMABNEKE<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PBLPPDOLIOG([In] ELGKAENLBKI<TData> NOIEGIONPHL);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GPOBIDFHFLJ([In] ELGKAENLBKI<TData> NOIEGIONPHL);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PIELINEBKPB([In] bool FDDBOFGLNAD);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JDLMEFDEENA([In] ELGKAENLBKI<TData> NOIEGIONPHL);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EFCAPFLHDKK();

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KHMDENEMPBD([In] TData KAOOCEPNGHF);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class FNMNENKCJKE<TData> : FGPAGJGLDNG<IPPGMABNEKE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly ELGKAENLBKI<TData> NOIEGIONPHL;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x33E3910", Offset = "0x33E2D10", VA = "0x1833E3910")]
	public FNMNENKCJKE(List<TData> PBOJKPKPEEN, IPPGMABNEKE<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x33E3140", Offset = "0x33E2540", VA = "0x1833E3140", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class HBHCGIIGLCP<TData> : FGPAGJGLDNG<IPPGMABNEKE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x33B82F0", Offset = "0x33B76F0", VA = "0x1833B82F0")]
	public HBHCGIIGLCP(IPPGMABNEKE<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3531720", Offset = "0x3530B20", VA = "0x183531720", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class DCDNIKMMKAO<TData> : FGPAGJGLDNG<IPPGMABNEKE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly bool OGDFCLDHMHG;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4C7CA20", Offset = "0x4C7BE20", VA = "0x184C7CA20")]
	public DCDNIKMMKAO(bool OGDFCLDHMHG, IPPGMABNEKE<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4C7C9C0", Offset = "0x4C7BDC0", VA = "0x184C7C9C0", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class FMNKJFEDIJJ<TData> : FGPAGJGLDNG<IPPGMABNEKE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ELGKAENLBKI<TData> NOIEGIONPHL;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x33E2D60", Offset = "0x33E2160", VA = "0x1833E2D60")]
	public FMNKJFEDIJJ(List<TData> PBOJKPKPEEN, bool OGDFCLDHMHG, IPPGMABNEKE<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x33E2C10", Offset = "0x33E2010", VA = "0x1833E2C10", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class KCDMEOEDOIO<TData> : FGPAGJGLDNG<IPPGMABNEKE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly TData KAOOCEPNGHF;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x38AE350", Offset = "0x38AD750", VA = "0x1838AE350")]
	public KCDMEOEDOIO(TData KAOOCEPNGHF, IPPGMABNEKE<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x38AE280", Offset = "0x38AD680", VA = "0x1838AE280", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class BAKIPBHNAGF<TData> : FGPAGJGLDNG<IPPGMABNEKE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly ELGKAENLBKI<TData> NOIEGIONPHL;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x443CC10", Offset = "0x443C010", VA = "0x18443CC10")]
	public BAKIPBHNAGF(List<TData> PBOJKPKPEEN, IPPGMABNEKE<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x443CB40", Offset = "0x443BF40", VA = "0x18443CB40", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct ELGKAENLBKI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public IEnumerable<TData> MPGKMANNNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public bool OGDFCLDHMHG;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3078000", Offset = "0x3077400", VA = "0x183078000")]
	public ELGKAENLBKI(IEnumerable<TData> JCEMGBIPKOP, bool MLACLIJHKPP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface CGNCGIIAKHD
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EMOEOBGAMFL> PKJOKDNDIPB(FFBHBCMNAJJ HCCEKJCAOPG);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class MJNCINOHIID : JLEIHCFFECI<CGNCGIIAKHD, EMOEOBGAMFL>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct OFNDFJDGFEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncTaskMethodBuilder<EMOEOBGAMFL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public MJNCINOHIID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<EMOEOBGAMFL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8EE0", Offset = "0x5CA82E0", VA = "0x185CA8EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9160", Offset = "0x5CA8560", VA = "0x185CA9160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly FFBHBCMNAJJ IDNDLBCEGBA;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5CA8DE0", Offset = "0x5CA81E0", VA = "0x185CA8DE0")]
	public MJNCINOHIID(bool OGDFCLDHMHG, CGNCGIIAKHD CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5CA8CF0", Offset = "0x5CA80F0", VA = "0x185CA8CF0", Slot = "4")]
	[AsyncStateMachine(typeof(OFNDFJDGFEB))]
	public override Task<EMOEOBGAMFL> PKJOKDNDIPB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct FFBHBCMNAJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public bool NNABHNIMCBL;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xB488D0", Offset = "0xB47CD0", VA = "0x180B488D0")]
	public FFBHBCMNAJJ(bool OGDFCLDHMHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface BLCDNAIAPJG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HOHECKHOFIF([In] ANLECDNMBJD<TData> GMADLPGCHDK);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GFHIGJCJPEO([In] LGPMFGBHNNN BHIJMOHBHKD);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GFHIGJCJPEO([In] EBBBCPLDEAG BHIJMOHBHKD);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HJDGGLFGKLO();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class CKBKMHGPADM<TData> : FGPAGJGLDNG<BLCDNAIAPJG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x33B82F0", Offset = "0x33B76F0", VA = "0x1833B82F0")]
	public CKBKMHGPADM(BLCDNAIAPJG<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4AE1F80", Offset = "0x4AE1380", VA = "0x184AE1F80", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class EFKBHBCGCII<TData> : FGPAGJGLDNG<BLCDNAIAPJG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly LGPMFGBHNNN BPFJAHKNALL;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3040A60", Offset = "0x303FE60", VA = "0x183040A60")]
	public EFKBHBCGCII(Vector3 FACGKGECFOF, bool PCDNNKFIHGH, BLCDNAIAPJG<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3040A00", Offset = "0x303FE00", VA = "0x183040A00", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class LIEGJLAPIKA<TData> : FGPAGJGLDNG<BLCDNAIAPJG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly EBBBCPLDEAG BPFJAHKNALL;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x397F610", Offset = "0x397EA10", VA = "0x18397F610")]
	public LIEGJLAPIKA(Guid NHHPLGEPHCD, int APOENOPNHBG, Vector3 LPAPEIIOLFG, Quaternion KBKHJHIFKGI, float NOEHIDPEPEC, bool PCDNNKFIHGH, BLCDNAIAPJG<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x397F5B0", Offset = "0x397E9B0", VA = "0x18397F5B0", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class HDPFHPDCLJF<TData> : FGPAGJGLDNG<BLCDNAIAPJG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly ANLECDNMBJD<TData> BPFJAHKNALL;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x353AE00", Offset = "0x353A200", VA = "0x18353AE00")]
	public HDPFHPDCLJF(TData BGICHGONLEL, bool OGDFCLDHMHG, BLCDNAIAPJG<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x33E3140", Offset = "0x33E2540", VA = "0x1833E3140", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct LGPMFGBHNNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Vector3 FACGKGECFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly bool PCDNNKFIHGH;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5CA8CD0", Offset = "0x5CA80D0", VA = "0x185CA8CD0")]
	public LGPMFGBHNNN(Vector3 FACGKGECFOF, bool PCDNNKFIHGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct EBBBCPLDEAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly Guid NHHPLGEPHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int APOENOPNHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly Vector3 LPAPEIIOLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly Quaternion KBKHJHIFKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly float NOEHIDPEPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly bool PCDNNKFIHGH;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5CA8690", Offset = "0x5CA7A90", VA = "0x185CA8690")]
	public EBBBCPLDEAG(Guid NHHPLGEPHCD, int APOENOPNHBG, Vector3 LPAPEIIOLFG, Quaternion KBKHJHIFKGI, float NOEHIDPEPEC, bool PCDNNKFIHGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct ANLECDNMBJD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly TData BGICHGONLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool OGDFCLDHMHG;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x36FFE80", Offset = "0x36FF280", VA = "0x1836FFE80")]
	public ANLECDNMBJD(TData BGICHGONLEL, bool OGDFCLDHMHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface DLAJMHNFNNO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PKJOKDNDIPB([In] PHJKFDLLMHE<TData> HLIAIMFCBAP);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PKJOKDNDIPB([In] NKBHBDPOJLA<TData> HLIAIMFCBAP);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface CEGIFGJJJOE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HOHECKHOFIF([In] HOJENOBKOBH<TData> KHLFIADOHBK);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GFHIGJCJPEO([In] BLAOLMNAHLE BHIJMOHBHKD);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HJDGGLFGKLO();
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class DCKKAGGPPGM<TData> : FGPAGJGLDNG<DLAJMHNFNNO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly PHJKFDLLMHE<TData> HLIAIMFCBAP;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4C7D130", Offset = "0x4C7C530", VA = "0x184C7D130")]
	public DCKKAGGPPGM(IEnumerable<TData> LJFDPLLMPMD, Vector3 AGMILILGDBK, bool OGDFCLDHMHG, DLAJMHNFNNO<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x33E3140", Offset = "0x33E2540", VA = "0x1833E3140", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class FGLDJIPEAAI<TData> : FGPAGJGLDNG<CEGIFGJJJOE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x33B82F0", Offset = "0x33B76F0", VA = "0x1833B82F0")]
	public FGLDJIPEAAI(CEGIFGJJJOE<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x33CEC40", Offset = "0x33CE040", VA = "0x1833CEC40", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class MMBNMMHOFBC<TData> : FGPAGJGLDNG<CEGIFGJJJOE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly HOJENOBKOBH<TData> HLIAIMFCBAP;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8260", Offset = "0x3BB7660", VA = "0x183BB8260")]
	public MMBNMMHOFBC(IEnumerable<TData> LJFDPLLMPMD, bool OGDFCLDHMHG, CEGIFGJJJOE<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x33E3140", Offset = "0x33E2540", VA = "0x1833E3140", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class EACDNJAJKMP<TData> : FGPAGJGLDNG<DLAJMHNFNNO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly NKBHBDPOJLA<TData> HLIAIMFCBAP;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x302A4D0", Offset = "0x30298D0", VA = "0x18302A4D0")]
	public EACDNJAJKMP(IEnumerable<TData> LJFDPLLMPMD, Vector3 AICBJBICDPC, KPJOKPGMLPP BMOGLMANPKL, bool OGDFCLDHMHG, DLAJMHNFNNO<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x302A400", Offset = "0x3029800", VA = "0x18302A400", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class KPJBLHOBIAN<TData> : FGPAGJGLDNG<CEGIFGJJJOE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly BLAOLMNAHLE HLIAIMFCBAP;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x39079E0", Offset = "0x3906DE0", VA = "0x1839079E0")]
	public KPJBLHOBIAN(Vector3 AGMILILGDBK, CEGIFGJJJOE<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3040A00", Offset = "0x303FE00", VA = "0x183040A00", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct PHJKFDLLMHE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public readonly IEnumerable<TData> LJFDPLLMPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly Vector3 AGMILILGDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public readonly bool OGDFCLDHMHG;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3DCF7F0", Offset = "0x3DCEBF0", VA = "0x183DCF7F0")]
	public PHJKFDLLMHE(IEnumerable<TData> LJFDPLLMPMD, Vector3 AGMILILGDBK, bool OGDFCLDHMHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct HOJENOBKOBH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly IEnumerable<TData> LJFDPLLMPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly bool OGDFCLDHMHG;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3570330", Offset = "0x356F730", VA = "0x183570330")]
	public HOJENOBKOBH(IEnumerable<TData> LJFDPLLMPMD, bool OGDFCLDHMHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct NKBHBDPOJLA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly IEnumerable<TData> LJFDPLLMPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Vector3 AICBJBICDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly KPJOKPGMLPP BMOGLMANPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly bool OGDFCLDHMHG;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3C10C10", Offset = "0x3C10010", VA = "0x183C10C10")]
	public NKBHBDPOJLA(IEnumerable<TData> LJFDPLLMPMD, Vector3 AICBJBICDPC, KPJOKPGMLPP BMOGLMANPKL, bool OGDFCLDHMHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct BLAOLMNAHLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly Vector3 AGMILILGDBK;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x1F35440", Offset = "0x1F34840", VA = "0x181F35440")]
	public BLAOLMNAHLE(Vector3 AGMILILGDBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public enum KPJOKPGMLPP
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface NNLKCBOHJPC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PKJOKDNDIPB([In] KPHFDKEAMOJ<TData> PEMKHIOLDNN);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PKJOKDNDIPB([In] HHHPJOPCIEK<TData> PEMKHIOLDNN);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface CLGIPAFNEIN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HOHECKHOFIF([In] PPDHLLHGKBE<TData> GMADLPGCHDK);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GFHIGJCJPEO([In] GEOLIDAIJKD BHIJMOHBHKD);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HJDGGLFGKLO();
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class MPFFAKGEJPO<TData> : FGPAGJGLDNG<NNLKCBOHJPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly KPHFDKEAMOJ<TData> PEMKHIOLDNN;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3BC1E10", Offset = "0x3BC1210", VA = "0x183BC1E10")]
	public MPFFAKGEJPO(IEnumerable<TData> LJFDPLLMPMD, Quaternion AGMILILGDBK, Vector3? MGBELOPAJCC, bool BDFMKKBPNAG, bool OGDFCLDHMHG, NNLKCBOHJPC<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x33E3140", Offset = "0x33E2540", VA = "0x1833E3140", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class HEJPAPDCLAE<TData> : FGPAGJGLDNG<CLGIPAFNEIN<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x33B82F0", Offset = "0x33B76F0", VA = "0x1833B82F0")]
	public HEJPAPDCLAE(CLGIPAFNEIN<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x33CEC40", Offset = "0x33CE040", VA = "0x1833CEC40", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class BONCDFAJHHE<TData> : FGPAGJGLDNG<CLGIPAFNEIN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly PPDHLLHGKBE<TData> PEMKHIOLDNN;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4851780", Offset = "0x4850B80", VA = "0x184851780")]
	public BONCDFAJHHE(IEnumerable<TData> LJFDPLLMPMD, bool OGDFCLDHMHG, CLGIPAFNEIN<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x33E3140", Offset = "0x33E2540", VA = "0x1833E3140", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class ABLJNLAMNAJ<TData> : FGPAGJGLDNG<NNLKCBOHJPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly HHHPJOPCIEK<TData> PEMKHIOLDNN;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3451C70", Offset = "0x3451070", VA = "0x183451C70")]
	public ABLJNLAMNAJ(IEnumerable<TData> LJFDPLLMPMD, Quaternion BGJKOOHNEFG, KPJOKPGMLPP FMEHAPKLPOL, Vector3? MGBELOPAJCC, bool BDFMKKBPNAG, bool OGDFCLDHMHG, NNLKCBOHJPC<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x302A400", Offset = "0x3029800", VA = "0x18302A400", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class AIIMCMGIONL<TData> : FGPAGJGLDNG<CLGIPAFNEIN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly GEOLIDAIJKD PEMKHIOLDNN;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x34A8C60", Offset = "0x34A8060", VA = "0x1834A8C60")]
	public AIIMCMGIONL(Quaternion AGMILILGDBK, Vector3? MGBELOPAJCC, bool BDFMKKBPNAG, CLGIPAFNEIN<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3040A00", Offset = "0x303FE00", VA = "0x183040A00", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct KPHFDKEAMOJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly IEnumerable<TData> LJFDPLLMPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly Quaternion AGMILILGDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly Vector3? MGBELOPAJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool BDFMKKBPNAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly bool OGDFCLDHMHG;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x39078C0", Offset = "0x3906CC0", VA = "0x1839078C0")]
	public KPHFDKEAMOJ(IEnumerable<TData> LJFDPLLMPMD, Quaternion AGMILILGDBK, Vector3? MGBELOPAJCC, bool BDFMKKBPNAG, bool OGDFCLDHMHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct PPDHLLHGKBE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly IEnumerable<TData> LJFDPLLMPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly bool OGDFCLDHMHG;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3E11500", Offset = "0x3E10900", VA = "0x183E11500")]
	public PPDHLLHGKBE(IEnumerable<TData> LJFDPLLMPMD, bool OGDFCLDHMHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct HHHPJOPCIEK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly IEnumerable<TData> LJFDPLLMPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Quaternion BGJKOOHNEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly KPJOKPGMLPP FMEHAPKLPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly Vector3? MGBELOPAJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly bool BDFMKKBPNAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool OGDFCLDHMHG;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3541430", Offset = "0x3540830", VA = "0x183541430")]
	public HHHPJOPCIEK(IEnumerable<TData> LJFDPLLMPMD, Quaternion BGJKOOHNEFG, KPJOKPGMLPP FMEHAPKLPOL, Vector3? MGBELOPAJCC, bool BDFMKKBPNAG, bool OGDFCLDHMHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct GEOLIDAIJKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly Quaternion AGMILILGDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Vector3? MGBELOPAJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly bool BDFMKKBPNAG;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x42A5140", Offset = "0x42A4540", VA = "0x1842A5140")]
	public GEOLIDAIJKD(Quaternion AGMILILGDBK, Vector3? MGBELOPAJCC, bool BDFMKKBPNAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public interface PIGDMMINAPE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HOHECKHOFIF([In] BLGPFGPLHJD<TData> GMADLPGCHDK);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GFHIGJCJPEO([In] PGLJFOINHLA BHIJMOHBHKD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GFHIGJCJPEO([In] MPENMLAAFJI BHIJMOHBHKD);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GFHIGJCJPEO([In] CCIGHBCDGJC BHIJMOHBHKD);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HJDGGLFGKLO();
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class NHPDDNDFILO<TData> : FGPAGJGLDNG<PIGDMMINAPE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CCIGHBCDGJC FLONHEFJCPN;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3C0F260", Offset = "0x3C0E660", VA = "0x183C0F260")]
	public NHPDDNDFILO(Vector3 OEBDIJAEPDO, float MGOPPJOJBHN, Vector3 MGBELOPAJCC, bool LFICPBDBAMB, PIGDMMINAPE<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3C0F200", Offset = "0x3C0E600", VA = "0x183C0F200", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class HBADPMLKJPL<TData> : FGPAGJGLDNG<PIGDMMINAPE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x33B82F0", Offset = "0x33B76F0", VA = "0x1833B82F0")]
	public HBADPMLKJPL(PIGDMMINAPE<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x35316B0", Offset = "0x3530AB0", VA = "0x1835316B0", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class CNDJMIJKHKE<TData> : FGPAGJGLDNG<PIGDMMINAPE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly BLGPFGPLHJD<TData> FLONHEFJCPN;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4AE9BF0", Offset = "0x4AE8FF0", VA = "0x184AE9BF0")]
	public CNDJMIJKHKE(IEnumerable<TData> LJFDPLLMPMD, bool OGDFCLDHMHG, PIGDMMINAPE<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x33E3140", Offset = "0x33E2540", VA = "0x1833E3140", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class FFENFOLPOLD<TData> : FGPAGJGLDNG<PIGDMMINAPE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MPENMLAAFJI FLONHEFJCPN;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x33CE740", Offset = "0x33CDB40", VA = "0x1833CE740")]
	public FFENFOLPOLD(float FEKKMEDJBOM, bool BPAPNEBKNGA, Vector3 MGBELOPAJCC, PIGDMMINAPE<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x33CE670", Offset = "0x33CDA70", VA = "0x1833CE670", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class NHCLAHOKEDC<TData> : FGPAGJGLDNG<PIGDMMINAPE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly PGLJFOINHLA FLONHEFJCPN;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3C0EBD0", Offset = "0x3C0DFD0", VA = "0x183C0EBD0")]
	public NHCLAHOKEDC(float MGOPPJOJBHN, Vector3 MGBELOPAJCC, PIGDMMINAPE<TData> CEICCLOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3040A00", Offset = "0x303FE00", VA = "0x183040A00", Slot = "4")]
	public override bool PKJOKDNDIPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct CCIGHBCDGJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly Vector3 OEBDIJAEPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly float MGOPPJOJBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Vector3 MGBELOPAJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly bool PCDNNKFIHGH;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5CA8660", Offset = "0x5CA7A60", VA = "0x185CA8660")]
	public CCIGHBCDGJC(Vector3 OEBDIJAEPDO, float MGOPPJOJBHN, Vector3 MGBELOPAJCC, bool PCDNNKFIHGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct BLGPFGPLHJD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly IEnumerable<TData> LJFDPLLMPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool OGDFCLDHMHG;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x484E320", Offset = "0x484D720", VA = "0x18484E320")]
	public BLGPFGPLHJD(IEnumerable<TData> LJFDPLLMPMD, bool OGDFCLDHMHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct MPENMLAAFJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly float FEKKMEDJBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool BPAPNEBKNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly Vector3 MGBELOPAJCC;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5CA8E40", Offset = "0x5CA8240", VA = "0x185CA8E40")]
	public MPENMLAAFJI(float FEKKMEDJBOM, bool BPAPNEBKNGA, Vector3 MGBELOPAJCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct PGLJFOINHLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly float MGOPPJOJBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly Vector3 MGBELOPAJCC;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x427AEA0", Offset = "0x427A2A0", VA = "0x18427AEA0")]
	public PGLJFOINHLA(float MGOPPJOJBHN, Vector3 MGBELOPAJCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class ENCMBEGONJN
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private struct NCBKCLIKOGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public bool GPJHFLDAIFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public HLDKHDLHDPB JEIGPGJOHIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public HLDKHDLHDPB PGLKAPFOOMC;
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static NCBKCLIKOGD ONBMDHBFCMA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static CancellationToken GJALGAPOOGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8830", Offset = "0x5CA7C30", VA = "0x185CA8830")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	internal static HLDKHDLHDPB JEIGPGJOHIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8790", Offset = "0x5CA7B90", VA = "0x185CA8790")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8720", Offset = "0x5CA7B20", VA = "0x185CA8720")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5CA8850", Offset = "0x5CA7C50", VA = "0x185CA8850")]
	[JMHDKPKEECF(POEFLILDONI.Room, OPIGPDFNEON.None)]
	private static void OABADPCGFBE(HLDKHDLHDPB FGHIJOKCDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5CA8950", Offset = "0x5CA7D50", VA = "0x185CA8950")]
	public static void OAFECOOGBFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5CA86D0", Offset = "0x5CA7AD0", VA = "0x185CA86D0")]
	private static HLDKHDLHDPB AJAACPDOBFL(HLDKHDLHDPB MDGHJCLHJJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public static class AKEGELPNLIO
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public enum CBEEDLFBIMF
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x29D5640", Offset = "0x29D4A40", VA = "0x1829D5640")]
	public static void NLGDLGCCMCI<T>(T LDFPHDMIKMC, CBEEDLFBIMF IJFAMCPOKBO) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x29D55E0", Offset = "0x29D49E0", VA = "0x1829D55E0")]
	public static void NLGDLGCCMCI<T>(T LDFPHDMIKMC) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x29D5570", Offset = "0x29D4970", VA = "0x1829D5570")]
	public static void DKDAMJNGMMO<T>(T LDFPHDMIKMC) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x29D5780", Offset = "0x29D4B80", VA = "0x1829D5780")]
	public static T OPODPAEFLEB<T>(CBEEDLFBIMF IJFAMCPOKBO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x29D5490", Offset = "0x29D4890", VA = "0x1829D5490")]
	public static bool BGHKBNLIKGB<T>(CBEEDLFBIMF IJFAMCPOKBO) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x29D5530", Offset = "0x29D4930", VA = "0x1829D5530")]
	public static T OPODPAEFLEB<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x29D5530", Offset = "0x29D4930", VA = "0x1829D5530")]
	public static bool BGHKBNLIKGB<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal static class FFFPPCCECPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5CA8AA0", Offset = "0x5CA7EA0", VA = "0x185CA8AA0")]
	public static void GDEHEBMBCAC(IEnumerable FMCDBPKGLAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x236C8F0", Offset = "0x236BCF0", VA = "0x18236C8F0")]
	public static void GDEHEBMBCAC<T>(T[] FFAHMFOPGLA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x236CAD0", Offset = "0x236BED0", VA = "0x18236CAD0")]
	public static void GDEHEBMBCAC<T>(T EMGLDFIGDIG) where T : notnull, Enum
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

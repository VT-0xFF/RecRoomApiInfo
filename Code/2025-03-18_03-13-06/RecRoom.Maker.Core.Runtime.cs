using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7651280", Offset = "0x7650480", VA = "0x187651280")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98C8C0", VA = "0x18098D6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x98D700", Offset = "0x98C900", VA = "0x18098D700")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Maker_Core_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7651400", Offset = "0x7650600", VA = "0x187651400", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2493E30", Offset = "0x2493030", VA = "0x182493E30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface KOFMNHHNEBM<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn OHJJBKFEDBF(TData ONELFPFEALD);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BBOINJPGCFH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(KMIBGMMJDOC AOENBKCOJAP);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData CGKPJBPKLPJ, Collider KNPGPPHPGKO, KMIBGMMJDOC AOENBKCOJAP, [Optional] GIHAKHDNNJF? IJOKOCEACGE);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData CGKPJBPKLPJ);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider KNPGPPHPGKO);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KIIDLHEGIEN<TData> : NHCNKMEMFFG, GAJIAKACFEL<TData>, IPLIELKLLFI<TData>, HDJNNFGPAMA<TData>, NGJPCPANOGD, BCNPICCMBME<TData>, CNOPPFNPGDN, HOGGKEOGKHP
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BCNPICCMBME<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 MEPDDJJJJDK, Vector3 FOKNLDGGKBN, float DLABDKKOOMK, [Out] T KOBHJKKKIAL, [Out] Vector3 NGJNALGNNBE, [Out] Collider KNPGPPHPGKO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 MEPDDJJJJDK, Vector3 FOKNLDGGKBN, float GEHDBHACDKA, float DLABDKKOOMK, T[] HKIBFLJOCLB, [Out] Vector3 KDIEKCJMPBH, [Out] Collider CDJFGGLGKKF);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 MEPDDJJJJDK, float GEHDBHACDKA, Vector3 ECONMOCLDAE, T[] HKIBFLJOCLB);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider BBPNMCBBJLE, [Out] T PBLBLABDHML);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NHCNKMEMFFG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds HFJLALFLDNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform IBNABLCOKDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds GONFMEPJIDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform KJALHPFELKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 ILIDBMDNGJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool JOJFAAOOGKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void UpdateLocalSelectionBounds();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetSelectionBoundsDirty(bool DBDBAFDMOEI = true, int CLFCKJCPMPI = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool OCIOMEJOPBE, object GIIKHLJPAKH);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HOGGKEOGKHP
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	MIOEGIOIKAG MFAFKGMHLFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HBFDIGJMELA
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool KPDKDBLGGMD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool HCNLIJCFPJO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool KJELLDLCHKA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Dictionary<Guid, Guid> TryGetPreviousCloneMapping();

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> FDJEGBNEOOK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HDJNNFGPAMA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool FJALDHAOHIK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int NPLMIJFPDBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> CIPOINOKNKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData LOKFKJLCEOD);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData LOKFKJLCEOD);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GAJIAKACFEL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T ONELFPFEALD, [Optional] GIHAKHDNNJF? JPGPAIHLKCE, bool CCCOIAFDOJG = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int IPBKHOJKHLJ, IEnumerable<T> LLHKKFGDNEM, bool CCCOIAFDOJG = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int IPBKHOJKHLJ, IEnumerable<T> LLHKKFGDNEM, GIHAKHDNNJF JPGPAIHLKCE, bool CCCOIAFDOJG = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CNOPPFNPGDN
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NGJPCPANOGD
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool KONOOKJGANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool FHMGOFCGHEA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool JFIGCJCAIPO
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool KJBMPPBJJHC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class HNGNNIFOBCI<TReceiver> : BJLMMMMIOBJ<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x40D97D0", Offset = "0x40D89D0", VA = "0x1840D97D0")]
	public HNGNNIFOBCI(TReceiver JEHDAPIHAPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class KDOEOKALEPN<TReceiver, TFromTask> : BJLMMMMIOBJ<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x40D97D0", Offset = "0x40D89D0", VA = "0x1840D97D0")]
	public KDOEOKALEPN(TReceiver JEHDAPIHAPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class BJLMMMMIOBJ<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver JEHDAPIHAPN;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x58C2110", Offset = "0x58C1310", VA = "0x1858C2110")]
	public BJLMMMMIOBJ(TReceiver JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute HEELOGLJLHD();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class DLCCIJKGOEE<TReceiver, TResult> : BJLMMMMIOBJ<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x40D97D0", Offset = "0x40D89D0", VA = "0x1840D97D0")]
	public DLCCIJKGOEE(TReceiver JEHDAPIHAPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct BCAKDGONKMP<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup PIMFJBAPADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData FAEKCJADNEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> BFKELHFGHHJ;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x24A49C0", Offset = "0x24A3BC0", VA = "0x1824A49C0")]
	public BCAKDGONKMP(TGroup OKCDADCFHCF, TData BFPMBEJELJP, IEnumerable<TData> HBCLGBNGIPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct NMCANFHIIAM<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup PIMFJBAPADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> BFKELHFGHHJ;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x9E2EE0", Offset = "0x9E20E0", VA = "0x1809E2EE0")]
	public NMCANFHIIAM(TGroup OKCDADCFHCF, IEnumerable<TData> HBCLGBNGIPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct PLFHACIKHHE<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup PIMFJBAPADA;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xC1A5C0", Offset = "0xC197C0", VA = "0x180C1A5C0")]
	public PLFHACIKHHE(TGroup OKCDADCFHCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct MCBCEEDLBJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<Guid> BFKELHFGHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public Guid BHJAIEGLLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly bool GBBHNMKNLPK;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x76507C0", Offset = "0x764F9C0", VA = "0x1876507C0")]
	public MCBCEEDLBJG(IEnumerable<Guid> HBCLGBNGIPE, Guid BDOJBJJNKAE, bool OGHMCNOPNDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct GKNCPHPPFOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public Guid BHJAIEGLLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool GBBHNMKNLPK;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x23753D0", Offset = "0x23745D0", VA = "0x1823753D0")]
	public GKNCPHPPFOB(Guid BDOJBJJNKAE, bool OGHMCNOPNDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface JAGJNFPIDPA<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NNLCAMNPEJB JGGJJMIECJN(BCAKDGONKMP<TGroup, TData> NMNHNOIFJDB);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NNLCAMNPEJB LBMGJFEFPFH(BCAKDGONKMP<TGroup, TData> NMNHNOIFJDB);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NNLCAMNPEJB OBFDIKHJHBI(NMCANFHIIAM<TGroup, TData> NMNHNOIFJDB);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NNLCAMNPEJB OODKAGNCGIC(PLFHACIKHHE<TGroup> NMNHNOIFJDB);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface PBHLJCEMLPM
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NNLCAMNPEJB> JGGJJMIECJN(MCBCEEDLBJG NMNHNOIFJDB);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<NNLCAMNPEJB> LBMGJFEFPFH(GKNCPHPPFOB NMNHNOIFJDB);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BJDGDNEEBJJ<TGroup, TData> : DLCCIJKGOEE<JAGJNFPIDPA<TGroup, TData>, NNLCAMNPEJB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly NMCANFHIIAM<TGroup, TData> NMNHNOIFJDB;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x58BDA20", Offset = "0x58BCC20", VA = "0x1858BDA20")]
	public BJDGDNEEBJJ(TGroup OKCDADCFHCF, IEnumerable<TData> HBCLGBNGIPE, JAGJNFPIDPA<TGroup, TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x58BD950", Offset = "0x58BCB50", VA = "0x1858BD950", Slot = "4")]
	public override NNLCAMNPEJB HEELOGLJLHD()
	{
		return default(NNLCAMNPEJB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class MDGDJHAFDMB<TGroup, TData> : DLCCIJKGOEE<JAGJNFPIDPA<TGroup, TData>, NNLCAMNPEJB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly BCAKDGONKMP<TGroup, TData> NMNHNOIFJDB;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4D94670", Offset = "0x4D93870", VA = "0x184D94670")]
	public MDGDJHAFDMB(TGroup OKCDADCFHCF, TData LHHOHLKECAO, IEnumerable<TData> HBCLGBNGIPE, JAGJNFPIDPA<TGroup, TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4D945A0", Offset = "0x4D937A0", VA = "0x184D945A0", Slot = "4")]
	public override NNLCAMNPEJB HEELOGLJLHD()
	{
		return default(NNLCAMNPEJB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JJKCHIBCIJN<TGroup, TData> : DLCCIJKGOEE<JAGJNFPIDPA<TGroup, TData>, NNLCAMNPEJB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly PLFHACIKHHE<TGroup> NMNHNOIFJDB;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x46ADB60", Offset = "0x46ACD60", VA = "0x1846ADB60")]
	public JJKCHIBCIJN(TGroup OKCDADCFHCF, JAGJNFPIDPA<TGroup, TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x498AE90", Offset = "0x498A090", VA = "0x18498AE90", Slot = "4")]
	public override NNLCAMNPEJB HEELOGLJLHD()
	{
		return default(NNLCAMNPEJB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class MMPBJNIIGGL<TGroup, TData> : DLCCIJKGOEE<JAGJNFPIDPA<TGroup, TData>, NNLCAMNPEJB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly BCAKDGONKMP<TGroup, TData> NMNHNOIFJDB;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4D94670", Offset = "0x4D93870", VA = "0x184D94670")]
	public MMPBJNIIGGL(TGroup OKCDADCFHCF, TData BFPMBEJELJP, IEnumerable<TData> HBCLGBNGIPE, JAGJNFPIDPA<TGroup, TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4DB2740", Offset = "0x4DB1940", VA = "0x184DB2740", Slot = "4")]
	public override NNLCAMNPEJB HEELOGLJLHD()
	{
		return default(NNLCAMNPEJB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BEBAMGANGIO : KDOEOKALEPN<PBHLJCEMLPM, NNLCAMNPEJB>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct DHIMCMEEIAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<NNLCAMNPEJB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public BEBAMGANGIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<NNLCAMNPEJB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x764FB80", Offset = "0x764ED80", VA = "0x18764FB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x764FE10", Offset = "0x764F010", VA = "0x18764FE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private MCBCEEDLBJG NMNHNOIFJDB;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x764F660", Offset = "0x764E860", VA = "0x18764F660")]
	public BEBAMGANGIO(IEnumerable<Guid> LOAEPPDFOKH, Guid BDOJBJJNKAE, bool OGHMCNOPNDP, PBHLJCEMLPM JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x764F570", Offset = "0x764E770", VA = "0x18764F570", Slot = "4")]
	[AsyncStateMachine(typeof(DHIMCMEEIAP))]
	public override Task<NNLCAMNPEJB> HEELOGLJLHD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class NHGCNCOOHDF : KDOEOKALEPN<PBHLJCEMLPM, NNLCAMNPEJB>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct NJJCMGFIEPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<NNLCAMNPEJB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public NHGCNCOOHDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<NNLCAMNPEJB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7650F70", Offset = "0x7650170", VA = "0x187650F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7651210", Offset = "0x7650410", VA = "0x187651210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly GKNCPHPPFOB NMNHNOIFJDB;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7650EF0", Offset = "0x76500F0", VA = "0x187650EF0")]
	public NHGCNCOOHDF(Guid BDOJBJJNKAE, bool OGHMCNOPNDP, PBHLJCEMLPM JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7650E00", Offset = "0x7650000", VA = "0x187650E00", Slot = "4")]
	[AsyncStateMachine(typeof(NJJCMGFIEPJ))]
	public override Task<NNLCAMNPEJB> HEELOGLJLHD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct ANJFFEDJLPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly LKDKDHHHMEB AEJCDMNPEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly bool GBBHNMKNLPK;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x764F550", Offset = "0x764E750", VA = "0x18764F550")]
	public ANJFFEDJLPI(LKDKDHHHMEB CAEGIJFPPOK, bool OGHMCNOPNDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface KDMNMBGDFAI<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> HEELOGLJLHD(ANJFFEDJLPI CEBGKFGONGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class MLJBMFBCKJH<TSpawnType> : KDOEOKALEPN<KDMNMBGDFAI<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct DEMLNCFMJPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public MLJBMFBCKJH<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6388D40", Offset = "0x6387F40", VA = "0x186388D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4123A90", Offset = "0x4122C90", VA = "0x184123A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly ANJFFEDJLPI CEBGKFGONGJ;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4DB10B0", Offset = "0x4DB02B0", VA = "0x184DB10B0")]
	public MLJBMFBCKJH(LKDKDHHHMEB CAEGIJFPPOK, bool OGHMCNOPNDP, KDMNMBGDFAI<TSpawnType> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4DB0EB0", Offset = "0x4DB00B0", VA = "0x184DB0EB0", Slot = "4")]
	[AsyncStateMachine(typeof(MLJBMFBCKJH<>.DEMLNCFMJPP))]
	public override Task<TSpawnType> HEELOGLJLHD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct LKDKDHHHMEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly bool CPCNJIJJHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Vector3 LAKEGDKHNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly Vector3 LAHGFMKGHMK;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x76506A0", Offset = "0x764F8A0", VA = "0x1876506A0")]
	public LKDKDHHHMEB(Transform GHHAHDIBHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7650790", Offset = "0x764F990", VA = "0x187650790")]
	public LKDKDHHHMEB(Vector3 HFFGEMAKAAC, Vector3 LBPAIJGCICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7650670", Offset = "0x764F870", VA = "0x187650670")]
	public static LKDKDHHHMEB KFABHKFANJO()
	{
		return default(LKDKDHHHMEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7650710", Offset = "0x764F910", VA = "0x187650710")]
	private LKDKDHHHMEB(bool IKLEHKGHAAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct CDONBKHDPIC<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public TNode KNAHHPLLOCI;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x59FA3D0", Offset = "0x59F95D0", VA = "0x1859FA3D0")]
	public CDONBKHDPIC(TNode KNAHHPLLOCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct LCDDKFBKOCI<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public TNode KPNGEBKPODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public TReparentOperations JNNNPLLPIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public FFFHAHCCDIK BKDAALJHOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly bool GBBHNMKNLPK;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4B2DA90", Offset = "0x4B2CC90", VA = "0x184B2DA90")]
	public LCDDKFBKOCI(TNode KPNGEBKPODN, TReparentOperations JNNNPLLPIEO, FFFHAHCCDIK BKDAALJHOEC, bool OGHMCNOPNDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface HFNDILGKMDB<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLHHBJNLNKD([In] CDONBKHDPIC<TNode> OPGDENEPCGL);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BCCHMOLNMIE([In] LCDDKFBKOCI<TNode, TReparentOperations> AIHCIFOHFPB);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OHLDFMJPBGO();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class HNKBCAMCIEA<TNode, TReparentOperations> : HNGNNIFOBCI<HFNDILGKMDB<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x40D97D0", Offset = "0x40D89D0", VA = "0x1840D97D0")]
	public HNKBCAMCIEA(HFNDILGKMDB<TNode, TReparentOperations> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x46BD7C0", Offset = "0x46BC9C0", VA = "0x1846BD7C0", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class KNNDIJPAGCG<TNode, TReparentOperations> : HNGNNIFOBCI<HFNDILGKMDB<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly LCDDKFBKOCI<TNode, TReparentOperations> AIHCIFOHFPB;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4AA20C0", Offset = "0x4AA12C0", VA = "0x184AA20C0")]
	public KNNDIJPAGCG(TNode KPNGEBKPODN, TReparentOperations JNNNPLLPIEO, FFFHAHCCDIK BKDAALJHOEC, HFNDILGKMDB<TNode, TReparentOperations> JEHDAPIHAPN, bool OGHMCNOPNDP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4AA2000", Offset = "0x4AA1200", VA = "0x184AA2000", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class NAOGAEGPJOB<TNode, TReparentOperations> : HNGNNIFOBCI<HFNDILGKMDB<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly CDONBKHDPIC<TNode> OPGDENEPCGL;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4E17E90", Offset = "0x4E17090", VA = "0x184E17E90")]
	public NAOGAEGPJOB(TNode MDMOLGLNAKJ, HFNDILGKMDB<TNode, TReparentOperations> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x40D5200", Offset = "0x40D4400", VA = "0x1840D5200", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct EENPPFFBGFC<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TSpawnInfo HJMBKAPCFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Vector3 LBPAIJGCICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Quaternion GLMEOLPKLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float DIOKPOCPBHH;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x40E0910", Offset = "0x40DFB10", VA = "0x1840E0910")]
	public EENPPFFBGFC(TSpawnInfo HJMBKAPCFFI, Vector3 LBPAIJGCICL, Quaternion GLMEOLPKLCA, float DIOKPOCPBHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface IKODGLJMOJC<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> BOKOLJFIEFO([In] EENPPFFBGFC<TSpawnInfo> OOJAJAHKCFJ, CancellationToken KPIINMODKFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class BIAKCBDKAPG<TSpawnType, TSpawnInfo> : KDOEOKALEPN<IKODGLJMOJC<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly EENPPFFBGFC<TSpawnInfo> MEDGLPBHGFL;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x58B2CF0", Offset = "0x58B1EF0", VA = "0x1858B2CF0")]
	public BIAKCBDKAPG(TSpawnInfo JMGMNPBDMNN, Vector3 LBPAIJGCICL, Quaternion GLMEOLPKLCA, float DIOKPOCPBHH, IKODGLJMOJC<TSpawnType, TSpawnInfo> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x58B2C10", Offset = "0x58B1E10", VA = "0x1858B2C10", Slot = "4")]
	public override Task<TSpawnType> HEELOGLJLHD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct ACDEOJLHCNA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly IEnumerable<TData> BFKELHFGHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool GBBHNMKNLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly bool NCIKJODFKLL;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x464CC20", Offset = "0x464BE20", VA = "0x18464CC20")]
	public ACDEOJLHCNA(IEnumerable<TData> HBCLGBNGIPE, bool OGHMCNOPNDP = false, bool PNCPFJKPCKP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface KEHFMACNDJB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NNLCAMNPEJB> GCFEKOIAKBH([In] ACDEOJLHCNA<TData> DNPHOKJJAEF, CancellationToken KPIINMODKFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class DANAFGBGECG<TData> : KDOEOKALEPN<KEHFMACNDJB<TData>, NNLCAMNPEJB> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly ACDEOJLHCNA<TData> ELBNEMLKDJL;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6372A80", Offset = "0x6371C80", VA = "0x186372A80")]
	public DANAFGBGECG(IEnumerable<TData> HBCLGBNGIPE, bool OGHMCNOPNDP, KEHFMACNDJB<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x58B2C10", Offset = "0x58B1E10", VA = "0x1858B2C10", Slot = "4")]
	public override Task<NNLCAMNPEJB> HEELOGLJLHD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct FADLIKFAAAO<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T CGKPJBPKLPJ;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x44A5740", Offset = "0x44A4940", VA = "0x1844A5740")]
	public FADLIKFAAAO(T DFMLGOMCBLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface JLOLIGIEBFJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLHHBJNLNKD([In] FADLIKFAAAO<T> GFDPONJDIJI);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BCCHMOLNMIE();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface OBEEJEGCEPI<T>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HEELOGLJLHD([In] IJIABFDKKGF<T> BDLMJLIDGAA);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct IJIABFDKKGF<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T CGKPJBPKLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly bool DMHCKAEOCHK;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x477B3A0", Offset = "0x477A5A0", VA = "0x18477B3A0")]
	public IJIABFDKKGF(T DFMLGOMCBLE, bool KEDPEKBDLOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class PFBKELDFJEL<T> : HNGNNIFOBCI<JLOLIGIEBFJ<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x40D97D0", Offset = "0x40D89D0", VA = "0x1840D97D0")]
	public PFBKELDFJEL(JLOLIGIEBFJ<T> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x50BCBC0", Offset = "0x50BBDC0", VA = "0x1850BCBC0", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class HHECLJEBBDI<T> : HNGNNIFOBCI<JLOLIGIEBFJ<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly FADLIKFAAAO<T> GFDPONJDIJI;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x46ADAD0", Offset = "0x46ACCD0", VA = "0x1846ADAD0")]
	public HHECLJEBBDI(T CGKPJBPKLPJ, JLOLIGIEBFJ<T> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x40D5200", Offset = "0x40D4400", VA = "0x1840D5200", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class DCBHIFJPJKJ<T> : HNGNNIFOBCI<OBEEJEGCEPI<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly IJIABFDKKGF<T> BDLMJLIDGAA;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6378910", Offset = "0x6377B10", VA = "0x186378910")]
	public DCBHIFJPJKJ(T CGKPJBPKLPJ, bool KEDPEKBDLOB, OBEEJEGCEPI<T> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x40D5200", Offset = "0x40D4400", VA = "0x1840D5200", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct FCBIFODDNLG<TData> where TData : notnull, ENPCDGHPBKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public IEnumerable<TData> BFKELHFGHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool NJBNMBIAAOO;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x44AFEB0", Offset = "0x44AF0B0", VA = "0x1844AFEB0")]
	public FCBIFODDNLG(IEnumerable<TData> GCHBBMGFOFC, bool LOJNFGBOFEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct FLBDOICLICE<TData> where TData : notnull, ENPCDGHPBKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public List<TData> BFKELHFGHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public List<bool> OLOODCAMBOP;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x453EB40", Offset = "0x453DD40", VA = "0x18453EB40")]
	public FLBDOICLICE(List<TData> GCHBBMGFOFC, List<bool> JBHJMACMCCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface ENPCDGHPBKN
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool ELOCBDBHHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface MOBHMFHGGPL<TData> where TData : ENPCDGHPBKN
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HEELOGLJLHD([In] FCBIFODDNLG<TData> ACMFKPPJAFJ);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HEELOGLJLHD([In] FLBDOICLICE<TData> ACMFKPPJAFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface ALGBIPCEGCF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GJIDOGJIIII(T CGKPJBPKLPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class KJPMPHBCJID<TData> : HNGNNIFOBCI<MOBHMFHGGPL<TData>> where TData : notnull, ENPCDGHPBKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly FCBIFODDNLG<TData> ACMFKPPJAFJ;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4A95A70", Offset = "0x4A94C70", VA = "0x184A95A70")]
	public KJPMPHBCJID(List<TData> HBCLGBNGIPE, bool NJBNMBIAAOO, MOBHMFHGGPL<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x40D5200", Offset = "0x40D4400", VA = "0x1840D5200", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class ANKGODKLHBC<TData> : HNGNNIFOBCI<MOBHMFHGGPL<TData>> where TData : notnull, ENPCDGHPBKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly FLBDOICLICE<TData> ACMFKPPJAFJ;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4855300", Offset = "0x4854500", VA = "0x184855300")]
	public ANKGODKLHBC(List<TData> HBCLGBNGIPE, List<bool> OLOODCAMBOP, MOBHMFHGGPL<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4855240", Offset = "0x4854440", VA = "0x184855240", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface OPKOIBBCEMD<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NNLCAMNPEJB> HEELOGLJLHD(BOJBHGDEKNP<TData> IMLMCJCDBMM);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class EMPOPLMBONA<TData> : KDOEOKALEPN<OPKOIBBCEMD<TData>, NNLCAMNPEJB> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct ANKAHJLNAPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder<NNLCAMNPEJB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public EMPOPLMBONA<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<NNLCAMNPEJB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x4854EF0", Offset = "0x48540F0", VA = "0x184854EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x48551D0", Offset = "0x48543D0", VA = "0x1848551D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly BOJBHGDEKNP<TData> DOLGMOOCCCH;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x411DD10", Offset = "0x411CF10", VA = "0x18411DD10")]
	public EMPOPLMBONA(TData BKPJNDFFGKO, IReadOnlyList<TData> OGLBBGLDDCM, bool OGHMCNOPNDP, OPKOIBBCEMD<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x411DC10", Offset = "0x411CE10", VA = "0x18411DC10", Slot = "4")]
	[AsyncStateMachine(typeof(EMPOPLMBONA<>.ANKAHJLNAPF))]
	public override Task<NNLCAMNPEJB> HEELOGLJLHD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct BOJBHGDEKNP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData ILGJICMGGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public IReadOnlyList<TData> JAJPHNNDALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool GBBHNMKNLPK;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x56F2400", Offset = "0x56F1600", VA = "0x1856F2400")]
	public BOJBHGDEKNP(TData BKPJNDFFGKO, IReadOnlyList<TData> OGLBBGLDDCM, bool OGHMCNOPNDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface IGPPJMGHCOC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HEELOGLJLHD([In] COEENPEOCKF<TData> GLMPHIHLEMC);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface LJHFBCGECFG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEELOGLJLHD([In] JGHNMOLJGIB<TData> GLMPHIHLEMC);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface GDOCNAPKOMP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MHFOGMAGEGG([In] CFGNMPHCGBA<TData> GLMPHIHLEMC);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCCHMOLNMIE();
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class PJHFAFLPIHM<TData> : HNGNNIFOBCI<IGPPJMGHCOC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly COEENPEOCKF<TData> GLMPHIHLEMC;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x512E850", Offset = "0x512DA50", VA = "0x18512E850")]
	public PJHFAFLPIHM(IEnumerable<TData> HBCLGBNGIPE, EOGPNGFBHLD JLNFDAODDKP, FAKFOCBMCDN MDMIJJAMBMD, float CONBGIGHGMM, bool OGHMCNOPNDP, IGPPJMGHCOC<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x40D5200", Offset = "0x40D4400", VA = "0x1840D5200", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class JEAAIHEOOOD<TData> : HNGNNIFOBCI<LJHFBCGECFG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly JGHNMOLJGIB<TData> GLMPHIHLEMC;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4968A40", Offset = "0x4967C40", VA = "0x184968A40")]
	public JEAAIHEOOOD(TData[] HBCLGBNGIPE, EOGPNGFBHLD[] JLNFDAODDKP, FAKFOCBMCDN[] MDMIJJAMBMD, float[] CONBGIGHGMM, LJHFBCGECFG<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x463D850", Offset = "0x463CA50", VA = "0x18463D850", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class CMNKCILFIHP<TData> : HNGNNIFOBCI<GDOCNAPKOMP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x40D97D0", Offset = "0x40D89D0", VA = "0x1840D97D0")]
	public CMNKCILFIHP(GDOCNAPKOMP<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5CE92D0", Offset = "0x5CE84D0", VA = "0x185CE92D0", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class GOIFGBIOAOG<TData> : HNGNNIFOBCI<GDOCNAPKOMP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly CFGNMPHCGBA<TData> GLMPHIHLEMC;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x463D910", Offset = "0x463CB10", VA = "0x18463D910")]
	public GOIFGBIOAOG(IEnumerable<TData> HBCLGBNGIPE, EOGPNGFBHLD JLNFDAODDKP, FAKFOCBMCDN MDMIJJAMBMD, float CONBGIGHGMM, GDOCNAPKOMP<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x463D850", Offset = "0x463CA50", VA = "0x18463D850", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct COEENPEOCKF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public IEnumerable<TData> BFKELHFGHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public EOGPNGFBHLD IAOFMHCNKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public FAKFOCBMCDN ECAGAIIDDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public float CONBGIGHGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public bool OGHMCNOPNDP;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0560", Offset = "0x5DBF760", VA = "0x185DC0560")]
	public COEENPEOCKF(IEnumerable<TData> HBCLGBNGIPE, EOGPNGFBHLD JLNFDAODDKP, FAKFOCBMCDN MDMIJJAMBMD, float CONBGIGHGMM, bool OGHMCNOPNDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct JGHNMOLJGIB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public TData[] BFKELHFGHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public EOGPNGFBHLD[] IAOFMHCNKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public FAKFOCBMCDN[] ECAGAIIDDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public float[] CONBGIGHGMM;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4980F30", Offset = "0x4980130", VA = "0x184980F30")]
	public JGHNMOLJGIB(TData[] HBCLGBNGIPE, EOGPNGFBHLD[] JLNFDAODDKP, FAKFOCBMCDN[] MDMIJJAMBMD, float[] CONBGIGHGMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct CFGNMPHCGBA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public IEnumerable<TData> BFKELHFGHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public EOGPNGFBHLD IAOFMHCNKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public FAKFOCBMCDN ECAGAIIDDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float CONBGIGHGMM;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5ADF4D0", Offset = "0x5ADE6D0", VA = "0x185ADF4D0")]
	public CFGNMPHCGBA(IEnumerable<TData> HBCLGBNGIPE, EOGPNGFBHLD JLNFDAODDKP, FAKFOCBMCDN MDMIJJAMBMD, float CONBGIGHGMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface IPLIELKLLFI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OBFDIKHJHBI([In] CBNFLOILIHP<TData> DNPHOKJJAEF);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OODKAGNCGIC([In] CBNFLOILIHP<TData> DNPHOKJJAEF);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OHKAOHLNJMF([In] bool ILDPLHPEKKM);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FOICFDDAJCK([In] CBNFLOILIHP<TData> DNPHOKJJAEF);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BAODFDDLDMC();

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LCFMDLPBMEK([In] TData DOOABFPJOFK);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class NFKMBJPGNPB<TData> : HNGNNIFOBCI<IPLIELKLLFI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly CBNFLOILIHP<TData> DNPHOKJJAEF;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4E28B30", Offset = "0x4E27D30", VA = "0x184E28B30")]
	public NFKMBJPGNPB(List<TData> IDDPONMNMLO, IPLIELKLLFI<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x40D5200", Offset = "0x40D4400", VA = "0x1840D5200", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class OOMJBNOIPNF<TData> : HNGNNIFOBCI<IPLIELKLLFI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x40D97D0", Offset = "0x40D89D0", VA = "0x1840D97D0")]
	public OOMJBNOIPNF(IPLIELKLLFI<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x501D960", Offset = "0x501CB60", VA = "0x18501D960", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class JNCEBILFMEA<TData> : HNGNNIFOBCI<IPLIELKLLFI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly bool OGHMCNOPNDP;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x498EB40", Offset = "0x498DD40", VA = "0x18498EB40")]
	public JNCEBILFMEA(bool OGHMCNOPNDP, IPLIELKLLFI<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x498EAE0", Offset = "0x498DCE0", VA = "0x18498EAE0", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class KKIAFFGIEEB<TData> : HNGNNIFOBCI<IPLIELKLLFI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly CBNFLOILIHP<TData> DNPHOKJJAEF;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4A99D50", Offset = "0x4A98F50", VA = "0x184A99D50")]
	public KKIAFFGIEEB(List<TData> IDDPONMNMLO, bool OGHMCNOPNDP, IPLIELKLLFI<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4855240", Offset = "0x4854440", VA = "0x184855240", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class EIEBFHDLGAB<TData> : HNGNNIFOBCI<IPLIELKLLFI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly TData DOOABFPJOFK;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4101910", Offset = "0x4100B10", VA = "0x184101910")]
	public EIEBFHDLGAB(TData DOOABFPJOFK, IPLIELKLLFI<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x41017A0", Offset = "0x41009A0", VA = "0x1841017A0", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class DPNJJBIHGCM<TData> : HNGNNIFOBCI<IPLIELKLLFI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly CBNFLOILIHP<TData> DNPHOKJJAEF;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x63F4CE0", Offset = "0x63F3EE0", VA = "0x1863F4CE0")]
	public DPNJJBIHGCM(IEnumerable<TData> IDDPONMNMLO, IPLIELKLLFI<TData> JEHDAPIHAPN, bool OGHMCNOPNDP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x63F4B70", Offset = "0x63F3D70", VA = "0x1863F4B70", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct CBNFLOILIHP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public IEnumerable<TData> BFKELHFGHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool OGHMCNOPNDP;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x59DF2B0", Offset = "0x59DE4B0", VA = "0x1859DF2B0")]
	public CBNFLOILIHP(IEnumerable<TData> GCHBBMGFOFC, bool HJMLHIMFBDA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface DFBMACKKCBJ
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NNLCAMNPEJB> HEELOGLJLHD(PPOCKHFGCEN BJFAHACIPIJ);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class ADMOFAELKPE : KDOEOKALEPN<DFBMACKKCBJ, NNLCAMNPEJB>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct GBMJOHEBGDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder<NNLCAMNPEJB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public ADMOFAELKPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<NNLCAMNPEJB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x764FF00", Offset = "0x764F100", VA = "0x18764FF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7650180", Offset = "0x764F380", VA = "0x187650180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly PPOCKHFGCEN ECCPCEDIAGN;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x764F4F0", Offset = "0x764E6F0", VA = "0x18764F4F0")]
	public ADMOFAELKPE(bool OGHMCNOPNDP, DFBMACKKCBJ JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x764F400", Offset = "0x764E600", VA = "0x18764F400", Slot = "4")]
	[AsyncStateMachine(typeof(GBMJOHEBGDH))]
	public override Task<NNLCAMNPEJB> HEELOGLJLHD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct PPOCKHFGCEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public bool GBBHNMKNLPK;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x27C0C30", Offset = "0x27BFE30", VA = "0x1827C0C30")]
	public PPOCKHFGCEN(bool OGHMCNOPNDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct HIMIEGFINAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool OFMDBAPHDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly bool CEILFBPGFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly bool DIOKPOCPBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly bool OGHMCNOPNDP;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5714440", Offset = "0x5713640", VA = "0x185714440")]
	public HIMIEGFINAF(bool OFMDBAPHDAB, bool CEILFBPGFOM, bool DIOKPOCPBHH, bool OGHMCNOPNDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x76501F0", Offset = "0x764F3F0", VA = "0x1876501F0")]
	public HIMIEGFINAF(bool CEILFBPGFOM, bool OGHMCNOPNDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface IKMPCOIMCMD
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LCOGIENGBCA(HIMIEGFINAF AHKJJMNDJHN);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool COBPNBEFAJA(HIMIEGFINAF AHKJJMNDJHN);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class OOPGIDFJOAI : HNGNNIFOBCI<IKMPCOIMCMD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly HIMIEGFINAF AHKJJMNDJHN;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7651370", Offset = "0x7650570", VA = "0x187651370")]
	public OOPGIDFJOAI(bool LBAHEDDLOKA, bool CEILFBPGFOM, bool DIOKPOCPBHH, bool OGHMCNOPNDP, IKMPCOIMCMD JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7651320", Offset = "0x7650520", VA = "0x187651320", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class KFIEIHLECMH : HNGNNIFOBCI<IKMPCOIMCMD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly HIMIEGFINAF AHKJJMNDJHN;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7650250", Offset = "0x764F450", VA = "0x187650250")]
	public KFIEIHLECMH(bool CEILFBPGFOM, bool OGHMCNOPNDP, IKMPCOIMCMD JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7650200", Offset = "0x764F400", VA = "0x187650200", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface OJPEENFECEA
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEELOGLJLHD([In] BGFDOCMELEK NGGHKDEEOIF);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class LIEDOHICOKG : HNGNNIFOBCI<OJPEENFECEA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly BGFDOCMELEK NGGHKDEEOIF;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7650490", Offset = "0x764F690", VA = "0x187650490")]
	public LIEDOHICOKG(Guid[] NJMPLJJMEAE, Vector3[] OLDLPDOMNOI, Quaternion[] CJBBELOGDJL, float[] PJNMGKCKDPE, Dictionary<Guid, Vector3> IEHBPLHIFNK, OJPEENFECEA JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x76503E0", Offset = "0x764F5E0", VA = "0x1876503E0", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface GIFJFIGNHME<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLHHBJNLNKD([In] JBLNMPOPJHA<TData> OPGDENEPCGL);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MHFOGMAGEGG([In] NFLFCPCODNH BLJKDJNJEGO);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MHFOGMAGEGG([In] EDAGPOOOOMP BLJKDJNJEGO);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BCCHMOLNMIE();
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class EBGLECLNMLG<TData> : HNGNNIFOBCI<GIFJFIGNHME<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x40D97D0", Offset = "0x40D89D0", VA = "0x1840D97D0")]
	public EBGLECLNMLG(GIFJFIGNHME<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x40D9780", Offset = "0x40D8980", VA = "0x1840D9780", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class DEGFMICHBBP<TData> : HNGNNIFOBCI<GIFJFIGNHME<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly NFLFCPCODNH ABLPIGKMIDA;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6383A00", Offset = "0x6382C00", VA = "0x186383A00")]
	public DEGFMICHBBP(Vector3 HENAGNHHOEH, bool PMIAMNCEFNP, GIFJFIGNHME<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x46504C0", Offset = "0x464F6C0", VA = "0x1846504C0", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class BHMLNNCHMMK<TData> : HNGNNIFOBCI<GIFJFIGNHME<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly EDAGPOOOOMP ABLPIGKMIDA;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x58B1B30", Offset = "0x58B0D30", VA = "0x1858B1B30")]
	public BHMLNNCHMMK(Guid MBLHOIDIDHF, int KOOLKCPAFBB, Vector3 LBPAIJGCICL, Quaternion GLMEOLPKLCA, float LDCGEIMNGOD, bool PMIAMNCEFNP, GIFJFIGNHME<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x58B1AD0", Offset = "0x58B0CD0", VA = "0x1858B1AD0", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class EAIBGPNMNBK<TData> : HNGNNIFOBCI<GIFJFIGNHME<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly JBLNMPOPJHA<TData> ABLPIGKMIDA;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x40D5360", Offset = "0x40D4560", VA = "0x1840D5360")]
	public EAIBGPNMNBK(TData CGKPJBPKLPJ, bool OGHMCNOPNDP, GIFJFIGNHME<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x40D5200", Offset = "0x40D4400", VA = "0x1840D5200", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct NFLFCPCODNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly Vector3 HENAGNHHOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly bool PMIAMNCEFNP;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7650DE0", Offset = "0x764FFE0", VA = "0x187650DE0")]
	public NFLFCPCODNH(Vector3 HENAGNHHOEH, bool PMIAMNCEFNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct EDAGPOOOOMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly Guid MBLHOIDIDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly int KOOLKCPAFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 LBPAIJGCICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly Quaternion GLMEOLPKLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly float LDCGEIMNGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool PMIAMNCEFNP;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x764FE80", Offset = "0x764F080", VA = "0x18764FE80")]
	public EDAGPOOOOMP(Guid MBLHOIDIDHF, int KOOLKCPAFBB, Vector3 LBPAIJGCICL, Quaternion GLMEOLPKLCA, float LDCGEIMNGOD, bool PMIAMNCEFNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct JBLNMPOPJHA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly TData CGKPJBPKLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly bool OGHMCNOPNDP;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4954740", Offset = "0x4953940", VA = "0x184954740")]
	public JBLNMPOPJHA(TData CGKPJBPKLPJ, bool OGHMCNOPNDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public interface PLJEGGODIGD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HEELOGLJLHD([In] AMEMACGPPGK<TData> PGGMGFIOOLA);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HEELOGLJLHD([In] CEJPPAJHCEI<TData> PGGMGFIOOLA);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface DGPFNJIPDEM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLHHBJNLNKD([In] GDLLCDHNJAD<TData> EJHGAHMEDAL);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MHFOGMAGEGG([In] NBJKEPCCPEN BLJKDJNJEGO);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BCCHMOLNMIE();
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class ILFKPJGKOII<TData> : HNGNNIFOBCI<PLJEGGODIGD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly AMEMACGPPGK<TData> PGGMGFIOOLA;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x477D710", Offset = "0x477C910", VA = "0x18477D710")]
	public ILFKPJGKOII(IEnumerable<TData> HBCLGBNGIPE, Vector3 EFDPDAPMMPP, bool OGHMCNOPNDP, PLJEGGODIGD<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x40D5200", Offset = "0x40D4400", VA = "0x1840D5200", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class JIGEGDLFNDC<TData> : HNGNNIFOBCI<DGPFNJIPDEM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x40D97D0", Offset = "0x40D89D0", VA = "0x1840D97D0")]
	public JIGEGDLFNDC(DGPFNJIPDEM<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x46BD7C0", Offset = "0x46BC9C0", VA = "0x1846BD7C0", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class DCFHFMCGKFF<TData> : HNGNNIFOBCI<DGPFNJIPDEM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly GDLLCDHNJAD<TData> PGGMGFIOOLA;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x637A9E0", Offset = "0x6379BE0", VA = "0x18637A9E0")]
	public DCFHFMCGKFF(IEnumerable<TData> HBCLGBNGIPE, bool OGHMCNOPNDP, DGPFNJIPDEM<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x40D5200", Offset = "0x40D4400", VA = "0x1840D5200", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class DHBIGDLAEMM<TData> : HNGNNIFOBCI<PLJEGGODIGD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly CEJPPAJHCEI<TData> PGGMGFIOOLA;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x63C2760", Offset = "0x63C1960", VA = "0x1863C2760")]
	public DHBIGDLAEMM(IEnumerable<TData> HBCLGBNGIPE, Vector3 MOGCIBFBEHK, EFFHIOPHOAC OONEMPGBBCK, bool OGHMCNOPNDP, PLJEGGODIGD<TData> JEHDAPIHAPN, Space MABJKKMOPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4AA2000", Offset = "0x4AA1200", VA = "0x184AA2000", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class NAJIMHEHFJC<TData> : HNGNNIFOBCI<DGPFNJIPDEM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly NBJKEPCCPEN PGGMGFIOOLA;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4E15A70", Offset = "0x4E14C70", VA = "0x184E15A70")]
	public NAJIMHEHFJC(Vector3 EFDPDAPMMPP, DGPFNJIPDEM<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x46504C0", Offset = "0x464F6C0", VA = "0x1846504C0", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct AMEMACGPPGK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly IEnumerable<TData> HBCLGBNGIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly Vector3 EFDPDAPMMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool OGHMCNOPNDP;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x484FD60", Offset = "0x484EF60", VA = "0x18484FD60")]
	public AMEMACGPPGK(IEnumerable<TData> HBCLGBNGIPE, Vector3 EFDPDAPMMPP, bool OGHMCNOPNDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct GDLLCDHNJAD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly IEnumerable<TData> HBCLGBNGIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly bool OGHMCNOPNDP;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x45F39C0", Offset = "0x45F2BC0", VA = "0x1845F39C0")]
	public GDLLCDHNJAD(IEnumerable<TData> HBCLGBNGIPE, bool OGHMCNOPNDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct CEJPPAJHCEI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly IEnumerable<TData> HBCLGBNGIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly Vector3 MOGCIBFBEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly EFFHIOPHOAC OONEMPGBBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public readonly bool OGHMCNOPNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly Space MABJKKMOPAH;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x59FA830", Offset = "0x59F9A30", VA = "0x1859FA830")]
	public CEJPPAJHCEI(IEnumerable<TData> HBCLGBNGIPE, Vector3 MOGCIBFBEHK, EFFHIOPHOAC OONEMPGBBCK, bool OGHMCNOPNDP, Space MABJKKMOPAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct NBJKEPCCPEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly Vector3 EFDPDAPMMPP;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x27C08C0", Offset = "0x27BFAC0", VA = "0x1827C08C0")]
	public NBJKEPCCPEN(Vector3 EFDPDAPMMPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public enum EFFHIOPHOAC
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface APNCOKIOFMJ
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HEELOGLJLHD([In] JJHHNKDKFNF DBDJHOMIACO);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class LEAANMPKAPI : HNGNNIFOBCI<APNCOKIOFMJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly JJHHNKDKFNF DBDJHOMIACO;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7650380", Offset = "0x764F580", VA = "0x187650380")]
	public LEAANMPKAPI(bool OGHMCNOPNDP, APNCOKIOFMJ JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x76502D0", Offset = "0x764F4D0", VA = "0x1876502D0", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct JJHHNKDKFNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool OGHMCNOPNDP;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x27C0C30", Offset = "0x27BFE30", VA = "0x1827C0C30")]
	public JJHHNKDKFNF(bool OGHMCNOPNDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public interface LKLHGKEGKNF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HEELOGLJLHD([In] EKEEBGLPNNK<TData> DMIBMCNLHMO);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HEELOGLJLHD([In] COFKOPPPNIP<TData> DMIBMCNLHMO);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public interface LFJAHGJLHNB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLHHBJNLNKD([In] HGCJAGCOCMI<TData> OPGDENEPCGL);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MHFOGMAGEGG([In] FFOBBCHFFAB BLJKDJNJEGO);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BCCHMOLNMIE();
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class LKNNKDKHLOH<TData> : HNGNNIFOBCI<LKLHGKEGKNF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly EKEEBGLPNNK<TData> DMIBMCNLHMO;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4B89220", Offset = "0x4B88420", VA = "0x184B89220")]
	public LKNNKDKHLOH(IEnumerable<TData> HBCLGBNGIPE, Quaternion EFDPDAPMMPP, Vector3? OBOOCCODCIN, bool MGHKPNBCKIL, bool OGHMCNOPNDP, LKLHGKEGKNF<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x40D5200", Offset = "0x40D4400", VA = "0x1840D5200", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class POCNHKEBKHD<TData> : HNGNNIFOBCI<LFJAHGJLHNB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x40D97D0", Offset = "0x40D89D0", VA = "0x1840D97D0")]
	public POCNHKEBKHD(LFJAHGJLHNB<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x46BD7C0", Offset = "0x46BC9C0", VA = "0x1846BD7C0", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class PAGJHCICHLB<TData> : HNGNNIFOBCI<LFJAHGJLHNB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly HGCJAGCOCMI<TData> DMIBMCNLHMO;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x50B2500", Offset = "0x50B1700", VA = "0x1850B2500")]
	public PAGJHCICHLB(IEnumerable<TData> HBCLGBNGIPE, bool OGHMCNOPNDP, LFJAHGJLHNB<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x40D5200", Offset = "0x40D4400", VA = "0x1840D5200", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class NGEEMPPMNDF<TData> : HNGNNIFOBCI<LKLHGKEGKNF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly COFKOPPPNIP<TData> DMIBMCNLHMO;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4E2DE10", Offset = "0x4E2D010", VA = "0x184E2DE10")]
	public NGEEMPPMNDF(IEnumerable<TData> HBCLGBNGIPE, Quaternion JKJGPLJFONK, EFFHIOPHOAC DDDGHEPNIHG, Vector3? OBOOCCODCIN, bool MGHKPNBCKIL, bool OGHMCNOPNDP, Space MABJKKMOPAH, LKLHGKEGKNF<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4AA2000", Offset = "0x4AA1200", VA = "0x184AA2000", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class DOGIGLNNEAD<TData> : HNGNNIFOBCI<LFJAHGJLHNB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly FFOBBCHFFAB DMIBMCNLHMO;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x63EB1D0", Offset = "0x63EA3D0", VA = "0x1863EB1D0")]
	public DOGIGLNNEAD(Quaternion EFDPDAPMMPP, Vector3? OBOOCCODCIN, bool MGHKPNBCKIL, LFJAHGJLHNB<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x46504C0", Offset = "0x464F6C0", VA = "0x1846504C0", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct EKEEBGLPNNK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly IEnumerable<TData> HBCLGBNGIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly Quaternion EFDPDAPMMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Vector3? OBOOCCODCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly bool MGHKPNBCKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly bool OGHMCNOPNDP;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4102D30", Offset = "0x4101F30", VA = "0x184102D30")]
	public EKEEBGLPNNK(IEnumerable<TData> HBCLGBNGIPE, Quaternion EFDPDAPMMPP, Vector3? OBOOCCODCIN, bool MGHKPNBCKIL, bool OGHMCNOPNDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct HGCJAGCOCMI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly IEnumerable<TData> HBCLGBNGIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly bool OGHMCNOPNDP;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x46A7080", Offset = "0x46A6280", VA = "0x1846A7080")]
	public HGCJAGCOCMI(IEnumerable<TData> HBCLGBNGIPE, bool OGHMCNOPNDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct COFKOPPPNIP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly IEnumerable<TData> HBCLGBNGIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly Quaternion JKJGPLJFONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly EFFHIOPHOAC DDDGHEPNIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3? OBOOCCODCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly bool MGHKPNBCKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly bool OGHMCNOPNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Space MABJKKMOPAH;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5DC07F0", Offset = "0x5DBF9F0", VA = "0x185DC07F0")]
	public COFKOPPPNIP(IEnumerable<TData> HBCLGBNGIPE, Quaternion JKJGPLJFONK, EFFHIOPHOAC DDDGHEPNIHG, Vector3? OBOOCCODCIN, bool MGHKPNBCKIL, bool OGHMCNOPNDP, Space MABJKKMOPAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct FFOBBCHFFAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Quaternion EFDPDAPMMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly Vector3? OBOOCCODCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly bool MGHKPNBCKIL;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x56CC6D0", Offset = "0x56CB8D0", VA = "0x1856CC6D0")]
	public FFOBBCHFFAB(Quaternion EFDPDAPMMPP, Vector3? OBOOCCODCIN, bool MGHKPNBCKIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public interface FIKNMFGKHAD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLHHBJNLNKD([In] MGJDLGEFIFP<TData> OPGDENEPCGL);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MHFOGMAGEGG([In] GNEKDOPDLEI BLJKDJNJEGO);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MHFOGMAGEGG([In] OFNIMEIIJCH BLJKDJNJEGO);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MHFOGMAGEGG([In] EKDIBNDMCHE BLJKDJNJEGO);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BCCHMOLNMIE();
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class NJEBFCMADFH<TData> : HNGNNIFOBCI<FIKNMFGKHAD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly EKDIBNDMCHE CNOLGGADJAF;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4E3C660", Offset = "0x4E3B860", VA = "0x184E3C660")]
	public NJEBFCMADFH(Vector3 GGOEAGHKPDL, float EDDIMDPGGDG, Vector3 OBOOCCODCIN, bool OMMFAJDDNOI, bool EJJFDLIDGCB, FIKNMFGKHAD<TData> JEHDAPIHAPN, Space MABJKKMOPAH = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4E3C600", Offset = "0x4E3B800", VA = "0x184E3C600", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class BLCMEACEHMP<TData> : HNGNNIFOBCI<FIKNMFGKHAD<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x40D97D0", Offset = "0x40D89D0", VA = "0x1840D97D0")]
	public BLCMEACEHMP(FIKNMFGKHAD<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x58C9130", Offset = "0x58C8330", VA = "0x1858C9130", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class LBPBAFNDDNH<TData> : HNGNNIFOBCI<FIKNMFGKHAD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly MGJDLGEFIFP<TData> CNOLGGADJAF;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4B277E0", Offset = "0x4B269E0", VA = "0x184B277E0")]
	public LBPBAFNDDNH(IEnumerable<TData> HBCLGBNGIPE, bool OGHMCNOPNDP, FIKNMFGKHAD<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x40D5200", Offset = "0x40D4400", VA = "0x1840D5200", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class POCPEPAPGNK<TData> : HNGNNIFOBCI<FIKNMFGKHAD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly OFNIMEIIJCH CNOLGGADJAF;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5138500", Offset = "0x5137700", VA = "0x185138500")]
	public POCPEPAPGNK(float LKOAAGOGBEE, bool BJDDDFDFPIP, Vector3 OBOOCCODCIN, FIKNMFGKHAD<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5138440", Offset = "0x5137640", VA = "0x185138440", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public class ACODPFJBILG<TData> : HNGNNIFOBCI<FIKNMFGKHAD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly GNEKDOPDLEI CNOLGGADJAF;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4650520", Offset = "0x464F720", VA = "0x184650520")]
	public ACODPFJBILG(float EDDIMDPGGDG, Vector3 OBOOCCODCIN, FIKNMFGKHAD<TData> JEHDAPIHAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x46504C0", Offset = "0x464F6C0", VA = "0x1846504C0", Slot = "4")]
	public override bool HEELOGLJLHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct EKDIBNDMCHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly Vector3 GGOEAGHKPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly float EDDIMDPGGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Vector3 OBOOCCODCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool PMIAMNCEFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly Space MABJKKMOPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool EJJFDLIDGCB;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x764FEC0", Offset = "0x764F0C0", VA = "0x18764FEC0")]
	public EKDIBNDMCHE(Vector3 GGOEAGHKPDL, float EDDIMDPGGDG, Vector3 OBOOCCODCIN, bool PMIAMNCEFNP, bool EIPHMHJAOGB, Space MABJKKMOPAH = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct MGJDLGEFIFP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly IEnumerable<TData> HBCLGBNGIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly bool OGHMCNOPNDP;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4D9AD90", Offset = "0x4D99F90", VA = "0x184D9AD90")]
	public MGJDLGEFIFP(IEnumerable<TData> HBCLGBNGIPE, bool OGHMCNOPNDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct OFNIMEIIJCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float LKOAAGOGBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly bool BJDDDFDFPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly Vector3 OBOOCCODCIN;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7651300", Offset = "0x7650500", VA = "0x187651300")]
	public OFNIMEIIJCH(float LKOAAGOGBEE, bool BJDDDFDFPIP, Vector3 OBOOCCODCIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public struct GNEKDOPDLEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly float EDDIMDPGGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Vector3 OBOOCCODCIN;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x56875E0", Offset = "0x56867E0", VA = "0x1856875E0")]
	public GNEKDOPDLEI(float EDDIMDPGGDG, Vector3 OBOOCCODCIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct BGFDOCMELEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly Guid[] HBCLGBNGIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly bool AEBIIJCCIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly bool FNOLCMIMCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly bool HHJDELIJONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Vector3[] OLDLPDOMNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly Quaternion[] CJBBELOGDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly float[] PJNMGKCKDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly Dictionary<Guid, Vector3> IEHBPLHIFNK;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x764F8F0", Offset = "0x764EAF0", VA = "0x18764F8F0")]
	public BGFDOCMELEK(Guid[] NJMPLJJMEAE, Vector3[] OLDLPDOMNOI, Quaternion[] CJBBELOGDJL, float[] PJNMGKCKDPE, Dictionary<Guid, Vector3> IEHBPLHIFNK, bool AEBIIJCCIIC = true, bool FNOLCMIMCJK = true, bool HHJDELIJONC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x764F720", Offset = "0x764E920", VA = "0x18764F720")]
	private static void DMICCJOADFJ(Dictionary<Guid, Vector3> IEHBPLHIFNK, int BNNCLPODCBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class MOGAPGKAGNH
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private struct AJGNPKJODHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public bool KKPONNJPDGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public ANOENEDKKHA PMEHLBDEPIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public ANOENEDKKHA NKEBGFJPMLO;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static AJGNPKJODHE IBFMKFEENLD;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken GEKPFJDHKCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7650DC0", Offset = "0x764FFC0", VA = "0x187650DC0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static ANOENEDKKHA PMEHLBDEPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7650B20", Offset = "0x764FD20", VA = "0x187650B20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7650D60", Offset = "0x764FF60", VA = "0x187650D60")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7650A30", Offset = "0x764FC30", VA = "0x187650A30")]
	[LDKBBAENJDF.LNCMKHHEGFN]
	internal static void BBACBJKIIBA(ANOENEDKKHA MMEAKBHOODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7650C10", Offset = "0x764FE10", VA = "0x187650C10")]
	public static void DICECPNPBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7650BC0", Offset = "0x764FDC0", VA = "0x187650BC0")]
	private static ANOENEDKKHA DAOLDLJBEKA(ANOENEDKKHA BDFODELEDCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class IIJPAFEGKOF
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public enum EMELJHGGNLC
	{
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x34D6580", Offset = "0x34D5780", VA = "0x1834D6580")]
	public static void DHGIFACPING<T>(T IMMKPGPNBIK, EMELJHGGNLC NNILCBOLNDI) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x34D6510", Offset = "0x34D5710", VA = "0x1834D6510")]
	public static void DHGIFACPING<T>(T IMMKPGPNBIK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x34D67F0", Offset = "0x34D59F0", VA = "0x1834D67F0")]
	public static void MKKMIHNDNMN<T>(T IMMKPGPNBIK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x34D6AA0", Offset = "0x34D5CA0", VA = "0x1834D6AA0")]
	public static T NKAAMPBENGI<T>(EMELJHGGNLC NNILCBOLNDI) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x34D6950", Offset = "0x34D5B50", VA = "0x1834D6950")]
	public static bool NHGJGBKEDKC<T>(EMELJHGGNLC NNILCBOLNDI, T? GDDFOHMANPO, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T NMMOFIGEOGC) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x34D6B50", Offset = "0x34D5D50", VA = "0x1834D6B50")]
	public static bool OKPDIDOEGCM<T>(EMELJHGGNLC NNILCBOLNDI, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T CJNJOEFGOHJ) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x34D66E0", Offset = "0x34D58E0", VA = "0x1834D66E0")]
	public static bool JIKHDIMNHPK<T>(EMELJHGGNLC NNILCBOLNDI) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x34D6790", Offset = "0x34D5990", VA = "0x1834D6790")]
	public static T NKAAMPBENGI<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x34D68A0", Offset = "0x34D5AA0", VA = "0x1834D68A0")]
	public static bool NHGJGBKEDKC<T>(T GDDFOHMANPO, [Out] T NMMOFIGEOGC) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x34D6790", Offset = "0x34D5990", VA = "0x1834D6790")]
	public static bool JIKHDIMNHPK<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal static class MMJOCEOFPMP
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7650800", Offset = "0x764FA00", VA = "0x187650800")]
	public static void GDOFBKFFGIB(IEnumerable HEBILAHBAGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x35A6840", Offset = "0x35A5A40", VA = "0x1835A6840")]
	public static void GDOFBKFFGIB<T>(T[] LGLFHJLCKKH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x35A6930", Offset = "0x35A5B30", VA = "0x1835A6930")]
	public static void GDOFBKFFGIB<T>(T PMBHGOELOML) where T : notnull, Enum
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

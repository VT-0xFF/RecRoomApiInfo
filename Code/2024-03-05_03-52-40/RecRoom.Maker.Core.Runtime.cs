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
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
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
		[Cpp2IlInjected.Address(RVA = "0x611E2B0", Offset = "0x611D0B0", VA = "0x18611E2B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E43F0", Offset = "0x7E31F0", VA = "0x1807E43F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E4430", Offset = "0x7E3230", VA = "0x1807E4430")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GOLKEOGOAAN<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn NKODOLIIMAG(TData KDHDNCADFDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface KBNJEEMEKOK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(HJMBPJKAKAA NOKGACCEMBE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData EOCODFIAJEL, Collider EJEBELEOKLK, HJMBPJKAKAA NOKGACCEMBE, [Optional] DPIIANELJKL? CPJPFCHLAHB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData EOCODFIAJEL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider EJEBELEOKLK);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FCCEPFDIMFE<TData> : EJLAJAIHIPJ, OBIKBBMAEAN<TData>, JCLDGPEAHLO<TData>, FHHNLJBPEKJ<TData>, BHGNJMGGBIH, FHCGPGJOCEL<TData>, NBDPEFNGJON, CIAHEDLLAJO
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FHCGPGJOCEL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 CDHDMAIICDB, Vector3 JMFPDJFKFGP, float CCDDMHMFCJA, [Out] T HGJGNNNJMHJ, [Out] Vector3 CCJONMBFJKA, [Out] Collider EJEBELEOKLK);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 CDHDMAIICDB, Vector3 JMFPDJFKFGP, float FKFLAIBBOCD, float CCDDMHMFCJA, T[] DJPMLABFFOM, [Out] Vector3 MAFPOHEFHOB, [Out] Collider ANEOINEKBEK);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 CDHDMAIICDB, float FKFLAIBBOCD, Vector3 OBCKBJFKKMD, T[] DJPMLABFFOM);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider CNCBABNOLDD, [Out] T MEGMIOCOLKO);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EJLAJAIHIPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds MIHGBAGPOKL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform NNEFABAHOJE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds OICFOKBBCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform DGKAJPIMPLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 HAKENLOCNGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NJJFJEIFGHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool KLFIHPKHJFA = true, int LPBGKHJIJJI = 0);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool DPBNBNODPHE, object BNAJMHPOOCG);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CIAHEDLLAJO
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	CGNODMPJOCB JFKNJMOHKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PJJJNMNBLEL
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool EEKAEGIJOOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool KIDIIEHDFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool CDNCCIEFBND
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Dictionary<Guid, Guid> TryGetPreviousCloneMapping();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> IEDFMMCBJHI);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FHHNLJBPEKJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool KJJIEMHCBBC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int JDAEDJMMLNN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> KNGLLKGNEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData IFKPOCGDKDB);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData IFKPOCGDKDB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OBIKBBMAEAN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T KDHDNCADFDJ, [Optional] DPIIANELJKL? KJMILHHGBID, bool IPEAIMMMEKD = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int DPKFLHPPNCH, IEnumerable<T> GPNEIINKPKB, bool IPEAIMMMEKD = true);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int DPKFLHPPNCH, IEnumerable<T> GPNEIINKPKB, DPIIANELJKL KJMILHHGBID, bool IPEAIMMMEKD = true);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NBDPEFNGJON
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BHGNJMGGBIH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool IMMDECADNMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool NCFBILHOMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool FLOJNCAJKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool ENJDPPKIJMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class IECOHACOMGH<TReceiver> : DONFMNEBKAG<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3292E90", Offset = "0x3291C90", VA = "0x183292E90")]
	public IECOHACOMGH(TReceiver LIOAKILKMJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class DGCOMLMIAOI<TReceiver, TFromTask> : DONFMNEBKAG<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3292E90", Offset = "0x3291C90", VA = "0x183292E90")]
	public DGCOMLMIAOI(TReceiver LIOAKILKMJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class DONFMNEBKAG<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver LIOAKILKMJA;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5050BE0", Offset = "0x504F9E0", VA = "0x185050BE0")]
	public DONFMNEBKAG(TReceiver LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute GEDDKJPLAEM();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class AMLHNBPOKGF<TReceiver, TResult> : DONFMNEBKAG<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3292E90", Offset = "0x3291C90", VA = "0x183292E90")]
	public AMLHNBPOKGF(TReceiver LIOAKILKMJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct JPMKOOGGJPN<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup AMGAAMGILBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData KIFMHLCBHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> GEFGDOHNIFF;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1ACD960", Offset = "0x1ACC760", VA = "0x181ACD960")]
	public JPMKOOGGJPN(TGroup NEJGEOJLBAA, TData BIFKILJDELD, IEnumerable<TData> NHHDGCEIAKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct KGEJLMIBBKL<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup AMGAAMGILBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> GEFGDOHNIFF;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8F0EC0", Offset = "0x8EFCC0", VA = "0x1808F0EC0")]
	public KGEJLMIBBKL(TGroup NEJGEOJLBAA, IEnumerable<TData> NHHDGCEIAKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct GPKPMIIIBLA<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup AMGAAMGILBP;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x9288D0", Offset = "0x9276D0", VA = "0x1809288D0")]
	public GPKPMIIIBLA(TGroup NEJGEOJLBAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct FECGALANIBN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> GEFGDOHNIFF;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9288D0", Offset = "0x9276D0", VA = "0x1809288D0")]
	public FECGALANIBN(IEnumerable<TData> NHHDGCEIAKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HNPMDJGFIBB<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AMCICLANCPL IEIHOCKGADL(JPMKOOGGJPN<TGroup, TData> LBLBFNNHJMA);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AMCICLANCPL GIBEJEFHGFE(JPMKOOGGJPN<TGroup, TData> LBLBFNNHJMA);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AMCICLANCPL AKDEJCDEBAB(KGEJLMIBBKL<TGroup, TData> LBLBFNNHJMA);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AMCICLANCPL GIBIHCOGDOF(GPKPMIIIBLA<TGroup> LBLBFNNHJMA);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface MKDIPLDGCCP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AMCICLANCPL> IEIHOCKGADL(FECGALANIBN<TData> LBLBFNNHJMA);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MFBKLPNDMAL<TGroup, TData> : AMLHNBPOKGF<HNPMDJGFIBB<TGroup, TData>, AMCICLANCPL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly KGEJLMIBBKL<TGroup, TData> LBLBFNNHJMA;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3E0F7D0", Offset = "0x3E0E5D0", VA = "0x183E0F7D0")]
	public MFBKLPNDMAL(TGroup NEJGEOJLBAA, IEnumerable<TData> NHHDGCEIAKO, HNPMDJGFIBB<TGroup, TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3E0F700", Offset = "0x3E0E500", VA = "0x183E0F700", Slot = "4")]
	public override AMCICLANCPL GEDDKJPLAEM()
	{
		return default(AMCICLANCPL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class EJJIKNFKMNG<TGroup, TData> : AMLHNBPOKGF<HNPMDJGFIBB<TGroup, TData>, AMCICLANCPL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly JPMKOOGGJPN<TGroup, TData> LBLBFNNHJMA;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x329C500", Offset = "0x329B300", VA = "0x18329C500")]
	public EJJIKNFKMNG(TGroup NEJGEOJLBAA, TData BMCMFJLHJFC, IEnumerable<TData> NHHDGCEIAKO, HNPMDJGFIBB<TGroup, TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x329C420", Offset = "0x329B220", VA = "0x18329C420", Slot = "4")]
	public override AMCICLANCPL GEDDKJPLAEM()
	{
		return default(AMCICLANCPL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DDJMPIKMBGG<TGroup, TData> : AMLHNBPOKGF<HNPMDJGFIBB<TGroup, TData>, AMCICLANCPL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly GPKPMIIIBLA<TGroup> LBLBFNNHJMA;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x36B6E20", Offset = "0x36B5C20", VA = "0x1836B6E20")]
	public DDJMPIKMBGG(TGroup NEJGEOJLBAA, HNPMDJGFIBB<TGroup, TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5027130", Offset = "0x5025F30", VA = "0x185027130", Slot = "4")]
	public override AMCICLANCPL GEDDKJPLAEM()
	{
		return default(AMCICLANCPL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class MPDPNEKAEEK<TGroup, TData> : AMLHNBPOKGF<HNPMDJGFIBB<TGroup, TData>, AMCICLANCPL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly JPMKOOGGJPN<TGroup, TData> LBLBFNNHJMA;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x329C500", Offset = "0x329B300", VA = "0x18329C500")]
	public MPDPNEKAEEK(TGroup NEJGEOJLBAA, TData BIFKILJDELD, IEnumerable<TData> NHHDGCEIAKO, HNPMDJGFIBB<TGroup, TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3E39930", Offset = "0x3E38730", VA = "0x183E39930", Slot = "4")]
	public override AMCICLANCPL GEDDKJPLAEM()
	{
		return default(AMCICLANCPL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class AABCNFONMDC<TData> : DGCOMLMIAOI<MKDIPLDGCCP<TData>, AMCICLANCPL> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct HHCIMJFAJKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<AMCICLANCPL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AABCNFONMDC<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<AMCICLANCPL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x37BAAB0", Offset = "0x37B98B0", VA = "0x1837BAAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x37BAD50", Offset = "0x37B9B50", VA = "0x1837BAD50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private FECGALANIBN<TData> LBLBFNNHJMA;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x36B6E20", Offset = "0x36B5C20", VA = "0x1836B6E20")]
	public AABCNFONMDC(IEnumerable<TData> MJJAEIDMKIO, MKDIPLDGCCP<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x36B6D20", Offset = "0x36B5B20", VA = "0x1836B6D20", Slot = "4")]
	[AsyncStateMachine(typeof(AABCNFONMDC<>.HHCIMJFAJKD))]
	public override Task<AMCICLANCPL> GEDDKJPLAEM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct AIKIAICLPJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly MFNODLICLDK CIAKNJKABKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool DHNCHBKGADF;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x611CDC0", Offset = "0x611BBC0", VA = "0x18611CDC0")]
	public AIKIAICLPJA(MFNODLICLDK LJDDHLCNKBG, bool KPIKHNGFDKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface ECLHGANBBIL<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> GEDDKJPLAEM(AIKIAICLPJA NBILHIAHEFO);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class NNEFKGEPGBB<TSpawnType> : DGCOMLMIAOI<ECLHGANBBIL<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct CIHGHLAODEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public NNEFKGEPGBB<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4C63BD0", Offset = "0x4C629D0", VA = "0x184C63BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x36EE760", Offset = "0x36ED560", VA = "0x1836EE760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly AIKIAICLPJA NBILHIAHEFO;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3EE3B70", Offset = "0x3EE2970", VA = "0x183EE3B70")]
	public NNEFKGEPGBB(MFNODLICLDK LJDDHLCNKBG, bool KPIKHNGFDKK, ECLHGANBBIL<TSpawnType> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3EE3870", Offset = "0x3EE2670", VA = "0x183EE3870", Slot = "4")]
	[AsyncStateMachine(typeof(NNEFKGEPGBB<>.CIHGHLAODEK))]
	public override Task<TSpawnType> GEDDKJPLAEM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct MFNODLICLDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool LFLOJDJBMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 ECAMAJBPDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 AEKKFHEKCOP;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x611DFB0", Offset = "0x611CDB0", VA = "0x18611DFB0")]
	public MFNODLICLDK(Transform BKLJEOAGBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x611DF80", Offset = "0x611CD80", VA = "0x18611DF80")]
	public MFNODLICLDK(Vector3 BKELBBDDNIG, Vector3 AJFNKFFNDBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x611DEC0", Offset = "0x611CCC0", VA = "0x18611DEC0")]
	public static MFNODLICLDK MAIDNGBLMAC()
	{
		return default(MFNODLICLDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x611DEF0", Offset = "0x611CCF0", VA = "0x18611DEF0")]
	private MFNODLICLDK(bool AEHDLOMHAFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct DOFKEKDEHCI<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode NEHJELIOHDG;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x504FA90", Offset = "0x504E890", VA = "0x18504FA90")]
	public DOFKEKDEHCI(TNode NEHJELIOHDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct LFPMOBPGKBN<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode KAMDLMPIHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public LHHJFPNDGAE DNAELHLJLHJ;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3C00950", Offset = "0x3BFF750", VA = "0x183C00950")]
	public LFPMOBPGKBN(TNode KAMDLMPIHLC, LHHJFPNDGAE DNAELHLJLHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface JDADNEHEHHG<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AGLEIFBEBFD([In] DOFKEKDEHCI<TNode> BOIEBLOJNAJ);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AFLIDDAGEBP([In] LFPMOBPGKBN<TNode> FMPKAMNHKKI);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AEJKBELLIMD();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class EAINLHIFLDG<TNode> : IECOHACOMGH<JDADNEHEHHG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3292E90", Offset = "0x3291C90", VA = "0x183292E90")]
	public EAINLHIFLDG(JDADNEHEHHG<TNode> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3292E40", Offset = "0x3291C40", VA = "0x183292E40", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class FPNJFDLBEFJ<TNode> : IECOHACOMGH<JDADNEHEHHG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly LFPMOBPGKBN<TNode> FMPKAMNHKKI;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3651FA0", Offset = "0x3650DA0", VA = "0x183651FA0")]
	public FPNJFDLBEFJ(TNode KAMDLMPIHLC, LHHJFPNDGAE DNAELHLJLHJ, JDADNEHEHHG<TNode> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3651ED0", Offset = "0x3650CD0", VA = "0x183651ED0", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class PDDCPEKEJDA<TNode> : IECOHACOMGH<JDADNEHEHHG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly DOFKEKDEHCI<TNode> BOIEBLOJNAJ;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x409B0A0", Offset = "0x4099EA0", VA = "0x18409B0A0")]
	public PDDCPEKEJDA(TNode GABPEPECHGP, JDADNEHEHHG<TNode> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x32B41A0", Offset = "0x32B2FA0", VA = "0x1832B41A0", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct OIDFKIBEKKC<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public TSpawnInfo LGEGJNAFCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Vector3 AJFNKFFNDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Quaternion OKEJHHGCFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float BJOKGACKCGO;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x40044A0", Offset = "0x40032A0", VA = "0x1840044A0")]
	public OIDFKIBEKKC(TSpawnInfo LGEGJNAFCKM, Vector3 AJFNKFFNDBD, Quaternion OKEJHHGCFPM, float BJOKGACKCGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface GJJIEINLAIP<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> LKMDPGOOJDI([In] OIDFKIBEKKC<TSpawnInfo> HOLLFNFBFPM, CancellationToken MBHHHCCHBAO);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class BKNFNDAMJOD<TSpawnType, TSpawnInfo> : DGCOMLMIAOI<GJJIEINLAIP<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly OIDFKIBEKKC<TSpawnInfo> LBACBNGIGEC;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x47C0070", Offset = "0x47BEE70", VA = "0x1847C0070")]
	public BKNFNDAMJOD(TSpawnInfo AJPCPIBJFJL, Vector3 AJFNKFFNDBD, Quaternion OKEJHHGCFPM, float BJOKGACKCGO, GJJIEINLAIP<TSpawnType, TSpawnInfo> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3B2EBB0", Offset = "0x3B2D9B0", VA = "0x183B2EBB0", Slot = "4")]
	public override Task<TSpawnType> GEDDKJPLAEM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct HDGGDFJHPGP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly IEnumerable<TData> GEFGDOHNIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly bool DHNCHBKGADF;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x37A7650", Offset = "0x37A6450", VA = "0x1837A7650")]
	public HDGGDFJHPGP(IEnumerable<TData> NHHDGCEIAKO, bool KPIKHNGFDKK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface AFCFFJMPNAG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AMCICLANCPL> AALGLLNMFLI([In] HDGGDFJHPGP<TData> EJPKAKKICCC, CancellationToken MBHHHCCHBAO);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class KODDODDNJGF<TData> : DGCOMLMIAOI<AFCFFJMPNAG<TData>, AMCICLANCPL> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HDGGDFJHPGP<TData> GHDILEDBGJF;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3B2ED20", Offset = "0x3B2DB20", VA = "0x183B2ED20")]
	public KODDODDNJGF(IEnumerable<TData> NHHDGCEIAKO, bool KPIKHNGFDKK, AFCFFJMPNAG<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3B2EBB0", Offset = "0x3B2D9B0", VA = "0x183B2EBB0", Slot = "4")]
	public override Task<AMCICLANCPL> GEDDKJPLAEM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct GAHADFCCGAB<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T EOCODFIAJEL;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3613B10", Offset = "0x3612910", VA = "0x183613B10")]
	public GAHADFCCGAB(T PBINGAEEGMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface IHLGLCOANPH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AGLEIFBEBFD([In] GAHADFCCGAB<T> ACDKPHHKABD);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AFLIDDAGEBP();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface BDAPEDDKKGG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GEDDKJPLAEM([In] LDFHCJOOIFA<T> KPICFLJLHLK);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct LDFHCJOOIFA<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T EOCODFIAJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly bool BPAGDBCMNFN;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3BFB960", Offset = "0x3BFA760", VA = "0x183BFB960")]
	public LDFHCJOOIFA(T PBINGAEEGMD, bool DAGEGKKFMIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class PFPHIJFNMPH<T> : IECOHACOMGH<IHLGLCOANPH<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3292E90", Offset = "0x3291C90", VA = "0x183292E90")]
	public PFPHIJFNMPH(IHLGLCOANPH<T> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x40A2670", Offset = "0x40A1470", VA = "0x1840A2670", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class LNABMHDHBIE<T> : IECOHACOMGH<IHLGLCOANPH<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly GAHADFCCGAB<T> ACDKPHHKABD;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3C3D3C0", Offset = "0x3C3C1C0", VA = "0x183C3D3C0")]
	public LNABMHDHBIE(T EOCODFIAJEL, IHLGLCOANPH<T> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x32B41A0", Offset = "0x32B2FA0", VA = "0x1832B41A0", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class DAFEGOFMMPI<T> : IECOHACOMGH<BDAPEDDKKGG<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly LDFHCJOOIFA<T> KPICFLJLHLK;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5017FC0", Offset = "0x5016DC0", VA = "0x185017FC0")]
	public DAFEGOFMMPI(T EOCODFIAJEL, bool DAGEGKKFMIF, BDAPEDDKKGG<T> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x32B41A0", Offset = "0x32B2FA0", VA = "0x1832B41A0", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct PFCFGIBMPDO<TData> where TData : notnull, GDDADJPOCEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public IEnumerable<TData> GEFGDOHNIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public bool JIGKHJABGLA;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x40A1900", Offset = "0x40A0700", VA = "0x1840A1900")]
	public PFCFGIBMPDO(IEnumerable<TData> PICLJEJMGBM, bool CDKKIJKJMKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct CDNEJMOAKHG<TData> where TData : notnull, GDDADJPOCEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public List<TData> GEFGDOHNIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<bool> AHOFMJOLLMG;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4B88FE0", Offset = "0x4B87DE0", VA = "0x184B88FE0")]
	public CDNEJMOAKHG(List<TData> PICLJEJMGBM, List<bool> GFGOIEBPGGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface GDDADJPOCEE
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool LIDLKNPNDIC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface CFEBOHGHGFP<TData> where TData : GDDADJPOCEE
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GEDDKJPLAEM([In] PFCFGIBMPDO<TData> OBAIKFAAGGM);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GEDDKJPLAEM([In] CDNEJMOAKHG<TData> OBAIKFAAGGM);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface MKPMHACPPDJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KAAEFPKGLFM(T EOCODFIAJEL);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class BEKCJFOOMIA<TData> : IECOHACOMGH<CFEBOHGHGFP<TData>> where TData : notnull, GDDADJPOCEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly PFCFGIBMPDO<TData> OBAIKFAAGGM;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x476C6F0", Offset = "0x476B4F0", VA = "0x18476C6F0")]
	public BEKCJFOOMIA(List<TData> NHHDGCEIAKO, bool JIGKHJABGLA, CFEBOHGHGFP<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x32B41A0", Offset = "0x32B2FA0", VA = "0x1832B41A0", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class EEGIEBEAMNN<TData> : IECOHACOMGH<CFEBOHGHGFP<TData>> where TData : notnull, GDDADJPOCEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly CDNEJMOAKHG<TData> OBAIKFAAGGM;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3295640", Offset = "0x3294440", VA = "0x183295640")]
	public EEGIEBEAMNN(List<TData> NHHDGCEIAKO, List<bool> AHOFMJOLLMG, CFEBOHGHGFP<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3295580", Offset = "0x3294380", VA = "0x183295580", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface KJPCLGNNGFN : GDDADJPOCEE
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface LNJJMLPJIMA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AMCICLANCPL> GEDDKJPLAEM(DLAAEIPPNKB<TData> GJACOKOHDPP);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class DCHLPBOCEHO<TData> : DGCOMLMIAOI<LNJJMLPJIMA<TData>, AMCICLANCPL> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct NICNALGMLBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<AMCICLANCPL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public DCHLPBOCEHO<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<AMCICLANCPL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3EB29C0", Offset = "0x3EB17C0", VA = "0x183EB29C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3EB2CB0", Offset = "0x3EB1AB0", VA = "0x183EB2CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly DLAAEIPPNKB<TData> NFGGEEADOKC;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x501FB60", Offset = "0x501E960", VA = "0x18501FB60")]
	public DCHLPBOCEHO(TData BIAEPIOBHLN, IReadOnlyList<TData> PGLJDNCOAEJ, bool KPIKHNGFDKK, LNJJMLPJIMA<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x501FA60", Offset = "0x501E860", VA = "0x18501FA60", Slot = "4")]
	[AsyncStateMachine(typeof(DCHLPBOCEHO<>.NICNALGMLBF))]
	public override Task<AMCICLANCPL> GEDDKJPLAEM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct DLAAEIPPNKB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public TData HEMKHFDFPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public IReadOnlyList<TData> AHECOGBFGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool DHNCHBKGADF;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4597650", Offset = "0x4596450", VA = "0x184597650")]
	public DLAAEIPPNKB(TData BIAEPIOBHLN, IReadOnlyList<TData> PGLJDNCOAEJ, bool KPIKHNGFDKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface LHHDLNFMGNC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GEDDKJPLAEM([In] GBAIPFMKHJM<TData> HKGJOEHCPHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface FEJCCFDLLHN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GEDDKJPLAEM([In] LHJPKJFLNNP<TData> HKGJOEHCPHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface NKDNPFLFHCK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GEBEBLFFJOO([In] LDNFHELKLKB<TData> HKGJOEHCPHJ);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFLIDDAGEBP();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class OHHJDCDBAOP<TData> : IECOHACOMGH<LHHDLNFMGNC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly GBAIPFMKHJM<TData> HKGJOEHCPHJ;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4003480", Offset = "0x4002280", VA = "0x184003480")]
	public OHHJDCDBAOP(IEnumerable<TData> NHHDGCEIAKO, JLAJJDNMAMO DNOKCMICDIP, FLBMFJMEEOH NLKDDMHEDOF, float HHAGHILCJFO, bool KPIKHNGFDKK, LHHDLNFMGNC<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x32B41A0", Offset = "0x32B2FA0", VA = "0x1832B41A0", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class BHGODOPFJAK<TData> : IECOHACOMGH<FEJCCFDLLHN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly LHJPKJFLNNP<TData> HKGJOEHCPHJ;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x477AFE0", Offset = "0x4779DE0", VA = "0x18477AFE0")]
	public BHGODOPFJAK(TData[] NHHDGCEIAKO, JLAJJDNMAMO[] DNOKCMICDIP, FLBMFJMEEOH[] NLKDDMHEDOF, float[] HHAGHILCJFO, FEJCCFDLLHN<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3731100", Offset = "0x372FF00", VA = "0x183731100", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class EKCINCGHBDI<TData> : IECOHACOMGH<NKDNPFLFHCK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3292E90", Offset = "0x3291C90", VA = "0x183292E90")]
	public EKCINCGHBDI(NKDNPFLFHCK<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x329EE00", Offset = "0x329DC00", VA = "0x18329EE00", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class GPDGBOHBINB<TData> : IECOHACOMGH<NKDNPFLFHCK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly LDNFHELKLKB<TData> HKGJOEHCPHJ;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x37311C0", Offset = "0x372FFC0", VA = "0x1837311C0")]
	public GPDGBOHBINB(IEnumerable<TData> NHHDGCEIAKO, JLAJJDNMAMO DNOKCMICDIP, FLBMFJMEEOH NLKDDMHEDOF, float HHAGHILCJFO, NKDNPFLFHCK<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3731100", Offset = "0x372FF00", VA = "0x183731100", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct GBAIPFMKHJM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public IEnumerable<TData> GEFGDOHNIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public JLAJJDNMAMO EPNBLEOPJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public FLBMFJMEEOH IGFAMDADIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public float HHAGHILCJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool KPIKHNGFDKK;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x36DDD80", Offset = "0x36DCB80", VA = "0x1836DDD80")]
	public GBAIPFMKHJM(IEnumerable<TData> NHHDGCEIAKO, JLAJJDNMAMO DNOKCMICDIP, FLBMFJMEEOH NLKDDMHEDOF, float HHAGHILCJFO, bool KPIKHNGFDKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct LHJPKJFLNNP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public TData[] GEFGDOHNIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public JLAJJDNMAMO[] EPNBLEOPJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public FLBMFJMEEOH[] IGFAMDADIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float[] HHAGHILCJFO;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3C1B220", Offset = "0x3C1A020", VA = "0x183C1B220")]
	public LHJPKJFLNNP(TData[] NHHDGCEIAKO, JLAJJDNMAMO[] DNOKCMICDIP, FLBMFJMEEOH[] NLKDDMHEDOF, float[] HHAGHILCJFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct LDNFHELKLKB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public IEnumerable<TData> GEFGDOHNIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public JLAJJDNMAMO EPNBLEOPJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public FLBMFJMEEOH IGFAMDADIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public float HHAGHILCJFO;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3BFF750", Offset = "0x3BFE550", VA = "0x183BFF750")]
	public LDNFHELKLKB(IEnumerable<TData> NHHDGCEIAKO, JLAJJDNMAMO DNOKCMICDIP, FLBMFJMEEOH NLKDDMHEDOF, float HHAGHILCJFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface JCLDGPEAHLO<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AKDEJCDEBAB([In] KEKCBEIFLCO<TData> EJPKAKKICCC);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GIBIHCOGDOF([In] KEKCBEIFLCO<TData> EJPKAKKICCC);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JMMKIMJBMIG([In] bool EPHAOHGDHNJ);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EOLCAMEOLBE([In] KEKCBEIFLCO<TData> EJPKAKKICCC);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PGPCKLHCDOJ();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LPCCIHPLELJ([In] TData OLLLBODJHMM);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class GDJADMCHBMO<TData> : IECOHACOMGH<JCLDGPEAHLO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly KEKCBEIFLCO<TData> EJPKAKKICCC;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x36EEA30", Offset = "0x36ED830", VA = "0x1836EEA30")]
	public GDJADMCHBMO(List<TData> EGCLMNAPIFL, JCLDGPEAHLO<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x32B41A0", Offset = "0x32B2FA0", VA = "0x1832B41A0", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class HJDLHMNKBMB<TData> : IECOHACOMGH<JCLDGPEAHLO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3292E90", Offset = "0x3291C90", VA = "0x183292E90")]
	public HJDLHMNKBMB(JCLDGPEAHLO<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x37C9E30", Offset = "0x37C8C30", VA = "0x1837C9E30", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class LCIDGPKEAEB<TData> : IECOHACOMGH<JCLDGPEAHLO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly bool KPIKHNGFDKK;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3BFAF90", Offset = "0x3BF9D90", VA = "0x183BFAF90")]
	public LCIDGPKEAEB(bool KPIKHNGFDKK, JCLDGPEAHLO<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3BFAF30", Offset = "0x3BF9D30", VA = "0x183BFAF30", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class GHCKFGIKOIH<TData> : IECOHACOMGH<JCLDGPEAHLO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly KEKCBEIFLCO<TData> EJPKAKKICCC;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3700110", Offset = "0x36FEF10", VA = "0x183700110")]
	public GHCKFGIKOIH(List<TData> EGCLMNAPIFL, bool KPIKHNGFDKK, JCLDGPEAHLO<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3295580", Offset = "0x3294380", VA = "0x183295580", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class FHFKGHAHFHG<TData> : IECOHACOMGH<JCLDGPEAHLO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly TData OLLLBODJHMM;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3604920", Offset = "0x3603720", VA = "0x183604920")]
	public FHFKGHAHFHG(TData OLLLBODJHMM, JCLDGPEAHLO<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3604850", Offset = "0x3603650", VA = "0x183604850", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class NDEFMPKILJF<TData> : IECOHACOMGH<JCLDGPEAHLO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly KEKCBEIFLCO<TData> EJPKAKKICCC;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3E845D0", Offset = "0x3E833D0", VA = "0x183E845D0")]
	public NDEFMPKILJF(IEnumerable<TData> EGCLMNAPIFL, JCLDGPEAHLO<TData> LIOAKILKMJA, bool KPIKHNGFDKK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3E84500", Offset = "0x3E83300", VA = "0x183E84500", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct KEKCBEIFLCO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public IEnumerable<TData> GEFGDOHNIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool KPIKHNGFDKK;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3B0F5D0", Offset = "0x3B0E3D0", VA = "0x183B0F5D0")]
	public KEKCBEIFLCO(IEnumerable<TData> PICLJEJMGBM, bool HHAGFJJPJEL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface GHDBDMEJFLA
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AMCICLANCPL> GEDDKJPLAEM(GPKOIPKDHGC OOGIBNFFCMF);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class AELBPOKIHJN : DGCOMLMIAOI<GHDBDMEJFLA, AMCICLANCPL>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct EEBGOKOMAKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AsyncTaskMethodBuilder<AMCICLANCPL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AELBPOKIHJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<AMCICLANCPL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x611D6E0", Offset = "0x611C4E0", VA = "0x18611D6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x611D960", Offset = "0x611C760", VA = "0x18611D960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly GPKOIPKDHGC FDCFLADPMMG;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x611CD60", Offset = "0x611BB60", VA = "0x18611CD60")]
	public AELBPOKIHJN(bool KPIKHNGFDKK, GHDBDMEJFLA LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x611CC70", Offset = "0x611BA70", VA = "0x18611CC70", Slot = "4")]
	[AsyncStateMachine(typeof(EEBGOKOMAKP))]
	public override Task<AMCICLANCPL> GEDDKJPLAEM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct GPKOIPKDHGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public bool DHNCHBKGADF;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xC8D8B0", Offset = "0xC8C6B0", VA = "0x180C8D8B0")]
	public GPKOIPKDHGC(bool KPIKHNGFDKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct FFIJFAKJJBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly bool DLCMPBODBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool OJFICLHPNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool BJOKGACKCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool KPIKHNGFDKK;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x45B0F40", Offset = "0x45AFD40", VA = "0x1845B0F40")]
	public FFIJFAKJJBH(bool DLCMPBODBPA, bool OJFICLHPNPC, bool BJOKGACKCGO, bool KPIKHNGFDKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x611DA10", Offset = "0x611C810", VA = "0x18611DA10")]
	public FFIJFAKJJBH(bool OJFICLHPNPC, bool KPIKHNGFDKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface NJGIIGABPAB
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EGFIJHJEJOG(FFIJFAKJJBH MAGPAOEDMFL);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FIOCMLECKCE(FFIJFAKJJBH MAGPAOEDMFL);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class JGNNMFIHDAJ : IECOHACOMGH<NJGIIGABPAB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly FFIJFAKJJBH MAGPAOEDMFL;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x611DDD0", Offset = "0x611CBD0", VA = "0x18611DDD0")]
	public JGNNMFIHDAJ(bool NBCGMJPEDEM, bool OJFICLHPNPC, bool BJOKGACKCGO, bool KPIKHNGFDKK, NJGIIGABPAB LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x611DD80", Offset = "0x611CB80", VA = "0x18611DD80", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class CNHDENGPHPP : IECOHACOMGH<NJGIIGABPAB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly FFIJFAKJJBH MAGPAOEDMFL;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x611D290", Offset = "0x611C090", VA = "0x18611D290")]
	public CNHDENGPHPP(bool OJFICLHPNPC, bool KPIKHNGFDKK, NJGIIGABPAB LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x611D240", Offset = "0x611C040", VA = "0x18611D240", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface AGLMPEGDBCI
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GEDDKJPLAEM([In] CKFEINJENFJ CDBPGLNEKDJ);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class NOHBPONIBPJ : IECOHACOMGH<AGLMPEGDBCI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly CKFEINJENFJ CDBPGLNEKDJ;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x611E0D0", Offset = "0x611CED0", VA = "0x18611E0D0")]
	public NOHBPONIBPJ(Guid[] OEDLACKFMFO, Vector3[] AKJHAJKDAOD, Quaternion[] KPPCMKLDFJJ, float[] LAMDCKMAKEM, Dictionary<Guid, Vector3> KEHHJGGBMIF, AGLMPEGDBCI LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x611E020", Offset = "0x611CE20", VA = "0x18611E020", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface OBPBGLPDCNF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AGLEIFBEBFD([In] OMNAEPIFAEH<TData> BOIEBLOJNAJ);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GEBEBLFFJOO([In] HGCHOBNJOON KOPBLKLGKHF);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GEBEBLFFJOO([In] KBKDEHBLGOF KOPBLKLGKHF);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AFLIDDAGEBP();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class CONCMPLGJEA<TData> : IECOHACOMGH<OBPBGLPDCNF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3292E90", Offset = "0x3291C90", VA = "0x183292E90")]
	public CONCMPLGJEA(OBPBGLPDCNF<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4D3D010", Offset = "0x4D3BE10", VA = "0x184D3D010", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class AIACEJAMFIH<TData> : IECOHACOMGH<OBPBGLPDCNF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly HGCHOBNJOON JNACKGAKJMN;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x38BF890", Offset = "0x38BE690", VA = "0x1838BF890")]
	public AIACEJAMFIH(Vector3 BKMKCAFHCFB, bool ADOBPBBGNCJ, OBPBGLPDCNF<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3860AD0", Offset = "0x385F8D0", VA = "0x183860AD0", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class HNHOLINOKLO<TData> : IECOHACOMGH<OBPBGLPDCNF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly KBKDEHBLGOF JNACKGAKJMN;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x37D99A0", Offset = "0x37D87A0", VA = "0x1837D99A0")]
	public HNHOLINOKLO(Guid IAJEPLNIPGP, int OHINPGIGDNE, Vector3 AJFNKFFNDBD, Quaternion OKEJHHGCFPM, float NOBKBEIDCKI, bool ADOBPBBGNCJ, OBPBGLPDCNF<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x37D9940", Offset = "0x37D8740", VA = "0x1837D9940", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class OLAJMOGLGJH<TData> : IECOHACOMGH<OBPBGLPDCNF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly OMNAEPIFAEH<TData> JNACKGAKJMN;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x400A4B0", Offset = "0x40092B0", VA = "0x18400A4B0")]
	public OLAJMOGLGJH(TData EOCODFIAJEL, bool KPIKHNGFDKK, OBPBGLPDCNF<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x32B41A0", Offset = "0x32B2FA0", VA = "0x1832B41A0", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct HGCHOBNJOON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly Vector3 BKMKCAFHCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly bool ADOBPBBGNCJ;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x611DC50", Offset = "0x611CA50", VA = "0x18611DC50")]
	public HGCHOBNJOON(Vector3 BKMKCAFHCFB, bool ADOBPBBGNCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct KBKDEHBLGOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly Guid IAJEPLNIPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly int OHINPGIGDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly Vector3 AJFNKFFNDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Quaternion OKEJHHGCFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly float NOBKBEIDCKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly bool ADOBPBBGNCJ;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x611DE60", Offset = "0x611CC60", VA = "0x18611DE60")]
	public KBKDEHBLGOF(Guid IAJEPLNIPGP, int OHINPGIGDNE, Vector3 AJFNKFFNDBD, Quaternion OKEJHHGCFPM, float NOBKBEIDCKI, bool ADOBPBBGNCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct OMNAEPIFAEH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly TData EOCODFIAJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly bool KPIKHNGFDKK;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x400E500", Offset = "0x400D300", VA = "0x18400E500")]
	public OMNAEPIFAEH(TData EOCODFIAJEL, bool KPIKHNGFDKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface OGFNKJGHDNH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GEDDKJPLAEM([In] DOCJLFGCJKI<TData> HMENPJKOEPL);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GEDDKJPLAEM([In] EEAJAIEAENH<TData> HMENPJKOEPL);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public interface EHOAMAGNFCI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AGLEIFBEBFD([In] CFMEJLEMPBI<TData> LOEDLECDPKI);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GEBEBLFFJOO([In] IIEEONGPNCH KOPBLKLGKHF);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AFLIDDAGEBP();
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class FHLDIOIPOME<TData> : IECOHACOMGH<OGFNKJGHDNH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly DOCJLFGCJKI<TData> HMENPJKOEPL;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x360D020", Offset = "0x360BE20", VA = "0x18360D020")]
	public FHLDIOIPOME(IEnumerable<TData> NHHDGCEIAKO, Vector3 AFNMMIHKEJC, bool KPIKHNGFDKK, OGFNKJGHDNH<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x32B41A0", Offset = "0x32B2FA0", VA = "0x1832B41A0", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class GLHBDNPFJMH<TData> : IECOHACOMGH<EHOAMAGNFCI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3292E90", Offset = "0x3291C90", VA = "0x183292E90")]
	public GLHBDNPFJMH(EHOAMAGNFCI<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3292E40", Offset = "0x3291C40", VA = "0x183292E40", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class EMMMEIPLFFJ<TData> : IECOHACOMGH<EHOAMAGNFCI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly CFMEJLEMPBI<TData> HMENPJKOEPL;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x32B4260", Offset = "0x32B3060", VA = "0x1832B4260")]
	public EMMMEIPLFFJ(IEnumerable<TData> NHHDGCEIAKO, bool KPIKHNGFDKK, EHOAMAGNFCI<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x32B41A0", Offset = "0x32B2FA0", VA = "0x1832B41A0", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class NJDKJDIAJGL<TData> : IECOHACOMGH<OGFNKJGHDNH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly EEAJAIEAENH<TData> HMENPJKOEPL;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3EB58E0", Offset = "0x3EB46E0", VA = "0x183EB58E0")]
	public NJDKJDIAJGL(IEnumerable<TData> NHHDGCEIAKO, Vector3 CNGOONAAINO, NPCALJGFCME MMCBBINMJNE, bool KPIKHNGFDKK, OGFNKJGHDNH<TData> LIOAKILKMJA, Space LEJLNLKEBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3651ED0", Offset = "0x3650CD0", VA = "0x183651ED0", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class MJDFMHHEEPM<TData> : IECOHACOMGH<EHOAMAGNFCI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly IIEEONGPNCH HMENPJKOEPL;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3E276F0", Offset = "0x3E264F0", VA = "0x183E276F0")]
	public MJDFMHHEEPM(Vector3 AFNMMIHKEJC, EHOAMAGNFCI<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3860AD0", Offset = "0x385F8D0", VA = "0x183860AD0", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct DOCJLFGCJKI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly IEnumerable<TData> NHHDGCEIAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly Vector3 AFNMMIHKEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly bool KPIKHNGFDKK;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x504F970", Offset = "0x504E770", VA = "0x18504F970")]
	public DOCJLFGCJKI(IEnumerable<TData> NHHDGCEIAKO, Vector3 AFNMMIHKEJC, bool KPIKHNGFDKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct CFMEJLEMPBI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly IEnumerable<TData> NHHDGCEIAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly bool KPIKHNGFDKK;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4C5FD30", Offset = "0x4C5EB30", VA = "0x184C5FD30")]
	public CFMEJLEMPBI(IEnumerable<TData> NHHDGCEIAKO, bool KPIKHNGFDKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct EEAJAIEAENH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly IEnumerable<TData> NHHDGCEIAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly Vector3 CNGOONAAINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly NPCALJGFCME MMCBBINMJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly bool KPIKHNGFDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly Space LEJLNLKEBNK;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3294A80", Offset = "0x3293880", VA = "0x183294A80")]
	public EEAJAIEAENH(IEnumerable<TData> NHHDGCEIAKO, Vector3 CNGOONAAINO, NPCALJGFCME MMCBBINMJNE, bool KPIKHNGFDKK, Space LEJLNLKEBNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct IIEEONGPNCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Vector3 AFNMMIHKEJC;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1F13900", Offset = "0x1F12700", VA = "0x181F13900")]
	public IIEEONGPNCH(Vector3 AFNMMIHKEJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public enum NPCALJGFCME
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface AODMHDJDLOO
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GEDDKJPLAEM([In] EODBBIBEEJM DCNOPLALMHF);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class IONLNCHPIBJ : IECOHACOMGH<AODMHDJDLOO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly EODBBIBEEJM DCNOPLALMHF;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x611DD20", Offset = "0x611CB20", VA = "0x18611DD20")]
	public IONLNCHPIBJ(bool KPIKHNGFDKK, AODMHDJDLOO LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x611DC70", Offset = "0x611CA70", VA = "0x18611DC70", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct EODBBIBEEJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly bool KPIKHNGFDKK;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0xC8D8B0", Offset = "0xC8C6B0", VA = "0x180C8D8B0")]
	public EODBBIBEEJM(bool KPIKHNGFDKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface LMLKKFBOOEL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GEDDKJPLAEM([In] MNOKFENCPLO<TData> NCNFAOLJGEF);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GEDDKJPLAEM([In] LOBBDNKOIPO<TData> NCNFAOLJGEF);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public interface HOFMBFGBECF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AGLEIFBEBFD([In] IBHFIGBFPBG<TData> BOIEBLOJNAJ);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GEBEBLFFJOO([In] BPADCIIBGOM KOPBLKLGKHF);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AFLIDDAGEBP();
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class CCJMOLKPJCA<TData> : IECOHACOMGH<LMLKKFBOOEL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly MNOKFENCPLO<TData> NCNFAOLJGEF;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4B82960", Offset = "0x4B81760", VA = "0x184B82960")]
	public CCJMOLKPJCA(IEnumerable<TData> NHHDGCEIAKO, Quaternion AFNMMIHKEJC, Vector3? MJBJLODHALC, bool GCCFIAKABNA, bool KPIKHNGFDKK, LMLKKFBOOEL<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x32B41A0", Offset = "0x32B2FA0", VA = "0x1832B41A0", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class ALDHOJCANFI<TData> : IECOHACOMGH<HOFMBFGBECF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3292E90", Offset = "0x3291C90", VA = "0x183292E90")]
	public ALDHOJCANFI(HOFMBFGBECF<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3292E40", Offset = "0x3291C40", VA = "0x183292E40", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class JEDIKDCBPKH<TData> : IECOHACOMGH<HOFMBFGBECF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly IBHFIGBFPBG<TData> NCNFAOLJGEF;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3A572B0", Offset = "0x3A560B0", VA = "0x183A572B0")]
	public JEDIKDCBPKH(IEnumerable<TData> NHHDGCEIAKO, bool KPIKHNGFDKK, HOFMBFGBECF<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x32B41A0", Offset = "0x32B2FA0", VA = "0x1832B41A0", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class INGKLBAKPCM<TData> : IECOHACOMGH<LMLKKFBOOEL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly LOBBDNKOIPO<TData> NCNFAOLJGEF;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x38A1370", Offset = "0x38A0170", VA = "0x1838A1370")]
	public INGKLBAKPCM(IEnumerable<TData> NHHDGCEIAKO, Quaternion HLEBNEBJJHB, NPCALJGFCME BGGCGKOEPEH, Vector3? MJBJLODHALC, bool GCCFIAKABNA, bool KPIKHNGFDKK, Space LEJLNLKEBNK, LMLKKFBOOEL<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3651ED0", Offset = "0x3650CD0", VA = "0x183651ED0", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class IBFGJKDOMBC<TData> : IECOHACOMGH<HOFMBFGBECF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly BPADCIIBGOM NCNFAOLJGEF;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3860B30", Offset = "0x385F930", VA = "0x183860B30")]
	public IBFGJKDOMBC(Quaternion AFNMMIHKEJC, Vector3? MJBJLODHALC, bool GCCFIAKABNA, HOFMBFGBECF<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3860AD0", Offset = "0x385F8D0", VA = "0x183860AD0", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct MNOKFENCPLO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly IEnumerable<TData> NHHDGCEIAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Quaternion AFNMMIHKEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Vector3? MJBJLODHALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly bool GCCFIAKABNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool KPIKHNGFDKK;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3E365B0", Offset = "0x3E353B0", VA = "0x183E365B0")]
	public MNOKFENCPLO(IEnumerable<TData> NHHDGCEIAKO, Quaternion AFNMMIHKEJC, Vector3? MJBJLODHALC, bool GCCFIAKABNA, bool KPIKHNGFDKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct IBHFIGBFPBG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly IEnumerable<TData> NHHDGCEIAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly bool KPIKHNGFDKK;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3860F20", Offset = "0x385FD20", VA = "0x183860F20")]
	public IBHFIGBFPBG(IEnumerable<TData> NHHDGCEIAKO, bool KPIKHNGFDKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct LOBBDNKOIPO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly IEnumerable<TData> NHHDGCEIAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly Quaternion HLEBNEBJJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly NPCALJGFCME BGGCGKOEPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly Vector3? MJBJLODHALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly bool GCCFIAKABNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool KPIKHNGFDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly Space LEJLNLKEBNK;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3C45A40", Offset = "0x3C44840", VA = "0x183C45A40")]
	public LOBBDNKOIPO(IEnumerable<TData> NHHDGCEIAKO, Quaternion HLEBNEBJJHB, NPCALJGFCME BGGCGKOEPEH, Vector3? MJBJLODHALC, bool GCCFIAKABNA, bool KPIKHNGFDKK, Space LEJLNLKEBNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct BPADCIIBGOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Quaternion AFNMMIHKEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Vector3? MJBJLODHALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly bool GCCFIAKABNA;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x457E110", Offset = "0x457CF10", VA = "0x18457E110")]
	public BPADCIIBGOM(Quaternion AFNMMIHKEJC, Vector3? MJBJLODHALC, bool GCCFIAKABNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface PKKGEBJMGDB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AGLEIFBEBFD([In] GHIPHAIDOFM<TData> BOIEBLOJNAJ);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GEBEBLFFJOO([In] EAMPEJANOPJ KOPBLKLGKHF);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GEBEBLFFJOO([In] LDPAHFJGFOO KOPBLKLGKHF);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GEBEBLFFJOO([In] FCLFMACEOKK KOPBLKLGKHF);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AFLIDDAGEBP();
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class DECPHNNDLFD<TData> : IECOHACOMGH<PKKGEBJMGDB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly FCLFMACEOKK KLCLIFODNBO;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x50363A0", Offset = "0x50351A0", VA = "0x1850363A0")]
	public DECPHNNDLFD(Vector3 FFCDLOMHLAF, float JMABOANLGPK, Vector3 MJBJLODHALC, bool DNDCLIMIEKH, bool HCIDJOCCGEF, PKKGEBJMGDB<TData> LIOAKILKMJA, Space LEJLNLKEBNK = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5036340", Offset = "0x5035140", VA = "0x185036340", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class MKNOFOIJLEE<TData> : IECOHACOMGH<PKKGEBJMGDB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3292E90", Offset = "0x3291C90", VA = "0x183292E90")]
	public MKNOFOIJLEE(PKKGEBJMGDB<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3E2D2C0", Offset = "0x3E2C0C0", VA = "0x183E2D2C0", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class DCFIEDFFHMO<TData> : IECOHACOMGH<PKKGEBJMGDB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly GHIPHAIDOFM<TData> KLCLIFODNBO;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x501F9D0", Offset = "0x501E7D0", VA = "0x18501F9D0")]
	public DCFIEDFFHMO(IEnumerable<TData> NHHDGCEIAKO, bool KPIKHNGFDKK, PKKGEBJMGDB<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x32B41A0", Offset = "0x32B2FA0", VA = "0x1832B41A0", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class CIEMEBAFPDM<TData> : IECOHACOMGH<PKKGEBJMGDB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly LDPAHFJGFOO KLCLIFODNBO;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4C626D0", Offset = "0x4C614D0", VA = "0x184C626D0")]
	public CIEMEBAFPDM(float NPODPJGJGMO, bool KCNDACANCHF, Vector3 MJBJLODHALC, PKKGEBJMGDB<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4C62600", Offset = "0x4C61400", VA = "0x184C62600", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class CEJKEBIKOAF<TData> : IECOHACOMGH<PKKGEBJMGDB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly EAMPEJANOPJ KLCLIFODNBO;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4C59010", Offset = "0x4C57E10", VA = "0x184C59010")]
	public CEJKEBIKOAF(float JMABOANLGPK, Vector3 MJBJLODHALC, PKKGEBJMGDB<TData> LIOAKILKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3860AD0", Offset = "0x385F8D0", VA = "0x183860AD0", Slot = "4")]
	public override bool GEDDKJPLAEM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct FCLFMACEOKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly Vector3 FFCDLOMHLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly float JMABOANLGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly Vector3 MJBJLODHALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly bool ADOBPBBGNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Space LEJLNLKEBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly bool HCIDJOCCGEF;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x611D9D0", Offset = "0x611C7D0", VA = "0x18611D9D0")]
	public FCLFMACEOKK(Vector3 FFCDLOMHLAF, float JMABOANLGPK, Vector3 MJBJLODHALC, bool ADOBPBBGNCJ, bool GEEPBCPDHCB, Space LEJLNLKEBNK = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct GHIPHAIDOFM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly IEnumerable<TData> NHHDGCEIAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly bool KPIKHNGFDKK;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x37025C0", Offset = "0x37013C0", VA = "0x1837025C0")]
	public GHIPHAIDOFM(IEnumerable<TData> NHHDGCEIAKO, bool KPIKHNGFDKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct LDPAHFJGFOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly float NPODPJGJGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly bool KCNDACANCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly Vector3 MJBJLODHALC;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x611DEA0", Offset = "0x611CCA0", VA = "0x18611DEA0")]
	public LDPAHFJGFOO(float NPODPJGJGMO, bool KCNDACANCHF, Vector3 MJBJLODHALC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct EAMPEJANOPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly float JMABOANLGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly Vector3 MJBJLODHALC;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4552160", Offset = "0x4550F60", VA = "0x184552160")]
	public EAMPEJANOPJ(float JMABOANLGPK, Vector3 MJBJLODHALC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct CKFEINJENFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Guid[] NHHDGCEIAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly bool HAAMEIPJJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool LMAPKAFDKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool MMENHFPFHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly Vector3[] AKJHAJKDAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Quaternion[] KPPCMKLDFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly float[] LAMDCKMAKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Dictionary<Guid, Vector3> KEHHJGGBMIF;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x611CFB0", Offset = "0x611BDB0", VA = "0x18611CFB0")]
	public CKFEINJENFJ(Guid[] OEDLACKFMFO, Vector3[] AKJHAJKDAOD, Quaternion[] KPPCMKLDFJJ, float[] LAMDCKMAKEM, Dictionary<Guid, Vector3> KEHHJGGBMIF, bool HAAMEIPJJNN = true, bool LMAPKAFDKME = true, bool MMENHFPFHPD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x611CDE0", Offset = "0x611BBE0", VA = "0x18611CDE0")]
	private static void GGCGMGOELDJ(Dictionary<Guid, Vector3> KEHHJGGBMIF, int PGHAOMGLJKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class ECOEFIMEINM
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private struct JEIPMOBOGIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool KPKHJPBCKJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public CMADEFPIMOE KMFHKLMAKEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public CMADEFPIMOE OCMGBFPEHMB;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static JEIPMOBOGIL FNGEJNAMGEG;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken JJJEGJONNGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x611D620", Offset = "0x611C420", VA = "0x18611D620")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static CMADEFPIMOE KMFHKLMAKEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x611D640", Offset = "0x611C440", VA = "0x18611D640")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x611D310", Offset = "0x611C110", VA = "0x18611D310")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x611D4D0", Offset = "0x611C2D0", VA = "0x18611D4D0")]
	[HBAMLEIOGOF(EOCHJKOJDMN.Room, BHCECOANHAK.None)]
	private static void GJIOLPICKKJ(CMADEFPIMOE IACLDNGEKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x611D380", Offset = "0x611C180", VA = "0x18611D380")]
	public static void BMDNDNAFIJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x611D5D0", Offset = "0x611C3D0", VA = "0x18611D5D0")]
	private static CMADEFPIMOE IAJBLMGFBAK(CMADEFPIMOE BIHHCHIDNDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public static class JMHENDOJCEA
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public enum IEODCLEBOFB
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x27B6AB0", Offset = "0x27B58B0", VA = "0x1827B6AB0")]
	public static void PNLEEPIKNLG<T>(T DIPPNLOGDJL, IEODCLEBOFB LPFFKBBBCBL) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x27B6A50", Offset = "0x27B5850", VA = "0x1827B6A50")]
	public static void PNLEEPIKNLG<T>(T DIPPNLOGDJL) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x27B69E0", Offset = "0x27B57E0", VA = "0x1827B69E0")]
	public static void NJDMNPNPIPE<T>(T DIPPNLOGDJL) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x27B6940", Offset = "0x27B5740", VA = "0x1827B6940")]
	public static T MHEOMGMBJHC<T>(IEODCLEBOFB LPFFKBBBCBL) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x27B6690", Offset = "0x27B5490", VA = "0x1827B6690")]
	public static bool CCEPLMLEFMB<T>(IEODCLEBOFB LPFFKBBBCBL, T LBEFHAMIBKN, [Out] T AOLPHEMIDDK) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x27B68A0", Offset = "0x27B56A0", VA = "0x1827B68A0")]
	public static bool ENBLHLEPPLK<T>(IEODCLEBOFB LPFFKBBBCBL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x27B6860", Offset = "0x27B5660", VA = "0x1827B6860")]
	public static T MHEOMGMBJHC<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x27B67C0", Offset = "0x27B55C0", VA = "0x1827B67C0")]
	public static bool CCEPLMLEFMB<T>(T LBEFHAMIBKN, [Out] T AOLPHEMIDDK) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x27B6860", Offset = "0x27B5660", VA = "0x1827B6860")]
	public static bool ENBLHLEPPLK<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class GBIDGIMGACG
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x611DA20", Offset = "0x611C820", VA = "0x18611DA20")]
	public static void EOJKEJJDJMM(IEnumerable HABLADAFBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x273BDB0", Offset = "0x273ABB0", VA = "0x18273BDB0")]
	public static void EOJKEJJDJMM<T>(T[] HHAMBPGBENG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x273BEA0", Offset = "0x273ACA0", VA = "0x18273BEA0")]
	public static void EOJKEJJDJMM<T>(T HNNEPCFDHAJ) where T : notnull, Enum
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

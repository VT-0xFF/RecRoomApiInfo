using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40")]
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
		[Cpp2IlInjected.Address(RVA = "0xEB5E00", Offset = "0xEB5000", VA = "0x180EB5E00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6E26F0", Offset = "0x6E18F0", VA = "0x1806E26F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9116C0", Offset = "0x9108C0", VA = "0x1809116C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GMMELGALFHH<TData> : HHBHODKPECL, global::LBNMGLHEBGP<TData>, global::GCLOHLAEJAG<TData>, global::ELBGLCIGIDH<TData>, global::CHPDCKGMLHF<TData>
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CHPDCKGMLHF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 KEAOCNJGPED, Vector3 HHOIMIMHDMP, float KMAOMDJLDEN, out T ANLFFGILJNN, out Vector3 HFELMFJPDDD, out Collider PBKPKOLGIPE);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 KEAOCNJGPED, Vector3 HHOIMIMHDMP, float ECCLMMNLHIJ, float KMAOMDJLDEN, T[] FKPFCKACJGC, out Vector3 PMGGHGBDKCD, out Collider KEOGBDBAGMB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 KEAOCNJGPED, float ECCLMMNLHIJ, Vector3 JGJDEPGPPBH, T[] FKPFCKACJGC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HHBHODKPECL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds KJCHKKFJBHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform DAFCMCJBGIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds PPIIBMNELAB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform NCCDGJDJLNO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 LJIGIJJFHBD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface ELBGLCIGIDH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KIAEHCKHKJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int DICKEBDDJNK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IEnumerable<TData> COLGDGNEBCO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData KDBGGIOGPDM);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LBNMGLHEBGP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T ADHHHFDPAPI, [Optional] KLPDLCDIGKD? FKALJJLAGGK, bool IEOJLDKJBBP = true);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int OCCKKIPCFBH, IEnumerable<T> HGLAIHECBOI, bool IEOJLDKJBBP = true);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int OCCKKIPCFBH, IEnumerable<T> HGLAIHECBOI, KLPDLCDIGKD FKALJJLAGGK, bool IEOJLDKJBBP = true);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct CDCCJBODEMB<TData> where TData : notnull, EKCKIAHEBKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public IEnumerable<TData> JOGDIEECCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public bool DJOMEFBCHHJ;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3BD3E10", Offset = "0x3BD3010", VA = "0x183BD3E10")]
	public CDCCJBODEMB(IEnumerable<TData> KLBPBOPEBHH, bool PKMMABHMACJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EKCKIAHEBKB
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool OGOBOPCNLHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GBEGBIBHIPC<TData> where TData : EKCKIAHEBKB
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GIOENJDGHHK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x68E880", Offset = "0x68DC80")] in global::CDCCJBODEMB<TData> JPLFGJOCAHD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x68E8F0", Offset = "0x68DCF0")]
public class PCIELEPKLAA<TData> : global::PAOKFDDBMPO<global::GBEGBIBHIPC<TData>> where TData : notnull, EKCKIAHEBKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x68E960", Offset = "0x68DD60")]
	private readonly global::CDCCJBODEMB<TData> JPLFGJOCAHD;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2698C70", Offset = "0x2697E70", VA = "0x182698C70")]
	public PCIELEPKLAA(List<TData> ONBEDFCJOLM, bool DJOMEFBCHHJ, global::GBEGBIBHIPC<TData> DAACGBFECDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2698BB0", Offset = "0x2697DB0", VA = "0x182698BB0", Slot = "4")]
	public override bool GIOENJDGHHK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LMIGDDOJKFI : EKCKIAHEBKB
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class PAOKFDDBMPO<TReceiver> where TReceiver : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected TReceiver DAACGBFECDE;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2692FA0", Offset = "0x26921A0", VA = "0x182692FA0")]
	public PAOKFDDBMPO(TReceiver DAACGBFECDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool GIOENJDGHHK();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GCLOHLAEJAG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KICNIEODKGM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x68E9C0", Offset = "0x68DDC0")] in global::OPCKFKBNCKK<TData> PNNALIABBDN);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IACHADKBOAD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x68EA30", Offset = "0x68DE30")] in global::OPCKFKBNCKK<TData> PNNALIABBDN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JBDJGMLPMAB(in bool HJGMHFCADHN);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GDACOIAAECE();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BCAPEEODFDL(TData ACHOENKPFHI);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x68EAA0", Offset = "0x68DEA0")]
public class GCFJMKHLPNG<TData> : global::PAOKFDDBMPO<global::GCLOHLAEJAG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x68EB10", Offset = "0x68DF10")]
	private readonly global::OPCKFKBNCKK<TData> PNNALIABBDN;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2BABB30", Offset = "0x2BAAD30", VA = "0x182BABB30")]
	public GCFJMKHLPNG(List<TData> BNOEJJNBJCK, bool CGIEOIKPFCC, global::GCLOHLAEJAG<TData> DAACGBFECDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2698BB0", Offset = "0x2697DB0", VA = "0x182698BB0", Slot = "4")]
	public override bool GIOENJDGHHK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x68EB70", Offset = "0x68DF70")]
public class MOBEIACMLAD<TData> : global::PAOKFDDBMPO<global::GCLOHLAEJAG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2356910", Offset = "0x2355B10", VA = "0x182356910")]
	public MOBEIACMLAD(global::GCLOHLAEJAG<TData> DAACGBFECDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3084D20", Offset = "0x3083F20", VA = "0x183084D20", Slot = "4")]
	public override bool GIOENJDGHHK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x68EBE0", Offset = "0x68DFE0")]
public class OJPCFLMGNLN<TData> : global::PAOKFDDBMPO<global::GCLOHLAEJAG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly bool CGIEOIKPFCC;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x264CA00", Offset = "0x264BC00", VA = "0x18264CA00")]
	public OJPCFLMGNLN(bool CGIEOIKPFCC, global::GCLOHLAEJAG<TData> DAACGBFECDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x264C990", Offset = "0x264BB90", VA = "0x18264C990", Slot = "4")]
	public override bool GIOENJDGHHK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x68EC50", Offset = "0x68E050")]
public class JEDCCHAAPHK<TData> : global::PAOKFDDBMPO<global::GCLOHLAEJAG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x68ECC0", Offset = "0x68E0C0")]
	private readonly global::OPCKFKBNCKK<TData> PNNALIABBDN;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2BABB30", Offset = "0x2BAAD30", VA = "0x182BABB30")]
	public JEDCCHAAPHK(List<TData> BNOEJJNBJCK, bool CGIEOIKPFCC, global::GCLOHLAEJAG<TData> DAACGBFECDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x30CC370", Offset = "0x30CB570", VA = "0x1830CC370", Slot = "4")]
	public override bool GIOENJDGHHK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x68ED20", Offset = "0x68E120")]
public class IEIIGGNGOMC<TData> : global::PAOKFDDBMPO<global::GCLOHLAEJAG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly TData ACHOENKPFHI;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1F67830", Offset = "0x1F66A30", VA = "0x181F67830")]
	public IEIIGGNGOMC(TData ACHOENKPFHI, global::GCLOHLAEJAG<TData> DAACGBFECDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1F67650", Offset = "0x1F66850", VA = "0x181F67650", Slot = "4")]
	public override bool GIOENJDGHHK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct OPCKFKBNCKK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public IEnumerable<TData> JOGDIEECCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public bool CGIEOIKPFCC;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2657440", Offset = "0x2656640", VA = "0x182657440")]
	public OPCKFKBNCKK(IEnumerable<TData> KLBPBOPEBHH, bool KOOBAEHMDPM)
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

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
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780")]
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
		[Cpp2IlInjected.Address(RVA = "0x18F0750", Offset = "0x18EFB50", VA = "0x1818F0750")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72ABD0", Offset = "0x729FD0", VA = "0x18072ABD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xC60960", Offset = "0xC5FD60", VA = "0x180C60960")]
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
	[Cpp2IlInjected.Address(RVA = "0x3368AB0", Offset = "0x3367EB0", VA = "0x183368AB0")]
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
	bool GIOENJDGHHK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x68BE20", Offset = "0x68B220")] in global::CDCCJBODEMB<TData> JPLFGJOCAHD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x68BE90", Offset = "0x68B290")]
public class PCIELEPKLAA<TData> : global::PAOKFDDBMPO<global::GBEGBIBHIPC<TData>> where TData : notnull, EKCKIAHEBKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x68BF00", Offset = "0x68B300")]
	private readonly global::CDCCJBODEMB<TData> JPLFGJOCAHD;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3360F00", Offset = "0x3360300", VA = "0x183360F00")]
	public PCIELEPKLAA(List<TData> ONBEDFCJOLM, bool DJOMEFBCHHJ, global::GBEGBIBHIPC<TData> DAACGBFECDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3360E40", Offset = "0x3360240", VA = "0x183360E40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x335B730", Offset = "0x335AB30", VA = "0x18335B730")]
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
	bool KICNIEODKGM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x68BF60", Offset = "0x68B360")] in global::OPCKFKBNCKK<TData> PNNALIABBDN);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IACHADKBOAD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x68BFD0", Offset = "0x68B3D0")] in global::OPCKFKBNCKK<TData> PNNALIABBDN);

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
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x68C040", Offset = "0x68B440")]
public class GCFJMKHLPNG<TData> : global::PAOKFDDBMPO<global::GCLOHLAEJAG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x68C0B0", Offset = "0x68B4B0")]
	private readonly global::OPCKFKBNCKK<TData> PNNALIABBDN;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x36A5A80", Offset = "0x36A4E80", VA = "0x1836A5A80")]
	public GCFJMKHLPNG(List<TData> BNOEJJNBJCK, bool CGIEOIKPFCC, global::GCLOHLAEJAG<TData> DAACGBFECDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3360E40", Offset = "0x3360240", VA = "0x183360E40", Slot = "4")]
	public override bool GIOENJDGHHK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x68C110", Offset = "0x68B510")]
public class MOBEIACMLAD<TData> : global::PAOKFDDBMPO<global::GCLOHLAEJAG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x27ACBD0", Offset = "0x27ABFD0", VA = "0x1827ACBD0")]
	public MOBEIACMLAD(global::GCLOHLAEJAG<TData> DAACGBFECDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3FC6180", Offset = "0x3FC5580", VA = "0x183FC6180", Slot = "4")]
	public override bool GIOENJDGHHK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x68C180", Offset = "0x68B580")]
public class OJPCFLMGNLN<TData> : global::PAOKFDDBMPO<global::GCLOHLAEJAG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly bool CGIEOIKPFCC;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2DF88B0", Offset = "0x2DF7CB0", VA = "0x182DF88B0")]
	public OJPCFLMGNLN(bool CGIEOIKPFCC, global::GCLOHLAEJAG<TData> DAACGBFECDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2DF8840", Offset = "0x2DF7C40", VA = "0x182DF8840", Slot = "4")]
	public override bool GIOENJDGHHK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x68C1F0", Offset = "0x68B5F0")]
public class JEDCCHAAPHK<TData> : global::PAOKFDDBMPO<global::GCLOHLAEJAG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x68C260", Offset = "0x68B660")]
	private readonly global::OPCKFKBNCKK<TData> PNNALIABBDN;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x36A5A80", Offset = "0x36A4E80", VA = "0x1836A5A80")]
	public JEDCCHAAPHK(List<TData> BNOEJJNBJCK, bool CGIEOIKPFCC, global::GCLOHLAEJAG<TData> DAACGBFECDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3AACED0", Offset = "0x3AAC2D0", VA = "0x183AACED0", Slot = "4")]
	public override bool GIOENJDGHHK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x68C2C0", Offset = "0x68B6C0")]
public class IEIIGGNGOMC<TData> : global::PAOKFDDBMPO<global::GCLOHLAEJAG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly TData ACHOENKPFHI;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x27BE2E0", Offset = "0x27BD6E0", VA = "0x1827BE2E0")]
	public IEIIGGNGOMC(TData ACHOENKPFHI, global::GCLOHLAEJAG<TData> DAACGBFECDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x27BE100", Offset = "0x27BD500", VA = "0x1827BE100", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E03580", Offset = "0x2E02980", VA = "0x182E03580")]
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

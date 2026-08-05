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
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x21E75B0", Offset = "0x21E63B0", VA = "0x1821E75B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9F7FC0", Offset = "0x9F6DC0", VA = "0x1809F7FC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x106BC90", Offset = "0x106AA90", VA = "0x18106BC90")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LAPMJGCPAPP<TData> : GLJMCLAHONH, global::NODACEELJIG<TData>, global::BPAMDPGHEOF<TData>, global::KEEGGEFKNLK<TData>, global::AHMNKANPKPJ<TData>
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface AHMNKANPKPJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 MEFJJPHNCLK, Vector3 EDKNJDMPJNA, float LEEANLGODCO, out T PJAPNCGMMKP, out Vector3 PCOEMAEFAMM, out Collider FGKICBFJOFG);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 MEFJJPHNCLK, Vector3 EDKNJDMPJNA, float NLJBEOJPAFN, float LEEANLGODCO, T[] HENDGOGCDIE, out Vector3 CLGHADDKKHD, out Collider CLKIOBBKCCP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 MEFJJPHNCLK, float NLJBEOJPAFN, Vector3 KMKPJIPBELB, T[] HENDGOGCDIE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GLJMCLAHONH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds OIGFHOMDDDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform NKMCNEKFPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds AAAOJBEAIKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform NKPBJGMCOHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 EBNFJLFBHLP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KEEGGEFKNLK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool CGCFMLEDIKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int ODIEPCBMADG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IEnumerable<TData> LMHFOELHGJA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData BKCHCEAGIMD);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NODACEELJIG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T LOPIEGGIDMF, [Optional] NKMOLDEJHMN? KJBGNDOMAJI, bool ICLEOEDIJJH = true);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int KNPCAAMBLKA, IEnumerable<T> NHMINHLCPGH, bool ICLEOEDIJJH = true);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int KNPCAAMBLKA, IEnumerable<T> NHMINHLCPGH, NKMOLDEJHMN KJBGNDOMAJI, bool ICLEOEDIJJH = true);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct NIDOLCJBJCF<TData> where TData : notnull, PIDDMCLFGEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public IEnumerable<TData> DFCJINOGFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public bool IAPLCMAMLJC;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x39578C0", Offset = "0x39566C0", VA = "0x1839578C0")]
	public NIDOLCJBJCF(IEnumerable<TData> JHODKCMBAAM, bool LLHLAOBCDAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PIDDMCLFGEL
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool MIMCDBAMHFP
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
public interface PHKADFGHOJE<TData> where TData : PIDDMCLFGEL
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AKGEHNPGMIG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x18FCF0", Offset = "0x18F0F0")] in global::NIDOLCJBJCF<TData> HNHLEIBJNAD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x18FD60", Offset = "0x18F160")]
public class AGCNIPMPAJF<TData> : global::MHBJGJPHKIP<global::PHKADFGHOJE<TData>> where TData : notnull, PIDDMCLFGEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x18FDD0", Offset = "0x18F1D0")]
	private readonly global::NIDOLCJBJCF<TData> HNHLEIBJNAD;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x40B44C0", Offset = "0x40B32C0", VA = "0x1840B44C0")]
	public AGCNIPMPAJF(List<TData> OPLHGOAOFIH, bool IAPLCMAMLJC, global::PHKADFGHOJE<TData> JKEAIGMKJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x38CF570", Offset = "0x38CE370", VA = "0x1838CF570", Slot = "4")]
	public override bool AKGEHNPGMIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OFKIJAENIEM : PIDDMCLFGEL
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class MHBJGJPHKIP<TReceiver> where TReceiver : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected TReceiver JKEAIGMKJOM;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3A6B4E0", Offset = "0x3A6A2E0", VA = "0x183A6B4E0")]
	public MHBJGJPHKIP(TReceiver JKEAIGMKJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool AKGEHNPGMIG();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface BPAMDPGHEOF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CMGPPMPMIHH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x18FE30", Offset = "0x18F230")] in global::GPIGONDKABI<TData> NOIJBGAPJIA);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LBGEOJMKFGH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x18FEA0", Offset = "0x18F2A0")] in global::GPIGONDKABI<TData> NOIJBGAPJIA);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BBLJANEBKLH(in bool EHABIBPLAOJ);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PNOIKEGGGIB();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PJMAIJOBCGD(TData HECHEKPKPDM);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x18FF10", Offset = "0x18F310")]
public class BNLHOMADJDH<TData> : global::MHBJGJPHKIP<global::BPAMDPGHEOF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x18FF80", Offset = "0x18F380")]
	private readonly global::GPIGONDKABI<TData> NOIJBGAPJIA;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x38CF6D0", Offset = "0x38CE4D0", VA = "0x1838CF6D0")]
	public BNLHOMADJDH(List<TData> JAODPABODGA, bool AEPEIGFCKJG, global::BPAMDPGHEOF<TData> JKEAIGMKJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x38CF570", Offset = "0x38CE370", VA = "0x1838CF570", Slot = "4")]
	public override bool AKGEHNPGMIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x18FFE0", Offset = "0x18F3E0")]
public class HKMABGALAAL<TData> : global::MHBJGJPHKIP<global::BPAMDPGHEOF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3262220", Offset = "0x3261020", VA = "0x183262220")]
	public HKMABGALAAL(global::BPAMDPGHEOF<TData> JKEAIGMKJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x393F4F0", Offset = "0x393E2F0", VA = "0x18393F4F0", Slot = "4")]
	public override bool AKGEHNPGMIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x190050", Offset = "0x18F450")]
public class FJDNNELNAFG<TData> : global::MHBJGJPHKIP<global::BPAMDPGHEOF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly bool AEPEIGFCKJG;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4018A60", Offset = "0x4017860", VA = "0x184018A60")]
	public FJDNNELNAFG(bool AEPEIGFCKJG, global::BPAMDPGHEOF<TData> JKEAIGMKJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x40189F0", Offset = "0x40177F0", VA = "0x1840189F0", Slot = "4")]
	public override bool AKGEHNPGMIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x1900C0", Offset = "0x18F4C0")]
public class ABJMJAAAPBP<TData> : global::MHBJGJPHKIP<global::BPAMDPGHEOF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x190130", Offset = "0x18F530")]
	private readonly global::GPIGONDKABI<TData> NOIJBGAPJIA;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x38CF6D0", Offset = "0x38CE4D0", VA = "0x1838CF6D0")]
	public ABJMJAAAPBP(List<TData> JAODPABODGA, bool AEPEIGFCKJG, global::BPAMDPGHEOF<TData> JKEAIGMKJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x40AB0C0", Offset = "0x40A9EC0", VA = "0x1840AB0C0", Slot = "4")]
	public override bool AKGEHNPGMIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x190190", Offset = "0x18F590")]
public class DGCLDJBOGMB<TData> : global::MHBJGJPHKIP<global::BPAMDPGHEOF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly TData HECHEKPKPDM;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3FF6E30", Offset = "0x3FF5C30", VA = "0x183FF6E30")]
	public DGCLDJBOGMB(TData HECHEKPKPDM, global::BPAMDPGHEOF<TData> JKEAIGMKJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3FF6C90", Offset = "0x3FF5A90", VA = "0x183FF6C90", Slot = "4")]
	public override bool AKGEHNPGMIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct GPIGONDKABI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public IEnumerable<TData> DFCJINOGFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public bool AEPEIGFCKJG;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4B4DAB0", Offset = "0x4B4C8B0", VA = "0x184B4DAB0")]
	public GPIGONDKABI(IEnumerable<TData> JHODKCMBAAM, bool IACMIKAHGFL)
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

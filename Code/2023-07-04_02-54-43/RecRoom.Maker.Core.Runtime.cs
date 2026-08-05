using System;
using System.Collections;
using System.Collections.Generic;
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
		[Cpp2IlInjected.Address(RVA = "0x956600", Offset = "0x954C00", VA = "0x180956600")]
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
		[Cpp2IlInjected.Address(RVA = "0x7242130", Offset = "0x7240730", VA = "0x187242130")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xBD9AB0", Offset = "0xBD80B0", VA = "0x180BD9AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xEA93B0", Offset = "0xEA79B0", VA = "0x180EA93B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x743B10", Offset = "0x742F10")]
public class IIHEFLPFINI<TData> : BMLGEEKNPHA<KAINODKDGKH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly GJCMFPPGNBM OEGNJKICNAD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF870", Offset = "0x1FEDE70", VA = "0x181FEF870")]
	public IIHEFLPFINI(Vector3 IFKNBJHNPMM, bool MGNJODFELDA, KAINODKDGKH<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF800", Offset = "0x1FEDE00", VA = "0x181FEF800", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct JMMCIIMIJPM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public IEnumerable<TData> ENDMNGNNLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public bool PAHHLPMEAGI;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2E70A60", Offset = "0x2E6F060", VA = "0x182E70A60")]
	public JMMCIIMIJPM(IEnumerable<TData> LGDNKCHLEFC, bool NPJFDJKFAEE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HKKDIHIKPDJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NHHGDAILMCF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x743BC0", Offset = "0x742FC0")] in ACCIIHJIJNF<TData?> IKKLIMOLAKM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OJNPPAKIFAD(in MLHOIOGNKEP OFDOBMJDFBL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OJNPPAKIFAD(in NPOFKKODHLL OFDOBMJDFBL);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EMJLNMEIJMJ();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct KPGJJGIALIP<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public TNode BPLKCNPLGAA;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x334E700", Offset = "0x334CD00", VA = "0x18334E700")]
	public KPGJJGIALIP(TNode BPLKCNPLGAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct HKNHCOFMMAL<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TNode PCBFNJJBLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public LHLNNIPFCNL GGMIEDJJIHL;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2E320D0", Offset = "0x2E306D0", VA = "0x182E320D0")]
	public HKNHCOFMMAL(TNode PCBFNJJBLFA, LHLNNIPFCNL GGMIEDJJIHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x743C30", Offset = "0x743030")]
public class DKPNIDAEALK<TData> : BMLGEEKNPHA<BGGBAOHKCHA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x743CA0", Offset = "0x7430A0")]
	private readonly JMMCIIMIJPM<TData> MIFDDBEPADK;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2F1EEB0", Offset = "0x2F1D4B0", VA = "0x182F1EEB0")]
	public DKPNIDAEALK(List<TData> NEGBPLHGJID, BGGBAOHKCHA<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1651FF0", Offset = "0x16505F0", VA = "0x181651FF0", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DJCELNOKGKM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INMPCLDOECM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x743D00", Offset = "0x743100")] in EIJOJPDGPAN<TData?> KCNHBOLMBOP);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KAPLGAMDOJK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> ENDMNGNNLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public GJALNGNNDJP NCILMPDNAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public FGDIOILOGNO NKGKBLOKJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float OEFGJJAMKBE;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2332A40", Offset = "0x2331040", VA = "0x182332A40")]
	public KAPLGAMDOJK(IEnumerable<TData> JANBNIKCNJC, GJALNGNNDJP OOJLGEBJDPI, FGDIOILOGNO GMIIJPABJKD, float OEFGJJAMKBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal static class CBLECODPOMN
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7241A00", Offset = "0x7240000", VA = "0x187241A00")]
	public static void DGDFANJGAFK(IEnumerable NFKMMHCBCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x169F140", Offset = "0x169D740", VA = "0x18169F140")]
	public static void DGDFANJGAFK<T>(T[] JHKFLJIAOGC) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NHFOGFNGPLA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INMPCLDOECM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x743D70", Offset = "0x743170")] in KADKGANJNFJ<T?> KFEHCNDMCGM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct NICFADFJKAD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public TData[] ENDMNGNNLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public GJALNGNNDJP[] NCILMPDNAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public FGDIOILOGNO[] NKGKBLOKJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public float[] OEFGJJAMKBE;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x26C70B0", Offset = "0x26C56B0", VA = "0x1826C70B0")]
	public NICFADFJKAD(TData[] JANBNIKCNJC, GJALNGNNDJP[] OOJLGEBJDPI, FGDIOILOGNO[] GMIIJPABJKD, float[] OEFGJJAMKBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OMPNFGGILME
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HKCNDHPNJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool BDOKHBBEDDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool AGDJLJALNOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DGKMADDFMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct GBGJDPFDBGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly Guid DIGMIHGKNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly int IIOMOLKAONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly Vector3 FADCMIMHMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly Quaternion HOHKOHLHECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly float FLPLIPPLLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool MGNJODFELDA;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x72420A0", Offset = "0x72406A0", VA = "0x1872420A0")]
	public GBGJDPFDBGB(Guid DIGMIHGKNJL, int IIOMOLKAONM, Vector3 FADCMIMHMJH, Quaternion HOHKOHLHECA, float FLPLIPPLLCO, bool MGNJODFELDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FCPANBMLBAB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NHHGDAILMCF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x743DE0", Offset = "0x7431E0")] in ACBJAJODFMC<TData?> IKKLIMOLAKM);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OJNPPAKIFAD(in LBDGOBAJAFB OFDOBMJDFBL);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EMJLNMEIJMJ();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct MLHOIOGNKEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly float IPBDNGOJOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly Vector3 BEAENAPILAH;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4FFA290", Offset = "0x4FF8890", VA = "0x184FFA290")]
	public MLHOIOGNKEP(float IPBDNGOJOJP, Vector3 BEAENAPILAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct NPOFKKODHLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly Vector3 DIEHLHAFPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly float IPBDNGOJOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 BEAENAPILAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly bool MGNJODFELDA;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7242100", Offset = "0x7240700", VA = "0x187242100")]
	public NPOFKKODHLL(Vector3 DIEHLHAFPFI, float IPBDNGOJOJP, Vector3 BEAENAPILAH, bool MGNJODFELDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x743E50", Offset = "0x743250")]
public class CPPGGELHEIB<TData> : BMLGEEKNPHA<PCDBFFPPKII<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly LEHDAEGPNMF EMNBKCFLGIA;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x32A8FD0", Offset = "0x32A75D0", VA = "0x1832A8FD0")]
	public CPPGGELHEIB(Vector3 GJDNMJFENKD, PCDBFFPPKII<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF800", Offset = "0x1FEDE00", VA = "0x181FEF800", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface APAGFBOJCJL<TData> where TData : JIFNBCGGICH
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INMPCLDOECM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x743EC0", Offset = "0x7432C0")] in CNLDEDELBNL<TData> MHPOJJHGMHK);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INMPCLDOECM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x743F30", Offset = "0x743330")] in NDHENLOHPBD<TData> MHPOJJHGMHK);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class GFLCGBOEKDA
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum NKKAKBOBIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1B79800", Offset = "0x1B77E00", VA = "0x181B79800")]
	public static void IBDLHDLDFOO<T>(T CMNEOBJBOCK, NKKAKBOBIDJ LFBJHCMDIAE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1B79770", Offset = "0x1B77D70", VA = "0x181B79770")]
	public static void IBDLHDLDFOO<T>(T CMNEOBJBOCK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1B796E0", Offset = "0x1B77CE0", VA = "0x181B796E0")]
	public static void CAEGIOBIEDL<T>(T CMNEOBJBOCK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1B79980", Offset = "0x1B77F80", VA = "0x181B79980")]
	public static T PIDCPOPDLLJ<T>(NKKAKBOBIDJ LFBJHCMDIAE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1B79A40", Offset = "0x1B78040", VA = "0x181B79A40")]
	public static T PIDCPOPDLLJ<T>() where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x743FA0", Offset = "0x7433A0")]
public class PGGHLJGAEDN<TData> : BMLGEEKNPHA<BGGBAOHKCHA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x121C940", Offset = "0x121AF40", VA = "0x18121C940")]
	public PGGHLJGAEDN(BGGBAOHKCHA<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2C4FB90", Offset = "0x2C4E190", VA = "0x182C4FB90", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface PGICNJGHMHE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 OACJHEFCBAA, Vector3 JPHMHCBHKFF, float HPJGDBFIPFJ, out T DGCEBLOAIAE, out Vector3 IPFBPIKBBCO, out Collider AGHAMLLNPID);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 OACJHEFCBAA, Vector3 JPHMHCBHKFF, float MJHDGFLDNJC, float HPJGDBFIPFJ, T[] PKPPLDCNNIF, out Vector3 ABBAEGEHPDO, out Collider OLOFFDKPKNJ);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 OACJHEFCBAA, float MJHDGFLDNJC, Vector3 FKNJKPBJOOA, T[] PKPPLDCNNIF);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class MIBMGMLPJII<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	protected TReceiver BIHBIOFPAIP;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x25E3480", Offset = "0x25E1A80", VA = "0x1825E3480")]
	public MIBMGMLPJII(TReceiver BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute INMPCLDOECM();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744010", Offset = "0x743410")]
public class OHKECLCGKCG<TData> : BMLGEEKNPHA<CABJNIJGDNJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744080", Offset = "0x743480")]
	private readonly GILFADJFFLM<TData> BBFLFPGIIOF;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2657800", Offset = "0x2655E00", VA = "0x182657800")]
	public OHKECLCGKCG(IEnumerable<TData> JANBNIKCNJC, GJALNGNNDJP OOJLGEBJDPI, FGDIOILOGNO GMIIJPABJKD, float OEFGJJAMKBE, bool PAHHLPMEAGI, CABJNIJGDNJ<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1651FF0", Offset = "0x16505F0", VA = "0x181651FF0", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7440E0", Offset = "0x7434E0")]
public class HBDNFGBCAJC<TData> : BMLGEEKNPHA<KAINODKDGKH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x121C940", Offset = "0x121AF40", VA = "0x18121C940")]
	public HBDNFGBCAJC(KAINODKDGKH<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3734FD0", Offset = "0x37335D0", VA = "0x183734FD0", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744150", Offset = "0x743550")]
public class FABNHHHIIOK<TData> : BMLGEEKNPHA<AHILDOFJCKB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7441C0", Offset = "0x7435C0")]
	private readonly JHBECABLNKO<TData> EMNBKCFLGIA;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1652190", Offset = "0x1650790", VA = "0x181652190")]
	public FABNHHHIIOK(IEnumerable<TData> JANBNIKCNJC, Vector3 GJDNMJFENKD, bool PAHHLPMEAGI, AHILDOFJCKB<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1651FF0", Offset = "0x16505F0", VA = "0x181651FF0", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct JHBECABLNKO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly IEnumerable<TData> JANBNIKCNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly Vector3 GJDNMJFENKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly bool PAHHLPMEAGI;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3725AB0", Offset = "0x37240B0", VA = "0x183725AB0")]
	public JHBECABLNKO(IEnumerable<TData> JANBNIKCNJC, Vector3 GJDNMJFENKD, bool PAHHLPMEAGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface AHILDOFJCKB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INMPCLDOECM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744220", Offset = "0x743620")] in JHBECABLNKO<TData?> EMNBKCFLGIA);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744290", Offset = "0x743690")]
public class ABMGDPAJKGA<TData> : BMLGEEKNPHA<BGGBAOHKCHA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly bool PAHHLPMEAGI;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x26CEC30", Offset = "0x26CD230", VA = "0x1826CEC30")]
	public ABMGDPAJKGA(bool PAHHLPMEAGI, BGGBAOHKCHA<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x26CEBC0", Offset = "0x26CD1C0", VA = "0x1826CEBC0", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface JIBEGLLJNCP<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NHHGDAILMCF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744300", Offset = "0x743700")] in KPGJJGIALIP<TNode?> IKKLIMOLAKM);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EMJLNMEIJMJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744370", Offset = "0x743770")] in HKNHCOFMMAL<TNode?> IPAMOKGEFOM);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KHEKIMGCMCJ();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7443E0", Offset = "0x7437E0")]
public class OHGPBFDPPJC<TNode> : BMLGEEKNPHA<JIBEGLLJNCP<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x121C940", Offset = "0x121AF40", VA = "0x18121C940")]
	public OHGPBFDPPJC(JIBEGLLJNCP<TNode> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2657750", Offset = "0x2655D50", VA = "0x182657750", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface PPFLHDAPPDP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INMPCLDOECM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744450", Offset = "0x743850")] in NICFADFJKAD<TData?> BBFLFPGIIOF);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class CNEIDMCFOMN
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private struct LBLILJEFAAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public bool OGOLEFHFMHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public EIHIACACEHJ FBIDEBDCKAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public EIHIACACEHJ HGIINPFGINH;
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static LBLILJEFAAA EBFILKOOLNF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static CancellationToken DDBGPDFFCBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7241ED0", Offset = "0x72404D0", VA = "0x187241ED0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal static EIHIACACEHJ FBIDEBDCKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7241DF0", Offset = "0x72403F0", VA = "0x187241DF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7241F30", Offset = "0x7240530", VA = "0x187241F30")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7241FB0", Offset = "0x72405B0", VA = "0x187241FB0")]
	[PJEDGFFEDPC(FLIHEPFCGKG.Room, PDIHHCLCNFI.None)]
	private static void PEMAGMCLMID(EIHIACACEHJ JIPMFDILOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7241C60", Offset = "0x7240260", VA = "0x187241C60")]
	public static void BCFKLBADKBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7241DA0", Offset = "0x72403A0", VA = "0x187241DA0")]
	private static EIHIACACEHJ IHDJCEPLKPO(EIHIACACEHJ HABLHGJIEJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface OFCNKHLEADP<TData> : BJKCJLNCCLH, JHKDGLIFBJJ<TData>, BGGBAOHKCHA<TData>, COAOGOHMPNB<TData>, OMPNFGGILME, PGICNJGHMHE<TData>, PAICHIDINMM
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct EIJOJPDGPAN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly IEnumerable<TData> JANBNIKCNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly Quaternion GJDNMJFENKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly Vector3? BEAENAPILAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly bool EMOJDDNLBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool PAHHLPMEAGI;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2DB3990", Offset = "0x2DB1F90", VA = "0x182DB3990")]
	public EIJOJPDGPAN(IEnumerable<TData> JANBNIKCNJC, Quaternion GJDNMJFENKD, Vector3? BEAENAPILAH, bool EMOJDDNLBLH, bool PAHHLPMEAGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7444E0", Offset = "0x7438E0")]
public class IOOGLKNOEOA<T> : BMLGEEKNPHA<NHFOGFNGPLA<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744550", Offset = "0x743950")]
	private readonly KADKGANJNFJ<T> KFEHCNDMCGM;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1FFFDC0", Offset = "0x1FFE3C0", VA = "0x181FFFDC0")]
	public IOOGLKNOEOA(T DPNGJGBLPFN, bool FIIDOIHOPIF, NHFOGFNGPLA<T> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1651FF0", Offset = "0x16505F0", VA = "0x181651FF0", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct GILFADJFFLM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public IEnumerable<TData> ENDMNGNNLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public GJALNGNNDJP NCILMPDNAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public FGDIOILOGNO NKGKBLOKJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float OEFGJJAMKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public bool PAHHLPMEAGI;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2DC3900", Offset = "0x2DC1F00", VA = "0x182DC3900")]
	public GILFADJFFLM(IEnumerable<TData> JANBNIKCNJC, GJALNGNNDJP OOJLGEBJDPI, FGDIOILOGNO GMIIJPABJKD, float OEFGJJAMKBE, bool PAHHLPMEAGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7445B0", Offset = "0x7439B0")]
public class KIABJNOEEEM<TData> : BMLGEEKNPHA<HKKDIHIKPDJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly NPOFKKODHLL CGFLHNOELOO;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x34A4F20", Offset = "0x34A3520", VA = "0x1834A4F20")]
	public KIABJNOEEEM(Vector3 DIEHLHAFPFI, float IPBDNGOJOJP, Vector3 BEAENAPILAH, bool PJLMAPIAEMK, HKKDIHIKPDJ<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2C56720", Offset = "0x2C54D20", VA = "0x182C56720", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct CGLPOCPEDED<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T DPNGJGBLPFN;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7950", Offset = "0x1FF5F50", VA = "0x181FF7950")]
	public CGLPOCPEDED(T OLADNMFNFFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744620", Offset = "0x743A20")]
public class HEECADDNCPK<TData> : BMLGEEKNPHA<BGGBAOHKCHA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744690", Offset = "0x743A90")]
	private readonly JMMCIIMIJPM<TData> MIFDDBEPADK;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2E53550", Offset = "0x2E51B50", VA = "0x182E53550")]
	public HEECADDNCPK(List<TData> NEGBPLHGJID, BGGBAOHKCHA<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2E53400", Offset = "0x2E51A00", VA = "0x182E53400", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct EJHJBPAFKJE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly IEnumerable<TData> ENDMNGNNLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly bool OIICNLBLHHL;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2DB3DE0", Offset = "0x2DB23E0", VA = "0x182DB3DE0")]
	public EJHJBPAFKJE(IEnumerable<TData> JANBNIKCNJC, bool PAHHLPMEAGI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744730", Offset = "0x743B30")]
public class NBPKGNFADCI<TData> : BMLGEEKNPHA<BGGBAOHKCHA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7447A0", Offset = "0x743BA0")]
	private readonly JMMCIIMIJPM<TData> MIFDDBEPADK;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x24E9B70", Offset = "0x24E8170", VA = "0x1824E9B70")]
	public NBPKGNFADCI(List<TData> NEGBPLHGJID, bool PAHHLPMEAGI, BGGBAOHKCHA<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2128C30", Offset = "0x2127230", VA = "0x182128C30", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface JHKDGLIFBJJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T IAMEECMGPIF, [Optional] CCEOOFIGOLM? NGNOCIABAAB, bool FPBEGBPLPCA = true);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int EGIKAKGFKPB, IEnumerable<T> BHEDJJBBEIH, bool FPBEGBPLPCA = true);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int EGIKAKGFKPB, IEnumerable<T> BHEDJJBBEIH, CCEOOFIGOLM NGNOCIABAAB, bool FPBEGBPLPCA = true);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct ACCIIHJIJNF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly IEnumerable<TData> JANBNIKCNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly bool PAHHLPMEAGI;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x26D56E0", Offset = "0x26D3CE0", VA = "0x1826D56E0")]
	public ACCIIHJIJNF(IEnumerable<TData> JANBNIKCNJC, bool PAHHLPMEAGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744800", Offset = "0x743C00")]
public class OMEEEBIFDDG<TData> : GEGNDFDIPPK<MCABDICPLDG<TData>, BOEFACIMGNG> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744870", Offset = "0x743C70")]
	private readonly EJHJBPAFKJE<TData> FJPPFBAAHCL;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x26635A0", Offset = "0x2661BA0", VA = "0x1826635A0")]
	public OMEEEBIFDDG(IEnumerable<TData> JANBNIKCNJC, bool PAHHLPMEAGI, MCABDICPLDG<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2663360", Offset = "0x2661960", VA = "0x182663360", Slot = "4")]
	public override Task<BOEFACIMGNG> INMPCLDOECM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7448D0", Offset = "0x743CD0")]
public class FNGILICBDAH<TData> : BMLGEEKNPHA<KAINODKDGKH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744940", Offset = "0x743D40")]
	private readonly DHAFOKIEDBB<TData> OEGNJKICNAD;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2B606F0", Offset = "0x2B5ECF0", VA = "0x182B606F0")]
	public FNGILICBDAH(TData DPNGJGBLPFN, bool PAHHLPMEAGI, KAINODKDGKH<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1651FF0", Offset = "0x16505F0", VA = "0x181651FF0", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct DHAFOKIEDBB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly TData DPNGJGBLPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly bool PAHHLPMEAGI;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2F16C40", Offset = "0x2F15240", VA = "0x182F16C40")]
	public DHAFOKIEDBB(TData DPNGJGBLPFN, bool PAHHLPMEAGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct LJFMEBCIIPP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly IEnumerable<TData> JANBNIKCNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool PAHHLPMEAGI;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2E090D0", Offset = "0x2E076D0", VA = "0x182E090D0")]
	public LJFMEBCIIPP(IEnumerable<TData> JANBNIKCNJC, bool PAHHLPMEAGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7449A0", Offset = "0x743DA0")]
public class BCHJMOIECDP<T> : BMLGEEKNPHA<HFACOPEHION<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x121C940", Offset = "0x121AF40", VA = "0x18121C940")]
	public BCHJMOIECDP(HFACOPEHION<T> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x50BB510", Offset = "0x50B9B10", VA = "0x1850BB510", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744A10", Offset = "0x743E10")]
public class EDFAPLLLCCJ<TData> : BMLGEEKNPHA<HKKDIHIKPDJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly MLHOIOGNKEP CGFLHNOELOO;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2A4BE30", Offset = "0x2A4A430", VA = "0x182A4BE30")]
	public EDFAPLLLCCJ(float IPBDNGOJOJP, Vector3 BEAENAPILAH, HKKDIHIKPDJ<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF800", Offset = "0x1FEDE00", VA = "0x181FEF800", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744A80", Offset = "0x743E80")]
public class FEBCILMILII<TData> : BMLGEEKNPHA<FCPANBMLBAB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x121C940", Offset = "0x121AF40", VA = "0x18121C940")]
	public FEBCILMILII(FCPANBMLBAB<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x21E86D0", Offset = "0x21E6CD0", VA = "0x1821E86D0", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744AF0", Offset = "0x743EF0")]
public class JGCNDFLGCNK<TData> : BMLGEEKNPHA<FCPANBMLBAB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744B60", Offset = "0x743F60")]
	private readonly ACBJAJODFMC<TData> KCNHBOLMBOP;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2A099C0", Offset = "0x2A07FC0", VA = "0x182A099C0")]
	public JGCNDFLGCNK(IEnumerable<TData> JANBNIKCNJC, bool PAHHLPMEAGI, FCPANBMLBAB<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1651FF0", Offset = "0x16505F0", VA = "0x181651FF0", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744BC0", Offset = "0x743FC0")]
public class BFANGDIOKBF<TNode> : BMLGEEKNPHA<JIBEGLLJNCP<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744C30", Offset = "0x744030")]
	private readonly KPGJJGIALIP<TNode> IKKLIMOLAKM;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2E17790", Offset = "0x2E15D90", VA = "0x182E17790")]
	public BFANGDIOKBF(TNode DJFPEKNHJKA, JIBEGLLJNCP<TNode> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1651FF0", Offset = "0x16505F0", VA = "0x181651FF0", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744C90", Offset = "0x744090")]
public class NCIMNPCIOML<TData> : BMLGEEKNPHA<PCDBFFPPKII<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744D00", Offset = "0x744100")]
	private readonly LJFMEBCIIPP<TData> EMNBKCFLGIA;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x24EDA10", Offset = "0x24EC010", VA = "0x1824EDA10")]
	public NCIMNPCIOML(IEnumerable<TData> JANBNIKCNJC, bool PAHHLPMEAGI, PCDBFFPPKII<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1651FF0", Offset = "0x16505F0", VA = "0x181651FF0", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct ACBJAJODFMC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IEnumerable<TData> JANBNIKCNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly bool PAHHLPMEAGI;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x26D4A10", Offset = "0x26D3010", VA = "0x1826D4A10")]
	public ACBJAJODFMC(IEnumerable<TData> JANBNIKCNJC, bool PAHHLPMEAGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744D60", Offset = "0x744160")]
public class PFHMDGBDJNC<TNode> : BMLGEEKNPHA<JIBEGLLJNCP<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744DD0", Offset = "0x7441D0")]
	private readonly HKNHCOFMMAL<TNode> IPAMOKGEFOM;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2C4E050", Offset = "0x2C4C650", VA = "0x182C4E050")]
	public PFHMDGBDJNC(TNode PCBFNJJBLFA, LHLNNIPFCNL GGMIEDJJIHL, JIBEGLLJNCP<TNode> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2C4DF90", Offset = "0x2C4C590", VA = "0x182C4DF90", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface MCABDICPLDG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BOEFACIMGNG> HIPNNDKOMAL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744E30", Offset = "0x744230")] in EJHJBPAFKJE<TData> MIFDDBEPADK, CancellationToken OOAGLCBNIOG);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface BGGBAOHKCHA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GNHLEBIPGEL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744EA0", Offset = "0x7442A0")] in JMMCIIMIJPM<TData> MIFDDBEPADK);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JAEKNEAMIJE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744F10", Offset = "0x744310")] in JMMCIIMIJPM<TData> MIFDDBEPADK);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JIIKLDJACFF(in bool KCGGLGPHCBN);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OFPIPNLOGHG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744F80", Offset = "0x744380")] in JMMCIIMIJPM<TData> MIFDDBEPADK);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AECJJCOADOD();

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PBKCCACDGJB(in TData NCDOLFHFHFG);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct LBDGOBAJAFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly Quaternion GJDNMJFENKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly Vector3? BEAENAPILAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly bool EMOJDDNLBLH;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5C14480", Offset = "0x5C12A80", VA = "0x185C14480")]
	public LBDGOBAJAFB(Quaternion GJDNMJFENKD, Vector3? BEAENAPILAH, bool EMOJDDNLBLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface KAINODKDGKH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NHHGDAILMCF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x744FF0", Offset = "0x7443F0")] in DHAFOKIEDBB<TData?> IKKLIMOLAKM);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OJNPPAKIFAD(in GJCMFPPGNBM OFDOBMJDFBL);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OJNPPAKIFAD(in GBGJDPFDBGB OFDOBMJDFBL);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EMJLNMEIJMJ();
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct LEHDAEGPNMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly Vector3 GJDNMJFENKD;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1FF79A0", Offset = "0x1FF5FA0", VA = "0x181FF79A0")]
	public LEHDAEGPNMF(Vector3 GJDNMJFENKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x745060", Offset = "0x744460")]
public class JLCBADCPHDI<T> : BMLGEEKNPHA<HFACOPEHION<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7450D0", Offset = "0x7444D0")]
	private readonly CGLPOCPEDED<T> PNAENALHNIL;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3734F40", Offset = "0x3733540", VA = "0x183734F40")]
	public JLCBADCPHDI(T DPNGJGBLPFN, HFACOPEHION<T> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1651FF0", Offset = "0x16505F0", VA = "0x181651FF0", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x745130", Offset = "0x744530")]
public class MKCFHOFKNDD<TData> : BMLGEEKNPHA<DJCELNOKGKM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7451A0", Offset = "0x7445A0")]
	private readonly EIJOJPDGPAN<TData> KCNHBOLMBOP;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x347DFF0", Offset = "0x347C5F0", VA = "0x18347DFF0")]
	public MKCFHOFKNDD(IEnumerable<TData> JANBNIKCNJC, Quaternion GJDNMJFENKD, Vector3? BEAENAPILAH, bool EMOJDDNLBLH, bool PAHHLPMEAGI, DJCELNOKGKM<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1651FF0", Offset = "0x16505F0", VA = "0x181651FF0", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x745200", Offset = "0x744600")]
public class JLDMNIPDAFJ<TData> : BMLGEEKNPHA<HKKDIHIKPDJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x121C940", Offset = "0x121AF40", VA = "0x18121C940")]
	public JLDMNIPDAFJ(HKKDIHIKPDJ<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3734FD0", Offset = "0x37335D0", VA = "0x183734FD0", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x745270", Offset = "0x744670")]
public class GNMDNFDHBPG<TData> : BMLGEEKNPHA<FCPANBMLBAB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly LBDGOBAJAFB KCNHBOLMBOP;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x24D4910", Offset = "0x24D2F10", VA = "0x1824D4910")]
	public GNMDNFDHBPG(Quaternion GJDNMJFENKD, Vector3? BEAENAPILAH, bool EMOJDDNLBLH, FCPANBMLBAB<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF800", Offset = "0x1FEDE00", VA = "0x181FEF800", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7452E0", Offset = "0x7446E0")]
public class LMCBGBADAOO<TData> : BMLGEEKNPHA<PPFLHDAPPDP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x745350", Offset = "0x744750")]
	private readonly NICFADFJKAD<TData> BBFLFPGIIOF;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3D3DAD0", Offset = "0x3D3C0D0", VA = "0x183D3DAD0")]
	public LMCBGBADAOO(TData[] JANBNIKCNJC, GJALNGNNDJP[] OOJLGEBJDPI, FGDIOILOGNO[] GMIIJPABJKD, float[] OEFGJJAMKBE, PPFLHDAPPDP<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3200", Offset = "0x1FF1800", VA = "0x181FF3200", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7453B0", Offset = "0x7447B0")]
public class BMDLMKFKMJN<TData> : BMLGEEKNPHA<APAGFBOJCJL<TData>> where TData : notnull, JIFNBCGGICH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x745420", Offset = "0x744820")]
	private readonly NDHENLOHPBD<TData> MHPOJJHGMHK;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2128CF0", Offset = "0x21272F0", VA = "0x182128CF0")]
	public BMDLMKFKMJN(List<TData> JANBNIKCNJC, List<bool> EOBLPCGOINO, APAGFBOJCJL<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2128C30", Offset = "0x2127230", VA = "0x182128C30", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x745480", Offset = "0x744880")]
public class ABLOHGIKDOE<TData> : BMLGEEKNPHA<PCDBFFPPKII<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x121C940", Offset = "0x121AF40", VA = "0x18121C940")]
	public ABLOHGIKDOE(PCDBFFPPKII<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x21E86D0", Offset = "0x21E6CD0", VA = "0x1821E86D0", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct GJCMFPPGNBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly Vector3 IFKNBJHNPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool MGNJODFELDA;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x72420E0", Offset = "0x72406E0", VA = "0x1872420E0")]
	public GJCMFPPGNBM(Vector3 IFKNBJHNPMM, bool MGNJODFELDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct KADKGANJNFJ<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T DPNGJGBLPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly bool NEFBDKMCGDG;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2332550", Offset = "0x2330B50", VA = "0x182332550")]
	public KADKGANJNFJ(T OLADNMFNFFA, bool FIIDOIHOPIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface IJAAHPFGDNJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OJNPPAKIFAD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7454F0", Offset = "0x7448F0")] in KAPLGAMDOJK<TData?> BBFLFPGIIOF);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMJLNMEIJMJ();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x745560", Offset = "0x744960")]
public class IKGNBHALHBL<TData> : BMLGEEKNPHA<IJAAHPFGDNJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7455D0", Offset = "0x7449D0")]
	private readonly KAPLGAMDOJK<TData> BBFLFPGIIOF;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1FF32C0", Offset = "0x1FF18C0", VA = "0x181FF32C0")]
	public IKGNBHALHBL(IEnumerable<TData> JANBNIKCNJC, GJALNGNNDJP OOJLGEBJDPI, FGDIOILOGNO GMIIJPABJKD, float OEFGJJAMKBE, IJAAHPFGDNJ<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3200", Offset = "0x1FF1800", VA = "0x181FF3200", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface JIFNBCGGICH
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool LELFJAHBJFA
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x745630", Offset = "0x744A30")]
public class PHMNDHBGFGK<TData> : BMLGEEKNPHA<KAINODKDGKH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly GBGJDPFDBGB OEGNJKICNAD;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2C56790", Offset = "0x2C54D90", VA = "0x182C56790")]
	public PHMNDHBGFGK(Guid DIGMIHGKNJL, int IIOMOLKAONM, Vector3 FADCMIMHMJH, Quaternion HOHKOHLHECA, float FLPLIPPLLCO, bool MGNJODFELDA, KAINODKDGKH<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2C56720", Offset = "0x2C54D20", VA = "0x182C56720", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7456A0", Offset = "0x744AA0")]
public class MDHHHOMKIHP<TData> : BMLGEEKNPHA<APAGFBOJCJL<TData>> where TData : notnull, JIFNBCGGICH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x745710", Offset = "0x744B10")]
	private readonly CNLDEDELBNL<TData> MHPOJJHGMHK;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x25D6CB0", Offset = "0x25D52B0", VA = "0x1825D6CB0")]
	public MDHHHOMKIHP(List<TData> JANBNIKCNJC, bool IMPOFHANMDC, APAGFBOJCJL<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1651FF0", Offset = "0x16505F0", VA = "0x181651FF0", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x745770", Offset = "0x744B70")]
public class KKKKLOGCPBG<TData> : BMLGEEKNPHA<BGGBAOHKCHA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly TData NCDOLFHFHFG;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x261D2B0", Offset = "0x261B8B0", VA = "0x18261D2B0")]
	public KKKKLOGCPBG(TData NCDOLFHFHFG, BGGBAOHKCHA<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x261D1F0", Offset = "0x261B7F0", VA = "0x18261D1F0", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7457E0", Offset = "0x744BE0")]
public abstract class BMLGEEKNPHA<TReceiver> : MIBMGMLPJII<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x121C940", Offset = "0x121AF40", VA = "0x18121C940")]
	public BMLGEEKNPHA(TReceiver BIHBIOFPAIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface BJKCJLNCCLH
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Bounds OMOICAPPCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Transform EJDMHINBEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Bounds IEIOHLDMPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Transform PAHLNJJIOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Vector3 HLMMDCCJCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool AABFPPKCGNK = true, int GFKJLPDPPEO = 0);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct CNLDEDELBNL<TData> where TData : notnull, JIFNBCGGICH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public IEnumerable<TData> ENDMNGNNLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public bool IMPOFHANMDC;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x32A3450", Offset = "0x32A1A50", VA = "0x1832A3450")]
	public CNLDEDELBNL(IEnumerable<TData> LGDNKCHLEFC, bool DKNAGEGIGBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct NDHENLOHPBD<TData> where TData : notnull, JIFNBCGGICH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public List<TData> ENDMNGNNLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public List<bool> EOBLPCGOINO;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x24EE7F0", Offset = "0x24ECDF0", VA = "0x1824EE7F0")]
	public NDHENLOHPBD(List<TData> LGDNKCHLEFC, List<bool> OCKPHBOLFJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface COAOGOHMPNB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool HAAECLHFOCN
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int KDKECLACEOO
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<TData> KEFPJIPEKKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData CDIFGMFCFLG);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData CDIFGMFCFLG);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface PAICHIDINMM
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface PCDBFFPPKII<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NHHGDAILMCF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x745850", Offset = "0x744C50")] in LJFMEBCIIPP<TData?> KKDCJJJOECH);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OJNPPAKIFAD(in LEHDAEGPNMF OFDOBMJDFBL);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EMJLNMEIJMJ();
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7458C0", Offset = "0x744CC0")]
public class LNODKPLAIIH<TData> : BMLGEEKNPHA<IJAAHPFGDNJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x121C940", Offset = "0x121AF40", VA = "0x18121C940")]
	public LNODKPLAIIH(IJAAHPFGDNJ<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3D41640", Offset = "0x3D3FC40", VA = "0x183D41640", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface HGEKPDBNCLN : JIFNBCGGICH
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x745930", Offset = "0x744D30")]
public abstract class GEGNDFDIPPK<TReceiver, TFromTask> : MIBMGMLPJII<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x121C940", Offset = "0x121AF40", VA = "0x18121C940")]
	public GEGNDFDIPPK(TReceiver BIHBIOFPAIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface HFACOPEHION<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NHHGDAILMCF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7459A0", Offset = "0x744DA0")] in CGLPOCPEDED<T?> PNAENALHNIL);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EMJLNMEIJMJ();
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x745A10", Offset = "0x744E10")]
public class CGKPIBMDDHL<TData> : BMLGEEKNPHA<HKKDIHIKPDJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x745A80", Offset = "0x744E80")]
	private readonly ACCIIHJIJNF<TData> CGFLHNOELOO;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2BB2B00", Offset = "0x2BB1100", VA = "0x182BB2B00")]
	public CGKPIBMDDHL(IEnumerable<TData> JANBNIKCNJC, bool PAHHLPMEAGI, HKKDIHIKPDJ<TData> BIHBIOFPAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1651FF0", Offset = "0x16505F0", VA = "0x181651FF0", Slot = "4")]
	public override bool INMPCLDOECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface CABJNIJGDNJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INMPCLDOECM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x745AE0", Offset = "0x744EE0")] in GILFADJFFLM<TData?> BBFLFPGIIOF);
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

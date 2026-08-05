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
		[Cpp2IlInjected.Address(RVA = "0x86EBE0", Offset = "0x86DBE0", VA = "0x18086EBE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72DE210", Offset = "0x72DD210", VA = "0x1872DE210")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA3FB40", Offset = "0xA3EB40", VA = "0x180A3FB40")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF9C40", Offset = "0xCF8C40", VA = "0x180CF9C40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x761B90", Offset = "0x760F90")]
public class DPLONCLOJMH<TData> : GIMDCBDCKIG<EFOJMAGMJCA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly IBOIMPPLHDK NPCMAHNEKPM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x231C720", Offset = "0x231B720", VA = "0x18231C720")]
	public DPLONCLOJMH(Vector3 DOFBOOADCDE, bool ECPIACBFMJE, EFOJMAGMJCA<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x231C6B0", Offset = "0x231B6B0", VA = "0x18231C6B0", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct MLEEAHNNKPD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public IEnumerable<TData> BCMDMNPPPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public bool IHJLMOPHMNB;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2F84020", Offset = "0x2F83020", VA = "0x182F84020")]
	public MLEEAHNNKPD(IEnumerable<TData> OEHJLMFHHAN, bool GDMPDFEALOC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KCILHIPEKAI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OPFFFHAFPLG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x761C40", Offset = "0x761040")] in NMMCGMODLAC<TData?> GEGANEFPFNB);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KGBMJLJOCJP(in MELIHEPCEON EHIDIMIMJLG);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KGBMJLJOCJP(in NIBJOIAOABD EHIDIMIMJLG);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AGMLIKFMDJM();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct HGDHLPLBECI<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public TNode OMIKPPMLBFM;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3674C70", Offset = "0x3673C70", VA = "0x183674C70")]
	public HGDHLPLBECI(TNode OMIKPPMLBFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct HJLIIPAPDHC<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TNode KHNFEIFCGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public BNCAFONCJCD DDIBDPLHEND;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x28450F0", Offset = "0x28440F0", VA = "0x1828450F0")]
	public HJLIIPAPDHC(TNode KHNFEIFCGJE, BNCAFONCJCD DDIBDPLHEND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x761CB0", Offset = "0x7610B0")]
public class CKGPDJGGLKM<TData> : GIMDCBDCKIG<GJDNBHMMLIA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x761D20", Offset = "0x761120")]
	private readonly MLEEAHNNKPD<TData> JNBINLEDKML;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x34547E0", Offset = "0x34537E0", VA = "0x1834547E0")]
	public CKGPDJGGLKM(List<TData> HACMILLGFCL, GJDNBHMMLIA<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x16965A0", Offset = "0x16955A0", VA = "0x1816965A0", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HLKKKLKLGCD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BCJGKBEDJFF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x761D80", Offset = "0x761180")] in KKBKOGEDIIH<TData?> JLPOIIEPCKC);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct HOHFIEBHEEE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> BCMDMNPPPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public KADGINDIKPL MKGELMCJLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public BACGCBKMFNG AHDGBCJMKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float EIDPFALKPDK;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2D94110", Offset = "0x2D93110", VA = "0x182D94110")]
	public HOHFIEBHEEE(IEnumerable<TData> LLGFHBBLPAM, KADGINDIKPL IFAEOGGHLKI, BACGCBKMFNG HDEIKJNIFFB, float EIDPFALKPDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal static class EMNAIEPOFOI
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x72DDAE0", Offset = "0x72DCAE0", VA = "0x1872DDAE0")]
	public static void EHFHNBEGHLN(IEnumerable AOPKJFKKJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1FFE9E0", Offset = "0x1FFD9E0", VA = "0x181FFE9E0")]
	public static void EHFHNBEGHLN<T>(T[] GJAKHOONFBO) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JFKBMGONKLI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BCJGKBEDJFF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x761DF0", Offset = "0x7611F0")] in OKFGKEPMHDI<T?> OKBPLNBOCDO);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct OKALNHPGMEG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public TData[] BCMDMNPPPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public KADGINDIKPL[] MKGELMCJLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public BACGCBKMFNG[] AHDGBCJMKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public float[] EIDPFALKPDK;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3285760", Offset = "0x3284760", VA = "0x183285760")]
	public OKALNHPGMEG(TData[] LLGFHBBLPAM, KADGINDIKPL[] IFAEOGGHLKI, BACGCBKMFNG[] HDEIKJNIFFB, float[] EIDPFALKPDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OEOHHFPMLAN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PILJNBDBBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool LDLFLDELOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool PMHCBIADCJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool JEKIIBKFBEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct FEEBOGGDGJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly Guid HIJPOFLLMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly int CCELBNKPBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly Vector3 NKMKMKDMOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly Quaternion NMKLOHCPMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly float MFIGFOJHONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool ECPIACBFMJE;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x72DDD40", Offset = "0x72DCD40", VA = "0x1872DDD40")]
	public FEEBOGGDGJK(Guid HIJPOFLLMCD, int CCELBNKPBGB, Vector3 NKMKMKDMOMJ, Quaternion NMKLOHCPMNL, float MFIGFOJHONE, bool ECPIACBFMJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HBHEMJCBMMB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OPFFFHAFPLG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x761E60", Offset = "0x761260")] in LNCEHNIEKPK<TData?> GEGANEFPFNB);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KGBMJLJOCJP(in MDOHCKDBGMF EHIDIMIMJLG);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AGMLIKFMDJM();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct MELIHEPCEON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly float JJMIOIPPABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly Vector3 LHJDGCBICFH;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4ED3CC0", Offset = "0x4ED2CC0", VA = "0x184ED3CC0")]
	public MELIHEPCEON(float JJMIOIPPABK, Vector3 LHJDGCBICFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct NIBJOIAOABD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly Vector3 HIAEAAHPMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly float JJMIOIPPABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 LHJDGCBICFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly bool ECPIACBFMJE;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x72DE1E0", Offset = "0x72DD1E0", VA = "0x1872DE1E0")]
	public NIBJOIAOABD(Vector3 HIAEAAHPMFN, float JJMIOIPPABK, Vector3 LHJDGCBICFH, bool ECPIACBFMJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x761ED0", Offset = "0x7612D0")]
public class OFAHIMGPIMN<TData> : GIMDCBDCKIG<PBGHGJHGFIL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly PJLNKGKEPCK MKJHHLKHNJC;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3277940", Offset = "0x3276940", VA = "0x183277940")]
	public OFAHIMGPIMN(Vector3 FBKJPHHFAEP, PBGHGJHGFIL<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x231C6B0", Offset = "0x231B6B0", VA = "0x18231C6B0", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface GKHPLENMEHC<TData> where TData : GCOKCNCEPPO
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BCJGKBEDJFF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x761F40", Offset = "0x761340")] in LNMMEALFHGF<TData> FLLCECOPLOM);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCJGKBEDJFF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x761FB0", Offset = "0x7613B0")] in BGDNJLIKPAJ<TData> FLLCECOPLOM);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class KDHHLBHNNAP
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum BNIPBHIDMCF
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2121D60", Offset = "0x2120D60", VA = "0x182121D60")]
	public static void BLBFIPLNMFE<T>(T NHLNFFHEKJH, BNIPBHIDMCF DPPJBLOOGOO) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2121EE0", Offset = "0x2120EE0", VA = "0x182121EE0")]
	public static void BLBFIPLNMFE<T>(T NHLNFFHEKJH) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2121CD0", Offset = "0x2120CD0", VA = "0x182121CD0")]
	public static void APJNFHEPADE<T>(T NHLNFFHEKJH) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2121F70", Offset = "0x2120F70", VA = "0x182121F70")]
	public static T FLFDNJDANPO<T>(BNIPBHIDMCF DPPJBLOOGOO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2122030", Offset = "0x2121030", VA = "0x182122030")]
	public static T FLFDNJDANPO<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x21220A0", Offset = "0x21210A0", VA = "0x1821220A0")]
	public static bool LBOPJKBKBFO<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762020", Offset = "0x761420")]
public class BLOKGPCAHDG<TData> : GIMDCBDCKIG<GJDNBHMMLIA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x168D8A0", Offset = "0x168C8A0", VA = "0x18168D8A0")]
	public BLOKGPCAHDG(GJDNBHMMLIA<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x23C0C80", Offset = "0x23BFC80", VA = "0x1823C0C80", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface NKOBMGJCFFI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 MGENAOADJOF, Vector3 HCEFOMOBPKF, float FJDPGBJBEDI, out T DDBDOJBNLFN, out Vector3 BBHGOHBHBMB, out Collider BFPOKKJOKIE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 MGENAOADJOF, Vector3 HCEFOMOBPKF, float JKLEKPMONDI, float FJDPGBJBEDI, T[] OLGGILJKKMC, out Vector3 LLMIGOBOBOP, out Collider MEEOOKLAPOL);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 MGENAOADJOF, float JKLEKPMONDI, Vector3 JFNGMJLIIDK, T[] OLGGILJKKMC);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class LKKJLKLBLKE<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	protected TReceiver NGIMGJJIBJB;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2507820", Offset = "0x2506820", VA = "0x182507820")]
	public LKKJLKLBLKE(TReceiver NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute BCJGKBEDJFF();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762090", Offset = "0x761490")]
public class PBAOBDECIMD<TData> : GIMDCBDCKIG<MAIOCKKPOID<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762100", Offset = "0x761500")]
	private readonly IOJECPPABFJ<TData> GBBJHPHLGLL;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2A88B20", Offset = "0x2A87B20", VA = "0x182A88B20")]
	public PBAOBDECIMD(IEnumerable<TData> LLGFHBBLPAM, KADGINDIKPL IFAEOGGHLKI, BACGCBKMFNG HDEIKJNIFFB, float EIDPFALKPDK, bool IHJLMOPHMNB, MAIOCKKPOID<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x16965A0", Offset = "0x16955A0", VA = "0x1816965A0", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762160", Offset = "0x761560")]
public class OAOIDMKFOON<TData> : GIMDCBDCKIG<EFOJMAGMJCA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x168D8A0", Offset = "0x168C8A0", VA = "0x18168D8A0")]
	public OAOIDMKFOON(EFOJMAGMJCA<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2350BD0", Offset = "0x234FBD0", VA = "0x182350BD0", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7621D0", Offset = "0x7615D0")]
public class GNDEIMBLGDH<TData> : GIMDCBDCKIG<MEIJKELIBOI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762240", Offset = "0x761640")]
	private readonly JCGLEKBMPEH<TData> MKJHHLKHNJC;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x32327F0", Offset = "0x32317F0", VA = "0x1832327F0")]
	public GNDEIMBLGDH(IEnumerable<TData> LLGFHBBLPAM, Vector3 FBKJPHHFAEP, bool IHJLMOPHMNB, MEIJKELIBOI<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x16965A0", Offset = "0x16955A0", VA = "0x1816965A0", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct JCGLEKBMPEH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly IEnumerable<TData> LLGFHBBLPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly Vector3 FBKJPHHFAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly bool IHJLMOPHMNB;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x36D3380", Offset = "0x36D2380", VA = "0x1836D3380")]
	public JCGLEKBMPEH(IEnumerable<TData> LLGFHBBLPAM, Vector3 FBKJPHHFAEP, bool IHJLMOPHMNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface MEIJKELIBOI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BCJGKBEDJFF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7622A0", Offset = "0x7616A0")] in JCGLEKBMPEH<TData?> MKJHHLKHNJC);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762310", Offset = "0x761710")]
public class KAGHHCLFFHI<TData> : GIMDCBDCKIG<GJDNBHMMLIA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly bool IHJLMOPHMNB;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2AA2650", Offset = "0x2AA1650", VA = "0x182AA2650")]
	public KAGHHCLFFHI(bool IHJLMOPHMNB, GJDNBHMMLIA<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2AA25E0", Offset = "0x2AA15E0", VA = "0x182AA25E0", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface ALLCFACLEME<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OPFFFHAFPLG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762380", Offset = "0x761780")] in HGDHLPLBECI<TNode?> GEGANEFPFNB);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AGMLIKFMDJM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7623F0", Offset = "0x7617F0")] in HJLIIPAPDHC<TNode?> MLFFODPNHGN);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LGGKACBNFGJ();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762460", Offset = "0x761860")]
public class LDLPFGDLDMC<TNode> : GIMDCBDCKIG<ALLCFACLEME<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x168D8A0", Offset = "0x168C8A0", VA = "0x18168D8A0")]
	public LDLPFGDLDMC(ALLCFACLEME<TNode> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2685BE0", Offset = "0x2684BE0", VA = "0x182685BE0", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface LCNIKNOOOCG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BCJGKBEDJFF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7624D0", Offset = "0x7618D0")] in OKALNHPGMEG<TData?> GBBJHPHLGLL);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class GEFJALNMJOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private struct JKOJBOINHAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public bool NJEGFGCIFNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public CNALHHIKJDD INJAIJFENAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public CNALHHIKJDD ENJHFIJHGKP;
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static JKOJBOINHAM CLODPGJHGJJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static CancellationToken IHPCMNALJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x72DE120", Offset = "0x72DD120", VA = "0x1872DE120")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal static CNALHHIKJDD INJAIJFENAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x72DDEB0", Offset = "0x72DCEB0", VA = "0x1872DDEB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x72DDE30", Offset = "0x72DCE30", VA = "0x1872DDE30")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x72DDD80", Offset = "0x72DCD80", VA = "0x1872DDD80")]
	[FBCFLFBFGIL(MELNECENNOL.Room, LAFFCBAHJKM.None)]
	private static void BGLPJMCJCBB(CNALHHIKJDD EDLFNOJINGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x72DDFE0", Offset = "0x72DCFE0", VA = "0x1872DDFE0")]
	public static void NJJHHEGPENJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x72DDF90", Offset = "0x72DCF90", VA = "0x1872DDF90")]
	private static CNALHHIKJDD LJCEPAKBLLL(CNALHHIKJDD EFFGMOEDBAB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface EKBBGPDCGFM<TData> : KBFKGDPPPEO, BHLEBHAOIFJ<TData>, GJDNBHMMLIA<TData>, LMEHGGGEHHJ<TData>, OEOHHFPMLAN, NKOBMGJCFFI<TData>, EJHFIDBIAOP
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct KKBKOGEDIIH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly IEnumerable<TData> LLGFHBBLPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly Quaternion FBKJPHHFAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly Vector3? LHJDGCBICFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly bool CJEIMDJAJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool IHJLMOPHMNB;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x354E3A0", Offset = "0x354D3A0", VA = "0x18354E3A0")]
	public KKBKOGEDIIH(IEnumerable<TData> LLGFHBBLPAM, Quaternion FBKJPHHFAEP, Vector3? LHJDGCBICFH, bool CJEIMDJAJAP, bool IHJLMOPHMNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762560", Offset = "0x761960")]
public class BLBIIAINOKC<T> : GIMDCBDCKIG<JFKBMGONKLI<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7625D0", Offset = "0x7619D0")]
	private readonly OKFGKEPMHDI<T> OKBPLNBOCDO;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x23BF450", Offset = "0x23BE450", VA = "0x1823BF450")]
	public BLBIIAINOKC(T FBOMMBLFPCD, bool NDGDJBGGKMG, JFKBMGONKLI<T> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x16965A0", Offset = "0x16955A0", VA = "0x1816965A0", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct IOJECPPABFJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public IEnumerable<TData> BCMDMNPPPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public KADGINDIKPL MKGELMCJLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public BACGCBKMFNG AHDGBCJMKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float EIDPFALKPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public bool IHJLMOPHMNB;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xBFE1F0", Offset = "0xBFD1F0", VA = "0x180BFE1F0")]
	public IOJECPPABFJ(IEnumerable<TData> LLGFHBBLPAM, KADGINDIKPL IFAEOGGHLKI, BACGCBKMFNG HDEIKJNIFFB, float EIDPFALKPDK, bool IHJLMOPHMNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762630", Offset = "0x761A30")]
public class BOGIKIAKIBC<TData> : GIMDCBDCKIG<KCILHIPEKAI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly NIBJOIAOABD BHHAGFNCDFB;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x23CCAA0", Offset = "0x23CBAA0", VA = "0x1823CCAA0")]
	public BOGIKIAKIBC(Vector3 HIAEAAHPMFN, float JJMIOIPPABK, Vector3 LHJDGCBICFH, bool DHDDHNKIKAE, KCILHIPEKAI<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x23B6220", Offset = "0x23B5220", VA = "0x1823B6220", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct ALMEOLOODJB<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T FBOMMBLFPCD;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2063AA0", Offset = "0x2062AA0", VA = "0x182063AA0")]
	public ALMEOLOODJB(T IMCFPOPBFBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7626A0", Offset = "0x761AA0")]
public class NLNJOLHCMIK<TData> : GIMDCBDCKIG<GJDNBHMMLIA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762710", Offset = "0x761B10")]
	private readonly MLEEAHNNKPD<TData> JNBINLEDKML;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2A768C0", Offset = "0x2A758C0", VA = "0x182A768C0")]
	public NLNJOLHCMIK(List<TData> HACMILLGFCL, GJDNBHMMLIA<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2A76800", Offset = "0x2A75800", VA = "0x182A76800", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct NNNHLOKIJAK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly IEnumerable<TData> BCMDMNPPPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly bool IENBKLEAGAM;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2A78D60", Offset = "0x2A77D60", VA = "0x182A78D60")]
	public NNNHLOKIJAK(IEnumerable<TData> LLGFHBBLPAM, bool IHJLMOPHMNB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7627B0", Offset = "0x761BB0")]
public class FCAELFJMEAL<TData> : GIMDCBDCKIG<GJDNBHMMLIA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762820", Offset = "0x761C20")]
	private readonly MLEEAHNNKPD<TData> JNBINLEDKML;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x16967A0", Offset = "0x16957A0", VA = "0x1816967A0")]
	public FCAELFJMEAL(List<TData> HACMILLGFCL, bool IHJLMOPHMNB, GJDNBHMMLIA<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1576AE0", Offset = "0x1575AE0", VA = "0x181576AE0", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface BHLEBHAOIFJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T EOHGDDIECBJ, [Optional] PIHMDDPJOEG? OCBHNJLEKLG, bool MAIFFEMNMIH = true);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int LEOAEOJMCHD, IEnumerable<T> OMMEOPKCKHJ, bool MAIFFEMNMIH = true);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int LEOAEOJMCHD, IEnumerable<T> OMMEOPKCKHJ, PIHMDDPJOEG OCBHNJLEKLG, bool MAIFFEMNMIH = true);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct NMMCGMODLAC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly IEnumerable<TData> LLGFHBBLPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly bool IHJLMOPHMNB;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2A77AC0", Offset = "0x2A76AC0", VA = "0x182A77AC0")]
	public NMMCGMODLAC(IEnumerable<TData> LLGFHBBLPAM, bool IHJLMOPHMNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762880", Offset = "0x761C80")]
public class IPNFMALAJMM<TData> : HIPCMANALKO<ENHLDPBCIPD<TData>, JGOGMPKIJMB> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7628F0", Offset = "0x761CF0")]
	private readonly NNNHLOKIJAK<TData> OFCPNCNGDFA;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xBFF510", Offset = "0xBFE510", VA = "0x180BFF510")]
	public IPNFMALAJMM(IEnumerable<TData> LLGFHBBLPAM, bool IHJLMOPHMNB, ENHLDPBCIPD<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xBFF230", Offset = "0xBFE230", VA = "0x180BFF230", Slot = "4")]
	public override Task<JGOGMPKIJMB> BCJGKBEDJFF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762950", Offset = "0x761D50")]
public class EJLDBDKLOOH<TData> : GIMDCBDCKIG<EFOJMAGMJCA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7629C0", Offset = "0x761DC0")]
	private readonly OLOMKFDDEEM<TData> NPCMAHNEKPM;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2AD1030", Offset = "0x2AD0030", VA = "0x182AD1030")]
	public EJLDBDKLOOH(TData FBOMMBLFPCD, bool IHJLMOPHMNB, EFOJMAGMJCA<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x16965A0", Offset = "0x16955A0", VA = "0x1816965A0", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct OLOMKFDDEEM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly TData FBOMMBLFPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly bool IHJLMOPHMNB;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x328B260", Offset = "0x328A260", VA = "0x18328B260")]
	public OLOMKFDDEEM(TData FBOMMBLFPCD, bool IHJLMOPHMNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct HNFGGCOMGHF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly IEnumerable<TData> LLGFHBBLPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool IHJLMOPHMNB;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2D8F6A0", Offset = "0x2D8E6A0", VA = "0x182D8F6A0")]
	public HNFGGCOMGHF(IEnumerable<TData> LLGFHBBLPAM, bool IHJLMOPHMNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762A20", Offset = "0x761E20")]
public class DHCDBLPLFMF<T> : GIMDCBDCKIG<EIJBAMJENFL<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x168D8A0", Offset = "0x168C8A0", VA = "0x18168D8A0")]
	public DHCDBLPLFMF(EIJBAMJENFL<T> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x296DA30", Offset = "0x296CA30", VA = "0x18296DA30", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762A90", Offset = "0x761E90")]
public class CECCIEGNGMO<TData> : GIMDCBDCKIG<KCILHIPEKAI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly MELIHEPCEON BHHAGFNCDFB;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2E36610", Offset = "0x2E35610", VA = "0x182E36610")]
	public CECCIEGNGMO(float JJMIOIPPABK, Vector3 LHJDGCBICFH, KCILHIPEKAI<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x231C6B0", Offset = "0x231B6B0", VA = "0x18231C6B0", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762B00", Offset = "0x761F00")]
public class FDMOIIHBDKM<TData> : GIMDCBDCKIG<HBHEMJCBMMB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x168D8A0", Offset = "0x168C8A0", VA = "0x18168D8A0")]
	public FDMOIIHBDKM(HBHEMJCBMMB<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2685BE0", Offset = "0x2684BE0", VA = "0x182685BE0", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762B70", Offset = "0x761F70")]
public class AIPACDIEHKL<TData> : GIMDCBDCKIG<HBHEMJCBMMB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762BE0", Offset = "0x761FE0")]
	private readonly LNCEHNIEKPK<TData> JLPOIIEPCKC;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x37DBBB0", Offset = "0x37DABB0", VA = "0x1837DBBB0")]
	public AIPACDIEHKL(IEnumerable<TData> LLGFHBBLPAM, bool IHJLMOPHMNB, HBHEMJCBMMB<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x16965A0", Offset = "0x16955A0", VA = "0x1816965A0", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762C40", Offset = "0x762040")]
public class ECPJCKMOADG<TNode> : GIMDCBDCKIG<ALLCFACLEME<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762CB0", Offset = "0x7620B0")]
	private readonly HGDHLPLBECI<TNode> GEGANEFPFNB;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x321A7E0", Offset = "0x32197E0", VA = "0x18321A7E0")]
	public ECPJCKMOADG(TNode NCOFNJONLFO, ALLCFACLEME<TNode> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x16965A0", Offset = "0x16955A0", VA = "0x1816965A0", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762D10", Offset = "0x762110")]
public class FBNJCPCKMFN<TData> : GIMDCBDCKIG<PBGHGJHGFIL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762D80", Offset = "0x762180")]
	private readonly HNFGGCOMGHF<TData> MKJHHLKHNJC;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1696700", Offset = "0x1695700", VA = "0x181696700")]
	public FBNJCPCKMFN(IEnumerable<TData> LLGFHBBLPAM, bool IHJLMOPHMNB, PBGHGJHGFIL<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x16965A0", Offset = "0x16955A0", VA = "0x1816965A0", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct LNCEHNIEKPK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IEnumerable<TData> LLGFHBBLPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly bool IHJLMOPHMNB;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x250FE50", Offset = "0x250EE50", VA = "0x18250FE50")]
	public LNCEHNIEKPK(IEnumerable<TData> LLGFHBBLPAM, bool IHJLMOPHMNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762DE0", Offset = "0x7621E0")]
public class OKOCOGOPINA<TNode> : GIMDCBDCKIG<ALLCFACLEME<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762E50", Offset = "0x762250")]
	private readonly HJLIIPAPDHC<TNode> MLFFODPNHGN;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x328A420", Offset = "0x3289420", VA = "0x18328A420")]
	public OKOCOGOPINA(TNode KHNFEIFCGJE, BNCAFONCJCD DDIBDPLHEND, ALLCFACLEME<TNode> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x328A360", Offset = "0x3289360", VA = "0x18328A360", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface ENHLDPBCIPD<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JGOGMPKIJMB> JCJNLAKKLAG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762EB0", Offset = "0x7622B0")] in NNNHLOKIJAK<TData> JNBINLEDKML, CancellationToken OAGBBBCDIGC);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface GJDNBHMMLIA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HPCNCOGBHHJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762F20", Offset = "0x762320")] in MLEEAHNNKPD<TData> JNBINLEDKML);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HEDNMPOONHJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x762F90", Offset = "0x762390")] in MLEEAHNNKPD<TData> JNBINLEDKML);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PBGEFFNOELM(in bool PIEKFADBGOM);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OKHBHHOPLNE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x763000", Offset = "0x762400")] in MLEEAHNNKPD<TData> JNBINLEDKML);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GCFCIEOJALA();

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KEBBDKDLKAM(in TData EDDHONMLECM);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct MDOHCKDBGMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly Quaternion FBKJPHHFAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly Vector3? LHJDGCBICFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly bool CJEIMDJAJAP;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x51D3510", Offset = "0x51D2510", VA = "0x1851D3510")]
	public MDOHCKDBGMF(Quaternion FBKJPHHFAEP, Vector3? LHJDGCBICFH, bool CJEIMDJAJAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface EFOJMAGMJCA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OPFFFHAFPLG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x763070", Offset = "0x762470")] in OLOMKFDDEEM<TData?> GEGANEFPFNB);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KGBMJLJOCJP(in IBOIMPPLHDK EHIDIMIMJLG);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KGBMJLJOCJP(in FEEBOGGDGJK EHIDIMIMJLG);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AGMLIKFMDJM();
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct PJLNKGKEPCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly Vector3 FBKJPHHFAEP;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2501E30", Offset = "0x2500E30", VA = "0x182501E30")]
	public PJLNKGKEPCK(Vector3 FBKJPHHFAEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7630E0", Offset = "0x7624E0")]
public class LEOKALAKAAM<T> : GIMDCBDCKIG<EIJBAMJENFL<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x763150", Offset = "0x762550")]
	private readonly ALMEOLOODJB<T> LMIHLCIGBEJ;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x268CC60", Offset = "0x268BC60", VA = "0x18268CC60")]
	public LEOKALAKAAM(T FBOMMBLFPCD, EIJBAMJENFL<T> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x16965A0", Offset = "0x16955A0", VA = "0x1816965A0", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7631B0", Offset = "0x7625B0")]
public class PAAMCKJIIBF<TData> : GIMDCBDCKIG<HLKKKLKLGCD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x763220", Offset = "0x762620")]
	private readonly KKBKOGEDIIH<TData> JLPOIIEPCKC;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2A83D30", Offset = "0x2A82D30", VA = "0x182A83D30")]
	public PAAMCKJIIBF(IEnumerable<TData> LLGFHBBLPAM, Quaternion FBKJPHHFAEP, Vector3? LHJDGCBICFH, bool CJEIMDJAJAP, bool IHJLMOPHMNB, HLKKKLKLGCD<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x16965A0", Offset = "0x16955A0", VA = "0x1816965A0", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x763280", Offset = "0x762680")]
public class ODDJLPEPPBP<TData> : GIMDCBDCKIG<KCILHIPEKAI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x168D8A0", Offset = "0x168C8A0", VA = "0x18168D8A0")]
	public ODDJLPEPPBP(KCILHIPEKAI<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2350BD0", Offset = "0x234FBD0", VA = "0x182350BD0", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7632F0", Offset = "0x7626F0")]
public class OGFBODFPFAM<TData> : GIMDCBDCKIG<HBHEMJCBMMB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly MDOHCKDBGMF JLPOIIEPCKC;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2FD5430", Offset = "0x2FD4430", VA = "0x182FD5430")]
	public OGFBODFPFAM(Quaternion FBKJPHHFAEP, Vector3? LHJDGCBICFH, bool CJEIMDJAJAP, HBHEMJCBMMB<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x231C6B0", Offset = "0x231B6B0", VA = "0x18231C6B0", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x763360", Offset = "0x762760")]
public class FJGKLGOAHMN<TData> : GIMDCBDCKIG<LCNIKNOOOCG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7633D0", Offset = "0x7627D0")]
	private readonly OKALNHPGMEG<TData> GBBJHPHLGLL;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2FB34B0", Offset = "0x2FB24B0", VA = "0x182FB34B0")]
	public FJGKLGOAHMN(TData[] LLGFHBBLPAM, KADGINDIKPL[] IFAEOGGHLKI, BACGCBKMFNG[] HDEIKJNIFFB, float[] EIDPFALKPDK, LCNIKNOOOCG<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2FB3320", Offset = "0x2FB2320", VA = "0x182FB3320", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x763430", Offset = "0x762830")]
public class IDBCNGBBLJF<TData> : GIMDCBDCKIG<GKHPLENMEHC<TData>> where TData : notnull, GCOKCNCEPPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7634A0", Offset = "0x7628A0")]
	private readonly BGDNJLIKPAJ<TData> FLLCECOPLOM;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1576BA0", Offset = "0x1575BA0", VA = "0x181576BA0")]
	public IDBCNGBBLJF(List<TData> LLGFHBBLPAM, List<bool> EMNHEKNBMHE, GKHPLENMEHC<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1576AE0", Offset = "0x1575AE0", VA = "0x181576AE0", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x763500", Offset = "0x762900")]
public class AJDGHIOGCGH<TData> : GIMDCBDCKIG<PBGHGJHGFIL<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x168D8A0", Offset = "0x168C8A0", VA = "0x18168D8A0")]
	public AJDGHIOGCGH(PBGHGJHGFIL<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2685BE0", Offset = "0x2684BE0", VA = "0x182685BE0", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct IBOIMPPLHDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly Vector3 DOFBOOADCDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool ECPIACBFMJE;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x72DE1C0", Offset = "0x72DD1C0", VA = "0x1872DE1C0")]
	public IBOIMPPLHDK(Vector3 DOFBOOADCDE, bool ECPIACBFMJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct OKFGKEPMHDI<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T FBOMMBLFPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly bool OJJHAELHPDG;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3285CB0", Offset = "0x3284CB0", VA = "0x183285CB0")]
	public OKFGKEPMHDI(T IMCFPOPBFBG, bool NDGDJBGGKMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface MHMCFONMHGB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KGBMJLJOCJP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x763570", Offset = "0x762970")] in HOHFIEBHEEE<TData?> GBBJHPHLGLL);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AGMLIKFMDJM();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7635E0", Offset = "0x7629E0")]
public class OGNHAGAHMJL<TData> : GIMDCBDCKIG<MHMCFONMHGB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x763650", Offset = "0x762A50")]
	private readonly HOHFIEBHEEE<TData> GBBJHPHLGLL;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2FDB1A0", Offset = "0x2FDA1A0", VA = "0x182FDB1A0")]
	public OGNHAGAHMJL(IEnumerable<TData> LLGFHBBLPAM, KADGINDIKPL IFAEOGGHLKI, BACGCBKMFNG HDEIKJNIFFB, float EIDPFALKPDK, MHMCFONMHGB<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2FB3320", Offset = "0x2FB2320", VA = "0x182FB3320", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface GCOKCNCEPPO
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool KIHOPEDJBJG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7636B0", Offset = "0x762AB0")]
public class BHMMCKCHCGP<TData> : GIMDCBDCKIG<EFOJMAGMJCA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly FEEBOGGDGJK NPCMAHNEKPM;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x23B6290", Offset = "0x23B5290", VA = "0x1823B6290")]
	public BHMMCKCHCGP(Guid HIJPOFLLMCD, int CCELBNKPBGB, Vector3 NKMKMKDMOMJ, Quaternion NMKLOHCPMNL, float MFIGFOJHONE, bool ECPIACBFMJE, EFOJMAGMJCA<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x23B6220", Offset = "0x23B5220", VA = "0x1823B6220", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x763720", Offset = "0x762B20")]
public class JJPJIFHDDOC<TData> : GIMDCBDCKIG<GKHPLENMEHC<TData>> where TData : notnull, GCOKCNCEPPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x763790", Offset = "0x762B90")]
	private readonly LNMMEALFHGF<TData> FLLCECOPLOM;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2DF7810", Offset = "0x2DF6810", VA = "0x182DF7810")]
	public JJPJIFHDDOC(List<TData> LLGFHBBLPAM, bool GLABJEBJOMF, GKHPLENMEHC<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x16965A0", Offset = "0x16955A0", VA = "0x1816965A0", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7637F0", Offset = "0x762BF0")]
public class HHMDIMLMJHG<TData> : GIMDCBDCKIG<GJDNBHMMLIA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly TData EDDHONMLECM;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2843AE0", Offset = "0x2842AE0", VA = "0x182843AE0")]
	public HHMDIMLMJHG(TData EDDHONMLECM, GJDNBHMMLIA<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2843A20", Offset = "0x2842A20", VA = "0x182843A20", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x763860", Offset = "0x762C60")]
public abstract class GIMDCBDCKIG<TReceiver> : LKKJLKLBLKE<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x168D8A0", Offset = "0x168C8A0", VA = "0x18168D8A0")]
	public GIMDCBDCKIG(TReceiver NGIMGJJIBJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface KBFKGDPPPEO
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Bounds HLIBBGHOFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Transform IOEIGJIGECG
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Bounds PBAPJMNJNDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Transform EFNBPHPDLKF
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Vector3 IJEEGDEONOD
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool OGFEGKGEKGP = true, int DNOGEIPPBNK = 0);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct LNMMEALFHGF<TData> where TData : notnull, GCOKCNCEPPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public IEnumerable<TData> BCMDMNPPPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public bool GLABJEBJOMF;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2510590", Offset = "0x250F590", VA = "0x182510590")]
	public LNMMEALFHGF(IEnumerable<TData> OEHJLMFHHAN, bool BEIIBPCBNMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct BGDNJLIKPAJ<TData> where TData : notnull, GCOKCNCEPPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public List<TData> BCMDMNPPPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public List<bool> EMNHEKNBMHE;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2BE0170", Offset = "0x2BDF170", VA = "0x182BE0170")]
	public BGDNJLIKPAJ(List<TData> OEHJLMFHHAN, List<bool> LGNAKODHMOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface LMEHGGGEHHJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool GKGEDMFADCN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int DBJGPGEFIAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<TData> IEAPEILOCIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData JFJFAONKKJC);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData JFJFAONKKJC);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface EJHFIDBIAOP
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface PBGHGJHGFIL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OPFFFHAFPLG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7638D0", Offset = "0x762CD0")] in HNFGGCOMGHF<TData?> EFFPMLCKJLL);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KGBMJLJOCJP(in PJLNKGKEPCK EHIDIMIMJLG);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AGMLIKFMDJM();
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x763940", Offset = "0x762D40")]
public class JEKJLHDFKHB<TData> : GIMDCBDCKIG<MHMCFONMHGB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x168D8A0", Offset = "0x168C8A0", VA = "0x18168D8A0")]
	public JEKJLHDFKHB(MHMCFONMHGB<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2441290", Offset = "0x2440290", VA = "0x182441290", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface JOFLHFNNGLL : GCOKCNCEPPO
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7639B0", Offset = "0x762DB0")]
public abstract class HIPCMANALKO<TReceiver, TFromTask> : LKKJLKLBLKE<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x168D8A0", Offset = "0x168C8A0", VA = "0x18168D8A0")]
	public HIPCMANALKO(TReceiver NGIMGJJIBJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface EIJBAMJENFL<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OPFFFHAFPLG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x763A20", Offset = "0x762E20")] in ALMEOLOODJB<T?> LMIHLCIGBEJ);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AGMLIKFMDJM();
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x763A90", Offset = "0x762E90")]
public class DOCDIGIEJGM<TData> : GIMDCBDCKIG<KCILHIPEKAI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x763B00", Offset = "0x762F00")]
	private readonly NMMCGMODLAC<TData> BHHAGFNCDFB;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x23126A0", Offset = "0x23116A0", VA = "0x1823126A0")]
	public DOCDIGIEJGM(IEnumerable<TData> LLGFHBBLPAM, bool IHJLMOPHMNB, KCILHIPEKAI<TData> NGIMGJJIBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x16965A0", Offset = "0x16955A0", VA = "0x1816965A0", Slot = "4")]
	public override bool BCJGKBEDJFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface MAIOCKKPOID<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BCJGKBEDJFF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x763B60", Offset = "0x762F60")] in IOJECPPABFJ<TData?> GBBJHPHLGLL);
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

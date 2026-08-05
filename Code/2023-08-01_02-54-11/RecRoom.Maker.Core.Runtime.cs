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
		[Cpp2IlInjected.Address(RVA = "0x8484E0", Offset = "0x8474E0", VA = "0x1808484E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x729ECA0", Offset = "0x729DCA0", VA = "0x18729ECA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB36FF0", Offset = "0xB35FF0", VA = "0x180B36FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x183B060", Offset = "0x183A060", VA = "0x18183B060")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73ED60", Offset = "0x73E160")]
public class NPCAEMCMAKL<TData> : PFEBHDPFNDF<MJHEPAOMEBJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly AADODELIGBP KJLPLIIJLBA;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A82120", Offset = "0x2A81120", VA = "0x182A82120")]
	public NPCAEMCMAKL(Vector3 MJLMKCINECL, bool POMJEPILKBG, MJHEPAOMEBJ<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x184FFB0", Offset = "0x184EFB0", VA = "0x18184FFB0", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct LCOEDMPCPMD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public IEnumerable<TData> GIPBFJHOCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public bool BNJHFJBABJM;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x20E3B80", Offset = "0x20E2B80", VA = "0x1820E3B80")]
	public LCOEDMPCPMD(IEnumerable<TData> CNIDDMMDMBE, bool OFFLCCGPAGI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DIPAJJGOBCJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EDFGPBNAKOA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73EE10", Offset = "0x73E210")] in LGKEJLJGLLL<TData?> EOACFFKCBCE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BJHKOLJNBIM(in FJBOGPAEBDN FLOLHKJECHD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BJHKOLJNBIM(in EBKCBALFEGJ FLOLHKJECHD);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AEHEMOCDMID();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct CGOMODLFLKP<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public TNode ILKCFLJDPJL;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2179000", Offset = "0x2178000", VA = "0x182179000")]
	public CGOMODLFLKP(TNode ILKCFLJDPJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct ABEAIDBMMGK<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TNode BGCPEFBHFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public ECAOLOKKKOC PAJHFCGGPGP;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3D4F750", Offset = "0x3D4E750", VA = "0x183D4F750")]
	public ABEAIDBMMGK(TNode BGCPEFBHFNH, ECAOLOKKKOC PAJHFCGGPGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73EE80", Offset = "0x73E280")]
public class NLFCJCEGDPP<TData> : PFEBHDPFNDF<KHBOOGFPDPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73EEF0", Offset = "0x73E2F0")]
	private readonly LCOEDMPCPMD<TData> EAGCFLEOMKC;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CAB0", Offset = "0x2A7BAB0", VA = "0x182A7CAB0")]
	public NLFCJCEGDPP(List<TData> GDJIPDMDHHM, KHBOOGFPDPG<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1A3EFF0", Offset = "0x1A3DFF0", VA = "0x181A3EFF0", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OGONLKELGEO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOKLPJBHLIC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73EF50", Offset = "0x73E350")] in GONHBCJICIJ<TData?> PHAIHCNJHOB);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct LEJEBNMHAIA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> GIPBFJHOCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public EABGJBJDCKI KNBPAEHNMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public EDOGAFJMIEH DKPLEGBPFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float FMGGCEDDFJH;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2E65F90", Offset = "0x2E64F90", VA = "0x182E65F90")]
	public LEJEBNMHAIA(IEnumerable<TData> CLLPMDMHGMJ, EABGJBJDCKI OAIMCLIJEAP, EDOGAFJMIEH AKEPBJIDOFF, float FMGGCEDDFJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal static class AINKIIEIGFA
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x729E590", Offset = "0x729D590", VA = "0x18729E590")]
	public static void MPCIBMFJCGD(IEnumerable NALKKEFIEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2A30780", Offset = "0x2A2F780", VA = "0x182A30780")]
	public static void MPCIBMFJCGD<T>(T[] OGEGDDKCPPH) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KINBPOCMMJF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOKLPJBHLIC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73EFC0", Offset = "0x73E3C0")] in NMJCDJKJAIE<T?> KLPDCLJMNKB);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct LIJLCPKMDHD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public TData[] GIPBFJHOCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public EABGJBJDCKI[] KNBPAEHNMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public EDOGAFJMIEH[] DKPLEGBPFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public float[] FMGGCEDDFJH;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2E72120", Offset = "0x2E71120", VA = "0x182E72120")]
	public LIJLCPKMDHD(TData[] CLLPMDMHGMJ, EABGJBJDCKI[] OAIMCLIJEAP, EDOGAFJMIEH[] AKEPBJIDOFF, float[] FMGGCEDDFJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NIPCKANIJFD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PIDEMFPFHMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool AGMKOGKMIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool DODMMPOLOMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool AEICFFMNKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct KEPNJHMHBFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly Guid KEICBHGGNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly int EJNMEMKEIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly Vector3 EDEGPGKBEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly Quaternion DEANJFCCEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly float CADELOLNNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool POMJEPILKBG;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x729E820", Offset = "0x729D820", VA = "0x18729E820")]
	public KEPNJHMHBFL(Guid KEICBHGGNOJ, int EJNMEMKEIOD, Vector3 EDEGPGKBEGA, Quaternion DEANJFCCEBG, float CADELOLNNHN, bool POMJEPILKBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MGNKGHPHAMA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EDFGPBNAKOA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73F030", Offset = "0x73E430")] in BANEDNMFNEC<TData?> EOACFFKCBCE);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BJHKOLJNBIM(in AAHKMCNFPPO FLOLHKJECHD);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AEHEMOCDMID();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct FJBOGPAEBDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly float BMIGADDGEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly Vector3 NOEDLJBJHJO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5014F20", Offset = "0x5013F20", VA = "0x185014F20")]
	public FJBOGPAEBDN(float BMIGADDGEGN, Vector3 NOEDLJBJHJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct EBKCBALFEGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly Vector3 ANJIKKOGIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly float BMIGADDGEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 NOEDLJBJHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly bool POMJEPILKBG;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x729E7F0", Offset = "0x729D7F0", VA = "0x18729E7F0")]
	public EBKCBALFEGJ(Vector3 ANJIKKOGIGP, float BMIGADDGEGN, Vector3 NOEDLJBJHJO, bool POMJEPILKBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73F0A0", Offset = "0x73E4A0")]
public class JEMCDAIHINC<TData> : PFEBHDPFNDF<GIMOIMNDHIM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly GBEOMCMNFKN NODAFDFPLFJ;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x28FF420", Offset = "0x28FE420", VA = "0x1828FF420")]
	public JEMCDAIHINC(Vector3 KLOIBPHHLND, GIMOIMNDHIM<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x184FFB0", Offset = "0x184EFB0", VA = "0x18184FFB0", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CGHLLDJCJGG<TData> where TData : ENPDBHJPNNM
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOKLPJBHLIC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73F110", Offset = "0x73E510")] in KDDEFGNCIFA<TData> EGILFDCIBFJ);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOKLPJBHLIC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73F180", Offset = "0x73E580")] in HCKDENHBFIG<TData> EGILFDCIBFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class NKMNGFNBFAC
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum OMPKGJIMLPP
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3121200", Offset = "0x3120200", VA = "0x183121200")]
	public static void DOAKOAIEJDD<T>(T CKGLHMMPGOL, OMPKGJIMLPP FLAJIGGIBOB) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3121380", Offset = "0x3120380", VA = "0x183121380")]
	public static void DOAKOAIEJDD<T>(T CKGLHMMPGOL) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3121540", Offset = "0x3120540", VA = "0x183121540")]
	public static void JGOBMFDJFJD<T>(T CKGLHMMPGOL) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3121480", Offset = "0x3120480", VA = "0x183121480")]
	public static T EAOPAIAIDNN<T>(OMPKGJIMLPP FLAJIGGIBOB) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3121410", Offset = "0x3120410", VA = "0x183121410")]
	public static T EAOPAIAIDNN<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3121190", Offset = "0x3120190", VA = "0x183121190")]
	public static bool BMAFBKNNEIP<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73F1F0", Offset = "0x73E5F0")]
public class ICLIKBHCFJP<TData> : PFEBHDPFNDF<KHBOOGFPDPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xEDC0B0", Offset = "0xEDB0B0", VA = "0x180EDC0B0")]
	public ICLIKBHCFJP(KHBOOGFPDPG<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x18595E0", Offset = "0x18585E0", VA = "0x1818595E0", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface IMBMPBEGKOO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 DPJJEDGKGBN, Vector3 HAMNFFBEFHD, float OLGGKIEPHEF, out T JJJAIOMCAKL, out Vector3 MFOMOIPCGLK, out Collider MFCMFBIOCDA);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 DPJJEDGKGBN, Vector3 HAMNFFBEFHD, float FBAHIMLGMLD, float OLGGKIEPHEF, T[] PPGNOGPIPEA, out Vector3 PDBOMLGCPGD, out Collider COGNEKGIJCB);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 DPJJEDGKGBN, float FBAHIMLGMLD, Vector3 LJBGEHHGDNA, T[] PPGNOGPIPEA);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class OBGFKEEJMNB<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	protected TReceiver BAHDDPNEAIB;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B230", Offset = "0x2C1A230", VA = "0x182C1B230")]
	public OBGFKEEJMNB(TReceiver BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute DOKLPJBHLIC();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73F260", Offset = "0x73E660")]
public class JFEIEIHMOFD<TData> : PFEBHDPFNDF<BDPELIPDALC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73F2D0", Offset = "0x73E6D0")]
	private readonly FMCDDIIGAHB<TData> DEDHNIMNFKO;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2900960", Offset = "0x28FF960", VA = "0x182900960")]
	public JFEIEIHMOFD(IEnumerable<TData> CLLPMDMHGMJ, EABGJBJDCKI OAIMCLIJEAP, EDOGAFJMIEH AKEPBJIDOFF, float FMGGCEDDFJH, bool BNJHFJBABJM, BDPELIPDALC<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1A3EFF0", Offset = "0x1A3DFF0", VA = "0x181A3EFF0", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73F330", Offset = "0x73E730")]
public class NFBPEMOPOHE<TData> : PFEBHDPFNDF<MJHEPAOMEBJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xEDC0B0", Offset = "0xEDB0B0", VA = "0x180EDC0B0")]
	public NFBPEMOPOHE(MJHEPAOMEBJ<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2640020", Offset = "0x263F020", VA = "0x182640020", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73F3A0", Offset = "0x73E7A0")]
public class PLGKACNFBDC<TData> : PFEBHDPFNDF<JLNNGFLAIIA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73F410", Offset = "0x73E810")]
	private readonly NAOFNPHBDFP<TData> NODAFDFPLFJ;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1E79820", Offset = "0x1E78820", VA = "0x181E79820")]
	public PLGKACNFBDC(IEnumerable<TData> CLLPMDMHGMJ, Vector3 KLOIBPHHLND, bool BNJHFJBABJM, JLNNGFLAIIA<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1A3EFF0", Offset = "0x1A3DFF0", VA = "0x181A3EFF0", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct NAOFNPHBDFP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly IEnumerable<TData> CLLPMDMHGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly Vector3 KLOIBPHHLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly bool BNJHFJBABJM;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2864B70", Offset = "0x2863B70", VA = "0x182864B70")]
	public NAOFNPHBDFP(IEnumerable<TData> CLLPMDMHGMJ, Vector3 KLOIBPHHLND, bool BNJHFJBABJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface JLNNGFLAIIA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOKLPJBHLIC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73F4B0", Offset = "0x73E8B0")] in NAOFNPHBDFP<TData?> NODAFDFPLFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73F520", Offset = "0x73E920")]
public class LKHDIFONILE<TData> : PFEBHDPFNDF<KHBOOGFPDPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly bool BNJHFJBABJM;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2E774B0", Offset = "0x2E764B0", VA = "0x182E774B0")]
	public LKHDIFONILE(bool BNJHFJBABJM, KHBOOGFPDPG<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2E77440", Offset = "0x2E76440", VA = "0x182E77440", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface AMCBENFMCFK<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EDFGPBNAKOA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73F590", Offset = "0x73E990")] in CGOMODLFLKP<TNode?> EOACFFKCBCE);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AEHEMOCDMID([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73F600", Offset = "0x73EA00")] in ABEAIDBMMGK<TNode?> NCINPBLBFHO);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PFAIOBJANEL();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73F670", Offset = "0x73EA70")]
public class KDOGBEMDFPA<TNode> : PFEBHDPFNDF<AMCBENFMCFK<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xEDC0B0", Offset = "0xEDB0B0", VA = "0x180EDC0B0")]
	public KDOGBEMDFPA(AMCBENFMCFK<TNode> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1F356D0", Offset = "0x1F346D0", VA = "0x181F356D0", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface GIAOLDIFPNG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOKLPJBHLIC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73F6E0", Offset = "0x73EAE0")] in LIJLCPKMDHD<TData?> DEDHNIMNFKO);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class NFCJOPNCDII
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private struct EAHHAEFLAPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public bool KGBIGGEICHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public ECDJHHJLGGB DELEMCNPOJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ECDJHHJLGGB EKMGMOCDBNJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static EAHHAEFLAPH FNFAPANIHPI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static CancellationToken COLCFIHLHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x729E990", Offset = "0x729D990", VA = "0x18729E990")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal static ECDJHHJLGGB DELEMCNPOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x729E860", Offset = "0x729D860", VA = "0x18729E860")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x729EAA0", Offset = "0x729DAA0", VA = "0x18729EAA0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x729E9F0", Offset = "0x729D9F0", VA = "0x18729E9F0")]
	[OHDKPIIHCBL(OMGGGJAFEOF.Room, BGEACDHIFOF.None)]
	private static void NBGHEENHDLH(ECDJHHJLGGB FHHKHGMNKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x729EB20", Offset = "0x729DB20", VA = "0x18729EB20")]
	public static void OMJIIKCHOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x729E940", Offset = "0x729D940", VA = "0x18729E940")]
	private static ECDJHHJLGGB BCJOPNHENFB(ECDJHHJLGGB GBECFLMEHHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface GAAGHCPEANA<TData> : FENHPLBLOMO, INGMFAGNDPL<TData>, KHBOOGFPDPG<TData>, ECBNHMOJJNM<TData>, NIPCKANIJFD, IMBMPBEGKOO<TData>, KGMDFIJFOEK
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct GONHBCJICIJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly IEnumerable<TData> CLLPMDMHGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly Quaternion KLOIBPHHLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly Vector3? NOEDLJBJHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly bool JBFONGEPNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool BNJHFJBABJM;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x25D3570", Offset = "0x25D2570", VA = "0x1825D3570")]
	public GONHBCJICIJ(IEnumerable<TData> CLLPMDMHGMJ, Quaternion KLOIBPHHLND, Vector3? NOEDLJBJHJO, bool JBFONGEPNDN, bool BNJHFJBABJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73F770", Offset = "0x73EB70")]
public class AMJCMJKFDDP<T> : PFEBHDPFNDF<KINBPOCMMJF<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73F7E0", Offset = "0x73EBE0")]
	private readonly NMJCDJKJAIE<T> KLPDCLJMNKB;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x20637C0", Offset = "0x20627C0", VA = "0x1820637C0")]
	public AMJCMJKFDDP(T EEMPMGBFHEC, bool MMNFDNKKDNL, KINBPOCMMJF<T> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1A3EFF0", Offset = "0x1A3DFF0", VA = "0x181A3EFF0", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct FMCDDIIGAHB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public IEnumerable<TData> GIPBFJHOCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public EABGJBJDCKI KNBPAEHNMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public EDOGAFJMIEH DKPLEGBPFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float FMGGCEDDFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public bool BNJHFJBABJM;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x40A9F30", Offset = "0x40A8F30", VA = "0x1840A9F30")]
	public FMCDDIIGAHB(IEnumerable<TData> CLLPMDMHGMJ, EABGJBJDCKI OAIMCLIJEAP, EDOGAFJMIEH AKEPBJIDOFF, float FMGGCEDDFJH, bool BNJHFJBABJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73F840", Offset = "0x73EC40")]
public class IBIBGAOHOLI<TData> : PFEBHDPFNDF<DIPAJJGOBCJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly EBKCBALFEGJ GPPDECBBOHA;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x18512B0", Offset = "0x18502B0", VA = "0x1818512B0")]
	public IBIBGAOHOLI(Vector3 ANJIKKOGIGP, float BMIGADDGEGN, Vector3 NOEDLJBJHJO, bool JFMOIMHCJEF, DIPAJJGOBCJ<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1851240", Offset = "0x1850240", VA = "0x181851240", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct GLFOOGAAIFK<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T EEMPMGBFHEC;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1859E70", Offset = "0x1858E70", VA = "0x181859E70")]
	public GLFOOGAAIFK(T POMANEOGNOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73F8B0", Offset = "0x73ECB0")]
public class DAFKDKLLANH<TData> : PFEBHDPFNDF<KHBOOGFPDPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73F920", Offset = "0x73ED20")]
	private readonly LCOEDMPCPMD<TData> EAGCFLEOMKC;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D580", Offset = "0x2E1C580", VA = "0x182E1D580")]
	public DAFKDKLLANH(List<TData> GDJIPDMDHHM, KHBOOGFPDPG<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D4C0", Offset = "0x2E1C4C0", VA = "0x182E1D4C0", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct ADPILLKLIOO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly IEnumerable<TData> GIPBFJHOCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly bool EDEEJIPBGFP;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2FAA7E0", Offset = "0x2FA97E0", VA = "0x182FAA7E0")]
	public ADPILLKLIOO(IEnumerable<TData> CLLPMDMHGMJ, bool BNJHFJBABJM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73F9C0", Offset = "0x73EDC0")]
public class JIIGLCOMMCL<TData> : PFEBHDPFNDF<KHBOOGFPDPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73FA30", Offset = "0x73EE30")]
	private readonly LCOEDMPCPMD<TData> EAGCFLEOMKC;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x290C8C0", Offset = "0x290B8C0", VA = "0x18290C8C0")]
	public JIIGLCOMMCL(List<TData> GDJIPDMDHHM, bool BNJHFJBABJM, KHBOOGFPDPG<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1E76AC0", Offset = "0x1E75AC0", VA = "0x181E76AC0", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface INGMFAGNDPL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T DCGPCJKHCOO, [Optional] KKAMNNCNEEM? AOGHJNLEEHB, bool DKBFFNCEFEL = true);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int PFDGPOIGHFM, IEnumerable<T> IOBPFBILMIA, bool DKBFFNCEFEL = true);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int PFDGPOIGHFM, IEnumerable<T> IOBPFBILMIA, KKAMNNCNEEM AOGHJNLEEHB, bool DKBFFNCEFEL = true);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct LGKEJLJGLLL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly IEnumerable<TData> CLLPMDMHGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly bool BNJHFJBABJM;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2E66930", Offset = "0x2E65930", VA = "0x182E66930")]
	public LGKEJLJGLLL(IEnumerable<TData> CLLPMDMHGMJ, bool BNJHFJBABJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73FA90", Offset = "0x73EE90")]
public class PBHALOLOCJK<TData> : DDEHHIHBAFI<ODEHPMCLHDG<TData>, GEGKLAHENNH> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73FB00", Offset = "0x73EF00")]
	private readonly ADPILLKLIOO<TData> CAPIKCKNBEA;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x32D7D30", Offset = "0x32D6D30", VA = "0x1832D7D30")]
	public PBHALOLOCJK(IEnumerable<TData> CLLPMDMHGMJ, bool BNJHFJBABJM, ODEHPMCLHDG<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x32D7AF0", Offset = "0x32D6AF0", VA = "0x1832D7AF0", Slot = "4")]
	public override Task<GEGKLAHENNH> DOKLPJBHLIC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73FB60", Offset = "0x73EF60")]
public class DEDJOJKJIDB<TData> : PFEBHDPFNDF<MJHEPAOMEBJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73FBD0", Offset = "0x73EFD0")]
	private readonly FACDKKHJHII<TData> KJLPLIIJLBA;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x268AE20", Offset = "0x2689E20", VA = "0x18268AE20")]
	public DEDJOJKJIDB(TData EEMPMGBFHEC, bool BNJHFJBABJM, MJHEPAOMEBJ<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1A3EFF0", Offset = "0x1A3DFF0", VA = "0x181A3EFF0", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct FACDKKHJHII<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly TData EEMPMGBFHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly bool BNJHFJBABJM;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xEDF930", Offset = "0xEDE930", VA = "0x180EDF930")]
	public FACDKKHJHII(TData EEMPMGBFHEC, bool BNJHFJBABJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct FNLGODJLIMK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly IEnumerable<TData> CLLPMDMHGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool BNJHFJBABJM;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x35CE9D0", Offset = "0x35CD9D0", VA = "0x1835CE9D0")]
	public FNLGODJLIMK(IEnumerable<TData> CLLPMDMHGMJ, bool BNJHFJBABJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73FC30", Offset = "0x73F030")]
public class EDNOFKFMBKN<T> : PFEBHDPFNDF<LPKMHGOIMCP<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xEDC0B0", Offset = "0xEDB0B0", VA = "0x180EDC0B0")]
	public EDNOFKFMBKN(LPKMHGOIMCP<T> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1F57B20", Offset = "0x1F56B20", VA = "0x181F57B20", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73FCA0", Offset = "0x73F0A0")]
public class BNAPBMGNOIF<TData> : PFEBHDPFNDF<DIPAJJGOBCJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly FJBOGPAEBDN GPPDECBBOHA;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x26407A0", Offset = "0x263F7A0", VA = "0x1826407A0")]
	public BNAPBMGNOIF(float BMIGADDGEGN, Vector3 NOEDLJBJHJO, DIPAJJGOBCJ<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x184FFB0", Offset = "0x184EFB0", VA = "0x18184FFB0", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73FD10", Offset = "0x73F110")]
public class OJBEHODEDEF<TData> : PFEBHDPFNDF<MGNKGHPHAMA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xEDC0B0", Offset = "0xEDB0B0", VA = "0x180EDC0B0")]
	public OJBEHODEDEF(MGNKGHPHAMA<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1F356D0", Offset = "0x1F346D0", VA = "0x181F356D0", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73FD80", Offset = "0x73F180")]
public class BEDCKCDKPGG<TData> : PFEBHDPFNDF<MGNKGHPHAMA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73FDF0", Offset = "0x73F1F0")]
	private readonly BANEDNMFNEC<TData> PHAIHCNJHOB;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3E00F00", Offset = "0x3DFFF00", VA = "0x183E00F00")]
	public BEDCKCDKPGG(IEnumerable<TData> CLLPMDMHGMJ, bool BNJHFJBABJM, MGNKGHPHAMA<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1A3EFF0", Offset = "0x1A3DFF0", VA = "0x181A3EFF0", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73FE50", Offset = "0x73F250")]
public class MBKCOIJLANL<TNode> : PFEBHDPFNDF<AMCBENFMCFK<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73FEC0", Offset = "0x73F2C0")]
	private readonly CGOMODLFLKP<TNode> EOACFFKCBCE;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x29D7CD0", Offset = "0x29D6CD0", VA = "0x1829D7CD0")]
	public MBKCOIJLANL(TNode OMLMMJFFMHD, AMCBENFMCFK<TNode> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1A3EFF0", Offset = "0x1A3DFF0", VA = "0x181A3EFF0", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73FF20", Offset = "0x73F320")]
public class MGECFBEKLLC<TData> : PFEBHDPFNDF<GIMOIMNDHIM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73FF90", Offset = "0x73F390")]
	private readonly FNLGODJLIMK<TData> NODAFDFPLFJ;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x29E13B0", Offset = "0x29E03B0", VA = "0x1829E13B0")]
	public MGECFBEKLLC(IEnumerable<TData> CLLPMDMHGMJ, bool BNJHFJBABJM, GIMOIMNDHIM<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1A3EFF0", Offset = "0x1A3DFF0", VA = "0x181A3EFF0", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct BANEDNMFNEC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IEnumerable<TData> CLLPMDMHGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly bool BNJHFJBABJM;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x53D25B0", Offset = "0x53D15B0", VA = "0x1853D25B0")]
	public BANEDNMFNEC(IEnumerable<TData> CLLPMDMHGMJ, bool BNJHFJBABJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73FFF0", Offset = "0x73F3F0")]
public class FCHFEPKOGOL<TNode> : PFEBHDPFNDF<AMCBENFMCFK<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x740060", Offset = "0x73F460")]
	private readonly ABEAIDBMMGK<TNode> NCINPBLBFHO;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xEE6A10", Offset = "0xEE5A10", VA = "0x180EE6A10")]
	public FCHFEPKOGOL(TNode BGCPEFBHFNH, ECAOLOKKKOC PAJHFCGGPGP, AMCBENFMCFK<TNode> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xEE6950", Offset = "0xEE5950", VA = "0x180EE6950", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface ODEHPMCLHDG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GEGKLAHENNH> HHLLIFLPPLP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7400C0", Offset = "0x73F4C0")] in ADPILLKLIOO<TData> EAGCFLEOMKC, CancellationToken AOAEIGNDKPI);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface KHBOOGFPDPG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FPMGALJIFNL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x740130", Offset = "0x73F530")] in LCOEDMPCPMD<TData> EAGCFLEOMKC);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CCMEHDOAPDP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7401A0", Offset = "0x73F5A0")] in LCOEDMPCPMD<TData> EAGCFLEOMKC);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FBEEJKINJLE(in bool OKFHHDMEJCM);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NDLPMJALHIP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x740210", Offset = "0x73F610")] in LCOEDMPCPMD<TData> EAGCFLEOMKC);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DDOKMLLLKHB();

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OCBKGGCBGJE(in TData KILHLPBGPIC);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct AAHKMCNFPPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly Quaternion KLOIBPHHLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly Vector3? NOEDLJBJHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly bool JBFONGEPNDN;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5B4A160", Offset = "0x5B49160", VA = "0x185B4A160")]
	public AAHKMCNFPPO(Quaternion KLOIBPHHLND, Vector3? NOEDLJBJHJO, bool JBFONGEPNDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface MJHEPAOMEBJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EDFGPBNAKOA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x740280", Offset = "0x73F680")] in FACDKKHJHII<TData?> EOACFFKCBCE);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BJHKOLJNBIM(in AADODELIGBP FLOLHKJECHD);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BJHKOLJNBIM(in KEPNJHMHBFL FLOLHKJECHD);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AEHEMOCDMID();
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct GBEOMCMNFKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly Vector3 KLOIBPHHLND;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1859EA0", Offset = "0x1858EA0", VA = "0x181859EA0")]
	public GBEOMCMNFKN(Vector3 KLOIBPHHLND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7402F0", Offset = "0x73F6F0")]
public class GOHHNGPHOHD<T> : PFEBHDPFNDF<LPKMHGOIMCP<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x740360", Offset = "0x73F760")]
	private readonly GLFOOGAAIFK<T> CJIHJMBEIBN;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x25D24E0", Offset = "0x25D14E0", VA = "0x1825D24E0")]
	public GOHHNGPHOHD(T EEMPMGBFHEC, LPKMHGOIMCP<T> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1A3EFF0", Offset = "0x1A3DFF0", VA = "0x181A3EFF0", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7403C0", Offset = "0x73F7C0")]
public class JCIFAMNFPBC<TData> : PFEBHDPFNDF<OGONLKELGEO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x740430", Offset = "0x73F830")]
	private readonly GONHBCJICIJ<TData> PHAIHCNJHOB;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x31EAF90", Offset = "0x31E9F90", VA = "0x1831EAF90")]
	public JCIFAMNFPBC(IEnumerable<TData> CLLPMDMHGMJ, Quaternion KLOIBPHHLND, Vector3? NOEDLJBJHJO, bool JBFONGEPNDN, bool BNJHFJBABJM, OGONLKELGEO<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1A3EFF0", Offset = "0x1A3DFF0", VA = "0x181A3EFF0", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x740490", Offset = "0x73F890")]
public class BMJHNAKEMHE<TData> : PFEBHDPFNDF<DIPAJJGOBCJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xEDC0B0", Offset = "0xEDB0B0", VA = "0x180EDC0B0")]
	public BMJHNAKEMHE(DIPAJJGOBCJ<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2640020", Offset = "0x263F020", VA = "0x182640020", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x740500", Offset = "0x73F900")]
public class IAHKGMLOPAC<TData> : PFEBHDPFNDF<MGNKGHPHAMA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly AAHKMCNFPPO PHAIHCNJHOB;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1850020", Offset = "0x184F020", VA = "0x181850020")]
	public IAHKGMLOPAC(Quaternion KLOIBPHHLND, Vector3? NOEDLJBJHJO, bool JBFONGEPNDN, MGNKGHPHAMA<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x184FFB0", Offset = "0x184EFB0", VA = "0x18184FFB0", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x740570", Offset = "0x73F970")]
public class FGNBJDNCKJD<TData> : PFEBHDPFNDF<GIAOLDIFPNG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7405E0", Offset = "0x73F9E0")]
	private readonly LIJLCPKMDHD<TData> DEDHNIMNFKO;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1F03490", Offset = "0x1F02490", VA = "0x181F03490")]
	public FGNBJDNCKJD(TData[] CLLPMDMHGMJ, EABGJBJDCKI[] OAIMCLIJEAP, EDOGAFJMIEH[] AKEPBJIDOFF, float[] FMGGCEDDFJH, GIAOLDIFPNG<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1F033D0", Offset = "0x1F023D0", VA = "0x181F033D0", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x740640", Offset = "0x73FA40")]
public class PLAEPDNHBCO<TData> : PFEBHDPFNDF<CGHLLDJCJGG<TData>> where TData : notnull, ENPDBHJPNNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7406B0", Offset = "0x73FAB0")]
	private readonly HCKDENHBFIG<TData> EGILFDCIBFJ;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1E76B80", Offset = "0x1E75B80", VA = "0x181E76B80")]
	public PLAEPDNHBCO(List<TData> CLLPMDMHGMJ, List<bool> LDHAKMGHLGI, CGHLLDJCJGG<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1E76AC0", Offset = "0x1E75AC0", VA = "0x181E76AC0", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x740710", Offset = "0x73FB10")]
public class CMBPECJEIEA<TData> : PFEBHDPFNDF<GIMOIMNDHIM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xEDC0B0", Offset = "0xEDB0B0", VA = "0x180EDC0B0")]
	public CMBPECJEIEA(GIMOIMNDHIM<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1F356D0", Offset = "0x1F346D0", VA = "0x181F356D0", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct AADODELIGBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly Vector3 MJLMKCINECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool POMJEPILKBG;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x729E570", Offset = "0x729D570", VA = "0x18729E570")]
	public AADODELIGBP(Vector3 MJLMKCINECL, bool POMJEPILKBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct NMJCDJKJAIE<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T EEMPMGBFHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly bool PNBFJAMIAEI;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D5C0", Offset = "0x2A7C5C0", VA = "0x182A7D5C0")]
	public NMJCDJKJAIE(T POMANEOGNOE, bool MMNFDNKKDNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface DKIMNEEHHGE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BJHKOLJNBIM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x740780", Offset = "0x73FB80")] in LEJEBNMHAIA<TData?> DEDHNIMNFKO);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AEHEMOCDMID();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7407F0", Offset = "0x73FBF0")]
public class NADOKFBAPDA<TData> : PFEBHDPFNDF<DKIMNEEHHGE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x740860", Offset = "0x73FC60")]
	private readonly LEJEBNMHAIA<TData> DEDHNIMNFKO;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2863D50", Offset = "0x2862D50", VA = "0x182863D50")]
	public NADOKFBAPDA(IEnumerable<TData> CLLPMDMHGMJ, EABGJBJDCKI OAIMCLIJEAP, EDOGAFJMIEH AKEPBJIDOFF, float FMGGCEDDFJH, DKIMNEEHHGE<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1F033D0", Offset = "0x1F023D0", VA = "0x181F033D0", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface ENPDBHJPNNM
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool NHGPHNCMBIB
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
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7408C0", Offset = "0x73FCC0")]
public class IMIIOIKFJCN<TData> : PFEBHDPFNDF<MJHEPAOMEBJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly KEPNJHMHBFL KJLPLIIJLBA;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x245D8C0", Offset = "0x245C8C0", VA = "0x18245D8C0")]
	public IMIIOIKFJCN(Guid KEICBHGGNOJ, int EJNMEMKEIOD, Vector3 EDEGPGKBEGA, Quaternion DEANJFCCEBG, float CADELOLNNHN, bool POMJEPILKBG, MJHEPAOMEBJ<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1851240", Offset = "0x1850240", VA = "0x181851240", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x740930", Offset = "0x73FD30")]
public class KCDLAHFMHHP<TData> : PFEBHDPFNDF<CGHLLDJCJGG<TData>> where TData : notnull, ENPDBHJPNNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7409A0", Offset = "0x73FDA0")]
	private readonly KDDEFGNCIFA<TData> EGILFDCIBFJ;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1A3F0B0", Offset = "0x1A3E0B0", VA = "0x181A3F0B0")]
	public KCDLAHFMHHP(List<TData> CLLPMDMHGMJ, bool ADAGKDEBBDG, CGHLLDJCJGG<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1A3EFF0", Offset = "0x1A3DFF0", VA = "0x181A3EFF0", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x740A00", Offset = "0x73FE00")]
public class EHJLHHKFPLD<TData> : PFEBHDPFNDF<KHBOOGFPDPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly TData KILHLPBGPIC;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x27CFCF0", Offset = "0x27CECF0", VA = "0x1827CFCF0")]
	public EHJLHHKFPLD(TData KILHLPBGPIC, KHBOOGFPDPG<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x27CFB90", Offset = "0x27CEB90", VA = "0x1827CFB90", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x740A70", Offset = "0x73FE70")]
public abstract class PFEBHDPFNDF<TReceiver> : OBGFKEEJMNB<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xEDC0B0", Offset = "0xEDB0B0", VA = "0x180EDC0B0")]
	public PFEBHDPFNDF(TReceiver BAHDDPNEAIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface FENHPLBLOMO
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Bounds PCFEMNJPADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Transform PILDKGDBJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Bounds NKDLHIANFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Transform IGGNBEBKFJC
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Vector3 AABGPAPILBL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool MDMNAOMGHMM = true, int JBEFCGMOLCL = 0);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct KDDEFGNCIFA<TData> where TData : notnull, ENPDBHJPNNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public IEnumerable<TData> GIPBFJHOCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public bool ADAGKDEBBDG;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x231ACE0", Offset = "0x2319CE0", VA = "0x18231ACE0")]
	public KDDEFGNCIFA(IEnumerable<TData> CNIDDMMDMBE, bool PJJCFDGNGKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct HCKDENHBFIG<TData> where TData : notnull, ENPDBHJPNNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public List<TData> GIPBFJHOCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public List<bool> LDHAKMGHLGI;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2CE3A70", Offset = "0x2CE2A70", VA = "0x182CE3A70")]
	public HCKDENHBFIG(List<TData> CNIDDMMDMBE, List<bool> OOCCNNEDOIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface ECBNHMOJJNM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool MCDHGKKPICA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int MJOIAACLAEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<TData> NMDGJEDOMJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData GDMNFPEECEP);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData GDMNFPEECEP);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface KGMDFIJFOEK
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface GIMOIMNDHIM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EDFGPBNAKOA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x740AE0", Offset = "0x73FEE0")] in FNLGODJLIMK<TData?> ADKIEBGJINB);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BJHKOLJNBIM(in GBEOMCMNFKN FLOLHKJECHD);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AEHEMOCDMID();
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x740B50", Offset = "0x73FF50")]
public class FHIBLMCHLME<TData> : PFEBHDPFNDF<DKIMNEEHHGE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xEDC0B0", Offset = "0xEDB0B0", VA = "0x180EDC0B0")]
	public FHIBLMCHLME(DKIMNEEHHGE<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x1F03630", Offset = "0x1F02630", VA = "0x181F03630", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface FMCEICDIMJL : ENPDBHJPNNM
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x740BC0", Offset = "0x73FFC0")]
public abstract class DDEHHIHBAFI<TReceiver, TFromTask> : OBGFKEEJMNB<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0xEDC0B0", Offset = "0xEDB0B0", VA = "0x180EDC0B0")]
	public DDEHHIHBAFI(TReceiver BAHDDPNEAIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface LPKMHGOIMCP<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EDFGPBNAKOA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x740C30", Offset = "0x740030")] in GLFOOGAAIFK<T?> CJIHJMBEIBN);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AEHEMOCDMID();
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x740CA0", Offset = "0x7400A0")]
public class DPAJFMFHIDO<TData> : PFEBHDPFNDF<DIPAJJGOBCJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x740D10", Offset = "0x740110")]
	private readonly LGKEJLJGLLL<TData> GPPDECBBOHA;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3821430", Offset = "0x3820430", VA = "0x183821430")]
	public DPAJFMFHIDO(IEnumerable<TData> CLLPMDMHGMJ, bool BNJHFJBABJM, DIPAJJGOBCJ<TData> BAHDDPNEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x1A3EFF0", Offset = "0x1A3DFF0", VA = "0x181A3EFF0", Slot = "4")]
	public override bool DOKLPJBHLIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface BDPELIPDALC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOKLPJBHLIC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x740D70", Offset = "0x740170")] in FMCDDIIGAHB<TData?> DEDHNIMNFKO);
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

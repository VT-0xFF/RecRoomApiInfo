using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Burst.CompilerServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class EntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6C6ECD0", Offset = "0x6C6D2D0", VA = "0x186C6ECD0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DPOKJMNJGMA : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BIDMJDNBNPO LOGCPLLGKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GKHKNPOMBFD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FKPKOACAOJL(Entity AINKOAHKAPB, object FLLNLBHFENG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LBNCALCCHGD(Entity AINKOAHKAPB, object FLLNLBHFENG);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GPLCCGGIOPD(Entity AINKOAHKAPB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class APMNGNAHPOF<TComponentData, TValue> : NJPJECAJFFP<TValue>, IDisposable where TComponentData : struct, DPOKJMNJGMA
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class CHAPOGBDLFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> OLAPNOFMNPM;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int MNNLJFACLOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x36B5100", Offset = "0x36B3700", VA = "0x1836B5100")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x55A2890", Offset = "0x55A0E90", VA = "0x1855A2890")]
		public bool IGPFHJONNAE([Out] TValue KLABJGGMBGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x55A27A0", Offset = "0x55A0DA0", VA = "0x1855A27A0")]
		public void FABNFHGMHGJ(object FLLNLBHFENG, TValue KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x55A29A0", Offset = "0x55A0FA0", VA = "0x1855A29A0")]
		public bool MBEEDABKNGP(object FLLNLBHFENG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x55A2A60", Offset = "0x55A1060", VA = "0x1855A2A60")]
		public int OHCPFAOHMPG(object FLLNLBHFENG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x55A2B60", Offset = "0x55A1160", VA = "0x1855A2B60")]
		public CHAPOGBDLFN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<CHAPOGBDLFN> GBGGNFJIJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private CFAOFCPNGBH<BIDMJDNBNPO, CHAPOGBDLFN> IOGLDJNIKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager MAJIKHEKDED;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3F267A0", Offset = "0x3F24DA0", VA = "0x183F267A0")]
	public APMNGNAHPOF(EntityManager MAJIKHEKDED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3F25FD0", Offset = "0x3F245D0", VA = "0x183F25FD0", Slot = "4")]
	public void FKPKOACAOJL(Entity AINKOAHKAPB, object FLLNLBHFENG, TValue KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3F26440", Offset = "0x3F24A40", VA = "0x183F26440", Slot = "5")]
	public bool LBNCALCCHGD(Entity AINKOAHKAPB, object FLLNLBHFENG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3F26260", Offset = "0x3F24860", VA = "0x183F26260", Slot = "6")]
	public bool IGPFHJONNAE(Entity AINKOAHKAPB, [Out] TValue KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3F25FB0", Offset = "0x3F245B0", VA = "0x183F25FB0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3F25EE0", Offset = "0x3F244E0", VA = "0x183F25EE0")]
	private void AFIADOAAIJL(CHAPOGBDLFN AOKDOOJHIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3F26380", Offset = "0x3F24980", VA = "0x183F26380")]
	private bool JFJDPEJMHGK(Entity AINKOAHKAPB, [Out] BIDMJDNBNPO GPPOCIDKPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3F26160", Offset = "0x3F24760", VA = "0x183F26160")]
	private void GNHIEMEGCPN(Entity AINKOAHKAPB, BIDMJDNBNPO GPPOCIDKPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3F26650", Offset = "0x3F24C50", VA = "0x183F26650")]
	private bool LFFGCPIGKKH(BIDMJDNBNPO GPPOCIDKPII, [Out] CHAPOGBDLFN AOKDOOJHIHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3F26670", Offset = "0x3F24C70", VA = "0x183F26670")]
	private CHAPOGBDLFN PKGNHOIENND()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NJPJECAJFFP<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FKPKOACAOJL(Entity AINKOAHKAPB, object FLLNLBHFENG, TValue KLABJGGMBGH);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LBNCALCCHGD(Entity AINKOAHKAPB, object FLLNLBHFENG);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IGPFHJONNAE(Entity AINKOAHKAPB, [Out] TValue KLABJGGMBGH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct BIDMJDNBNPO : EOIFKCNADCO, IEquatable<BIDMJDNBNPO>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly BIDMJDNBNPO PFLMBFLCPLB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int OAGDGHBELJN
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x94DCE0", Offset = "0x94C2E0", VA = "0x18094DCE0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xB082E0", Offset = "0xB068E0", VA = "0x180B082E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int MFBBLPJBOGP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2669630", Offset = "0x2667C30", VA = "0x182669630", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5F41DD0", Offset = "0x5F403D0", VA = "0x185F41DD0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6C6E940", Offset = "0x6C6CF40", VA = "0x186C6E940", Slot = "8")]
	public bool Equals(BIDMJDNBNPO PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6C6E990", Offset = "0x6C6CF90", VA = "0x186C6E990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class NFLEEJLEKHP<THasTokensTag> : GKHKNPOMBFD, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, BIDMJDNBNPO> DDAOEPNNPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> GBGGNFJIJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CFAOFCPNGBH<BIDMJDNBNPO, HashSet<object>> IOGLDJNIKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager MAJIKHEKDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem ANJMLGEPABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool HFIMBOHAJFI;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x470C930", Offset = "0x470AF30", VA = "0x18470C930")]
	public NFLEEJLEKHP(EntityManager MAJIKHEKDED, EntityCommandBufferSystem ANJMLGEPABJ, CMICIECANPG CAMKENBKIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x470A680", Offset = "0x4708C80", VA = "0x18470A680", Slot = "4")]
	public bool FKPKOACAOJL(Entity AINKOAHKAPB, object FLLNLBHFENG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x470B670", Offset = "0x4709C70", VA = "0x18470B670", Slot = "5")]
	public bool LBNCALCCHGD(Entity AINKOAHKAPB, object FLLNLBHFENG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x470AC00", Offset = "0x4709200", VA = "0x18470AC00", Slot = "6")]
	public bool GPLCCGGIOPD(Entity AINKOAHKAPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x470AE30", Offset = "0x4709430", VA = "0x18470AE30", Slot = "8")]
	public bool GPLCCGGIOPD(BIDMJDNBNPO GPPOCIDKPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x470A1C0", Offset = "0x47087C0", VA = "0x18470A1C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4709CD0", Offset = "0x47082D0", VA = "0x184709CD0")]
	private void AFIADOAAIJL(HashSet<object> AOKDOOJHIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x470B130", Offset = "0x4709730", VA = "0x18470B130")]
	private bool JFJDPEJMHGK(Entity AINKOAHKAPB, [Out] BIDMJDNBNPO GPPOCIDKPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x470A100", Offset = "0x4708700", VA = "0x18470A100")]
	private bool DKDMDDEALDL(Entity AINKOAHKAPB, [Out] BIDMJDNBNPO GPPOCIDKPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x470BC50", Offset = "0x470A250", VA = "0x18470BC50")]
	private void MILFDMLJKEF(Entity AINKOAHKAPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x470C370", Offset = "0x470A970", VA = "0x18470C370")]
	private void PLJOICDEPKI(Entity AINKOAHKAPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x470C050", Offset = "0x470A650", VA = "0x18470C050")]
	private void PHJHOLOCEDG(Entity AINKOAHKAPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x470AAB0", Offset = "0x47090B0", VA = "0x18470AAB0")]
	private void GNHIEMEGCPN(Entity AINKOAHKAPB, BIDMJDNBNPO GPPOCIDKPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4709E00", Offset = "0x4708400", VA = "0x184709E00")]
	private bool AIAGAOJOLOG(BIDMJDNBNPO GPPOCIDKPII, [Out] HashSet<object> AOKDOOJHIHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x470C2D0", Offset = "0x470A8D0", VA = "0x18470C2D0")]
	private HashSet<object> PKGNHOIENND()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class GHIJMFDHJCI
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct NENEPFEEGEL : IJNGLFLENGH<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6C6F740", Offset = "0x6C6DD40", VA = "0x186C6F740")]
	public float CMOFKEDONCH([In] float3 KLABJGGMBGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6C6F740", Offset = "0x6C6DD40", VA = "0x186C6F740", Slot = "4")]
	private float PJMNEPLKABG([In] float3 KLABJGGMBGH)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct DIIIHMCAJDJ : IJNGLFLENGH<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6C6EA20", Offset = "0x6C6D020", VA = "0x186C6EA20")]
	public float CMOFKEDONCH([In] float3 KLABJGGMBGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C6EA20", Offset = "0x6C6D020", VA = "0x186C6EA20", Slot = "4")]
	private float PJMNEPLKABG([In] float3 KLABJGGMBGH)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct FCDGHPMNFGE : IJNGLFLENGH<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1F371D0", Offset = "0x1F357D0", VA = "0x181F371D0")]
	public float CMOFKEDONCH([In] float3 KLABJGGMBGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1F371D0", Offset = "0x1F357D0", VA = "0x181F371D0", Slot = "4")]
	private float PJMNEPLKABG([In] float3 KLABJGGMBGH)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct NGIDGLMLDFC : IJNGLFLENGH<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x17E3330", Offset = "0x17E1930", VA = "0x1817E3330")]
	public int CMOFKEDONCH([In] int3 KLABJGGMBGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x17E3330", Offset = "0x17E1930", VA = "0x1817E3330", Slot = "4")]
	private int CJOGDLDMKAE([In] int3 KLABJGGMBGH)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct FJDOFHHMPCO : IJNGLFLENGH<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6C6ECF0", Offset = "0x6C6D2F0", VA = "0x186C6ECF0")]
	public int CMOFKEDONCH([In] int3 KLABJGGMBGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6C6ECF0", Offset = "0x6C6D2F0", VA = "0x186C6ECF0", Slot = "4")]
	private int CJOGDLDMKAE([In] int3 KLABJGGMBGH)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct KMKJBNOEHMB : IJNGLFLENGH<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xF2E300", Offset = "0xF2C900", VA = "0x180F2E300")]
	public int CMOFKEDONCH([In] int3 KLABJGGMBGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xF2E300", Offset = "0xF2C900", VA = "0x180F2E300", Slot = "4")]
	private int CJOGDLDMKAE([In] int3 KLABJGGMBGH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class IHHLFNNELBP : GCKGMAMCGEA
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x16E4740", Offset = "0x16E2D40", VA = "0x1816E4740")]
	public IHHLFNNELBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class NAHELDIECMN : SystemBase, FMLOMPLKPLJ
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6C6F3D0", Offset = "0x6C6D9D0", VA = "0x186C6F3D0")]
	public JobHandle IANBBMGICIA(ReadOnlySpan<int> NBNNBMCJGON)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2E014D0", Offset = "0x2DFFAD0", VA = "0x182E014D0")]
	public void KBCFBIBIHJM<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2E01640", Offset = "0x2DFFC40", VA = "0x182E01640")]
	public JobHandle KBCFBIBIHJM<T>(JobHandle GPPOCIDKPII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6C6F420", Offset = "0x6C6DA20", VA = "0x186C6F420")]
	public JobHandle KBCFBIBIHJM(ReadOnlySpan<int> NBNNBMCJGON, JobHandle GPPOCIDKPII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2E014D0", Offset = "0x2DFFAD0", VA = "0x182E014D0")]
	public void AJKOJKACMPJ<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2E00EB0", Offset = "0x2DFF4B0", VA = "0x182E00EB0")]
	public JobHandle AJKOJKACMPJ<T>(JobHandle GPPOCIDKPII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6C6F490", Offset = "0x6C6DA90", VA = "0x186C6F490")]
	public ComponentDataFromEntity PDJOOAEAEPK(int NMEBIIGAMHK, bool MPKLOIOFKAG = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6C6F3B0", Offset = "0x6C6D9B0", VA = "0x186C6F3B0")]
	public EntityExistenceLookupByEntity BGJADAMNJHC()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6C6F550", Offset = "0x6C6DB50", VA = "0x186C6F550", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x16E4740", Offset = "0x16E2D40", VA = "0x1816E4740")]
	protected NAHELDIECMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class JGABPICLHPA : NAHELDIECMN
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6C6EF30", Offset = "0x6C6D530", VA = "0x186C6EF30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x16E4740", Offset = "0x16E2D40", VA = "0x1816E4740")]
	protected JGABPICLHPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class EGPFMDJMALI
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class NLEAHBCNIEG : EntityCommandBufferSystem, FMLOMPLKPLJ
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x16E4740", Offset = "0x16E2D40", VA = "0x1816E4740")]
	protected NLEAHBCNIEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface IJNGLFLENGH<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo CMOFKEDONCH([In] TFrom KLABJGGMBGH);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface FPLHAMKINLI<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GDMOAEJJJNJ(T KLABJGGMBGH);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct ODNCHDJKOIN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[ReadOnly]
	public NativeArray<Entity> EFGPCHNDDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public EntityCommandBuffer MDAIOGJLPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public ComponentTypes NGJDEKHBLKJ;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6C6F750", Offset = "0x6C6DD50", VA = "0x186C6F750", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct BFFBNINGJOJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> EFGPCHNDDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer MDAIOGJLPIJ;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6C6E8A0", Offset = "0x6C6CEA0", VA = "0x186C6E8A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct FNNDOMDNIJB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public NativeArray<Entity> EFGPCHNDDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public EntityCommandBuffer MDAIOGJLPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public ComponentType KDIPHLEHHMM;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C6ED00", Offset = "0x6C6D300", VA = "0x186C6ED00", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct KGGCBMDAPNG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> EFGPCHNDDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public NativeArray<T> JGCMECODHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public EntityCommandBuffer MDAIOGJLPIJ;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x434FC90", Offset = "0x434E290", VA = "0x18434FC90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct DFOFKDMOBCD<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> EFGPCHNDDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> ICLOFOKMOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer MDAIOGJLPIJ;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct LEGIHGIHPMM<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> EFGPCHNDDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public T KLABJGGMBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer MDAIOGJLPIJ;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x43F6EF0", Offset = "0x43F54F0", VA = "0x1843F6EF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct KNOCKCLPPLI<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, IJNGLFLENGH<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<TFrom> CMOMNHLCKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[WriteOnly]
	public NativeArray<TTo> HBMMDBJHMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public TMap PMCMEAHOBEF;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct JIHGDOFJCKH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public ComponentDataFromEntity NNLKOMJNEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> CMOMNHLCKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[WriteOnly]
	public NativeArray<byte> HBMMDBJHMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int GIPABHAFFKK;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6C6EF60", Offset = "0x6C6D560", VA = "0x186C6EF60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct IMBEMDKEDJA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public ComponentDataFromEntity<T> ELPMOMDLOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public NativeArray<Entity> CMOMNHLCKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[WriteOnly]
	public NativeList<T> GMCLDKIGLLJ;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct MACPGGHFFCB<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, IJNGLFLENGH<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> KGGEKKBFNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeList<TTo> HBMMDBJHMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap PMCMEAHOBEF;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct JGPPJOBKICO<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JAKONNJBFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> JMHFCLCBNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<bool> KFKPBCFJKAG;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct HGJGAHPBLDC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JAKONNJBFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> JMHFCLCBNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> KFKPBCFJKAG;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3E71510", Offset = "0x3E6FB10", VA = "0x183E71510", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct CNHJAMNNFII<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<T> CMOMNHLCKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeList<T> GMCLDKIGLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeParallelHashSet<T> KFCFIIDHDBJ;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5796590", Offset = "0x5794B90", VA = "0x185796590", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct PBFHKLFJOBA<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : IJNGLFLENGH<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<TFrom> CMOMNHLCKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<TFrom> GMCLDKIGLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<TTo> KFCFIIDHDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public TMap PMCMEAHOBEF;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct BECGFKPOHGP<T, TPredicate> : IJob where T : struct where TPredicate : struct, FPLHAMKINLI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<T> CMOMNHLCKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> ADAKBGHHNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeList<Entity> HJAPMFGCDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public TPredicate PMCMEAHOBEF;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct GKOACCLCJCH<T, TPredicate> : IJob where T : struct where TPredicate : struct, FPLHAMKINLI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<T> CMOMNHLCKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<T> GMCLDKIGLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate PMCMEAHOBEF;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct PCPAHCCCDFM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public ComponentDataFromEntity JAKONNJBFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	public NativeArray<Entity> JMHFCLCBNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeList<Entity> LOALPBPNDOM;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6C6F840", Offset = "0x6C6DE40", VA = "0x186C6F840", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct MLIMBKHNNOJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity JAKONNJBFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> JMHFCLCBNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> LOALPBPNDOM;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6C6F320", Offset = "0x6C6D920", VA = "0x186C6F320", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class GJOHLLKPFDN
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class JDFHIPBAALD
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2D3DD20", Offset = "0x2D3C320", VA = "0x182D3DD20")]
	public static bool NABIIJNOIEN<T>(this NativeArray<Entity> JMHFCLCBNFM, EntityManager MAJIKHEKDED, Allocator NPNPKHEIOHB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class HLIGDMKMLEA
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class HDBMELDDLKO<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public HDBMELDDLKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class MDMDKCJNJHL<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		public MDMDKCJNJHL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly List<Func<JobHandle, JobHandle>> LGNKNJCHPNH;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6C6EEA0", Offset = "0x6C6D4A0", VA = "0x186C6EEA0")]
	public HLIGDMKMLEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class DHKDPDMNFLH
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class HNDPCEIOHBN
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct BFCDDMODKKI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct KNOKAAIGHNB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			internal BFCDDMODKKI<TFrom> LDJCBIBELIM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Allocator NPNPKHEIOHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal NativeArray<TFrom> MILPHOELICC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct ALMBOPONAED<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct LJFECDBHCDK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal ALMBOPONAED<TFrom> LDJCBIBELIM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator NPNPKHEIOHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeList<TFrom> MILPHOELICC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct NDOMBCGFDKE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct PHBKBFFIGGC<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal NDOMBCGFDKE<TFrom> LDJCBIBELIM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator NPNPKHEIOHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeArrayAsync<TFrom> MILPHOELICC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct GIGEGLDEKMP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct PJFFLFIIBOH<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal GIGEGLDEKMP<TFrom> LDJCBIBELIM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator NPNPKHEIOHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeListAsync<TFrom> MILPHOELICC;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class LIIDBGNFJPM
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class GLPOONAJLNO
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2CC9FA0", Offset = "0x2CC85A0", VA = "0x182CC9FA0")]
	public static NativeList<T> COGGGDCIEIP<T>(this NativeArray<T> OPCJLEAJHPA, Allocator NPNPKHEIOHB = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class NHAFDBEAPFM
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class LNPNALNFPHF
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2D7DFB0", Offset = "0x2D7C5B0", VA = "0x182D7DFB0")]
	[BGPIFKFEHAA]
	public static JobHandle LCMDHOCCIMN<T>(this EntityCommandBufferSystem ANJMLGEPABJ, NativeArrayAsync<Entity> EFGPCHNDDEC, NativeArrayAsync<T> JGCMECODHDI, [Optional] JobHandle OEPHCBKFEKK) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2D7E260", Offset = "0x2D7C860", VA = "0x182D7E260")]
	[BGPIFKFEHAA]
	public static JobHandle LCMDHOCCIMN<T>(this EntityCommandBufferSystem ANJMLGEPABJ, NativeArrayAsync<Entity> EFGPCHNDDEC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2D7E130", Offset = "0x2D7C730", VA = "0x182D7E130")]
	[BGPIFKFEHAA]
	public static JobHandle LCMDHOCCIMN<T>(this EntityCommandBufferSystem ANJMLGEPABJ, NativeArray<Entity> EFGPCHNDDEC, [Optional] JobHandle OEPHCBKFEKK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6C6F1B0", Offset = "0x6C6D7B0", VA = "0x186C6F1B0")]
	[BGPIFKFEHAA]
	public static JobHandle LCMDHOCCIMN(this EntityCommandBufferSystem ANJMLGEPABJ, NativeArray<Entity> EFGPCHNDDEC, ComponentTypes NGJDEKHBLKJ, [Optional] JobHandle OEPHCBKFEKK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6C6F060", Offset = "0x6C6D660", VA = "0x186C6F060")]
	[BGPIFKFEHAA]
	public static JobHandle LCMDHOCCIMN(this EntityCommandBufferSystem ANJMLGEPABJ, EntityCommandBuffer MDAIOGJLPIJ, NativeArray<Entity> EFGPCHNDDEC, ComponentTypes NGJDEKHBLKJ, [Optional] JobHandle OEPHCBKFEKK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class PEDLNKMNBPI
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2E5CA60", Offset = "0x2E5B060", VA = "0x182E5CA60")]
	[BGPIFKFEHAA]
	public static JobHandle DDMHHJBFPHM<T>(this EntityCommandBufferSystem ANJMLGEPABJ, EntityCommandBuffer MDAIOGJLPIJ, EntityQuery DOLJPDDOAOI, T KLABJGGMBGH) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class EHBEIOHNECE
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6C6EA30", Offset = "0x6C6D030", VA = "0x186C6EA30")]
	[BGPIFKFEHAA]
	public static JobHandle AMJCIHBIHLF(this EntityCommandBufferSystem ANJMLGEPABJ, NativeList<Entity> EFGPCHNDDEC, [Optional] JobHandle OEPHCBKFEKK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6C6EBC0", Offset = "0x6C6D1C0", VA = "0x186C6EBC0")]
	[BGPIFKFEHAA]
	public static JobHandle AMJCIHBIHLF(this EntityCommandBufferSystem ANJMLGEPABJ, NativeArrayAsync<Entity> EFGPCHNDDEC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class NMEHNNBIPKH
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class FCBAIEIMDHN
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2C96360", Offset = "0x2C94960", VA = "0x182C96360")]
	[BGPIFKFEHAA]
	public static JobHandle PKLCMNFHNNM<T>(this EntityCommandBufferSystem ANJMLGEPABJ, NativeArray<Entity> EFGPCHNDDEC, NativeArray<T> JGCMECODHDI, JobHandle OEPHCBKFEKK) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class BANJGBHKJDM
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2A0C0D0", Offset = "0x2A0A6D0", VA = "0x182A0C0D0")]
	[BGPIFKFEHAA]
	public static JobHandle NJLHNNPIAID<T>(this EntityCommandBufferSystem ANJMLGEPABJ, NativeArray<Entity> EFGPCHNDDEC, T KLABJGGMBGH, [Optional] JobHandle OEPHCBKFEKK) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2A0BFF0", Offset = "0x2A0A5F0", VA = "0x182A0BFF0")]
	[BGPIFKFEHAA]
	public static JobHandle NJLHNNPIAID<T>(this EntityCommandBufferSystem ANJMLGEPABJ, EntityCommandBuffer MDAIOGJLPIJ, NativeArray<Entity> EFGPCHNDDEC, T KLABJGGMBGH, [Optional] JobHandle OEPHCBKFEKK) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class OBLNDFHIDFI
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class NEAAMHNNHKH
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2E06700", Offset = "0x2E04D00", VA = "0x182E06700")]
	public static NativeArray<T> EICPAJKNPIH<T>(this NativeList<Entity> OPCJLEAJHPA, EntityManager MAJIKHEKDED, Allocator NPNPKHEIOHB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2E06340", Offset = "0x2E04940", VA = "0x182E06340")]
	public static NativeArray<T> EICPAJKNPIH<T>(this NativeArray<Entity> OPCJLEAJHPA, EntityManager MAJIKHEKDED, Allocator NPNPKHEIOHB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6C6F560", Offset = "0x6C6DB60", VA = "0x186C6F560")]
	public static NativeArray<Entity> AFLICLMKAAG(this NativeArray<Entity> OPCJLEAJHPA, EntityManager MAJIKHEKDED, ComponentType KDIPHLEHHMM, Allocator NPNPKHEIOHB = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2E069B0", Offset = "0x2E04FB0", VA = "0x182E069B0")]
	public static NativeArray<T> KLPPEKBLLBA<T>(this NativeArray<Entity> OPCJLEAJHPA, EntityManager MAJIKHEKDED, Allocator NPNPKHEIOHB = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class NJLIKBBMBBC
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct CMDNJEMFMMB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct ACLOLPFECOH<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public CMDNJEMFMMB<TFrom> MILPHOELICC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Allocator NPNPKHEIOHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public NativeArray<TFrom> CMOMNHLCKAM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct KCMMDOMCPDD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct ICKKPFIIFCG<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public KCMMDOMCPDD<TFrom> MILPHOELICC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator NPNPKHEIOHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArrayAsync<TFrom> CMOMNHLCKAM;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct PBMIAOMGANF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct HBBLKEKMBCB<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public PBMIAOMGANF<TFrom> MILPHOELICC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator NPNPKHEIOHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeListAsync<TFrom> CMOMNHLCKAM;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class GDPFDBALDMF
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class LHJJIIPJOOM
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct EOBPOPKGFKK : IJNGLFLENGH<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> EJEABEJNOOF;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6C6ECC0", Offset = "0x6C6D2C0", VA = "0x186C6ECC0")]
		[BurstCompatible]
		public Entity CMOFKEDONCH([In] Entity KLABJGGMBGH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6C6ECC0", Offset = "0x6C6D2C0", VA = "0x186C6ECC0", Slot = "4")]
		private Entity GFDMODNHFLC([In] Entity KLABJGGMBGH)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class BHKDJDPMLDG
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct BNIAHKMOOGI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator NPNPKHEIOHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<Entity> ADAKBGHHNPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<T> CMOMNHLCKAM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct DKPENGHDMGA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator NPNPKHEIOHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeList<Entity> ADAKBGHHNPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> CMOMNHLCKAM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct HCDDGKGGLGA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator NPNPKHEIOHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<Entity> ADAKBGHHNPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArrayAsync<T> CMOMNHLCKAM;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class NGJKOALCGKE
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class OJNAAHFBHIB
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct CCJGBGHAKBD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator NPNPKHEIOHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> CMOMNHLCKAM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct LPICBOIOPBE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator NPNPKHEIOHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> CMOMNHLCKAM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct AOLLLKNAEHE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator NPNPKHEIOHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> CMOMNHLCKAM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct AMJIPBKHAGB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator NPNPKHEIOHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> CMOMNHLCKAM;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class CABHIMJCNPP
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class NNDOAILOOOM
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2E21AE0", Offset = "0x2E200E0", VA = "0x182E21AE0")]
	public static NativeList<Entity> KPLGGJDGINO<T>(this NativeArray<Entity> JMHFCLCBNFM, EntityManager MAJIKHEKDED, Allocator NPNPKHEIOHB = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class MPCKAKHGDKH
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class OFHJJDPIFCH
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct JEEMOKPLBDC<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> DKEEEGEFALD;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA60", Offset = "0xB7C060", VA = "0x180B7DA60")]
		public JEEMOKPLBDC(NativeArray<TSrc> DKEEEGEFALD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50")]
		public LJGMKBCJIMH<TSrc, TValue> IJDPMLOEMDL<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(LJGMKBCJIMH<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct LJGMKBCJIMH<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> DKEEEGEFALD;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA60", Offset = "0xB7C060", VA = "0x180B7DA60")]
		public LJGMKBCJIMH(NativeArray<TSrc> DKEEEGEFALD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50")]
		public COOHFFPDALG<TSrc, TValue, TSelector> HNFLNJBDOKM<TSelector>() where TSelector : struct, IJNGLFLENGH<TSrc, TValue>
		{
			return default(COOHFFPDALG<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct COOHFFPDALG<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, IJNGLFLENGH<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> DKEEEGEFALD;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA60", Offset = "0xB7C060", VA = "0x180B7DA60")]
		public COOHFFPDALG(NativeArray<TSrc> DKEEEGEFALD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x57A09C0", Offset = "0x579EFC0", VA = "0x1857A09C0")]
		public AHNGKMANGMM<TSrc, TValue, TSelector> FCCBCNJIMMP()
		{
			return default(AHNGKMANGMM<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct EFJBGDPNMMF<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, IJNGLFLENGH<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> DKEEEGEFALD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TSelector LAAOPFHDHBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int HGFDMIDEFHN;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue JINHOCMBIBA
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x39430C0", Offset = "0x39416C0", VA = "0x1839430C0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int OAGDGHBELJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9023F0", Offset = "0x9009F0", VA = "0x1809023F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int OMFNNJPGGGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x20E3390", Offset = "0x20E1990", VA = "0x1820E3390")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3943290", Offset = "0x3941890", VA = "0x183943290")]
		public EFJBGDPNMMF(NativeArray<TSrc> DKEEEGEFALD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x39430B0", Offset = "0x39416B0", VA = "0x1839430B0")]
		public bool AMEHHFPEGIG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3943100", Offset = "0x3941700", VA = "0x183943100")]
		private TSrc LOAMKNNONEE(int DMIMFDDIIBO)
		{
			return (TSrc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3943200", Offset = "0x3941800", VA = "0x183943200")]
		private TValue PEPIILAFLMB()
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct AHNGKMANGMM<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, IJNGLFLENGH<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private EFJBGDPNMMF<TSrc, TValue, TSelector> GMBMPHHMOPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TValue NBAOANCLEBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int NBPJLJIBBHP;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public LIDAMMEOCHG JGNGNHJEIAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x3DB1160", Offset = "0x3DAF760", VA = "0x183DB1160")]
			get
			{
				return default(LIDAMMEOCHG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue BKNCGDHAKED
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x88D660", Offset = "0x88BC60", VA = "0x18088D660")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, LIDAMMEOCHG range) JINHOCMBIBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x3DB11A0", Offset = "0x3DAF7A0", VA = "0x183DB11A0")]
			get
			{
				return default((TValue, LIDAMMEOCHG));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3DB1280", Offset = "0x3DAF880", VA = "0x183DB1280")]
		public AHNGKMANGMM(NativeArray<TSrc> DKEEEGEFALD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x396B790", Offset = "0x3969D90", VA = "0x18396B790")]
		public AHNGKMANGMM<TSrc, TValue, TSelector> HNHGFOAAHAF()
		{
			return default(AHNGKMANGMM<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3DB0FE0", Offset = "0x3DAF5E0", VA = "0x183DB0FE0")]
		public bool AMEHHFPEGIG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2E3DCB0", Offset = "0x2E3C2B0", VA = "0x182E3DCB0")]
	public static JEEMOKPLBDC<T> BDBEJAPPIMG<T>(this NativeList<T> OLAPNOFMNPM) where T : struct
	{
		return default(JEEMOKPLBDC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50")]
	public static JEEMOKPLBDC<T> BDBEJAPPIMG<T>(this NativeArray<T> DKEEEGEFALD) where T : struct
	{
		return default(JEEMOKPLBDC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class NHAFGIKCANH
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct OEOEIOPMBGL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly NativeArray<T>.ReadOnly DKEEEGEFALD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int NBPJLJIBBHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int PIFJBCKCFDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T NBAOANCLEBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private T LLPIJPINDAK;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public LIDAMMEOCHG JGNGNHJEIAL
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x4338D80", Offset = "0x4337380", VA = "0x184338D80")]
			get
			{
				return default(LIDAMMEOCHG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T BKNCGDHAKED
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x39E7570", Offset = "0x39E5B70", VA = "0x1839E7570")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, LIDAMMEOCHG) JINHOCMBIBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x481BDF0", Offset = "0x481A3F0", VA = "0x18481BDF0")]
			get
			{
				return default((T, LIDAMMEOCHG));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x481BF30", Offset = "0x481A530", VA = "0x18481BF30")]
		public OEOEIOPMBGL(NativeArray<T> DKEEEGEFALD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x481BD00", Offset = "0x481A300", VA = "0x18481BD00")]
		public OEOEIOPMBGL<T> HNHGFOAAHAF()
		{
			return default(OEOEIOPMBGL<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x481B930", Offset = "0x4819F30", VA = "0x18481B930")]
		public bool AMEHHFPEGIG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2CF29B0", Offset = "0x2CF0FB0", VA = "0x182CF29B0")]
		public KBIFELEIJMD<T, TComparer> PJMPPAMCJOF<TComparer>([Optional] TComparer EMGNFHOBKAC) where TComparer : struct, IEqualityComparer<T>
		{
			return default(KBIFELEIJMD<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct KBIFELEIJMD<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly NativeArray<T>.ReadOnly DKEEEGEFALD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int NBPJLJIBBHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int PIFJBCKCFDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T NBAOANCLEBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private T LLPIJPINDAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TComparer EMGNFHOBKAC;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LIDAMMEOCHG JGNGNHJEIAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x4338D80", Offset = "0x4337380", VA = "0x184338D80")]
			get
			{
				return default(LIDAMMEOCHG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T BKNCGDHAKED
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x39E7570", Offset = "0x39E5B70", VA = "0x1839E7570")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x4338D90", Offset = "0x4337390", VA = "0x184338D90")]
		public KBIFELEIJMD(NativeArray<T>.ReadOnly DKEEEGEFALD, TComparer EMGNFHOBKAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4338B90", Offset = "0x4337190", VA = "0x184338B90")]
		public bool AMEHHFPEGIG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2E12FD0", Offset = "0x2E115D0", VA = "0x182E12FD0")]
	public static OEOEIOPMBGL<T> FCCBCNJIMMP<T>(this NativeArray<T> DKEEEGEFALD) where T : struct
	{
		return default(OEOEIOPMBGL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface LELOPBLIEPM
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class MNMMLBCANKB
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct PJBDNBDCENM<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class ALBHHNCMBHG : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public PJBDNBDCENM<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xDCF430", Offset = "0xDCDA30", VA = "0x180DCF430", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x3CF7A30", Offset = "0x3CF6030", VA = "0x183CF7A30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
		[DebuggerHidden]
		public ALBHHNCMBHG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3DBE710", Offset = "0x3DBCD10", VA = "0x183DBE710", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x3DBE8F0", Offset = "0x3DBCEF0", VA = "0x183DBE8F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Action<Protobuf> PNELALABKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly MemoryStream CHPPOENEDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CodedInputStream JGHCIMKBNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Protobuf DJFACICIDCN;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int OMFNNJPGGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8F5280", Offset = "0x8F3880", VA = "0x1808F5280")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x491D9D0", Offset = "0x491BFD0", VA = "0x18491D9D0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x491DA10", Offset = "0x491C010", VA = "0x18491DA10", Slot = "4")]
	[IteratorStateMachine(typeof(PJBDNBDCENM<>.ALBHHNCMBHG))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x491DB10", Offset = "0x491C110", VA = "0x18491DB10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct JCFJMFLCCOG<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly byte[] DJOHOLIEOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Protobuf DJFACICIDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream CHPPOENEDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedOutputStream GCBIAKGFGLJ;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4197A40", Offset = "0x4196040", VA = "0x184197A40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct DEMJOBIGCDC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly MemoryStream CHPPOENEDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly CodedInputStream JGHCIMKBNMP;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6C6E9E0", Offset = "0x6C6CFE0", VA = "0x186C6E9E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct GNJDHCPPDCA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly byte[] DJOHOLIEOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly MemoryStream CHPPOENEDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CodedOutputStream GCBIAKGFGLJ;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6C6ED80", Offset = "0x6C6D380", VA = "0x186C6ED80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class KJNHJMHFHHF
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class HHAHPMDHMPE
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum HFGNHEGPEKN
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Main = 5,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal static class CAMDAHNCGBI
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class GCJAEBBBAOC
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public GCJAEBBBAOC()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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

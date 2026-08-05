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
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69BFBF0", Offset = "0x69BE7F0", VA = "0x1869BFBF0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NCANMDHNBCI : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	AFFCBADDDMF LAICJGEAPGP
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
public interface DDOOBNMHEDE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PDGJHOFGHFE(Entity NGLCFDBCFFC, object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PKHGBGPOODM(Entity NGLCFDBCFFC, object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OHCEOJALELD(Entity NGLCFDBCFFC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class DGBFEBNOJBA<TComponentData, TValue> : OBHOFIJFEPA<TValue>, IDisposable where TComponentData : struct, NCANMDHNBCI
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class LJALBIGFPLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> KNDOIJDCKAF;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int FPIENNPNDKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3551D00", Offset = "0x3550900", VA = "0x183551D00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x420B930", Offset = "0x420A530", VA = "0x18420B930")]
		public bool HEJAJABKGOF([Out] TValue GLMEMJNJKAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x420BBD0", Offset = "0x420A7D0", VA = "0x18420BBD0")]
		public void MPFJKDGCCNN(object FGIAGALCIAP, TValue GLMEMJNJKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x420BB20", Offset = "0x420A720", VA = "0x18420BB20")]
		public bool IFPALOLJLCH(object FGIAGALCIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x420BA40", Offset = "0x420A640", VA = "0x18420BA40")]
		public int HNKMEOEHJLO(object FGIAGALCIAP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x420BCB0", Offset = "0x420A8B0", VA = "0x18420BCB0")]
		public LJALBIGFPLI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<LJALBIGFPLI> MLLAIDMFEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private DJDFNGKJPNN<AFFCBADDDMF, LJALBIGFPLI> ODILIKNGPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager NJHBFCFCNCD;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x57CE430", Offset = "0x57CD030", VA = "0x1857CE430")]
	public DGBFEBNOJBA(EntityManager NJHBFCFCNCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x57CE0C0", Offset = "0x57CCCC0", VA = "0x1857CE0C0", Slot = "4")]
	public void PDGJHOFGHFE(Entity NGLCFDBCFFC, object FGIAGALCIAP, TValue GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x57CE240", Offset = "0x57CCE40", VA = "0x1857CE240", Slot = "5")]
	public bool PKHGBGPOODM(Entity NGLCFDBCFFC, object FGIAGALCIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x57CDEF0", Offset = "0x57CCAF0", VA = "0x1857CDEF0", Slot = "6")]
	public bool HEJAJABKGOF(Entity NGLCFDBCFFC, [Out] TValue GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x57CDBF0", Offset = "0x57CC7F0", VA = "0x1857CDBF0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x57CE000", Offset = "0x57CCC00", VA = "0x1857CE000")]
	private void OOIDOGDKAFE(LJALBIGFPLI NGIINLPOCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x57CDD10", Offset = "0x57CC910", VA = "0x1857CDD10")]
	private bool EPODJIJIPIC(Entity NGLCFDBCFFC, [Out] AFFCBADDDMF POAHFHMMEAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x57CDC10", Offset = "0x57CC810", VA = "0x1857CDC10")]
	private void ELIANKIPNPO(Entity NGLCFDBCFFC, AFFCBADDDMF POAHFHMMEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x57CDBD0", Offset = "0x57CC7D0", VA = "0x1857CDBD0")]
	private bool DBBBGDHFKFA(AFFCBADDDMF POAHFHMMEAF, [Out] LJALBIGFPLI NGIINLPOCBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x57CDDD0", Offset = "0x57CC9D0", VA = "0x1857CDDD0")]
	private LJALBIGFPLI GKBFDIILPLE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OBHOFIJFEPA<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PDGJHOFGHFE(Entity NGLCFDBCFFC, object FGIAGALCIAP, TValue GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PKHGBGPOODM(Entity NGLCFDBCFFC, object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HEJAJABKGOF(Entity NGLCFDBCFFC, [Out] TValue GLMEMJNJKAN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct AFFCBADDDMF : MJOKIKKGNLI, IEquatable<AFFCBADDDMF>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly AFFCBADDDMF GFAAJGGODEO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int HDEPOMLIBHF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x916930", Offset = "0x915530", VA = "0x180916930", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA63EA0", Offset = "0xA62AA0", VA = "0x180A63EA0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int LEANFGGOJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x251F470", Offset = "0x251E070", VA = "0x18251F470", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5CE1680", Offset = "0x5CE0280", VA = "0x185CE1680", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x69BF3E0", Offset = "0x69BDFE0", VA = "0x1869BF3E0", Slot = "8")]
	public bool Equals(AFFCBADDDMF OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69BF430", Offset = "0x69BE030", VA = "0x1869BF430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class FMCDCGJGOLH<THasTokensTag> : DDOOBNMHEDE, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly KEDKJKIEEGM MIIBHDDJGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, AFFCBADDDMF> HGNIJNNNMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> MLLAIDMFEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private DJDFNGKJPNN<AFFCBADDDMF, HashSet<object>> ODILIKNGPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager NJHBFCFCNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem DDMLMPJKBJC;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3BB40E0", Offset = "0x3BB2CE0", VA = "0x183BB40E0")]
	public FMCDCGJGOLH(EntityManager NJHBFCFCNCD, EntityCommandBufferSystem DDMLMPJKBJC, KEDKJKIEEGM MGEEHJAMBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3BB3440", Offset = "0x3BB2040", VA = "0x183BB3440", Slot = "4")]
	public bool PDGJHOFGHFE(Entity NGLCFDBCFFC, object FGIAGALCIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3BB3C40", Offset = "0x3BB2840", VA = "0x183BB3C40", Slot = "5")]
	public bool PKHGBGPOODM(Entity NGLCFDBCFFC, object FGIAGALCIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3BB2A30", Offset = "0x3BB1630", VA = "0x183BB2A30", Slot = "6")]
	public bool OHCEOJALELD(Entity NGLCFDBCFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3BB2CF0", Offset = "0x3BB18F0", VA = "0x183BB2CF0", Slot = "8")]
	public bool OHCEOJALELD(AFFCBADDDMF POAHFHMMEAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3BB21F0", Offset = "0x3BB0DF0", VA = "0x183BB21F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3BB2EF0", Offset = "0x3BB1AF0", VA = "0x183BB2EF0")]
	private void OOIDOGDKAFE(HashSet<object> NGIINLPOCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3BB2540", Offset = "0x3BB1140", VA = "0x183BB2540")]
	private bool EPODJIJIPIC(Entity NGLCFDBCFFC, [Out] AFFCBADDDMF POAHFHMMEAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3BB19B0", Offset = "0x3BB05B0", VA = "0x183BB19B0")]
	private bool BFJOFGEDKAJ(Entity NGLCFDBCFFC, [Out] AFFCBADDDMF POAHFHMMEAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3BB1530", Offset = "0x3BB0130", VA = "0x183BB1530")]
	private void AFCGIAIAJKL(Entity NGLCFDBCFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3BB1EB0", Offset = "0x3BB0AB0", VA = "0x183BB1EB0")]
	private void DGPKPDOEOLP(Entity NGLCFDBCFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3BB1D10", Offset = "0x3BB0910", VA = "0x183BB1D10")]
	private void CFOLOHBNINE(Entity NGLCFDBCFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3BB2320", Offset = "0x3BB0F20", VA = "0x183BB2320")]
	private void ELIANKIPNPO(Entity NGLCFDBCFFC, AFFCBADDDMF POAHFHMMEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3BB3700", Offset = "0x3BB2300", VA = "0x183BB3700")]
	private bool PGMOLOJKHJE(AFFCBADDDMF POAHFHMMEAF, [Out] HashSet<object> NGIINLPOCBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3BB2850", Offset = "0x3BB1450", VA = "0x183BB2850")]
	private HashSet<object> GKBFDIILPLE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class PLDOBHNGMMG
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct AABMKDCIONJ : DHKAGHCIOCA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x69BF3D0", Offset = "0x69BDFD0", VA = "0x1869BF3D0")]
	public float FHHPPKDHCCJ([In] float3 GLMEMJNJKAN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x69BF3D0", Offset = "0x69BDFD0", VA = "0x1869BF3D0", Slot = "4")]
	private float MDHCCDBDHGL([In] float3 GLMEMJNJKAN)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct NCBOFOKGOGJ : DHKAGHCIOCA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x69C0000", Offset = "0x69BEC00", VA = "0x1869C0000")]
	public float FHHPPKDHCCJ([In] float3 GLMEMJNJKAN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x69C0000", Offset = "0x69BEC00", VA = "0x1869C0000", Slot = "4")]
	private float MDHCCDBDHGL([In] float3 GLMEMJNJKAN)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct PLCOJMNIMJA : DHKAGHCIOCA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1CA47E0", Offset = "0x1CA33E0", VA = "0x181CA47E0")]
	public float FHHPPKDHCCJ([In] float3 GLMEMJNJKAN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1CA47E0", Offset = "0x1CA33E0", VA = "0x181CA47E0", Slot = "4")]
	private float MDHCCDBDHGL([In] float3 GLMEMJNJKAN)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct LBANKFKCIIH : DHKAGHCIOCA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1584AE0", Offset = "0x15836E0", VA = "0x181584AE0")]
	public int FHHPPKDHCCJ([In] int3 GLMEMJNJKAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1584AE0", Offset = "0x15836E0", VA = "0x181584AE0", Slot = "4")]
	private int DCKNDMJIDEH([In] int3 GLMEMJNJKAN)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct PDIGIGOOICK : DHKAGHCIOCA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x69C0350", Offset = "0x69BEF50", VA = "0x1869C0350")]
	public int FHHPPKDHCCJ([In] int3 GLMEMJNJKAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x69C0350", Offset = "0x69BEF50", VA = "0x1869C0350", Slot = "4")]
	private int DCKNDMJIDEH([In] int3 GLMEMJNJKAN)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct HMCDGPELAJI : DHKAGHCIOCA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1889A80", Offset = "0x1888680", VA = "0x181889A80")]
	public int FHHPPKDHCCJ([In] int3 GLMEMJNJKAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1889A80", Offset = "0x1888680", VA = "0x181889A80", Slot = "4")]
	private int DCKNDMJIDEH([In] int3 GLMEMJNJKAN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class GBMBFHIDABN : NFNGONMACMA
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x14BF290", Offset = "0x14BDE90", VA = "0x1814BF290")]
	public GBMBFHIDABN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class EGOOACFDFBF : SystemBase, BPGGIMLJPHG
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x69BFAA0", Offset = "0x69BE6A0", VA = "0x1869BFAA0")]
	public JobHandle LNJLEADMDCB(ReadOnlySpan<int> NGFCPAGDAJL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x29754E0", Offset = "0x29740E0", VA = "0x1829754E0")]
	public void EMFDPLHCMDF<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x29758F0", Offset = "0x29744F0", VA = "0x1829758F0")]
	public JobHandle EMFDPLHCMDF<T>(JobHandle POAHFHMMEAF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x69BFA10", Offset = "0x69BE610", VA = "0x1869BFA10")]
	public JobHandle EMFDPLHCMDF(ReadOnlySpan<int> NGFCPAGDAJL, JobHandle POAHFHMMEAF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x29754E0", Offset = "0x29740E0", VA = "0x1829754E0")]
	public void DKDGHHOEMNB<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2975080", Offset = "0x2973C80", VA = "0x182975080")]
	public JobHandle DKDGHHOEMNB<T>(JobHandle POAHFHMMEAF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x69BFAF0", Offset = "0x69BE6F0", VA = "0x1869BFAF0")]
	public ComponentDataFromEntity OHDDNJBJBPF(int CCJPPHADPEH, bool KFDEGEPDPIE = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x69BFA80", Offset = "0x69BE680", VA = "0x1869BFA80")]
	public EntityExistenceLookupByEntity GAOLDFNADHB()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x69BFBB0", Offset = "0x69BE7B0", VA = "0x1869BFBB0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x14BF290", Offset = "0x14BDE90", VA = "0x1814BF290")]
	protected EGOOACFDFBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class EICNFCBGJFC : EGOOACFDFBF
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x69BFBC0", Offset = "0x69BE7C0", VA = "0x1869BFBC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x14BF290", Offset = "0x14BDE90", VA = "0x1814BF290")]
	protected EICNFCBGJFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class GLLLKOPNHOG
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class NMFNABHEKAM : EntityCommandBufferSystem, BPGGIMLJPHG
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x14BF290", Offset = "0x14BDE90", VA = "0x1814BF290")]
	protected NMFNABHEKAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DHKAGHCIOCA<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo FHHPPKDHCCJ([In] TFrom GLMEMJNJKAN);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface DPLMEMPBOPF<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JKCMFHCJCFJ(T GLMEMJNJKAN);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct BFMJIBFKHEK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[ReadOnly]
	public NativeArray<Entity> NBNHBNDLFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public EntityCommandBuffer DPFDCBIFGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public ComponentTypes BHBKPEAHMMC;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x69BF600", Offset = "0x69BE200", VA = "0x1869BF600", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct PFOLFPGDDPG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[ReadOnly]
	public NativeArray<Entity> NBNHBNDLFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public EntityCommandBuffer DPFDCBIFGPP;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x69C0360", Offset = "0x69BEF60", VA = "0x1869C0360", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct BAHJPLBLJBF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public NativeArray<Entity> NBNHBNDLFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public EntityCommandBuffer DPFDCBIFGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public ComponentType DCGHMIFIMCA;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x69BF580", Offset = "0x69BE180", VA = "0x1869BF580", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct CBILFJFBLKJ<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[ReadOnly]
	public NativeArray<Entity> NBNHBNDLFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<T> IMCLGJBJJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer DPFDCBIFGPP;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x50C2910", Offset = "0x50C1510", VA = "0x1850C2910", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct DGCAMEMIEAI<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> NBNHBNDLFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<T> DJGHJNNEKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public EntityCommandBuffer DPFDCBIFGPP;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct ICIHOGNKPNA<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> NBNHBNDLFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public T GLMEMJNJKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public EntityCommandBuffer DPFDCBIFGPP;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3E21480", Offset = "0x3E20080", VA = "0x183E21480", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct PBGJJEMDDEE<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, DHKAGHCIOCA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[ReadOnly]
	public NativeArray<TFrom> BEJNGCCCPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[WriteOnly]
	public NativeArray<TTo> ACPCOBJKOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public TMap FIPNCHEIGMJ;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct AMHLJMEFEJC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public ComponentDataFromEntity ADEFMKICKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<Entity> BEJNGCCCPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<byte> ACPCOBJKOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int JLFHFKFICGK;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x69BF480", Offset = "0x69BE080", VA = "0x1869BF480", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct GKJONMGELEI<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity<T> CFPLKNEEEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> BEJNGCCCPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeList<T> KFJLCKEKPPD;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct NDOOHKKAEIG<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, DHKAGHCIOCA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public NativeArray<TFrom> DDEBAPDNBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[WriteOnly]
	public NativeList<TTo> ACPCOBJKOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public TMap FIPNCHEIGMJ;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct BJKOEOPMALB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public ComponentDataFromEntity<T> NFLGJFKKLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<Entity> FLMILEMLHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<bool> IEFIAJNBPJB;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct CAKNLGANGIK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ComponentDataFromEntity<T> NFLGJFKKLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public NativeArray<Entity> FLMILEMLHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NativeArray<bool> IEFIAJNBPJB;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x50C06C0", Offset = "0x50BF2C0", VA = "0x1850C06C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct CGLENBICPKK<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<T> BEJNGCCCPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<T> KFJLCKEKPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeParallelHashSet<T> FHINEEGCGMD;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x51B4610", Offset = "0x51B3210", VA = "0x1851B4610", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct KODLAFMJNEA<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : DHKAGHCIOCA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public NativeArray<TFrom> BEJNGCCCPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeList<TFrom> KFJLCKEKPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeParallelHashSet<TTo> FHINEEGCGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public TMap FIPNCHEIGMJ;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct KINKEFOKKOG<T, TPredicate> : IJob where T : struct where TPredicate : struct, DPLMEMPBOPF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<T> BEJNGCCCPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<Entity> OGDNNNAEDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeList<Entity> GJEIGMJBPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TPredicate FIPNCHEIGMJ;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct IDFCCLJENMI<T, TPredicate> : IJob where T : struct where TPredicate : struct, DPLMEMPBOPF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> BEJNGCCCPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> KFJLCKEKPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public TPredicate FIPNCHEIGMJ;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct IFKGLEDCCMJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public ComponentDataFromEntity NFLGJFKKLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<Entity> FLMILEMLHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<Entity> DKBOBEOCKDG;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69BFED0", Offset = "0x69BEAD0", VA = "0x1869BFED0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct KOKCDBDPJBK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[ReadOnly]
	public ComponentDataFromEntity NFLGJFKKLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<Entity> FLMILEMLHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<Entity> DKBOBEOCKDG;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x69BFF70", Offset = "0x69BEB70", VA = "0x1869BFF70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class IMOGKBIMHAG
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class AMBDBHJLLAN
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x31DE630", Offset = "0x31DD230", VA = "0x1831DE630")]
	public static bool NPLIDOEAAPN<T>(this NativeArray<Entity> FLMILEMLHLC, EntityManager NJHBFCFCNCD, Allocator BLMBIIGOJPG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class DKLFKLIHFIK
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class ABLPCEJIDEM<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public ABLPCEJIDEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class AGINBLHLENK<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		public AGINBLHLENK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<Func<JobHandle, JobHandle>> AKDECBNELBH;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x69BF980", Offset = "0x69BE580", VA = "0x1869BF980")]
	public DKLFKLIHFIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class DLPGIEGHCOK
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class GIBCLGDELEL
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct JACIPALDLJB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct DEAJLCFLFNL<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			internal JACIPALDLJB<TFrom> GPMGJNAOOEP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal Allocator BLMBIIGOJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal NativeArray<TFrom> AIFEMCDFFGN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct OOMLDHOCNNB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct ACDKKPJIHPP<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			internal OOMLDHOCNNB<TFrom> GPMGJNAOOEP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal Allocator BLMBIIGOJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal NativeList<TFrom> AIFEMCDFFGN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct JDEOEJLEDJM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct NMBGEBGCOLA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			internal JDEOEJLEDJM<TFrom> GPMGJNAOOEP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal Allocator BLMBIIGOJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal NativeArrayAsync<TFrom> AIFEMCDFFGN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct BOMPFGEMKPB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct GBNONJPCKEC<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			internal BOMPFGEMKPB<TFrom> GPMGJNAOOEP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal Allocator BLMBIIGOJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal NativeListAsync<TFrom> AIFEMCDFFGN;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class HJKKNIBKFGG
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class IMDGPOKJNFI
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2B76B90", Offset = "0x2B75790", VA = "0x182B76B90")]
	public static NativeList<T> NPLLPBKABKF<T>(this NativeArray<T> HOHDCKKDOFJ, Allocator BLMBIIGOJPG = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class ILMNOAKLJGM
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class FAECCHEGKGM
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2ADD930", Offset = "0x2ADC530", VA = "0x182ADD930")]
	[IOHCGPHPPCH]
	public static JobHandle DODLKAPMGED<T>(this EntityCommandBufferSystem DDMLMPJKBJC, NativeArrayAsync<Entity> NBNHBNDLFMG, NativeArrayAsync<T> IMCLGJBJJKP, [Optional] JobHandle NJBGDHEBIBA) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2ADDAB0", Offset = "0x2ADC6B0", VA = "0x182ADDAB0")]
	[IOHCGPHPPCH]
	public static JobHandle DODLKAPMGED<T>(this EntityCommandBufferSystem DDMLMPJKBJC, NativeArrayAsync<Entity> NBNHBNDLFMG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2ADD800", Offset = "0x2ADC400", VA = "0x182ADD800")]
	[IOHCGPHPPCH]
	public static JobHandle DODLKAPMGED<T>(this EntityCommandBufferSystem DDMLMPJKBJC, NativeArray<Entity> NBNHBNDLFMG, [Optional] JobHandle NJBGDHEBIBA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x69BFC10", Offset = "0x69BE810", VA = "0x1869BFC10")]
	[IOHCGPHPPCH]
	public static JobHandle DODLKAPMGED(this EntityCommandBufferSystem DDMLMPJKBJC, NativeArray<Entity> NBNHBNDLFMG, ComponentTypes BHBKPEAHMMC, [Optional] JobHandle NJBGDHEBIBA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x69BFD80", Offset = "0x69BE980", VA = "0x1869BFD80")]
	[IOHCGPHPPCH]
	public static JobHandle DODLKAPMGED(this EntityCommandBufferSystem DDMLMPJKBJC, EntityCommandBuffer DPFDCBIFGPP, NativeArray<Entity> NBNHBNDLFMG, ComponentTypes BHBKPEAHMMC, [Optional] JobHandle NJBGDHEBIBA)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class FLEHNKLFKJK
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3450", Offset = "0x2AF2050", VA = "0x182AF3450")]
	[IOHCGPHPPCH]
	public static JobHandle NGMJPNOBJKA<T>(this EntityCommandBufferSystem DDMLMPJKBJC, EntityCommandBuffer DPFDCBIFGPP, EntityQuery NLMOHJOABCP, T GLMEMJNJKAN) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class CFNFDELEMNN
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x69BF7F0", Offset = "0x69BE3F0", VA = "0x1869BF7F0")]
	[IOHCGPHPPCH]
	public static JobHandle CEKMAKEHDIL(this EntityCommandBufferSystem DDMLMPJKBJC, NativeList<Entity> NBNHBNDLFMG, [Optional] JobHandle NJBGDHEBIBA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x69BF6F0", Offset = "0x69BE2F0", VA = "0x1869BF6F0")]
	[IOHCGPHPPCH]
	public static JobHandle CEKMAKEHDIL(this EntityCommandBufferSystem DDMLMPJKBJC, NativeArrayAsync<Entity> NBNHBNDLFMG)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class PLIAJAACDEP
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class HNAFIDMGJIG
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2B21390", Offset = "0x2B1FF90", VA = "0x182B21390")]
	[IOHCGPHPPCH]
	public static JobHandle GEMFIMGBNFD<T>(this EntityCommandBufferSystem DDMLMPJKBJC, NativeArray<Entity> NBNHBNDLFMG, NativeArray<T> IMCLGJBJJKP, JobHandle NJBGDHEBIBA) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class EBHCHLKDPAA
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2970A20", Offset = "0x296F620", VA = "0x182970A20")]
	[IOHCGPHPPCH]
	public static JobHandle FCENMGCDCIH<T>(this EntityCommandBufferSystem DDMLMPJKBJC, NativeArray<Entity> NBNHBNDLFMG, T GLMEMJNJKAN, [Optional] JobHandle NJBGDHEBIBA) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2970B10", Offset = "0x296F710", VA = "0x182970B10")]
	[IOHCGPHPPCH]
	public static JobHandle FCENMGCDCIH<T>(this EntityCommandBufferSystem DDMLMPJKBJC, EntityCommandBuffer DPFDCBIFGPP, NativeArray<Entity> NBNHBNDLFMG, T GLMEMJNJKAN, [Optional] JobHandle NJBGDHEBIBA) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class FBNAOHOICIO
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class NIPNJCCJBOE
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2C9FBD0", Offset = "0x2C9E7D0", VA = "0x182C9FBD0")]
	public static NativeArray<T> CLBGNACOLMO<T>(this NativeList<Entity> HOHDCKKDOFJ, EntityManager NJHBFCFCNCD, Allocator BLMBIIGOJPG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2C9F630", Offset = "0x2C9E230", VA = "0x182C9F630")]
	public static NativeArray<T> CLBGNACOLMO<T>(this NativeArray<Entity> HOHDCKKDOFJ, EntityManager NJHBFCFCNCD, Allocator BLMBIIGOJPG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x69C0010", Offset = "0x69BEC10", VA = "0x1869C0010")]
	public static NativeArray<Entity> ILBKKIFEPGJ(this NativeArray<Entity> HOHDCKKDOFJ, EntityManager NJHBFCFCNCD, ComponentType DCGHMIFIMCA, Allocator BLMBIIGOJPG = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2C9FCA0", Offset = "0x2C9E8A0", VA = "0x182C9FCA0")]
	public static NativeArray<T> DHNCBIOPICE<T>(this NativeArray<Entity> HOHDCKKDOFJ, EntityManager NJHBFCFCNCD, Allocator BLMBIIGOJPG = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class GAMBAKEGCOC
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct MGHPBLDHAMA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct KHHFBKIGIED<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public MGHPBLDHAMA<TFrom> AIFEMCDFFGN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public Allocator BLMBIIGOJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeArray<TFrom> BEJNGCCCPPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct DELKNHAGLOO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct PNMLOPBJMHA<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public DELKNHAGLOO<TFrom> AIFEMCDFFGN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Allocator BLMBIIGOJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeArrayAsync<TFrom> BEJNGCCCPPD;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct LMMGPIAAIFA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct IPJOANCPDGO<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public LMMGPIAAIFA<TFrom> AIFEMCDFFGN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Allocator BLMBIIGOJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public NativeListAsync<TFrom> BEJNGCCCPPD;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class EIMKDMGEMMJ
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class KOFMHCBEPJP
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct IHJMGCJPAME : DHKAGHCIOCA<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> KKINAKFJCFA;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x69BFF60", Offset = "0x69BEB60", VA = "0x1869BFF60")]
		[BurstCompatible]
		public Entity FHHPPKDHCCJ([In] Entity GLMEMJNJKAN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x69BFF60", Offset = "0x69BEB60", VA = "0x1869BFF60", Slot = "4")]
		private Entity GMOGOBJKACO([In] Entity GLMEMJNJKAN)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class DLGJKBFDNKG
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct IANJGKFLMIA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator BLMBIIGOJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeArray<Entity> OGDNNNAEDML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<T> BEJNGCCCPPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct GOJCBNOCMJJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Allocator BLMBIIGOJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<Entity> OGDNNNAEDML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<T> BEJNGCCCPPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct KOHGMMDCKFA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Allocator BLMBIIGOJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArrayAsync<Entity> OGDNNNAEDML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<T> BEJNGCCCPPD;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class DEFMENGIDPI
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class IIPMOJGPMLA
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct NDOCFIAFGGB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Allocator BLMBIIGOJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NativeArray<T> BEJNGCCCPPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct NDGDBDKEKJL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator BLMBIIGOJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeList<T> BEJNGCCCPPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct KHLNILJPHNH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator BLMBIIGOJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArrayAsync<T> BEJNGCCCPPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct KCBFFMDGGCA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator BLMBIIGOJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeListAsync<T> BEJNGCCCPPD;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class EMCMFBKHMBC
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class MNKJJJMAPDL
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2C45D70", Offset = "0x2C44970", VA = "0x182C45D70")]
	public static NativeList<Entity> GAFCKKGOJCO<T>(this NativeArray<Entity> FLMILEMLHLC, EntityManager NJHBFCFCNCD, Allocator BLMBIIGOJPG = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class MDCBFBHJNMP
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class CJJMLIBKLDC
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct PPHAHOMJHDN<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly NativeArray<TSrc> CHPEIOMPEEH;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1F94260", Offset = "0x1F92E60", VA = "0x181F94260")]
		public PPHAHOMJHDN(NativeArray<TSrc> CHPEIOMPEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150")]
		public OAJPAPJKNNN<TSrc, TValue> IFDJNBPLBBI<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(OAJPAPJKNNN<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct OAJPAPJKNNN<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> CHPEIOMPEEH;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1F94260", Offset = "0x1F92E60", VA = "0x181F94260")]
		public OAJPAPJKNNN(NativeArray<TSrc> CHPEIOMPEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150")]
		public BFHADNOBAEC<TSrc, TValue, TSelector> KBDCAEBFKIN<TSelector>() where TSelector : struct, DHKAGHCIOCA<TSrc, TValue>
		{
			return default(BFHADNOBAEC<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct BFHADNOBAEC<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, DHKAGHCIOCA<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> CHPEIOMPEEH;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1F94260", Offset = "0x1F92E60", VA = "0x181F94260")]
		public BFHADNOBAEC(NativeArray<TSrc> CHPEIOMPEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4E583A0", Offset = "0x4E56FA0", VA = "0x184E583A0")]
		public FOOFAKGPNEA<TSrc, TValue, TSelector> FGKNMODALHJ()
		{
			return default(FOOFAKGPNEA<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct EFEGKKDCBFG<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, DHKAGHCIOCA<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> CHPEIOMPEEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TSelector CAIKDLGBFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int OPDMGNJCACB;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue KDHPDJIABMO
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x37ED0F0", Offset = "0x37EBCF0", VA = "0x1837ED0F0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int HDEPOMLIBHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8B9300", Offset = "0x8B7F00", VA = "0x1808B9300")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int CJOHGCFPKAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x37ED130", Offset = "0x37EBD30", VA = "0x1837ED130")]
		public EFEGKKDCBFG(NativeArray<TSrc> CHPEIOMPEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x37ECF50", Offset = "0x37EBB50", VA = "0x1837ECF50")]
		public bool EDAAKPFFNIP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x37ECF60", Offset = "0x37EBB60", VA = "0x1837ECF60")]
		private TSrc IFGFAFPIDAP(int EKELKKECGGF)
		{
			return (TSrc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x37ED060", Offset = "0x37EBC60", VA = "0x1837ED060")]
		private TValue LNOLPCPKKAI()
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct FOOFAKGPNEA<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, DHKAGHCIOCA<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private EFEGKKDCBFG<TSrc, TValue, TSelector> CACLGIIFKFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TValue LBILJNLHKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int PAGNMFPMINA;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public GGEMFBHNFIG GPLLCNDIACN
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x3BDE080", Offset = "0x3BDCC80", VA = "0x183BDE080")]
			get
			{
				return default(GGEMFBHNFIG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue CEFKGJCFLPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x84DDF0", Offset = "0x84C9F0", VA = "0x18084DDF0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, GGEMFBHNFIG range) KDHPDJIABMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x3BDE0E0", Offset = "0x3BDCCE0", VA = "0x183BDE0E0")]
			get
			{
				return default((TValue, GGEMFBHNFIG));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3BDE1B0", Offset = "0x3BDCDB0", VA = "0x183BDE1B0")]
		public FOOFAKGPNEA(NativeArray<TSrc> CHPEIOMPEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3BDE0C0", Offset = "0x3BDCCC0", VA = "0x183BDE0C0")]
		public FOOFAKGPNEA<TSrc, TValue, TSelector> NDANHGBCNEI()
		{
			return default(FOOFAKGPNEA<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3BDDF00", Offset = "0x3BDCB00", VA = "0x183BDDF00")]
		public bool EDAAKPFFNIP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2901950", Offset = "0x2900550", VA = "0x182901950")]
	public static PPHAHOMJHDN<T> PONMKEBMNKC<T>(this NativeList<T> KNDOIJDCKAF) where T : struct
	{
		return default(PPHAHOMJHDN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150")]
	public static PPHAHOMJHDN<T> PONMKEBMNKC<T>(this NativeArray<T> CHPEIOMPEEH) where T : struct
	{
		return default(PPHAHOMJHDN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class EJNDPCDHBCB
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct BCIKBDLDLEE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly NativeArray<T>.ReadOnly CHPEIOMPEEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int PAGNMFPMINA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int MHMBJEBAFLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private T LBILJNLHKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T AKLLLMHDOKJ;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public GGEMFBHNFIG GPLLCNDIACN
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x3D5A1F0", Offset = "0x3D58DF0", VA = "0x183D5A1F0")]
			get
			{
				return default(GGEMFBHNFIG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T CEFKGJCFLPH
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x387CCC0", Offset = "0x387B8C0", VA = "0x18387CCC0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, GGEMFBHNFIG) KDHPDJIABMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x4E233E0", Offset = "0x4E21FE0", VA = "0x184E233E0")]
			get
			{
				return default((T, GGEMFBHNFIG));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4E23520", Offset = "0x4E22120", VA = "0x184E23520")]
		public BCIKBDLDLEE(NativeArray<T> CHPEIOMPEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4E23300", Offset = "0x4E21F00", VA = "0x184E23300")]
		public BCIKBDLDLEE<T> NDANHGBCNEI()
		{
			return default(BCIKBDLDLEE<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4E23120", Offset = "0x4E21D20", VA = "0x184E23120")]
		public bool EDAAKPFFNIP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x256EC90", Offset = "0x256D890", VA = "0x18256EC90")]
		public HMLDNONAALC<T, TComparer> CAEEIOJAKNO<TComparer>([Optional] TComparer JGABKNMCAEL) where TComparer : struct, IEqualityComparer<T>
		{
			return default(HMLDNONAALC<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct HMLDNONAALC<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<T>.ReadOnly CHPEIOMPEEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int PAGNMFPMINA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int MHMBJEBAFLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T LBILJNLHKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T AKLLLMHDOKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TComparer JGABKNMCAEL;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public GGEMFBHNFIG GPLLCNDIACN
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x3D5A1F0", Offset = "0x3D58DF0", VA = "0x183D5A1F0")]
			get
			{
				return default(GGEMFBHNFIG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T CEFKGJCFLPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x387CCC0", Offset = "0x387B8C0", VA = "0x18387CCC0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3D5A200", Offset = "0x3D58E00", VA = "0x183D5A200")]
		public HMLDNONAALC(NativeArray<T>.ReadOnly CHPEIOMPEEH, TComparer JGABKNMCAEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3D5A010", Offset = "0x3D58C10", VA = "0x183D5A010")]
		public bool EDAAKPFFNIP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2977DE0", Offset = "0x29769E0", VA = "0x182977DE0")]
	public static BCIKBDLDLEE<T> FGKNMODALHJ<T>(this NativeArray<T> CHPEIOMPEEH) where T : struct
	{
		return default(BCIKBDLDLEE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface DADINJBBMFG
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class AICCMPOELGH
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct PNLLANGECJM<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class POCCFOLEBAE : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public PNLLANGECJM<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xC225E0", Offset = "0xC211E0", VA = "0x180C225E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C12FB0", Offset = "0x3C11BB0", VA = "0x183C12FB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
		[DebuggerHidden]
		public POCCFOLEBAE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x47828C0", Offset = "0x47814C0", VA = "0x1847828C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x4782A90", Offset = "0x4781690", VA = "0x184782A90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly Action<Protobuf> NMJBLHDGKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly MemoryStream DMCHAOHIHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly CodedInputStream AMLEDOHCKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Protobuf KGCMPKPCOJF;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int CJOHGCFPKAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8BAEF0", Offset = "0x8B9AF0", VA = "0x1808BAEF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x47823F0", Offset = "0x4780FF0", VA = "0x1847823F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4782430", Offset = "0x4781030", VA = "0x184782430", Slot = "4")]
	[IteratorStateMachine(typeof(PNLLANGECJM<>.POCCFOLEBAE))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4782530", Offset = "0x4781130", VA = "0x184782530", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct PCJEALOLNOD<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly byte[] BKHGNPANPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Protobuf KGCMPKPCOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly MemoryStream DMCHAOHIHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly CodedOutputStream ENPOOONHACG;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x46F1BD0", Offset = "0x46F07D0", VA = "0x1846F1BD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct NLOGGOBEAMK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MemoryStream DMCHAOHIHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CodedInputStream AMLEDOHCKJC;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x69C01F0", Offset = "0x69BEDF0", VA = "0x1869C01F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct OMEJACKKLMB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly byte[] BKHGNPANPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream DMCHAOHIHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedOutputStream ENPOOONHACG;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x69C0230", Offset = "0x69BEE30", VA = "0x1869C0230", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class LGKLIFOLINJ
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class ICOEPGLMOHG
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum BMLJEEGPCEH
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Main = 5,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal static class GLBFKAFNBIJ
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class MOPBIGCLMGE
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public MOPBIGCLMGE()
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

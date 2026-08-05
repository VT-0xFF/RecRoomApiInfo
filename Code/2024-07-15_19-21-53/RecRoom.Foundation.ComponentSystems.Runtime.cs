using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Collections;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public abstract class EHIGJPBACPO : HILDKDKAGGF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x68D1470", Offset = "0x68CFC70", VA = "0x1868D1470", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase NECCKAIGHLJ();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68D13D0", Offset = "0x68CFBD0", VA = "0x1868D13D0")]
	protected ComponentSystemBase HMJFJALFFBM(params ComponentSystemBase[] JGCPGLNEMJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x29ABD00", Offset = "0x29AA500", VA = "0x1829ABD00")]
	protected ComponentSystemBase HMJFJALFFBM<T>(params ComponentSystemBase[] JGCPGLNEMJB) where T : HILDKDKAGGF, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x29ABDA0", Offset = "0x29AA5A0", VA = "0x1829ABDA0")]
	protected ComponentSystemBase MHGKGDALJAC<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x29ABDA0", Offset = "0x29AA5A0", VA = "0x1829ABDA0")]
	protected ComponentSystemBase LAKAEOKKFAB<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x68D1420", Offset = "0x68CFC20", VA = "0x1868D1420")]
	protected ComponentSystemBase MOLFLFOMLJA(params SystemHandleUntyped[] JGCPGLNEMJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x29ABE90", Offset = "0x29AA690", VA = "0x1829ABE90")]
	protected ComponentSystemBase MOLFLFOMLJA<T>(params SystemHandleUntyped[] JGCPGLNEMJB) where T : HILDKDKAGGF, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x29ABE00", Offset = "0x29AA600", VA = "0x1829ABE00")]
	protected SystemHandleUntyped LDLJOPBOHGJ<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x68D14C0", Offset = "0x68CFCC0", VA = "0x1868D14C0")]
	protected EHIGJPBACPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GDJLILNELBP
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HILDKDKAGGF : JDAIFAJEAOE
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x68D1510", Offset = "0x68CFD10", VA = "0x1868D1510", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x68D14C0", Offset = "0x68CFCC0", VA = "0x1868D14C0")]
	public HILDKDKAGGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class JDAIFAJEAOE : ComponentSystemGroup, GDJLILNELBP
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x68D14C0", Offset = "0x68CFCC0", VA = "0x1868D14C0")]
	protected JDAIFAJEAOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct IKPCGJCHJJF<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private LHBECHAPJGM<T> DMDAEILPBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityCommandBuffer HDAOBPDCCDB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public LHBECHAPJGM<T> JGJKDDFGOML
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3C5F900", Offset = "0x3C5E100", VA = "0x183C5F900")]
		get
		{
			return default(LHBECHAPJGM<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3CD3190", Offset = "0x3CD1990", VA = "0x183CD3190")]
	public IKPCGJCHJJF(LHBECHAPJGM<T> DMDAEILPBHA, EntityCommandBuffer HDAOBPDCCDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3EC4D50", Offset = "0x3EC3550", VA = "0x183EC4D50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct EJGHFBLMIPN<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private KBKNOAGOEDC<T> DMDAEILPBHA;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x37E0660", Offset = "0x37DEE60", VA = "0x1837E0660")]
	public EJGHFBLMIPN(KBKNOAGOEDC<T> DMDAEILPBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x37E0480", Offset = "0x37DEC80", VA = "0x1837E0480")]
	public IKPCGJCHJJF<T> BGEHNCLNPLC()
	{
		return default(IKPCGJCHJJF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct GOCOCEOFINB<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private LHBECHAPJGM<T> DMDAEILPBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityCommandBuffer HDAOBPDCCDB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public LHBECHAPJGM<T> JGJKDDFGOML
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3C5F900", Offset = "0x3C5E100", VA = "0x183C5F900")]
		get
		{
			return default(LHBECHAPJGM<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3CD3190", Offset = "0x3CD1990", VA = "0x183CD3190")]
	public GOCOCEOFINB(LHBECHAPJGM<T> DMDAEILPBHA, EntityCommandBuffer HDAOBPDCCDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3CD2790", Offset = "0x3CD0F90", VA = "0x183CD2790")]
	public void ODHAFMLAMKF(KBKNOAGOEDC<T> OHPNOPMOOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3CD1CD0", Offset = "0x3CD04D0", VA = "0x183CD1CD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct BAGEEEJMBMD<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private KBKNOAGOEDC<T> DMDAEILPBHA;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x37E0660", Offset = "0x37DEE60", VA = "0x1837E0660")]
	public BAGEEEJMBMD(KBKNOAGOEDC<T> DMDAEILPBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4DEFDA0", Offset = "0x4DEE5A0", VA = "0x184DEFDA0")]
	public GOCOCEOFINB<T> HCJBCNAEAEJ()
	{
		return default(GOCOCEOFINB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AlwaysUpdateSystem]
public abstract class DKEHGHAOFDP : SystemBase
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private EntityCommandBufferSystem HICMAKMOHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private NativeList<EntityQuery> PHPIAJBMHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool HMLDEKBBPIE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EntityCommandBufferSystem JDLNFPGKHLN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	protected abstract CDLNJDLNIPA MGFMJHPPHBP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected bool CFHDDGLKNCC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3E1B800", Offset = "0x3E1A000", VA = "0x183E1B800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x852890", Offset = "0x851090", VA = "0x180852890")]
	public void IJEMMKEKHCH(EntityCommandBufferSystem HICMAKMOHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x68D1290", Offset = "0x68CFA90", VA = "0x1868D1290", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68D1370", Offset = "0x68CFB70", VA = "0x1868D1370", Slot = "13")]
	protected sealed override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x68D1320", Offset = "0x68CFB20", VA = "0x1868D1320", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract void IDGDGIFGHPI();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x297CE50", Offset = "0x297B650", VA = "0x18297CE50")]
	protected EntityQuery KEGNHDLALHK<T>() where T : struct, IComponentData
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x297BBC0", Offset = "0x297A3C0", VA = "0x18297BBC0")]
	protected BAGEEEJMBMD<T> IBOCJAMEKKI<T>() where T : struct, IComponentData
	{
		return default(BAGEEEJMBMD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x297BAB0", Offset = "0x297A2B0", VA = "0x18297BAB0")]
	protected EJGHFBLMIPN<T> DIPGECCHMKJ<T>() where T : struct, IComponentData
	{
		return default(EJGHFBLMIPN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x14DD360", Offset = "0x14DBB60", VA = "0x1814DD360")]
	protected DKEHGHAOFDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DefaultMember("Item")]
public struct LHBECHAPJGM<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public NativeList<Entity> JPHDFJFJAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NativeList<T> LINJEFIAFHO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int PBLCBJADLHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4254FA0", Offset = "0x42537A0", VA = "0x184254FA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public (Entity entity, T value) NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4255060", Offset = "0x4253860", VA = "0x184255060")]
		get
		{
			return default((Entity, T));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4254FE0", Offset = "0x42537E0", VA = "0x184254FE0")]
	public void PBLNBBGFGAP(Entity IBKNLGIDEBH, T JMDCGOKJIDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct KBKNOAGOEDC<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[ReadOnly]
	public EntityQueryInJob EEIHEBHOGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[ReadOnly]
	public EntityTypeHandle BMIFLAFFLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[ReadOnly]
	public ComponentTypeHandle<T> HIKIHNMMEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[WriteOnly]
	public EntityCommandBuffer HDAOBPDCCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public AllocatorManager.AllocatorHandle CHDJMCMMMLJ;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4162990", Offset = "0x4161190", VA = "0x184162990")]
	public LHBECHAPJGM<T> BGEHNCLNPLC()
	{
		return default(LHBECHAPJGM<T>);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FFCOGINOOIO
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	public FFCOGINOOIO()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
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

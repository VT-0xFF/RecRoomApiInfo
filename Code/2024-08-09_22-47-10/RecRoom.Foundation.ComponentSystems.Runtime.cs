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
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
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
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public abstract class ENFAOKNHNCB : AGMJBEPFMFO
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x68F05C0", Offset = "0x68EF9C0", VA = "0x1868F05C0", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase JFILDLGHBJK();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68F0570", Offset = "0x68EF970", VA = "0x1868F0570")]
	protected ComponentSystemBase MHHLDJIAAKN(params ComponentSystemBase[] CFNFPMOAHPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x29EF340", Offset = "0x29EE740", VA = "0x1829EF340")]
	protected ComponentSystemBase MHHLDJIAAKN<T>(params ComponentSystemBase[] CFNFPMOAHPJ) where T : AGMJBEPFMFO, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x29EF3E0", Offset = "0x29EE7E0", VA = "0x1829EF3E0")]
	protected ComponentSystemBase MKJDMPMGJAE<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x29EF3E0", Offset = "0x29EE7E0", VA = "0x1829EF3E0")]
	protected ComponentSystemBase NAMBMMMHENL<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x68F0520", Offset = "0x68EF920", VA = "0x1868F0520")]
	protected ComponentSystemBase EHNDIEEAHDM(params SystemHandleUntyped[] CFNFPMOAHPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x29EF210", Offset = "0x29EE610", VA = "0x1829EF210")]
	protected ComponentSystemBase EHNDIEEAHDM<T>(params SystemHandleUntyped[] CFNFPMOAHPJ) where T : AGMJBEPFMFO, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x29EF2B0", Offset = "0x29EE6B0", VA = "0x1829EF2B0")]
	protected SystemHandleUntyped LKAAJKPKEAJ<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x68F04D0", Offset = "0x68EF8D0", VA = "0x1868F04D0")]
	protected ENFAOKNHNCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IJPDCJFICGO
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class AGMJBEPFMFO : JMFCDPEBFIB
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x68F04A0", Offset = "0x68EF8A0", VA = "0x1868F04A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x68F04D0", Offset = "0x68EF8D0", VA = "0x1868F04D0")]
	public AGMJBEPFMFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class JMFCDPEBFIB : ComponentSystemGroup, IJPDCJFICGO
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x68F04D0", Offset = "0x68EF8D0", VA = "0x1868F04D0")]
	protected JMFCDPEBFIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct PGFHOMLEMBG<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private HMOLGNHCFLH<T> FKMAFNEMDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityCommandBuffer DAIEEBBBKKG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HMOLGNHCFLH<T> HLHLCEJIGHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x380D560", Offset = "0x380C960", VA = "0x18380D560")]
		get
		{
			return default(HMOLGNHCFLH<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x454CC20", Offset = "0x454C020", VA = "0x18454CC20")]
	public PGFHOMLEMBG(HMOLGNHCFLH<T> FKMAFNEMDJH, EntityCommandBuffer DAIEEBBBKKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x47D8ED0", Offset = "0x47D82D0", VA = "0x1847D8ED0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct NOJCBHLGFCG<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private CMAGKFMIJLJ<T> FKMAFNEMDJH;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3D00A70", Offset = "0x3CFFE70", VA = "0x183D00A70")]
	public NOJCBHLGFCG(CMAGKFMIJLJ<T> FKMAFNEMDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4558F20", Offset = "0x4558320", VA = "0x184558F20")]
	public PGFHOMLEMBG<T> HGLPAPLPJGL()
	{
		return default(PGFHOMLEMBG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct NNHIGOPBFKG<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private HMOLGNHCFLH<T> FKMAFNEMDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityCommandBuffer DAIEEBBBKKG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public HMOLGNHCFLH<T> HLHLCEJIGHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x380D560", Offset = "0x380C960", VA = "0x18380D560")]
		get
		{
			return default(HMOLGNHCFLH<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x454CC20", Offset = "0x454C020", VA = "0x18454CC20")]
	public NNHIGOPBFKG(HMOLGNHCFLH<T> FKMAFNEMDJH, EntityCommandBuffer DAIEEBBBKKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x454C220", Offset = "0x454B620", VA = "0x18454C220")]
	public void NBKNNBMCCDK(CMAGKFMIJLJ<T> HBGDCEFAIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x454B360", Offset = "0x454A760", VA = "0x18454B360", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct GECBLJDBAKM<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CMAGKFMIJLJ<T> FKMAFNEMDJH;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3D00A70", Offset = "0x3CFFE70", VA = "0x183D00A70")]
	public GECBLJDBAKM(CMAGKFMIJLJ<T> FKMAFNEMDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3D00790", Offset = "0x3CFFB90", VA = "0x183D00790")]
	public NNHIGOPBFKG<T> MEAAAIFIALL()
	{
		return default(NNHIGOPBFKG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AlwaysUpdateSystem]
public abstract class AFJECGLJCFK : SystemBase
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private EntityCommandBufferSystem FGJNGACCPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private NativeList<EntityQuery> HNKIBAIBOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool CCPPJLMHGAL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EntityCommandBufferSystem FOFELAJBLNB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	protected abstract BADOKLEEAHE NEKMHMJECLN
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected bool OODFNLHIOMP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1B698E0", Offset = "0x1B68CE0", VA = "0x181B698E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x84D8F0", Offset = "0x84CCF0", VA = "0x18084D8F0")]
	public void PFNBFKAIBIE(EntityCommandBufferSystem FGJNGACCPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x68F0360", Offset = "0x68EF760", VA = "0x1868F0360", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68F0440", Offset = "0x68EF840", VA = "0x1868F0440", Slot = "13")]
	protected sealed override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x68F03F0", Offset = "0x68EF7F0", VA = "0x1868F03F0", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract void OKKDMDIOLLJ();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3217670", Offset = "0x3216A70", VA = "0x183217670")]
	protected EntityQuery FAHEFOMNPLC<T>() where T : struct, IComponentData
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3217EB0", Offset = "0x32172B0", VA = "0x183217EB0")]
	protected GECBLJDBAKM<T> JCIHEIMODDL<T>() where T : struct, IComponentData
	{
		return default(GECBLJDBAKM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3219140", Offset = "0x3218540", VA = "0x183219140")]
	protected NOJCBHLGFCG<T> NOOEJCEJHLI<T>() where T : struct, IComponentData
	{
		return default(NOJCBHLGFCG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x15B3AC0", Offset = "0x15B2EC0", VA = "0x1815B3AC0")]
	protected AFJECGLJCFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DefaultMember("Item")]
public struct HMOLGNHCFLH<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public NativeList<Entity> OMFJPLKFCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NativeList<T> LDNEPNAGEGN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int LHAGCGMDNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3D97EF0", Offset = "0x3D972F0", VA = "0x183D97EF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public (Entity entity, T value) OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3D974C0", Offset = "0x3D968C0", VA = "0x183D974C0")]
		get
		{
			return default((Entity, T));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3D96680", Offset = "0x3D95A80", VA = "0x183D96680")]
	public void HINMMBAADBG(Entity KHAAFKNHHNL, T OBEEJPGJPFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct CMAGKFMIJLJ<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[ReadOnly]
	public EntityQueryInJob EMMJEBBEHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[ReadOnly]
	public EntityTypeHandle NMGKOLGFMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[ReadOnly]
	public ComponentTypeHandle<T> BNAHCKDHBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[WriteOnly]
	public EntityCommandBuffer DAIEEBBBKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public AllocatorManager.AllocatorHandle EIFDLGAHDFC;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x50390D0", Offset = "0x50384D0", VA = "0x1850390D0")]
	public HMOLGNHCFLH<T> HGLPAPLPJGL()
	{
		return default(HMOLGNHCFLH<T>);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FKGLLJJNECC
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public FKGLLJJNECC()
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

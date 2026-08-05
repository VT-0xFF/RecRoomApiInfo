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
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public abstract class LDEDGNPOBED : EKBKKGMCGEN
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60D9F10", Offset = "0x60D8D10", VA = "0x1860D9F10", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase AJFNLJOMGJA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60D9E70", Offset = "0x60D8C70", VA = "0x1860D9E70")]
	protected ComponentSystemBase DDBJCMIAPHG(params ComponentSystemBase[] JGBIGODNMJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x27F4790", Offset = "0x27F3590", VA = "0x1827F4790")]
	protected ComponentSystemBase DDBJCMIAPHG<T>(params ComponentSystemBase[] JGBIGODNMJI) where T : EKBKKGMCGEN, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x27F4750", Offset = "0x27F3550", VA = "0x1827F4750")]
	protected ComponentSystemBase EJBONOJCBKM<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x27F4750", Offset = "0x27F3550", VA = "0x1827F4750")]
	protected ComponentSystemBase CMDHFAPBIAN<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x60D9EC0", Offset = "0x60D8CC0", VA = "0x1860D9EC0")]
	protected ComponentSystemBase OMIMBMADOGB(params SystemHandleUntyped[] JGBIGODNMJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x27F4880", Offset = "0x27F3680", VA = "0x1827F4880")]
	protected ComponentSystemBase OMIMBMADOGB<T>(params SystemHandleUntyped[] JGBIGODNMJI) where T : EKBKKGMCGEN, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x27F4820", Offset = "0x27F3620", VA = "0x1827F4820")]
	protected SystemHandleUntyped FPMMHCIGHDJ<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x60D9CB0", Offset = "0x60D8AB0", VA = "0x1860D9CB0")]
	protected LDEDGNPOBED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LONGMLBFHLJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EKBKKGMCGEN : EBDKGPICGCP
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x60D9D00", Offset = "0x60D8B00", VA = "0x1860D9D00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x60D9CB0", Offset = "0x60D8AB0", VA = "0x1860D9CB0")]
	public EKBKKGMCGEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class EBDKGPICGCP : ComponentSystemGroup, LONGMLBFHLJ
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x60D9CB0", Offset = "0x60D8AB0", VA = "0x1860D9CB0")]
	protected EBDKGPICGCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct CAKKMMMLFCE<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private KMDBMKMMJKN<T> OCEOBDFJNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityCommandBuffer PCCICGJEGBH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public KMDBMKMMJKN<T> IGJKIFJNABH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3613680", Offset = "0x3612480", VA = "0x183613680")]
		get
		{
			return default(KMDBMKMMJKN<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3EAF8B0", Offset = "0x3EAE6B0", VA = "0x183EAF8B0")]
	public CAKKMMMLFCE(KMDBMKMMJKN<T> OCEOBDFJNCG, EntityCommandBuffer PCCICGJEGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4B7CA50", Offset = "0x4B7B850", VA = "0x184B7CA50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct IABMDKIPAEF<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private HHEMOJLMHED<T> OCEOBDFJNCG;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3857D50", Offset = "0x3856B50", VA = "0x183857D50")]
	public IABMDKIPAEF(HHEMOJLMHED<T> OCEOBDFJNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3857990", Offset = "0x3856790", VA = "0x183857990")]
	public CAKKMMMLFCE<T> EABCPGHMLKP()
	{
		return default(CAKKMMMLFCE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct NGFCCCBMMLN<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private KMDBMKMMJKN<T> OCEOBDFJNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityCommandBuffer PCCICGJEGBH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public KMDBMKMMJKN<T> IGJKIFJNABH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3613680", Offset = "0x3612480", VA = "0x183613680")]
		get
		{
			return default(KMDBMKMMJKN<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3EAF8B0", Offset = "0x3EAE6B0", VA = "0x183EAF8B0")]
	public NGFCCCBMMLN(KMDBMKMMJKN<T> OCEOBDFJNCG, EntityCommandBuffer PCCICGJEGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3EAF610", Offset = "0x3EAE410", VA = "0x183EAF610")]
	public void GBKDMOJHDCF(HHEMOJLMHED<T> HKPGCEAFBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3EAEE80", Offset = "0x3EADC80", VA = "0x183EAEE80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct NNFGMLBCBML<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private HHEMOJLMHED<T> OCEOBDFJNCG;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3857D50", Offset = "0x3856B50", VA = "0x183857D50")]
	public NNFGMLBCBML(HHEMOJLMHED<T> OCEOBDFJNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3EE44B0", Offset = "0x3EE32B0", VA = "0x183EE44B0")]
	public NGFCCCBMMLN<T> AIGBFIMGNDL()
	{
		return default(NGFCCCBMMLN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AlwaysUpdateSystem]
public abstract class IIFLCBDHLLH : SystemBase
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private EntityCommandBufferSystem MOMNNDIAGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private NativeList<EntityQuery> HECKAKELJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool AMFJOMPKBIE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EntityCommandBufferSystem AFBLBDAGDAK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	protected abstract IIFCCHIKGII INBEFCGIFMO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected bool KOELFDEDMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x386ADA0", Offset = "0x3869BA0", VA = "0x18386ADA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7B8F50", Offset = "0x7B7D50", VA = "0x1807B8F50")]
	public void IFDKDOKEEAL(EntityCommandBufferSystem MOMNNDIAGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x60D9D30", Offset = "0x60D8B30", VA = "0x1860D9D30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60D9E10", Offset = "0x60D8C10", VA = "0x1860D9E10", Slot = "13")]
	protected sealed override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x60D9DC0", Offset = "0x60D8BC0", VA = "0x1860D9DC0", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract void PHHEGBOKHNP();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2788CA0", Offset = "0x2787AA0", VA = "0x182788CA0")]
	protected EntityQuery KJMJHKCFELF<T>() where T : struct, IComponentData
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x27880B0", Offset = "0x2786EB0", VA = "0x1827880B0")]
	protected NNFGMLBCBML<T> ABJDDPFJCDH<T>() where T : struct, IComponentData
	{
		return default(NNFGMLBCBML<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2788BA0", Offset = "0x27879A0", VA = "0x182788BA0")]
	protected IABMDKIPAEF<T> CJOPENCIBNK<T>() where T : struct, IComponentData
	{
		return default(IABMDKIPAEF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7C9100", Offset = "0x7C7F00", VA = "0x1807C9100")]
	protected IIFLCBDHLLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DefaultMember("Item")]
public struct KMDBMKMMJKN<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public NativeList<Entity> ILPEGPIDHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NativeList<T> EEDANCJJEPL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EINKGEEBGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3B2CB70", Offset = "0x3B2B970", VA = "0x183B2CB70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public (Entity entity, T value) GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3B2D660", Offset = "0x3B2C460", VA = "0x183B2D660")]
		get
		{
			return default((Entity, T));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3B2C870", Offset = "0x3B2B670", VA = "0x183B2C870")]
	public void GALNLGNAACN(Entity JLCPBIBMCCJ, T MAEBFBHFPDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct HHEMOJLMHED<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[ReadOnly]
	public EntityQueryInJob GLHAGHMBEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[ReadOnly]
	public EntityTypeHandle HGDEBPLDLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[ReadOnly]
	public ComponentTypeHandle<T> JKKCHCIFFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[WriteOnly]
	public EntityCommandBuffer PCCICGJEGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public AllocatorManager.AllocatorHandle ALDDPOOJFGI;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x37BB300", Offset = "0x37BA100", VA = "0x1837BB300")]
	public KMDBMKMMJKN<T> EABCPGHMLKP()
	{
		return default(KMDBMKMMJKN<T>);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class HPJJGAKKNAL
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public HPJJGAKKNAL()
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

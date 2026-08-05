using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class)]
public class PNEIECIPGHH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
	public PNEIECIPGHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class HOEPBNPDHBA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7FBFC10", Offset = "0x7FBE210", VA = "0x187FBFC10")]
	public HOEPBNPDHBA(int GPNBMIDFKMK, int IGCNJBPIAOA, int EKEEDNKENMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class PHJDBGIEKDN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA70610", Offset = "0xA6EC10", VA = "0x180A70610")]
	public PHJDBGIEKDN(bool LJCJBAAFFDH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class)]
public class JEGFPHMHGCD : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7FBFC60", Offset = "0x7FBE260", VA = "0x187FBFC60")]
	public JEGFPHMHGCD(string IEDAJGLJHNI, string LCNJPNDEDOK = "")
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Class)]
public class JOIJBFNKAOG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IBMJNNAJGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2357BC0", Offset = "0x23561C0", VA = "0x182357BC0")]
	public JOIJBFNKAOG(int KKGBKLFKCPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
public enum HEFCOEOLOKI
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	NonNetworked = 1,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Incoming = 2,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Outgoing = 4,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Suppressed = 8,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	FastForward = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	CacheRemove = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Default = 0x3F,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	All = 0x3F
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IJHGAPMKDGO
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IDDDDOLACNM<T> : IJHGAPMKDGO
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MGFOOPGHBGH([In] EHJMGOEHNJP GONKAOGFIDC, T KKGBKLFKCPO);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NBPDHNLHNDC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool EKLCNDNFKLH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int DAMHAIICPBI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int JGDPFKLBMHA(Type JLPANLJHHFI);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FMEMLEGEFBO(NativeParallelHashMap<int, HABDMPMOHEE> EHECCAJFJLF, NativeArray<byte> ACJFHCNBBBO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JHGHBHIIGIG
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class ELADKNAEEKF
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class HEOCAEMMAGJ<T> : GLPPMJFOPGP<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4724F50", Offset = "0x4723550", VA = "0x184724F50")]
	protected HEOCAEMMAGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class GLPPMJFOPGP<T> : IDDDDOLACNM<T>, IJHGAPMKDGO where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4D666D0", Offset = "0x4D64CD0", VA = "0x184D666D0")]
	public void MGFOOPGHBGH([In] EHJMGOEHNJP GONKAOGFIDC, T KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	protected GLPPMJFOPGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4D666B0", Offset = "0x4D64CB0", VA = "0x184D666B0", Slot = "4")]
	private void IADKEJMGCJH([In] EHJMGOEHNJP GONKAOGFIDC, T KKGBKLFKCPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class GBDBCKICAGN<T> : IDDDDOLACNM<NativeArray<T>>, IJHGAPMKDGO where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4D259C0", Offset = "0x4D23FC0", VA = "0x184D259C0")]
	public void MGFOOPGHBGH([In] EHJMGOEHNJP GONKAOGFIDC, NativeArray<T> KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3CC5040", Offset = "0x3CC3640", VA = "0x183CC5040")]
	public static ReadOnlySpan<T> HBOJJEJKJJE<T>(NativeArray<T> DDENONPPKCL) where T : struct
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	protected GBDBCKICAGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4D25990", Offset = "0x4D23F90", VA = "0x184D25990", Slot = "4")]
	private void DPDLOGLAJKI([In] EHJMGOEHNJP GONKAOGFIDC, NativeArray<T> KKGBKLFKCPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IKKACHNDJCI : IDDDDOLACNM<IKKACHNDJCI.LGOFDHNMMDF>, IJHGAPMKDGO
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct LGOFDHNMMDF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
	public void MGFOOPGHBGH([In] EHJMGOEHNJP GONKAOGFIDC, LGOFDHNMMDF KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public IKKACHNDJCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	private void PKJMEGNICLM([In] EHJMGOEHNJP GONKAOGFIDC, LGOFDHNMMDF KKGBKLFKCPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KKOOFLKNPFI : IDDDDOLACNM<string>, IJHGAPMKDGO
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly KKOOFLKNPFI FNIBPMLJKFE;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7FBFCC0", Offset = "0x7FBE2C0", VA = "0x187FBFCC0")]
	public void MGFOOPGHBGH([In] EHJMGOEHNJP GONKAOGFIDC, string KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public KKOOFLKNPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7FBFCB0", Offset = "0x7FBE2B0", VA = "0x187FBFCB0", Slot = "4")]
	private void DAFFOFHIJCG([In] EHJMGOEHNJP GONKAOGFIDC, string KKGBKLFKCPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class JMMGHJMLFMG<T> : MMAFJLGKNKJ<T> where T : struct, IComparable<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4724F50", Offset = "0x4723550", VA = "0x184724F50")]
	protected JMMGHJMLFMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class MMAFJLGKNKJ<T> : IDDDDOLACNM<T>, IJHGAPMKDGO where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5613E10", Offset = "0x5612410", VA = "0x185613E10")]
	public void MGFOOPGHBGH([In] EHJMGOEHNJP GONKAOGFIDC, T KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	protected MMAFJLGKNKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4D666B0", Offset = "0x4D64CB0", VA = "0x184D666B0", Slot = "4")]
	private void IADKEJMGCJH([In] EHJMGOEHNJP GONKAOGFIDC, T KKGBKLFKCPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct EHJMGOEHNJP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct LDHELGCBLIF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly EHJMGOEHNJP GONKAOGFIDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly int GJEMEELGKIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly int OANGBNLNLOH;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5F37D20", Offset = "0x5F36320", VA = "0x185F37D20")]
		public LDHELGCBLIF(EHJMGOEHNJP GONKAOGFIDC, int GJEMEELGKIE, int OANGBNLNLOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7FC0130", Offset = "0x7FBE730", VA = "0x187FC0130")]
		public LDHELGCBLIF KKEHKNGPAPH(ReadOnlySpan<byte> ACJFHCNBBBO)
		{
			return default(LDHELGCBLIF);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4236D00", Offset = "0x4235300", VA = "0x184236D00")]
		public LDHELGCBLIF KKEHKNGPAPH<T>(T ACJFHCNBBBO) where T : struct
		{
			return default(LDHELGCBLIF);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7FC0090", Offset = "0x7FBE690", VA = "0x187FC0090", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private NBPDHNLHNDC AMDIGMMBNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NativeParallelHashMap<int, HABDMPMOHEE> EHECCAJFJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<byte> ACJFHCNBBBO;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7FBFA30", Offset = "0x7FBE030", VA = "0x187FBFA30")]
	public EHJMGOEHNJP(NBPDHNLHNDC AMDIGMMBNKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7FBF940", Offset = "0x7FBDF40", VA = "0x187FBF940")]
	public int JOFEKECPCIG(IJHGAPMKDGO ABKNIBKILDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7FBF6A0", Offset = "0x7FBDCA0", VA = "0x187FBF6A0")]
	public LDHELGCBLIF DHAFGPHALME(IJHGAPMKDGO ABKNIBKILDN)
	{
		return default(LDHELGCBLIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7FBF790", Offset = "0x7FBDD90", VA = "0x187FBF790")]
	public LDHELGCBLIF DHAFGPHALME(int AJHFBEHEIGE)
	{
		return default(LDHELGCBLIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7FBF570", Offset = "0x7FBDB70", VA = "0x187FBF570")]
	public void CKFDMMPHCBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7FBF8A0", Offset = "0x7FBDEA0", VA = "0x187FBF8A0")]
	public EHJMGOEHNJP FJGIFBPLLNO()
	{
		return default(EHJMGOEHNJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7FBF840", Offset = "0x7FBDE40", VA = "0x187FBF840", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class DKHFFJCBJLP
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x399B160", Offset = "0x3999760", VA = "0x18399B160")]
	public static EHJMGOEHNJP JDPCENHCAFL<T>([In] this EHJMGOEHNJP GONKAOGFIDC, IDDDDOLACNM<T> ABKNIBKILDN, T KKGBKLFKCPO)
	{
		return default(EHJMGOEHNJP);
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

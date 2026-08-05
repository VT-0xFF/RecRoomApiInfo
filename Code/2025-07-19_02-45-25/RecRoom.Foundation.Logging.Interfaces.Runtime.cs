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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class)]
public class OOMPPGJLHHB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
	public OOMPPGJLHHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class BNDNKGFGMFC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8185C30", Offset = "0x8184C30", VA = "0x188185C30")]
	public BNDNKGFGMFC(int BKLOHAHJLKP, int MAEIHFIBCFB, int JJJDNDPMGEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class ELINCOAEPLN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA8B800", Offset = "0xA8A800", VA = "0x180A8B800")]
	public ELINCOAEPLN(bool FAHPGPPNCBJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class)]
public class POIBLLFGJIP : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x81867E0", Offset = "0x81857E0", VA = "0x1881867E0")]
	public POIBLLFGJIP(string HJLBILHBIIC, string GAPCMICLLJD = "")
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Class)]
public class PJAACGFKJED : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BDJLGAHJNPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x242AB90", Offset = "0x2429B90", VA = "0x18242AB90")]
	public PJAACGFKJED(int IOALKPFEKEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
public enum FILJPCBJCLJ
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
public interface LFDDDIBFBHA
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EENNIJPIAPC<T> : LFDDDIBFBHA
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DMIFBHEKBBI([In] JFIINGNNCOL GMENMGEBJMF, T IOALKPFEKEK);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DBEBBELMOJK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool PMIEJHICDBH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int LPLKDIBHCDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int KGGDFMEKDEI(Type BJLNCBFOGNL);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IDJDBNCFAMA(NativeParallelHashMap<int, LKKNDHJDELB> GHPPGCHDHHL, NativeArray<byte> INCJDDLACNP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface AMOEGAFMKBE
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class PECGCDDCLKG
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class JFFDKCLLMKG<T> : OIDDFEGKGNN<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x48B4C40", Offset = "0x48B3C40", VA = "0x1848B4C40")]
	protected JFFDKCLLMKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class OIDDFEGKGNN<T> : EENNIJPIAPC<T>, LFDDDIBFBHA where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5932330", Offset = "0x5931330", VA = "0x185932330")]
	public void DMIFBHEKBBI([In] JFIINGNNCOL GMENMGEBJMF, T IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	protected OIDDFEGKGNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5932410", Offset = "0x5931410", VA = "0x185932410", Slot = "4")]
	private void ECMGCEJIEEM([In] JFIINGNNCOL GMENMGEBJMF, T IOALKPFEKEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class JNOAKHPMAOB<T> : EENNIJPIAPC<NativeArray<T>>, LFDDDIBFBHA where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x52E2060", Offset = "0x52E1060", VA = "0x1852E2060")]
	public void DMIFBHEKBBI([In] JFIINGNNCOL GMENMGEBJMF, NativeArray<T> IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFA60", Offset = "0x3DFEA60", VA = "0x183DFFA60")]
	public static ReadOnlySpan<T> IBJKPLDKMGD<T>(NativeArray<T> MFIJBPNIELL) where T : struct
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	protected JNOAKHPMAOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x52E21B0", Offset = "0x52E11B0", VA = "0x1852E21B0", Slot = "4")]
	private void GPFAKMKIBOB([In] JFIINGNNCOL GMENMGEBJMF, NativeArray<T> IOALKPFEKEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JEIICKOKCHE : EENNIJPIAPC<JEIICKOKCHE.NDBOKEMDHOI>, LFDDDIBFBHA
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct NDBOKEMDHOI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
	public void DMIFBHEKBBI([In] JFIINGNNCOL GMENMGEBJMF, NDBOKEMDHOI IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public JEIICKOKCHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	private void DGEKMOKPCKO([In] JFIINGNNCOL GMENMGEBJMF, NDBOKEMDHOI IOALKPFEKEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MDKDGPHMENG : EENNIJPIAPC<string>, LFDDDIBFBHA
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly MDKDGPHMENG KONBGMLOLPI;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8186400", Offset = "0x8185400", VA = "0x188186400")]
	public void DMIFBHEKBBI([In] JFIINGNNCOL GMENMGEBJMF, string IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public MDKDGPHMENG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8186750", Offset = "0x8185750", VA = "0x188186750", Slot = "4")]
	private void FAOKNNCFOFL([In] JFIINGNNCOL GMENMGEBJMF, string IOALKPFEKEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class JPDOKHODGFF<T> : PBCCEIBBIDO<T> where T : struct, IComparable<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x48B4C40", Offset = "0x48B3C40", VA = "0x1848B4C40")]
	protected JPDOKHODGFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class PBCCEIBBIDO<T> : EENNIJPIAPC<T>, LFDDDIBFBHA where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5A1DDA0", Offset = "0x5A1CDA0", VA = "0x185A1DDA0")]
	public void DMIFBHEKBBI([In] JFIINGNNCOL GMENMGEBJMF, T IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	protected PBCCEIBBIDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5932410", Offset = "0x5931410", VA = "0x185932410", Slot = "4")]
	private void ECMGCEJIEEM([In] JFIINGNNCOL GMENMGEBJMF, T IOALKPFEKEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JFIINGNNCOL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct IMHHLJPELDG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly JFIINGNNCOL GMENMGEBJMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly int GJFDDOJOIOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly int BFFGAOBDKKD;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x60BA830", Offset = "0x60B9830", VA = "0x1860BA830")]
		public IMHHLJPELDG(JFIINGNNCOL GMENMGEBJMF, int GJFDDOJOIOG, int BFFGAOBDKKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8185D20", Offset = "0x8184D20", VA = "0x188185D20")]
		public IMHHLJPELDG EKDAOPEAFPJ(ReadOnlySpan<byte> INCJDDLACNP)
		{
			return default(IMHHLJPELDG);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x43A1600", Offset = "0x43A0600", VA = "0x1843A1600")]
		public IMHHLJPELDG EKDAOPEAFPJ<T>(T INCJDDLACNP) where T : struct
		{
			return default(IMHHLJPELDG);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8185C80", Offset = "0x8184C80", VA = "0x188185C80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private DBEBBELMOJK HDAKANCKKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NativeParallelHashMap<int, LKKNDHJDELB> GHPPGCHDHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<byte> INCJDDLACNP;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8186230", Offset = "0x8185230", VA = "0x188186230")]
	public JFIINGNNCOL(DBEBBELMOJK HDAKANCKKDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8185F10", Offset = "0x8184F10", VA = "0x188185F10")]
	public int HKOFIFNKKHN(LFDDDIBFBHA EPFLIAPJNOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8186090", Offset = "0x8185090", VA = "0x188186090")]
	public IMHHLJPELDG NHOEMLDDBGE(LFDDDIBFBHA EPFLIAPJNOD)
	{
		return default(IMHHLJPELDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8186180", Offset = "0x8185180", VA = "0x188186180")]
	public IMHHLJPELDG NHOEMLDDBGE(int NLOCOAHFHJB)
	{
		return default(IMHHLJPELDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8185DE0", Offset = "0x8184DE0", VA = "0x188185DE0")]
	public void GEIODCMLOHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8185FF0", Offset = "0x8184FF0", VA = "0x188185FF0")]
	public JFIINGNNCOL JAMDHJMFGHJ()
	{
		return default(JFIINGNNCOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8185D80", Offset = "0x8184D80", VA = "0x188185D80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class ELHLHJAPFCM
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3AD14A0", Offset = "0x3AD04A0", VA = "0x183AD14A0")]
	public static JFIINGNNCOL DOPEKGIEJEC<T>([In] this JFIINGNNCOL GMENMGEBJMF, EENNIJPIAPC<T> EPFLIAPJNOD, T IOALKPFEKEK)
	{
		return default(JFIINGNNCOL);
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

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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class)]
public class MFEPICKPFDI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
	public MFEPICKPFDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class GBLPMNMKLCC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x82C0D10", Offset = "0x82C0110", VA = "0x1882C0D10")]
	public GBLPMNMKLCC(int MPDDFCCPIOM, int JOFEPKJOJBL, int INLHALEBBJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class HGGGAJOCELI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA99B40", Offset = "0xA98F40", VA = "0x180A99B40")]
	public HGGGAJOCELI(bool LDDEAHONJNK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class)]
public class FPNMABOIHII : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x82C0CC0", Offset = "0x82C00C0", VA = "0x1882C0CC0")]
	public FPNMABOIHII(string HDNPPEBJPAE, string GMABBLIJJKB = "")
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Class)]
public class ONBBAOHIDEK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JCMAOCOGHGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2485220", Offset = "0x2484620", VA = "0x182485220")]
	public ONBBAOHIDEK(int CBMEHPPMEEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
public enum FMKJKLCDMGB
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
public interface KNFOGIMNAEH
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JNEOHHNFLCE<T> : KNFOGIMNAEH
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BHMHOEBLIFC([In] NPGJJAOPLDO ODAEABHOMJO, T CBMEHPPMEEA);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NKKAKEODMHE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool OCLKMFNONKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int PFEOPCIKLFG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int JFOODEKHNGD(Type IIHAKBEOLJD);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BLNJHOLOCLF(NativeParallelHashMap<int, NJKCHNHGMDO> CLIKJBPKKKI, NativeArray<byte> NGIAGNLBILI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IMCDKNMGIOJ
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class JDBAPMANFBH
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class OCNNBBMIKPP<T> : LNMNAHOKCLB<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x44ECB20", Offset = "0x44EBF20", VA = "0x1844ECB20")]
	protected OCNNBBMIKPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class LNMNAHOKCLB<T> : JNEOHHNFLCE<T>, KNFOGIMNAEH where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4539330", Offset = "0x4538730", VA = "0x184539330")]
	public void BHMHOEBLIFC([In] NPGJJAOPLDO ODAEABHOMJO, T CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	protected LNMNAHOKCLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x45396C0", Offset = "0x4538AC0", VA = "0x1845396C0", Slot = "4")]
	private void PDLNCNKNMMC([In] NPGJJAOPLDO ODAEABHOMJO, T CBMEHPPMEEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class LPICNPLCJND<T> : JNEOHHNFLCE<NativeArray<T>>, KNFOGIMNAEH where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5595DF0", Offset = "0x55951F0", VA = "0x185595DF0")]
	public void BHMHOEBLIFC([In] NPGJJAOPLDO ODAEABHOMJO, NativeArray<T> CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3E638F0", Offset = "0x3E62CF0", VA = "0x183E638F0")]
	public static ReadOnlySpan<T> DJEIIBOKDME<T>(NativeArray<T> LMLCJEFLFMP) where T : struct
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	protected LPICNPLCJND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5595F40", Offset = "0x5595340", VA = "0x185595F40", Slot = "4")]
	private void MNEFBLPCBAK([In] NPGJJAOPLDO ODAEABHOMJO, NativeArray<T> CBMEHPPMEEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class GDGMIGLKFDP : JNEOHHNFLCE<GDGMIGLKFDP.KDJEMIJNGPF>, KNFOGIMNAEH
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct KDJEMIJNGPF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	public void BHMHOEBLIFC([In] NPGJJAOPLDO ODAEABHOMJO, KDJEMIJNGPF CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public GDGMIGLKFDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	private void JMEKPBJFBDO([In] NPGJJAOPLDO ODAEABHOMJO, KDJEMIJNGPF CBMEHPPMEEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class BFGMCLEOGEN : JNEOHHNFLCE<string>, KNFOGIMNAEH
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly BFGMCLEOGEN NKAKNKMIPPI;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x82C08E0", Offset = "0x82BFCE0", VA = "0x1882C08E0")]
	public void BHMHOEBLIFC([In] NPGJJAOPLDO ODAEABHOMJO, string CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public BFGMCLEOGEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x82C0C30", Offset = "0x82C0030", VA = "0x1882C0C30", Slot = "4")]
	private void JFJKIEFBOGJ([In] NPGJJAOPLDO ODAEABHOMJO, string CBMEHPPMEEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class BABIHNNHANA<T> : DDKCMHFDJJD<T> where T : struct, IComparable<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x44ECB20", Offset = "0x44EBF20", VA = "0x1844ECB20")]
	protected BABIHNNHANA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class DDKCMHFDJJD<T> : JNEOHHNFLCE<T>, KNFOGIMNAEH where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4539250", Offset = "0x4538650", VA = "0x184539250")]
	public void BHMHOEBLIFC([In] NPGJJAOPLDO ODAEABHOMJO, T CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	protected DDKCMHFDJJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x45396C0", Offset = "0x4538AC0", VA = "0x1845396C0", Slot = "4")]
	private void PDLNCNKNMMC([In] NPGJJAOPLDO ODAEABHOMJO, T CBMEHPPMEEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct NPGJJAOPLDO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct JEJGKHCBDKD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly NPGJJAOPLDO ODAEABHOMJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly int FPLDOFEGBAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly int KLEJDENMMJF;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x61723C0", Offset = "0x61717C0", VA = "0x1861723C0")]
		public JEJGKHCBDKD(NPGJJAOPLDO ODAEABHOMJO, int FPLDOFEGBAL, int KLEJDENMMJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x82C0E00", Offset = "0x82C0200", VA = "0x1882C0E00")]
		public JEJGKHCBDKD JHGEFBAJJLP(ReadOnlySpan<byte> NGIAGNLBILI)
		{
			return default(JEJGKHCBDKD);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x441DD80", Offset = "0x441D180", VA = "0x18441DD80")]
		public JEJGKHCBDKD JHGEFBAJJLP<T>(T NGIAGNLBILI) where T : struct
		{
			return default(JEJGKHCBDKD);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x82C0D60", Offset = "0x82C0160", VA = "0x1882C0D60", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private NKKAKEODMHE CEMPIJDGFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NativeParallelHashMap<int, NJKCHNHGMDO> CLIKJBPKKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<byte> NGIAGNLBILI;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x82C1310", Offset = "0x82C0710", VA = "0x1882C1310")]
	public NPGJJAOPLDO(NKKAKEODMHE CEMPIJDGFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x82C1060", Offset = "0x82C0460", VA = "0x1882C1060")]
	public int HCGCNMKANFD(KNFOGIMNAEH GBOEJHCDIGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x82C0F10", Offset = "0x82C0310", VA = "0x1882C0F10")]
	public JEJGKHCBDKD DCBFOFKHELJ(KNFOGIMNAEH GBOEJHCDIGI)
	{
		return default(JEJGKHCBDKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x82C0E60", Offset = "0x82C0260", VA = "0x1882C0E60")]
	public JEJGKHCBDKD DCBFOFKHELJ(int LMJGCJHGBBF)
	{
		return default(JEJGKHCBDKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x82C11E0", Offset = "0x82C05E0", VA = "0x1882C11E0")]
	public void OFFKLMLFJJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x82C1140", Offset = "0x82C0540", VA = "0x1882C1140")]
	public NPGJJAOPLDO IMAIIMDHCFG()
	{
		return default(NPGJJAOPLDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x82C1000", Offset = "0x82C0400", VA = "0x1882C1000", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class EIICJOHHCGM
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3B34A00", Offset = "0x3B33E00", VA = "0x183B34A00")]
	public static NPGJJAOPLDO KOBMLIBBKBO<T>([In] this NPGJJAOPLDO ODAEABHOMJO, JNEOHHNFLCE<T> GBOEJHCDIGI, T CBMEHPPMEEA)
	{
		return default(NPGJJAOPLDO);
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

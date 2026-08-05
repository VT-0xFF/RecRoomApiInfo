using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x84D2160", Offset = "0x84D0D60", VA = "0x1884D2160")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA879A0", Offset = "0xA865A0", VA = "0x180A879A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class EECDIOBOHBI : AHMFKOHFEKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private class OAIABFJMIBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int HEHHIBDCLNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int IPDLAGCCHDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public bool IFGDEHFNMAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public DateTime? CFMBPAMHLFD;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x84D21E0", Offset = "0x84D0DE0", VA = "0x1884D21E0")]
		public OAIABFJMIBJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct CMLOBJCNLOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public EECDIOBOHBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x84CFE90", Offset = "0x84CEA90", VA = "0x1884CFE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x84D0270", Offset = "0x84CEE70", VA = "0x1884D0270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly IMLLBHMDGLG OHMOEOBJNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly DKCBALPBFPJ DFJCGJKDAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly GAFEJJBMOGG FCIFIOGBFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly CEDFNINGHPN AIAFDKCHONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly GNNHJGKDEMF PANHMDCENKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly PEHHKHACOAC MBMIIEAOJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly JPPFLHIEAKP NGAPIMCMAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly MPIIOEGAGLP EJMAMEFADFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<NOPEEMEGJLL, MBIPAIDHEJH> GGAHGFMGKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly OAIABFJMIBJ NGINDFNCGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Dictionary<int, string> FEGBHLOBBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private int AHCGBNDANND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private float LKJAMGENHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private float KECENOAGPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int? NNANGAINKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int JOPCPJPMCMP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JDPDIFNNOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84D0430", Offset = "0x84CF030", VA = "0x1884D0430", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CNAEPMLCHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA94530", Offset = "0xA93130", VA = "0x180A94530", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1526EE0", Offset = "0x1525AE0", VA = "0x181526EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public TimeSpan IEFNFNCJMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84D11A0", Offset = "0x84CFDA0", VA = "0x1884D11A0", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private DateTime BLBPAHLEGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84D0B70", Offset = "0x84CF770", VA = "0x1884D0B70")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool GBMLGKGLNOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x84D1260", Offset = "0x84CFE60", VA = "0x1884D1260", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private DateTime ONJCCEDNMEG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x84D0E50", Offset = "0x84CFA50", VA = "0x1884D0E50")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public string NJPCCGHCFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA5B440", Offset = "0xA5A040", VA = "0x180A5B440", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA5B650", Offset = "0xA5A250", VA = "0x180A5B650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public float MEADFMKOEHF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x18AC380", Offset = "0x18AAF80", VA = "0x1818AC380", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1A07E50", Offset = "0x1A06A50", VA = "0x181A07E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float AEOPIGILNBL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1853300", Offset = "0x1851F00", VA = "0x181853300", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1423670", Offset = "0x1422270", VA = "0x181423670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string AIOGCDJIOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA5EA70", Offset = "0xA5D670", VA = "0x180A5EA70", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA5EB70", Offset = "0xA5D770", VA = "0x180A5EB70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string PFJCAHDFAKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xAC01F0", Offset = "0xABEDF0", VA = "0x180AC01F0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xABDCF0", Offset = "0xABC8F0", VA = "0x180ABDCF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int MMNHCIKPCIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x84D0360", Offset = "0x84CEF60", VA = "0x1884D0360", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x84D1D60", Offset = "0x84D0960", VA = "0x1884D1D60")]
	[Preserve]
	internal EECDIOBOHBI([HAKCNCGPHPD(null)][NDIKMIAMGFC] IMLLBHMDGLG NJPDIECAGPE, [HAKCNCGPHPD(null)][NDIKMIAMGFC] DKCBALPBFPJ ABKELJNOFBE, [NDIKMIAMGFC][HAKCNCGPHPD("ServerTime")] GAFEJJBMOGG FCIFIOGBFAD, [HAKCNCGPHPD(null)][NDIKMIAMGFC] CEDFNINGHPN NCAMCGOHDNP, [NDIKMIAMGFC][HAKCNCGPHPD(null)] GNNHJGKDEMF PANHMDCENKO, [HAKCNCGPHPD(null)][NDIKMIAMGFC] PEHHKHACOAC MBMIIEAOJOA, [NDIKMIAMGFC][HAKCNCGPHPD(null)] JPPFLHIEAKP NGAPIMCMAAI, [HAKCNCGPHPD(null)][NDIKMIAMGFC] MPIIOEGAGLP EJMAMEFADFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x84D0C20", Offset = "0x84CF820", VA = "0x1884D0C20", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x84D1B10", Offset = "0x84D0710", VA = "0x1884D1B10")]
	private void MEHAPAFBACK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x84D0920", Offset = "0x84CF520", VA = "0x1884D0920")]
	private void BCOKNLEHAAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x84D1000", Offset = "0x84CFC00", VA = "0x1884D1000")]
	private void FFKNPLNOFNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x84D04A0", Offset = "0x84CF0A0", VA = "0x1884D04A0")]
	private void AJOIEKEOAID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x84D1410", Offset = "0x84D0010", VA = "0x1884D1410")]
	private void JKDMAJKDMDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x84D1A60", Offset = "0x84D0660", VA = "0x1884D1A60", Slot = "14")]
	public int LMEIFNELLOB(int FINOFDAMOCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x84D0EE0", Offset = "0x84CFAE0", VA = "0x1884D0EE0", Slot = "15")]
	public string EJKEMNMOFEE(int FINOFDAMOCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x84D1360", Offset = "0x84CFF60", VA = "0x1884D1360", Slot = "16")]
	public MBIPAIDHEJH GHNOGAAPAIA(NOPEEMEGJLL NDMEBHICHPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x84D02D0", Offset = "0x84CEED0", VA = "0x1884D02D0", Slot = "17")]
	public void ABAPOCPPBCK(NOPEEMEGJLL NDMEBHICHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x84D1C90", Offset = "0x84D0890", VA = "0x1884D1C90", Slot = "18")]
	[AsyncStateMachine(typeof(CMLOBJCNLOP))]
	public Task OOOKJCHNLLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x84D19F0", Offset = "0x84D05F0", VA = "0x1884D19F0", Slot = "19")]
	public (int, int) LINKJCOANLG()
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x84D1230", Offset = "0x84CFE30", VA = "0x1884D1230", Slot = "20")]
	public void FOOIEFEDKGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x84D1B30", Offset = "0x84D0730", VA = "0x1884D1B30")]
	private int MPKJHHKNEBG(MBIPAIDHEJH EHLKIKGNNGK, MBIPAIDHEJH MMGNGPFBICG)
	{
		return default(int);
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

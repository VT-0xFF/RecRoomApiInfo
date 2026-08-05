using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CSCore;
using CSCore.CoreAudioAPI;
using CSCore.SoundIn;
using CSCore.Streams;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DGNBIHCOLPL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CBIPEGBCHNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<IOFEHBNIMPP> NEFOAHINMEO();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IOFEHBNIMPP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string FMLDLBGKEMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool GPBICKHPLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MEPNKGPMJAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MEIALGKALAN KMLLEFCMCBI(Action<ArraySegment<float>> DKOPNCNMOIF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FDLLMOGFNKB();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct MEIALGKALAN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FJBDBKKPFNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9696E0", Offset = "0x9680E0", VA = "0x1809696E0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB0FC60", Offset = "0xB0E660", VA = "0x180B0FC60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int AOPGHEJJOOK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2664280", Offset = "0x2662C80", VA = "0x182664280")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5F77A80", Offset = "0x5F76480", VA = "0x185F77A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6BEF450", Offset = "0x6BEDE50", VA = "0x186BEF450")]
	public MEIALGKALAN(int DMDEDNDMLFC, int LIGLBDHFDJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LKFFEFKOHMH
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static DGNBIHCOLPL APBPBLEEACE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool CBIPEGBCHNO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7526680", Offset = "0x7525080", VA = "0x187526680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x75267E0", Offset = "0x75251E0", VA = "0x1875267E0")]
	static LKFFEFKOHMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x75266F0", Offset = "0x75250F0", VA = "0x1875266F0")]
	public static IReadOnlyList<IOFEHBNIMPP> NEFOAHINMEO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JKFGCDMJAPO : DGNBIHCOLPL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class EODPPCAMPPM : IOFEHBNIMPP
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class OECPOHDGKDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Action<ArraySegment<float>> callback;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public float[] buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public int length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ISampleSource sampleSource;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public OECPOHDGKDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x75268D0", Offset = "0x75252D0", VA = "0x1875268D0")]
			internal void MHMPAMMBGCE(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice DKACFLEPEHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture POJEKMGMCFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource AMDLKNNHNLL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string FMLDLBGKEMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7526260", Offset = "0x7524C60", VA = "0x187526260", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool GPBICKHPLGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8FEDF0", Offset = "0x8FD7F0", VA = "0x1808FEDF0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xCE8060", Offset = "0xCE6A60", VA = "0x180CE8060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MEPNKGPMJAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x1045970", Offset = "0x1044370", VA = "0x181045970", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7525E70", Offset = "0x7524870", VA = "0x187525E70", Slot = "7")]
		public MEIALGKALAN KMLLEFCMCBI(Action<ArraySegment<float>> DKOPNCNMOIF)
		{
			return default(MEIALGKALAN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7525EA0", Offset = "0x75248A0", VA = "0x187525EA0")]
		private MEIALGKALAN KMLLEFCMCBI(int DMDEDNDMLFC, int LFMJLKNFOBE, int LIGLBDHFDJL, Action<ArraySegment<float>> DKOPNCNMOIF)
		{
			return default(MEIALGKALAN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7525DF0", Offset = "0x75247F0", VA = "0x187525DF0", Slot = "8")]
		public void FDLLMOGFNKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7526280", Offset = "0x7524C80", VA = "0x187526280")]
		public EODPPCAMPPM(MMDevice DKACFLEPEHO, bool DIGCPHIMIBL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<EODPPCAMPPM> BFDNBDCPJPG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool CBIPEGBCHNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x75262D0", Offset = "0x7524CD0", VA = "0x1875262D0", Slot = "5")]
	public IReadOnlyList<IOFEHBNIMPP> NEFOAHINMEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x75265F0", Offset = "0x7524FF0", VA = "0x1875265F0")]
	public JKFGCDMJAPO()
	{
	}
}
namespace Cpp2IlInjected;

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

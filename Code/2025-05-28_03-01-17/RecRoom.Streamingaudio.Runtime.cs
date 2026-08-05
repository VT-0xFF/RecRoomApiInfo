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
public interface IDKPAEMKMJI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IEHEJGNJPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<CPCKNELLCJL> PNCJBHGEOJC();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CPCKNELLCJL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string KPDIBFFPHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool ADOBMDKJACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool JEINBGCGFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OPPLBPBPMDA CLMJANNELEB(Action<ArraySegment<float>> LDLIMOGOGBF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OODICPBHFFB();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct OPPLBPBPMDA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DPMDCNFGGCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA55A60", Offset = "0xA54860", VA = "0x180A55A60")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x12EC4E0", Offset = "0x12EB2E0", VA = "0x1812EC4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KAJLOGKHNBB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2EB6640", Offset = "0x2EB5440", VA = "0x182EB6640")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F9F2F0", Offset = "0x6F9E0F0", VA = "0x186F9F2F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7E00490", Offset = "0x7DFF290", VA = "0x187E00490")]
	public OPPLBPBPMDA(int BICOGKIAPPM, int CPCMKMKKGNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HMEFFEDMELF
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static IDKPAEMKMJI JKHMJIJBOFJ;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool IEHEJGNJPBI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x88B3740", Offset = "0x88B2540", VA = "0x1888B3740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x88B38B0", Offset = "0x88B26B0", VA = "0x1888B38B0")]
	static HMEFFEDMELF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x88B37C0", Offset = "0x88B25C0", VA = "0x1888B37C0")]
	public static IReadOnlyList<CPCKNELLCJL> PNCJBHGEOJC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JHLGNEOIMIB : IDKPAEMKMJI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class GMINEEHMKOB : CPCKNELLCJL
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class LPGIGOKDEIG
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
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public LPGIGOKDEIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x88B3D50", Offset = "0x88B2B50", VA = "0x1888B3D50")]
			internal void EBMDMACHPOG(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice BPCKMANIHAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture BHMJLBIBGBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource JKNPLLPFMDJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string KPDIBFFPHNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x88B3650", Offset = "0x88B2450", VA = "0x1888B3650", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool ADOBMDKJACE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xDD8CC0", Offset = "0xDD7AC0", VA = "0x180DD8CC0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xAD8900", Offset = "0xAD7700", VA = "0x180AD8900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JEINBGCGFIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xDBB630", Offset = "0xDBA430", VA = "0x180DBB630", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x88B3260", Offset = "0x88B2060", VA = "0x1888B3260", Slot = "7")]
		public OPPLBPBPMDA CLMJANNELEB(Action<ArraySegment<float>> LDLIMOGOGBF)
		{
			return default(OPPLBPBPMDA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x88B3290", Offset = "0x88B2090", VA = "0x1888B3290")]
		private OPPLBPBPMDA CLMJANNELEB(int BICOGKIAPPM, int GOHOHIHIPED, int CPCMKMKKGNF, Action<ArraySegment<float>> LDLIMOGOGBF)
		{
			return default(OPPLBPBPMDA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x88B3670", Offset = "0x88B2470", VA = "0x1888B3670", Slot = "8")]
		public void OODICPBHFFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x88B36F0", Offset = "0x88B24F0", VA = "0x1888B36F0")]
		public GMINEEHMKOB(MMDevice BPCKMANIHAM, bool CAGOGEKFMHK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<GMINEEHMKOB> HJHBHEHLDFL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool IEHEJGNJPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x88B39A0", Offset = "0x88B27A0", VA = "0x1888B39A0", Slot = "5")]
	public IReadOnlyList<CPCKNELLCJL> PNCJBHGEOJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x88B3CC0", Offset = "0x88B2AC0", VA = "0x1888B3CC0")]
	public JHLGNEOIMIB()
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

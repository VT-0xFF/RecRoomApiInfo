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
public interface NODONJGJOPF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BNOCGDMMNAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<OCOHFFPGLHA> NKAGGHFMCDG();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OCOHFFPGLHA
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string JDBNGHCMKPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool DBMJGOFJJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool ONLAFPHDAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GCEGIGHCELO PNGDOENNGOL(Action<ArraySegment<float>> MEKLMIFMFCO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IBNFEJOPGJM();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct GCEGIGHCELO
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DKCPPPLFNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9906E0", Offset = "0x98F4E0", VA = "0x1809906E0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7F1B50", Offset = "0x7F0950", VA = "0x1807F1B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int AKLMMEJLNDH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1FBBF30", Offset = "0x1FBAD30", VA = "0x181FBBF30")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x51FC460", Offset = "0x51FB260", VA = "0x1851FC460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6399B10", Offset = "0x6398910", VA = "0x186399B10")]
	public GCEGIGHCELO(int KAKOMBAIBMA, int OJBJKDLFEJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EMBGGGNJKKF
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static NODONJGJOPF EBIEIJFALOI;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool BNOCGDMMNAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x63998B0", Offset = "0x63986B0", VA = "0x1863998B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6399A20", Offset = "0x6398820", VA = "0x186399A20")]
	static EMBGGGNJKKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6399930", Offset = "0x6398730", VA = "0x186399930")]
	public static IReadOnlyList<OCOHFFPGLHA> NKAGGHFMCDG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OGGEGJFMCNA : NODONJGJOPF
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class CHKAAIGEJKM : OCOHFFPGLHA
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class KNJIOLCAMEP
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
			[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
			public KNJIOLCAMEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6399B20", Offset = "0x6398920", VA = "0x186399B20")]
			internal void DEFMAIIFEIE(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice HLIIOBHPBLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture GPAMCCLMCON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource NAHCCBDNLNE;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string JDBNGHCMKPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6399450", Offset = "0x6398250", VA = "0x186399450", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DBMJGOFJJJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7FCD80", Offset = "0x7FBB80", VA = "0x1807FCD80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x869AB0", Offset = "0x8688B0", VA = "0x180869AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ONLAFPHDAEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xB8A980", Offset = "0xB89780", VA = "0x180B8A980", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6399830", Offset = "0x6398630", VA = "0x186399830", Slot = "7")]
		public GCEGIGHCELO PNGDOENNGOL(Action<ArraySegment<float>> MEKLMIFMFCO)
		{
			return default(GCEGIGHCELO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6399470", Offset = "0x6398270", VA = "0x186399470")]
		private GCEGIGHCELO PNGDOENNGOL(int KAKOMBAIBMA, int PPCAPPENFHK, int OJBJKDLFEJK, Action<ArraySegment<float>> MEKLMIFMFCO)
		{
			return default(GCEGIGHCELO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x63993D0", Offset = "0x63981D0", VA = "0x1863993D0", Slot = "8")]
		public void IBNFEJOPGJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6399860", Offset = "0x6398660", VA = "0x186399860")]
		public CHKAAIGEJKM(MMDevice HLIIOBHPBLE, bool NNDCIAPPNGF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<CHKAAIGEJKM> FCOCOEBKNOA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool BNOCGDMMNAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x77D2F0", Offset = "0x77C0F0", VA = "0x18077D2F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6399CA0", Offset = "0x6398AA0", VA = "0x186399CA0", Slot = "5")]
	public IReadOnlyList<OCOHFFPGLHA> NKAGGHFMCDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6399FC0", Offset = "0x6398DC0", VA = "0x186399FC0")]
	public OGGEGJFMCNA()
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

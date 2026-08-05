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
public interface NKJIOPONOAE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool ECGFMLIBKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<HJLBGKACDPE> BAJENOAFJKE();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HJLBGKACDPE
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string HFLFOHLMPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool KPADPDGPFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GLEJDGCGGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DIMCIDACMHH FHOABCCELJI(Action<ArraySegment<float>> LBJMJKFNAPH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MHDKPFPAHIH();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct DIMCIDACMHH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int NKJCILDDMAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xD91780", Offset = "0xD90580", VA = "0x180D91780")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x156A1B0", Offset = "0x1568FB0", VA = "0x18156A1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DDLHFJCGKHH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x300A170", Offset = "0x3008F70", VA = "0x18300A170")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x300A160", Offset = "0x3008F60", VA = "0x18300A160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x83EB590", Offset = "0x83EA390", VA = "0x1883EB590")]
	public DIMCIDACMHH(int FMAPGJELDND, int GBHDIJIKCIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GOLCPIKKDEA
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static NKJIOPONOAE ICCDNBLKPOH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool ECGFMLIBKNC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8670", Offset = "0x8EF7470", VA = "0x188EF8670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8EF86E0", Offset = "0x8EF74E0", VA = "0x188EF86E0")]
	static GOLCPIKKDEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8EF8580", Offset = "0x8EF7380", VA = "0x188EF8580")]
	public static IReadOnlyList<HJLBGKACDPE> BAJENOAFJKE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PFIIIGBMIDH : NKJIOPONOAE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class ODAGLAEDEMI : HJLBGKACDPE
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class JIILCPBLBAO
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
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public JIILCPBLBAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8EF87D0", Offset = "0x8EF75D0", VA = "0x188EF87D0")]
			internal void OLLBPMMOGID(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice GBLAKLAFJIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture LFFIMJODMBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource MGHCNHMNFCM;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string HFLFOHLMPIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8EF8DC0", Offset = "0x8EF7BC0", VA = "0x188EF8DC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool KPADPDGPFPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xC38800", Offset = "0xC37600", VA = "0x180C38800", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xC01980", Offset = "0xC00780", VA = "0x180C01980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GLEJDGCGGLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xF0E0C0", Offset = "0xF0CEC0", VA = "0x180F0E0C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8950", Offset = "0x8EF7750", VA = "0x188EF8950", Slot = "7")]
		public DIMCIDACMHH FHOABCCELJI(Action<ArraySegment<float>> LBJMJKFNAPH)
		{
			return default(DIMCIDACMHH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8980", Offset = "0x8EF7780", VA = "0x188EF8980")]
		private DIMCIDACMHH FHOABCCELJI(int FMAPGJELDND, int LCFMBBHLLKG, int GBHDIJIKCIM, Action<ArraySegment<float>> LBJMJKFNAPH)
		{
			return default(DIMCIDACMHH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8D40", Offset = "0x8EF7B40", VA = "0x188EF8D40", Slot = "8")]
		public void MHDKPFPAHIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8DE0", Offset = "0x8EF7BE0", VA = "0x188EF8DE0")]
		public ODAGLAEDEMI(MMDevice GBLAKLAFJIP, bool NDCBKJHJNAA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<ODAGLAEDEMI> BDIIFCCLPFH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool ECGFMLIBKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8EF8E30", Offset = "0x8EF7C30", VA = "0x188EF8E30", Slot = "5")]
	public IReadOnlyList<HJLBGKACDPE> BAJENOAFJKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8EF9150", Offset = "0x8EF7F50", VA = "0x188EF9150")]
	public PFIIIGBMIDH()
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

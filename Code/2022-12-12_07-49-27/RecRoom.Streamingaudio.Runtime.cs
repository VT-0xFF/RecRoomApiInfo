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
public interface OLNPLAOGEJE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EBLAENBFGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<LPNONEPCOEN> PLCKPOFMLPD();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LPNONEPCOEN
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string AMGPGOMDLKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool OJIBCELILGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BKJDBALDJDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OCBOJJJFAPP EGDHIGAMLFI(Action<ArraySegment<float>> ONHFNOPIIKL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OHNAOMAAAED();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct OCBOJJJFAPP
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int PFBILJPGFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x792CD0", Offset = "0x7912D0", VA = "0x180792CD0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x794540", Offset = "0x792B40", VA = "0x180794540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HFIANJEPDGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7F3C20", Offset = "0x7F2220", VA = "0x1807F3C20")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7F3C30", Offset = "0x7F2230", VA = "0x1807F3C30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1D35190", Offset = "0x1D33790", VA = "0x181D35190")]
	public OCBOJJJFAPP(int EANJDEPMAOJ, int LJMPDGPOHFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HHFMAFGBNPH
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static OLNPLAOGEJE KJMBMCGJAMG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool EBLAENBFGPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1D34A80", Offset = "0x1D33080", VA = "0x181D34A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1D34C00", Offset = "0x1D33200", VA = "0x181D34C00")]
	static HHFMAFGBNPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1D34B00", Offset = "0x1D33100", VA = "0x181D34B00")]
	public static IReadOnlyList<LPNONEPCOEN> PLCKPOFMLPD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FKFFIPKNHNP : OLNPLAOGEJE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class NPLBHHLNCPK : LPNONEPCOEN
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class CMBHAOPMLIP
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
			[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
			public CMBHAOPMLIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x1D34590", Offset = "0x1D32B90", VA = "0x181D34590")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice JEAJMHHBKBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture LEOIJOAPMBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource PMBFKINEMIB;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string AMGPGOMDLKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1D350A0", Offset = "0x1D336A0", VA = "0x181D350A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool OJIBCELILGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x84A610", Offset = "0x848C10", VA = "0x18084A610", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x84A6A0", Offset = "0x848CA0", VA = "0x18084A6A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BKJDBALDJDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x87A710", Offset = "0x878D10", VA = "0x18087A710", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1D35070", Offset = "0x1D33670", VA = "0x181D35070", Slot = "7")]
		public OCBOJJJFAPP EGDHIGAMLFI(Action<ArraySegment<float>> ONHFNOPIIKL)
		{
			return default(OCBOJJJFAPP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1D34CD0", Offset = "0x1D332D0", VA = "0x181D34CD0")]
		private OCBOJJJFAPP EGDHIGAMLFI(int EANJDEPMAOJ, int HIECLBKPLFM, int LJMPDGPOHFO, Action<ArraySegment<float>> ONHFNOPIIKL)
		{
			return default(OCBOJJJFAPP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1D350C0", Offset = "0x1D336C0", VA = "0x181D350C0", Slot = "8")]
		public void OHNAOMAAAED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1D35140", Offset = "0x1D33740", VA = "0x181D35140")]
		public NPLBHHLNCPK(MMDevice JEAJMHHBKBH, bool PAKPINILGPB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<NPLBHHLNCPK> KIJPKFDMEKE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool EBLAENBFGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x747120", Offset = "0x745720", VA = "0x180747120", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1D34720", Offset = "0x1D32D20", VA = "0x181D34720", Slot = "5")]
	public IReadOnlyList<LPNONEPCOEN> PLCKPOFMLPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1D34A00", Offset = "0x1D33000", VA = "0x181D34A00")]
	public FKFFIPKNHNP()
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

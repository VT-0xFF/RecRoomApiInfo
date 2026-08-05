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
		[Cpp2IlInjected.Address(RVA = "0x728E20", Offset = "0x727820", VA = "0x180728E20")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x728D90", Offset = "0x727790", VA = "0x180728D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HFIANJEPDGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B60", Offset = "0x8B4560", VA = "0x1808B5B60")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xE8F640", Offset = "0xE8E040", VA = "0x180E8F640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6096850", Offset = "0x6095250", VA = "0x186096850")]
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
		[Cpp2IlInjected.Address(RVA = "0x6096140", Offset = "0x6094B40", VA = "0x186096140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x60962C0", Offset = "0x6094CC0", VA = "0x1860962C0")]
	static HHFMAFGBNPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x60961C0", Offset = "0x6094BC0", VA = "0x1860961C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
			public CMBHAOPMLIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6095C50", Offset = "0x6094650", VA = "0x186095C50")]
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
			[Cpp2IlInjected.Address(RVA = "0x6096760", Offset = "0x6095160", VA = "0x186096760", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool OJIBCELILGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x767F80", Offset = "0x766980", VA = "0x180767F80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x731170", Offset = "0x72FB70", VA = "0x180731170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BKJDBALDJDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6B8C60", Offset = "0x6B7660", VA = "0x1806B8C60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6096730", Offset = "0x6095130", VA = "0x186096730", Slot = "7")]
		public OCBOJJJFAPP EGDHIGAMLFI(Action<ArraySegment<float>> ONHFNOPIIKL)
		{
			return default(OCBOJJJFAPP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6096390", Offset = "0x6094D90", VA = "0x186096390")]
		private OCBOJJJFAPP EGDHIGAMLFI(int EANJDEPMAOJ, int HIECLBKPLFM, int LJMPDGPOHFO, Action<ArraySegment<float>> ONHFNOPIIKL)
		{
			return default(OCBOJJJFAPP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6096780", Offset = "0x6095180", VA = "0x186096780", Slot = "8")]
		public void OHNAOMAAAED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6096800", Offset = "0x6095200", VA = "0x186096800")]
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
		[Cpp2IlInjected.Address(RVA = "0x698020", Offset = "0x696A20", VA = "0x180698020", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6095DE0", Offset = "0x60947E0", VA = "0x186095DE0", Slot = "5")]
	public IReadOnlyList<LPNONEPCOEN> PLCKPOFMLPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x60960C0", Offset = "0x6094AC0", VA = "0x1860960C0")]
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

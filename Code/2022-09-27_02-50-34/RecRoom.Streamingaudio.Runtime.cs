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
public interface MCKOLGOEMCB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PFGHKJAJAHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<KPFOEGKMGNK> CAEDLKJFNIA();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KPFOEGKMGNK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string KGBDEEFHAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool JFIJMCNFNDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HHEDEHGCKKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OAKNPALBFIB AKNBKKKBAMH(Action<ArraySegment<float>> ELMGCHGCEJD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PLAIDHKCOMK();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct OAKNPALBFIB
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int COFGDAMMLPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FD360", Offset = "0x6FC560", VA = "0x1806FD360")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6FD370", Offset = "0x6FC570", VA = "0x1806FD370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int ODPGDDBDLAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x881B10", Offset = "0x880D10", VA = "0x180881B10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x881B00", Offset = "0x880D00", VA = "0x180881B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x28940A0", Offset = "0x28932A0", VA = "0x1828940A0")]
	public OAKNPALBFIB(int FAFDDMAJIBE, int EAAJADAIKGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DPMCIDFJBBI
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static MCKOLGOEMCB IDMNFNOECEB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool PFGHKJAJAHH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2893C70", Offset = "0x2892E70", VA = "0x182893C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2893CE0", Offset = "0x2892EE0", VA = "0x182893CE0")]
	static DPMCIDFJBBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2893B80", Offset = "0x2892D80", VA = "0x182893B80")]
	public static IReadOnlyList<KPFOEGKMGNK> CAEDLKJFNIA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HEHCJHIGDFH : MCKOLGOEMCB
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class DKBJJLFIDIP : KPFOEGKMGNK
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class OCELBFBHMHC
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
			[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
			public OCELBFBHMHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x28940B0", Offset = "0x28932B0", VA = "0x1828940B0")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice AOHDOLMFMON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture OCGLFEJJDEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource FFKLEBGINKL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string KGBDEEFHAME
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2893A90", Offset = "0x2892C90", VA = "0x182893A90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool JFIJMCNFNDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7E7390", Offset = "0x7E6590", VA = "0x1807E7390", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7E7600", Offset = "0x7E6800", VA = "0x1807E7600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HHEDEHGCKKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xBA96A0", Offset = "0xBA88A0", VA = "0x180BA96A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2893A60", Offset = "0x2892C60", VA = "0x182893A60", Slot = "7")]
		public OAKNPALBFIB AKNBKKKBAMH(Action<ArraySegment<float>> ELMGCHGCEJD)
		{
			return default(OAKNPALBFIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2893720", Offset = "0x2892920", VA = "0x182893720")]
		private OAKNPALBFIB AKNBKKKBAMH(int FAFDDMAJIBE, int BNKKIAGPBAC, int EAAJADAIKGB, Action<ArraySegment<float>> ELMGCHGCEJD)
		{
			return default(OAKNPALBFIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2893AB0", Offset = "0x2892CB0", VA = "0x182893AB0", Slot = "8")]
		public void PLAIDHKCOMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2893B30", Offset = "0x2892D30", VA = "0x182893B30")]
		public DKBJJLFIDIP(MMDevice AOHDOLMFMON, bool GLCAEOFMNHC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<DKBJJLFIDIP> BLBIKPLJPDE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool PFGHKJAJAHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x601070", Offset = "0x600270", VA = "0x180601070", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2893D90", Offset = "0x2892F90", VA = "0x182893D90", Slot = "5")]
	public IReadOnlyList<KPFOEGKMGNK> CAEDLKJFNIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2894030", Offset = "0x2893230", VA = "0x182894030")]
	public HEHCJHIGDFH()
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

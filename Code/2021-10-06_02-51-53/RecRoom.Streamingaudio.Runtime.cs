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
public interface PJPOLABFBGI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NMJFPFCMLLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<BACDJPJJDMI> BGKDNEMDJCN();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BACDJPJJDMI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string OAIIAFHPPOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool KFGJJPFJNFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DILNDJLPMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IHABKFPPEKP PCLINMJPHDL(Action<ArraySegment<float>> GAMOMGCMAHI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MBPICDGBBEG();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct IHABKFPPEKP
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FPDLOKNDPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5526A0", Offset = "0x5516A0", VA = "0x1805526A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5526C0", Offset = "0x5516C0", VA = "0x1805526C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KNOJFPPMCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x735260", Offset = "0x734260", VA = "0x180735260")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x781950", Offset = "0x780950", VA = "0x180781950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3D0AC20", Offset = "0x3D09C20", VA = "0x183D0AC20")]
	public IHABKFPPEKP(int OFNJLLGFNMN, int ANNKLOCJNJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DKOIFLKLBIB
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static PJPOLABFBGI DAPLMMHMEFC;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool NMJFPFCMLLD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3D0A740", Offset = "0x3D09740", VA = "0x183D0A740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3D0A7B0", Offset = "0x3D097B0", VA = "0x183D0A7B0")]
	static DKOIFLKLBIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3D0A650", Offset = "0x3D09650", VA = "0x183D0A650")]
	public static IReadOnlyList<BACDJPJJDMI> BGKDNEMDJCN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CBCINHBLHGD : PJPOLABFBGI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class HGJMMMODMFB : BACDJPJJDMI
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class JFOFPBIIEMM
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
			[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
			public JFOFPBIIEMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3D0AC30", Offset = "0x3D09C30", VA = "0x183D0AC30")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice EJDIFEADENF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture KJADCGLIJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource PJMCBIDJNJA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string OAIIAFHPPOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3D0A850", Offset = "0x3D09850", VA = "0x183D0A850", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool KFGJJPFJNFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x51CE00", Offset = "0x51BE00", VA = "0x18051CE00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7A7EA0", Offset = "0x7A6EA0", VA = "0x1807A7EA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DILNDJLPMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xCDD9F0", Offset = "0xCDC9F0", VA = "0x180CDD9F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3D0ABB0", Offset = "0x3D09BB0", VA = "0x183D0ABB0", Slot = "7")]
		public IHABKFPPEKP PCLINMJPHDL(Action<ArraySegment<float>> GAMOMGCMAHI)
		{
			return default(IHABKFPPEKP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3D0A8D0", Offset = "0x3D098D0", VA = "0x183D0A8D0")]
		private IHABKFPPEKP PCLINMJPHDL(int OFNJLLGFNMN, int EKOJOHJPFEJ, int ANNKLOCJNJK, Action<ArraySegment<float>> GAMOMGCMAHI)
		{
			return default(IHABKFPPEKP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3D0A870", Offset = "0x3D09870", VA = "0x183D0A870", Slot = "8")]
		public void MBPICDGBBEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3D0ABE0", Offset = "0x3D09BE0", VA = "0x183D0ABE0")]
		public HGJMMMODMFB(MMDevice EJDIFEADENF, bool BFJKKLLGFKL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<HGJMMMODMFB> JHGBENGOKNG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool NMJFPFCMLLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x447060", Offset = "0x446060", VA = "0x180447060", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3D0A350", Offset = "0x3D09350", VA = "0x183D0A350", Slot = "5")]
	public IReadOnlyList<BACDJPJJDMI> BGKDNEMDJCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3D0A5F0", Offset = "0x3D095F0", VA = "0x183D0A5F0")]
	public CBCINHBLHGD()
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

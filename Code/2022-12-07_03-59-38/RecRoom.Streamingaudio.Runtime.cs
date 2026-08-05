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
public interface JEABIFIEDIL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OJMNHBEGNKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<FMBFHDGEKJO> EGHNEOCPDLD();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FMBFHDGEKJO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string OIBJOHNPHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool BKPFKNLFCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool JNNJPOPIKJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HPNFEIPAHCD EBNAELBFDOG(Action<ArraySegment<float>> JGLIBPMCCNL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DOPFBNKJMJB();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct HPNFEIPAHCD
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FHLFILILCAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6D9CB0", Offset = "0x6D88B0", VA = "0x1806D9CB0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6DB530", Offset = "0x6DA130", VA = "0x1806DB530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MHGCHLGHMAN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x715000", Offset = "0x713C00", VA = "0x180715000")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x715010", Offset = "0x713C10", VA = "0x180715010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x60949A0", Offset = "0x60935A0", VA = "0x1860949A0")]
	public HPNFEIPAHCD(int NHIJPNMIMKF, int AGNFLIKAAMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class AEMBAFPJGEM
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static JEABIFIEDIL KCHOPLNIILF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool OJMNHBEGNKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x60944F0", Offset = "0x60930F0", VA = "0x1860944F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6094570", Offset = "0x6093170", VA = "0x186094570")]
	static AEMBAFPJGEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x60943F0", Offset = "0x6092FF0", VA = "0x1860943F0")]
	public static IReadOnlyList<FMBFHDGEKJO> EGHNEOCPDLD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BKDGPHIJPGE : JEABIFIEDIL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class PLBAPFMPJEG : FMBFHDGEKJO
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class MGNJOGCKLOL
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
			[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
			public MGNJOGCKLOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x60949B0", Offset = "0x60935B0", VA = "0x1860949B0")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice EDHPPPGGDIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture FBGNECLCHGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource BCHOHHPALDO;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string OIBJOHNPHGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6094F90", Offset = "0x6093B90", VA = "0x186094F90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool BKPFKNLFCKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7C4280", Offset = "0x7C2E80", VA = "0x1807C4280", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7C4300", Offset = "0x7C2F00", VA = "0x1807C4300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JNNJPOPIKJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7D1D20", Offset = "0x7D0920", VA = "0x1807D1D20", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6094F60", Offset = "0x6093B60", VA = "0x186094F60", Slot = "7")]
		public HPNFEIPAHCD EBNAELBFDOG(Action<ArraySegment<float>> JGLIBPMCCNL)
		{
			return default(HPNFEIPAHCD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6094BC0", Offset = "0x60937C0", VA = "0x186094BC0")]
		private HPNFEIPAHCD EBNAELBFDOG(int NHIJPNMIMKF, int HPODHAIAFAD, int AGNFLIKAAMB, Action<ArraySegment<float>> JGLIBPMCCNL)
		{
			return default(HPNFEIPAHCD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6094B40", Offset = "0x6093740", VA = "0x186094B40", Slot = "8")]
		public void DOPFBNKJMJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6094FB0", Offset = "0x6093BB0", VA = "0x186094FB0")]
		public PLBAPFMPJEG(MMDevice EDHPPPGGDIK, bool HDGMANEAKDK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<PLBAPFMPJEG> GODOONELIJP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool OJMNHBEGNKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6AD850", Offset = "0x6AC450", VA = "0x1806AD850", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6094640", Offset = "0x6093240", VA = "0x186094640", Slot = "5")]
	public IReadOnlyList<FMBFHDGEKJO> EGHNEOCPDLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6094920", Offset = "0x6093520", VA = "0x186094920")]
	public BKDGPHIJPGE()
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

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Dynamic.Api;
using Circuits.Shared.Api;
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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA1C30", Offset = "0x2BA0630", VA = "0x182BA1C30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3B0", Offset = "0xD39DB0", VA = "0x180D3B3B0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Dynamic.RecRoom.Api
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct DynamicCircuitsErrRegistry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public Id32<WWRAASIHDRG> ConvertedFromLegacy;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1BF0", Offset = "0x2BA05F0", VA = "0x182BA1BF0")]
		public static DynamicCircuitsErrRegistry New()
		{
			return default(DynamicCircuitsErrRegistry);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1BB0", Offset = "0x2BA05B0", VA = "0x182BA1BB0")]
		[CompilerGenerated]
		internal static Id32<WWRAASIHDRG> ESOMNPCOIAQ(int a)
		{
			return default(Id32<WWRAASIHDRG>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface MRNHRDHQHVF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface LAOSOHNGXZN
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		int IKEMJWBASMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		int YJPHFXZPFSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		float ADYTGAUWZWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		float ZLJVMPERCIX
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool VCXYHCWHDQN
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool AOUIBKHKWVV
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool AELTLDMCOJL
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		LegacyCV2Result<None> CV2SetMaxAmmo(YRRNONXIVNU e, int max);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		LegacyCV2Result<None> CV2SetCurrentAmmo(YRRNONXIVNU e, int current);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "9")]
		LegacyCV2Result<None> CV2SetADSEnabled(YRRNONXIVNU e, bool enabled);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "10")]
		LegacyCV2Result<None> CV2SetCanReload(YRRNONXIVNU e, bool canReload);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "11")]
		LegacyCV2Result<None> CV2SetContinuousFire(YRRNONXIVNU e, bool continuousFire);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "12")]
		LegacyCV2Result<None> CV2SetRateOfFire(YRRNONXIVNU e, float rate);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "13")]
		LegacyCV2Result<None> CV2SetReloadDuration(YRRNONXIVNU e, float time);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface VHEBTBBPLUX
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		string OSWHUUQDYEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		LegacyCV2Result<None> SetHandleControlLabel(YRRNONXIVNU e, string label);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface ACDFLBHNDNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		(MRNHRDHQHVF, MRNHRDHQHVF, MRNHRDHQHVF, MRNHRDHQHVF, MRNHRDHQHVF) HQBIXDFIFER(object a);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		object GetLocalPlayer();

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool FGCJYTKVFEA(object a);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		string SFXAXROLCZM(object a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface KBMWQTETDFB
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool CDEBOEJXXZO
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface HKSUIQJZABZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		LARFXRVRZOQ? UIOXUQVVXGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface LARFXRVRZOQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		IEnumerable<string> DKAHQVMCBFF
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string UOFYVULFWYF(string a);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void AFRRIUNMAOY(string a, string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface FLLSEBDXVIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CircuitsColor PWPUUPFOQMM(int a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int DCCWKKJQXHS([In] CircuitsColor circuitsColor);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface WTEDEOUTIOR
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		LegacyCV2Result<None> SetEnabled(YRRNONXIVNU e, bool setEnabled);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public readonly struct RecRoomDynamicDeps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly VTQXGJFVGXL EngineDeps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly FLLSEBDXVIB GameDeps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly ACDFLBHNDNA PlayerDeps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly DynamicCircuitsErrRegistry DynamicErr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly DynamicCircuitsErrDefs DynamicErrDefs;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1CB0", Offset = "0x2BA06B0", VA = "0x182BA1CB0")]
		public RecRoomDynamicDeps(VTQXGJFVGXL engineDeps, FLLSEBDXVIB gameDeps, ACDFLBHNDNA playerDeps, [In] DynamicCircuitsErrRegistry dynamicErr, DynamicCircuitsErrDefs dynamicErrDefs)
		{
		}
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

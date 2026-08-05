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
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		[Cpp2IlInjected.Address(RVA = "0x2864250", Offset = "0x2863650", VA = "0x182864250")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACEB40", Offset = "0xACDF40", VA = "0x180ACEB40")]
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
		[Cpp2IlInjected.Address(RVA = "0xACEB80", Offset = "0xACDF80", VA = "0x180ACEB80")]
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
		public Id32<WFDLYHBQOFK> ConvertedFromLegacy;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2864210", Offset = "0x2863610", VA = "0x182864210")]
		public static DynamicCircuitsErrRegistry New()
		{
			return default(DynamicCircuitsErrRegistry);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28641D0", Offset = "0x28635D0", VA = "0x1828641D0")]
		[CompilerGenerated]
		internal static Id32<WFDLYHBQOFK> GZXUVWMMDTW(int a)
		{
			return default(Id32<WFDLYHBQOFK>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface BILRNMKXHUH
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface JINIWGOENMX
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		int MRXMODEBKXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		int SEUUNHUWIJU
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		float UUWZYPGMFSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		float DHRQMVUYCNN
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool ANWRHOTXISF
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool NXFWKBUCCIX
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool INCVKRTTRDT
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		LegacyCV2Result<None> CV2SetMaxAmmo(QVMTSXADWLM e, int max);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		LegacyCV2Result<None> CV2SetCurrentAmmo(QVMTSXADWLM e, int current);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "9")]
		LegacyCV2Result<None> CV2SetADSEnabled(QVMTSXADWLM e, bool enabled);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "10")]
		LegacyCV2Result<None> CV2SetCanReload(QVMTSXADWLM e, bool canReload);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "11")]
		LegacyCV2Result<None> CV2SetContinuousFire(QVMTSXADWLM e, bool continuousFire);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "12")]
		LegacyCV2Result<None> CV2SetRateOfFire(QVMTSXADWLM e, float rate);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "13")]
		LegacyCV2Result<None> CV2SetReloadDuration(QVMTSXADWLM e, float time);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface MNXCIKJAYTF
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		string PNXMGFVQKAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		LegacyCV2Result<None> SetHandleControlLabel(QVMTSXADWLM e, string label);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface KCXVZIKDHAS
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		(BILRNMKXHUH, BILRNMKXHUH, BILRNMKXHUH, BILRNMKXHUH, BILRNMKXHUH) ONRNTUZJVLD(object a);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		object GetLocalPlayer();

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool TJTYNZBKWRC(object a);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		string XHULETXXDPM(object a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface EUPPEJHBPML
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool RQKGWVSDJOE
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface NKMPTCHVIDV
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		EWLZMGNRPPO? LVYKDVFRYUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface EWLZMGNRPPO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		IEnumerable<string> YLKZOUFEMHV
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string PLNXNVHYOKJ(string a);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DFRJEEEQPBO(string a, string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface KLDEYUYBTMR
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CircuitsColor FARBAUSWIQE(int a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int ZXVSRXUXSKA([In] CircuitsColor circuitsColor);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface ZCXIDDXNHTD
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		LegacyCV2Result<None> SetEnabled(QVMTSXADWLM e, bool setEnabled);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public readonly struct RecRoomDynamicDeps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly TNQBFZGPRNT EngineDeps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly KLDEYUYBTMR GameDeps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly KCXVZIKDHAS PlayerDeps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly DynamicCircuitsErrRegistry DynamicErr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly DynamicCircuitsErrDefs DynamicErrDefs;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x28642D0", Offset = "0x28636D0", VA = "0x1828642D0")]
		public RecRoomDynamicDeps(TNQBFZGPRNT engineDeps, KLDEYUYBTMR gameDeps, KCXVZIKDHAS playerDeps, [In] DynamicCircuitsErrRegistry dynamicErr, DynamicCircuitsErrDefs dynamicErrDefs)
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

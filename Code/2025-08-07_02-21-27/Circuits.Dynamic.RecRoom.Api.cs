using System;
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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DC3EF0", Offset = "0x2DC2AF0", VA = "0x182DC3EF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
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
		public Id32<UCWLUIIGNGH> ConvertedFromLegacy;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2DC3EB0", Offset = "0x2DC2AB0", VA = "0x182DC3EB0")]
		public static DynamicCircuitsErrRegistry New()
		{
			return default(DynamicCircuitsErrRegistry);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2DC3E70", Offset = "0x2DC2A70", VA = "0x182DC3E70")]
		[CompilerGenerated]
		internal static Id32<UCWLUIIGNGH> IRYNTKTKRVN(int a)
		{
			return default(Id32<UCWLUIIGNGH>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface BTTYMEWUHLY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface TOWIETVTGBO
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		int FYBKRASLHAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		int DPRQTXYXINB
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		float QARULLPJMKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		float FHCHDVNJTRW
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool IGRETPAVNKM
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool LQANKSMUAYI
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool NBDDYYZLCNE
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		LegacyCV2Result<None> CV2SetMaxAmmo(ABZCVUHNAYT e, int max);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		LegacyCV2Result<None> CV2SetCurrentAmmo(ABZCVUHNAYT e, int current);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "9")]
		LegacyCV2Result<None> CV2SetADSEnabled(ABZCVUHNAYT e, bool enabled);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "10")]
		LegacyCV2Result<None> CV2SetCanReload(ABZCVUHNAYT e, bool canReload);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "11")]
		LegacyCV2Result<None> CV2SetContinuousFire(ABZCVUHNAYT e, bool continuousFire);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "12")]
		LegacyCV2Result<None> CV2SetRateOfFire(ABZCVUHNAYT e, float rate);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "13")]
		LegacyCV2Result<None> CV2SetReloadDuration(ABZCVUHNAYT e, float time);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface HYPMOBBPYIS
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		string LIOFPWAZXYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		LegacyCV2Result<None> SetHandleControlLabel(ABZCVUHNAYT e, string label);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface CRNDIFJOJOT
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		(BTTYMEWUHLY, BTTYMEWUHLY, BTTYMEWUHLY, BTTYMEWUHLY, BTTYMEWUHLY) PDBGPVZPNTU(object a);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		object GetLocalPlayer();

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool SNDHVNFTAHT(object a);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		string CCEXGIURFJP(object a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface ZCFDAPHNYNK
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool BHQLHQYKBZZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface RRYJLIWAQJW
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CircuitsColor QRZOZMRWBZV(int a);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int LYIVSMXDXKV([In] CircuitsColor circuitsColor);
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface FOHOLLFCENE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		LegacyCV2Result<None> SetEnabled(ABZCVUHNAYT e, bool setEnabled);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public readonly struct RecRoomDynamicDeps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly XEVORPDPVDW EngineDeps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly RRYJLIWAQJW GameDeps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly CRNDIFJOJOT PlayerDeps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly DynamicCircuitsErrRegistry DynamicErr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly DynamicCircuitsErrDefs DynamicErrDefs;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2DC3F70", Offset = "0x2DC2B70", VA = "0x182DC3F70")]
		public RecRoomDynamicDeps(XEVORPDPVDW engineDeps, RRYJLIWAQJW gameDeps, CRNDIFJOJOT playerDeps, [In] DynamicCircuitsErrRegistry dynamicErr, DynamicCircuitsErrDefs dynamicErrDefs)
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

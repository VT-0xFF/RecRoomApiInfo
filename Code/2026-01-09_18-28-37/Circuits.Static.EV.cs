using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Circuits.Static.Api;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures.Performance;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		[Cpp2IlInjected.Address(RVA = "0x28EA9B0", Offset = "0x28E9DB0", VA = "0x1828EA9B0")]
		public NullableAttribute(byte P_0)
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

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACDB00", Offset = "0xACCF00", VA = "0x180ACDB00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.EV.Lang
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class WPKDFKUISLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x28EB240", Offset = "0x28EA640", VA = "0x1828EB240")]
		public static Id32<GAODAGDLSAS> DRAUHALUTBG(this int a)
		{
			return default(Id32<GAODAGDLSAS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x28EB280", Offset = "0x28EA680", VA = "0x1828EB280")]
		public static Id32<KBHHKAZFCJZ> EZCMQONYTTB(this int a)
		{
			return default(Id32<KBHHKAZFCJZ>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DebuggerDisplay("Class: {ClassString}, Bool: {Bool}, I32: {I32}, F32: {F32}")]
	public readonly struct Variant : IEquatable<Variant>, VHVQTMURGOZ<Variant>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly object? _class;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly Union32 _struct;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private string JDYMVXQCBCT
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x28EB1B0", Offset = "0x28EA5B0", VA = "0x1828EB1B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool FIGTNOUHVBY
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xBEF460", Offset = "0xBEE860", VA = "0x180BEF460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public int KVUVTLEZIYU
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xC9E840", Offset = "0xC9DC40", VA = "0x180C9E840")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float EVTBSDNIGCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x28EAD10", Offset = "0x28EA110", VA = "0x1828EAD10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string? JRGFAKTXMDF
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x28EAED0", Offset = "0x28EA2D0", VA = "0x1828EAED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ReadOnlyArray<byte>? QDCHQLCOZTP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x28EAD20", Offset = "0x28EA120", VA = "0x1828EAD20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x28EB210", Offset = "0x28EA610", VA = "0x1828EB210")]
		private Variant(object? @class, Union32 @struct)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x28EAC70", Offset = "0x28EA070", VA = "0x1828EAC70")]
		private static Variant GNJBZCQMVWT(Union32 a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28EAA30", Offset = "0x28E9E30", VA = "0x1828EAA30")]
		public static Variant ALXGZNVNPVE(bool a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28EB160", Offset = "0x28EA560", VA = "0x1828EB160")]
		public static Variant XLHESBZJKQY(int a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", VA = "0x1828EAAD0")]
		public static Variant CVQJPVKBUER(float a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28EAF00", Offset = "0x28EA300", VA = "0x1828EAF00")]
		public static Variant YMSORPRDUMX(string a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28EAF00", Offset = "0x28EA300", VA = "0x1828EAF00")]
		public static Variant PFJIPPISJSV(byte[] a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28EADE0", Offset = "0x28EA1E0", VA = "0x1828EADE0")]
		public static Variant KBJQMVZCTTU(int a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28EAAA0", Offset = "0x28E9EA0", VA = "0x1828EAAA0")]
		public static Variant CNAKZZFNWAJ()
		{
			return default(Variant);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28EAE60", Offset = "0x28EA260", VA = "0x1828EAE60")]
		public static bool NAQFJJXEQSO([In] Variant lhs, [In] Variant rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28EAC00", Offset = "0x28EA000", VA = "0x1828EAC00", Slot = "4")]
		public bool Equals(Variant other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x28EAE60", Offset = "0x28EA260", VA = "0x1828EAE60")]
		public bool UEETEZFSGGI([In] Variant other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x28EAB20", Offset = "0x28E9F20", VA = "0x1828EAB20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28EACA0", Offset = "0x28EA0A0", VA = "0x1828EACA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28EAF30", Offset = "0x28EA330", VA = "0x1828EAF30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28EAE60", Offset = "0x28EA260", VA = "0x1828EAE60", Slot = "5")]
		private bool VCOXQVOZMOZ([In] Variant other)
		{
			return default(bool);
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

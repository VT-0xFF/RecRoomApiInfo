using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Debugging;
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
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A50", Offset = "0xAF4A50", VA = "0x180AF5A50")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.All.Injection.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class ATUYFGYIQSH
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class HQENANIBZDY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public LogFlags QVMQXOCXAEO;

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public HQENANIBZDY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x2895640", Offset = "0x2894640", VA = "0x182895640")]
			internal bool IPXBVWHSPMZ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2895590", Offset = "0x2894590", VA = "0x182895590")]
			internal void IPRUYPNVGBQ(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x28954E0", Offset = "0x28944E0", VA = "0x1828954E0")]
			internal bool IPMOBITXWQH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2895430", Offset = "0x2894430", VA = "0x182895430")]
			internal void IPHHECAANEY(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2895380", Offset = "0x2894380", VA = "0x182895380")]
			internal bool IPCAGVGDDTP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x28952D0", Offset = "0x28942D0", VA = "0x1828952D0")]
			internal void IOWTJOMFUIG(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static readonly LogDeps QSHZKWMVMOA;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2894E90", Offset = "0x2893E90", VA = "0x182894E90")]
		private static LogDelegates VSKJPSUBXTV(LogFlags a)
		{
			return default(LogDelegates);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x28945D0", Offset = "0x28935D0", VA = "0x1828945D0")]
		private static LogDeps HGDWZUJLFSU()
		{
			return default(LogDeps);
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

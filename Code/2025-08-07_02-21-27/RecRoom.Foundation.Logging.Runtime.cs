using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Foundation
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public readonly struct LogForJob
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool EnabledInHierarchy
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x118DBC0", Offset = "0x118C7C0", VA = "0x18118DBC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8A1D650", Offset = "0x8A1C250", VA = "0x188A1D650")]
		public static implicit operator LogForJob(Log log)
		{
			return default(LogForJob);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8A1D910", Offset = "0x8A1C510", VA = "0x188A1D910")]
		public LogForJob(Log log)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8A1D850", Offset = "0x8A1C450", VA = "0x188A1D850")]
		public void WEJRWAXQWGB([In] FixedString128Bytes str)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8A1D760", Offset = "0x8A1C360", VA = "0x188A1D760")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TGJQOPPHXBK([In] FixedString128Bytes str)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8A1D670", Offset = "0x8A1C270", VA = "0x188A1D670")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void FHJCSUMYQXW([In] FixedString128Bytes str)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A1D770", Offset = "0x8A1C370", VA = "0x188A1D770")]
		private void VUWDRRTMMQP([In] FixedString128Bytes str)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8A1D680", Offset = "0x8A1C280", VA = "0x188A1D680")]
		private void NDVMJKETNGL([In] FixedString128Bytes str)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class DQACYOKKDWD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8A1D650", Offset = "0x8A1C250", VA = "0x188A1D650")]
		public static LogForJob VHQBJQRQHPA(this Log a)
		{
			return default(LogForJob);
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

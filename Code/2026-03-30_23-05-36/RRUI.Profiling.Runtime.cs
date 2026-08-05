using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Profiling.Visualization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RRUI.Profiling.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class EMZYDLDRERQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly KAAVETZHQLO DCDYZKAWRPK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static KAAVETZHQLO AXAIYRDGPZN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x91CB010", Offset = "0x91C9E10", VA = "0x1891CB010")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct PageChildrenStats
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public int PageDepthInHierarchy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int TotalChildren;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int TotalEnabledChildren;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public int TotalDisabledChildren;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int TotalComponentCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int MaxHierarchyDepth;
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface JFAMPLDPAOA
	{
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

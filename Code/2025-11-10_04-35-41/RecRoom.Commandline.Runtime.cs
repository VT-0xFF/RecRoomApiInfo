using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.NoEngine.Common;
using UJect;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Commandline_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x81994E0", Offset = "0x81988E0", VA = "0x1881994E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x26F2710", Offset = "0x26F1B10", VA = "0x1826F2710")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface GCOQKFPMCFV
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string QMSSRZHISID(string a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool HHEDLKRYLDF(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RecRoom.NoEngine.Common.Preserve]
	public class CommandLineManager : GCOQKFPMCFV
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static List<string> JUWVSYUDDWQ;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static string[] EOXFYOZJCUP;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static string[] MCTWIJTGRAP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static string[] GOCTKSVQRDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x81994D0", Offset = "0x81988D0", VA = "0x1881994D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static string[] PQOSWKJWZQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x81991B0", Offset = "0x81985B0", VA = "0x1881991B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x81993E0", Offset = "0x81987E0", VA = "0x1881993E0")]
		[CVOOPLRRRUK.Root]
		internal static void UUDUQLMHCPR(XRSJVGYQFTW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8198F40", Offset = "0x8198340", VA = "0x188198F40")]
		internal static string[] JDWUWDMUIWD(string[] a, string[] b, List<string> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8199050", Offset = "0x8198450", VA = "0x188199050", Slot = "4")]
		private string MBOMPNLMWFG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8199100", Offset = "0x8198500", VA = "0x188199100")]
		public static string QMSSRZHISID(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8199340", Offset = "0x8198740", VA = "0x188199340", Slot = "5")]
		private bool RRDSZVSIPBO(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8198EA0", Offset = "0x81982A0", VA = "0x188198EA0")]
		public static bool HHEDLKRYLDF(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public CommandLineManager()
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

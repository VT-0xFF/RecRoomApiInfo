using System;
using System.Reflection;
using Cpp2IlInjected;
using Newtonsoft.Json.Linq;
using UnityGLTF.Plugins;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityGLTF.Interactivity.VisualScripting
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[NonRatifiedPlugin(null)]
	public class VisualScriptingExportPlugin : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override JToken FMODCACLGEQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xB86C670", Offset = "0xB86B070", VA = "0x18B86C670", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool TKCLWUCJLDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool NMIBNTBUWEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public override bool RRNGQKZARGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override string RLENMKFRGES
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xB86C840", Offset = "0xB86B240", VA = "0x18B86C840", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override string UZNYKMCUYRT
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xB86C810", Offset = "0xB86B210", VA = "0x18B86C810", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xB86C610", Offset = "0xB86B010", VA = "0x18B86C610", Slot = "14")]
		public override IOJCCXFBITW CreateInstance(YAQTRRFQGDA context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x19CC7A0", Offset = "0x19CB1A0", VA = "0x1819CC7A0")]
		public VisualScriptingExportPlugin()
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

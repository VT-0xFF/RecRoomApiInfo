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
		public override JToken GWGUGQEHOVI
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xA27B4E0", Offset = "0xA27A2E0", VA = "0x18A27B4E0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool HDBUMCCJOKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool RYNJTFKPZPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public override bool IOHLIIHJALJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override string DKTFULDZQCQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA27B6B0", Offset = "0xA27A4B0", VA = "0x18A27B6B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override string DQPGZQUGAMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA27B680", Offset = "0xA27A480", VA = "0x18A27B680", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA27B480", Offset = "0xA27A280", VA = "0x18A27B480", Slot = "14")]
		public override NIQOXFUJQOW CreateInstance(VWVEGYCAVXS context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1983170", Offset = "0x1981F70", VA = "0x181983170")]
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

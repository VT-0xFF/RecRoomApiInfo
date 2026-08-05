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
		public override JToken FFYIFJGVZXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xB614C50", Offset = "0xB614050", VA = "0x18B614C50", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool BYWDFIHJUYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool MOVJBQXITYX
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public override bool DIPZIQWEBMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override string WZGBLGIJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xB614E20", Offset = "0xB614220", VA = "0x18B614E20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override string GSJQWDIOTQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xB614DF0", Offset = "0xB6141F0", VA = "0x18B614DF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xB614BF0", Offset = "0xB613FF0", VA = "0x18B614BF0", Slot = "14")]
		public override HMEEPODDUBT CreateInstance(SKRDRZRTZVR context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x19A5060", Offset = "0x19A4460", VA = "0x1819A5060")]
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

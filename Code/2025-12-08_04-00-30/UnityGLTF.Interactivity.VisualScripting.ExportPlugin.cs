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
		public override JToken VMBGJEGYZWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x9F32880", Offset = "0x9F31080", VA = "0x189F32880", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool MVQOJPYSRSA
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool FUFYAALZRYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public override bool BIRGBVNSOGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override string NROFRYQVSOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9F32A50", Offset = "0x9F31250", VA = "0x189F32A50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override string HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9F32A20", Offset = "0x9F31220", VA = "0x189F32A20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9F32820", Offset = "0x9F31020", VA = "0x189F32820", Slot = "14")]
		public override NVPVEURSWXA CreateInstance(QEOAQKJBNBK context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x16BAA20", Offset = "0x16B9220", VA = "0x1816BAA20")]
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
